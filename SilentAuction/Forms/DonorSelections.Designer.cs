namespace SilentAuction.Forms
{
    partial class DonorSelections
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonorSelections));
            this.donorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.silentAuctionDataSet = new SilentAuction.SilentAuctionDataSet();
            this.donorsTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.DonorsTableAdapter();
            this.DonorsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PrintDonorsButton = new System.Windows.Forms.Button();
            this.CancelPrintDonorsButton = new System.Windows.Forms.Button();
            this.donorTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donorTypesTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.DonorTypesTableAdapter();
            this.requestFormatTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestFormatTypesTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.RequestFormatTypesTableAdapter();
            this.requestStatusTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestStatusTypesTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.RequestStatusTypesTableAdapter();
            this.auctionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auctionsTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.AuctionsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestFormatTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestStatusTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // donorsBindingSource
            // 
            this.donorsBindingSource.DataMember = "Donors";
            this.donorsBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // silentAuctionDataSet
            // 
            this.silentAuctionDataSet.DataSetName = "SilentAuctionDataSet";
            this.silentAuctionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // donorsTableAdapter
            // 
            this.donorsTableAdapter.ClearBeforeFill = true;
            // 
            // DonorsListBox
            // 
            this.DonorsListBox.DataSource = this.donorsBindingSource;
            this.DonorsListBox.DisplayMember = "Name";
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
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Donors to Print:";
            // 
            // PrintDonorsButton
            // 
            this.PrintDonorsButton.Location = new System.Drawing.Point(51, 227);
            this.PrintDonorsButton.Name = "PrintDonorsButton";
            this.PrintDonorsButton.Size = new System.Drawing.Size(75, 23);
            this.PrintDonorsButton.TabIndex = 2;
            this.PrintDonorsButton.Text = "Print";
            this.PrintDonorsButton.UseVisualStyleBackColor = true;
            this.PrintDonorsButton.Click += new System.EventHandler(this.PrintDonorsButtonClick);
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
            // auctionsBindingSource
            // 
            this.auctionsBindingSource.DataMember = "Auctions";
            this.auctionsBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // auctionsTableAdapter
            // 
            this.auctionsTableAdapter.ClearBeforeFill = true;
            // 
            // DonorSelections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelPrintDonorsButton;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.CancelPrintDonorsButton);
            this.Controls.Add(this.PrintDonorsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DonorsListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DonorSelections";
            this.Text = "DonorSelections";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DonorSelectionsFormClosing);
            this.Load += new System.EventHandler(this.DonorSelectionsLoad);
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestFormatTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestStatusTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource donorsBindingSource;
        private SilentAuctionDataSet silentAuctionDataSet;
        private SilentAuctionDataSetTableAdapters.DonorsTableAdapter donorsTableAdapter;
        private System.Windows.Forms.ListBox DonorsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PrintDonorsButton;
        private System.Windows.Forms.Button CancelPrintDonorsButton;
        private System.Windows.Forms.BindingSource donorTypesBindingSource;
        private SilentAuctionDataSetTableAdapters.DonorTypesTableAdapter donorTypesTableAdapter;
        private System.Windows.Forms.BindingSource requestFormatTypesBindingSource;
        private SilentAuctionDataSetTableAdapters.RequestFormatTypesTableAdapter requestFormatTypesTableAdapter;
        private System.Windows.Forms.BindingSource requestStatusTypesBindingSource;
        private SilentAuctionDataSetTableAdapters.RequestStatusTypesTableAdapter requestStatusTypesTableAdapter;
        private System.Windows.Forms.BindingSource auctionsBindingSource;
        private SilentAuctionDataSetTableAdapters.AuctionsTableAdapter auctionsTableAdapter;
    }
}