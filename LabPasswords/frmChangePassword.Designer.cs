﻿namespace LabPasswords
{
    partial class frmChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.frameButtons = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_CancelOK = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtWarningMessage = new System.Windows.Forms.RichTextBox();
            this.frameReEnterPassword = new System.Windows.Forms.GroupBox();
            this.picCheckMark = new System.Windows.Forms.PictureBox();
            this.btnDisplayReenterPassword = new System.Windows.Forms.Button();
            this.txtReenterPassword = new System.Windows.Forms.TextBox();
            this.frameEnterPassword = new System.Windows.Forms.GroupBox();
            this.btnDisplayPassword = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.frameDropboxFolder = new System.Windows.Forms.GroupBox();
            this.btnBrowseForDropboxFolder = new System.Windows.Forms.Button();
            this.txtDropboxFolder = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.frameButtons.SuspendLayout();
            this.tableLayoutPanel_CancelOK.SuspendLayout();
            this.panel1.SuspendLayout();
            this.frameReEnterPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCheckMark)).BeginInit();
            this.frameEnterPassword.SuspendLayout();
            this.frameDropboxFolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(10, 10);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(672, 433);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 1;
            this.splitContainer1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::LabPasswords.Properties.Resources.Passwords;
            this.pictureBox1.Location = new System.Drawing.Point(-16, 3);
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
            this.tableLayoutPanel1.Controls.Add(this.frameButtons, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.frameReEnterPassword, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.frameEnterPassword, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.frameDropboxFolder, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(468, 433);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // frameButtons
            // 
            this.frameButtons.Controls.Add(this.tableLayoutPanel_CancelOK);
            this.frameButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frameButtons.Location = new System.Drawing.Point(3, 347);
            this.frameButtons.Name = "frameButtons";
            this.frameButtons.Size = new System.Drawing.Size(462, 83);
            this.frameButtons.TabIndex = 3;
            this.frameButtons.TabStop = false;
            // 
            // tableLayoutPanel_CancelOK
            // 
            this.tableLayoutPanel_CancelOK.ColumnCount = 2;
            this.tableLayoutPanel_CancelOK.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_CancelOK.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_CancelOK.Controls.Add(this.btnCancel, 0, 0);
            this.tableLayoutPanel_CancelOK.Controls.Add(this.btnOK, 1, 0);
            this.tableLayoutPanel_CancelOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_CancelOK.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel_CancelOK.Name = "tableLayoutPanel_CancelOK";
            this.tableLayoutPanel_CancelOK.RowCount = 1;
            this.tableLayoutPanel_CancelOK.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_CancelOK.Size = new System.Drawing.Size(456, 62);
            this.tableLayoutPanel_CancelOK.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(12, 2);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(12, 2, 12, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(204, 58);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOK.Enabled = false;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(240, 2);
            this.btnOK.Margin = new System.Windows.Forms.Padding(12, 2, 12, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(204, 58);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtWarningMessage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 261);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(462, 80);
            this.panel1.TabIndex = 6;
            // 
            // txtWarningMessage
            // 
            this.txtWarningMessage.BackColor = System.Drawing.SystemColors.Control;
            this.txtWarningMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWarningMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWarningMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWarningMessage.Location = new System.Drawing.Point(5, 5);
            this.txtWarningMessage.Name = "txtWarningMessage";
            this.txtWarningMessage.Size = new System.Drawing.Size(448, 66);
            this.txtWarningMessage.TabIndex = 0;
            this.txtWarningMessage.TabStop = false;
            this.txtWarningMessage.Text = "";
            // 
            // frameReEnterPassword
            // 
            this.frameReEnterPassword.Controls.Add(this.picCheckMark);
            this.frameReEnterPassword.Controls.Add(this.btnDisplayReenterPassword);
            this.frameReEnterPassword.Controls.Add(this.txtReenterPassword);
            this.frameReEnterPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frameReEnterPassword.Location = new System.Drawing.Point(3, 175);
            this.frameReEnterPassword.Name = "frameReEnterPassword";
            this.frameReEnterPassword.Size = new System.Drawing.Size(462, 80);
            this.frameReEnterPassword.TabIndex = 2;
            this.frameReEnterPassword.TabStop = false;
            this.frameReEnterPassword.Text = "Reenter New Password:";
            // 
            // picCheckMark
            // 
            this.picCheckMark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picCheckMark.BackColor = System.Drawing.SystemColors.Window;
            this.picCheckMark.Image = ((System.Drawing.Image)(resources.GetObject("picCheckMark.Image")));
            this.picCheckMark.Location = new System.Drawing.Point(434, 30);
            this.picCheckMark.Name = "picCheckMark";
            this.picCheckMark.Size = new System.Drawing.Size(27, 27);
            this.picCheckMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCheckMark.TabIndex = 48;
            this.picCheckMark.TabStop = false;
            // 
            // btnDisplayReenterPassword
            // 
            this.btnDisplayReenterPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisplayReenterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayReenterPassword.Location = new System.Drawing.Point(323, 27);
            this.btnDisplayReenterPassword.Name = "btnDisplayReenterPassword";
            this.btnDisplayReenterPassword.Size = new System.Drawing.Size(102, 33);
            this.btnDisplayReenterPassword.TabIndex = 1;
            this.btnDisplayReenterPassword.TabStop = false;
            this.btnDisplayReenterPassword.Text = "Display";
            this.btnDisplayReenterPassword.UseVisualStyleBackColor = true;
            this.btnDisplayReenterPassword.Click += new System.EventHandler(this.btnDisplayReenterPassword_Click);
            // 
            // txtReenterPassword
            // 
            this.txtReenterPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReenterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReenterPassword.Location = new System.Drawing.Point(6, 30);
            this.txtReenterPassword.Name = "txtReenterPassword";
            this.txtReenterPassword.PasswordChar = '*';
            this.txtReenterPassword.Size = new System.Drawing.Size(307, 27);
            this.txtReenterPassword.TabIndex = 0;
            this.txtReenterPassword.TextChanged += new System.EventHandler(this.txtReenterPassword_TextChanged);
            // 
            // frameEnterPassword
            // 
            this.frameEnterPassword.Controls.Add(this.btnDisplayPassword);
            this.frameEnterPassword.Controls.Add(this.txtPassword);
            this.frameEnterPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frameEnterPassword.Location = new System.Drawing.Point(3, 89);
            this.frameEnterPassword.Name = "frameEnterPassword";
            this.frameEnterPassword.Size = new System.Drawing.Size(462, 80);
            this.frameEnterPassword.TabIndex = 1;
            this.frameEnterPassword.TabStop = false;
            this.frameEnterPassword.Text = "Enter New Password:";
            // 
            // btnDisplayPassword
            // 
            this.btnDisplayPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisplayPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayPassword.Location = new System.Drawing.Point(323, 27);
            this.btnDisplayPassword.Name = "btnDisplayPassword";
            this.btnDisplayPassword.Size = new System.Drawing.Size(102, 33);
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
            this.txtPassword.Location = new System.Drawing.Point(6, 30);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(307, 27);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // frameDropboxFolder
            // 
            this.frameDropboxFolder.Controls.Add(this.btnBrowseForDropboxFolder);
            this.frameDropboxFolder.Controls.Add(this.txtDropboxFolder);
            this.frameDropboxFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frameDropboxFolder.Location = new System.Drawing.Point(3, 3);
            this.frameDropboxFolder.Name = "frameDropboxFolder";
            this.frameDropboxFolder.Size = new System.Drawing.Size(462, 80);
            this.frameDropboxFolder.TabIndex = 0;
            this.frameDropboxFolder.TabStop = false;
            this.frameDropboxFolder.Text = "Dropbox Folder:";
            // 
            // btnBrowseForDropboxFolder
            // 
            this.btnBrowseForDropboxFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseForDropboxFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseForDropboxFolder.Location = new System.Drawing.Point(323, 27);
            this.btnBrowseForDropboxFolder.Name = "btnBrowseForDropboxFolder";
            this.btnBrowseForDropboxFolder.Size = new System.Drawing.Size(102, 33);
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
            this.txtDropboxFolder.Size = new System.Drawing.Size(307, 27);
            this.txtDropboxFolder.TabIndex = 0;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 453);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChangePassword";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change Password";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmChangePassword_FormClosing);
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.frameButtons.ResumeLayout(false);
            this.tableLayoutPanel_CancelOK.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.frameReEnterPassword.ResumeLayout(false);
            this.frameReEnterPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCheckMark)).EndInit();
            this.frameEnterPassword.ResumeLayout(false);
            this.frameEnterPassword.PerformLayout();
            this.frameDropboxFolder.ResumeLayout(false);
            this.frameDropboxFolder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox frameDropboxFolder;
        private System.Windows.Forms.Button btnBrowseForDropboxFolder;
        private System.Windows.Forms.TextBox txtDropboxFolder;
        private System.Windows.Forms.GroupBox frameButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txtWarningMessage;
        private System.Windows.Forms.GroupBox frameReEnterPassword;
        private System.Windows.Forms.PictureBox picCheckMark;
        private System.Windows.Forms.Button btnDisplayReenterPassword;
        private System.Windows.Forms.TextBox txtReenterPassword;
        private System.Windows.Forms.GroupBox frameEnterPassword;
        private System.Windows.Forms.Button btnDisplayPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_CancelOK;
    }
}