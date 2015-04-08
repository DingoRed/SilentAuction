namespace SilentAuction.Forms
{
    partial class DocumentSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentSelection));
            this.label1 = new System.Windows.Forms.Label();
            this.DocumentsComboBox = new System.Windows.Forms.ComboBox();
            this.documentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.silentAuctionDataSet = new SilentAuction.SilentAuctionDataSet();
            this.documentsTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.DocumentsTableAdapter();
            this.SelectDocumentButton = new System.Windows.Forms.Button();
            this.CancelDocumentButton = new System.Windows.Forms.Button();
            this.auctionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auctionsTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.AuctionsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Document to Load";
            // 
            // DocumentsComboBox
            // 
            this.DocumentsComboBox.DataSource = this.documentsBindingSource;
            this.DocumentsComboBox.DisplayMember = "Name";
            this.DocumentsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DocumentsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DocumentsComboBox.FormattingEnabled = true;
            this.DocumentsComboBox.Location = new System.Drawing.Point(12, 25);
            this.DocumentsComboBox.Name = "DocumentsComboBox";
            this.DocumentsComboBox.Size = new System.Drawing.Size(300, 21);
            this.DocumentsComboBox.TabIndex = 1;
            this.DocumentsComboBox.ValueMember = "Id";
            // 
            // documentsBindingSource
            // 
            this.documentsBindingSource.DataMember = "Documents";
            this.documentsBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // silentAuctionDataSet
            // 
            this.silentAuctionDataSet.DataSetName = "SilentAuctionDataSet";
            this.silentAuctionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // documentsTableAdapter
            // 
            this.documentsTableAdapter.ClearBeforeFill = true;
            // 
            // SelectDocumentButton
            // 
            this.SelectDocumentButton.Location = new System.Drawing.Point(72, 77);
            this.SelectDocumentButton.Name = "SelectDocumentButton";
            this.SelectDocumentButton.Size = new System.Drawing.Size(75, 23);
            this.SelectDocumentButton.TabIndex = 2;
            this.SelectDocumentButton.Text = "Select";
            this.SelectDocumentButton.UseVisualStyleBackColor = true;
            this.SelectDocumentButton.Click += new System.EventHandler(this.SelectDocumentButtonClick);
            // 
            // CancelDocumentButton
            // 
            this.CancelDocumentButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelDocumentButton.Location = new System.Drawing.Point(179, 77);
            this.CancelDocumentButton.Name = "CancelDocumentButton";
            this.CancelDocumentButton.Size = new System.Drawing.Size(75, 23);
            this.CancelDocumentButton.TabIndex = 3;
            this.CancelDocumentButton.Text = "Cancel";
            this.CancelDocumentButton.UseVisualStyleBackColor = true;
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
            // DocumentSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelDocumentButton;
            this.ClientSize = new System.Drawing.Size(327, 134);
            this.Controls.Add(this.CancelDocumentButton);
            this.Controls.Add(this.SelectDocumentButton);
            this.Controls.Add(this.DocumentsComboBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DocumentSelection";
            this.Text = "Select Document";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DocumentSelectionFormClosing);
            this.Load += new System.EventHandler(this.DocumentSelectionLoad);
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DocumentsComboBox;
        private System.Windows.Forms.BindingSource documentsBindingSource;
        private SilentAuctionDataSet silentAuctionDataSet;
        private SilentAuctionDataSetTableAdapters.DocumentsTableAdapter documentsTableAdapter;
        private System.Windows.Forms.Button SelectDocumentButton;
        private System.Windows.Forms.Button CancelDocumentButton;
        private System.Windows.Forms.BindingSource auctionsBindingSource;
        private SilentAuctionDataSetTableAdapters.AuctionsTableAdapter auctionsTableAdapter;
    }
}