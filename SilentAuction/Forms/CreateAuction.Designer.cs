namespace SilentAuction.Forms
{
    partial class CreateNewAuctionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewAuctionForm));
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.SaveAuctionButton = new System.Windows.Forms.Button();
            this.CancelAuctionButton = new System.Windows.Forms.Button();
            this.auctionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.silentAuctionDataSet = new SilentAuction.SilentAuctionDataSet();
            this.auctionsTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.AuctionsTableAdapter();
            this.SaveAuctionAndCloseButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CopyFromAuctionLabel = new System.Windows.Forms.Label();
            this.CopyFromAuctionComboBox = new System.Windows.Forms.ComboBox();
            this.CopyDonorsCheckBox = new System.Windows.Forms.CheckBox();
            this.AuctionNameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.donorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donorsTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.DonorsTableAdapter();
            this.donorTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donorTypesTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.DonorTypesTableAdapter();
            this.requestFormatTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestFormatTypesTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.RequestFormatTypesTableAdapter();
            this.requestStatusTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestStatusTypesTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.RequestStatusTypesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.auctionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AuctionNameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestFormatTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestStatusTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(22, 32);
            this.NameTextBox.MaxLength = 200;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(302, 20);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBoxTextChanged);
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(22, 85);
            this.DescriptionTextBox.MaxLength = 5000;
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(302, 93);
            this.DescriptionTextBox.TabIndex = 2;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(22, 16);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(129, 13);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Auction Name (Required):";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(22, 69);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(102, 13);
            this.DescriptionLabel.TabIndex = 3;
            this.DescriptionLabel.Text = "Auction Description:";
            // 
            // SaveAuctionButton
            // 
            this.SaveAuctionButton.Location = new System.Drawing.Point(47, 346);
            this.SaveAuctionButton.Name = "SaveAuctionButton";
            this.SaveAuctionButton.Size = new System.Drawing.Size(75, 23);
            this.SaveAuctionButton.TabIndex = 2;
            this.SaveAuctionButton.Text = "Save";
            this.SaveAuctionButton.UseVisualStyleBackColor = true;
            this.SaveAuctionButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // CancelAuctionButton
            // 
            this.CancelAuctionButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelAuctionButton.Location = new System.Drawing.Point(262, 346);
            this.CancelAuctionButton.Name = "CancelAuctionButton";
            this.CancelAuctionButton.Size = new System.Drawing.Size(75, 23);
            this.CancelAuctionButton.TabIndex = 4;
            this.CancelAuctionButton.Text = "Cancel";
            this.CancelAuctionButton.UseVisualStyleBackColor = true;
            // 
            // auctionsBindingSource
            // 
            this.auctionsBindingSource.DataMember = "Auctions";
            this.auctionsBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // silentAuctionDataSet
            // 
            this.silentAuctionDataSet.DataSetName = "SilentAuctionDataSet";
            this.silentAuctionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // auctionsTableAdapter
            // 
            this.auctionsTableAdapter.ClearBeforeFill = true;
            // 
            // SaveAuctionAndCloseButton
            // 
            this.SaveAuctionAndCloseButton.AutoSize = true;
            this.SaveAuctionAndCloseButton.Location = new System.Drawing.Point(146, 346);
            this.SaveAuctionAndCloseButton.Name = "SaveAuctionAndCloseButton";
            this.SaveAuctionAndCloseButton.Size = new System.Drawing.Size(92, 23);
            this.SaveAuctionAndCloseButton.TabIndex = 3;
            this.SaveAuctionAndCloseButton.Text = "Save and Close";
            this.SaveAuctionAndCloseButton.UseVisualStyleBackColor = true;
            this.SaveAuctionAndCloseButton.Click += new System.EventHandler(this.SaveAuctionAndCloseButtonClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DescriptionTextBox);
            this.groupBox1.Controls.Add(this.NameTextBox);
            this.groupBox1.Controls.Add(this.NameLabel);
            this.groupBox1.Controls.Add(this.DescriptionLabel);
            this.groupBox1.Location = new System.Drawing.Point(19, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 204);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auction Items";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CopyFromAuctionLabel);
            this.groupBox2.Controls.Add(this.CopyFromAuctionComboBox);
            this.groupBox2.Controls.Add(this.CopyDonorsCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(19, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 96);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Copy Donors";
            // 
            // CopyFromAuctionLabel
            // 
            this.CopyFromAuctionLabel.AutoSize = true;
            this.CopyFromAuctionLabel.Enabled = false;
            this.CopyFromAuctionLabel.Location = new System.Drawing.Point(22, 56);
            this.CopyFromAuctionLabel.Name = "CopyFromAuctionLabel";
            this.CopyFromAuctionLabel.Size = new System.Drawing.Size(96, 13);
            this.CopyFromAuctionLabel.TabIndex = 3;
            this.CopyFromAuctionLabel.Text = "Copy from Auction:";
            // 
            // CopyFromAuctionComboBox
            // 
            this.CopyFromAuctionComboBox.DataSource = this.auctionsBindingSource;
            this.CopyFromAuctionComboBox.DisplayMember = "Name";
            this.CopyFromAuctionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CopyFromAuctionComboBox.Enabled = false;
            this.CopyFromAuctionComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyFromAuctionComboBox.FormattingEnabled = true;
            this.CopyFromAuctionComboBox.Location = new System.Drawing.Point(124, 53);
            this.CopyFromAuctionComboBox.Name = "CopyFromAuctionComboBox";
            this.CopyFromAuctionComboBox.Size = new System.Drawing.Size(200, 21);
            this.CopyFromAuctionComboBox.TabIndex = 2;
            this.CopyFromAuctionComboBox.ValueMember = "Id";
            // 
            // CopyDonorsCheckBox
            // 
            this.CopyDonorsCheckBox.AutoSize = true;
            this.CopyDonorsCheckBox.Location = new System.Drawing.Point(22, 19);
            this.CopyDonorsCheckBox.Name = "CopyDonorsCheckBox";
            this.CopyDonorsCheckBox.Size = new System.Drawing.Size(201, 17);
            this.CopyDonorsCheckBox.TabIndex = 1;
            this.CopyDonorsCheckBox.Text = "Copy all Donors from another Auction";
            this.CopyDonorsCheckBox.UseVisualStyleBackColor = true;
            this.CopyDonorsCheckBox.CheckedChanged += new System.EventHandler(this.CopyDonorsCheckBoxCheckedChanged);
            // 
            // AuctionNameErrorProvider
            // 
            this.AuctionNameErrorProvider.ContainerControl = this;
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
            // donorTypesBindingSource
            // 
            this.donorTypesBindingSource.DataMember = "DonorTypes";
            this.donorTypesBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // donorTypesTableAdapter
            // 
            this.donorTypesTableAdapter.ClearBeforeFill = true;
            // 
            // requestFormatTypesBindingSource
            // 
            this.requestFormatTypesBindingSource.DataMember = "RequestFormatTypes";
            this.requestFormatTypesBindingSource.DataSource = this.silentAuctionDataSet;
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
            // CreateNewAuctionForm
            // 
            this.AcceptButton = this.SaveAuctionButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelAuctionButton;
            this.ClientSize = new System.Drawing.Size(384, 395);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SaveAuctionAndCloseButton);
            this.Controls.Add(this.CancelAuctionButton);
            this.Controls.Add(this.SaveAuctionButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateNewAuctionForm";
            this.Text = "Create New Auction";
            this.Load += new System.EventHandler(this.CreateNewAuctionFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.auctionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AuctionNameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestFormatTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestStatusTypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Button SaveAuctionButton;
        private System.Windows.Forms.Button CancelAuctionButton;
        private System.Windows.Forms.BindingSource auctionsBindingSource;
        private SilentAuctionDataSet silentAuctionDataSet;
        private SilentAuctionDataSetTableAdapters.AuctionsTableAdapter auctionsTableAdapter;
        private System.Windows.Forms.Button SaveAuctionAndCloseButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label CopyFromAuctionLabel;
        private System.Windows.Forms.ComboBox CopyFromAuctionComboBox;
        private System.Windows.Forms.CheckBox CopyDonorsCheckBox;
        private System.Windows.Forms.ErrorProvider AuctionNameErrorProvider;
        private System.Windows.Forms.BindingSource donorsBindingSource;
        private SilentAuctionDataSetTableAdapters.DonorsTableAdapter donorsTableAdapter;
        private System.Windows.Forms.BindingSource donorTypesBindingSource;
        private SilentAuctionDataSetTableAdapters.DonorTypesTableAdapter donorTypesTableAdapter;
        private System.Windows.Forms.BindingSource requestFormatTypesBindingSource;
        private SilentAuctionDataSetTableAdapters.RequestFormatTypesTableAdapter requestFormatTypesTableAdapter;
        private System.Windows.Forms.BindingSource requestStatusTypesBindingSource;
        private SilentAuctionDataSetTableAdapters.RequestStatusTypesTableAdapter requestStatusTypesTableAdapter;
    }
}