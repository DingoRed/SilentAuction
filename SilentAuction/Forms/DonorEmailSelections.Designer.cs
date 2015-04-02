namespace SilentAuction.Forms
{
    partial class DonorEmailSelections
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonorEmailSelections));
            this.DonorsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailDonorsButton = new System.Windows.Forms.Button();
            this.CancelPrintDonorsButton = new System.Windows.Forms.Button();
            this.donorsWithEmailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.silentAuctionDataSet = new SilentAuction.SilentAuctionDataSet();
            this.donorsWithEmailsTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.DonorsWithEmailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.donorsWithEmailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DonorsListBox
            // 
            this.DonorsListBox.FormattingEnabled = true;
            this.DonorsListBox.Location = new System.Drawing.Point(16, 29);
            this.DonorsListBox.Name = "DonorsListBox";
            this.DonorsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.DonorsListBox.Size = new System.Drawing.Size(256, 186);
            this.DonorsListBox.TabIndex = 0;
            this.DonorsListBox.ValueMember = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Donors to Email:";
            // 
            // EmailDonorsButton
            // 
            this.EmailDonorsButton.Location = new System.Drawing.Point(51, 227);
            this.EmailDonorsButton.Name = "EmailDonorsButton";
            this.EmailDonorsButton.Size = new System.Drawing.Size(75, 23);
            this.EmailDonorsButton.TabIndex = 2;
            this.EmailDonorsButton.Text = "Email";
            this.EmailDonorsButton.UseVisualStyleBackColor = true;
            this.EmailDonorsButton.Click += new System.EventHandler(this.EmailDonorsButtonClick);
            // 
            // CancelPrintDonorsButton
            // 
            this.CancelPrintDonorsButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelPrintDonorsButton.Location = new System.Drawing.Point(158, 227);
            this.CancelPrintDonorsButton.Name = "CancelPrintDonorsButton";
            this.CancelPrintDonorsButton.Size = new System.Drawing.Size(75, 23);
            this.CancelPrintDonorsButton.TabIndex = 3;
            this.CancelPrintDonorsButton.Text = "Cancel";
            this.CancelPrintDonorsButton.UseVisualStyleBackColor = true;
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
            // DonorEmailSelections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelPrintDonorsButton;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.CancelPrintDonorsButton);
            this.Controls.Add(this.EmailDonorsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DonorsListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DonorEmailSelections";
            this.Text = "Donor Email Selections";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DonorSelectionsFormClosing);
            this.Load += new System.EventHandler(this.DonorSelectionsLoad);
            ((System.ComponentModel.ISupportInitialize)(this.donorsWithEmailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox DonorsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EmailDonorsButton;
        private System.Windows.Forms.Button CancelPrintDonorsButton;
        private System.Windows.Forms.BindingSource donorsWithEmailsBindingSource;
        private SilentAuctionDataSet silentAuctionDataSet;
        private SilentAuctionDataSetTableAdapters.DonorsWithEmailsTableAdapter donorsWithEmailsTableAdapter;
    }
}