namespace SilentAuction.Forms
{
    partial class DocumentEmailForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentEmailForm));
            this.DonorsListBox = new System.Windows.Forms.ListBox();
            this.silentAuctionDataSet = new SilentAuction.SilentAuctionDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailButton = new System.Windows.Forms.Button();
            this.CancelEmailButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AccountTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CcTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveAccountCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SubjectTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.emailAccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailAccountsTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.EmailAccountsTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.attachmentListLabel = new System.Windows.Forms.Label();
            this.ClearAttachmentsButton = new System.Windows.Forms.Button();
            this.AttachFileButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.attachmentOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.donorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donorsTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.DonorsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailAccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DonorsListBox
            // 
            this.DonorsListBox.DataSource = this.donorsBindingSource;
            this.DonorsListBox.DisplayMember = "Name";
            this.DonorsListBox.FormattingEnabled = true;
            this.DonorsListBox.Location = new System.Drawing.Point(85, 19);
            this.DonorsListBox.Name = "DonorsListBox";
            this.DonorsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.DonorsListBox.Size = new System.Drawing.Size(256, 95);
            this.DonorsListBox.TabIndex = 0;
            this.DonorsListBox.ValueMember = "Id";
            // 
            // silentAuctionDataSet
            // 
            this.silentAuctionDataSet.DataSetName = "SilentAuctionDataSet";
            this.silentAuctionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "To:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EmailButton
            // 
            this.EmailButton.Location = new System.Drawing.Point(110, 447);
            this.EmailButton.Name = "EmailButton";
            this.EmailButton.Size = new System.Drawing.Size(75, 23);
            this.EmailButton.TabIndex = 2;
            this.EmailButton.Text = "Email";
            this.EmailButton.UseVisualStyleBackColor = true;
            this.EmailButton.Click += new System.EventHandler(this.EmailButtonClick);
            // 
            // CancelEmailButton
            // 
            this.CancelEmailButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelEmailButton.Location = new System.Drawing.Point(217, 447);
            this.CancelEmailButton.Name = "CancelEmailButton";
            this.CancelEmailButton.Size = new System.Drawing.Size(75, 23);
            this.CancelEmailButton.TabIndex = 3;
            this.CancelEmailButton.Text = "Cancel";
            this.CancelEmailButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Account:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AccountTextBox
            // 
            this.AccountTextBox.Location = new System.Drawing.Point(85, 19);
            this.AccountTextBox.Name = "AccountTextBox";
            this.AccountTextBox.Size = new System.Drawing.Size(256, 20);
            this.AccountTextBox.TabIndex = 6;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(85, 47);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(256, 20);
            this.PasswordTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cc:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CcTextBox
            // 
            this.CcTextBox.Location = new System.Drawing.Point(85, 122);
            this.CcTextBox.Name = "CcTextBox";
            this.CcTextBox.Size = new System.Drawing.Size(256, 20);
            this.CcTextBox.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SaveAccountCheckBox);
            this.groupBox1.Controls.Add(this.PasswordTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.AccountTextBox);
            this.groupBox1.Location = new System.Drawing.Point(23, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 102);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Email Account";
            // 
            // SaveAccountCheckBox
            // 
            this.SaveAccountCheckBox.AutoSize = true;
            this.SaveAccountCheckBox.Location = new System.Drawing.Point(85, 75);
            this.SaveAccountCheckBox.Name = "SaveAccountCheckBox";
            this.SaveAccountCheckBox.Size = new System.Drawing.Size(145, 17);
            this.SaveAccountCheckBox.TabIndex = 8;
            this.SaveAccountCheckBox.Text = "Save Account/Password";
            this.SaveAccountCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SubjectTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.DonorsListBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.CcTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(23, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 182);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Email";
            // 
            // SubjectTextBox
            // 
            this.SubjectTextBox.Location = new System.Drawing.Point(85, 148);
            this.SubjectTextBox.Name = "SubjectTextBox";
            this.SubjectTextBox.Size = new System.Drawing.Size(256, 20);
            this.SubjectTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Subject:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // emailAccountsBindingSource
            // 
            this.emailAccountsBindingSource.DataMember = "EmailAccounts";
            this.emailAccountsBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // emailAccountsTableAdapter
            // 
            this.emailAccountsTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.attachmentListLabel);
            this.groupBox3.Controls.Add(this.ClearAttachmentsButton);
            this.groupBox3.Controls.Add(this.AttachFileButton);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(23, 340);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(357, 84);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Attachments";
            // 
            // attachmentListLabel
            // 
            this.attachmentListLabel.AutoEllipsis = true;
            this.attachmentListLabel.AutoSize = true;
            this.attachmentListLabel.Location = new System.Drawing.Point(85, 22);
            this.attachmentListLabel.MaximumSize = new System.Drawing.Size(256, 13);
            this.attachmentListLabel.Name = "attachmentListLabel";
            this.attachmentListLabel.Size = new System.Drawing.Size(33, 13);
            this.attachmentListLabel.TabIndex = 15;
            this.attachmentListLabel.Text = "None";
            this.attachmentListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClearAttachmentsButton
            // 
            this.ClearAttachmentsButton.Location = new System.Drawing.Point(194, 45);
            this.ClearAttachmentsButton.Name = "ClearAttachmentsButton";
            this.ClearAttachmentsButton.Size = new System.Drawing.Size(75, 23);
            this.ClearAttachmentsButton.TabIndex = 14;
            this.ClearAttachmentsButton.Text = "Clear";
            this.ClearAttachmentsButton.UseVisualStyleBackColor = true;
            this.ClearAttachmentsButton.Click += new System.EventHandler(this.ClearAttachmentsButtonClick);
            // 
            // AttachFileButton
            // 
            this.AttachFileButton.Location = new System.Drawing.Point(87, 45);
            this.AttachFileButton.Name = "AttachFileButton";
            this.AttachFileButton.Size = new System.Drawing.Size(75, 23);
            this.AttachFileButton.TabIndex = 13;
            this.AttachFileButton.Text = "Attach File";
            this.AttachFileButton.UseVisualStyleBackColor = true;
            this.AttachFileButton.Click += new System.EventHandler(this.AttachFileButtonClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Attachments:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // attachmentOpenFileDialog
            // 
            this.attachmentOpenFileDialog.Filter = "All files (*.*)|*.*";
            this.attachmentOpenFileDialog.Multiselect = true;
            this.attachmentOpenFileDialog.Title = "Attach File(s)";
            // 
            // donorsBindingSource
            // 
            this.donorsBindingSource.DataMember = "Donors";
            this.donorsBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // donorsTableAdapter
            // 
            this.donorsTableAdapter.ClearBeforeFill = true;
            // 
            // DocumentEmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelEmailButton;
            this.ClientSize = new System.Drawing.Size(402, 496);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancelEmailButton);
            this.Controls.Add(this.EmailButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DocumentEmailForm";
            this.Text = "Email";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmailFormClosing);
            this.Load += new System.EventHandler(this.EmailFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailAccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox DonorsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EmailButton;
        private System.Windows.Forms.Button CancelEmailButton;
        private SilentAuctionDataSet silentAuctionDataSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AccountTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CcTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox SaveAccountCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox SubjectTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource emailAccountsBindingSource;
        private SilentAuctionDataSetTableAdapters.EmailAccountsTableAdapter emailAccountsTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button AttachFileButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog attachmentOpenFileDialog;
        private System.Windows.Forms.Button ClearAttachmentsButton;
        private System.Windows.Forms.Label attachmentListLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.BindingSource donorsBindingSource;
        private SilentAuctionDataSetTableAdapters.DonorsTableAdapter donorsTableAdapter;
    }
}