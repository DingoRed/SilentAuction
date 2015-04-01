namespace SilentAuction.Forms
{
    partial class CopyDonorsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CopyDonorsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AuctionToComboBox = new System.Windows.Forms.ComboBox();
            this.auctionToBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.silentAuctionDataSet = new SilentAuction.SilentAuctionDataSet();
            this.DonorsListBox = new System.Windows.Forms.ListBox();
            this.donorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AuctionFromComboBox = new System.Windows.Forms.ComboBox();
            this.auctionFromBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auctionFromTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.AuctionsTableAdapter();
            this.SaveDonorsButton = new System.Windows.Forms.Button();
            this.SaveDonorsAndCloseButton = new System.Windows.Forms.Button();
            this.CancelCopyDonorsButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.donorsTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.DonorsTableAdapter();
            this.donorTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestFormatTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donorTypesTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.DonorTypesTableAdapter();
            this.requestFormatTypesTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.RequestFormatTypesTableAdapter();
            this.requestStatusTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestStatusTypesTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.RequestStatusTypesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.auctionToBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionFromBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donorTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestFormatTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestStatusTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Step 1 - Select the Auction to copy the Donor(s) from:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Step 3 - Select the Donor(s) to copy:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Step 2 - Select the Auction to copy the Donor(s) to:";
            // 
            // AuctionToComboBox
            // 
            this.AuctionToComboBox.DataSource = this.auctionToBindingSource;
            this.AuctionToComboBox.DisplayMember = "Name";
            this.AuctionToComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AuctionToComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuctionToComboBox.FormattingEnabled = true;
            this.AuctionToComboBox.Location = new System.Drawing.Point(18, 109);
            this.AuctionToComboBox.Name = "AuctionToComboBox";
            this.AuctionToComboBox.Size = new System.Drawing.Size(253, 21);
            this.AuctionToComboBox.TabIndex = 4;
            this.AuctionToComboBox.ValueMember = "Id";
            this.AuctionToComboBox.SelectedIndexChanged += new System.EventHandler(this.AuctionToComboBoxSelectedIndexChanged);
            // 
            // auctionToBindingSource
            // 
            this.auctionToBindingSource.DataMember = "Auctions";
            this.auctionToBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // silentAuctionDataSet
            // 
            this.silentAuctionDataSet.DataSetName = "SilentAuctionDataSet";
            this.silentAuctionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DonorsListBox
            // 
            this.DonorsListBox.DataSource = this.donorsBindingSource;
            this.DonorsListBox.DisplayMember = "Name";
            this.DonorsListBox.FormattingEnabled = true;
            this.DonorsListBox.Location = new System.Drawing.Point(18, 172);
            this.DonorsListBox.Name = "DonorsListBox";
            this.DonorsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.DonorsListBox.Size = new System.Drawing.Size(256, 186);
            this.DonorsListBox.TabIndex = 5;
            this.DonorsListBox.ValueMember = "Id";
            // 
            // donorsBindingSource
            // 
            this.donorsBindingSource.DataMember = "Donors";
            this.donorsBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // AuctionFromComboBox
            // 
            this.AuctionFromComboBox.DataSource = this.auctionFromBindingSource;
            this.AuctionFromComboBox.DisplayMember = "Name";
            this.AuctionFromComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AuctionFromComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuctionFromComboBox.FormattingEnabled = true;
            this.AuctionFromComboBox.Location = new System.Drawing.Point(18, 45);
            this.AuctionFromComboBox.Name = "AuctionFromComboBox";
            this.AuctionFromComboBox.Size = new System.Drawing.Size(253, 21);
            this.AuctionFromComboBox.TabIndex = 6;
            this.AuctionFromComboBox.ValueMember = "Id";
            this.AuctionFromComboBox.SelectedIndexChanged += new System.EventHandler(this.AuctionFromComboBoxSelectedIndexChanged);
            // 
            // auctionFromBindingSource
            // 
            this.auctionFromBindingSource.DataMember = "Auctions";
            this.auctionFromBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // auctionFromTableAdapter
            // 
            this.auctionFromTableAdapter.ClearBeforeFill = true;
            // 
            // SaveDonorsButton
            // 
            this.SaveDonorsButton.Location = new System.Drawing.Point(17, 421);
            this.SaveDonorsButton.Name = "SaveDonorsButton";
            this.SaveDonorsButton.Size = new System.Drawing.Size(75, 23);
            this.SaveDonorsButton.TabIndex = 7;
            this.SaveDonorsButton.Text = "Save";
            this.SaveDonorsButton.UseVisualStyleBackColor = true;
            this.SaveDonorsButton.Click += new System.EventHandler(this.SaveDonorsButtonClick);
            // 
            // SaveDonorsAndCloseButton
            // 
            this.SaveDonorsAndCloseButton.AutoSize = true;
            this.SaveDonorsAndCloseButton.Location = new System.Drawing.Point(116, 421);
            this.SaveDonorsAndCloseButton.Name = "SaveDonorsAndCloseButton";
            this.SaveDonorsAndCloseButton.Size = new System.Drawing.Size(92, 23);
            this.SaveDonorsAndCloseButton.TabIndex = 8;
            this.SaveDonorsAndCloseButton.Text = "Save and Close";
            this.SaveDonorsAndCloseButton.UseVisualStyleBackColor = true;
            this.SaveDonorsAndCloseButton.Click += new System.EventHandler(this.SaveDonorsAndCloseButtonClick);
            // 
            // CancelCopyDonorsButton
            // 
            this.CancelCopyDonorsButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelCopyDonorsButton.Location = new System.Drawing.Point(232, 421);
            this.CancelCopyDonorsButton.Name = "CancelCopyDonorsButton";
            this.CancelCopyDonorsButton.Size = new System.Drawing.Size(75, 23);
            this.CancelCopyDonorsButton.TabIndex = 9;
            this.CancelCopyDonorsButton.Text = "Cancel";
            this.CancelCopyDonorsButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ErrorLabel);
            this.groupBox1.Controls.Add(this.DonorsListBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.AuctionFromComboBox);
            this.groupBox1.Controls.Add(this.AuctionToComboBox);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 378);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Copy Donors";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(15, 133);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(211, 13);
            this.ErrorLabel.TabIndex = 7;
            this.ErrorLabel.Text = "\"To\" and \"From\" auctions must be different";
            this.ErrorLabel.Visible = false;
            // 
            // donorsTableAdapter
            // 
            this.donorsTableAdapter.ClearBeforeFill = true;
            // 
            // donorTypesBindingSource
            // 
            this.donorTypesBindingSource.DataMember = "DonorTypes";
            this.donorTypesBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // requestFormatTypesBindingSource
            // 
            this.requestFormatTypesBindingSource.DataMember = "RequestFormatTypes";
            this.requestFormatTypesBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // donorTypesTableAdapter
            // 
            this.donorTypesTableAdapter.ClearBeforeFill = true;
            // 
            // requestFormatTypesTableAdapter
            // 
            this.requestFormatTypesTableAdapter.ClearBeforeFill = true;
            // 
            // requestStatusTypesBindingSource
            // 
            this.requestStatusTypesBindingSource.DataMember = "RequestStatusTypes";
            this.requestStatusTypesBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // requestStatusTypesTableAdapter
            // 
            this.requestStatusTypesTableAdapter.ClearBeforeFill = true;
            // 
            // CopyDonorsForm
            // 
            this.AcceptButton = this.SaveDonorsButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelCopyDonorsButton;
            this.ClientSize = new System.Drawing.Size(324, 477);
            this.Controls.Add(this.CancelCopyDonorsButton);
            this.Controls.Add(this.SaveDonorsAndCloseButton);
            this.Controls.Add(this.SaveDonorsButton);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CopyDonorsForm";
            this.Text = "Copy Donors";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CopyDonorsFormFormClosing);
            this.Load += new System.EventHandler(this.CopyDonorsLoad);
            ((System.ComponentModel.ISupportInitialize)(this.auctionToBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionFromBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donorTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestFormatTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestStatusTypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox AuctionToComboBox;
        private System.Windows.Forms.ListBox DonorsListBox;
        private System.Windows.Forms.ComboBox AuctionFromComboBox;
        private System.Windows.Forms.BindingSource auctionFromBindingSource;
        private SilentAuctionDataSet silentAuctionDataSet;
        private SilentAuctionDataSetTableAdapters.AuctionsTableAdapter auctionFromTableAdapter;
        private System.Windows.Forms.Button SaveDonorsButton;
        private System.Windows.Forms.Button SaveDonorsAndCloseButton;
        private System.Windows.Forms.Button CancelCopyDonorsButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource donorsBindingSource;
        private SilentAuctionDataSetTableAdapters.DonorsTableAdapter donorsTableAdapter;
        private System.Windows.Forms.BindingSource auctionToBindingSource;
        private System.Windows.Forms.BindingSource donorTypesBindingSource;
        private System.Windows.Forms.BindingSource requestFormatTypesBindingSource;
        private SilentAuctionDataSetTableAdapters.DonorTypesTableAdapter donorTypesTableAdapter;
        private SilentAuctionDataSetTableAdapters.RequestFormatTypesTableAdapter requestFormatTypesTableAdapter;
        private System.Windows.Forms.BindingSource requestStatusTypesBindingSource;
        private SilentAuctionDataSetTableAdapters.RequestStatusTypesTableAdapter requestStatusTypesTableAdapter;
        private System.Windows.Forms.Label ErrorLabel;
    }
}