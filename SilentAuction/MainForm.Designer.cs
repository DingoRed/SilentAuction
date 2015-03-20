namespace SilentAuction
{ 
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ItemsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.ItemsDonorIdColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.donorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.silentAuctionDataSet = new SilentAuction.SilentAuctionDataSet();
            this.ItemsAuctionIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsQtyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsItemDescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsNotesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsItemTypeIdColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.itemTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ItemsDonationDeliveryTypeIdColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.donationDeliveryTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ItemsRetailValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsBidBuyItNowValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsBidIncrementTypeColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bidIncrementTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ItemsBidMinValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsBidMaxValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsBidIncrementValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsBidNumberOfBidsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsCreateDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsModifiedDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddItemsButton = new System.Windows.Forms.Button();
            this.ItemsSaveAllButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ItemsRequirementLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AuctionNameLabel2 = new System.Windows.Forms.Label();
            this.AuctionNameLabel1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewAuctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDonorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.OpenAuctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseAuctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAuctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDonorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auctionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.ItemsTableAdapter();
            this.donorsTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.DonorsTableAdapter();
            this.auctionsTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.AuctionsTableAdapter();
            this.bidIncrementTypesTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.BidIncrementTypesTableAdapter();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.MainFormStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.itemTypesTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.ItemTypesTableAdapter();
            this.donationDeliveryTypesTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.DonationDeliveryTypesTableAdapter();
            this.donorTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donorTypesTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.DonorTypesTableAdapter();
            this.requestFormatTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestFormatTypesTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.RequestFormatTypesTableAdapter();
            this.AuctionsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DonorsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationDeliveryTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bidIncrementTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.auctionsBindingSource)).BeginInit();
            this.statusStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donorTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestFormatTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemsTableLayoutPanel
            // 
            this.ItemsTableLayoutPanel.ColumnCount = 2;
            this.ItemsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ItemsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ItemsTableLayoutPanel.Controls.Add(this.ItemsDataGridView, 0, 1);
            this.ItemsTableLayoutPanel.Controls.Add(this.panel1, 0, 2);
            this.ItemsTableLayoutPanel.Controls.Add(this.panel4, 0, 3);
            this.ItemsTableLayoutPanel.Controls.Add(this.panel2, 1, 0);
            this.ItemsTableLayoutPanel.Controls.Add(this.menuStrip1, 0, 0);
            this.ItemsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.ItemsTableLayoutPanel.Name = "ItemsTableLayoutPanel";
            this.ItemsTableLayoutPanel.RowCount = 4;
            this.ItemsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.ItemsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ItemsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ItemsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ItemsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ItemsTableLayoutPanel.Size = new System.Drawing.Size(874, 414);
            this.ItemsTableLayoutPanel.TabIndex = 3;
            // 
            // ItemsDataGridView
            // 
            this.ItemsDataGridView.AutoGenerateColumns = false;
            this.ItemsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.ItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemsDonorIdColumn,
            this.ItemsAuctionIdColumn,
            this.ItemsNameColumn,
            this.ItemsQtyColumn,
            this.ItemsItemDescriptionColumn,
            this.ItemsNotesColumn,
            this.ItemsItemTypeIdColumn,
            this.ItemsDonationDeliveryTypeIdColumn,
            this.ItemsRetailValueColumn,
            this.ItemsBidBuyItNowValueColumn,
            this.ItemsBidIncrementTypeColumn,
            this.ItemsBidMinValueColumn,
            this.ItemsBidMaxValueColumn,
            this.ItemsBidIncrementValueColumn,
            this.ItemsBidNumberOfBidsColumn,
            this.ItemsCreateDateColumn,
            this.ItemsModifiedDateColumn,
            this.ItemsIdColumn});
            this.ItemsTableLayoutPanel.SetColumnSpan(this.ItemsDataGridView, 2);
            this.ItemsDataGridView.DataSource = this.itemsBindingSource;
            this.ItemsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsDataGridView.Location = new System.Drawing.Point(3, 27);
            this.ItemsDataGridView.Name = "ItemsDataGridView";
            this.ItemsDataGridView.Size = new System.Drawing.Size(868, 324);
            this.ItemsDataGridView.TabIndex = 0;
            this.ItemsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsDataGridViewCellClick);
            this.ItemsDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsDataGridViewCellEndEdit);
            this.ItemsDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.ItemsDataGridViewCellValidating);
            this.ItemsDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.ItemsDataGridViewDataError);
            this.ItemsDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.ItemsDataGridViewDefaultValuesNeeded);
            // 
            // ItemsDonorIdColumn
            // 
            this.ItemsDonorIdColumn.DataPropertyName = "DonorId";
            this.ItemsDonorIdColumn.DataSource = this.donorsBindingSource;
            this.ItemsDonorIdColumn.DisplayMember = "Name";
            this.ItemsDonorIdColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ItemsDonorIdColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemsDonorIdColumn.HeaderText = "* Donor";
            this.ItemsDonorIdColumn.Name = "ItemsDonorIdColumn";
            this.ItemsDonorIdColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsDonorIdColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ItemsDonorIdColumn.ValueMember = "Id";
            this.ItemsDonorIdColumn.Width = 70;
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
            // ItemsAuctionIdColumn
            // 
            this.ItemsAuctionIdColumn.DataPropertyName = "AuctionId";
            this.ItemsAuctionIdColumn.HeaderText = "AuctionId";
            this.ItemsAuctionIdColumn.Name = "ItemsAuctionIdColumn";
            this.ItemsAuctionIdColumn.Visible = false;
            this.ItemsAuctionIdColumn.Width = 80;
            // 
            // ItemsNameColumn
            // 
            this.ItemsNameColumn.DataPropertyName = "Name";
            this.ItemsNameColumn.HeaderText = "* Item Name";
            this.ItemsNameColumn.Name = "ItemsNameColumn";
            this.ItemsNameColumn.Width = 90;
            // 
            // ItemsQtyColumn
            // 
            this.ItemsQtyColumn.DataPropertyName = "Qty";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Format = "N0";
            dataGridViewCellStyle9.NullValue = null;
            this.ItemsQtyColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.ItemsQtyColumn.HeaderText = "* Qty";
            this.ItemsQtyColumn.Name = "ItemsQtyColumn";
            this.ItemsQtyColumn.Width = 55;
            // 
            // ItemsItemDescriptionColumn
            // 
            this.ItemsItemDescriptionColumn.DataPropertyName = "Description";
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsItemDescriptionColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.ItemsItemDescriptionColumn.HeaderText = "Item Description";
            this.ItemsItemDescriptionColumn.Name = "ItemsItemDescriptionColumn";
            this.ItemsItemDescriptionColumn.Width = 120;
            // 
            // ItemsNotesColumn
            // 
            this.ItemsNotesColumn.DataPropertyName = "Notes";
            this.ItemsNotesColumn.HeaderText = "Notes";
            this.ItemsNotesColumn.Name = "ItemsNotesColumn";
            this.ItemsNotesColumn.Width = 60;
            // 
            // ItemsItemTypeIdColumn
            // 
            this.ItemsItemTypeIdColumn.DataPropertyName = "ItemTypeId";
            this.ItemsItemTypeIdColumn.DataSource = this.itemTypesBindingSource;
            this.ItemsItemTypeIdColumn.DisplayMember = "Name";
            this.ItemsItemTypeIdColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ItemsItemTypeIdColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemsItemTypeIdColumn.HeaderText = "Item Type";
            this.ItemsItemTypeIdColumn.Name = "ItemsItemTypeIdColumn";
            this.ItemsItemTypeIdColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsItemTypeIdColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ItemsItemTypeIdColumn.ValueMember = "Id";
            // 
            // itemTypesBindingSource
            // 
            this.itemTypesBindingSource.DataMember = "ItemTypes";
            this.itemTypesBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // ItemsDonationDeliveryTypeIdColumn
            // 
            this.ItemsDonationDeliveryTypeIdColumn.DataPropertyName = "DonationDeliveryTypeId";
            this.ItemsDonationDeliveryTypeIdColumn.DataSource = this.donationDeliveryTypesBindingSource;
            this.ItemsDonationDeliveryTypeIdColumn.DisplayMember = "Name";
            this.ItemsDonationDeliveryTypeIdColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ItemsDonationDeliveryTypeIdColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemsDonationDeliveryTypeIdColumn.HeaderText = "Delivery Method";
            this.ItemsDonationDeliveryTypeIdColumn.Name = "ItemsDonationDeliveryTypeIdColumn";
            this.ItemsDonationDeliveryTypeIdColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsDonationDeliveryTypeIdColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ItemsDonationDeliveryTypeIdColumn.ValueMember = "Id";
            this.ItemsDonationDeliveryTypeIdColumn.Width = 120;
            // 
            // donationDeliveryTypesBindingSource
            // 
            this.donationDeliveryTypesBindingSource.DataMember = "DonationDeliveryTypes";
            this.donationDeliveryTypesBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // ItemsRetailValueColumn
            // 
            this.ItemsRetailValueColumn.DataPropertyName = "RetailValue";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "C2";
            this.ItemsRetailValueColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.ItemsRetailValueColumn.HeaderText = "Retail Value";
            this.ItemsRetailValueColumn.Name = "ItemsRetailValueColumn";
            this.ItemsRetailValueColumn.Width = 90;
            // 
            // ItemsBidBuyItNowValueColumn
            // 
            this.ItemsBidBuyItNowValueColumn.DataPropertyName = "BidBuyItNowValue";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "C2";
            this.ItemsBidBuyItNowValueColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.ItemsBidBuyItNowValueColumn.HeaderText = "Buy It Now Amount";
            this.ItemsBidBuyItNowValueColumn.Name = "ItemsBidBuyItNowValueColumn";
            this.ItemsBidBuyItNowValueColumn.Width = 140;
            // 
            // ItemsBidIncrementTypeColumn
            // 
            this.ItemsBidIncrementTypeColumn.DataPropertyName = "BidIncrementTypeId";
            this.ItemsBidIncrementTypeColumn.DataSource = this.bidIncrementTypesBindingSource;
            this.ItemsBidIncrementTypeColumn.DisplayMember = "Name";
            this.ItemsBidIncrementTypeColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ItemsBidIncrementTypeColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemsBidIncrementTypeColumn.HeaderText = "* Bid Incr Type";
            this.ItemsBidIncrementTypeColumn.Name = "ItemsBidIncrementTypeColumn";
            this.ItemsBidIncrementTypeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsBidIncrementTypeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ItemsBidIncrementTypeColumn.ValueMember = "Id";
            this.ItemsBidIncrementTypeColumn.Width = 110;
            // 
            // bidIncrementTypesBindingSource
            // 
            this.bidIncrementTypesBindingSource.DataMember = "BidIncrementTypes";
            this.bidIncrementTypesBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // ItemsBidMinValueColumn
            // 
            this.ItemsBidMinValueColumn.DataPropertyName = "BidMinValue";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "C2";
            dataGridViewCellStyle13.NullValue = null;
            this.ItemsBidMinValueColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.ItemsBidMinValueColumn.HeaderText = "Minimum Bid";
            this.ItemsBidMinValueColumn.Name = "ItemsBidMinValueColumn";
            this.ItemsBidMinValueColumn.Width = 95;
            // 
            // ItemsBidMaxValueColumn
            // 
            this.ItemsBidMaxValueColumn.DataPropertyName = "BidMaxValue";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "C2";
            this.ItemsBidMaxValueColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.ItemsBidMaxValueColumn.HeaderText = "Maximum Bid";
            this.ItemsBidMaxValueColumn.Name = "ItemsBidMaxValueColumn";
            this.ItemsBidMaxValueColumn.Width = 95;
            // 
            // ItemsBidIncrementValueColumn
            // 
            this.ItemsBidIncrementValueColumn.DataPropertyName = "BidIncrementValue";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Format = "C2";
            this.ItemsBidIncrementValueColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.ItemsBidIncrementValueColumn.HeaderText = "Bid Incr";
            this.ItemsBidIncrementValueColumn.Name = "ItemsBidIncrementValueColumn";
            this.ItemsBidIncrementValueColumn.Width = 70;
            // 
            // ItemsBidNumberOfBidsColumn
            // 
            this.ItemsBidNumberOfBidsColumn.DataPropertyName = "BidNumberOfBids";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.Format = "N0";
            dataGridViewCellStyle16.NullValue = null;
            this.ItemsBidNumberOfBidsColumn.DefaultCellStyle = dataGridViewCellStyle16;
            this.ItemsBidNumberOfBidsColumn.HeaderText = "# of Bids";
            this.ItemsBidNumberOfBidsColumn.Name = "ItemsBidNumberOfBidsColumn";
            this.ItemsBidNumberOfBidsColumn.Width = 75;
            // 
            // ItemsCreateDateColumn
            // 
            this.ItemsCreateDateColumn.DataPropertyName = "CreateDate";
            this.ItemsCreateDateColumn.HeaderText = "CreateDate";
            this.ItemsCreateDateColumn.Name = "ItemsCreateDateColumn";
            this.ItemsCreateDateColumn.ReadOnly = true;
            this.ItemsCreateDateColumn.Visible = false;
            this.ItemsCreateDateColumn.Width = 86;
            // 
            // ItemsModifiedDateColumn
            // 
            this.ItemsModifiedDateColumn.DataPropertyName = "ModifiedDate";
            this.ItemsModifiedDateColumn.HeaderText = "ModifiedDate";
            this.ItemsModifiedDateColumn.Name = "ItemsModifiedDateColumn";
            this.ItemsModifiedDateColumn.Visible = false;
            this.ItemsModifiedDateColumn.Width = 95;
            // 
            // ItemsIdColumn
            // 
            this.ItemsIdColumn.DataPropertyName = "Id";
            this.ItemsIdColumn.HeaderText = "Id";
            this.ItemsIdColumn.Name = "ItemsIdColumn";
            this.ItemsIdColumn.ReadOnly = true;
            this.ItemsIdColumn.Visible = false;
            this.ItemsIdColumn.Width = 41;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // panel1
            // 
            this.ItemsTableLayoutPanel.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.AddItemsButton);
            this.panel1.Controls.Add(this.ItemsSaveAllButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 357);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 34);
            this.panel1.TabIndex = 3;
            // 
            // AddItemsButton
            // 
            this.AddItemsButton.AutoSize = true;
            this.AddItemsButton.Location = new System.Drawing.Point(110, 3);
            this.AddItemsButton.Name = "AddItemsButton";
            this.AddItemsButton.Size = new System.Drawing.Size(101, 23);
            this.AddItemsButton.TabIndex = 3;
            this.AddItemsButton.Text = "Add Item";
            this.AddItemsButton.UseVisualStyleBackColor = true;
            this.AddItemsButton.Visible = false;
            this.AddItemsButton.Click += new System.EventHandler(this.AddItemsButtonClick);
            // 
            // ItemsSaveAllButton
            // 
            this.ItemsSaveAllButton.AutoSize = true;
            this.ItemsSaveAllButton.Location = new System.Drawing.Point(3, 3);
            this.ItemsSaveAllButton.Name = "ItemsSaveAllButton";
            this.ItemsSaveAllButton.Size = new System.Drawing.Size(101, 23);
            this.ItemsSaveAllButton.TabIndex = 2;
            this.ItemsSaveAllButton.Text = "Save Changes";
            this.ItemsSaveAllButton.UseVisualStyleBackColor = true;
            this.ItemsSaveAllButton.Visible = false;
            this.ItemsSaveAllButton.Click += new System.EventHandler(this.ItemsSaveAllButtonClick);
            // 
            // panel4
            // 
            this.ItemsTableLayoutPanel.SetColumnSpan(this.panel4, 2);
            this.panel4.Controls.Add(this.ItemsRequirementLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 397);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(868, 14);
            this.panel4.TabIndex = 4;
            // 
            // ItemsRequirementLabel
            // 
            this.ItemsRequirementLabel.AutoSize = true;
            this.ItemsRequirementLabel.Location = new System.Drawing.Point(3, 0);
            this.ItemsRequirementLabel.Name = "ItemsRequirementLabel";
            this.ItemsRequirementLabel.Size = new System.Drawing.Size(218, 13);
            this.ItemsRequirementLabel.TabIndex = 3;
            this.ItemsRequirementLabel.Text = "Items marked with an asterisk (*) are required";
            this.ItemsRequirementLabel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AuctionNameLabel2);
            this.panel2.Controls.Add(this.AuctionNameLabel1);
            this.panel2.Location = new System.Drawing.Point(440, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(431, 14);
            this.panel2.TabIndex = 6;
            // 
            // AuctionNameLabel2
            // 
            this.AuctionNameLabel2.AutoSize = true;
            this.AuctionNameLabel2.Location = new System.Drawing.Point(133, 1);
            this.AuctionNameLabel2.Name = "AuctionNameLabel2";
            this.AuctionNameLabel2.Size = new System.Drawing.Size(69, 13);
            this.AuctionNameLabel2.TabIndex = 6;
            this.AuctionNameLabel2.Text = "(Placeholder)";
            this.AuctionNameLabel2.Visible = false;
            // 
            // AuctionNameLabel1
            // 
            this.AuctionNameLabel1.AutoSize = true;
            this.AuctionNameLabel1.Location = new System.Drawing.Point(16, 1);
            this.AuctionNameLabel1.Name = "AuctionNameLabel1";
            this.AuctionNameLabel1.Size = new System.Drawing.Size(111, 13);
            this.AuctionNameLabel1.TabIndex = 5;
            this.AuctionNameLabel1.Text = "Working with Auction:";
            this.AuctionNameLabel1.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(206, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewAuctionToolStripMenuItem,
            this.newDonorToolStripMenuItem,
            this.toolStripSeparator7,
            this.OpenAuctionToolStripMenuItem,
            this.CloseAuctionToolStripMenuItem,
            this.toolStripSeparator,
            this.SaveToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // NewAuctionToolStripMenuItem
            // 
            this.NewAuctionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("NewAuctionToolStripMenuItem.Image")));
            this.NewAuctionToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewAuctionToolStripMenuItem.Name = "NewAuctionToolStripMenuItem";
            this.NewAuctionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewAuctionToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.NewAuctionToolStripMenuItem.Text = "&New Auction";
            this.NewAuctionToolStripMenuItem.Click += new System.EventHandler(this.NewAuctionToolStripMenuItemClick);
            // 
            // newDonorToolStripMenuItem
            // 
            this.newDonorToolStripMenuItem.Name = "newDonorToolStripMenuItem";
            this.newDonorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.newDonorToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.newDonorToolStripMenuItem.Text = "New &Donor";
            this.newDonorToolStripMenuItem.Click += new System.EventHandler(this.NewDonorToolStripMenuItemClick);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(188, 6);
            // 
            // OpenAuctionToolStripMenuItem
            // 
            this.OpenAuctionToolStripMenuItem.Enabled = false;
            this.OpenAuctionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("OpenAuctionToolStripMenuItem.Image")));
            this.OpenAuctionToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenAuctionToolStripMenuItem.Name = "OpenAuctionToolStripMenuItem";
            this.OpenAuctionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenAuctionToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.OpenAuctionToolStripMenuItem.Text = "&Open Auction";
            this.OpenAuctionToolStripMenuItem.Click += new System.EventHandler(this.OpenAuctionToolStripMenuItemClick);
            // 
            // CloseAuctionToolStripMenuItem
            // 
            this.CloseAuctionToolStripMenuItem.Enabled = false;
            this.CloseAuctionToolStripMenuItem.Name = "CloseAuctionToolStripMenuItem";
            this.CloseAuctionToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.CloseAuctionToolStripMenuItem.Text = "Close Auction";
            this.CloseAuctionToolStripMenuItem.Click += new System.EventHandler(this.CloseAuctionToolStripMenuItemClick);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(188, 6);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SaveToolStripMenuItem.Image")));
            this.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.SaveToolStripMenuItem.Text = "&Save";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItemClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(188, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItemClick);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.PrintPreviewToolStripMenuItemClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(188, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AuctionsListToolStripMenuItem,
            this.editAuctionToolStripMenuItem,
            this.toolStripSeparator3,
            this.DonorsListToolStripMenuItem,
            this.editDonorToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.editToolStripMenuItem.Text = "&Edit/View";
            // 
            // editAuctionToolStripMenuItem
            // 
            this.editAuctionToolStripMenuItem.Name = "editAuctionToolStripMenuItem";
            this.editAuctionToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.editAuctionToolStripMenuItem.Text = "Edit Auction (Form)";
            this.editAuctionToolStripMenuItem.Click += new System.EventHandler(this.EditAuctionToolStripMenuItemClick);
            // 
            // editDonorToolStripMenuItem
            // 
            this.editDonorToolStripMenuItem.Name = "editDonorToolStripMenuItem";
            this.editDonorToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.editDonorToolStripMenuItem.Text = "Edit Donor (Form)";
            this.editDonorToolStripMenuItem.Click += new System.EventHandler(this.EditDonorToolStripMenuItemClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(175, 6);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(149, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
            // 
            // auctionsBindingSource
            // 
            this.auctionsBindingSource.DataMember = "Auctions";
            this.auctionsBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // donorsTableAdapter
            // 
            this.donorsTableAdapter.ClearBeforeFill = true;
            // 
            // auctionsTableAdapter
            // 
            this.auctionsTableAdapter.ClearBeforeFill = true;
            // 
            // bidIncrementTypesTableAdapter
            // 
            this.bidIncrementTypesTableAdapter.ClearBeforeFill = true;
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainFormStatusLabel});
            this.statusStrip2.Location = new System.Drawing.Point(0, 414);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(874, 22);
            this.statusStrip2.TabIndex = 1;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // MainFormStatusLabel
            // 
            this.MainFormStatusLabel.Name = "MainFormStatusLabel";
            this.MainFormStatusLabel.Size = new System.Drawing.Size(65, 17);
            this.MainFormStatusLabel.Text = "Data Saved";
            this.MainFormStatusLabel.Visible = false;
            // 
            // itemTypesTableAdapter
            // 
            this.itemTypesTableAdapter.ClearBeforeFill = true;
            // 
            // donationDeliveryTypesTableAdapter
            // 
            this.donationDeliveryTypesTableAdapter.ClearBeforeFill = true;
            // 
            // donorTypeBindingSource
            // 
            this.donorTypeBindingSource.DataMember = "DonorTypes";
            this.donorTypeBindingSource.DataSource = this.silentAuctionDataSet;
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
            // AuctionsListToolStripMenuItem
            // 
            this.AuctionsListToolStripMenuItem.Name = "AuctionsListToolStripMenuItem";
            this.AuctionsListToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.AuctionsListToolStripMenuItem.Text = "Edit Auction (List)";
            this.AuctionsListToolStripMenuItem.Click += new System.EventHandler(this.AuctionsListToolStripMenuItemClick);
            // 
            // DonorsListToolStripMenuItem
            // 
            this.DonorsListToolStripMenuItem.Name = "DonorsListToolStripMenuItem";
            this.DonorsListToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.DonorsListToolStripMenuItem.Text = "Edit Donor (List)";
            this.DonorsListToolStripMenuItem.Click += new System.EventHandler(this.DonorsListToolStripMenuItemClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 436);
            this.Controls.Add(this.ItemsTableLayoutPanel);
            this.Controls.Add(this.statusStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Silent Auction";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm2FormClosing);
            this.Load += new System.EventHandler(this.MainForm2Load);
            this.ItemsTableLayoutPanel.ResumeLayout(false);
            this.ItemsTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationDeliveryTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bidIncrementTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.auctionsBindingSource)).EndInit();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donorTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestFormatTypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ItemsDataGridView;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private SilentAuctionDataSet silentAuctionDataSet;
        private SilentAuctionDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.Button ItemsSaveAllButton;
        private System.Windows.Forms.TableLayoutPanel ItemsTableLayoutPanel;
        private System.Windows.Forms.BindingSource donorsBindingSource;
        private SilentAuctionDataSetTableAdapters.DonorsTableAdapter donorsTableAdapter;
        private System.Windows.Forms.BindingSource auctionsBindingSource;
        private SilentAuctionDataSetTableAdapters.AuctionsTableAdapter auctionsTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ItemsRequirementLabel;
        private System.Windows.Forms.BindingSource bidIncrementTypesBindingSource;
        private SilentAuctionDataSetTableAdapters.BidIncrementTypesTableAdapter bidIncrementTypesTableAdapter;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel MainFormStatusLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button AddItemsButton;
        private System.Windows.Forms.BindingSource itemTypesBindingSource;
        private SilentAuctionDataSetTableAdapters.ItemTypesTableAdapter itemTypesTableAdapter;
        private System.Windows.Forms.BindingSource donationDeliveryTypesBindingSource;
        private SilentAuctionDataSetTableAdapters.DonationDeliveryTypesTableAdapter donationDeliveryTypesTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewAuctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenAuctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label AuctionNameLabel1;
        private System.Windows.Forms.BindingSource donorTypeBindingSource;
        private SilentAuctionDataSetTableAdapters.DonorTypesTableAdapter donorTypesTableAdapter;
        private System.Windows.Forms.BindingSource requestFormatTypesBindingSource;
        private SilentAuctionDataSetTableAdapters.RequestFormatTypesTableAdapter requestFormatTypesTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label AuctionNameLabel2;
        private System.Windows.Forms.ToolStripMenuItem newDonorToolStripMenuItem;
        private System.Windows.Forms.DataGridViewComboBoxColumn ItemsDonorIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsAuctionIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsQtyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsItemDescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsNotesColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ItemsItemTypeIdColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ItemsDonationDeliveryTypeIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsRetailValueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsBidBuyItNowValueColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ItemsBidIncrementTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsBidMinValueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsBidMaxValueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsBidIncrementValueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsBidNumberOfBidsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsCreateDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsModifiedDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsIdColumn;
        private System.Windows.Forms.ToolStripMenuItem editAuctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDonorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem CloseAuctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AuctionsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DonorsListToolStripMenuItem;
    }
}