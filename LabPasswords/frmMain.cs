using LabPasswords;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

using Newtonsoft.Json;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;
using System.Media;

namespace LabPasswords
{
    public partial class frmMain : Form
    {
        private String PasswordsDataFullFilename
        {
            get
            {
                return Path.Combine(LabPasswords.Properties.Settings.Default.PasswordsDropboxFolder, mPasswordsFilename);
            }
        }

        private String getPasswordsDataBackupFilename(int version)
        {
            StringBuilder backupFilenname = new StringBuilder();
            backupFilenname.Append("bk").Append(version).Append(".").Append(mPasswordsFilename);
            return Path.Combine(LabPasswords.Properties.Settings.Default.PasswordsDropboxFolder, backupFilenname.ToString());
        }


        private int mLastPasswordID = 0;
        private int getNextPasswordID
        {
            get
            {
                mLastPasswordID++;
                return mLastPasswordID;
            }
        }
        private int mLastUserID = 0;
        private int getNextUserID
        {
            get
            {
                mLastUserID++;
                return mLastUserID;
            }
        }

        private const String mPasswordsFilename = "PasswordsDatafile.txt";
        //private const String iv = "74172ca8e67761d2";
        private String mKey = "";

        private clsLabPasswords mLabPasswords;

        private List<clsPasswordItem> mUserAllPasswordItems;
        private List<clsPasswordItem> mUserCreditCards;
        private List<clsPasswordItem> mUserGeneralAccounts;
        private List<clsPasswordItem> mUserWebsites;
        private List<clsPasswordItem> mUserSoftware;

        //private List<clsUsers> mUsersList;
        private List<clsItemTypes> mItemTypesList;

        private BindingSource bsPasswordItems = new BindingSource();
        private List<clsSelectedItem> mSelectedItems;
        private clsSelectedItem mSelectedItem;
        private clsPasswordItem mSelectedLabPasswordsItem;
        private clsItemTypes mActiveItemType;
        private int mActiveItemTypeID;

        private clsUsers mActiveUser;

        private bool mSuspendHandlers = true;
        private bool mIsDirty = false;
        private FileSystemWatcher mWatcher = null;

        private const int ALL_ITEM_TYPES = 0;
        private const int CREDIT_CARDS = 1;
        private const int GENERAL_ACCOUNTS = 2;
        private const int SOFTWARE = 3;
        private const int WEBSITES = 4;

        private const int CONTROL_MARGIN = 7;
        private int HOME_TOP = 4;
        private int HOME_LEFT = 95;

        public frmMain()
        {
            InitializeComponent();

        }

        #region Form Events
        private void frmMain_Load(object sender, EventArgs e)
        {
            TextWriterTraceListener myWriter = new TextWriterTraceListener(System.Console.Out);
            Debug.Listeners.Add(myWriter);

            initializeApp();

            // restore form's window state
            this.WindowState = LabPasswords.Properties.Settings.Default.frmMainWindowState;
            if (this.WindowState == FormWindowState.Minimized)
            {
                // Never start minimized
                this.WindowState = FormWindowState.Normal;
            }
            this.DesktopBounds =
                new Rectangle(LabPasswords.Properties.Settings.Default.frmMainLocation,
            LabPasswords.Properties.Settings.Default.frmMainSize);

           // showItemDetail(mActiveItemTypeID);

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveSelectedItems(mSelectedItems);
            if (mIsDirty)
            {
                Debug.WriteLine("frmMain_FormClosing WRITE PASSWORDS FILE");
                writePasswordfile(false);
            }

            LabPasswords.Properties.Settings.Default.frmMainWindowState = this.WindowState;
            if (this.WindowState == FormWindowState.Normal)
            {
                LabPasswords.Properties.Settings.Default.frmMainLocation = this.Location;
                LabPasswords.Properties.Settings.Default.frmMainSize = this.Size;
            }
            LabPasswords.Properties.Settings.Default.Save();
        }

        #endregion

        #region Initilzation Methods
        private void initializeApp()
        {
            resizeForm();

        RESTART:
            mKey = getPasswordFromUser();
            if (!mKey.Equals(""))
            {
                txtIsDirty.BackColor = Color.Green;

                if (LabPasswords.Properties.Settings.Default.PasswordsDropboxFolder.Equals(""))
                {
                    selectPasswordsFilePath();
                }

                // Two scenarios: 1) Passwords data file exists, or 2) it does not exist

                if (File.Exists(PasswordsDataFullFilename))
                {
                    // 1) the Passwords file exists ... read and sort the file            
                    if (!readPasswordfile())
                    {
                        // failed to read Passwords file ... try again.
                        goto RESTART;
                    }
                }
                else
                {
                    // 2) the Passwords file does not exist
                    mLabPasswords = new clsLabPasswords();
                    createNewUser(true);
                }

                // set active user
                int activeUserID = LabPasswords.Properties.Settings.Default.ActiveUserID;
                if (activeUserID > 0)
                {
                    mActiveUser = findUser(activeUserID);
                }
                else
                {
                    // active user is not set, try and select the first user i
                    if (mLabPasswords.Users.Count > 0)
                    {
                        mActiveUser = mLabPasswords.Users[0];
                        LabPasswords.Properties.Settings.Default.ActiveUserID = mActiveUser.UserID;
                        LabPasswords.Properties.Settings.Default.Save();
                    }
                }

                fillPasswordLists();
                fillUsersAndItemTypes();
                bsPasswordItems.PositionChanged += new System.EventHandler(bsPasswordItems_PositionChanged);

                bindPasswordItemControls();
                mSelectedItems = loadSelectedItems(); // also sets mSelectedItem
                setTextChangeListeners();

                mActiveItemTypeID = LabPasswords.Properties.Settings.Default.ActiveItemTypeID;
                //int activeUserID = LabPasswords.Properties.Settings.Default.ActiveUserID;

                if (mSelectedItem != null)
                {
                    int position = mSelectedItem.ItemPosition;
                    if (position > -1)
                    {
                        if (bsPasswordItems.Count > position)
                        {
                            bsPasswordItems.Position = position;
                        }
                        else
                        {
                            bsPasswordItems.Position = 0;
                        }
                    }
                    else
                    {
                        if (bsPasswordItems.Count > 0)
                        {
                            bsPasswordItems.Position = 0;
                        }
                    }

                }

                setUpFileListener();
                mSuspendHandlers = false;
                bsPasswordItems_PositionChanged(new object(), new EventArgs());
            }
        }

        private clsUsers findUser(int userID)
        {
            clsUsers foundUser = null;

            if (mLabPasswords != null)
            {
                foreach (clsUsers user in mLabPasswords.Users)
                {
                    if (user.UserID == userID)
                    {
                        // User found
                        foundUser = user;
                        break;
                    }
                }
            }
            return foundUser;
        }

        private clsPasswordItem findPasswordsItem(int itemID)
        {
            clsPasswordItem foundItem = null;

            if (mLabPasswords != null)
            {
                foreach (clsPasswordItem item in mLabPasswords.PasswordItems)
                {
                    if (item.ID == itemID)
                    {
                        // User found
                        foundItem = item;
                        break;
                    }
                }
            }
            return foundItem;
        }

        private void createNewUser(bool exitApplicationOnCancel)
        {
            String newUserName = "";
            frmGetNewUserName dialog = new frmGetNewUserName(mLabPasswords.Users);
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                mSuspendHandlers = true;
                newUserName = dialog.newUserName;
                clsUsers newUser = new clsUsers();
                newUser.UserID = getNextUserID;
                newUser.UserName = newUserName;
                mLabPasswords.Users.Add(newUser);

                sortUsers();
                savePasswordsFileAsync(false);

                mActiveUser = newUser;
                LabPasswords.Properties.Settings.Default.ActiveUserID = mActiveUser.UserID;
                LabPasswords.Properties.Settings.Default.Save();

                //mUsersList = mLabPasswords.Users;
                cbxUsersFilter.DataSource = null;
                cbxUsersFilter.DataSource = mLabPasswords.Users;
                cbxUsersFilter.SelectedIndex = getUsersFilterSelectedIndex();

                mSuspendHandlers = false;
            }
            else
            {
                if (exitApplicationOnCancel)
                {
                    StringBuilder msg = new StringBuilder();
                    msg.Append("Sorry, but unable to proceed without a user name.")
                        .Append(System.Environment.NewLine).Append(System.Environment.NewLine)
                        .Append("Quitting the application!");
                    MessageBox.Show(msg.ToString(), "No User Name Provided", MessageBoxButtons.OK);
                    Application.Exit();
                }
            }
        }

