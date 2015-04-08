namespace SilentAuction.Forms
{
    partial class EmailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailForm));
            this.DonorsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailButton = new System.Windows.Forms.Button();
            this.CancelEmailButton = new System.Windows.Forms.Button();
            this.donorsWithEmailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.silentAuctionDataSet = new SilentAuction.SilentAuctionDataSet();
            this.donorsWithEmailsTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.DonorsWithEmailsTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.donorsWithEmailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailAccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // DonorsListBox
            // 
            this.DonorsListBox.DataSource = this.donorsWithEmailsBindingSource;
            this.DonorsListBox.DisplayMember = "Name";
            this.DonorsListBox.FormattingEnabled = true;
            this.DonorsListBox.Location = new System.Drawing.Point(72, 19);
            this.DonorsListBox.Name = "DonorsListBox";
            this.DonorsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.DonorsListBox.Size = new System.Drawing.Size(256, 95);
            this.DonorsListBox.TabIndex = 0;
            this.DonorsListBox.ValueMember = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "To:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EmailButton
            // 
            this.EmailButton.Location = new System.Drawing.Point(96, 352);
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
            this.CancelEmailButton.Location = new System.Drawing.Point(203, 352);
            this.CancelEmailButton.Name = "CancelEmailButton";
            this.CancelEmailButton.Size = new System.Drawing.Size(75, 23);
            this.CancelEmailButton.TabIndex = 3;
            this.CancelEmailButton.Text = "Cancel";
            this.CancelEmailButton.UseVisualStyleBackColor = true;
            // 
            // donorsWithEmailsBindingSource
            // 
            this.donorsWithEmailsBindingSource.DataMember = "DonorsWithEmails";
            this.donorsWithEmailsBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // silentAuctionDataSet
            // 
            this.silentAuctionDataSet.DataSetName = "SilentAuctionDataSet";
            this.silentAuctionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // donorsWithEmailsTableAdapter
            // 
            this.donorsWithEmailsTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Account:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AccountTextBox
            // 
            this.AccountTextBox.Location = new System.Drawing.Point(72, 19);
            this.AccountTextBox.Name = "AccountTextBox";
            this.AccountTextBox.Size = new System.Drawing.Size(256, 20);
            this.AccountTextBox.TabIndex = 6;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(72, 47);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(256, 20);
            this.PasswordTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cc:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CcTextBox
            // 
            this.CcTextBox.Location = new System.Drawing.Point(72, 122);
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
            this.groupBox1.Size = new System.Drawing.Size(347, 102);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Email Account";
            // 
            // SaveAccountCheckBox
            // 
            this.SaveAccountCheckBox.AutoSize = true;
            this.SaveAccountCheckBox.Location = new System.Drawing.Point(72, 75);
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
            this.groupBox2.Size = new System.Drawing.Size(347, 182);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Email";
            // 
            // SubjectTextBox
            // 
            this.SubjectTextBox.Location = new System.Drawing.Point(72, 148);
            this.SubjectTextBox.Name = "SubjectTextBox";
            this.SubjectTextBox.Size = new System.Drawing.Size(256, 20);
            this.SubjectTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 151);
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
            // EmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelEmailButton;
            this.ClientSize = new System.Drawing.Size(395, 402);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancelEmailButton);
            this.Controls.Add(this.EmailButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmailForm";
            this.Text = "Email";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmailFormClosing);
            this.Load += new System.EventHandler(this.EmailFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.donorsWithEmailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailAccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox DonorsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EmailButton;
        private System.Windows.Forms.Button CancelEmailButton;
        private System.Windows.Forms.BindingSource donorsWithEmailsBindingSource;
        private SilentAuctionDataSet silentAuctionDataSet;
        private SilentAuctionDataSetTableAdapters.DonorsWithEmailsTableAdapter donorsWithEmailsTableAdapter;
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
    }
}