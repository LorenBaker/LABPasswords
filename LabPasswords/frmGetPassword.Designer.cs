namespace LabPasswords
{
    partial class frmGetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGetPassword));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.frameDropboxFolder = new System.Windows.Forms.GroupBox();
            this.btnBrowseForDropboxFolder = new System.Windows.Forms.Button();
            this.txtDropboxFolder = new System.Windows.Forms.TextBox();
            this.frameButtons = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.frameEnterPassword = new System.Windows.Forms.GroupBox();
            this.btnDisplayPassword = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtWarningMessage = new System.Windows.Forms.RichTextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.frameDropboxFolder.SuspendLayout();
            this.frameButtons.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.frameEnterPassword.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(692, 363);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::LabPasswords.Properties.Resources.Passwords;
            this.pictureBox1.Location = new System.Drawing.Point(-16, -32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 432);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.frameDropboxFolder, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.frameButtons, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.frameEnterPassword, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(488, 363);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // frameDropboxFolder
            // 
            this.frameDropboxFolder.Controls.Add(this.btnBrowseForDropboxFolder);
            this.frameDropboxFolder.Controls.Add(this.txtDropboxFolder);
            this.frameDropboxFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frameDropboxFolder.Location = new System.Drawing.Point(3, 3);
            this.frameDropboxFolder.Name = "frameDropboxFolder";
            this.frameDropboxFolder.Size = new System.Drawing.Size(482, 84);
            this.frameDropboxFolder.TabIndex = 0;
            this.frameDropboxFolder.TabStop = false;
            this.frameDropboxFolder.Text = "Dropbox Folder:";
            // 
            // btnBrowseForDropboxFolder
            // 
            this.btnBrowseForDropboxFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseForDropboxFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseForDropboxFolder.Location = new System.Drawing.Point(363, 27);
            this.btnBrowseForDropboxFolder.Name = "btnBrowseForDropboxFolder";
            this.btnBrowseForDropboxFolder.Size = new System.Drawing.Size(110, 33);
            this.btnBrowseForDropboxFolder.TabIndex = 1;
            this.btnBrowseForDropboxFolder.TabStop = false;
            this.btnBrowseForDropboxFolder.Text = "Browse";
            this.btnBrowseForDropboxFolder.UseVisualStyleBackColor = true;
            this.btnBrowseForDropboxFolder.Click += new System.EventHandler(this.btnBrowseForDropboxFolder_Click);
            // 
            // txtDropboxFolder
            // 
            this.txtDropboxFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDropboxFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDropboxFolder.Location = new System.Drawing.Point(6, 30);
            this.txtDropboxFolder.Name = "txtDropboxFolder";
            this.txtDropboxFolder.Size = new System.Drawing.Size(351, 27);
            this.txtDropboxFolder.TabIndex = 0;
            // 
            // frameButtons
            // 
            this.frameButtons.Controls.Add(this.tableLayoutPanel2);
            this.frameButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frameButtons.Location = new System.Drawing.Point(3, 273);
            this.frameButtons.Name = "frameButtons";
            this.frameButtons.Size = new System.Drawing.Size(482, 87);
            this.frameButtons.TabIndex = 4;
            this.frameButtons.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnOK, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCancel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(476, 66);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(250, 2);
            this.btnOK.Margin = new System.Windows.Forms.Padding(12, 2, 12, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(214, 62);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(12, 2);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(12, 2, 12, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(214, 62);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frameEnterPassword
            // 
            this.frameEnterPassword.Controls.Add(this.btnDisplayPassword);
            this.frameEnterPassword.Controls.Add(this.txtPassword);
            this.frameEnterPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frameEnterPassword.Location = new System.Drawing.Point(3, 93);
            this.frameEnterPassword.Name = "frameEnterPassword";
            this.frameEnterPassword.Size = new System.Drawing.Size(482, 84);
            this.frameEnterPassword.TabIndex = 1;
            this.frameEnterPassword.TabStop = false;
            this.frameEnterPassword.Text = "Enter Password:";
            // 
            // btnDisplayPassword
            // 
            this.btnDisplayPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisplayPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayPassword.Location = new System.Drawing.Point(363, 21);
            this.btnDisplayPassword.Name = "btnDisplayPassword";
            this.btnDisplayPassword.Size = new System.Drawing.Size(110, 33);
            this.btnDisplayPassword.TabIndex = 1;
            this.btnDisplayPassword.TabStop = false;
            this.btnDisplayPassword.Text = "Display";
            this.btnDisplayPassword.UseVisualStyleBackColor = true;
            this.btnDisplayPassword.Click += new System.EventHandler(this.btnDisplayPassword_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(6, 24);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(351, 27);
            this.txtPassword.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtWarningMessage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 183);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(482, 84);
            this.panel1.TabIndex = 3;
            // 
            // txtWarningMessage
            // 
            this.txtWarningMessage.BackColor = System.Drawing.SystemColors.Control;
            this.txtWarningMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWarningMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWarningMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWarningMessage.Location = new System.Drawing.Point(5, 5);
            this.txtWarningMessage.Name = "txtWarningMessage";
            this.txtWarningMessage.Size = new System.Drawing.Size(468, 70);
            this.txtWarningMessage.TabIndex = 0;
            this.txtWarningMessage.TabStop = false;
            this.txtWarningMessage.Text = "";
            // 
            // frmGetPassword
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(692, 363);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Enter Password";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGetPassword_FormClosing);
            this.Load += new System.EventHandler(this.frmGetPassword_Load);
            this.Shown += new System.EventHandler(this.frmGetPassword_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.frameDropboxFolder.ResumeLayout(false);
            this.frameDropboxFolder.PerformLayout();
            this.frameButtons.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.frameEnterPassword.ResumeLayout(false);
            this.frameEnterPassword.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txtWarningMessage;
        private System.Windows.Forms.GroupBox frameEnterPassword;
        private System.Windows.Forms.Button btnDisplayPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.GroupBox frameDropboxFolder;
        private System.Windows.Forms.Button btnBrowseForDropboxFolder;
        private System.Windows.Forms.TextBox txtDropboxFolder;
        private System.Windows.Forms.GroupBox frameButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}