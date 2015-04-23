namespace SilentAuction.Forms
{
    partial class GenerateItemLabelsFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateItemLabelsFile));
            this.ItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.silentAuctionDataSet = new SilentAuction.SilentAuctionDataSet();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CancelMakeFileButton = new System.Windows.Forms.Button();
            this.MakeFileButton = new System.Windows.Forms.Button();
            this.itemsTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.ItemsTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.donorTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auctionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auctionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donationDeliveryTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retailValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidIncrementTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidMinValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidMaxValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidIncrementValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidBuyItNowValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidNumberOfBidsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemsDataGridView
            // 
            this.ItemsDataGridView.AllowUserToAddRows = false;
            this.ItemsDataGridView.AllowUserToDeleteRows = false;
            this.ItemsDataGridView.AutoGenerateColumns = false;
            this.ItemsDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.imageDataGridViewImageColumn,
            this.donorTypeNameDataGridViewTextBoxColumn,
            this.donorIdDataGridViewTextBoxColumn,
            this.auctionIdDataGridViewTextBoxColumn,
            this.auctionNameDataGridViewTextBoxColumn,
            this.itemTypeIdDataGridViewTextBoxColumn,
            this.itemTypeNameDataGridViewTextBoxColumn,
            this.donationDeliveryTypeIdDataGridViewTextBoxColumn,
            this.sellValueDataGridViewTextBoxColumn,
            this.retailValueDataGridViewTextBoxColumn,
            this.bidIncrementTypeIdDataGridViewTextBoxColumn,
            this.bidMinValueDataGridViewTextBoxColumn,
            this.bidMaxValueDataGridViewTextBoxColumn,
            this.bidIncrementValueDataGridViewTextBoxColumn,
            this.bidBuyItNowValueDataGridViewTextBoxColumn,
            this.bidNumberOfBidsDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.modifiedDateDataGridViewTextBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.ItemsDataGridView, 2);
            this.ItemsDataGridView.DataSource = this.itemsBindingSource;
            this.ItemsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.ItemsDataGridView.Name = "ItemsDataGridView";
            this.ItemsDataGridView.RowHeadersVisible = false;
            this.ItemsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemsDataGridView.Size = new System.Drawing.Size(563, 215);
            this.ItemsDataGridView.TabIndex = 0;
            this.ItemsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsDataGridViewCellClick);
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // silentAuctionDataSet
            // 
            this.silentAuctionDataSet.DataSetName = "SilentAuctionDataSet";
            this.silentAuctionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ItemsDataGridView, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(569, 261);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 2);
            this.panel2.Controls.Add(this.CancelMakeFileButton);
            this.panel2.Controls.Add(this.MakeFileButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(563, 34);
            this.panel2.TabIndex = 0;
            // 
            // CancelMakeFileButton
            // 
            this.CancelMakeFileButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelMakeFileButton.Location = new System.Drawing.Point(295, 3);
            this.CancelMakeFileButton.Name = "CancelMakeFileButton";
            this.CancelMakeFileButton.Size = new System.Drawing.Size(75, 23);
            this.CancelMakeFileButton.TabIndex = 1;
            this.CancelMakeFileButton.Text = "Cancel";
            this.CancelMakeFileButton.UseVisualStyleBackColor = true;
            // 
            // MakeFileButton
            // 
            this.MakeFileButton.Location = new System.Drawing.Point(188, 4);
            this.MakeFileButton.Name = "MakeFileButton";
            this.MakeFileButton.Size = new System.Drawing.Size(75, 23);
            this.MakeFileButton.TabIndex = 0;
            this.MakeFileButton.Text = "Make File";
            this.MakeFileButton.UseVisualStyleBackColor = true;
            this.MakeFileButton.Click += new System.EventHandler(this.MakeFileButtonClick);
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DonorName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Donor Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Item Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 90;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Qty";
            this.dataGridViewTextBoxColumn4.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 55;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Item Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            // 
            // donorTypeNameDataGridViewTextBoxColumn
            // 
            this.donorTypeNameDataGridViewTextBoxColumn.DataPropertyName = "DonorTypeName";
            this.donorTypeNameDataGridViewTextBoxColumn.HeaderText = "DonorTypeName";
            this.donorTypeNameDataGridViewTextBoxColumn.Name = "donorTypeNameDataGridViewTextBoxColumn";
            this.donorTypeNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // donorIdDataGridViewTextBoxColumn
            // 
            this.donorIdDataGridViewTextBoxColumn.DataPropertyName = "DonorId";
            this.donorIdDataGridViewTextBoxColumn.HeaderText = "DonorId";
            this.donorIdDataGridViewTextBoxColumn.Name = "donorIdDataGridViewTextBoxColumn";
            this.donorIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // auctionIdDataGridViewTextBoxColumn
            // 
            this.auctionIdDataGridViewTextBoxColumn.DataPropertyName = "AuctionId";
            this.auctionIdDataGridViewTextBoxColumn.HeaderText = "AuctionId";
            this.auctionIdDataGridViewTextBoxColumn.Name = "auctionIdDataGridViewTextBoxColumn";
            this.auctionIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // auctionNameDataGridViewTextBoxColumn
            // 
            this.auctionNameDataGridViewTextBoxColumn.DataPropertyName = "AuctionName";
            this.auctionNameDataGridViewTextBoxColumn.HeaderText = "AuctionName";
            this.auctionNameDataGridViewTextBoxColumn.Name = "auctionNameDataGridViewTextBoxColumn";
            this.auctionNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // itemTypeIdDataGridViewTextBoxColumn
            // 
            this.itemTypeIdDataGridViewTextBoxColumn.DataPropertyName = "ItemTypeId";
            this.itemTypeIdDataGridViewTextBoxColumn.HeaderText = "ItemTypeId";
            this.itemTypeIdDataGridViewTextBoxColumn.Name = "itemTypeIdDataGridViewTextBoxColumn";
            this.itemTypeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // itemTypeNameDataGridViewTextBoxColumn
            // 
            this.itemTypeNameDataGridViewTextBoxColumn.DataPropertyName = "ItemTypeName";
            this.itemTypeNameDataGridViewTextBoxColumn.HeaderText = "ItemTypeName";
            this.itemTypeNameDataGridViewTextBoxColumn.Name = "itemTypeNameDataGridViewTextBoxColumn";
            this.itemTypeNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // donationDeliveryTypeIdDataGridViewTextBoxColumn
            // 
            this.donationDeliveryTypeIdDataGridViewTextBoxColumn.DataPropertyName = "DonationDeliveryTypeId";
            this.donationDeliveryTypeIdDataGridViewTextBoxColumn.HeaderText = "DonationDeliveryTypeId";
            this.donationDeliveryTypeIdDataGridViewTextBoxColumn.Name = "donationDeliveryTypeIdDataGridViewTextBoxColumn";
            this.donationDeliveryTypeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // sellValueDataGridViewTextBoxColumn
            // 
            this.sellValueDataGridViewTextBoxColumn.DataPropertyName = "SellValue";
            this.sellValueDataGridViewTextBoxColumn.HeaderText = "SellValue";
            this.sellValueDataGridViewTextBoxColumn.Name = "sellValueDataGridViewTextBoxColumn";
            this.sellValueDataGridViewTextBoxColumn.Visible = false;
            // 
            // retailValueDataGridViewTextBoxColumn
            // 
            this.retailValueDataGridViewTextBoxColumn.DataPropertyName = "RetailValue";
            this.retailValueDataGridViewTextBoxColumn.HeaderText = "RetailValue";
            this.retailValueDataGridViewTextBoxColumn.Name = "retailValueDataGridViewTextBoxColumn";
            this.retailValueDataGridViewTextBoxColumn.Visible = false;
            // 
            // bidIncrementTypeIdDataGridViewTextBoxColumn
            // 
            this.bidIncrementTypeIdDataGridViewTextBoxColumn.DataPropertyName = "BidIncrementTypeId";
            this.bidIncrementTypeIdDataGridViewTextBoxColumn.HeaderText = "BidIncrementTypeId";
            this.bidIncrementTypeIdDataGridViewTextBoxColumn.Name = "bidIncrementTypeIdDataGridViewTextBoxColumn";
            this.bidIncrementTypeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // bidMinValueDataGridViewTextBoxColumn
            // 
            this.bidMinValueDataGridViewTextBoxColumn.DataPropertyName = "BidMinValue";
            this.bidMinValueDataGridViewTextBoxColumn.HeaderText = "BidMinValue";
            this.bidMinValueDataGridViewTextBoxColumn.Name = "bidMinValueDataGridViewTextBoxColumn";
            this.bidMinValueDataGridViewTextBoxColumn.Visible = false;
            // 
            // bidMaxValueDataGridViewTextBoxColumn
            // 
            this.bidMaxValueDataGridViewTextBoxColumn.DataPropertyName = "BidMaxValue";
            this.bidMaxValueDataGridViewTextBoxColumn.HeaderText = "BidMaxValue";
            this.bidMaxValueDataGridViewTextBoxColumn.Name = "bidMaxValueDataGridViewTextBoxColumn";
            this.bidMaxValueDataGridViewTextBoxColumn.Visible = false;
            // 
            // bidIncrementValueDataGridViewTextBoxColumn
            // 
            this.bidIncrementValueDataGridViewTextBoxColumn.DataPropertyName = "BidIncrementValue";
            this.bidIncrementValueDataGridViewTextBoxColumn.HeaderText = "BidIncrementValue";
            this.bidIncrementValueDataGridViewTextBoxColumn.Name = "bidIncrementValueDataGridViewTextBoxColumn";
            this.bidIncrementValueDataGridViewTextBoxColumn.Visible = false;
            // 
            // bidBuyItNowValueDataGridViewTextBoxColumn
            // 
            this.bidBuyItNowValueDataGridViewTextBoxColumn.DataPropertyName = "BidBuyItNowValue";
            this.bidBuyItNowValueDataGridViewTextBoxColumn.HeaderText = "BidBuyItNowValue";
            this.bidBuyItNowValueDataGridViewTextBoxColumn.Name = "bidBuyItNowValueDataGridViewTextBoxColumn";
            this.bidBuyItNowValueDataGridViewTextBoxColumn.Visible = false;
            // 
            // bidNumberOfBidsDataGridViewTextBoxColumn
            // 
            this.bidNumberOfBidsDataGridViewTextBoxColumn.DataPropertyName = "BidNumberOfBids";
            this.bidNumberOfBidsDataGridViewTextBoxColumn.HeaderText = "BidNumberOfBids";
            this.bidNumberOfBidsDataGridViewTextBoxColumn.Name = "bidNumberOfBidsDataGridViewTextBoxColumn";
            this.bidNumberOfBidsDataGridViewTextBoxColumn.Visible = false;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.Visible = false;
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            this.createDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // modifiedDateDataGridViewTextBoxColumn
            // 
            this.modifiedDateDataGridViewTextBoxColumn.DataPropertyName = "ModifiedDate";
            this.modifiedDateDataGridViewTextBoxColumn.HeaderText = "ModifiedDate";
            this.modifiedDateDataGridViewTextBoxColumn.Name = "modifiedDateDataGridViewTextBoxColumn";
            this.modifiedDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // GenerateItemLabelsFile
            // 
            this.AcceptButton = this.MakeFileButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelMakeFileButton;
            this.ClientSize = new System.Drawing.Size(569, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GenerateItemLabelsFile";
            this.Text = "Select Items to Include";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GenerateItemLabelsFileFormClosing);
            this.Load += new System.EventHandler(this.GenerateItemLabelsFileLoad);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ItemsDataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private SilentAuctionDataSet silentAuctionDataSet;
        private System.Windows.Forms.Button CancelMakeFileButton;
        private System.Windows.Forms.Button MakeFileButton;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private SilentAuctionDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auctionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auctionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donationDeliveryTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn retailValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidIncrementTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidMinValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidMaxValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidIncrementValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidBuyItNowValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidNumberOfBidsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedDateDataGridViewTextBoxColumn;
    }
}