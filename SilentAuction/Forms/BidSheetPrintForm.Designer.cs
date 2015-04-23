namespace SilentAuction.Forms
{
    partial class BidSheetPrintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BidSheetPrintForm));
            this.ItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.silentAuctionDataSet = new SilentAuction.SilentAuctionDataSet();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CancelPrintButton = new System.Windows.Forms.Button();
            this.PrintBidSheetButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bidSheetsTextControl = new TXTextControl.TextControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.bidSheetsPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.itemsTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.ItemsTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auctionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auctionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemsDataGridView
            // 
            this.ItemsDataGridView.AllowUserToAddRows = false;
            this.ItemsDataGridView.AllowUserToDeleteRows = false;
            this.ItemsDataGridView.AutoGenerateColumns = false;
            this.ItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.itemTypeNameDataGridViewTextBoxColumn,
            this.donorTypeNameDataGridViewTextBoxColumn,
            this.donorIdDataGridViewTextBoxColumn,
            this.auctionIdDataGridViewTextBoxColumn,
            this.auctionNameDataGridViewTextBoxColumn,
            this.itemTypeIdDataGridViewTextBoxColumn,
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
            this.imageDataGridViewImageColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.modifiedDateDataGridViewTextBoxColumn});
            this.ItemsDataGridView.DataSource = this.itemsBindingSource;
            this.ItemsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ItemsDataGridView.Name = "ItemsDataGridView";
            this.ItemsDataGridView.RowHeadersVisible = false;
            this.ItemsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemsDataGridView.Size = new System.Drawing.Size(561, 258);
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
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(567, 344);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 2);
            this.panel2.Controls.Add(this.CancelPrintButton);
            this.panel2.Controls.Add(this.PrintBidSheetButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 307);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(561, 34);
            this.panel2.TabIndex = 0;
            // 
            // CancelPrintButton
            // 
            this.CancelPrintButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelPrintButton.Location = new System.Drawing.Point(295, 3);
            this.CancelPrintButton.Name = "CancelPrintButton";
            this.CancelPrintButton.Size = new System.Drawing.Size(75, 23);
            this.CancelPrintButton.TabIndex = 1;
            this.CancelPrintButton.Text = "Cancel";
            this.CancelPrintButton.UseVisualStyleBackColor = true;
            // 
            // PrintBidSheetButton
            // 
            this.PrintBidSheetButton.Location = new System.Drawing.Point(188, 4);
            this.PrintBidSheetButton.Name = "PrintBidSheetButton";
            this.PrintBidSheetButton.Size = new System.Drawing.Size(75, 23);
            this.PrintBidSheetButton.TabIndex = 0;
            this.PrintBidSheetButton.Text = "Print";
            this.PrintBidSheetButton.UseVisualStyleBackColor = true;
            this.PrintBidSheetButton.Click += new System.EventHandler(this.PrintBidSheetsButtonClick);
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.ItemsDataGridView);
            this.panel1.Controls.Add(this.bidSheetsTextControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 258);
            this.panel1.TabIndex = 1;
            // 
            // bidSheetsTextControl
            // 
            this.bidSheetsTextControl.Font = new System.Drawing.Font("Arial", 10F);
            this.bidSheetsTextControl.Location = new System.Drawing.Point(42, 40);
            this.bidSheetsTextControl.Name = "bidSheetsTextControl";
            this.bidSheetsTextControl.Size = new System.Drawing.Size(63, 48);
            this.bidSheetsTextControl.TabIndex = 1;
            this.bidSheetsTextControl.Text = "textControl1";
            // 
            // panel3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel3, 2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.progressBar1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 267);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(561, 34);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Printing Progress:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(98, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(463, 23);
            this.progressBar1.TabIndex = 0;
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
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 41;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Item Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 90;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DonorName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Donor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Qty";
            this.dataGridViewTextBoxColumn4.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 55;
            // 
            // itemTypeNameDataGridViewTextBoxColumn
            // 
            this.itemTypeNameDataGridViewTextBoxColumn.DataPropertyName = "ItemTypeName";
            this.itemTypeNameDataGridViewTextBoxColumn.HeaderText = "Item Type";
            this.itemTypeNameDataGridViewTextBoxColumn.Name = "itemTypeNameDataGridViewTextBoxColumn";
            this.itemTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
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
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            this.imageDataGridViewImageColumn.Visible = false;
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
            // BidSheetPrintForm
            // 
            this.AcceptButton = this.PrintBidSheetButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelPrintButton;
            this.ClientSize = new System.Drawing.Size(567, 344);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BidSheetPrintForm";
            this.Text = "Print Bid Sheet Items";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GenerateItemLabelsFileFormClosing);
            this.Load += new System.EventHandler(this.GenerateItemLabelsFileLoad);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ItemsDataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private SilentAuctionDataSet silentAuctionDataSet;
        private System.Windows.Forms.Button CancelPrintButton;
        private System.Windows.Forms.Button PrintBidSheetButton;
        private System.Drawing.Printing.PrintDocument bidSheetsPrintDocument;
        private System.Windows.Forms.Panel panel1;
        private TXTextControl.TextControl bidSheetsTextControl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private SilentAuctionDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auctionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auctionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemTypeIdDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedDateDataGridViewTextBoxColumn;
    }
}