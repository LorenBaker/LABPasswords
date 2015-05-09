namespace LabPasswords
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.frameDeleteNewButtons = new System.Windows.Forms.GroupBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.frameSearch = new System.Windows.Forms.GroupBox();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuChangeAppPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRandomPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAndroidCompanionApp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.frameFilterItems = new System.Windows.Forms.GroupBox();
            this.lblUsersFilter = new System.Windows.Forms.Label();
            this.cbxUsersFilter = new System.Windows.Forms.ComboBox();
            this.SplitContainer2 = new System.Windows.Forms.SplitContainer();
            this.listPasswordItems = new System.Windows.Forms.ListBox();
            this.cbxItemTypes = new System.Windows.Forms.ComboBox();
            this.frameWebsite = new System.Windows.Forms.GroupBox();
            this.lblWebsitePassword = new System.Windows.Forms.Label();
            this.lblWebsiteUserID = new System.Windows.Forms.Label();
            this.lblWebsiteURLAddress = new System.Windows.Forms.Label();
            this.btnCopyPassword = new System.Windows.Forms.Button();
            this.btnCopyPasswordAndGoToWebsite = new System.Windows.Forms.Button();
            this.txtWebsitePassword = new System.Windows.Forms.TextBox();
            this.txtWebsiteUserID = new System.Windows.Forms.TextBox();
            this.txtWebsiteURLAddress = new System.Windows.Forms.TextBox();
            this.frameGeneralAccountInformation = new System.Windows.Forms.GroupBox();
            this.lblGeneralAccountPrimaryPhoneNumber = new System.Windows.Forms.Label();
            this.lblGeneralAccountNumber = new System.Windows.Forms.Label();
            this.btnCopyGeneralAccountNumber = new System.Windows.Forms.Button();
            this.lblGeneralAccountAltPhoneNumber = new System.Windows.Forms.Label();
            this.txtGeneralAccountAltPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtGeneralAccountPrimaryPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtGeneralAccountNumber = new System.Windows.Forms.TextBox();
            this.framePasswordItem = new System.Windows.Forms.GroupBox();
            this.txtIsDirty = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.frameComments = new System.Windows.Forms.GroupBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.frameSoftwareKeyCode = new System.Windows.Forms.GroupBox();
            this.lblSoftwareKeyCode = new System.Windows.Forms.Label();
            this.btnCopyKeyCode = new System.Windows.Forms.Button();
            this.txtSoftwareKeyCode = new System.Windows.Forms.TextBox();
            this.updnSoftwareKeyCodeSubgroupLength = new System.Windows.Forms.NumericUpDown();
            this.frameCreditCardInfo = new System.Windows.Forms.GroupBox();
            this.lblCreditCardPrimaryPhoneNumber = new System.Windows.Forms.Label();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.lblCreditCardAccountNumber = new System.Windows.Forms.Label();
            this.picCheckMark = new System.Windows.Forms.PictureBox();
            this.txtCreditCardExpirationYear = new System.Windows.Forms.TextBox();
            this.txtCreditCardExpirationMonth = new System.Windows.Forms.TextBox();
            this.btnCopyCreditCardAccountNumber = new System.Windows.Forms.Button();
            this.lblCreditCardAltPhoneNumber = new System.Windows.Forms.Label();
            this.txtCreditCardType = new System.Windows.Forms.TextBox();
            this.lblCreditCardType = new System.Windows.Forms.Label();
            this.txtCreditCardSecurityCode = new System.Windows.Forms.TextBox();
            this.lblCardSecurityCode = new System.Windows.Forms.Label();
            this.txtCreditCardAltPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtCreditCardPrimaryPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtCreditCardAccountNumber = new System.Windows.Forms.TextBox();
            this.savePasswordsFileBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.backupPasswordsFileBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.frameDeleteNewButtons.SuspendLayout();
            this.frameSearch.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            this.frameFilterItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).BeginInit();
            this.SplitContainer2.Panel1.SuspendLayout();
            this.SplitContainer2.Panel2.SuspendLayout();
            this.SplitContainer2.SuspendLayout();
            this.frameWebsite.SuspendLayout();
            this.frameGeneralAccountInformation.SuspendLayout();
            this.framePasswordItem.SuspendLayout();
            this.frameComments.SuspendLayout();
            this.frameSoftwareKeyCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updnSoftwareKeyCodeSubgroupLength)).BeginInit();
            this.frameCreditCardInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCheckMark)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(8, 21);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(617, 23);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TabStop = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // menuSave
            // 
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(52, 24);
            this.menuSave.Text = "Save";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.SplitContainer1.Location = new System.Drawing.Point(4, 4);
            this.SplitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.SplitContainer1.Name = "SplitContainer1";
            this.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.SplitContainer1.Panel1.Controls.Add(this.frameDeleteNewButtons);
            this.SplitContainer1.Panel1.Controls.Add(this.frameSearch);
            this.SplitContainer1.Panel1.Controls.Add(this.MenuStrip1);
            this.SplitContainer1.Panel1.Controls.Add(this.frameFilterItems);
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.AutoScroll = true;
            this.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SplitContainer1.Panel2.Controls.Add(this.SplitContainer2);
            this.SplitContainer1.Size = new System.Drawing.Size(1227, 857);
            this.SplitContainer1.SplitterDistance = 109;
            this.SplitContainer1.SplitterWidth = 1;
            this.SplitContainer1.TabIndex = 1;
            this.SplitContainer1.TabStop = false;
            // 
            // frameDeleteNewButtons
            // 
            this.frameDeleteNewButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.frameDeleteNewButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.frameDeleteNewButtons.Controls.Add(this.btnNew);
            this.frameDeleteNewButtons.Controls.Add(this.btnDelete);
            this.frameDeleteNewButtons.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frameDeleteNewButtons.Location = new System.Drawing.Point(926, 36);
            this.frameDeleteNewButtons.Margin = new System.Windows.Forms.Padding(4);
            this.frameDeleteNewButtons.Name = "frameDeleteNewButtons";
            this.frameDeleteNewButtons.Padding = new System.Windows.Forms.Padding(4);
            this.frameDeleteNewButtons.Size = new System.Drawing.Size(281, 62);
            this.frameDeleteNewButtons.TabIndex = 1;
            this.frameDeleteNewButtons.TabStop = false;
            // 
            // btnNew
            // 
            this.btnNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNew.Location = new System.Drawing.Point(153, 15);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(107, 39);
            this.btnNew.TabIndex = 1;
            this.btnNew.TabStop = false;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Location = new System.Drawing.Point(21, 15);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 39);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frameSearch
            // 
            this.frameSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frameSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.frameSearch.Controls.Add(this.txtSearch);
            this.frameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frameSearch.Location = new System.Drawing.Point(285, 36);
            this.frameSearch.Margin = new System.Windows.Forms.Padding(4);
            this.frameSearch.Name = "frameSearch";
            this.frameSearch.Padding = new System.Windows.Forms.Padding(4);
            this.frameSearch.Size = new System.Drawing.Size(633, 62);
            this.frameSearch.TabIndex = 0;
            this.frameSearch.TabStop = false;
            this.frameSearch.Text = "Search:";
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSave,
            this.usersToolStripMenuItem,
            this.menuChangeAppPassword,
            this.menuRandomPassword,
            this.menuAndroidCompanionApp,
            this.menuRefresh,
            this.menuAbout});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MenuStrip1.Size = new System.Drawing.Size(1223, 28);
            this.MenuStrip1.TabIndex = 6;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddNewUser,
            this.menuDeleteUser});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // menuAddNewUser
            // 
            this.menuAddNewUser.Name = "menuAddNewUser";
            this.menuAddNewUser.Size = new System.Drawing.Size(173, 24);
            this.menuAddNewUser.Text = "Add New User";
            this.menuAddNewUser.Click += new System.EventHandler(this.menuAddNewUser_Click);
            // 
            // menuDeleteUser
            // 
            this.menuDeleteUser.Name = "menuDeleteUser";
            this.menuDeleteUser.Size = new System.Drawing.Size(173, 24);
            this.menuDeleteUser.Text = "Delete User";
            this.menuDeleteUser.Click += new System.EventHandler(this.menuDeleteUser_Click);
            // 
            // menuChangeAppPassword
            // 
            this.menuChangeAppPassword.Name = "menuChangeAppPassword";
            this.menuChangeAppPassword.Size = new System.Drawing.Size(169, 24);
            this.menuChangeAppPassword.Text = "Change App Password";
            this.menuChangeAppPassword.Click += new System.EventHandler(this.menuChangeAppPassword_Click);
            // 
            // menuRandomPassword
            // 
            this.menuRandomPassword.Name = "menuRandomPassword";
            this.menuRandomPassword.Size = new System.Drawing.Size(143, 24);
            this.menuRandomPassword.Text = "Random Password";
            this.menuRandomPassword.Click += new System.EventHandler(this.menuRandomPassword_Click);
            // 
            // menuAndroidCompanionApp
            // 
            this.menuAndroidCompanionApp.Name = "menuAndroidCompanionApp";
            this.menuAndroidCompanionApp.Size = new System.Drawing.Size(188, 24);
            this.menuAndroidCompanionApp.Text = "Android Companion App";
            this.menuAndroidCompanionApp.Click += new System.EventHandler(this.menuAndroidCompanionApp_Click);
            // 
            // menuRefresh
            // 
            this.menuRefresh.Name = "menuRefresh";
            this.menuRefresh.Size = new System.Drawing.Size(70, 24);
            this.menuRefresh.Text = "Refresh";
            this.menuRefresh.Click += new System.EventHandler(this.menuRefresh_Click);
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(62, 24);
            this.menuAbout.Text = "About";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // frameFilterItems
            // 
            this.frameFilterItems.Controls.Add(this.lblUsersFilter);
            this.frameFilterItems.Controls.Add(this.cbxUsersFilter);
            this.frameFilterItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frameFilterItems.Location = new System.Drawing.Point(9, 36);
            this.frameFilterItems.Margin = new System.Windows.Forms.Padding(4);
            this.frameFilterItems.Name = "frameFilterItems";
            this.frameFilterItems.Padding = new System.Windows.Forms.Padding(4);
            this.frameFilterItems.Size = new System.Drawing.Size(263, 62);
            this.frameFilterItems.TabIndex = 4;
            this.frameFilterItems.TabStop = false;
            // 
            // lblUsersFilter
            // 
            this.lblUsersFilter.AutoSize = true;
            this.lblUsersFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsersFilter.Location = new System.Drawing.Point(19, 21);
            this.lblUsersFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsersFilter.Name = "lblUsersFilter";
            this.lblUsersFilter.Size = new System.Drawing.Size(44, 18);
            this.lblUsersFilter.TabIndex = 31;
            this.lblUsersFilter.Text = "User:";
            // 
            // cbxUsersFilter
            // 
            this.cbxUsersFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxUsersFilter.DisplayMember = "User_ID";
            this.cbxUsersFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUsersFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUsersFilter.FormattingEnabled = true;
            this.cbxUsersFilter.Location = new System.Drawing.Point(67, 17);
            this.cbxUsersFilter.Margin = new System.Windows.Forms.Padding(4);
            this.cbxUsersFilter.Name = "cbxUsersFilter";
            this.cbxUsersFilter.Size = new System.Drawing.Size(176, 26);
            this.cbxUsersFilter.TabIndex = 30;
            this.cbxUsersFilter.TabStop = false;
            this.cbxUsersFilter.ValueMember = "User_ID";
            this.cbxUsersFilter.SelectedIndexChanged += new System.EventHandler(this.cbxUsersFilter_SelectedIndexChanged);
            // 
            // SplitContainer2
            // 
            this.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.SplitContainer2.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.SplitContainer2.Name = "SplitContainer2";
            // 
            // SplitContainer2.Panel1
            // 
            this.SplitContainer2.Panel1.Controls.Add(this.listPasswordItems);
            this.SplitContainer2.Panel1.Controls.Add(this.cbxItemTypes);
            // 
            // SplitContainer2.Panel2
            // 
            this.SplitContainer2.Panel2.Controls.Add(this.frameWebsite);
            this.SplitContainer2.Panel2.Controls.Add(this.frameGeneralAccountInformation);
            this.SplitContainer2.Panel2.Controls.Add(this.framePasswordItem);
            this.SplitContainer2.Panel2.Controls.Add(this.frameComments);
            this.SplitContainer2.Panel2.Controls.Add(this.frameSoftwareKeyCode);
            this.SplitContainer2.Panel2.Controls.Add(this.frameCreditCardInfo);
            this.SplitContainer2.Size = new System.Drawing.Size(1223, 743);
            this.SplitContainer2.SplitterDistance = 275;
            this.SplitContainer2.SplitterWidth = 7;
            this.SplitContainer2.TabIndex = 7;
            this.SplitContainer2.TabStop = false;
            // 
            // listPasswordItems
            // 
            this.listPasswordItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listPasswordItems.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listPasswordItems.FormattingEnabled = true;
            this.listPasswordItems.ItemHeight = 16;
            this.listPasswordItems.Location = new System.Drawing.Point(3, 43);
            this.listPasswordItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listPasswordItems.Name = "listPasswordItems";
            this.listPasswordItems.Size = new System.Drawing.Size(269, 676);
            this.listPasswordItems.TabIndex = 46;
            this.listPasswordItems.UseTabStops = false;
            // 
            // cbxItemTypes
            // 
            this.cbxItemTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxItemTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxItemTypes.FormattingEnabled = true;
            this.cbxItemTypes.Location = new System.Drawing.Point(3, 14);
            this.cbxItemTypes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxItemTypes.Name = "cbxItemTypes";
            this.cbxItemTypes.Size = new System.Drawing.Size(269, 26);
            this.cbxItemTypes.TabIndex = 45;
            this.cbxItemTypes.TabStop = false;
            this.cbxItemTypes.SelectedIndexChanged += new System.EventHandler(this.cbxItemTypes_SelectedIndexChanged);
            // 
            // frameWebsite
            // 
            this.frameWebsite.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.frameWebsite.Controls.Add(this.lblWebsitePassword);
            this.frameWebsite.Controls.Add(this.lblWebsiteUserID);
            this.frameWebsite.Controls.Add(this.lblWebsiteURLAddress);
            this.frameWebsite.Controls.Add(this.btnCopyPassword);
            this.frameWebsite.Controls.Add(this.btnCopyPasswordAndGoToWebsite);
            this.frameWebsite.Controls.Add(this.txtWebsitePassword);
            this.frameWebsite.Controls.Add(this.txtWebsiteUserID);
            this.frameWebsite.Controls.Add(this.txtWebsiteURLAddress);
            this.frameWebsite.Location = new System.Drawing.Point(69, 348);
            this.frameWebsite.Margin = new System.Windows.Forms.Padding(4);
            this.frameWebsite.Name = "frameWebsite";
            this.frameWebsite.Padding = new System.Windows.Forms.Padding(4);
            this.frameWebsite.Size = new System.Drawing.Size(611, 217);
            this.frameWebsite.TabIndex = 21;
            this.frameWebsite.TabStop = false;
            this.frameWebsite.Text = "Website Information:";
            // 
            // lblWebsitePassword
            // 
            this.lblWebsitePassword.AutoSize = true;
            this.lblWebsitePassword.Location = new System.Drawing.Point(27, 126);
            this.lblWebsitePassword.Name = "lblWebsitePassword";
            this.lblWebsitePassword.Size = new System.Drawing.Size(128, 17);
            this.lblWebsitePassword.TabIndex = 51;
            this.lblWebsitePassword.Text = "Website Password:";
            // 
            // lblWebsiteUserID
            // 
            this.lblWebsiteUserID.AutoSize = true;
            this.lblWebsiteUserID.Location = new System.Drawing.Point(27, 94);
            this.lblWebsiteUserID.Name = "lblWebsiteUserID";
            this.lblWebsiteUserID.Size = new System.Drawing.Size(114, 17);
            this.lblWebsiteUserID.TabIndex = 50;
            this.lblWebsiteUserID.Text = "Website User ID:";
            // 
            // lblWebsiteURLAddress
            // 
            this.lblWebsiteURLAddress.AutoSize = true;
            this.lblWebsiteURLAddress.Location = new System.Drawing.Point(23, 46);
            this.lblWebsiteURLAddress.Name = "lblWebsiteURLAddress";
            this.lblWebsiteURLAddress.Size = new System.Drawing.Size(151, 17);
            this.lblWebsiteURLAddress.TabIndex = 49;
            this.lblWebsiteURLAddress.Text = "Website URL Address:";
            // 
            // btnCopyPassword
            // 
            this.btnCopyPassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCopyPassword.Location = new System.Drawing.Point(201, 153);
            this.btnCopyPassword.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopyPassword.Name = "btnCopyPassword";
            this.btnCopyPassword.Size = new System.Drawing.Size(223, 46);
            this.btnCopyPassword.TabIndex = 48;
            this.btnCopyPassword.TabStop = false;
            this.btnCopyPassword.Text = "Copy Password";
            this.btnCopyPassword.UseVisualStyleBackColor = true;
            // 
            // btnCopyPasswordAndGoToWebsite
            // 
            this.btnCopyPasswordAndGoToWebsite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyPasswordAndGoToWebsite.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCopyPasswordAndGoToWebsite.Location = new System.Drawing.Point(399, 153);
            this.btnCopyPasswordAndGoToWebsite.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopyPasswordAndGoToWebsite.Name = "btnCopyPasswordAndGoToWebsite";
            this.btnCopyPasswordAndGoToWebsite.Size = new System.Drawing.Size(203, 46);
            this.btnCopyPasswordAndGoToWebsite.TabIndex = 47;
            this.btnCopyPasswordAndGoToWebsite.TabStop = false;
            this.btnCopyPasswordAndGoToWebsite.Text = "GoTo Website";
            this.btnCopyPasswordAndGoToWebsite.UseVisualStyleBackColor = true;
            // 
            // txtWebsitePassword
            // 
            this.txtWebsitePassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWebsitePassword.Location = new System.Drawing.Point(201, 122);
            this.txtWebsitePassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtWebsitePassword.Name = "txtWebsitePassword";
            this.txtWebsitePassword.Size = new System.Drawing.Size(400, 22);
            this.txtWebsitePassword.TabIndex = 2;
            // 
            // txtWebsiteUserID
            // 
            this.txtWebsiteUserID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWebsiteUserID.Location = new System.Drawing.Point(201, 90);
            this.txtWebsiteUserID.Margin = new System.Windows.Forms.Padding(4);
            this.txtWebsiteUserID.Name = "txtWebsiteUserID";
            this.txtWebsiteUserID.Size = new System.Drawing.Size(400, 22);
            this.txtWebsiteUserID.TabIndex = 1;
            // 
            // txtWebsiteURLAddress
            // 
            this.txtWebsiteURLAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWebsiteURLAddress.Location = new System.Drawing.Point(201, 27);
            this.txtWebsiteURLAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtWebsiteURLAddress.Multiline = true;
            this.txtWebsiteURLAddress.Name = "txtWebsiteURLAddress";
            this.txtWebsiteURLAddress.Size = new System.Drawing.Size(400, 54);
            this.txtWebsiteURLAddress.TabIndex = 0;
            // 
            // frameGeneralAccountInformation
            // 
            this.frameGeneralAccountInformation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.frameGeneralAccountInformation.Controls.Add(this.lblGeneralAccountPrimaryPhoneNumber);
            this.frameGeneralAccountInformation.Controls.Add(this.lblGeneralAccountNumber);
            this.frameGeneralAccountInformation.Controls.Add(this.btnCopyGeneralAccountNumber);
            this.frameGeneralAccountInformation.Controls.Add(this.lblGeneralAccountAltPhoneNumber);
            this.frameGeneralAccountInformation.Controls.Add(this.txtGeneralAccountAltPhoneNumber);
            this.frameGeneralAccountInformation.Controls.Add(this.txtGeneralAccountPrimaryPhoneNumber);
            this.frameGeneralAccountInformation.Controls.Add(this.txtGeneralAccountNumber);
            this.frameGeneralAccountInformation.Location = new System.Drawing.Point(129, 268);
            this.frameGeneralAccountInformation.Margin = new System.Windows.Forms.Padding(4);
            this.frameGeneralAccountInformation.Name = "frameGeneralAccountInformation";
            this.frameGeneralAccountInformation.Padding = new System.Windows.Forms.Padding(4);
            this.frameGeneralAccountInformation.Size = new System.Drawing.Size(611, 144);
            this.frameGeneralAccountInformation.TabIndex = 20;
            this.frameGeneralAccountInformation.TabStop = false;
            this.frameGeneralAccountInformation.Text = "General Account Information:";
            // 
            // lblGeneralAccountPrimaryPhoneNumber
            // 
            this.lblGeneralAccountPrimaryPhoneNumber.AutoSize = true;
            this.lblGeneralAccountPrimaryPhoneNumber.Location = new System.Drawing.Point(33, 55);
            this.lblGeneralAccountPrimaryPhoneNumber.Name = "lblGeneralAccountPrimaryPhoneNumber";
            this.lblGeneralAccountPrimaryPhoneNumber.Size = new System.Drawing.Size(114, 17);
            this.lblGeneralAccountPrimaryPhoneNumber.TabIndex = 48;
            this.lblGeneralAccountPrimaryPhoneNumber.Text = "Primary Number:";
            // 
            // lblGeneralAccountNumber
            // 
            this.lblGeneralAccountNumber.AutoSize = true;
            this.lblGeneralAccountNumber.Location = new System.Drawing.Point(33, 23);
            this.lblGeneralAccountNumber.Name = "lblGeneralAccountNumber";
            this.lblGeneralAccountNumber.Size = new System.Drawing.Size(117, 17);
            this.lblGeneralAccountNumber.TabIndex = 47;
            this.lblGeneralAccountNumber.Text = "Account Number:";
            // 
            // btnCopyGeneralAccountNumber
            // 
            this.btnCopyGeneralAccountNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyGeneralAccountNumber.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCopyGeneralAccountNumber.Location = new System.Drawing.Point(201, 82);
            this.btnCopyGeneralAccountNumber.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopyGeneralAccountNumber.Name = "btnCopyGeneralAccountNumber";
            this.btnCopyGeneralAccountNumber.Size = new System.Drawing.Size(400, 46);
            this.btnCopyGeneralAccountNumber.TabIndex = 46;
            this.btnCopyGeneralAccountNumber.TabStop = false;
            this.btnCopyGeneralAccountNumber.Text = "Copy Account Number";
            this.btnCopyGeneralAccountNumber.UseVisualStyleBackColor = true;
            // 
            // lblGeneralAccountAltPhoneNumber
            // 
            this.lblGeneralAccountAltPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGeneralAccountAltPhoneNumber.AutoSize = true;
            this.lblGeneralAccountAltPhoneNumber.Location = new System.Drawing.Point(341, 53);
            this.lblGeneralAccountAltPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGeneralAccountAltPhoneNumber.Name = "lblGeneralAccountAltPhoneNumber";
            this.lblGeneralAccountAltPhoneNumber.Size = new System.Drawing.Size(114, 17);
            this.lblGeneralAccountAltPhoneNumber.TabIndex = 42;
            this.lblGeneralAccountAltPhoneNumber.Text = "Alternate Phone:";
            // 
            // txtGeneralAccountAltPhoneNumber
            // 
            this.txtGeneralAccountAltPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGeneralAccountAltPhoneNumber.Location = new System.Drawing.Point(461, 50);
            this.txtGeneralAccountAltPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtGeneralAccountAltPhoneNumber.Name = "txtGeneralAccountAltPhoneNumber";
            this.txtGeneralAccountAltPhoneNumber.Size = new System.Drawing.Size(140, 22);
            this.txtGeneralAccountAltPhoneNumber.TabIndex = 2;
            // 
            // txtGeneralAccountPrimaryPhoneNumber
            // 
            this.txtGeneralAccountPrimaryPhoneNumber.Location = new System.Drawing.Point(201, 52);
            this.txtGeneralAccountPrimaryPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtGeneralAccountPrimaryPhoneNumber.Name = "txtGeneralAccountPrimaryPhoneNumber";
            this.txtGeneralAccountPrimaryPhoneNumber.Size = new System.Drawing.Size(140, 22);
            this.txtGeneralAccountPrimaryPhoneNumber.TabIndex = 1;
            // 
            // txtGeneralAccountNumber
            // 
            this.txtGeneralAccountNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGeneralAccountNumber.Location = new System.Drawing.Point(201, 20);
            this.txtGeneralAccountNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtGeneralAccountNumber.Name = "txtGeneralAccountNumber";
            this.txtGeneralAccountNumber.Size = new System.Drawing.Size(401, 22);
            this.txtGeneralAccountNumber.TabIndex = 0;
            // 
            // framePasswordItem
            // 
            this.framePasswordItem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.framePasswordItem.Controls.Add(this.txtIsDirty);
            this.framePasswordItem.Controls.Add(this.txtItemName);
            this.framePasswordItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.framePasswordItem.Location = new System.Drawing.Point(272, -7);
            this.framePasswordItem.Margin = new System.Windows.Forms.Padding(4);
            this.framePasswordItem.Name = "framePasswordItem";
            this.framePasswordItem.Padding = new System.Windows.Forms.Padding(4);
            this.framePasswordItem.Size = new System.Drawing.Size(611, 65);
            this.framePasswordItem.TabIndex = 17;
            this.framePasswordItem.TabStop = false;
            this.framePasswordItem.Text = "Item:";
            // 
            // txtIsDirty
            // 
            this.txtIsDirty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIsDirty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIsDirty.Location = new System.Drawing.Point(573, 21);
            this.txtIsDirty.Margin = new System.Windows.Forms.Padding(4);
            this.txtIsDirty.Name = "txtIsDirty";
            this.txtIsDirty.Size = new System.Drawing.Size(29, 29);
            this.txtIsDirty.TabIndex = 1;
            this.txtIsDirty.TabStop = false;
            // 
            // txtItemName
            // 
            this.txtItemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(21, 21);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(543, 29);
            this.txtItemName.TabIndex = 0;
            // 
            // frameComments
            // 
            this.frameComments.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.frameComments.Controls.Add(this.txtComments);
            this.frameComments.Location = new System.Drawing.Point(39, 532);
            this.frameComments.Margin = new System.Windows.Forms.Padding(4);
            this.frameComments.Name = "frameComments";
            this.frameComments.Padding = new System.Windows.Forms.Padding(4);
            this.frameComments.Size = new System.Drawing.Size(611, 225);
            this.frameComments.TabIndex = 22;
            this.frameComments.TabStop = false;
            this.frameComments.Text = "Comments:";
            // 
            // txtComments
            // 
            this.txtComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComments.Location = new System.Drawing.Point(4, 19);
            this.txtComments.Margin = new System.Windows.Forms.Padding(4);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtComments.Size = new System.Drawing.Size(603, 202);
            this.txtComments.TabIndex = 0;
            // 
            // frameSoftwareKeyCode
            // 
            this.frameSoftwareKeyCode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.frameSoftwareKeyCode.Controls.Add(this.lblSoftwareKeyCode);
            this.frameSoftwareKeyCode.Controls.Add(this.btnCopyKeyCode);
            this.frameSoftwareKeyCode.Controls.Add(this.txtSoftwareKeyCode);
            this.frameSoftwareKeyCode.Controls.Add(this.updnSoftwareKeyCodeSubgroupLength);
            this.frameSoftwareKeyCode.Location = new System.Drawing.Point(232, 48);
            this.frameSoftwareKeyCode.Margin = new System.Windows.Forms.Padding(4);
            this.frameSoftwareKeyCode.Name = "frameSoftwareKeyCode";
            this.frameSoftwareKeyCode.Padding = new System.Windows.Forms.Padding(4);
            this.frameSoftwareKeyCode.Size = new System.Drawing.Size(611, 113);
            this.frameSoftwareKeyCode.TabIndex = 18;
            this.frameSoftwareKeyCode.TabStop = false;
            this.frameSoftwareKeyCode.Text = "Software Key Code Information:";
            // 
            // lblSoftwareKeyCode
            // 
            this.lblSoftwareKeyCode.AutoSize = true;
            this.lblSoftwareKeyCode.Location = new System.Drawing.Point(24, 25);
            this.lblSoftwareKeyCode.Name = "lblSoftwareKeyCode";
            this.lblSoftwareKeyCode.Size = new System.Drawing.Size(132, 17);
            this.lblSoftwareKeyCode.TabIndex = 2;
            this.lblSoftwareKeyCode.Text = "Software Key Code:";
            // 
            // btnCopyKeyCode
            // 
            this.btnCopyKeyCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyKeyCode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCopyKeyCode.Location = new System.Drawing.Point(201, 57);
            this.btnCopyKeyCode.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopyKeyCode.Name = "btnCopyKeyCode";
            this.btnCopyKeyCode.Size = new System.Drawing.Size(401, 46);
            this.btnCopyKeyCode.TabIndex = 1;
            this.btnCopyKeyCode.TabStop = false;
            this.btnCopyKeyCode.Text = "Copy Key Code";
            this.btnCopyKeyCode.UseVisualStyleBackColor = true;
            // 
            // txtSoftwareKeyCode
            // 
            this.txtSoftwareKeyCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoftwareKeyCode.Location = new System.Drawing.Point(201, 23);
            this.txtSoftwareKeyCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoftwareKeyCode.Name = "txtSoftwareKeyCode";
            this.txtSoftwareKeyCode.Size = new System.Drawing.Size(351, 22);
            this.txtSoftwareKeyCode.TabIndex = 0;
            // 
            // updnSoftwareKeyCodeSubgroupLength
            // 
            this.updnSoftwareKeyCodeSubgroupLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updnSoftwareKeyCodeSubgroupLength.Location = new System.Drawing.Point(559, 23);
            this.updnSoftwareKeyCodeSubgroupLength.Margin = new System.Windows.Forms.Padding(4);
            this.updnSoftwareKeyCodeSubgroupLength.Name = "updnSoftwareKeyCodeSubgroupLength";
            this.updnSoftwareKeyCodeSubgroupLength.Size = new System.Drawing.Size(43, 22);
            this.updnSoftwareKeyCodeSubgroupLength.TabIndex = 1;
            // 
            // frameCreditCardInfo
            // 
            this.frameCreditCardInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.frameCreditCardInfo.Controls.Add(this.lblCreditCardPrimaryPhoneNumber);
            this.frameCreditCardInfo.Controls.Add(this.lblExpirationDate);
            this.frameCreditCardInfo.Controls.Add(this.lblCreditCardAccountNumber);
            this.frameCreditCardInfo.Controls.Add(this.picCheckMark);
            this.frameCreditCardInfo.Controls.Add(this.txtCreditCardExpirationYear);
            this.frameCreditCardInfo.Controls.Add(this.txtCreditCardExpirationMonth);
            this.frameCreditCardInfo.Controls.Add(this.btnCopyCreditCardAccountNumber);
            this.frameCreditCardInfo.Controls.Add(this.lblCreditCardAltPhoneNumber);
            this.frameCreditCardInfo.Controls.Add(this.txtCreditCardType);
            this.frameCreditCardInfo.Controls.Add(this.lblCreditCardType);
            this.frameCreditCardInfo.Controls.Add(this.txtCreditCardSecurityCode);
            this.frameCreditCardInfo.Controls.Add(this.lblCardSecurityCode);
            this.frameCreditCardInfo.Controls.Add(this.txtCreditCardAltPhoneNumber);
            this.frameCreditCardInfo.Controls.Add(this.txtCreditCardPrimaryPhoneNumber);
            this.frameCreditCardInfo.Controls.Add(this.txtCreditCardAccountNumber);
            this.frameCreditCardInfo.Location = new System.Drawing.Point(181, 113);
            this.frameCreditCardInfo.Margin = new System.Windows.Forms.Padding(4);
            this.frameCreditCardInfo.Name = "frameCreditCardInfo";
            this.frameCreditCardInfo.Padding = new System.Windows.Forms.Padding(4);
            this.frameCreditCardInfo.Size = new System.Drawing.Size(611, 217);
            this.frameCreditCardInfo.TabIndex = 19;
            this.frameCreditCardInfo.TabStop = false;
            this.frameCreditCardInfo.Text = "Credit Card Information:";
            // 
            // lblCreditCardPrimaryPhoneNumber
            // 
            this.lblCreditCardPrimaryPhoneNumber.AutoSize = true;
            this.lblCreditCardPrimaryPhoneNumber.Location = new System.Drawing.Point(24, 127);
            this.lblCreditCardPrimaryPhoneNumber.Name = "lblCreditCardPrimaryPhoneNumber";
            this.lblCreditCardPrimaryPhoneNumber.Size = new System.Drawing.Size(114, 17);
            this.lblCreditCardPrimaryPhoneNumber.TabIndex = 49;
            this.lblCreditCardPrimaryPhoneNumber.Text = "Primary Number:";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Location = new System.Drawing.Point(24, 95);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(108, 17);
            this.lblExpirationDate.TabIndex = 48;
            this.lblExpirationDate.Text = "Expiration Date:";
            // 
            // lblCreditCardAccountNumber
            // 
            this.lblCreditCardAccountNumber.AutoSize = true;
            this.lblCreditCardAccountNumber.Location = new System.Drawing.Point(24, 31);
            this.lblCreditCardAccountNumber.Name = "lblCreditCardAccountNumber";
            this.lblCreditCardAccountNumber.Size = new System.Drawing.Size(133, 17);
            this.lblCreditCardAccountNumber.TabIndex = 3;
            this.lblCreditCardAccountNumber.Text = "Credit Card Number";
            // 
            // picCheckMark
            // 
            this.picCheckMark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picCheckMark.BackColor = System.Drawing.SystemColors.Window;
            this.picCheckMark.Image = ((System.Drawing.Image)(resources.GetObject("picCheckMark.Image")));
            this.picCheckMark.Location = new System.Drawing.Point(573, 60);
            this.picCheckMark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picCheckMark.Name = "picCheckMark";
            this.picCheckMark.Size = new System.Drawing.Size(27, 27);
            this.picCheckMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCheckMark.TabIndex = 47;
            this.picCheckMark.TabStop = false;
            // 
            // txtCreditCardExpirationYear
            // 
            this.txtCreditCardExpirationYear.Location = new System.Drawing.Point(263, 92);
            this.txtCreditCardExpirationYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreditCardExpirationYear.MaxLength = 4;
            this.txtCreditCardExpirationYear.Name = "txtCreditCardExpirationYear";
            this.txtCreditCardExpirationYear.Size = new System.Drawing.Size(79, 22);
            this.txtCreditCardExpirationYear.TabIndex = 3;
            // 
            // txtCreditCardExpirationMonth
            // 
            this.txtCreditCardExpirationMonth.Location = new System.Drawing.Point(201, 92);
            this.txtCreditCardExpirationMonth.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreditCardExpirationMonth.MaxLength = 2;
            this.txtCreditCardExpirationMonth.Name = "txtCreditCardExpirationMonth";
            this.txtCreditCardExpirationMonth.Size = new System.Drawing.Size(55, 22);
            this.txtCreditCardExpirationMonth.TabIndex = 2;
            // 
            // btnCopyCreditCardAccountNumber
            // 
            this.btnCopyCreditCardAccountNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyCreditCardAccountNumber.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCopyCreditCardAccountNumber.Location = new System.Drawing.Point(201, 156);
            this.btnCopyCreditCardAccountNumber.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopyCreditCardAccountNumber.Name = "btnCopyCreditCardAccountNumber";
            this.btnCopyCreditCardAccountNumber.Size = new System.Drawing.Size(400, 46);
            this.btnCopyCreditCardAccountNumber.TabIndex = 46;
            this.btnCopyCreditCardAccountNumber.TabStop = false;
            this.btnCopyCreditCardAccountNumber.Text = "Copy Credit Card Account Number";
            this.btnCopyCreditCardAccountNumber.UseVisualStyleBackColor = true;
            // 
            // lblCreditCardAltPhoneNumber
            // 
            this.lblCreditCardAltPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCreditCardAltPhoneNumber.AutoSize = true;
            this.lblCreditCardAltPhoneNumber.Location = new System.Drawing.Point(309, 127);
            this.lblCreditCardAltPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreditCardAltPhoneNumber.Name = "lblCreditCardAltPhoneNumber";
            this.lblCreditCardAltPhoneNumber.Size = new System.Drawing.Size(114, 17);
            this.lblCreditCardAltPhoneNumber.TabIndex = 42;
            this.lblCreditCardAltPhoneNumber.Text = "Alternate Phone:";
            // 
            // txtCreditCardType
            // 
            this.txtCreditCardType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCreditCardType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditCardType.Location = new System.Drawing.Point(427, 60);
            this.txtCreditCardType.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreditCardType.Name = "txtCreditCardType";
            this.txtCreditCardType.Size = new System.Drawing.Size(140, 23);
            this.txtCreditCardType.TabIndex = 2;
            this.txtCreditCardType.TabStop = false;
            // 
            // lblCreditCardType
            // 
            this.lblCreditCardType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCreditCardType.AutoSize = true;
            this.lblCreditCardType.Location = new System.Drawing.Point(307, 63);
            this.lblCreditCardType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreditCardType.Name = "lblCreditCardType";
            this.lblCreditCardType.Size = new System.Drawing.Size(119, 17);
            this.lblCreditCardType.TabIndex = 39;
            this.lblCreditCardType.Text = "Credit Card Type:";
            // 
            // txtCreditCardSecurityCode
            // 
            this.txtCreditCardSecurityCode.Location = new System.Drawing.Point(201, 60);
            this.txtCreditCardSecurityCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreditCardSecurityCode.Name = "txtCreditCardSecurityCode";
            this.txtCreditCardSecurityCode.Size = new System.Drawing.Size(140, 22);
            this.txtCreditCardSecurityCode.TabIndex = 1;
            // 
            // lblCardSecurityCode
            // 
            this.lblCardSecurityCode.AutoSize = true;
            this.lblCardSecurityCode.Location = new System.Drawing.Point(24, 63);
            this.lblCardSecurityCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCardSecurityCode.Name = "lblCardSecurityCode";
            this.lblCardSecurityCode.Size = new System.Drawing.Size(175, 17);
            this.lblCardSecurityCode.TabIndex = 37;
            this.lblCardSecurityCode.Text = "Card Security Code (CSC):";
            // 
            // txtCreditCardAltPhoneNumber
            // 
            this.txtCreditCardAltPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCreditCardAltPhoneNumber.Location = new System.Drawing.Point(427, 124);
            this.txtCreditCardAltPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreditCardAltPhoneNumber.Name = "txtCreditCardAltPhoneNumber";
            this.txtCreditCardAltPhoneNumber.Size = new System.Drawing.Size(140, 22);
            this.txtCreditCardAltPhoneNumber.TabIndex = 5;
            // 
            // txtCreditCardPrimaryPhoneNumber
            // 
            this.txtCreditCardPrimaryPhoneNumber.Location = new System.Drawing.Point(201, 124);
            this.txtCreditCardPrimaryPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreditCardPrimaryPhoneNumber.Name = "txtCreditCardPrimaryPhoneNumber";
            this.txtCreditCardPrimaryPhoneNumber.Size = new System.Drawing.Size(140, 22);
            this.txtCreditCardPrimaryPhoneNumber.TabIndex = 4;
            // 
            // txtCreditCardAccountNumber
            // 
            this.txtCreditCardAccountNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCreditCardAccountNumber.Location = new System.Drawing.Point(201, 28);
            this.txtCreditCardAccountNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreditCardAccountNumber.Name = "txtCreditCardAccountNumber";
            this.txtCreditCardAccountNumber.Size = new System.Drawing.Size(400, 22);
            this.txtCreditCardAccountNumber.TabIndex = 0;
            // 
            // savePasswordsFileBackgroundWorker
            // 
            this.savePasswordsFileBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.savePasswordsFileBackgroundWorker_DoWork);
            this.savePasswordsFileBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.savePasswordsFileBackgroundWorker_RunWorkerCompleted);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1235, 865);
            this.Controls.Add(this.SplitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Passwords";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel1.PerformLayout();
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            this.frameDeleteNewButtons.ResumeLayout(false);
            this.frameSearch.ResumeLayout(false);
            this.frameSearch.PerformLayout();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.frameFilterItems.ResumeLayout(false);
            this.frameFilterItems.PerformLayout();
            this.SplitContainer2.Panel1.ResumeLayout(false);
            this.SplitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).EndInit();
            this.SplitContainer2.ResumeLayout(false);
            this.frameWebsite.ResumeLayout(false);
            this.frameWebsite.PerformLayout();
            this.frameGeneralAccountInformation.ResumeLayout(false);
            this.frameGeneralAccountInformation.PerformLayout();
            this.framePasswordItem.ResumeLayout(false);
            this.framePasswordItem.PerformLayout();
            this.frameComments.ResumeLayout(false);
            this.frameComments.PerformLayout();
            this.frameSoftwareKeyCode.ResumeLayout(false);
            this.frameSoftwareKeyCode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updnSoftwareKeyCodeSubgroupLength)).EndInit();
            this.frameCreditCardInfo.ResumeLayout(false);
            this.frameCreditCardInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCheckMark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.SaveFileDialog SaveFileDialog1;
        internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        internal System.Windows.Forms.TextBox txtSearch;
        internal System.Windows.Forms.ToolStripMenuItem menuSave;
        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal System.Windows.Forms.GroupBox frameSearch;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem menuAbout;
        internal System.Windows.Forms.ToolStripMenuItem menuRandomPassword;
        internal System.Windows.Forms.GroupBox frameFilterItems;
        internal System.Windows.Forms.Label lblUsersFilter;
        internal System.Windows.Forms.ComboBox cbxUsersFilter;
        internal System.Windows.Forms.SplitContainer SplitContainer2;
        private System.Windows.Forms.ComboBox cbxItemTypes;
        private System.Windows.Forms.ListBox listPasswordItems;
        private System.Windows.Forms.ToolStripMenuItem menuChangeAppPassword;
        internal System.Windows.Forms.GroupBox frameDeleteNewButtons;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolStripMenuItem menuAndroidCompanionApp;
        private System.Windows.Forms.ToolStripMenuItem menuRefresh;
        private System.ComponentModel.BackgroundWorker savePasswordsFileBackgroundWorker;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.ComponentModel.BackgroundWorker backupPasswordsFileBackgroundWorker;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAddNewUser;
        private System.Windows.Forms.ToolStripMenuItem menuDeleteUser;
        internal System.Windows.Forms.GroupBox frameWebsite;
        private System.Windows.Forms.Label lblWebsitePassword;
        private System.Windows.Forms.Label lblWebsiteUserID;
        private System.Windows.Forms.Label lblWebsiteURLAddress;
        internal System.Windows.Forms.Button btnCopyPassword;
        internal System.Windows.Forms.Button btnCopyPasswordAndGoToWebsite;
        internal System.Windows.Forms.TextBox txtWebsitePassword;
        internal System.Windows.Forms.TextBox txtWebsiteUserID;
        internal System.Windows.Forms.TextBox txtWebsiteURLAddress;
        internal System.Windows.Forms.GroupBox frameGeneralAccountInformation;
        private System.Windows.Forms.Label lblGeneralAccountPrimaryPhoneNumber;
        private System.Windows.Forms.Label lblGeneralAccountNumber;
        internal System.Windows.Forms.Button btnCopyGeneralAccountNumber;
        internal System.Windows.Forms.Label lblGeneralAccountAltPhoneNumber;
        internal System.Windows.Forms.TextBox txtGeneralAccountAltPhoneNumber;
        internal System.Windows.Forms.TextBox txtGeneralAccountPrimaryPhoneNumber;
        internal System.Windows.Forms.TextBox txtGeneralAccountNumber;
        internal System.Windows.Forms.GroupBox framePasswordItem;
        internal System.Windows.Forms.TextBox txtIsDirty;
        internal System.Windows.Forms.TextBox txtItemName;
        internal System.Windows.Forms.GroupBox frameComments;
        internal System.Windows.Forms.TextBox txtComments;
        internal System.Windows.Forms.GroupBox frameSoftwareKeyCode;
        private System.Windows.Forms.Label lblSoftwareKeyCode;
        internal System.Windows.Forms.Button btnCopyKeyCode;
        internal System.Windows.Forms.TextBox txtSoftwareKeyCode;
        internal System.Windows.Forms.NumericUpDown updnSoftwareKeyCodeSubgroupLength;
        internal System.Windows.Forms.GroupBox frameCreditCardInfo;
        private System.Windows.Forms.Label lblCreditCardPrimaryPhoneNumber;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Label lblCreditCardAccountNumber;
        private System.Windows.Forms.PictureBox picCheckMark;
        internal System.Windows.Forms.TextBox txtCreditCardExpirationYear;
        internal System.Windows.Forms.TextBox txtCreditCardExpirationMonth;
        internal System.Windows.Forms.Button btnCopyCreditCardAccountNumber;
        internal System.Windows.Forms.Label lblCreditCardAltPhoneNumber;
        internal System.Windows.Forms.TextBox txtCreditCardType;
        internal System.Windows.Forms.Label lblCreditCardType;
        internal System.Windows.Forms.TextBox txtCreditCardSecurityCode;
        internal System.Windows.Forms.Label lblCardSecurityCode;
        internal System.Windows.Forms.TextBox txtCreditCardAltPhoneNumber;
        internal System.Windows.Forms.TextBox txtCreditCardPrimaryPhoneNumber;
        internal System.Windows.Forms.TextBox txtCreditCardAccountNumber;
    }
}

