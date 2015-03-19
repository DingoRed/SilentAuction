namespace SilentAuction.Forms
{
    partial class OpenAuctionForm
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
            this.AuctionsListLabel = new System.Windows.Forms.Label();
            this.AuctionComboBox = new System.Windows.Forms.ComboBox();
            this.auctionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.silentAuctionDataSet = new SilentAuction.SilentAuctionDataSet();
            this.auctionsTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.AuctionsTableAdapter();
            this.OpenButton = new System.Windows.Forms.Button();
            this.CancelOpenButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.auctionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // AuctionsListLabel
            // 
            this.AuctionsListLabel.AutoSize = true;
            this.AuctionsListLabel.Location = new System.Drawing.Point(12, 34);
            this.AuctionsListLabel.Name = "AuctionsListLabel";
            this.AuctionsListLabel.Size = new System.Drawing.Size(120, 13);
            this.AuctionsListLabel.TabIndex = 0;
            this.AuctionsListLabel.Text = "Select Auction to Open:";
            // 
            // AuctionComboBox
            // 
            this.AuctionComboBox.DataSource = this.auctionsBindingSource;
            this.AuctionComboBox.DisplayMember = "Name";
            this.AuctionComboBox.FormattingEnabled = true;
            this.AuctionComboBox.Location = new System.Drawing.Point(12, 50);
            this.AuctionComboBox.Name = "AuctionComboBox";
            this.AuctionComboBox.Size = new System.Drawing.Size(260, 21);
            this.AuctionComboBox.TabIndex = 1;
            this.AuctionComboBox.ValueMember = "Id";
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
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(46, 198);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(75, 23);
            this.OpenButton.TabIndex = 2;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButtonClick);
            // 
            // CancelOpenButton
            // 
            this.CancelOpenButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelOpenButton.Location = new System.Drawing.Point(152, 198);
            this.CancelOpenButton.Name = "CancelOpenButton";
            this.CancelOpenButton.Size = new System.Drawing.Size(75, 23);
            this.CancelOpenButton.TabIndex = 3;
            this.CancelOpenButton.Text = "Cancel";
            this.CancelOpenButton.UseVisualStyleBackColor = true;
            this.CancelOpenButton.Click += new System.EventHandler(this.CancelOpenButtonClick);
            // 
            // OpenAuctionForm
            // 
            this.AcceptButton = this.OpenButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelOpenButton;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.CancelOpenButton);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.AuctionComboBox);
            this.Controls.Add(this.AuctionsListLabel);
            this.Name = "OpenAuctionForm";
            this.Text = "Open Auction";
            this.Load += new System.EventHandler(this.OpenAuctionFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.auctionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AuctionsListLabel;
        private SilentAuctionDataSet silentAuctionDataSet;
        private System.Windows.Forms.BindingSource auctionsBindingSource;
        private SilentAuctionDataSetTableAdapters.AuctionsTableAdapter auctionsTableAdapter;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button CancelOpenButton;
        private System.Windows.Forms.ComboBox AuctionComboBox;
    }
}