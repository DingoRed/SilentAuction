namespace SilentAuction.Forms
{
    partial class ViewAuctionsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AuctionsDataGridView = new System.Windows.Forms.DataGridView();
            this.auctionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.silentAuctionDataSet = new SilentAuction.SilentAuctionDataSet();
            this.auctionsTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.AuctionsTableAdapter();
            this.AuctionsNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuctionsDescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AuctionsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // AuctionsDataGridView
            // 
            this.AuctionsDataGridView.AllowUserToAddRows = false;
            this.AuctionsDataGridView.AllowUserToDeleteRows = false;
            this.AuctionsDataGridView.AutoGenerateColumns = false;
            this.AuctionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AuctionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AuctionsNameColumn,
            this.AuctionsDescriptionColumn,
            this.idDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.modifiedDateDataGridViewTextBoxColumn});
            this.AuctionsDataGridView.DataSource = this.auctionsBindingSource;
            this.AuctionsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuctionsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.AuctionsDataGridView.Name = "AuctionsDataGridView";
            this.AuctionsDataGridView.ReadOnly = true;
            this.AuctionsDataGridView.Size = new System.Drawing.Size(644, 288);
            this.AuctionsDataGridView.TabIndex = 0;
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
            // AuctionsNameColumn
            // 
            this.AuctionsNameColumn.DataPropertyName = "Name";
            this.AuctionsNameColumn.HeaderText = "Auction Name";
            this.AuctionsNameColumn.Name = "AuctionsNameColumn";
            this.AuctionsNameColumn.ReadOnly = true;
            this.AuctionsNameColumn.Width = 200;
            // 
            // AuctionsDescriptionColumn
            // 
            this.AuctionsDescriptionColumn.DataPropertyName = "Description";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AuctionsDescriptionColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.AuctionsDescriptionColumn.HeaderText = "Auction Description";
            this.AuctionsDescriptionColumn.Name = "AuctionsDescriptionColumn";
            this.AuctionsDescriptionColumn.ReadOnly = true;
            this.AuctionsDescriptionColumn.Width = 400;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            this.createDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.createDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // modifiedDateDataGridViewTextBoxColumn
            // 
            this.modifiedDateDataGridViewTextBoxColumn.DataPropertyName = "ModifiedDate";
            this.modifiedDateDataGridViewTextBoxColumn.HeaderText = "ModifiedDate";
            this.modifiedDateDataGridViewTextBoxColumn.Name = "modifiedDateDataGridViewTextBoxColumn";
            this.modifiedDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.modifiedDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // ViewAuctionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 288);
            this.Controls.Add(this.AuctionsDataGridView);
            this.Name = "ViewAuctionsForm";
            this.Text = "View Auctions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewAuctionsFormFormClosing);
            this.Load += new System.EventHandler(this.ViewAuctionsLoad);
            ((System.ComponentModel.ISupportInitialize)(this.AuctionsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AuctionsDataGridView;
        private SilentAuctionDataSet silentAuctionDataSet;
        private System.Windows.Forms.BindingSource auctionsBindingSource;
        private SilentAuctionDataSetTableAdapters.AuctionsTableAdapter auctionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuctionsNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuctionsDescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedDateDataGridViewTextBoxColumn;
    }
}