        private void deleteUser()
        {
            // Confirm that the active user will be delteded
            StringBuilder msg = new StringBuilder();
            msg.Append("Do you want to permanently delete user \"")
                .Append(mActiveUser.UserName).Append("\"?");
            if (MessageBox.Show(msg.ToString(), "Confirm Deleting User", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Delete all Passwords items assocated with the active user
                List<int> itemIDsForDeletion = new List<int>();
                // Find all items assocated with the active user
                foreach (clsPasswordItem item in mLabPasswords.PasswordItems)
                {
                    if (item.User_ID == mActiveUser.UserID)
                    {
                        itemIDsForDeletion.Add(item.ID);
                    }
                }

                foreach (int ID in itemIDsForDeletion)
                {
                    deletePasswordItem(ID);
                }

                // Delete tha active user
                deleteUser(mActiveUser.UserID);

                // Refresh the User's comboBox list

                // Select the first user in the comboBox list
                if (mLabPasswords.Users.Count > 0)
                {
                    mActiveUser = mLabPasswords.Users[0];
                    LabPasswords.Properties.Settings.Default.ActiveUserID = mActiveUser.UserID;
                    LabPasswords.Properties.Settings.Default.Save();

                    cbxUsersFilter.DataSource = null;
                    cbxUsersFilter.DataSource = mLabPasswords.Users;
                    cbxUsersFilter.SelectedIndex = 0;
                }
                else
                {
                    mActiveUser = null;
                    cbxUsersFilter.DataSource = null;
                    cbxUsersFilter.SelectedIndex = -1;
                }




            }
        }

        private void deletePasswordItem(int itemID)
        {
            for (int i = mLabPasswords.PasswordItems.Count - 1; i >= 0; i--)
            {
                if (mLabPasswords.PasswordItems[i].ID == itemID)
                {
                    mLabPasswords.PasswordItems.RemoveAt(i);
                    break;
                }
            }
        }

        private void deleteUser(int userID)
        {
            for (int i = mLabPasswords.Users.Count - 1; i >= 0; i--)
            {
                if (mLabPasswords.Users[i].UserID == userID)
                {
                    mLabPasswords.Users.RemoveAt(i);
                    break;
                }
            }
        }

        private void backupPasswordsDataFile(String key)
        {
            if (needsBackingUp(key))
            {
                Debug.WriteLine("frmMain: backupPasswordsDataFile: file backup STARTING.");
                int maxNumberOfBackupFiles = LabPasswords.Properties.Settings.Default.MaxNumberOfBackupFiles;
                String sourceBackupFilename = "";
                String destinationBackupFilename = "";
                for (int i = maxNumberOfBackupFiles; i > 0; i--)
                {
                    destinationBackupFilename = getPasswordsDataBackupFilename(i);
                    if (i == 1)
                    {
                        sourceBackupFilename = PasswordsDataFullFilename;
                        File.Copy(sourceBackupFilename, destinationBackupFilename, true);
                    }
                    else
                    {
                        sourceBackupFilename = getPasswordsDataBackupFilename(i - 1);
                        if (File.Exists(sourceBackupFilename))
                        {
                            File.Copy(sourceBackupFilename, destinationBackupFilename, true);
                        }
                    }
                }
            }
            else
            {
                Debug.WriteLine("frmMain: backupPasswordsDataFile: Backup NOT NEEDED.");
            }
        }

        private bool needsBackingUp(String key)
        {
            return !clsFormattingMethods.PasswordsFileCompare(key, mLabPasswords, getPasswordsDataBackupFilename(1));
        }

        private void setUpFileListener()
        {
            // Create a new FileSystemWatcher and set its properties.
            mWatcher = new FileSystemWatcher();
            // make the watcher thread safe
            mWatcher.SynchronizingObject = cbxUsersFilter;
            mWatcher.Path = LabPasswords.Properties.Settings.Default.PasswordsDropboxFolder;
            // Watch for changes in LastWrite times
            mWatcher.NotifyFilter = NotifyFilters.LastWrite;
            // Only watch Password data file.
            mWatcher.Filter = mPasswordsFilename;

            // Add event handlers.
            addFileWatcherHandlers();


            // Begin watching.
            mWatcher.EnableRaisingEvents = true;
        }

        private void addFileWatcherHandlers()
        {
            if (mWatcher != null)
            {
                mWatcher.Changed += new FileSystemEventHandler(OnFileChanged);
                mWatcher.Created += new FileSystemEventHandler(OnFileChanged);
            }
        }

        private void removeFileWatcherHandlers()
        {
            if (mWatcher != null)
            {
                mWatcher.Changed -= new FileSystemEventHandler(OnFileChanged);
                mWatcher.Created -= new FileSystemEventHandler(OnFileChanged);
            }
        }

        private void OnFileChanged(object sender, FileSystemEventArgs e)
        {
            Debug.WriteLine("frmMain: OnFileChanged Event");
            updateUI();
            //MessageBox.Show(mPasswordsFilename + " changed", "FileSystemWatcher", MessageBoxButtons.OK);
        }

        private void updateUI()
        {
            // read the changed Passwords file
            if (readPasswordfile())
            {
                mSuspendHandlers = true;
                sortPasswordfile();
                fillPasswordLists();
                fillUsersAndItemTypes();
                mSuspendHandlers = false;
            }
        }

        private string getPasswordFromUser()
        {
            String key = "";
            frmGetPassword dialog = new frmGetPassword();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                Application.Exit();
            }
            else if (result == DialogResult.OK)
            {
                key = dialog.passwordKey;
            }
            return key;
        }


        private void setTextChangeListeners()
        {
            txtItemName.Validating += new System.ComponentModel.CancelEventHandler(txtItemName_Validating);

            txtCreditCardAltPhoneNumber.KeyPress += new KeyPressEventHandler(numericTxtBox_KeyPress);
            txtCreditCardPrimaryPhoneNumber.KeyPress += new KeyPressEventHandler(numericTxtBox_KeyPress);

            txtGeneralAccountAltPhoneNumber.KeyPress += new KeyPressEventHandler(numericTxtBox_KeyPress);
            txtGeneralAccountPrimaryPhoneNumber.KeyPress += new KeyPressEventHandler(numericTxtBox_KeyPress);

            txtCreditCardAccountNumber.KeyPress += new KeyPressEventHandler(numericTxtBox_KeyPress);
            txtCreditCardExpirationMonth.KeyPress += new KeyPressEventHandler(numericTxtBox_KeyPress);
            txtCreditCardExpirationYear.KeyPress += new KeyPressEventHandler(numericTxtBox_KeyPress);
        }

        private void passwordItemChanged(object sender, PropertyChangedEventArgs e)
        {
            Debug.WriteLine("PASSWORDItemChanged");
            mIsDirty = true;
            txtIsDirty.BackColor = Color.Red;
        }

