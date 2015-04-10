namespace SilentAuction.Forms
{
    partial class EditAuctionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAuctionForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.SaveAuctionAndCloseButton = new System.Windows.Forms.Button();
            this.CancelAuctionButton = new System.Windows.Forms.Button();
            this.SaveAuctionButton = new System.Windows.Forms.Button();
            this.AuctionComboBox = new System.Windows.Forms.ComboBox();
            this.auctionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.silentAuctionDataSet = new SilentAuction.SilentAuctionDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.auctionsTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.AuctionsTableAdapter();
            this.AuctionNameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.auctionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuctionNameErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DescriptionTextBox);
            this.groupBox1.Controls.Add(this.NameTextBox);
            this.groupBox1.Controls.Add(this.NameLabel);
            this.groupBox1.Controls.Add(this.DescriptionLabel);
            this.groupBox1.Location = new System.Drawing.Point(19, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 236);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auction Items";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(22, 102);
            this.DescriptionTextBox.MaxLength = 5000;
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(260, 93);
            this.DescriptionTextBox.TabIndex = 2;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(22, 48);
            this.NameTextBox.MaxLength = 200;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(260, 20);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBoxTextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(22, 32);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(129, 13);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Auction Name (Required):";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(22, 86);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(102, 13);
            this.DescriptionLabel.TabIndex = 3;
            this.DescriptionLabel.Text = "Auction Description:";
            // 
            // SaveAuctionAndCloseButton
            // 
            this.SaveAuctionAndCloseButton.AutoSize = true;
            this.SaveAuctionAndCloseButton.Location = new System.Drawing.Point(125, 344);
            this.SaveAuctionAndCloseButton.Name = "SaveAuctionAndCloseButton";
            this.SaveAuctionAndCloseButton.Size = new System.Drawing.Size(92, 23);
            this.SaveAuctionAndCloseButton.TabIndex = 4;
            this.SaveAuctionAndCloseButton.Text = "Save and Close";
            this.SaveAuctionAndCloseButton.UseVisualStyleBackColor = true;
            this.SaveAuctionAndCloseButton.Click += new System.EventHandler(this.SaveAuctionAndCloseButtonClick);
            // 
            // CancelAuctionButton
            // 
            this.CancelAuctionButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelAuctionButton.Location = new System.Drawing.Point(241, 344);
            this.CancelAuctionButton.Name = "CancelAuctionButton";
            this.CancelAuctionButton.Size = new System.Drawing.Size(75, 23);
            this.CancelAuctionButton.TabIndex = 5;
            this.CancelAuctionButton.Text = "Cancel";
            this.CancelAuctionButton.UseVisualStyleBackColor = true;
            // 
            // SaveAuctionButton
            // 
            this.SaveAuctionButton.Location = new System.Drawing.Point(26, 344);
            this.SaveAuctionButton.Name = "SaveAuctionButton";
            this.SaveAuctionButton.Size = new System.Drawing.Size(75, 23);
            this.SaveAuctionButton.TabIndex = 3;
            this.SaveAuctionButton.Text = "Save";
            this.SaveAuctionButton.UseVisualStyleBackColor = true;
            this.SaveAuctionButton.Click += new System.EventHandler(this.SaveAuctionButtonClick);
            // 
            // AuctionComboBox
            // 
            this.AuctionComboBox.DataSource = this.auctionsBindingSource;
            this.AuctionComboBox.DisplayMember = "Name";
            this.AuctionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AuctionComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuctionComboBox.FormattingEnabled = true;
            this.AuctionComboBox.Location = new System.Drawing.Point(137, 20);
            this.AuctionComboBox.Name = "AuctionComboBox";
            this.AuctionComboBox.Size = new System.Drawing.Size(187, 21);
            this.AuctionComboBox.TabIndex = 1;
            this.AuctionComboBox.ValueMember = "Id";
            this.AuctionComboBox.SelectedIndexChanged += new System.EventHandler(this.AuctionComboBoxSelectedIndexChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select Auction to Edit:";
            // 
            // auctionsTableAdapter
            // 
            this.auctionsTableAdapter.ClearBeforeFill = true;
            // 
            // AuctionNameErrorProvider
            // 
            this.AuctionNameErrorProvider.ContainerControl = this;
            // 
            // EditAuctionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelAuctionButton;
            this.ClientSize = new System.Drawing.Size(343, 398);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AuctionComboBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SaveAuctionAndCloseButton);
            this.Controls.Add(this.CancelAuctionButton);
            this.Controls.Add(this.SaveAuctionButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditAuctionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Edit an Auction";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditAuctionFormFormClosing);
            this.Load += new System.EventHandler(this.EditAuctionFormLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.auctionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuctionNameErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Button SaveAuctionAndCloseButton;
        private System.Windows.Forms.Button CancelAuctionButton;
        private System.Windows.Forms.Button SaveAuctionButton;
        private System.Windows.Forms.ComboBox AuctionComboBox;
        private System.Windows.Forms.Label label1;
        private SilentAuctionDataSet silentAuctionDataSet;
        private System.Windows.Forms.BindingSource auctionsBindingSource;
        private SilentAuctionDataSetTableAdapters.AuctionsTableAdapter auctionsTableAdapter;
        private System.Windows.Forms.ErrorProvider AuctionNameErrorProvider;
    }
}