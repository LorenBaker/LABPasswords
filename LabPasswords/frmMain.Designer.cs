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
            this.tableLayoutPanel_Header = new System.Windows.Forms.TableLayoutPanel();
            this.frameUsers = new System.Windows.Forms.GroupBox();
            this.cbxUsersFilter = new System.Windows.Forms.ComboBox();
            this.frameSearch = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_DeleteNewButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuChangeAppPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRandomPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAndroidCompanionApp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.SplitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel_ItemsList = new System.Windows.Forms.TableLayoutPanel();
            this.frameItemType = new System.Windows.Forms.GroupBox();
            this.cbxItemTypes = new System.Windows.Forms.ComboBox();
            this.frameItemsList = new System.Windows.Forms.GroupBox();
            this.listPasswordItems = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel_ItemDetails = new System.Windows.Forms.TableLayoutPanel();
            this.framePasswordItem = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_Item = new System.Windows.Forms.TableLayoutPanel();
            this.txtIsDirty = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.frameComments = new System.Windows.Forms.GroupBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.frameWebsite = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_Website = new System.Windows.Forms.TableLayoutPanel();
            this.lblWebsitePassword = new System.Windows.Forms.Label();
            this.btnCopyPassword = new System.Windows.Forms.Button();
            this.txtWebsitePassword = new System.Windows.Forms.TextBox();
            this.lblWebsiteUserID = new System.Windows.Forms.Label();
            this.lblWebsiteURLAddress = new System.Windows.Forms.Label();
            this.txtWebsiteURLAddress = new System.Windows.Forms.TextBox();
            this.txtWebsiteUserID = new System.Windows.Forms.TextBox();
            this.btnCopyPasswordAndGoToWebsite = new System.Windows.Forms.Button();
            this.frameCreditCardInfo = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_CreditCard = new System.Windows.Forms.TableLayoutPanel();
            this.txtCreditCardAccountNumber = new System.Windows.Forms.TextBox();
            this.lblCreditCardPrimaryPhoneNumber = new System.Windows.Forms.Label();
            this.lblCardSecurityCode = new System.Windows.Forms.Label();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.txtCreditCardPrimaryPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtCreditCardSecurityCode = new System.Windows.Forms.TextBox();
            this.lblCreditCardAccountNumber = new System.Windows.Forms.Label();
            this.picCheckMark = new System.Windows.Forms.PictureBox();
            this.txtCreditCardType = new System.Windows.Forms.TextBox();
            this.lblCreditCardType = new System.Windows.Forms.Label();
            this.txtCreditCardAltPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblCreditCardAltPhoneNumber = new System.Windows.Forms.Label();
            this.btnCopyCreditCardAccountNumber = new System.Windows.Forms.Button();
            this.txtCreditCardExpirationYear = new System.Windows.Forms.TextBox();
            this.txtCreditCardExpirationMonth = new System.Windows.Forms.TextBox();
            this.frameGeneralAccountInformation = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_GeneralAccount = new System.Windows.Forms.TableLayoutPanel();
            this.btnCopyGeneralAccountNumber = new System.Windows.Forms.Button();
            this.txtGeneralAccountNumber = new System.Windows.Forms.TextBox();
            this.lblGeneralAccountNumber = new System.Windows.Forms.Label();
            this.lblGeneralAccountPrimaryPhoneNumber = new System.Windows.Forms.Label();
            this.txtGeneralAccountAltPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblGeneralAccountAltPhoneNumber = new System.Windows.Forms.Label();
            this.txtGeneralAccountPrimaryPhoneNumber = new System.Windows.Forms.TextBox();
            this.frameSoftwareKeyCode = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_Software = new System.Windows.Forms.TableLayoutPanel();
            this.updnSoftwareKeyCodeSubgroupLength = new System.Windows.Forms.NumericUpDown();
            this.lblSoftwareKeyCode = new System.Windows.Forms.Label();
            this.txtSoftwareKeyCode = new System.Windows.Forms.TextBox();
            this.btnCopyKeyCode = new System.Windows.Forms.Button();
            this.savePasswordsFileBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.backupPasswordsFileBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.tableLayoutPanel_Header.SuspendLayout();
            this.frameUsers.SuspendLayout();
            this.frameSearch.SuspendLayout();
            this.tableLayoutPanel_DeleteNewButtons.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).BeginInit();
            this.SplitContainer2.Panel1.SuspendLayout();
            this.SplitContainer2.Panel2.SuspendLayout();
            this.SplitContainer2.SuspendLayout();
            this.tableLayoutPanel_ItemsList.SuspendLayout();
            this.frameItemType.SuspendLayout();
            this.frameItemsList.SuspendLayout();
            this.tableLayoutPanel_ItemDetails.SuspendLayout();
            this.framePasswordItem.SuspendLayout();
            this.tableLayoutPanel_Item.SuspendLayout();
            this.frameComments.SuspendLayout();
            this.frameWebsite.SuspendLayout();
            this.tableLayoutPanel_Website.SuspendLayout();
            this.frameCreditCardInfo.SuspendLayout();
            this.tableLayoutPanel_CreditCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCheckMark)).BeginInit();
            this.frameGeneralAccountInformation.SuspendLayout();
            this.tableLayoutPanel_GeneralAccount.SuspendLayout();
            this.frameSoftwareKeyCode.SuspendLayout();
            this.tableLayoutPanel_Software.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updnSoftwareKeyCodeSubgroupLength)).BeginInit();
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
            this.txtSearch.Location = new System.Drawing.Point(10, 23);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(583, 24);
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
            this.SplitContainer1.Panel1.Controls.Add(this.tableLayoutPanel_Header);
            this.SplitContainer1.Panel1.Controls.Add(this.MenuStrip1);
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.AutoScroll = true;
            this.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SplitContainer1.Panel2.Controls.Add(this.SplitContainer2);
            this.SplitContainer1.Size = new System.Drawing.Size(1227, 857);
            this.SplitContainer1.SplitterDistance = 100;
            this.SplitContainer1.SplitterWidth = 1;
            this.SplitContainer1.TabIndex = 1;
            this.SplitContainer1.TabStop = false;
            // 
            // tableLayoutPanel_Header
            // 
            this.tableLayoutPanel_Header.ColumnCount = 3;
            this.tableLayoutPanel_Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Header.Controls.Add(this.frameUsers, 0, 0);
            this.tableLayoutPanel_Header.Controls.Add(this.frameSearch, 1, 0);
            this.tableLayoutPanel_Header.Controls.Add(this.tableLayoutPanel_DeleteNewButtons, 2, 0);
            this.tableLayoutPanel_Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Header.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel_Header.Name = "tableLayoutPanel_Header";
            this.tableLayoutPanel_Header.RowCount = 1;
            this.tableLayoutPanel_Header.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Header.Size = new System.Drawing.Size(1223, 68);
            this.tableLayoutPanel_Header.TabIndex = 7;
            // 
            // frameUsers
            // 
            this.frameUsers.Controls.Add(this.cbxUsersFilter);
            this.frameUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frameUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frameUsers.Location = new System.Drawing.Point(4, 4);
            this.frameUsers.Margin = new System.Windows.Forms.Padding(4);
            this.frameUsers.Name = "frameUsers";
            this.frameUsers.Padding = new System.Windows.Forms.Padding(6);
            this.frameUsers.Size = new System.Drawing.Size(297, 60);
            this.frameUsers.TabIndex = 4;
            this.frameUsers.TabStop = false;
            this.frameUsers.Text = "User:";
            // 
            // cbxUsersFilter
            // 
            this.cbxUsersFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxUsersFilter.DisplayMember = "User_ID";
            this.cbxUsersFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUsersFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUsersFilter.FormattingEnabled = true;
            this.cbxUsersFilter.Location = new System.Drawing.Point(10, 20);
            this.cbxUsersFilter.Margin = new System.Windows.Forms.Padding(4);
            this.cbxUsersFilter.Name = "cbxUsersFilter";
            this.cbxUsersFilter.Size = new System.Drawing.Size(277, 26);
            this.cbxUsersFilter.TabIndex = 30;
            this.cbxUsersFilter.TabStop = false;
            this.cbxUsersFilter.ValueMember = "User_ID";
            this.cbxUsersFilter.SelectedIndexChanged += new System.EventHandler(this.cbxUsersFilter_SelectedIndexChanged);
            // 
            // frameSearch
            // 
            this.frameSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frameSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.frameSearch.Controls.Add(this.txtSearch);
            this.frameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frameSearch.Location = new System.Drawing.Point(309, 4);
            this.frameSearch.Margin = new System.Windows.Forms.Padding(4);
            this.frameSearch.Name = "frameSearch";
            this.frameSearch.Padding = new System.Windows.Forms.Padding(6);
            this.frameSearch.Size = new System.Drawing.Size(603, 60);
            this.frameSearch.TabIndex = 0;
            this.frameSearch.TabStop = false;
            this.frameSearch.Text = "Search:";
            // 
            // tableLayoutPanel_DeleteNewButtons
            // 
            this.tableLayoutPanel_DeleteNewButtons.ColumnCount = 2;
            this.tableLayoutPanel_DeleteNewButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_DeleteNewButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_DeleteNewButtons.Controls.Add(this.btnNew, 1, 0);
            this.tableLayoutPanel_DeleteNewButtons.Controls.Add(this.btnDelete, 0, 0);
            this.tableLayoutPanel_DeleteNewButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_DeleteNewButtons.Location = new System.Drawing.Point(919, 3);
            this.tableLayoutPanel_DeleteNewButtons.Name = "tableLayoutPanel_DeleteNewButtons";
            this.tableLayoutPanel_DeleteNewButtons.RowCount = 1;
            this.tableLayoutPanel_DeleteNewButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_DeleteNewButtons.Size = new System.Drawing.Size(301, 62);
            this.tableLayoutPanel_DeleteNewButtons.TabIndex = 5;
            // 
            // btnNew
            // 
            this.btnNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(162, 6);
            this.btnNew.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(127, 50);
            this.btnNew.TabIndex = 1;
            this.btnNew.TabStop = false;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(12, 6);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 50);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.SplitContainer2.Panel1.Controls.Add(this.tableLayoutPanel_ItemsList);
            // 
            // SplitContainer2.Panel2
            // 
            this.SplitContainer2.Panel2.Controls.Add(this.tableLayoutPanel_ItemDetails);
            this.SplitContainer2.Size = new System.Drawing.Size(1223, 752);
            this.SplitContainer2.SplitterDistance = 275;
            this.SplitContainer2.SplitterWidth = 7;
            this.SplitContainer2.TabIndex = 7;
            this.SplitContainer2.TabStop = false;
            // 
            // tableLayoutPanel_ItemsList
            // 
            this.tableLayoutPanel_ItemsList.ColumnCount = 1;
            this.tableLayoutPanel_ItemsList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_ItemsList.Controls.Add(this.frameItemType, 0, 0);
            this.tableLayoutPanel_ItemsList.Controls.Add(this.frameItemsList, 0, 1);
            this.tableLayoutPanel_ItemsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_ItemsList.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_ItemsList.Name = "tableLayoutPanel_ItemsList";
            this.tableLayoutPanel_ItemsList.RowCount = 2;
            this.tableLayoutPanel_ItemsList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel_ItemsList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_ItemsList.Size = new System.Drawing.Size(275, 752);
            this.tableLayoutPanel_ItemsList.TabIndex = 47;
            // 
            // frameItemType
            // 
            this.frameItemType.AutoSize = true;
            this.frameItemType.Controls.Add(this.cbxItemTypes);
            this.frameItemType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frameItemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frameItemType.Location = new System.Drawing.Point(4, 4);
            this.frameItemType.Margin = new System.Windows.Forms.Padding(4);
            this.frameItemType.Name = "frameItemType";
            this.frameItemType.Padding = new System.Windows.Forms.Padding(4);
            this.frameItemType.Size = new System.Drawing.Size(267, 57);
            this.frameItemType.TabIndex = 0;
            this.frameItemType.TabStop = false;
            this.frameItemType.Text = "Item Type:";
            // 
            // cbxItemTypes
            // 
            this.cbxItemTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxItemTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxItemTypes.FormattingEnabled = true;
            this.cbxItemTypes.Location = new System.Drawing.Point(4, 22);
            this.cbxItemTypes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxItemTypes.Name = "cbxItemTypes";
            this.cbxItemTypes.Size = new System.Drawing.Size(256, 26);
            this.cbxItemTypes.TabIndex = 45;
            this.cbxItemTypes.TabStop = false;
            this.cbxItemTypes.SelectedIndexChanged += new System.EventHandler(this.cbxItemTypes_SelectedIndexChanged);
            // 
            // frameItemsList
            // 
            this.frameItemsList.Controls.Add(this.listPasswordItems);
            this.frameItemsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frameItemsList.Location = new System.Drawing.Point(3, 68);
            this.frameItemsList.Name = "frameItemsList";
            this.frameItemsList.Padding = new System.Windows.Forms.Padding(6, 3, 6, 6);
            this.frameItemsList.Size = new System.Drawing.Size(269, 681);
            this.frameItemsList.TabIndex = 1;
            this.frameItemsList.TabStop = false;
            // 
            // listPasswordItems
            // 
            this.listPasswordItems.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listPasswordItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listPasswordItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPasswordItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPasswordItems.FormattingEnabled = true;
            this.listPasswordItems.ItemHeight = 18;
            this.listPasswordItems.Location = new System.Drawing.Point(6, 18);
            this.listPasswordItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listPasswordItems.Name = "listPasswordItems";
            this.listPasswordItems.Size = new System.Drawing.Size(257, 657);
            this.listPasswordItems.TabIndex = 46;
            this.listPasswordItems.UseTabStops = false;
            // 
            // tableLayoutPanel_ItemDetails
            // 
            this.tableLayoutPanel_ItemDetails.ColumnCount = 1;
            this.tableLayoutPanel_ItemDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_ItemDetails.Controls.Add(this.framePasswordItem, 0, 0);
            this.tableLayoutPanel_ItemDetails.Controls.Add(this.frameComments, 0, 5);
            this.tableLayoutPanel_ItemDetails.Controls.Add(this.frameWebsite, 0, 4);
            this.tableLayoutPanel_ItemDetails.Controls.Add(this.frameCreditCardInfo, 0, 1);
            this.tableLayoutPanel_ItemDetails.Controls.Add(this.frameGeneralAccountInformation, 0, 2);
            this.tableLayoutPanel_ItemDetails.Controls.Add(this.frameSoftwareKeyCode, 0, 3);
            this.tableLayoutPanel_ItemDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_ItemDetails.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_ItemDetails.Name = "tableLayoutPanel_ItemDetails";
            this.tableLayoutPanel_ItemDetails.RowCount = 6;
            this.tableLayoutPanel_ItemDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel_ItemDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_ItemDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_ItemDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_ItemDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_ItemDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel_ItemDetails.Size = new System.Drawing.Size(941, 752);
            this.tableLayoutPanel_ItemDetails.TabIndex = 23;
            // 
            // framePasswordItem
            // 
            this.framePasswordItem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.framePasswordItem.Controls.Add(this.tableLayoutPanel_Item);
            this.framePasswordItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.framePasswordItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.framePasswordItem.Location = new System.Drawing.Point(4, 4);
            this.framePasswordItem.Margin = new System.Windows.Forms.Padding(4);
            this.framePasswordItem.Name = "framePasswordItem";
            this.framePasswordItem.Padding = new System.Windows.Forms.Padding(4);
            this.framePasswordItem.Size = new System.Drawing.Size(933, 57);
            this.framePasswordItem.TabIndex = 17;
            this.framePasswordItem.TabStop = false;
            this.framePasswordItem.Text = "Item:";
            // 
            // tableLayoutPanel_Item
            // 
            this.tableLayoutPanel_Item.ColumnCount = 2;
            this.tableLayoutPanel_Item.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Item.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_Item.Controls.Add(this.txtIsDirty, 1, 0);
            this.tableLayoutPanel_Item.Controls.Add(this.txtItemName, 0, 0);
            this.tableLayoutPanel_Item.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Item.Location = new System.Drawing.Point(4, 21);
            this.tableLayoutPanel_Item.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel_Item.Name = "tableLayoutPanel_Item";
            this.tableLayoutPanel_Item.RowCount = 1;
            this.tableLayoutPanel_Item.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Item.Size = new System.Drawing.Size(925, 32);
            this.tableLayoutPanel_Item.TabIndex = 2;
            // 
            // txtIsDirty
            // 
            this.txtIsDirty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIsDirty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIsDirty.Location = new System.Drawing.Point(896, 0);
            this.txtIsDirty.Margin = new System.Windows.Forms.Padding(0);
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
            this.txtItemName.Location = new System.Drawing.Point(0, 0);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(895, 29);
            this.txtItemName.TabIndex = 0;
            this.txtItemName.Text = "Text";
            // 
            // frameComments
            // 
            this.frameComments.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.frameComments.Controls.Add(this.txtComments);
            this.frameComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frameComments.Location = new System.Drawing.Point(4, 792);
            this.frameComments.Margin = new System.Windows.Forms.Padding(4);
            this.frameComments.Name = "frameComments";
            this.frameComments.Padding = new System.Windows.Forms.Padding(4);
            this.frameComments.Size = new System.Drawing.Size(933, 92);
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
            this.txtComments.Size = new System.Drawing.Size(925, 69);
            this.txtComments.TabIndex = 0;
            // 
            // frameWebsite
            // 
            this.frameWebsite.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.frameWebsite.Controls.Add(this.tableLayoutPanel_Website);
            this.frameWebsite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frameWebsite.Location = new System.Drawing.Point(4, 562);
            this.frameWebsite.Margin = new System.Windows.Forms.Padding(4);
            this.frameWebsite.Name = "frameWebsite";
            this.frameWebsite.Padding = new System.Windows.Forms.Padding(4);
            this.frameWebsite.Size = new System.Drawing.Size(933, 222);
            this.frameWebsite.TabIndex = 21;
            this.frameWebsite.TabStop = false;
            this.frameWebsite.Text = "Website Information:";
            // 
            // tableLayoutPanel_Website
            // 
            this.tableLayoutPanel_Website.ColumnCount = 3;
            this.tableLayoutPanel_Website.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel_Website.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Website.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Website.Controls.Add(this.lblWebsitePassword, 0, 3);
            this.tableLayoutPanel_Website.Controls.Add(this.btnCopyPassword, 1, 4);
            this.tableLayoutPanel_Website.Controls.Add(this.txtWebsitePassword, 1, 3);
            this.tableLayoutPanel_Website.Controls.Add(this.lblWebsiteUserID, 0, 2);
            this.tableLayoutPanel_Website.Controls.Add(this.lblWebsiteURLAddress, 0, 0);
            this.tableLayoutPanel_Website.Controls.Add(this.txtWebsiteURLAddress, 1, 0);
            this.tableLayoutPanel_Website.Controls.Add(this.txtWebsiteUserID, 1, 2);
            this.tableLayoutPanel_Website.Controls.Add(this.btnCopyPasswordAndGoToWebsite, 2, 4);
            this.tableLayoutPanel_Website.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Website.Location = new System.Drawing.Point(4, 19);
            this.tableLayoutPanel_Website.Name = "tableLayoutPanel_Website";
            this.tableLayoutPanel_Website.RowCount = 5;
            this.tableLayoutPanel_Website.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_Website.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_Website.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_Website.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_Website.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_Website.Size = new System.Drawing.Size(925, 199);
            this.tableLayoutPanel_Website.TabIndex = 52;
            // 
            // lblWebsitePassword
            // 
            this.lblWebsitePassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWebsitePassword.Location = new System.Drawing.Point(3, 108);
            this.lblWebsitePassword.Name = "lblWebsitePassword";
            this.lblWebsitePassword.Padding = new System.Windows.Forms.Padding(12, 5, 0, 0);
            this.lblWebsitePassword.Size = new System.Drawing.Size(169, 36);
            this.lblWebsitePassword.TabIndex = 51;
            this.lblWebsitePassword.Text = "Website Password:";
            // 
            // btnCopyPassword
            // 
            this.btnCopyPassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCopyPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyPassword.Location = new System.Drawing.Point(179, 148);
            this.btnCopyPassword.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopyPassword.Name = "btnCopyPassword";
            this.btnCopyPassword.Size = new System.Drawing.Size(203, 46);
            this.btnCopyPassword.TabIndex = 48;
            this.btnCopyPassword.TabStop = false;
            this.btnCopyPassword.Text = "Copy Password";
            this.btnCopyPassword.UseVisualStyleBackColor = true;
            // 
            // txtWebsitePassword
            // 
            this.txtWebsitePassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_Website.SetColumnSpan(this.txtWebsitePassword, 2);
            this.txtWebsitePassword.Location = new System.Drawing.Point(179, 112);
            this.txtWebsitePassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtWebsitePassword.Name = "txtWebsitePassword";
            this.txtWebsitePassword.Size = new System.Drawing.Size(742, 22);
            this.txtWebsitePassword.TabIndex = 2;
            // 
            // lblWebsiteUserID
            // 
            this.lblWebsiteUserID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWebsiteUserID.Location = new System.Drawing.Point(3, 72);
            this.lblWebsiteUserID.Name = "lblWebsiteUserID";
            this.lblWebsiteUserID.Padding = new System.Windows.Forms.Padding(12, 5, 0, 0);
            this.lblWebsiteUserID.Size = new System.Drawing.Size(169, 36);
            this.lblWebsiteUserID.TabIndex = 50;
            this.lblWebsiteUserID.Text = "Website User ID:";
            // 
            // lblWebsiteURLAddress
            // 
            this.lblWebsiteURLAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWebsiteURLAddress.Location = new System.Drawing.Point(3, 0);
            this.lblWebsiteURLAddress.Name = "lblWebsiteURLAddress";
            this.lblWebsiteURLAddress.Padding = new System.Windows.Forms.Padding(12, 22, 0, 0);
            this.tableLayoutPanel_Website.SetRowSpan(this.lblWebsiteURLAddress, 2);
            this.lblWebsiteURLAddress.Size = new System.Drawing.Size(169, 72);
            this.lblWebsiteURLAddress.TabIndex = 49;
            this.lblWebsiteURLAddress.Text = "Website URL Address:";
            // 
            // txtWebsiteURLAddress
            // 
            this.txtWebsiteURLAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_Website.SetColumnSpan(this.txtWebsiteURLAddress, 2);
            this.txtWebsiteURLAddress.Location = new System.Drawing.Point(179, 4);
            this.txtWebsiteURLAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtWebsiteURLAddress.Multiline = true;
            this.txtWebsiteURLAddress.Name = "txtWebsiteURLAddress";
            this.tableLayoutPanel_Website.SetRowSpan(this.txtWebsiteURLAddress, 2);
            this.txtWebsiteURLAddress.Size = new System.Drawing.Size(742, 54);
            this.txtWebsiteURLAddress.TabIndex = 0;
            // 
            // txtWebsiteUserID
            // 
            this.txtWebsiteUserID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_Website.SetColumnSpan(this.txtWebsiteUserID, 2);
            this.txtWebsiteUserID.Location = new System.Drawing.Point(179, 76);
            this.txtWebsiteUserID.Margin = new System.Windows.Forms.Padding(4);
            this.txtWebsiteUserID.Name = "txtWebsiteUserID";
            this.txtWebsiteUserID.Size = new System.Drawing.Size(742, 22);
            this.txtWebsiteUserID.TabIndex = 1;
            // 
            // btnCopyPasswordAndGoToWebsite
            // 
            this.btnCopyPasswordAndGoToWebsite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyPasswordAndGoToWebsite.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCopyPasswordAndGoToWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyPasswordAndGoToWebsite.Location = new System.Drawing.Point(718, 148);
            this.btnCopyPasswordAndGoToWebsite.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopyPasswordAndGoToWebsite.Name = "btnCopyPasswordAndGoToWebsite";
            this.btnCopyPasswordAndGoToWebsite.Size = new System.Drawing.Size(203, 46);
            this.btnCopyPasswordAndGoToWebsite.TabIndex = 47;
            this.btnCopyPasswordAndGoToWebsite.TabStop = false;
            this.btnCopyPasswordAndGoToWebsite.Text = "GoTo Website";
            this.btnCopyPasswordAndGoToWebsite.UseVisualStyleBackColor = true;
            // 
            // frameCreditCardInfo
            // 
            this.frameCreditCardInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.frameCreditCardInfo.Controls.Add(this.tableLayoutPanel_CreditCard);
            this.frameCreditCardInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frameCreditCardInfo.Location = new System.Drawing.Point(4, 69);
            this.frameCreditCardInfo.Margin = new System.Windows.Forms.Padding(4);
            this.frameCreditCardInfo.Name = "frameCreditCardInfo";
            this.frameCreditCardInfo.Padding = new System.Windows.Forms.Padding(4);
            this.frameCreditCardInfo.Size = new System.Drawing.Size(933, 192);
            this.frameCreditCardInfo.TabIndex = 19;
            this.frameCreditCardInfo.TabStop = false;
            this.frameCreditCardInfo.Text = "Credit Card Information:";
            // 
            // tableLayoutPanel_CreditCard
            // 
            this.tableLayoutPanel_CreditCard.ColumnCount = 6;
            this.tableLayoutPanel_CreditCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel_CreditCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_CreditCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_CreditCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel_CreditCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_CreditCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_CreditCard.Controls.Add(this.txtCreditCardAccountNumber, 1, 0);
            this.tableLayoutPanel_CreditCard.Controls.Add(this.lblCreditCardPrimaryPhoneNumber, 0, 3);
            this.tableLayoutPanel_CreditCard.Controls.Add(this.lblCardSecurityCode, 0, 1);
            this.tableLayoutPanel_CreditCard.Controls.Add(this.lblExpirationDate, 0, 2);
            this.tableLayoutPanel_CreditCard.Controls.Add(this.txtCreditCardPrimaryPhoneNumber, 1, 3);
            this.tableLayoutPanel_CreditCard.Controls.Add(this.txtCreditCardSecurityCode, 1, 1);
            this.tableLayoutPanel_CreditCard.Controls.Add(this.lblCreditCardAccountNumber, 0, 0);
            this.tableLayoutPanel_CreditCard.Controls.Add(this.picCheckMark, 5, 1);
            this.tableLayoutPanel_CreditCard.Controls.Add(this.txtCreditCardType, 4, 1);
            this.tableLayoutPanel_CreditCard.Controls.Add(this.lblCreditCardType, 3, 1);
            this.tableLayoutPanel_CreditCard.Controls.Add(this.txtCreditCardAltPhoneNumber, 4, 3);
            this.tableLayoutPanel_CreditCard.Controls.Add(this.lblCreditCardAltPhoneNumber, 3, 3);
            this.tableLayoutPanel_CreditCard.Controls.Add(this.btnCopyCreditCardAccountNumber, 1, 4);
            this.tableLayoutPanel_CreditCard.Controls.Add(this.txtCreditCardExpirationYear, 2, 2);
            this.tableLayoutPanel_CreditCard.Controls.Add(this.txtCreditCardExpirationMonth, 1, 2);
            this.tableLayoutPanel_CreditCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_CreditCard.Location = new System.Drawing.Point(4, 19);
            this.tableLayoutPanel_CreditCard.Name = "tableLayoutPanel_CreditCard";
            this.tableLayoutPanel_CreditCard.RowCount = 5;
            this.tableLayoutPanel_CreditCard.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_CreditCard.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_CreditCard.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_CreditCard.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_CreditCard.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_CreditCard.Size = new System.Drawing.Size(925, 169);
            this.tableLayoutPanel_CreditCard.TabIndex = 50;
            // 
            // txtCreditCardAccountNumber
            // 
            this.txtCreditCardAccountNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_CreditCard.SetColumnSpan(this.txtCreditCardAccountNumber, 2);
            this.txtCreditCardAccountNumber.Location = new System.Drawing.Point(179, 4);
            this.txtCreditCardAccountNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreditCardAccountNumber.Name = "txtCreditCardAccountNumber";
            this.txtCreditCardAccountNumber.Size = new System.Drawing.Size(350, 22);
            this.txtCreditCardAccountNumber.TabIndex = 0;
            // 
            // lblCreditCardPrimaryPhoneNumber
            // 
            this.lblCreditCardPrimaryPhoneNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCreditCardPrimaryPhoneNumber.Location = new System.Drawing.Point(3, 94);
            this.lblCreditCardPrimaryPhoneNumber.Name = "lblCreditCardPrimaryPhoneNumber";
            this.lblCreditCardPrimaryPhoneNumber.Padding = new System.Windows.Forms.Padding(12, 5, 0, 0);
            this.lblCreditCardPrimaryPhoneNumber.Size = new System.Drawing.Size(169, 30);
            this.lblCreditCardPrimaryPhoneNumber.TabIndex = 49;
            this.lblCreditCardPrimaryPhoneNumber.Text = "Primary Number:";
            // 
            // lblCardSecurityCode
            // 
            this.lblCardSecurityCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCardSecurityCode.Location = new System.Drawing.Point(4, 30);
            this.lblCardSecurityCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCardSecurityCode.Name = "lblCardSecurityCode";
            this.lblCardSecurityCode.Padding = new System.Windows.Forms.Padding(12, 5, 0, 0);
            this.lblCardSecurityCode.Size = new System.Drawing.Size(167, 34);
            this.lblCardSecurityCode.TabIndex = 37;
            this.lblCardSecurityCode.Text = "Card Security Code:";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblExpirationDate.Location = new System.Drawing.Point(3, 64);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Padding = new System.Windows.Forms.Padding(12, 5, 0, 0);
            this.lblExpirationDate.Size = new System.Drawing.Size(169, 30);
            this.lblExpirationDate.TabIndex = 48;
            this.lblExpirationDate.Text = "Expiration Date:";
            // 
            // txtCreditCardPrimaryPhoneNumber
            // 
            this.txtCreditCardPrimaryPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCreditCardPrimaryPhoneNumber.Location = new System.Drawing.Point(179, 98);
            this.txtCreditCardPrimaryPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreditCardPrimaryPhoneNumber.Name = "txtCreditCardPrimaryPhoneNumber";
            this.txtCreditCardPrimaryPhoneNumber.Size = new System.Drawing.Size(171, 22);
            this.txtCreditCardPrimaryPhoneNumber.TabIndex = 4;
            // 
            // txtCreditCardSecurityCode
            // 
            this.txtCreditCardSecurityCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCreditCardSecurityCode.Location = new System.Drawing.Point(179, 34);
            this.txtCreditCardSecurityCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreditCardSecurityCode.Name = "txtCreditCardSecurityCode";
            this.txtCreditCardSecurityCode.Size = new System.Drawing.Size(171, 22);
            this.txtCreditCardSecurityCode.TabIndex = 1;
            // 
            // lblCreditCardAccountNumber
            // 
            this.lblCreditCardAccountNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCreditCardAccountNumber.Location = new System.Drawing.Point(3, 0);
            this.lblCreditCardAccountNumber.Name = "lblCreditCardAccountNumber";
            this.lblCreditCardAccountNumber.Padding = new System.Windows.Forms.Padding(12, 5, 0, 0);
            this.lblCreditCardAccountNumber.Size = new System.Drawing.Size(169, 30);
            this.lblCreditCardAccountNumber.TabIndex = 3;
            this.lblCreditCardAccountNumber.Text = "Credit Card Number";
            // 
            // picCheckMark
            // 
            this.picCheckMark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picCheckMark.BackColor = System.Drawing.SystemColors.Window;
            this.picCheckMark.Image = ((System.Drawing.Image)(resources.GetObject("picCheckMark.Image")));
            this.picCheckMark.Location = new System.Drawing.Point(890, 32);
            this.picCheckMark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picCheckMark.Name = "picCheckMark";
            this.picCheckMark.Size = new System.Drawing.Size(32, 27);
            this.picCheckMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCheckMark.TabIndex = 47;
            this.picCheckMark.TabStop = false;
            // 
            // txtCreditCardType
            // 
            this.txtCreditCardType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCreditCardType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditCardType.Location = new System.Drawing.Point(712, 34);
            this.txtCreditCardType.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreditCardType.Name = "txtCreditCardType";
            this.txtCreditCardType.Size = new System.Drawing.Size(171, 23);
            this.txtCreditCardType.TabIndex = 2;
            this.txtCreditCardType.TabStop = false;
            // 
            // lblCreditCardType
            // 
            this.lblCreditCardType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCreditCardType.Location = new System.Drawing.Point(536, 30);
            this.lblCreditCardType.Name = "lblCreditCardType";
            this.lblCreditCardType.Padding = new System.Windows.Forms.Padding(12, 5, 0, 0);
            this.lblCreditCardType.Size = new System.Drawing.Size(169, 34);
            this.lblCreditCardType.TabIndex = 39;
            this.lblCreditCardType.Text = "Credit Card Type:";
            this.lblCreditCardType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCreditCardAltPhoneNumber
            // 
            this.txtCreditCardAltPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCreditCardAltPhoneNumber.Location = new System.Drawing.Point(712, 98);
            this.txtCreditCardAltPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreditCardAltPhoneNumber.Name = "txtCreditCardAltPhoneNumber";
            this.txtCreditCardAltPhoneNumber.Size = new System.Drawing.Size(171, 22);
            this.txtCreditCardAltPhoneNumber.TabIndex = 5;
            // 
            // lblCreditCardAltPhoneNumber
            // 
            this.lblCreditCardAltPhoneNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCreditCardAltPhoneNumber.Location = new System.Drawing.Point(536, 94);
            this.lblCreditCardAltPhoneNumber.Name = "lblCreditCardAltPhoneNumber";
            this.lblCreditCardAltPhoneNumber.Padding = new System.Windows.Forms.Padding(12, 5, 0, 0);
            this.lblCreditCardAltPhoneNumber.Size = new System.Drawing.Size(169, 30);
            this.lblCreditCardAltPhoneNumber.TabIndex = 42;
            this.lblCreditCardAltPhoneNumber.Text = "Alternate Phone:";
            this.lblCreditCardAltPhoneNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCopyCreditCardAccountNumber
            // 
            this.btnCopyCreditCardAccountNumber.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel_CreditCard.SetColumnSpan(this.btnCopyCreditCardAccountNumber, 5);
            this.btnCopyCreditCardAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyCreditCardAccountNumber.Location = new System.Drawing.Point(179, 128);
            this.btnCopyCreditCardAccountNumber.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopyCreditCardAccountNumber.Name = "btnCopyCreditCardAccountNumber";
            this.btnCopyCreditCardAccountNumber.Size = new System.Drawing.Size(737, 46);
            this.btnCopyCreditCardAccountNumber.TabIndex = 46;
            this.btnCopyCreditCardAccountNumber.TabStop = false;
            this.btnCopyCreditCardAccountNumber.Text = "Copy Credit Card Account Number";
            this.btnCopyCreditCardAccountNumber.UseVisualStyleBackColor = true;
            // 
            // txtCreditCardExpirationYear
            // 
            this.txtCreditCardExpirationYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCreditCardExpirationYear.Location = new System.Drawing.Point(358, 68);
            this.txtCreditCardExpirationYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreditCardExpirationYear.MaxLength = 4;
            this.txtCreditCardExpirationYear.Name = "txtCreditCardExpirationYear";
            this.txtCreditCardExpirationYear.Size = new System.Drawing.Size(171, 22);
            this.txtCreditCardExpirationYear.TabIndex = 3;
            // 
            // txtCreditCardExpirationMonth
            // 
            this.txtCreditCardExpirationMonth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCreditCardExpirationMonth.Location = new System.Drawing.Point(179, 68);
            this.txtCreditCardExpirationMonth.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreditCardExpirationMonth.MaxLength = 2;
            this.txtCreditCardExpirationMonth.Name = "txtCreditCardExpirationMonth";
            this.txtCreditCardExpirationMonth.Size = new System.Drawing.Size(171, 22);
            this.txtCreditCardExpirationMonth.TabIndex = 2;
            // 
            // frameGeneralAccountInformation
            // 
            this.frameGeneralAccountInformation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.frameGeneralAccountInformation.Controls.Add(this.tableLayoutPanel_GeneralAccount);
            this.frameGeneralAccountInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frameGeneralAccountInformation.Location = new System.Drawing.Point(4, 269);
            this.frameGeneralAccountInformation.Margin = new System.Windows.Forms.Padding(4);
            this.frameGeneralAccountInformation.Name = "frameGeneralAccountInformation";
            this.frameGeneralAccountInformation.Padding = new System.Windows.Forms.Padding(4);
            this.frameGeneralAccountInformation.Size = new System.Drawing.Size(933, 151);
            this.frameGeneralAccountInformation.TabIndex = 20;
            this.frameGeneralAccountInformation.TabStop = false;
            this.frameGeneralAccountInformation.Text = "General Account Information:";
            // 
            // tableLayoutPanel_GeneralAccount
            // 
            this.tableLayoutPanel_GeneralAccount.ColumnCount = 4;
            this.tableLayoutPanel_GeneralAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel_GeneralAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_GeneralAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel_GeneralAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_GeneralAccount.Controls.Add(this.btnCopyGeneralAccountNumber, 1, 2);
            this.tableLayoutPanel_GeneralAccount.Controls.Add(this.txtGeneralAccountNumber, 1, 0);
            this.tableLayoutPanel_GeneralAccount.Controls.Add(this.lblGeneralAccountNumber, 0, 0);
            this.tableLayoutPanel_GeneralAccount.Controls.Add(this.lblGeneralAccountPrimaryPhoneNumber, 0, 1);
            this.tableLayoutPanel_GeneralAccount.Controls.Add(this.txtGeneralAccountAltPhoneNumber, 3, 1);
            this.tableLayoutPanel_GeneralAccount.Controls.Add(this.lblGeneralAccountAltPhoneNumber, 2, 1);
            this.tableLayoutPanel_GeneralAccount.Controls.Add(this.txtGeneralAccountPrimaryPhoneNumber, 1, 1);
            this.tableLayoutPanel_GeneralAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_GeneralAccount.Location = new System.Drawing.Point(4, 19);
            this.tableLayoutPanel_GeneralAccount.Name = "tableLayoutPanel_GeneralAccount";
            this.tableLayoutPanel_GeneralAccount.RowCount = 3;
            this.tableLayoutPanel_GeneralAccount.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_GeneralAccount.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_GeneralAccount.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_GeneralAccount.Size = new System.Drawing.Size(925, 128);
            this.tableLayoutPanel_GeneralAccount.TabIndex = 49;
            // 
            // btnCopyGeneralAccountNumber
            // 
            this.btnCopyGeneralAccountNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyGeneralAccountNumber.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel_GeneralAccount.SetColumnSpan(this.btnCopyGeneralAccountNumber, 3);
            this.btnCopyGeneralAccountNumber.Location = new System.Drawing.Point(179, 64);
            this.btnCopyGeneralAccountNumber.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopyGeneralAccountNumber.Name = "btnCopyGeneralAccountNumber";
            this.btnCopyGeneralAccountNumber.Size = new System.Drawing.Size(742, 46);
            this.btnCopyGeneralAccountNumber.TabIndex = 46;
            this.btnCopyGeneralAccountNumber.TabStop = false;
            this.btnCopyGeneralAccountNumber.Text = "Copy Account Number";
            this.btnCopyGeneralAccountNumber.UseVisualStyleBackColor = true;
            // 
            // txtGeneralAccountNumber
            // 
            this.txtGeneralAccountNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_GeneralAccount.SetColumnSpan(this.txtGeneralAccountNumber, 2);
            this.txtGeneralAccountNumber.Location = new System.Drawing.Point(179, 4);
            this.txtGeneralAccountNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtGeneralAccountNumber.Name = "txtGeneralAccountNumber";
            this.txtGeneralAccountNumber.Size = new System.Drawing.Size(454, 22);
            this.txtGeneralAccountNumber.TabIndex = 0;
            // 
            // lblGeneralAccountNumber
            // 
            this.lblGeneralAccountNumber.AutoSize = true;
            this.lblGeneralAccountNumber.Location = new System.Drawing.Point(3, 0);
            this.lblGeneralAccountNumber.Name = "lblGeneralAccountNumber";
            this.lblGeneralAccountNumber.Size = new System.Drawing.Size(117, 17);
            this.lblGeneralAccountNumber.TabIndex = 47;
            this.lblGeneralAccountNumber.Text = "Account Number:";
            // 
            // lblGeneralAccountPrimaryPhoneNumber
            // 
            this.lblGeneralAccountPrimaryPhoneNumber.AutoSize = true;
            this.lblGeneralAccountPrimaryPhoneNumber.Location = new System.Drawing.Point(3, 30);
            this.lblGeneralAccountPrimaryPhoneNumber.Name = "lblGeneralAccountPrimaryPhoneNumber";
            this.lblGeneralAccountPrimaryPhoneNumber.Size = new System.Drawing.Size(114, 17);
            this.lblGeneralAccountPrimaryPhoneNumber.TabIndex = 48;
            this.lblGeneralAccountPrimaryPhoneNumber.Text = "Primary Number:";
            // 
            // txtGeneralAccountAltPhoneNumber
            // 
            this.txtGeneralAccountAltPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGeneralAccountAltPhoneNumber.Location = new System.Drawing.Point(641, 34);
            this.txtGeneralAccountAltPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtGeneralAccountAltPhoneNumber.Name = "txtGeneralAccountAltPhoneNumber";
            this.txtGeneralAccountAltPhoneNumber.Size = new System.Drawing.Size(280, 22);
            this.txtGeneralAccountAltPhoneNumber.TabIndex = 2;
            // 
            // lblGeneralAccountAltPhoneNumber
            // 
            this.lblGeneralAccountAltPhoneNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGeneralAccountAltPhoneNumber.Location = new System.Drawing.Point(465, 30);
            this.lblGeneralAccountAltPhoneNumber.Name = "lblGeneralAccountAltPhoneNumber";
            this.lblGeneralAccountAltPhoneNumber.Padding = new System.Windows.Forms.Padding(12, 5, 0, 0);
            this.lblGeneralAccountAltPhoneNumber.Size = new System.Drawing.Size(169, 30);
            this.lblGeneralAccountAltPhoneNumber.TabIndex = 42;
            this.lblGeneralAccountAltPhoneNumber.Text = "Alternate Phone:";
            this.lblGeneralAccountAltPhoneNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtGeneralAccountPrimaryPhoneNumber
            // 
            this.txtGeneralAccountPrimaryPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGeneralAccountPrimaryPhoneNumber.Location = new System.Drawing.Point(179, 34);
            this.txtGeneralAccountPrimaryPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtGeneralAccountPrimaryPhoneNumber.Name = "txtGeneralAccountPrimaryPhoneNumber";
            this.txtGeneralAccountPrimaryPhoneNumber.Size = new System.Drawing.Size(279, 22);
            this.txtGeneralAccountPrimaryPhoneNumber.TabIndex = 1;
            // 
            // frameSoftwareKeyCode
            // 
            this.frameSoftwareKeyCode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.frameSoftwareKeyCode.Controls.Add(this.tableLayoutPanel_Software);
            this.frameSoftwareKeyCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frameSoftwareKeyCode.Location = new System.Drawing.Point(4, 428);
            this.frameSoftwareKeyCode.Margin = new System.Windows.Forms.Padding(4);
            this.frameSoftwareKeyCode.Name = "frameSoftwareKeyCode";
            this.frameSoftwareKeyCode.Padding = new System.Windows.Forms.Padding(4);
            this.frameSoftwareKeyCode.Size = new System.Drawing.Size(933, 126);
            this.frameSoftwareKeyCode.TabIndex = 18;
            this.frameSoftwareKeyCode.TabStop = false;
            this.frameSoftwareKeyCode.Text = "Software Key Code Information:";
            // 
            // tableLayoutPanel_Software
            // 
            this.tableLayoutPanel_Software.ColumnCount = 3;
            this.tableLayoutPanel_Software.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel_Software.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Software.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_Software.Controls.Add(this.updnSoftwareKeyCodeSubgroupLength, 2, 0);
            this.tableLayoutPanel_Software.Controls.Add(this.lblSoftwareKeyCode, 0, 0);
            this.tableLayoutPanel_Software.Controls.Add(this.txtSoftwareKeyCode, 1, 0);
            this.tableLayoutPanel_Software.Controls.Add(this.btnCopyKeyCode, 1, 1);
            this.tableLayoutPanel_Software.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Software.Location = new System.Drawing.Point(4, 19);
            this.tableLayoutPanel_Software.Name = "tableLayoutPanel_Software";
            this.tableLayoutPanel_Software.RowCount = 2;
            this.tableLayoutPanel_Software.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_Software.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Software.Size = new System.Drawing.Size(925, 103);
            this.tableLayoutPanel_Software.TabIndex = 3;
            // 
            // updnSoftwareKeyCodeSubgroupLength
            // 
            this.updnSoftwareKeyCodeSubgroupLength.Location = new System.Drawing.Point(871, 4);
            this.updnSoftwareKeyCodeSubgroupLength.Margin = new System.Windows.Forms.Padding(4);
            this.updnSoftwareKeyCodeSubgroupLength.Name = "updnSoftwareKeyCodeSubgroupLength";
            this.updnSoftwareKeyCodeSubgroupLength.Size = new System.Drawing.Size(50, 22);
            this.updnSoftwareKeyCodeSubgroupLength.TabIndex = 1;
            this.updnSoftwareKeyCodeSubgroupLength.ValueChanged += new System.EventHandler(this.updnSoftwareKeyCodeSubgroupLength_ValueChanged);
            // 
            // lblSoftwareKeyCode
            // 
            this.lblSoftwareKeyCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSoftwareKeyCode.Location = new System.Drawing.Point(3, 0);
            this.lblSoftwareKeyCode.Name = "lblSoftwareKeyCode";
            this.lblSoftwareKeyCode.Padding = new System.Windows.Forms.Padding(12, 5, 0, 0);
            this.lblSoftwareKeyCode.Size = new System.Drawing.Size(169, 30);
            this.lblSoftwareKeyCode.TabIndex = 2;
            this.lblSoftwareKeyCode.Text = "Software Key Code:";
            // 
            // txtSoftwareKeyCode
            // 
            this.txtSoftwareKeyCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoftwareKeyCode.Location = new System.Drawing.Point(179, 4);
            this.txtSoftwareKeyCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoftwareKeyCode.Name = "txtSoftwareKeyCode";
            this.txtSoftwareKeyCode.Size = new System.Drawing.Size(684, 22);
            this.txtSoftwareKeyCode.TabIndex = 0;
            // 
            // btnCopyKeyCode
            // 
            this.btnCopyKeyCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyKeyCode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel_Software.SetColumnSpan(this.btnCopyKeyCode, 2);
            this.btnCopyKeyCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyKeyCode.Location = new System.Drawing.Point(179, 34);
            this.btnCopyKeyCode.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopyKeyCode.Name = "btnCopyKeyCode";
            this.btnCopyKeyCode.Size = new System.Drawing.Size(742, 46);
            this.btnCopyKeyCode.TabIndex = 1;
            this.btnCopyKeyCode.TabStop = false;
            this.btnCopyKeyCode.Text = "Copy Key Code";
            this.btnCopyKeyCode.UseVisualStyleBackColor = true;
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
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel1.PerformLayout();
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            this.tableLayoutPanel_Header.ResumeLayout(false);
            this.frameUsers.ResumeLayout(false);
            this.frameSearch.ResumeLayout(false);
            this.frameSearch.PerformLayout();
            this.tableLayoutPanel_DeleteNewButtons.ResumeLayout(false);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.SplitContainer2.Panel1.ResumeLayout(false);
            this.SplitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).EndInit();
            this.SplitContainer2.ResumeLayout(false);
            this.tableLayoutPanel_ItemsList.ResumeLayout(false);
            this.tableLayoutPanel_ItemsList.PerformLayout();
            this.frameItemType.ResumeLayout(false);
            this.frameItemsList.ResumeLayout(false);
            this.tableLayoutPanel_ItemDetails.ResumeLayout(false);
            this.framePasswordItem.ResumeLayout(false);
            this.tableLayoutPanel_Item.ResumeLayout(false);
            this.tableLayoutPanel_Item.PerformLayout();
            this.frameComments.ResumeLayout(false);
            this.frameComments.PerformLayout();
            this.frameWebsite.ResumeLayout(false);
            this.tableLayoutPanel_Website.ResumeLayout(false);
            this.tableLayoutPanel_Website.PerformLayout();
            this.frameCreditCardInfo.ResumeLayout(false);
            this.tableLayoutPanel_CreditCard.ResumeLayout(false);
            this.tableLayoutPanel_CreditCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCheckMark)).EndInit();
            this.frameGeneralAccountInformation.ResumeLayout(false);
            this.tableLayoutPanel_GeneralAccount.ResumeLayout(false);
            this.tableLayoutPanel_GeneralAccount.PerformLayout();
            this.frameSoftwareKeyCode.ResumeLayout(false);
            this.tableLayoutPanel_Software.ResumeLayout(false);
            this.tableLayoutPanel_Software.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updnSoftwareKeyCodeSubgroupLength)).EndInit();
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
        internal System.Windows.Forms.GroupBox frameUsers;
        internal System.Windows.Forms.ComboBox cbxUsersFilter;
        internal System.Windows.Forms.SplitContainer SplitContainer2;
        private System.Windows.Forms.ComboBox cbxItemTypes;
        private System.Windows.Forms.ListBox listPasswordItems;
        private System.Windows.Forms.ToolStripMenuItem menuChangeAppPassword;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_ItemDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_ItemsList;
        private System.Windows.Forms.GroupBox frameItemType;
        private System.Windows.Forms.GroupBox frameItemsList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Header;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_DeleteNewButtons;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Item;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_CreditCard;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Website;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Software;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_GeneralAccount;
    }
}