        void txtItemName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Debug.WriteLine("txtItemName_Validating");
            String textBoxText = txtItemName.Text.Trim();
            if (textBoxText.Length == 0)
            {
                e.Cancel = true;
                SystemSounds.Beep.Play();
            }
            else if (newNameExists(textBoxText))
            {
                e.Cancel = true;
                SystemSounds.Beep.Play();
                String msg = "\"" + textBoxText + "\"" + " already exists." + Environment.NewLine + "Please enter a unique name.";
                String title = "Invalid Name";
                MessageBox.Show(msg, title);
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void bindPasswordItemControls()
        {
            try
            {
                txtItemName.DataBindings.Add("Text", bsPasswordItems, "Name");

                Binding bindingSoftwareKeyCode = new Binding("Text", bsPasswordItems, "SoftwareKeyCode");
                // Add the delegates to the event.
                bindingSoftwareKeyCode.Format += new ConvertEventHandler(FormatSoftwareKeyCode);
                bindingSoftwareKeyCode.Parse += new ConvertEventHandler(UnformatSoftwareKeyCode);
                txtSoftwareKeyCode.DataBindings.Add(bindingSoftwareKeyCode);
                updnSoftwareKeyCodeSubgroupLength.DataBindings.Add("Value", bsPasswordItems, "SoftwareSubgroupLength");

                Binding bindingCreditCardAccountNumber = new Binding("Text", bsPasswordItems, "CreditCardAccountNumber");
                // Add the delegates to the event.
                bindingCreditCardAccountNumber.Format += new ConvertEventHandler(FormatCreditCard);
                bindingCreditCardAccountNumber.Parse += new ConvertEventHandler(UnformatCreditCard);
                txtCreditCardAccountNumber.DataBindings.Add(bindingCreditCardAccountNumber);
                txtCreditCardSecurityCode.DataBindings.Add("Text", bsPasswordItems, "CreditCardSecurityCode");
                txtCreditCardExpirationMonth.DataBindings.Add("Text", bsPasswordItems, "CreditCardExpirationMonth");
                txtCreditCardExpirationYear.DataBindings.Add("Text", bsPasswordItems, "CreditCardExpirationYear");

                Binding bindingCreditCardPrimaryPhoneNumber = new Binding("Text", bsPasswordItems, "PrimaryPhoneNumber");
                // Add the delegates to the event.
                bindingCreditCardPrimaryPhoneNumber.Format += new ConvertEventHandler(FormatPhoneNumber);
                bindingCreditCardPrimaryPhoneNumber.Parse += new ConvertEventHandler(UnformattedPhoneNumber);
                txtCreditCardPrimaryPhoneNumber.DataBindings.Add(bindingCreditCardPrimaryPhoneNumber);
                Binding bindingCreditCardAlternatePhoneNumber = new Binding("Text", bsPasswordItems, "AlternatePhoneNumber");
                // Add the delegates to the event.
                bindingCreditCardAlternatePhoneNumber.Format += new ConvertEventHandler(FormatPhoneNumber);
                bindingCreditCardAlternatePhoneNumber.Parse += new ConvertEventHandler(UnformattedPhoneNumber);
                txtCreditCardAltPhoneNumber.DataBindings.Add(bindingCreditCardAlternatePhoneNumber);

                txtGeneralAccountNumber.DataBindings.Add("Text", bsPasswordItems, "GeneralAccountNumber");
                Binding bindingGeneralAccountPrimaryPhoneNumber = new Binding("Text", bsPasswordItems, "PrimaryPhoneNumber");
                // Add the delegates to the event.
                bindingGeneralAccountPrimaryPhoneNumber.Format += new ConvertEventHandler(FormatPhoneNumber);
                bindingGeneralAccountPrimaryPhoneNumber.Parse += new ConvertEventHandler(UnformattedPhoneNumber);
                txtGeneralAccountPrimaryPhoneNumber.DataBindings.Add(bindingGeneralAccountPrimaryPhoneNumber);
                Binding bindingGeneralAccountAlternatePhoneNumber = new Binding("Text", bsPasswordItems, "AlternatePhoneNumber");
                // Add the delegates to the event.
                bindingGeneralAccountAlternatePhoneNumber.Format += new ConvertEventHandler(FormatPhoneNumber);
                bindingGeneralAccountAlternatePhoneNumber.Parse += new ConvertEventHandler(UnformattedPhoneNumber);
                txtGeneralAccountAltPhoneNumber.DataBindings.Add(bindingGeneralAccountAlternatePhoneNumber);

                txtWebsiteURLAddress.DataBindings.Add("Text", bsPasswordItems, "WebsiteURL");
                txtWebsiteUserID.DataBindings.Add("Text", bsPasswordItems, "WebsiteUserID");
                txtWebsitePassword.DataBindings.Add("Text", bsPasswordItems, "WebsitePassword");

                txtComments.DataBindings.Add("Text", bsPasswordItems, "Comments");
            }
            catch (Exception)
            {
                // Do nothing
            }
        }

        private void fillUsersAndItemTypes()
        {
            cbxUsersFilter.DataSource = mLabPasswords.Users;
            cbxUsersFilter.SelectedIndex = getUsersFilterSelectedIndex();

            String[] ITEM_TYPES = new String[] { "[ALL]", "Credit Cards", "General Accounts", "Software", "Websites" };
            mItemTypesList = new List<clsItemTypes>();
            for (int i = 0; i < 5; i++)
            {
                clsItemTypes item = new clsItemTypes();
                item.ItemType = ITEM_TYPES[i];
                item.ItemTypeID = i;
                mItemTypesList.Add(item);
            }
            cbxItemTypes.DataSource = mItemTypesList;
            cbxItemTypes.SelectedIndex = getItemTypesSelectedIndex();

            showPasswordItems(cbxItemTypes.SelectedIndex);
        }

        private void fillPasswordLists()
        {
            mUserAllPasswordItems = new List<clsPasswordItem>();
            mUserCreditCards = new List<clsPasswordItem>();
            mUserGeneralAccounts = new List<clsPasswordItem>();
            mUserSoftware = new List<clsPasswordItem>();
            mUserWebsites = new List<clsPasswordItem>();

            mLastPasswordID = -1;
            mLastUserID = -1;

            foreach (clsPasswordItem item in mLabPasswords.PasswordItems)
            {
                if (item.ID > mLastPasswordID)
                {
                    mLastPasswordID = item.ID;
                }

                if (item.User_ID == LabPasswords.Properties.Settings.Default.ActiveUserID)
                {
                    mUserAllPasswordItems.Add(item);
                    switch (item.ItemType_ID)
                    {
                        case 1:
                            // Credit Cards
                            mUserCreditCards.Add(item);
                            break;

                        case 2:
                            // General Accounts
                            mUserGeneralAccounts.Add(item);
                            break;

                        case 3:
                            // Software
                            mUserSoftware.Add(item);
                            break;

                        case 4:
                            // Websites
                            mUserWebsites.Add(item);
                            break;
                    }
                }
            }

            foreach (clsUsers user in mLabPasswords.Users)
            {
                if (user.UserID > mLastUserID)
                {
                    mLastUserID = user.UserID;
                }
            }
        }

        public void sortPasswordfile()
        {
            sortPasswordItmes();
            sortUsers();
        }

        private void sortPasswordItmes()
        {
            if (mLabPasswords.PasswordItems.Count > 0)
            {
                //mLabPasswords.PasswordItems.Sort((a, b) => String.Compare(a.Name.ToUpper(), b.Name.ToUpper()));
                mLabPasswords.PasswordItems.Sort((a, b) =>
                {
                    int ret = a.Name.ToUpper().CompareTo(b.Name.ToUpper());
                    if (ret == 0)
                    {
                        ret = a.ID - b.ID;
                    }
                    return ret;
                });
            }
        }

        private void sortUsers()
        {
            if (mLabPasswords.Users.Count > 0)
            {
                //mLabPasswords.Users.Sort((a, b) => String.Compare(a.UserName.ToUpper(), b.UserName.ToUpper()));
                mLabPasswords.Users.Sort((a, b) =>
                {
                    int ret = a.UserName.ToUpper().CompareTo(b.UserName.ToUpper());
                    if (ret == 0) ret = a.UserID.CompareTo(b.UserID);
                    return ret;
                });
            }
        }
        #endregion

        private void selectPasswordsFilePath()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                //String passwordsFilePath = Path.Combine(@"C:\Users", "Loren", "Dropbox", "BakerShare", "LABPasswords");
                LabPasswords.Properties.Settings.Default.PasswordsDropboxFolder = folderBrowserDialog1.SelectedPath;
                LabPasswords.Properties.Settings.Default.Save();
            }
        }

        #region Read and Write Methods
        private bool readPasswordfile()
        {
            Debug.WriteLine("READ Passwords file START");
            bool results = false;
            try
            {
                //String fileContent = File.ReadAllText(getPasswordsFilePathAndFilename);
                //String tempFilePath = Path.Combine(@"C:\Users", "Loren", "Documents", "PasswordsTesting", "encryptedPasswordsDatafile.txt");
                if (File.Exists(PasswordsDataFullFilename))
                {
                    FileInfo oFileInfo = new FileInfo(PasswordsDataFullFilename);
                    //Debug.WriteLine("Encrypted text file found. Length = " + oFileInfo.Length.ToString("N0"));
                    String fileContent = File.ReadAllText(PasswordsDataFullFilename);
                    //Debug.WriteLine("Encrypted file read. Length = " + fileContent.Length.ToString("N0"));

                    CryptLib _crypt = new CryptLib();
                    String iv = fileContent.Substring(0, 16);
                    fileContent = fileContent.Substring(16, fileContent.Length - 16);
                    //String iv = "74172ca8e67761d2";
                    String decryptedText = _crypt.decrypt(fileContent, mKey, iv);
                    //Debug.WriteLine("Padded file decrypted. Length = " + decryptedText.Length.ToString("N0"));

                    // trim spaces to overcome last character not being written issue!
                    decryptedText = decryptedText.Trim();

                    //Debug.WriteLine("File decrypted. Length = " + decryptedText.Length.ToString("N0"));

                    if (!decryptedText.Equals(""))
                    {
                        mLabPasswords = JsonConvert.DeserializeObject<clsLabPasswords>(decryptedText);
                        sortPasswordfile();
                        Debug.WriteLine("File deserialize. " + mLabPasswords.PasswordItems.Count + " password items and " + mLabPasswords.Users.Count + " users found.");
                        backupPasswordsDataFile(mKey);
                        results = true;
                        mIsDirty = false;
                        txtIsDirty.BackColor = Color.Green;
                    }
                    else
                    {
                        Debug.WriteLine("FAILED to read existing Passwords file.");
                    }
                    Debug.WriteLine("READ Passwords file FINISHED");
                }
                else
                {
                    MessageBox.Show("Unable to find encrypted Passwords data file!", "Reading Passwords File Failed");
                }

            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message, "readPasswordfile: IOException");
            }
            catch (JsonSerializationException e)
            {
                MessageBox.Show(e.Message, "readPasswordfile: JsonSerializationException");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "readPasswordfile: Exception");
            }

            //if (!results)
            //{
            //    mLabPasswords = new clsLabPasswords();
            //}
            return results;
        }

        private void writePasswordfile(bool showDialog)
        {
            // serialize JSON to a string, encrypt, and then write the encrypted string to a file
            //String fileContent = JsonConvert.SerializeObject(mLabPasswords, Formatting.Indented);
            String fileContent = JsonConvert.SerializeObject(mLabPasswords);
            //Debug.WriteLine("mLabPasswords serialized. Length = " + fileContent.Length.ToString("N0"));

            // add spaces to overcome last character not being written issue!
            fileContent = fileContent.Trim();
            fileContent = fileContent + "     ";
            // Debug.WriteLine("mLabPasswords padded. Length = " + fileContent.Length.ToString("N0"));

            CryptLib _crypt = new CryptLib();

            String iv = randomString(16);
            String encryptedFileContent = _crypt.encrypt(fileContent, mKey, iv);
            encryptedFileContent = iv + encryptedFileContent;
            // Debug.WriteLine("mLabPasswords encrypted. Length = " + encryptedFileContent.Length.ToString("N0"));

            File.WriteAllText(PasswordsDataFullFilename, encryptedFileContent);
            //String tempFilePath = Path.Combine(@"C:\Users", "Loren", "Documents", "PasswordsTesting", "encryptedPasswordsDatafile.txt");
            //File.WriteAllText(tempFilePath, encryptedFileContent);
            FileInfo oFileInfo = new FileInfo(PasswordsDataFullFilename);
            //FileInfo oFileInfo = new FileInfo(tempFilePath);
            // Debug.WriteLine("File written. Length = " + oFileInfo.Length.ToString("N0"));

            if (showDialog)
            {
                if (oFileInfo != null)
                {
                    MessageBox.Show("Encrypted " + oFileInfo.Name + " successfully saved." + Environment.NewLine + "Size: " + oFileInfo.Length.ToString("N0") + " bytes.", "File Saved");
                }
                else
                {
                    MessageBox.Show("Failed to save file " + mPasswordsFilename, "File Saved");
                }
            }
        }

        private string randomString(int size)
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < size; i++)
            {
                //ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                ch = Convert.ToChar(random.Next(65, 126));
                builder.Append(ch);
            }

            return builder.ToString();
        }
        #endregion

        private int getUsersFilterSelectedIndex()
        {
            int activeUserID = LabPasswords.Properties.Settings.Default.ActiveUserID;
            int result = -1;
            int index = 0;
            foreach (clsUsers user in cbxUsersFilter.Items)
            {
                if (user.UserID == activeUserID)
                {
                    result = index;
                    break;
                }
                else
                {
                    index++;
                }
            }
            return result;
        }

        private void cbxUsersFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mSuspendHandlers) return;
            mSuspendHandlers = true;

            ComboBox comboBox = (ComboBox)sender;
            clsUsers user = (clsUsers)comboBox.SelectedItem;
            if (user != null)
            {
                mActiveUser = user;
                LabPasswords.Properties.Settings.Default.ActiveUserID = mActiveUser.UserID;
                LabPasswords.Properties.Settings.Default.Save();
            }

            fillPasswordLists();
            showPasswordItems(LabPasswords.Properties.Settings.Default.ActiveItemTypeID);
            mSuspendHandlers = false;
            // move to the 0 position
            if (bsPasswordItems.Count > 0)
            {
                bsPasswordItems.Position = 0;
                bsPasswordItems_PositionChanged(new object(), new EventArgs());
            }

        }


        private int getItemTypesSelectedIndex()
        {
            int activeItemTypeID = LabPasswords.Properties.Settings.Default.ActiveItemTypeID;
            int result = -1;
            int index = 0;
            foreach (clsItemTypes itemType in cbxItemTypes.Items)
            {
                if (itemType.ItemTypeID == activeItemTypeID)
                {
                    result = index;
                    break;
                }
                else
                {
                    index++;
                }
            }
            return result;
        }

        private void cbxItemTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mSuspendHandlers) return;
            mSuspendHandlers = true;

            ComboBox comboBox = (ComboBox)sender;
            mActiveItemType = (clsItemTypes)comboBox.SelectedItem;
            if (mActiveItemType != null)
            {
                mActiveItemTypeID = mActiveItemType.ItemTypeID;
                LabPasswords.Properties.Settings.Default.ActiveItemTypeID = mActiveItemTypeID;
                LabPasswords.Properties.Settings.Default.Save();
            }

            if (mSelectedItems != null)
            {
                mSelectedItem = mSelectedItems[mActiveItemTypeID];
            }
            showPasswordItems(mActiveItemTypeID);
            showItemDetail(mActiveItemTypeID);
            txtSearch.Text = "";
            mSuspendHandlers = false;
            // move to the 0 position
            if (bsPasswordItems.Count > 0)
            {
                bsPasswordItems.Position = 0;
                bsPasswordItems_PositionChanged(new object(), new EventArgs());
            }
            resizeForm();
        }

        private void showPasswordItems(int itemTypeID)
        {
            switch (itemTypeID)
            {
                case ALL_ITEM_TYPES:
                    showAllUserItems();
                    break;
                case CREDIT_CARDS:
                    showUserCreditCardItems();
                    break;
                case GENERAL_ACCOUNTS:
                    showUserGeneralAccountItems();
                    break;
                case SOFTWARE:
                    showUserSoftwareItems();
                    break;
                case WEBSITES:
                    showUserWebsiteItems();
                    break;
            }

            if (mSelectedItem != null && mSelectedItem.ItemPosition > -1)
            {
                bsPasswordItems.Position = mSelectedItem.ItemPosition;
            }
        }

        private void bsPasswordItems_PositionChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("bsPasswordItems_PositionChanged");
            if (mSuspendHandlers) return;
            mSuspendHandlers = true;
            clsPasswordItem item = (clsPasswordItem)bsPasswordItems.Current;
            if (item != null)
            {
                mSelectedItem.ItemID = item.ID;
                mSelectedItem.ItemPosition = bsPasswordItems.Position;
                if (mSelectedLabPasswordsItem != null)
                {
                    mSelectedLabPasswordsItem.PropertyChanged -= passwordItemChanged;
                }
                //mSelectedLabPasswordsItem = getPasswordsItem(item.ID);
                mSelectedLabPasswordsItem = item;
                if (mSelectedLabPasswordsItem != null)
                {
                    mSelectedLabPasswordsItem.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(passwordItemChanged);
                }

                if (mActiveItemTypeID == ALL_ITEM_TYPES)
                {
                    showItemDetail(item.ItemType_ID);
                }
                else
                {
                    showItemDetail(mActiveItemTypeID);
                }
            }
            if (mIsDirty)
            {
                savePasswordsFileAsync(false);
            }
            mSuspendHandlers = false;
        }

        private void showItemDetail(int itemTypeID)
        {
            HOME_TOP = framePasswordItem.Bottom + CONTROL_MARGIN;
            HOME_LEFT = framePasswordItem.Left;

            switch (itemTypeID)
            {
                case CREDIT_CARDS:
                    frameCreditCardInfo.Visible = true;
                    frameGeneralAccountInformation.Visible = false;
                    frameSoftwareKeyCode.Visible = false;

                    frameCreditCardInfo.Location = new Point(HOME_LEFT, HOME_TOP);

                    frameWebsite.Location = new Point(
                        HOME_LEFT,
                        frameCreditCardInfo.Bottom + CONTROL_MARGIN);

                    frameComments.Location = new Point(
                        HOME_LEFT,
                        frameWebsite.Bottom + CONTROL_MARGIN);

                    break;

                case GENERAL_ACCOUNTS:
                    frameCreditCardInfo.Visible = false;
                    frameGeneralAccountInformation.Visible = true;
                    frameSoftwareKeyCode.Visible = false;

                    frameGeneralAccountInformation.Location = new Point(HOME_LEFT, HOME_TOP);

                    frameWebsite.Location = new Point(
                        HOME_LEFT,
                        frameGeneralAccountInformation.Bottom + CONTROL_MARGIN);

                    frameComments.Location = new Point(
                        HOME_LEFT,
                        frameWebsite.Bottom + CONTROL_MARGIN);
                    break;

                case SOFTWARE:
                    frameCreditCardInfo.Visible = false;
                    frameGeneralAccountInformation.Visible = false;
                    frameSoftwareKeyCode.Visible = true;

                    frameSoftwareKeyCode.Location = new Point(HOME_LEFT, HOME_TOP);

                    frameWebsite.Location = new Point(
                        HOME_LEFT,
                        frameSoftwareKeyCode.Bottom + CONTROL_MARGIN);

                    frameComments.Location = new Point(
                        HOME_LEFT,
                        frameWebsite.Bottom + CONTROL_MARGIN);
                    break;

                case WEBSITES:
                    frameCreditCardInfo.Visible = false;
                    frameGeneralAccountInformation.Visible = false;
                    frameSoftwareKeyCode.Visible = false;

                    frameWebsite.Location = new Point(HOME_LEFT, HOME_TOP);

                    frameComments.Location = new Point(
                        HOME_LEFT,
                        frameWebsite.Bottom + CONTROL_MARGIN);
                    break;
            }
        }

        private clsPasswordItem getPasswordsItem(int itemID)
        {
            clsPasswordItem foundItem = null;
            foreach (clsPasswordItem item in mLabPasswords.PasswordItems)
            {
                if (item.ID == itemID)
                {
                    foundItem = item;
                    break;
                }
            }
            return foundItem;
        }

        private void showAllUserItems()
        {
            bsPasswordItems.DataSource = mUserAllPasswordItems;
            listPasswordItems.DataSource = bsPasswordItems;
        }

        private void showUserCreditCardItems()
        {
            bsPasswordItems.DataSource = mUserCreditCards;
            listPasswordItems.DataSource = bsPasswordItems;
        }

        private void showUserGeneralAccountItems()
        {
            bsPasswordItems.DataSource = mUserGeneralAccounts;
            listPasswordItems.DataSource = bsPasswordItems;
        }

        private void showUserSoftwareItems()
        {
            bsPasswordItems.DataSource = mUserSoftware;
            listPasswordItems.DataSource = bsPasswordItems;
        }

        private void showUserWebsiteItems()
        {
            bsPasswordItems.DataSource = mUserWebsites;
            listPasswordItems.DataSource = bsPasswordItems;
        }

        private void numericTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

        #region Formatting Events
        private void FormatPhoneNumber(object sender, ConvertEventArgs cevent)
        {
            // The method converts only to string type. Test this using the DesiredType. 
            if (cevent.DesiredType != typeof(string)) return;

            cevent.Value = clsFormattingMethods.formatPhoneNumber(cevent.Value.ToString());
        }

        private void UnformattedPhoneNumber(object sender, ConvertEventArgs cevent)
        {
            if (cevent.DesiredType != typeof(string)) return;
            cevent.Value = clsFormattingMethods.unFormatPhoneNumber(cevent.Value.ToString());
        }


        private void FormatCreditCard(object sender, ConvertEventArgs cevent)
        {
            if (cevent.DesiredType != typeof(string)) return;
            clsFormattingMethods.creditCard creditCard = clsFormattingMethods.getCreditCardType(cevent.Value.ToString());
            txtCreditCardType.Text = creditCard.getCardType();
            bool luhnCheck = clsFormattingMethods.LuhnCheck(cevent.Value.ToString());
            if (luhnCheck)
            {
                picCheckMark.Image = LabPasswords.Properties.Resources.check_on;
            }
            else
            {
                picCheckMark.Image = LabPasswords.Properties.Resources.check_off;
            }
            cevent.Value = creditCard.getFormattedCardNumber();
        }

        private void UnformatCreditCard(object sender, ConvertEventArgs cevent)
        {
            // The method converts only to string type. Test this using the DesiredType. 
            if (cevent.DesiredType != typeof(string)) return;
            cevent.Value = clsFormattingMethods.unformatAccountNumber(cevent.Value.ToString());
        }

        private void FormatSoftwareKeyCode(object sender, ConvertEventArgs cevent)
        {
            if (cevent.DesiredType != typeof(string)) return;
            clsPasswordItem item = (clsPasswordItem)bsPasswordItems.Current;
            cevent.Value = clsFormattingMethods.formatTypicalAccountNumber(cevent.Value.ToString(), item.SoftwareSubgroupLength);
        }

        private void UnformatSoftwareKeyCode(object sender, ConvertEventArgs cevent)
        {
            if (cevent.DesiredType != typeof(string)) return;
            cevent.Value = clsFormattingMethods.unformatAccountNumber(cevent.Value.ToString());
        }

        #endregion

        private void saveSelectedItems(List<clsSelectedItem> selectedItems)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                if (selectedItems != null)
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(ms, selectedItems);
                    ms.Position = 0;
                    byte[] buffer = new byte[(int)ms.Length];
                    ms.Read(buffer, 0, buffer.Length);
                    LabPasswords.Properties.Settings.Default.SelectedItems = Convert.ToBase64String(buffer);
                    LabPasswords.Properties.Settings.Default.Save();
                }
            }
        }

        private List<clsSelectedItem> loadSelectedItems()
        {
            List<clsSelectedItem> selectedItems;
            String selectedItemsString = LabPasswords.Properties.Settings.Default.SelectedItems;

            if (selectedItemsString.Length > 0)
            {
                // There are saved selected Items... so, retreive them
                using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(selectedItemsString)))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    selectedItems = (List<clsSelectedItem>)bf.Deserialize(ms);
                }
            }
            else
            {
                // There are no saved selected items... so, create them
                selectedItems = new List<clsSelectedItem>();
                for (int i = 0; i < 5; i++)
                {
                    clsSelectedItem newItem = new clsSelectedItem();
                    selectedItems.Add(newItem);
                }
            }

            int activeItemTypeID = LabPasswords.Properties.Settings.Default.ActiveItemTypeID;

            //Fill selected item positions
            findPasswordItemPosition(mUserAllPasswordItems, selectedItems[0]);
            findPasswordItemPosition(mUserCreditCards, selectedItems[1]);
            findPasswordItemPosition(mUserGeneralAccounts, selectedItems[2]);
            findPasswordItemPosition(mUserSoftware, selectedItems[3]);
            findPasswordItemPosition(mUserWebsites, selectedItems[4]);

            mSelectedItem = selectedItems[activeItemTypeID];
            return selectedItems;
        }

        private int findPasswordItemPosition(List<clsPasswordItem> listOfItems, clsSelectedItem selectedItem)
        {
            int position = -1;
            if (listOfItems == null)
            {
                return position;
            }

            if (selectedItem == null)
            {
                return position;
            }

            int index = -1;
            int itemID = selectedItem.ItemID;
            bool itemFound = false;
            foreach (clsPasswordItem item in listOfItems)
            {
                index++;
                if (item.ID == itemID)
                {
                    selectedItem.ItemPosition = index;
                    position = index;
                    itemFound = true;
                    break;
                }
            }

            if (!itemFound)
            {
                if (listOfItems.Count > 0)
                {
                    // Select the first item in the list
                    clsPasswordItem passwordItem = listOfItems[0];
                    selectedItem.ItemID = passwordItem.ID;
                    selectedItem.ItemPosition = 0;
                }
                else
                {
                    // the list is empty!
                    selectedItem.ItemID = -1;
                    selectedItem.ItemPosition = 0;
                }
            }

            return position;
        }

        #region Search Methods
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (mSuspendHandlers) return;

            TextBox txtBox = (TextBox)sender;
            List<clsPasswordItem> itemsList;

            switch (mActiveItemTypeID)
            {
                case ALL_ITEM_TYPES:
                    if (txtBox.Text.Length > 0)
                    {
                        itemsList = getFilteredItemsList(mUserAllPasswordItems, txtBox.Text);
                        bsPasswordItems.DataSource = itemsList;
                    }
                    else
                    {
                        bsPasswordItems.DataSource = mUserAllPasswordItems;
                    }
                    break;

                case CREDIT_CARDS:
                    if (txtBox.Text.Length > 0)
                    {
                        itemsList = getFilteredItemsList(mUserCreditCards, txtBox.Text);
                        bsPasswordItems.DataSource = itemsList;
                    }
                    else
                    {
                        bsPasswordItems.DataSource = mUserCreditCards;
                    }
                    break;

                case GENERAL_ACCOUNTS:
                    if (txtBox.Text.Length > 0)
                    {
                        itemsList = getFilteredItemsList(mUserGeneralAccounts, txtBox.Text);
                        bsPasswordItems.DataSource = itemsList;
                    }
                    else
                    {
                        bsPasswordItems.DataSource = mUserGeneralAccounts;
                    }
                    break;

                case SOFTWARE:
                    if (txtBox.Text.Length > 0)
                    {
                        itemsList = getFilteredItemsList(mUserSoftware, txtBox.Text);
                        bsPasswordItems.DataSource = itemsList;
                    }
                    else
                    {
                        bsPasswordItems.DataSource = mUserSoftware;
                    }
                    break;

                case WEBSITES:
                    if (txtBox.Text.Length > 0)
                    {
                        itemsList = getFilteredItemsList(mUserWebsites, txtBox.Text);
                        bsPasswordItems.DataSource = itemsList;
                    }
                    else
                    {
                        bsPasswordItems.DataSource = mUserWebsites;
                    }
                    break;
            }
        }

        private List<clsPasswordItem> getFilteredItemsList(List<clsPasswordItem> passwordItems, string searchText)
        {
            List<clsPasswordItem> itemsList = new List<clsPasswordItem>();
            foreach (clsPasswordItem item in passwordItems)
            {
                if (item.Name.ToUpper().Contains(searchText.ToUpper()))
                {
                    itemsList.Add(item);
                }
            }
            return itemsList;
        }
        #endregion

        #region Button Click Events

        private void menuSave_Click(object sender, EventArgs e)
        {
            savePasswordsFileAsync(true);
        }

        private void savePasswordsFileAsync(bool verbose)
        {
            removeFileWatcherHandlers();
            savePasswordsFileBackgroundWorker.RunWorkerAsync(verbose);
        }


        private void menuAddNewUser_Click(object sender, EventArgs e)
        {
            createNewUser(false);
        }

        private void menuDeleteUser_Click(object sender, EventArgs e)
        {
            deleteUser();
        }

        private void menuChangeAppPassword_Click(object sender, EventArgs e)
        {
            frmChangePassword dialog = new frmChangePassword();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                mKey = dialog.passwordKey;
                savePasswordsFileAsync(false);
            }
        }

        private void menuRandomPassword_Click(object sender, EventArgs e)
        {
            frmRandomPasswordDialog dialog = new frmRandomPasswordDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.Yes)
            {
                // btnCopyToClipboardPasteAndClose_Clicked
                Clipboard.SetText(dialog.resultPassword);
                txtWebsitePassword.Text = dialog.resultPassword;
                mSelectedLabPasswordsItem.WebsitePassword = dialog.resultPassword;

            }
            else if (result == DialogResult.OK)
            {
                //btnCopyPasswordAndClose_Clicked
                Clipboard.SetText(dialog.resultPassword);
            }
        }

        private void menuAndroidCompanionApp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TO COME: menuAndroidCompanionApp_Click");
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TO COME: menuAbout_Click");
        }


        private void menuRefresh_Click(object sender, EventArgs e)
        {
            updateUI();
            MessageBox.Show("File refreshed", "", MessageBoxButtons.OK);
            //MessageBox.Show("TO COME: menuRefresh_Click");
        }

        private void btnCopyPasswordAndGoToWebsite_Click(object sender, EventArgs e)
        {
            if (mSelectedLabPasswordsItem != null)
            {
                if (!mSelectedLabPasswordsItem.WebsitePassword.Equals(""))
                {
                    Clipboard.SetText(mSelectedLabPasswordsItem.WebsitePassword);
                }
                else
                {
                    Clipboard.Clear();
                }

                if (!mSelectedLabPasswordsItem.WebsiteURL.Equals(""))
                {
                    try
                    {
                        System.Diagnostics.Process.Start(mSelectedLabPasswordsItem.WebsiteURL);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Exception occured while trying to open website:" + mSelectedLabPasswordsItem.WebsiteURL,
                            "Unable to open website", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Sorry. The website URL is empty!", "Unable to open website", MessageBoxButtons.OK);
                }
            }
        }

        private void btnCopyPassword_Click(object sender, EventArgs e)
        {
            if (mSelectedLabPasswordsItem != null)
                if (mSelectedLabPasswordsItem.WebsitePassword.Equals(""))
                {
                    Clipboard.Clear();
                }
                else
                {
                    Clipboard.SetText(mSelectedLabPasswordsItem.WebsitePassword);
                }
        }

        private void btnCopyKeyCode_Click(object sender, EventArgs e)
        {
            if (mSelectedLabPasswordsItem != null)
                if (mSelectedLabPasswordsItem.SoftwareKeyCode.Equals(""))
                {
                    Clipboard.Clear();
                }
                else
                {
                    Clipboard.SetText(mSelectedLabPasswordsItem.SoftwareKeyCode);
                }
        }

        private void btnCopyCreditCardAccountNumber_Click(object sender, EventArgs e)
        {
            if (mSelectedLabPasswordsItem != null)
                if (mSelectedLabPasswordsItem.CreditCardAccountNumber.Equals(""))
                {
                    Clipboard.Clear();
                }
                else
                {
                    Clipboard.SetText(mSelectedLabPasswordsItem.CreditCardAccountNumber);
                }
        }

        private void btnCopyGeneralAccountNumber_Click(object sender, EventArgs e)
        {
            if (mSelectedLabPasswordsItem != null)
                if (mSelectedLabPasswordsItem.GeneralAccountNumber.Equals(""))
                {
                    Clipboard.Clear();
                }
                else
                {
                    Clipboard.SetText(mSelectedLabPasswordsItem.GeneralAccountNumber);
                }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            StringBuilder msg = new StringBuilder();
            msg.Append("Do you want to delete ");
            int itemTypeID = mActiveItemTypeID;
            clsPasswordItem item = getPasswordsItem(mSelectedItem.ItemID);

            if (mActiveItemTypeID == ALL_ITEM_TYPES)
            {
                itemTypeID = item.ItemType_ID;
            }

            switch (itemTypeID)
            {
                case CREDIT_CARDS:
                    msg.Append("Credit Card ");
                    break;

                case GENERAL_ACCOUNTS:
                    msg.Append("General Account ");
                    break;

                case SOFTWARE:
                    msg.Append("Software ");
                    break;

                case WEBSITES:
                    msg.Append("Website ");
                    break;

            }

            msg.Append("\"").Append(item.Name).Append("\"?");


            DialogResult dialogResult = MessageBox.Show(msg.ToString(), "Delete Item", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                deletePasswordItem(item);
            }
        }

        private void deletePasswordItem(clsPasswordItem item)
        {
            // find the binding source's new position.
            int newPosition = mSelectedItem.ItemPosition;
            if (newPosition + 1 == bsPasswordItems.Count)
            {
                // you are about to delete the last item in the displayed list
                if (bsPasswordItems.Count > 1)
                {
                    newPosition--;
                }
                else
                {
                    // You're about to delete the only item in the displayed list
                    newPosition = -1;
                }
            }

            listPasswordItems.DataSource = null;
            mLabPasswords.PasswordItems.Remove(item);
            mUserAllPasswordItems.Remove(item);

            switch (mActiveItemTypeID)
            {
                case ALL_ITEM_TYPES:
                    showAllUserItems();
                    break;

                case CREDIT_CARDS:
                    mUserCreditCards.Remove(item);
                    showUserCreditCardItems();
                    break;

                case GENERAL_ACCOUNTS:
                    mUserGeneralAccounts.Remove(item);
                    showUserGeneralAccountItems();
                    break;

                case SOFTWARE:
                    mUserSoftware.Remove(item);
                    showUserSoftwareItems();
                    break;

                case WEBSITES:
                    mUserWebsites.Remove(item);
                    showUserWebsiteItems();
                    break;
            }
            bsPasswordItems.Position = -1;
            bsPasswordItems.Position = newPosition;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";

            if (mActiveItemTypeID == ALL_ITEM_TYPES)
            {
                frmNewPasswordItemTypeDialog dialog = new frmNewPasswordItemTypeDialog();
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    switch (dialog.ItemTypeID)
                    {
                        case CREDIT_CARDS:
                            createNewPasswordItem(CREDIT_CARDS, true);
                            break;
                        case GENERAL_ACCOUNTS:
                            createNewPasswordItem(GENERAL_ACCOUNTS, true);
                            break;
                        case SOFTWARE:
                            createNewPasswordItem(SOFTWARE, true);
                            break;
                        case WEBSITES:
                            createNewPasswordItem(WEBSITES, true);
                            break;
                    }
                }
            }
            else
            {
                createNewPasswordItem(mActiveItemTypeID, false);
            }

            txtItemName.Select();
            mIsDirty = true;
            bsPasswordItems_PositionChanged(new object(), new EventArgs());
        }


        private void createNewPasswordItem(int itemTypeID, bool showAllItemTypes)
        {
            clsPasswordItem newItem = new clsPasswordItem(getNextPasswordID);
            newItem.ItemType_ID = itemTypeID;
            newItem.User_ID = mActiveUser.UserID;
            switch (itemTypeID)
            {
                case CREDIT_CARDS:
                    String newName = verifyNewName("NewCreditCard");
                    newItem.Name = newName;
                    mLabPasswords.PasswordItems.Add(newItem);
                    sortPasswordfile();
                    fillPasswordLists();
                    mSelectedItem.ItemID = newItem.ID;
                    if (showAllItemTypes)
                    {
                        int position = findPasswordItemPosition(mUserAllPasswordItems, mSelectedItem);
                        bsPasswordItems.DataSource = mUserAllPasswordItems;
                        bsPasswordItems.Position = position;
                    }
                    else
                    {
                        int position = findPasswordItemPosition(mUserCreditCards, mSelectedItem);
                        bsPasswordItems.DataSource = mUserCreditCards;
                        bsPasswordItems.Position = position;
                    }
                    break;

                case GENERAL_ACCOUNTS:
                    newName = verifyNewName("NewGeneralAccount");
                    newItem.Name = newName;
                    mLabPasswords.PasswordItems.Add(newItem);
                    sortPasswordfile();
                    fillPasswordLists();
                    mSelectedItem.ItemID = newItem.ID;
                    if (showAllItemTypes)
                    {
                        int position = findPasswordItemPosition(mUserAllPasswordItems, mSelectedItem);
                        bsPasswordItems.DataSource = mUserAllPasswordItems;
                        bsPasswordItems.Position = position;
                    }
                    else
                    {
                        int position = findPasswordItemPosition(mUserGeneralAccounts, mSelectedItem);
                        bsPasswordItems.DataSource = mUserGeneralAccounts;
                        bsPasswordItems.Position = position;
                    }
                    break;

                case SOFTWARE:
                    newName = verifyNewName("NewSoftware");
                    newItem.Name = newName;
                    mLabPasswords.PasswordItems.Add(newItem);
                    sortPasswordfile();
                    fillPasswordLists();
                    mSelectedItem.ItemID = newItem.ID;
                    if (showAllItemTypes)
                    {
                        int position = findPasswordItemPosition(mUserAllPasswordItems, mSelectedItem);
                        bsPasswordItems.DataSource = mUserAllPasswordItems;
                        bsPasswordItems.Position = position;
                    }
                    else
                    {
                        int position = findPasswordItemPosition(mUserSoftware, mSelectedItem);
                        bsPasswordItems.DataSource = mUserSoftware;
                        bsPasswordItems.Position = position;
                    }
                    break;

                case WEBSITES:
                    newName = verifyNewName("NewWebsite");
                    newItem.Name = newName;
                    mLabPasswords.PasswordItems.Add(newItem);
                    sortPasswordfile();
                    fillPasswordLists();
                    mSelectedItem.ItemID = newItem.ID;
                    if (showAllItemTypes)
                    {
                        int position = findPasswordItemPosition(mUserAllPasswordItems, mSelectedItem);
                        bsPasswordItems.DataSource = mUserAllPasswordItems;
                        bsPasswordItems.Position = position;
                    }
                    else
                    {
                        int position = findPasswordItemPosition(mUserWebsites, mSelectedItem);
                        bsPasswordItems.DataSource = mUserWebsites;
                        bsPasswordItems.Position = position;
                    }
                    break;
            }
        }

        private string verifyNewName(string proposedNewName)
        {
            String resultName = proposedNewName;
            int index = 0;
            while (newNameExists(resultName))
            {
                index++;
                resultName = proposedNewName + "(" + index + ")";
            }

            return resultName;
        }

        private bool newNameExists(string proposedNewName)
        {
            bool result = false;
            int itemCount = 0;
            //foreach (clsPasswordItem item in mLabPasswords.PasswordItems)
            foreach (clsPasswordItem item in mUserAllPasswordItems)
            {
                if (item.Name.ToUpper().Equals(proposedNewName.ToUpper()))
                {
                    itemCount++;
                    if (itemCount > 1)
                    {
                        result = true;
                        break;
                    }
                }
            }

            return result;
        }
        #endregion

        private void updnSoftwareKeyCodeSubgroupLength_ValueChanged(object sender, EventArgs e)
        {
            if (mSuspendHandlers) return;
            String unformattedKeyCode = clsFormattingMethods.unformatAccountNumber(txtSoftwareKeyCode.Text);
            String formattedKeyCode = clsFormattingMethods.formatTypicalAccountNumber(unformattedKeyCode, (int)updnSoftwareKeyCodeSubgroupLength.Value);
            txtSoftwareKeyCode.Text = formattedKeyCode;
        }

        private void savePasswordsFileBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            mIsDirty = false;
            Debug.WriteLine("Save Passwords file async START");
            bool verbose = (bool)e.Argument;
            writePasswordfile(verbose);
        }

        private void savePasswordsFileBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            addFileWatcherHandlers();
            txtIsDirty.BackColor = Color.Green;
            Debug.WriteLine("Save Passwords file async COMPLETE");
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            resizeForm();
        }

        private void resizeForm()
        {
            //lblTop.Text = "Top = " + this.Top;
            //lblLeft.Text = "Left = " + this.Left;
            //lblWidth.Text = "Width = " + this.Width;
            //lblHeight.Text = "Height = " + this.Height;

            int displayWidth = SplitContainer2.Panel2.DisplayRectangle.Width;


            int titleWidth = lblCardSecurityCode.Width;

            frameComments.Width = displayWidth - 2 * CONTROL_MARGIN;
            frameComments.Left = CONTROL_MARGIN;

            framePasswordItem.Width = frameComments.Width;
            framePasswordItem.Left = CONTROL_MARGIN;
            framePasswordItem.Top = CONTROL_MARGIN;

            frameCreditCardInfo.Width = frameComments.Width;
            frameCreditCardInfo.Left = CONTROL_MARGIN;

            frameGeneralAccountInformation.Width = frameComments.Width;
            frameGeneralAccountInformation.Left = CONTROL_MARGIN;

            frameSoftwareKeyCode.Width = frameComments.Width;
            frameSoftwareKeyCode.Left = CONTROL_MARGIN;

            frameWebsite.Width = frameComments.Width;
            frameWebsite.Left = CONTROL_MARGIN;

            //int frameWidth = frameComments.Width;

            //txtIsDirty.Left = frameWidth - txtIsDirty.Width - CONTROL_MARGIN;
            //txtItemName.Left = CONTROL_MARGIN;
            //txtItemName.Width = frameWidth - txtIsDirty.Width - 3 * CONTROL_MARGIN;

            //// frameSoftwareKeyCode controls 
            //lblSoftwareKeyCode.Left = CONTROL_MARGIN;
            //updnSoftwareKeyCodeSubgroupLength.Left = frameWidth - updnSoftwareKeyCodeSubgroupLength.Width - CONTROL_MARGIN;
            //txtSoftwareKeyCode.Left =  CONTROL_MARGIN + titleWidth;
            //txtSoftwareKeyCode.Width = frameWidth - titleWidth - updnSoftwareKeyCodeSubgroupLength.Width - 3*CONTROL_MARGIN;

            //btnCopyKeyCode.Left = txtSoftwareKeyCode.Left;
            //btnCopyKeyCode.Width = frameWidth - txtSoftwareKeyCode.Left - CONTROL_MARGIN;

            //// frameCreditCardInfo controls
            //lblCreditCardAccountNumber.Left = CONTROL_MARGIN;
            //lblCardSecurityCode.Left = CONTROL_MARGIN;
            //lblExpirationDate.Left = CONTROL_MARGIN;
            //lblCreditCardPrimaryPhoneNumber.Left = CONTROL_MARGIN;

            //txtCreditCardAccountNumber.Left = titleWidth + CONTROL_MARGIN;
            //txtCreditCardSecurityCode.Left = txtCreditCardAccountNumber.Left;
            //txtCreditCardExpirationMonth.Left = txtCreditCardAccountNumber.Left;
            //txtCreditCardPrimaryPhoneNumber.Left = txtCreditCardAccountNumber.Left;
            //txtCreditCardExpirationYear.Left = txtCreditCardExpirationMonth.Right + CONTROL_MARGIN;

            //picCheckMark.Left = frameWidth - picCheckMark.Width - CONTROL_MARGIN;

            //txtCreditCardAccountNumber.Width = frameWidth - titleWidth - 2* CONTROL_MARGIN;
            //txtCreditCardType.Left = picCheckMark.Left - txtCreditCardType.Width- CONTROL_MARGIN;
            //txtCreditCardAltPhoneNumber.Left = txtCreditCardType.Left;

            //lblCreditCardType.Left = txtCreditCardType.Left -lblCreditCardType.Width- CONTROL_MARGIN;
            //lblCreditCardAltPhoneNumber.Left = lblCreditCardType.Left;

            //txtCreditCardSecurityCode.Width = txtCreditCardExpirationYear.Right - txtCreditCardExpirationMonth.Left;
            //txtCreditCardPrimaryPhoneNumber.Width = txtCreditCardSecurityCode.Width;
            //txtCreditCardAltPhoneNumber.Width = txtCreditCardSecurityCode.Width;
            //txtCreditCardType.Width = txtCreditCardSecurityCode.Width;

            //btnCopyCreditCardAccountNumber.Left = btnCopyKeyCode.Left;
            //btnCopyCreditCardAccountNumber.Width = btnCopyKeyCode.Width;

            //// frameWebsite Controls
            //lblWebsiteURLAddress.Left = CONTROL_MARGIN;
            //lblWebsiteUserID.Left = CONTROL_MARGIN;
            //lblWebsitePassword.Left = CONTROL_MARGIN;

            //txtWebsiteURLAddress.Left = titleWidth + CONTROL_MARGIN;
            //txtWebsitePassword.Left = txtWebsiteURLAddress.Left;
            //txtWebsiteUserID.Left = txtWebsiteURLAddress.Left;

            //txtWebsiteURLAddress.Width = frameWidth - titleWidth - 2 * CONTROL_MARGIN;
            //txtWebsitePassword.Width = txtWebsiteURLAddress.Width;
            //txtWebsiteUserID.Width = txtWebsiteURLAddress.Width;

            //btnCopyPassword.Left = txtWebsiteURLAddress.Left;
            //btnCopyPasswordAndGoToWebsite.Left = frameWidth - btnCopyPasswordAndGoToWebsite.Width - CONTROL_CONTROL_MARGIN;

            ////frameGeneralAccountInformation
            //lblGeneralAccountNumber.Left = CONTROL_CONTROL_MARGIN;
            //lblGeneralAccountPrimaryPhoneNumber.Left = CONTROL_CONTROL_MARGIN;

            //txtGeneralAccountNumber.Left = titleWidth + CONTROL_CONTROL_MARGIN;
            //txtGeneralAccountNumber.Width = frameWidth - titleWidth - 2* CONTROL_CONTROL_MARGIN;

            //txtGeneralAccountPrimaryPhoneNumber.Left = txtGeneralAccountNumber.Left;
            //txtGeneralAccountPrimaryPhoneNumber.Width = txtCreditCardSecurityCode.Width;
            //txtGeneralAccountAltPhoneNumber.Width = txtCreditCardSecurityCode.Width;

            //txtGeneralAccountAltPhoneNumber.Left = frameWidth - txtGeneralAccountAltPhoneNumber.Width - CONTROL_CONTROL_CONTROL_MARGIN;
            //lblGeneralAccountAltPhoneNumber.Left = txtGeneralAccountAltPhoneNumber.Left - lblGeneralAccountAltPhoneNumber .Width- CONTROL_CONTROL_CONTROL_MARGIN;

            //btnCopyGeneralAccountNumber.Left = txtGeneralAccountNumber.Left;
            //btnCopyGeneralAccountNumber.Width = txtGeneralAccountNumber.Width;

        }

        //private void backupPasswordsFileBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    Debug.WriteLine("Backup Passwords file async START");
        //    backupPasswordsDataFile();
        //}

        //private void backupPasswordsFileBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        //{
        //    Debug.WriteLine("Backup Passwords file async COMPLETE");
        //}

    }

    [Serializable()]
    class clsSelectedItem
    {
        public int ItemPosition { get; set; }
        public int ItemID { get; set; }

        public clsSelectedItem()
        {
            this.ItemID = -1;
            this.ItemPosition = 0;
        }
    }


}
