namespace SilentAuction.Forms
{
    partial class ReportShowAllItemsByDonorName
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportShowAllItemsByDonorName));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.donorsComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.donorItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.donationDeliveryTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.silentAuctionDataSet = new SilentAuction.SilentAuctionDataSet();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.ItemsTableAdapter();
            this.donorsTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.DonorsTableAdapter();
            this.donationDeliveryTypesTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.DonationDeliveryTypesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auctionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.itemTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donationDeliveryTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sellValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retailValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidMinValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidMaxValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidBuyItNowValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auctionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidIncrementTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidIncrementValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidNumberOfBidsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donorItemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationDeliveryTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(922, 435);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.donorsComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 34);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Donor:";
            // 
            // donorsComboBox
            // 
            this.donorsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.donorsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.donorsComboBox.FormattingEnabled = true;
            this.donorsComboBox.Location = new System.Drawing.Point(103, 5);
            this.donorsComboBox.Name = "donorsComboBox";
            this.donorsComboBox.Size = new System.Drawing.Size(227, 21);
            this.donorsComboBox.TabIndex = 0;
            this.donorsComboBox.SelectedIndexChanged += new System.EventHandler(this.DonorsComboBoxSelectedIndexChanged);
            // 
            // panel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 2);
            this.panel2.Controls.Add(this.donorItemsDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(916, 389);
            this.panel2.TabIndex = 1;
            // 
            // donorItemsDataGridView
            // 
            this.donorItemsDataGridView.AllowUserToAddRows = false;
            this.donorItemsDataGridView.AllowUserToDeleteRows = false;
            this.donorItemsDataGridView.AutoGenerateColumns = false;
            this.donorItemsDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.donorItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.donorItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.auctionNameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn,
            this.itemTypeNameDataGridViewTextBoxColumn,
            this.donationDeliveryTypeIdDataGridViewTextBoxColumn,
            this.sellValueDataGridViewTextBoxColumn,
            this.retailValueDataGridViewTextBoxColumn,
            this.bidMinValueDataGridViewTextBoxColumn,
            this.bidMaxValueDataGridViewTextBoxColumn,
            this.bidBuyItNowValueDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.donorTypeNameDataGridViewTextBoxColumn,
            this.donorIdDataGridViewTextBoxColumn,
            this.donorNameDataGridViewTextBoxColumn,
            this.auctionIdDataGridViewTextBoxColumn,
            this.itemTypeIdDataGridViewTextBoxColumn,
            this.bidIncrementTypeIdDataGridViewTextBoxColumn,
            this.bidIncrementValueDataGridViewTextBoxColumn,
            this.bidNumberOfBidsDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.modifiedDateDataGridViewTextBoxColumn});
            this.donorItemsDataGridView.DataSource = this.itemsBindingSource;
            this.donorItemsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.donorItemsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.donorItemsDataGridView.Name = "donorItemsDataGridView";
            this.donorItemsDataGridView.ReadOnly = true;
            this.donorItemsDataGridView.Size = new System.Drawing.Size(916, 389);
            this.donorItemsDataGridView.TabIndex = 0;
            // 
            // donationDeliveryTypesBindingSource
            // 
            this.donationDeliveryTypesBindingSource.DataMember = "DonationDeliveryTypes";
            this.donationDeliveryTypesBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // silentAuctionDataSet
            // 
            this.silentAuctionDataSet.DataSetName = "SilentAuctionDataSet";
            this.silentAuctionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // donorsBindingSource
            // 
            this.donorsBindingSource.DataMember = "Donors";
            this.donorsBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // donorsTableAdapter
            // 
            this.donorsTableAdapter.ClearBeforeFill = true;
            // 
            // donationDeliveryTypesTableAdapter
            // 
            this.donationDeliveryTypesTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 30;
            // 
            // auctionNameDataGridViewTextBoxColumn
            // 
            this.auctionNameDataGridViewTextBoxColumn.DataPropertyName = "AuctionName";
            this.auctionNameDataGridViewTextBoxColumn.HeaderText = "Auction";
            this.auctionNameDataGridViewTextBoxColumn.Name = "auctionNameDataGridViewTextBoxColumn";
            this.auctionNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Item Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.qtyDataGridViewTextBoxColumn.Width = 30;
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            this.imageDataGridViewImageColumn.ReadOnly = true;
            // 
            // itemTypeNameDataGridViewTextBoxColumn
            // 
            this.itemTypeNameDataGridViewTextBoxColumn.DataPropertyName = "ItemTypeName";
            this.itemTypeNameDataGridViewTextBoxColumn.HeaderText = "Item Type";
            this.itemTypeNameDataGridViewTextBoxColumn.Name = "itemTypeNameDataGridViewTextBoxColumn";
            this.itemTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // donationDeliveryTypeIdDataGridViewTextBoxColumn
            // 
            this.donationDeliveryTypeIdDataGridViewTextBoxColumn.DataPropertyName = "DonationDeliveryTypeId";
            this.donationDeliveryTypeIdDataGridViewTextBoxColumn.DataSource = this.donationDeliveryTypesBindingSource;
            this.donationDeliveryTypeIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.donationDeliveryTypeIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.donationDeliveryTypeIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.donationDeliveryTypeIdDataGridViewTextBoxColumn.HeaderText = "Delivery Via";
            this.donationDeliveryTypeIdDataGridViewTextBoxColumn.Name = "donationDeliveryTypeIdDataGridViewTextBoxColumn";
            this.donationDeliveryTypeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.donationDeliveryTypeIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.donationDeliveryTypeIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.donationDeliveryTypeIdDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // sellValueDataGridViewTextBoxColumn
            // 
            this.sellValueDataGridViewTextBoxColumn.DataPropertyName = "SellValue";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            this.sellValueDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.sellValueDataGridViewTextBoxColumn.HeaderText = "Sell Value";
            this.sellValueDataGridViewTextBoxColumn.Name = "sellValueDataGridViewTextBoxColumn";
            this.sellValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // retailValueDataGridViewTextBoxColumn
            // 
            this.retailValueDataGridViewTextBoxColumn.DataPropertyName = "RetailValue";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            this.retailValueDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.retailValueDataGridViewTextBoxColumn.HeaderText = "Retail Value";
            this.retailValueDataGridViewTextBoxColumn.Name = "retailValueDataGridViewTextBoxColumn";
            this.retailValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bidMinValueDataGridViewTextBoxColumn
            // 
            this.bidMinValueDataGridViewTextBoxColumn.DataPropertyName = "BidMinValue";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            this.bidMinValueDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.bidMinValueDataGridViewTextBoxColumn.HeaderText = "Min Value";
            this.bidMinValueDataGridViewTextBoxColumn.Name = "bidMinValueDataGridViewTextBoxColumn";
            this.bidMinValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bidMaxValueDataGridViewTextBoxColumn
            // 
            this.bidMaxValueDataGridViewTextBoxColumn.DataPropertyName = "BidMaxValue";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C2";
            this.bidMaxValueDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.bidMaxValueDataGridViewTextBoxColumn.HeaderText = "Max Value";
            this.bidMaxValueDataGridViewTextBoxColumn.Name = "bidMaxValueDataGridViewTextBoxColumn";
            this.bidMaxValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bidBuyItNowValueDataGridViewTextBoxColumn
            // 
            this.bidBuyItNowValueDataGridViewTextBoxColumn.DataPropertyName = "BidBuyItNowValue";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "C2";
            this.bidBuyItNowValueDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.bidBuyItNowValueDataGridViewTextBoxColumn.HeaderText = "Buy It Now Value";
            this.bidBuyItNowValueDataGridViewTextBoxColumn.Name = "bidBuyItNowValueDataGridViewTextBoxColumn";
            this.bidBuyItNowValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.bidBuyItNowValueDataGridViewTextBoxColumn.Width = 150;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // donorTypeNameDataGridViewTextBoxColumn
            // 
            this.donorTypeNameDataGridViewTextBoxColumn.DataPropertyName = "DonorTypeName";
            this.donorTypeNameDataGridViewTextBoxColumn.HeaderText = "Donor Type";
            this.donorTypeNameDataGridViewTextBoxColumn.Name = "donorTypeNameDataGridViewTextBoxColumn";
            this.donorTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.donorTypeNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // donorIdDataGridViewTextBoxColumn
            // 
            this.donorIdDataGridViewTextBoxColumn.DataPropertyName = "DonorId";
            this.donorIdDataGridViewTextBoxColumn.HeaderText = "DonorId";
            this.donorIdDataGridViewTextBoxColumn.Name = "donorIdDataGridViewTextBoxColumn";
            this.donorIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.donorIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // donorNameDataGridViewTextBoxColumn
            // 
            this.donorNameDataGridViewTextBoxColumn.DataPropertyName = "DonorName";
            this.donorNameDataGridViewTextBoxColumn.HeaderText = "DonorName";
            this.donorNameDataGridViewTextBoxColumn.Name = "donorNameDataGridViewTextBoxColumn";
            this.donorNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.donorNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // auctionIdDataGridViewTextBoxColumn
            // 
            this.auctionIdDataGridViewTextBoxColumn.DataPropertyName = "AuctionId";
            this.auctionIdDataGridViewTextBoxColumn.HeaderText = "AuctionId";
            this.auctionIdDataGridViewTextBoxColumn.Name = "auctionIdDataGridViewTextBoxColumn";
            this.auctionIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.auctionIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // itemTypeIdDataGridViewTextBoxColumn
            // 
            this.itemTypeIdDataGridViewTextBoxColumn.DataPropertyName = "ItemTypeId";
            this.itemTypeIdDataGridViewTextBoxColumn.HeaderText = "ItemTypeId";
            this.itemTypeIdDataGridViewTextBoxColumn.Name = "itemTypeIdDataGridViewTextBoxColumn";
            this.itemTypeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemTypeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // bidIncrementTypeIdDataGridViewTextBoxColumn
            // 
            this.bidIncrementTypeIdDataGridViewTextBoxColumn.DataPropertyName = "BidIncrementTypeId";
            this.bidIncrementTypeIdDataGridViewTextBoxColumn.HeaderText = "BidIncrementTypeId";
            this.bidIncrementTypeIdDataGridViewTextBoxColumn.Name = "bidIncrementTypeIdDataGridViewTextBoxColumn";
            this.bidIncrementTypeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.bidIncrementTypeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // bidIncrementValueDataGridViewTextBoxColumn
            // 
            this.bidIncrementValueDataGridViewTextBoxColumn.DataPropertyName = "BidIncrementValue";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "C2";
            this.bidIncrementValueDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.bidIncrementValueDataGridViewTextBoxColumn.HeaderText = "Incr Value";
            this.bidIncrementValueDataGridViewTextBoxColumn.Name = "bidIncrementValueDataGridViewTextBoxColumn";
            this.bidIncrementValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.bidIncrementValueDataGridViewTextBoxColumn.Visible = false;
            // 
            // bidNumberOfBidsDataGridViewTextBoxColumn
            // 
            this.bidNumberOfBidsDataGridViewTextBoxColumn.DataPropertyName = "BidNumberOfBids";
            this.bidNumberOfBidsDataGridViewTextBoxColumn.HeaderText = "# of Bids";
            this.bidNumberOfBidsDataGridViewTextBoxColumn.Name = "bidNumberOfBidsDataGridViewTextBoxColumn";
            this.bidNumberOfBidsDataGridViewTextBoxColumn.ReadOnly = true;
            this.bidNumberOfBidsDataGridViewTextBoxColumn.Visible = false;
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
            // ReportShowAllItemsByDonorName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 435);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportShowAllItemsByDonorName";
            this.Text = "Search By Donor Name";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShowAllItemsByDonorNameFormClosing);
            this.Load += new System.EventHandler(this.SearchByDonorNameLoad);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.donorItemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationDeliveryTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox donorsComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView donorItemsDataGridView;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private SilentAuctionDataSet silentAuctionDataSet;
        private SilentAuctionDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.BindingSource donorsBindingSource;
        private SilentAuctionDataSetTableAdapters.DonorsTableAdapter donorsTableAdapter;
        private System.Windows.Forms.BindingSource donationDeliveryTypesBindingSource;
        private SilentAuctionDataSetTableAdapters.DonationDeliveryTypesTableAdapter donationDeliveryTypesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auctionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn donationDeliveryTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn retailValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidMinValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidMaxValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidBuyItNowValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auctionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidIncrementTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidIncrementValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidNumberOfBidsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedDateDataGridViewTextBoxColumn;
    }
}