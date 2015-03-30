namespace SilentAuction.Forms
{
    partial class ShowAllItemsByDonorName
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.donorsComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.donorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.silentAuctionDataSet = new SilentAuction.SilentAuctionDataSet();
            this.donorsTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.DonorsTableAdapter();
            this.donorTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donorTypesTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.DonorTypesTableAdapter();
            this.requestFormatTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestFormatTypesTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.RequestFormatTypesTableAdapter();
            this.requestStatusTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestStatusTypesTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.RequestStatusTypesTableAdapter();
            this.auctionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auctionsTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.AuctionsTableAdapter();
            this.donorItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.ItemsTableAdapter();
            this.itemTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemTypesTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.ItemTypesTableAdapter();
            this.donationDeliveryTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donationDeliveryTypesTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.DonationDeliveryTypesTableAdapter();
            this.bidIncrementTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bidIncrementTypesTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.BidIncrementTypesTableAdapter();
            this.auctionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.donationDeliveryTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.retailValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidBuyItNowValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidIncrementTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bidMinValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidMaxValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidIncrementValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidNumberOfBidsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestFormatTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestStatusTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorItemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationDeliveryTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bidIncrementTypesBindingSource)).BeginInit();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.663189F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.33681F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(922, 671);
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
            this.panel1.Size = new System.Drawing.Size(916, 31);
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
            this.panel2.Location = new System.Drawing.Point(3, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(916, 628);
            this.panel2.TabIndex = 1;
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
            // donorItemsDataGridView
            // 
            this.donorItemsDataGridView.AllowUserToAddRows = false;
            this.donorItemsDataGridView.AllowUserToDeleteRows = false;
            this.donorItemsDataGridView.AutoGenerateColumns = false;
            this.donorItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.donorItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.auctionIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.itemTypeIdDataGridViewTextBoxColumn,
            this.donationDeliveryTypeIdDataGridViewTextBoxColumn,
            this.retailValueDataGridViewTextBoxColumn,
            this.bidBuyItNowValueDataGridViewTextBoxColumn,
            this.bidIncrementTypeIdDataGridViewTextBoxColumn,
            this.bidMinValueDataGridViewTextBoxColumn,
            this.bidMaxValueDataGridViewTextBoxColumn,
            this.bidIncrementValueDataGridViewTextBoxColumn,
            this.bidNumberOfBidsDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.donorIdDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.modifiedDateDataGridViewTextBoxColumn});
            this.donorItemsDataGridView.DataSource = this.itemsBindingSource;
            this.donorItemsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.donorItemsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.donorItemsDataGridView.Name = "donorItemsDataGridView";
            this.donorItemsDataGridView.ReadOnly = true;
            this.donorItemsDataGridView.Size = new System.Drawing.Size(916, 628);
            this.donorItemsDataGridView.TabIndex = 0;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // itemTypesBindingSource
            // 
            this.itemTypesBindingSource.DataMember = "ItemTypes";
            this.itemTypesBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // itemTypesTableAdapter
            // 
            this.itemTypesTableAdapter.ClearBeforeFill = true;
            // 
            // donationDeliveryTypesBindingSource
            // 
            this.donationDeliveryTypesBindingSource.DataMember = "DonationDeliveryTypes";
            this.donationDeliveryTypesBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // donationDeliveryTypesTableAdapter
            // 
            this.donationDeliveryTypesTableAdapter.ClearBeforeFill = true;
            // 
            // bidIncrementTypesBindingSource
            // 
            this.bidIncrementTypesBindingSource.DataMember = "BidIncrementTypes";
            this.bidIncrementTypesBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // bidIncrementTypesTableAdapter
            // 
            this.bidIncrementTypesTableAdapter.ClearBeforeFill = true;
            // 
            // auctionIdDataGridViewTextBoxColumn
            // 
            this.auctionIdDataGridViewTextBoxColumn.DataPropertyName = "AuctionId";
            this.auctionIdDataGridViewTextBoxColumn.DataSource = this.auctionsBindingSource;
            this.auctionIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.auctionIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.auctionIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.auctionIdDataGridViewTextBoxColumn.HeaderText = "Auction";
            this.auctionIdDataGridViewTextBoxColumn.Name = "auctionIdDataGridViewTextBoxColumn";
            this.auctionIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.auctionIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.auctionIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.auctionIdDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Item Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 90;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.qtyDataGridViewTextBoxColumn.Width = 55;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Item Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 120;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            this.notesDataGridViewTextBoxColumn.Width = 60;
            // 
            // itemTypeIdDataGridViewTextBoxColumn
            // 
            this.itemTypeIdDataGridViewTextBoxColumn.DataPropertyName = "ItemTypeId";
            this.itemTypeIdDataGridViewTextBoxColumn.DataSource = this.itemTypesBindingSource;
            this.itemTypeIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.itemTypeIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.itemTypeIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemTypeIdDataGridViewTextBoxColumn.HeaderText = "Item Type";
            this.itemTypeIdDataGridViewTextBoxColumn.Name = "itemTypeIdDataGridViewTextBoxColumn";
            this.itemTypeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemTypeIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemTypeIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.itemTypeIdDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // donationDeliveryTypeIdDataGridViewTextBoxColumn
            // 
            this.donationDeliveryTypeIdDataGridViewTextBoxColumn.DataPropertyName = "DonationDeliveryTypeId";
            this.donationDeliveryTypeIdDataGridViewTextBoxColumn.DataSource = this.donationDeliveryTypesBindingSource;
            this.donationDeliveryTypeIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.donationDeliveryTypeIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.donationDeliveryTypeIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.donationDeliveryTypeIdDataGridViewTextBoxColumn.HeaderText = "Delivery Method";
            this.donationDeliveryTypeIdDataGridViewTextBoxColumn.Name = "donationDeliveryTypeIdDataGridViewTextBoxColumn";
            this.donationDeliveryTypeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.donationDeliveryTypeIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.donationDeliveryTypeIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.donationDeliveryTypeIdDataGridViewTextBoxColumn.ValueMember = "Id";
            this.donationDeliveryTypeIdDataGridViewTextBoxColumn.Width = 120;
            // 
            // retailValueDataGridViewTextBoxColumn
            // 
            this.retailValueDataGridViewTextBoxColumn.DataPropertyName = "RetailValue";
            this.retailValueDataGridViewTextBoxColumn.HeaderText = "Retail Value";
            this.retailValueDataGridViewTextBoxColumn.Name = "retailValueDataGridViewTextBoxColumn";
            this.retailValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.retailValueDataGridViewTextBoxColumn.Width = 90;
            // 
            // bidBuyItNowValueDataGridViewTextBoxColumn
            // 
            this.bidBuyItNowValueDataGridViewTextBoxColumn.DataPropertyName = "BidBuyItNowValue";
            this.bidBuyItNowValueDataGridViewTextBoxColumn.HeaderText = "Buy It Now Amount";
            this.bidBuyItNowValueDataGridViewTextBoxColumn.Name = "bidBuyItNowValueDataGridViewTextBoxColumn";
            this.bidBuyItNowValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.bidBuyItNowValueDataGridViewTextBoxColumn.Width = 140;
            // 
            // bidIncrementTypeIdDataGridViewTextBoxColumn
            // 
            this.bidIncrementTypeIdDataGridViewTextBoxColumn.DataPropertyName = "BidIncrementTypeId";
            this.bidIncrementTypeIdDataGridViewTextBoxColumn.DataSource = this.bidIncrementTypesBindingSource;
            this.bidIncrementTypeIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.bidIncrementTypeIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.bidIncrementTypeIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bidIncrementTypeIdDataGridViewTextBoxColumn.HeaderText = "Bid Incr Type";
            this.bidIncrementTypeIdDataGridViewTextBoxColumn.Name = "bidIncrementTypeIdDataGridViewTextBoxColumn";
            this.bidIncrementTypeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.bidIncrementTypeIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bidIncrementTypeIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.bidIncrementTypeIdDataGridViewTextBoxColumn.ValueMember = "Id";
            this.bidIncrementTypeIdDataGridViewTextBoxColumn.Width = 110;
            // 
            // bidMinValueDataGridViewTextBoxColumn
            // 
            this.bidMinValueDataGridViewTextBoxColumn.DataPropertyName = "BidMinValue";
            this.bidMinValueDataGridViewTextBoxColumn.HeaderText = "Minimum Bid";
            this.bidMinValueDataGridViewTextBoxColumn.Name = "bidMinValueDataGridViewTextBoxColumn";
            this.bidMinValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.bidMinValueDataGridViewTextBoxColumn.Width = 95;
            // 
            // bidMaxValueDataGridViewTextBoxColumn
            // 
            this.bidMaxValueDataGridViewTextBoxColumn.DataPropertyName = "BidMaxValue";
            this.bidMaxValueDataGridViewTextBoxColumn.HeaderText = "Maximum Bid";
            this.bidMaxValueDataGridViewTextBoxColumn.Name = "bidMaxValueDataGridViewTextBoxColumn";
            this.bidMaxValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.bidMaxValueDataGridViewTextBoxColumn.Width = 95;
            // 
            // bidIncrementValueDataGridViewTextBoxColumn
            // 
            this.bidIncrementValueDataGridViewTextBoxColumn.DataPropertyName = "BidIncrementValue";
            this.bidIncrementValueDataGridViewTextBoxColumn.HeaderText = "Bid Incr";
            this.bidIncrementValueDataGridViewTextBoxColumn.Name = "bidIncrementValueDataGridViewTextBoxColumn";
            this.bidIncrementValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.bidIncrementValueDataGridViewTextBoxColumn.Width = 70;
            // 
            // bidNumberOfBidsDataGridViewTextBoxColumn
            // 
            this.bidNumberOfBidsDataGridViewTextBoxColumn.DataPropertyName = "BidNumberOfBids";
            this.bidNumberOfBidsDataGridViewTextBoxColumn.HeaderText = "# of Bids";
            this.bidNumberOfBidsDataGridViewTextBoxColumn.Name = "bidNumberOfBidsDataGridViewTextBoxColumn";
            this.bidNumberOfBidsDataGridViewTextBoxColumn.ReadOnly = true;
            this.bidNumberOfBidsDataGridViewTextBoxColumn.Width = 75;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // donorIdDataGridViewTextBoxColumn
            // 
            this.donorIdDataGridViewTextBoxColumn.DataPropertyName = "DonorId";
            this.donorIdDataGridViewTextBoxColumn.HeaderText = "DonorId";
            this.donorIdDataGridViewTextBoxColumn.Name = "donorIdDataGridViewTextBoxColumn";
            this.donorIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.donorIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            this.createDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modifiedDateDataGridViewTextBoxColumn
            // 
            this.modifiedDateDataGridViewTextBoxColumn.DataPropertyName = "ModifiedDate";
            this.modifiedDateDataGridViewTextBoxColumn.HeaderText = "ModifiedDate";
            this.modifiedDateDataGridViewTextBoxColumn.Name = "modifiedDateDataGridViewTextBoxColumn";
            this.modifiedDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SearchByDonorName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 671);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SearchByDonorName";
            this.Text = "SearchByDonorName";
            this.Load += new System.EventHandler(this.SearchByDonorNameLoad);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestFormatTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestStatusTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorItemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationDeliveryTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bidIncrementTypesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox donorsComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource donorsBindingSource;
        private SilentAuctionDataSet silentAuctionDataSet;
        private SilentAuctionDataSetTableAdapters.DonorsTableAdapter donorsTableAdapter;
        private System.Windows.Forms.BindingSource donorTypesBindingSource;
        private SilentAuctionDataSetTableAdapters.DonorTypesTableAdapter donorTypesTableAdapter;
        private System.Windows.Forms.BindingSource requestFormatTypesBindingSource;
        private SilentAuctionDataSetTableAdapters.RequestFormatTypesTableAdapter requestFormatTypesTableAdapter;
        private System.Windows.Forms.BindingSource requestStatusTypesBindingSource;
        private SilentAuctionDataSetTableAdapters.RequestStatusTypesTableAdapter requestStatusTypesTableAdapter;
        private System.Windows.Forms.BindingSource auctionsBindingSource;
        private SilentAuctionDataSetTableAdapters.AuctionsTableAdapter auctionsTableAdapter;
        private System.Windows.Forms.DataGridView donorItemsDataGridView;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private SilentAuctionDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.BindingSource itemTypesBindingSource;
        private SilentAuctionDataSetTableAdapters.ItemTypesTableAdapter itemTypesTableAdapter;
        private System.Windows.Forms.BindingSource donationDeliveryTypesBindingSource;
        private SilentAuctionDataSetTableAdapters.DonationDeliveryTypesTableAdapter donationDeliveryTypesTableAdapter;
        private System.Windows.Forms.BindingSource bidIncrementTypesBindingSource;
        private SilentAuctionDataSetTableAdapters.BidIncrementTypesTableAdapter bidIncrementTypesTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn auctionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn itemTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn donationDeliveryTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn retailValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidBuyItNowValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn bidIncrementTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidMinValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidMaxValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidIncrementValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidNumberOfBidsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedDateDataGridViewTextBoxColumn;
    }
}