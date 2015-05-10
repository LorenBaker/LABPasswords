namespace LabPasswords
{
    partial class frmRandomPasswordDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRandomPasswordDialog));
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.brnCancel = new System.Windows.Forms.Button();
            this.btnCopyToClipboardAndClose = new System.Windows.Forms.Button();
            this.updnMaxLength = new System.Windows.Forms.NumericUpDown();
            this.lblMaxLength = new System.Windows.Forms.Label();
            this.lblMinLength = new System.Windows.Forms.Label();
            this.updnMinLenght = new System.Windows.Forms.NumericUpDown();
            this.frameLength = new System.Windows.Forms.GroupBox();
            this.framePassword = new System.Windows.Forms.GroupBox();
            this.frameButtons = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCopyToClipboardPasteAndClose = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.updnMaxLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnMinLenght)).BeginInit();
            this.frameLength.SuspendLayout();
            this.framePassword.SuspendLayout();
            this.frameButtons.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGeneratePassword.Location = new System.Drawing.Point(13, 21);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(366, 54);
            this.btnGeneratePassword.TabIndex = 0;
            this.btnGeneratePassword.Text = "Generate Password";
            this.btnGeneratePassword.UseVisualStyleBackColor = true;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(13, 91);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(366, 30);
            this.txtPassword.TabIndex = 1;
            // 
            // brnCancel
            // 
            this.brnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brnCancel.Location = new System.Drawing.Point(3, 3);
            this.brnCancel.Name = "brnCancel";
            this.brnCancel.Size = new System.Drawing.Size(117, 49);
            this.brnCancel.TabIndex = 2;
            this.brnCancel.Text = "Cancel";
            this.brnCancel.UseVisualStyleBackColor = true;
            this.brnCancel.Click += new System.EventHandler(this.brnCancel_Click);
            // 
            // btnCopyToClipboardAndClose
            // 
            this.btnCopyToClipboardAndClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCopyToClipboardAndClose.Location = new System.Drawing.Point(126, 3);
            this.btnCopyToClipboardAndClose.Name = "btnCopyToClipboardAndClose";
            this.btnCopyToClipboardAndClose.Size = new System.Drawing.Size(243, 49);
            this.btnCopyToClipboardAndClose.TabIndex = 3;
            this.btnCopyToClipboardAndClose.Text = "Copy to Clipboard and Close";
            this.btnCopyToClipboardAndClose.UseVisualStyleBackColor = true;
            this.btnCopyToClipboardAndClose.Click += new System.EventHandler(this.btnCopyPasswordAndClose_Click);
            // 
            // updnMaxLength
            // 
            this.updnMaxLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updnMaxLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updnMaxLength.Location = new System.Drawing.Point(326, 32);
            this.updnMaxLength.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.updnMaxLength.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.updnMaxLength.Name = "updnMaxLength";
            this.updnMaxLength.Size = new System.Drawing.Size(53, 27);
            this.updnMaxLength.TabIndex = 4;
            this.updnMaxLength.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblMaxLength
            // 
            this.lblMaxLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaxLength.AutoSize = true;
            this.lblMaxLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxLength.Location = new System.Drawing.Point(224, 35);
            this.lblMaxLength.Name = "lblMaxLength";
            this.lblMaxLength.Size = new System.Drawing.Size(96, 20);
            this.lblMaxLength.TabIndex = 5;
            this.lblMaxLength.Text = "Max Length";
            // 
            // lblMinLength
            // 
            this.lblMinLength.AutoSize = true;
            this.lblMinLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinLength.Location = new System.Drawing.Point(9, 35);
            this.lblMinLength.Name = "lblMinLength";
            this.lblMinLength.Size = new System.Drawing.Size(92, 20);
            this.lblMinLength.TabIndex = 7;
            this.lblMinLength.Text = "Min Length";
            // 
            // updnMinLenght
            // 
            this.updnMinLenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updnMinLenght.Location = new System.Drawing.Point(111, 32);
            this.updnMinLenght.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.updnMinLenght.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.updnMinLenght.Name = "updnMinLenght";
            this.updnMinLenght.Size = new System.Drawing.Size(53, 27);
            this.updnMinLenght.TabIndex = 6;
            this.updnMinLenght.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // frameLength
            // 
            this.frameLength.Controls.Add(this.lblMaxLength);
            this.frameLength.Controls.Add(this.lblMinLength);
            this.frameLength.Controls.Add(this.updnMaxLength);
            this.frameLength.Controls.Add(this.updnMinLenght);
            this.frameLength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frameLength.Location = new System.Drawing.Point(3, 3);
            this.frameLength.Name = "frameLength";
            this.frameLength.Size = new System.Drawing.Size(392, 69);
            this.frameLength.TabIndex = 8;
            this.frameLength.TabStop = false;
            this.frameLength.Text = "Password Length";
            // 
            // framePassword
            // 
            this.framePassword.Controls.Add(this.btnGeneratePassword);
            this.framePassword.Controls.Add(this.txtPassword);
            this.framePassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.framePassword.Location = new System.Drawing.Point(3, 78);
            this.framePassword.Name = "framePassword";
            this.framePassword.Padding = new System.Windows.Forms.Padding(10);
            this.framePassword.Size = new System.Drawing.Size(392, 144);
            this.framePassword.TabIndex = 9;
            this.framePassword.TabStop = false;
            // 
            // frameButtons
            // 
            this.frameButtons.Controls.Add(this.tableLayoutPanel2);
            this.frameButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frameButtons.Location = new System.Drawing.Point(3, 228);
            this.frameButtons.Name = "frameButtons";
            this.frameButtons.Padding = new System.Windows.Forms.Padding(10);
            this.frameButtons.Size = new System.Drawing.Size(392, 145);
            this.frameButtons.TabIndex = 10;
            this.frameButtons.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.67F));
            this.tableLayoutPanel2.Controls.Add(this.btnCopyToClipboardAndClose, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCopyToClipboardPasteAndClose, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.brnCancel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 25);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(372, 110);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // btnCopyToClipboardPasteAndClose
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.btnCopyToClipboardPasteAndClose, 2);
            this.btnCopyToClipboardPasteAndClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCopyToClipboardPasteAndClose.Location = new System.Drawing.Point(3, 58);
            this.btnCopyToClipboardPasteAndClose.Name = "btnCopyToClipboardPasteAndClose";
            this.btnCopyToClipboardPasteAndClose.Size = new System.Drawing.Size(366, 49);
            this.btnCopyToClipboardPasteAndClose.TabIndex = 4;
            this.btnCopyToClipboardPasteAndClose.Text = "Copy to Clipboard, Paste, and Close";
            this.btnCopyToClipboardPasteAndClose.UseVisualStyleBackColor = true;
            this.btnCopyToClipboardPasteAndClose.Click += new System.EventHandler(this.btnCopyToClipboardPasteAndClose_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.frameLength, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.frameButtons, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.framePassword, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(398, 376);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // frmRandomPasswordDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 376);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRandomPasswordDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Random Password";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRandomPasswordDialog_FormClosing);
            this.Load += new System.EventHandler(this.frmRandomPasswordDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updnMaxLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnMinLenght)).EndInit();
            this.frameLength.ResumeLayout(false);
            this.frameLength.PerformLayout();
            this.framePassword.ResumeLayout(false);
            this.framePassword.PerformLayout();
            this.frameButtons.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGeneratePassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button brnCancel;
        private System.Windows.Forms.Button btnCopyToClipboardAndClose;
        private System.Windows.Forms.NumericUpDown updnMaxLength;
        private System.Windows.Forms.Label lblMaxLength;
        private System.Windows.Forms.Label lblMinLength;
        private System.Windows.Forms.NumericUpDown updnMinLenght;
        private System.Windows.Forms.GroupBox frameLength;
        private System.Windows.Forms.GroupBox framePassword;
        private System.Windows.Forms.GroupBox frameButtons;
        private System.Windows.Forms.Button btnCopyToClipboardPasteAndClose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}