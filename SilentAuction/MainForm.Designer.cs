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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ItemsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.ItemsIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsDonorTypeNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsDonorNameColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.donorsNameOnlyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.silentAuctionDataSet = new SilentAuction.SilentAuctionDataSet();
            this.ItemsItemNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsQtyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsDescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.ItemsNotesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsItemTypeNameColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.itemTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ItemsDonationDeliveryTypeIdColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.donationDeliveryTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ItemsSellValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsRetailValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsBidBuyItNowValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsBidIncrementTypeIdColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bidIncrementTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ItemsBidMinValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsBidMaxValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsBidIncrementValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsBidNumberOfBidsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsDonorIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsAuctionIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsAuctionNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsItemTypeIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsCreateDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsModifiedDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.GoToBottomButton = new System.Windows.Forms.Button();
            this.ItemsSaveAllButton = new System.Windows.Forms.Button();
            this.LabelsPanel = new System.Windows.Forms.Panel();
            this.ItemsRequirementLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewAuctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewDonorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.OpenAuctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseAuctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditAuctionListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditAuctionFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.EditDonorListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditDonorFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DocumentEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.PrintBidSheetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.CreateAddressLabelsFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateItemLabelsFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyDonorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bidCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ShowAllItemsByDonorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donorNoResponseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AuctionNamePanel = new System.Windows.Forms.Panel();
            this.AuctionNameLabel2 = new System.Windows.Forms.Label();
            this.ScreenTitlePanel = new System.Windows.Forms.Panel();
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.MainFormStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.itemsTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.ItemsTableAdapter();
            this.donorsNameOnlyTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.DonorsNameOnlyTableAdapter();
            this.itemTypesTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.ItemTypesTableAdapter();
            this.donationDeliveryTypesTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.DonationDeliveryTypesTableAdapter();
            this.bidIncrementTypesTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.BidIncrementTypesTableAdapter();
            this.ItemsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorsNameOnlyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationDeliveryTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bidIncrementTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.ButtonsPanel.SuspendLayout();
            this.LabelsPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.AuctionNamePanel.SuspendLayout();
            this.ScreenTitlePanel.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemsTableLayoutPanel
            // 
            this.ItemsTableLayoutPanel.ColumnCount = 3;
            this.ItemsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.ItemsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.ItemsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ItemsTableLayoutPanel.Controls.Add(this.ItemsDataGridView, 0, 2);
            this.ItemsTableLayoutPanel.Controls.Add(this.ButtonsPanel, 0, 3);
            this.ItemsTableLayoutPanel.Controls.Add(this.LabelsPanel, 0, 4);
            this.ItemsTableLayoutPanel.Controls.Add(this.menuStrip1, 0, 0);
            this.ItemsTableLayoutPanel.Controls.Add(this.AuctionNamePanel, 1, 0);
            this.ItemsTableLayoutPanel.Controls.Add(this.ScreenTitlePanel, 0, 1);
            this.ItemsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.ItemsTableLayoutPanel.Name = "ItemsTableLayoutPanel";
            this.ItemsTableLayoutPanel.RowCount = 5;
            this.ItemsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ItemsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ItemsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ItemsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ItemsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ItemsTableLayoutPanel.Size = new System.Drawing.Size(874, 414);
            this.ItemsTableLayoutPanel.TabIndex = 3;
            // 
            // ItemsDataGridView
            // 
            this.ItemsDataGridView.AutoGenerateColumns = false;
            this.ItemsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.ItemsDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemsIdColumn,
            this.ItemsDonorTypeNameColumn,
            this.ItemsDonorNameColumn,
            this.ItemsItemNameColumn,
            this.ItemsQtyColumn,
            this.ItemsDescriptionColumn,
            this.ItemsImageColumn,
            this.ItemsNotesColumn,
            this.ItemsItemTypeNameColumn,
            this.ItemsDonationDeliveryTypeIdColumn,
            this.ItemsSellValueColumn,
            this.ItemsRetailValueColumn,
            this.ItemsBidBuyItNowValueColumn,
            this.ItemsBidIncrementTypeIdColumn,
            this.ItemsBidMinValueColumn,
            this.ItemsBidMaxValueColumn,
            this.ItemsBidIncrementValueColumn,
            this.ItemsBidNumberOfBidsColumn,
            this.ItemsDonorIdColumn,
            this.ItemsAuctionIdColumn,
            this.ItemsAuctionNameColumn,
            this.ItemsItemTypeIdColumn,
            this.ItemsCreateDateColumn,
            this.ItemsModifiedDateColumn});
            this.ItemsTableLayoutPanel.SetColumnSpan(this.ItemsDataGridView, 3);
            this.ItemsDataGridView.DataSource = this.itemsBindingSource;
            this.ItemsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsDataGridView.Location = new System.Drawing.Point(3, 63);
            this.ItemsDataGridView.Name = "ItemsDataGridView";
            this.ItemsDataGridView.Size = new System.Drawing.Size(868, 288);
            this.ItemsDataGridView.TabIndex = 0;
            this.ItemsDataGridView.Visible = false;
            this.ItemsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsDataGridViewCellClick);
            this.ItemsDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsDataGridViewCellEndEdit);
            this.ItemsDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ItemsDataGridViewCellMouseClick);
            this.ItemsDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.ItemsDataGridViewDataError);
            this.ItemsDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.ItemsDataGridViewDefaultValuesNeeded);
            this.ItemsDataGridView.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.ItemsDataGridViewRowPrePaint);
            // 
            // ItemsIdColumn
            // 
            this.ItemsIdColumn.DataPropertyName = "Id";
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.ItemsIdColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.ItemsIdColumn.HeaderText = "Id";
            this.ItemsIdColumn.Name = "ItemsIdColumn";
            this.ItemsIdColumn.ReadOnly = true;
            this.ItemsIdColumn.Width = 30;
            // 
            // ItemsDonorTypeNameColumn
            // 
            this.ItemsDonorTypeNameColumn.DataPropertyName = "DonorTypeName";
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.ItemsDonorTypeNameColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.ItemsDonorTypeNameColumn.HeaderText = "Donor Type";
            this.ItemsDonorTypeNameColumn.Name = "ItemsDonorTypeNameColumn";
            this.ItemsDonorTypeNameColumn.ReadOnly = true;
            // 
            // ItemsDonorNameColumn
            // 
            this.ItemsDonorNameColumn.DataPropertyName = "DonorName";
            this.ItemsDonorNameColumn.DataSource = this.donorsNameOnlyBindingSource;
            this.ItemsDonorNameColumn.DisplayMember = "Name";
            this.ItemsDonorNameColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ItemsDonorNameColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemsDonorNameColumn.HeaderText = "* Donor Name";
            this.ItemsDonorNameColumn.Name = "ItemsDonorNameColumn";
            this.ItemsDonorNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsDonorNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ItemsDonorNameColumn.ValueMember = "Name";
            // 
            // donorsNameOnlyBindingSource
            // 
            this.donorsNameOnlyBindingSource.DataMember = "DonorsNameOnly";
            this.donorsNameOnlyBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // silentAuctionDataSet
            // 
            this.silentAuctionDataSet.DataSetName = "SilentAuctionDataSet";
            this.silentAuctionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ItemsItemNameColumn
            // 
            this.ItemsItemNameColumn.DataPropertyName = "Name";
            this.ItemsItemNameColumn.HeaderText = "* Item Name";
            this.ItemsItemNameColumn.Name = "ItemsItemNameColumn";
            this.ItemsItemNameColumn.Width = 90;
            // 
            // ItemsQtyColumn
            // 
            this.ItemsQtyColumn.DataPropertyName = "Qty";
            this.ItemsQtyColumn.HeaderText = "* Qty";
            this.ItemsQtyColumn.Name = "ItemsQtyColumn";
            this.ItemsQtyColumn.Width = 55;
            // 
            // ItemsDescriptionColumn
            // 
            this.ItemsDescriptionColumn.DataPropertyName = "Description";
            this.ItemsDescriptionColumn.HeaderText = "Item Description";
            this.ItemsDescriptionColumn.Name = "ItemsDescriptionColumn";
            this.ItemsDescriptionColumn.Width = 120;
            // 
            // ItemsImageColumn
            // 
            this.ItemsImageColumn.DataPropertyName = "Image";
            this.ItemsImageColumn.HeaderText = "Image";
            this.ItemsImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ItemsImageColumn.Name = "ItemsImageColumn";
            // 
            // ItemsNotesColumn
            // 
            this.ItemsNotesColumn.DataPropertyName = "Notes";
            this.ItemsNotesColumn.HeaderText = "Notes";
            this.ItemsNotesColumn.Name = "ItemsNotesColumn";
            this.ItemsNotesColumn.Width = 60;
            // 
            // ItemsItemTypeNameColumn
            // 
            this.ItemsItemTypeNameColumn.DataPropertyName = "ItemTypeName";
            this.ItemsItemTypeNameColumn.DataSource = this.itemTypesBindingSource;
            this.ItemsItemTypeNameColumn.DisplayMember = "Name";
            this.ItemsItemTypeNameColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ItemsItemTypeNameColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemsItemTypeNameColumn.HeaderText = "Item Type";
            this.ItemsItemTypeNameColumn.Name = "ItemsItemTypeNameColumn";
            this.ItemsItemTypeNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsItemTypeNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ItemsItemTypeNameColumn.ValueMember = "Name";
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
            // ItemsSellValueColumn
            // 
            this.ItemsSellValueColumn.DataPropertyName = "SellValue";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.ItemsSellValueColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.ItemsSellValueColumn.HeaderText = "Sell Value";
            this.ItemsSellValueColumn.Name = "ItemsSellValueColumn";
            this.ItemsSellValueColumn.Width = 90;
            // 
            // ItemsRetailValueColumn
            // 
            this.ItemsRetailValueColumn.DataPropertyName = "RetailValue";
            dataGridViewCellStyle4.Format = "C2";
            this.ItemsRetailValueColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.ItemsRetailValueColumn.HeaderText = "Retail Value";
            this.ItemsRetailValueColumn.Name = "ItemsRetailValueColumn";
            this.ItemsRetailValueColumn.Width = 90;
            // 
            // ItemsBidBuyItNowValueColumn
            // 
            this.ItemsBidBuyItNowValueColumn.DataPropertyName = "BidBuyItNowValue";
            dataGridViewCellStyle5.Format = "C2";
            this.ItemsBidBuyItNowValueColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.ItemsBidBuyItNowValueColumn.HeaderText = "Buy It Now Amt";
            this.ItemsBidBuyItNowValueColumn.Name = "ItemsBidBuyItNowValueColumn";
            this.ItemsBidBuyItNowValueColumn.Width = 140;
            // 
            // ItemsBidIncrementTypeIdColumn
            // 
            this.ItemsBidIncrementTypeIdColumn.DataPropertyName = "BidIncrementTypeId";
            this.ItemsBidIncrementTypeIdColumn.DataSource = this.bidIncrementTypesBindingSource;
            this.ItemsBidIncrementTypeIdColumn.DisplayMember = "Name";
            this.ItemsBidIncrementTypeIdColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ItemsBidIncrementTypeIdColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemsBidIncrementTypeIdColumn.HeaderText = "Bid Incr Type";
            this.ItemsBidIncrementTypeIdColumn.Name = "ItemsBidIncrementTypeIdColumn";
            this.ItemsBidIncrementTypeIdColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsBidIncrementTypeIdColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ItemsBidIncrementTypeIdColumn.ValueMember = "Id";
            this.ItemsBidIncrementTypeIdColumn.Width = 150;
            // 
            // bidIncrementTypesBindingSource
            // 
            this.bidIncrementTypesBindingSource.DataMember = "BidIncrementTypes";
            this.bidIncrementTypesBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // ItemsBidMinValueColumn
            // 
            this.ItemsBidMinValueColumn.DataPropertyName = "BidMinValue";
            dataGridViewCellStyle6.Format = "C2";
            this.ItemsBidMinValueColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.ItemsBidMinValueColumn.HeaderText = "Min Bid";
            this.ItemsBidMinValueColumn.Name = "ItemsBidMinValueColumn";
            this.ItemsBidMinValueColumn.Width = 95;
            // 
            // ItemsBidMaxValueColumn
            // 
            this.ItemsBidMaxValueColumn.DataPropertyName = "BidMaxValue";
            dataGridViewCellStyle7.Format = "C2";
            this.ItemsBidMaxValueColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.ItemsBidMaxValueColumn.HeaderText = "Max Bid";
            this.ItemsBidMaxValueColumn.Name = "ItemsBidMaxValueColumn";
            this.ItemsBidMaxValueColumn.Width = 95;
            // 
            // ItemsBidIncrementValueColumn
            // 
            this.ItemsBidIncrementValueColumn.DataPropertyName = "BidIncrementValue";
            dataGridViewCellStyle8.Format = "C2";
            this.ItemsBidIncrementValueColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.ItemsBidIncrementValueColumn.HeaderText = "Bid Incr";
            this.ItemsBidIncrementValueColumn.Name = "ItemsBidIncrementValueColumn";
            this.ItemsBidIncrementValueColumn.Width = 80;
            // 
            // ItemsBidNumberOfBidsColumn
            // 
            this.ItemsBidNumberOfBidsColumn.DataPropertyName = "BidNumberOfBids";
            this.ItemsBidNumberOfBidsColumn.HeaderText = "# of Bids";
            this.ItemsBidNumberOfBidsColumn.Name = "ItemsBidNumberOfBidsColumn";
            // 
            // ItemsDonorIdColumn
            // 
            this.ItemsDonorIdColumn.DataPropertyName = "DonorId";
            this.ItemsDonorIdColumn.HeaderText = "DonorId";
            this.ItemsDonorIdColumn.Name = "ItemsDonorIdColumn";
            this.ItemsDonorIdColumn.ReadOnly = true;
            this.ItemsDonorIdColumn.Visible = false;
            this.ItemsDonorIdColumn.Width = 30;
            // 
            // ItemsAuctionIdColumn
            // 
            this.ItemsAuctionIdColumn.DataPropertyName = "AuctionId";
            this.ItemsAuctionIdColumn.HeaderText = "Auction Id";
            this.ItemsAuctionIdColumn.Name = "ItemsAuctionIdColumn";
            this.ItemsAuctionIdColumn.ReadOnly = true;
            this.ItemsAuctionIdColumn.Visible = false;
            this.ItemsAuctionIdColumn.Width = 30;
            // 
            // ItemsAuctionNameColumn
            // 
            this.ItemsAuctionNameColumn.DataPropertyName = "AuctionName";
            this.ItemsAuctionNameColumn.HeaderText = "Auction Name";
            this.ItemsAuctionNameColumn.Name = "ItemsAuctionNameColumn";
            this.ItemsAuctionNameColumn.ReadOnly = true;
            this.ItemsAuctionNameColumn.Visible = false;
            this.ItemsAuctionNameColumn.Width = 30;
            // 
            // ItemsItemTypeIdColumn
            // 
            this.ItemsItemTypeIdColumn.DataPropertyName = "ItemTypeId";
            this.ItemsItemTypeIdColumn.HeaderText = "Item Type Id";
            this.ItemsItemTypeIdColumn.Name = "ItemsItemTypeIdColumn";
            this.ItemsItemTypeIdColumn.ReadOnly = true;
            this.ItemsItemTypeIdColumn.Visible = false;
            this.ItemsItemTypeIdColumn.Width = 30;
            // 
            // ItemsCreateDateColumn
            // 
            this.ItemsCreateDateColumn.DataPropertyName = "CreateDate";
            this.ItemsCreateDateColumn.HeaderText = "Create Date";
            this.ItemsCreateDateColumn.Name = "ItemsCreateDateColumn";
            this.ItemsCreateDateColumn.Visible = false;
            this.ItemsCreateDateColumn.Width = 30;
            // 
            // ItemsModifiedDateColumn
            // 
            this.ItemsModifiedDateColumn.DataPropertyName = "ModifiedDate";
            this.ItemsModifiedDateColumn.HeaderText = "ModifiedDate";
            this.ItemsModifiedDateColumn.Name = "ItemsModifiedDateColumn";
            this.ItemsModifiedDateColumn.Visible = false;
            this.ItemsModifiedDateColumn.Width = 30;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // ButtonsPanel
            // 
            this.ItemsTableLayoutPanel.SetColumnSpan(this.ButtonsPanel, 3);
            this.ButtonsPanel.Controls.Add(this.RefreshButton);
            this.ButtonsPanel.Controls.Add(this.exportButton);
            this.ButtonsPanel.Controls.Add(this.GoToBottomButton);
            this.ButtonsPanel.Controls.Add(this.ItemsSaveAllButton);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonsPanel.Location = new System.Drawing.Point(3, 357);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(868, 34);
            this.ButtonsPanel.TabIndex = 3;
            this.ButtonsPanel.Visible = false;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(217, 3);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 5;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButtonClick);
            // 
            // exportButton
            // 
            this.exportButton.Image = global::SilentAuction.Properties.Resources.file_extension_txt;
            this.exportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exportButton.Location = new System.Drawing.Point(795, 3);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(64, 23);
            this.exportButton.TabIndex = 4;
            this.exportButton.Text = "Export";
            this.exportButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.ExportButtonClick);
            // 
            // GoToBottomButton
            // 
            this.GoToBottomButton.AutoSize = true;
            this.GoToBottomButton.Location = new System.Drawing.Point(110, 3);
            this.GoToBottomButton.Name = "GoToBottomButton";
            this.GoToBottomButton.Size = new System.Drawing.Size(101, 23);
            this.GoToBottomButton.TabIndex = 3;
            this.GoToBottomButton.Text = "Go to Bottom";
            this.GoToBottomButton.UseVisualStyleBackColor = true;
            this.GoToBottomButton.Click += new System.EventHandler(this.AddItemsButtonClick);
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
            this.ItemsSaveAllButton.Click += new System.EventHandler(this.ItemsSaveAllButtonClick);
            // 
            // LabelsPanel
            // 
            this.ItemsTableLayoutPanel.SetColumnSpan(this.LabelsPanel, 3);
            this.LabelsPanel.Controls.Add(this.ItemsRequirementLabel);
            this.LabelsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelsPanel.Location = new System.Drawing.Point(3, 397);
            this.LabelsPanel.Name = "LabelsPanel";
            this.LabelsPanel.Size = new System.Drawing.Size(868, 14);
            this.LabelsPanel.TabIndex = 4;
            this.LabelsPanel.Visible = false;
            // 
            // ItemsRequirementLabel
            // 
            this.ItemsRequirementLabel.AutoSize = true;
            this.ItemsRequirementLabel.Location = new System.Drawing.Point(3, 0);
            this.ItemsRequirementLabel.Name = "ItemsRequirementLabel";
            this.ItemsRequirementLabel.Size = new System.Drawing.Size(218, 13);
            this.ItemsRequirementLabel.TabIndex = 3;
            this.ItemsRequirementLabel.Text = "Items marked with an asterisk (*) are required";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.documentsStripMenuItem,
            this.toolsToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(315, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewAuctionToolStripMenuItem,
            this.NewDonorToolStripMenuItem,
            this.NewItemToolStripMenuItem,
            this.toolStripSeparator7,
            this.OpenAuctionToolStripMenuItem,
            this.CloseAuctionToolStripMenuItem,
            this.toolStripSeparator,
            this.SaveToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // NewAuctionToolStripMenuItem
            // 
            this.NewAuctionToolStripMenuItem.Image = global::SilentAuction.Properties.Resources.newpage;
            this.NewAuctionToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewAuctionToolStripMenuItem.Name = "NewAuctionToolStripMenuItem";
            this.NewAuctionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewAuctionToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.NewAuctionToolStripMenuItem.Text = "&New Auction";
            this.NewAuctionToolStripMenuItem.Click += new System.EventHandler(this.NewAuctionToolStripMenuItemClick);
            // 
            // NewDonorToolStripMenuItem
            // 
            this.NewDonorToolStripMenuItem.Name = "NewDonorToolStripMenuItem";
            this.NewDonorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.NewDonorToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.NewDonorToolStripMenuItem.Text = "New &Donor";
            this.NewDonorToolStripMenuItem.Click += new System.EventHandler(this.NewDonorToolStripMenuItemClick);
            // 
            // NewItemToolStripMenuItem
            // 
            this.NewItemToolStripMenuItem.Name = "NewItemToolStripMenuItem";
            this.NewItemToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.NewItemToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.NewItemToolStripMenuItem.Text = "New &Item";
            this.NewItemToolStripMenuItem.Click += new System.EventHandler(this.NewItemToolStripMenuItemClick);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(188, 6);
            // 
            // OpenAuctionToolStripMenuItem
            // 
            this.OpenAuctionToolStripMenuItem.Enabled = false;
            this.OpenAuctionToolStripMenuItem.Image = global::SilentAuction.Properties.Resources.open;
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
            this.SaveToolStripMenuItem.Enabled = false;
            this.SaveToolStripMenuItem.Image = global::SilentAuction.Properties.Resources.save;
            this.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.SaveToolStripMenuItem.Text = "&Save";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItemClick);
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
            this.EditAuctionListToolStripMenuItem,
            this.EditAuctionFormToolStripMenuItem,
            this.toolStripSeparator3,
            this.EditDonorListToolStripMenuItem,
            this.EditDonorFormToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // EditAuctionListToolStripMenuItem
            // 
            this.EditAuctionListToolStripMenuItem.Name = "EditAuctionListToolStripMenuItem";
            this.EditAuctionListToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.EditAuctionListToolStripMenuItem.Text = "Edit Auction (List)";
            this.EditAuctionListToolStripMenuItem.Click += new System.EventHandler(this.EditAuctionListToolStripMenuItemClick);
            // 
            // EditAuctionFormToolStripMenuItem
            // 
            this.EditAuctionFormToolStripMenuItem.Name = "EditAuctionFormToolStripMenuItem";
            this.EditAuctionFormToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.EditAuctionFormToolStripMenuItem.Text = "Edit Auction (Form)";
            this.EditAuctionFormToolStripMenuItem.Click += new System.EventHandler(this.EditAuctionFormToolStripMenuItemClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(175, 6);
            // 
            // EditDonorListToolStripMenuItem
            // 
            this.EditDonorListToolStripMenuItem.Name = "EditDonorListToolStripMenuItem";
            this.EditDonorListToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.EditDonorListToolStripMenuItem.Text = "Edit Donor (List)";
            this.EditDonorListToolStripMenuItem.Click += new System.EventHandler(this.EditDonorListToolStripMenuItemClick);
            // 
            // EditDonorFormToolStripMenuItem
            // 
            this.EditDonorFormToolStripMenuItem.Name = "EditDonorFormToolStripMenuItem";
            this.EditDonorFormToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.EditDonorFormToolStripMenuItem.Text = "Edit Donor (Form)";
            this.EditDonorFormToolStripMenuItem.Click += new System.EventHandler(this.EditDonorFormToolStripMenuItemClick);
            // 
            // documentsStripMenuItem
            // 
            this.documentsStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DocumentEditorToolStripMenuItem,
            this.toolStripSeparator6,
            this.PrintBidSheetsToolStripMenuItem,
            this.toolStripSeparator8,
            this.CreateAddressLabelsFileToolStripMenuItem,
            this.CreateItemLabelsFileToolStripMenuItem});
            this.documentsStripMenuItem.Name = "documentsStripMenuItem";
            this.documentsStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.documentsStripMenuItem.Text = "&Documents";
            // 
            // DocumentEditorToolStripMenuItem
            // 
            this.DocumentEditorToolStripMenuItem.Image = global::SilentAuction.Properties.Resources.newpage;
            this.DocumentEditorToolStripMenuItem.Name = "DocumentEditorToolStripMenuItem";
            this.DocumentEditorToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.DocumentEditorToolStripMenuItem.Text = "&Document Editor";
            this.DocumentEditorToolStripMenuItem.Click += new System.EventHandler(this.DocumentEditorToolStripMenuItemClick);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(207, 6);
            // 
            // PrintBidSheetsToolStripMenuItem
            // 
            this.PrintBidSheetsToolStripMenuItem.Image = global::SilentAuction.Properties.Resources.print;
            this.PrintBidSheetsToolStripMenuItem.Name = "PrintBidSheetsToolStripMenuItem";
            this.PrintBidSheetsToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.PrintBidSheetsToolStripMenuItem.Text = "&Print Bid Sheets";
            this.PrintBidSheetsToolStripMenuItem.Click += new System.EventHandler(this.PrintBidSheetsToolStripMenuItemClick);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(207, 6);
            // 
            // CreateAddressLabelsFileToolStripMenuItem
            // 
            this.CreateAddressLabelsFileToolStripMenuItem.Image = global::SilentAuction.Properties.Resources.file_extension_txt;
            this.CreateAddressLabelsFileToolStripMenuItem.Name = "CreateAddressLabelsFileToolStripMenuItem";
            this.CreateAddressLabelsFileToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.CreateAddressLabelsFileToolStripMenuItem.Text = "Create &Address Labels File";
            this.CreateAddressLabelsFileToolStripMenuItem.Click += new System.EventHandler(this.CreateLabelsFileToolStripMenuItemClick);
            // 
            // CreateItemLabelsFileToolStripMenuItem
            // 
            this.CreateItemLabelsFileToolStripMenuItem.Image = global::SilentAuction.Properties.Resources.file_extension_txt;
            this.CreateItemLabelsFileToolStripMenuItem.Name = "CreateItemLabelsFileToolStripMenuItem";
            this.CreateItemLabelsFileToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.CreateItemLabelsFileToolStripMenuItem.Text = "Create &Item Labels File";
            this.CreateItemLabelsFileToolStripMenuItem.Click += new System.EventHandler(this.CreateItemLabelsFileToolStripMenuItemClick);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyDonorsToolStripMenuItem,
            this.bidCalculatorToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // CopyDonorsToolStripMenuItem
            // 
            this.CopyDonorsToolStripMenuItem.Image = global::SilentAuction.Properties.Resources.copy;
            this.CopyDonorsToolStripMenuItem.Name = "CopyDonorsToolStripMenuItem";
            this.CopyDonorsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.CopyDonorsToolStripMenuItem.Text = "&Copy Donors";
            this.CopyDonorsToolStripMenuItem.Click += new System.EventHandler(this.CopyDonorsToolStripMenuItemClick);
            // 
            // bidCalculatorToolStripMenuItem
            // 
            this.bidCalculatorToolStripMenuItem.Image = global::SilentAuction.Properties.Resources.calculator;
            this.bidCalculatorToolStripMenuItem.Name = "bidCalculatorToolStripMenuItem";
            this.bidCalculatorToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.bidCalculatorToolStripMenuItem.Text = "&Bid Calculator";
            this.bidCalculatorToolStripMenuItem.Click += new System.EventHandler(this.BidCalculatorToolStripMenuItemClick);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4,
            this.ShowAllItemsByDonorToolStripMenuItem,
            this.donorNoResponseToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "&Reports";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(161, 6);
            // 
            // ShowAllItemsByDonorToolStripMenuItem
            // 
            this.ShowAllItemsByDonorToolStripMenuItem.Image = global::SilentAuction.Properties.Resources.report;
            this.ShowAllItemsByDonorToolStripMenuItem.Name = "ShowAllItemsByDonorToolStripMenuItem";
            this.ShowAllItemsByDonorToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.ShowAllItemsByDonorToolStripMenuItem.Text = "&Items By Donor";
            this.ShowAllItemsByDonorToolStripMenuItem.Click += new System.EventHandler(this.ShowAllItemsByDonorToolStripMenuItemClick);
            // 
            // donorNoResponseToolStripMenuItem
            // 
            this.donorNoResponseToolStripMenuItem.Image = global::SilentAuction.Properties.Resources.report;
            this.donorNoResponseToolStripMenuItem.Name = "donorNoResponseToolStripMenuItem";
            this.donorNoResponseToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.donorNoResponseToolStripMenuItem.Text = "&No Response List";
            this.donorNoResponseToolStripMenuItem.Click += new System.EventHandler(this.DonorNoResponseToolStripMenuItemClick);
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
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
            // 
            // AuctionNamePanel
            // 
            this.ItemsTableLayoutPanel.SetColumnSpan(this.AuctionNamePanel, 2);
            this.AuctionNamePanel.Controls.Add(this.AuctionNameLabel2);
            this.AuctionNamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuctionNamePanel.Location = new System.Drawing.Point(403, 3);
            this.AuctionNamePanel.Name = "AuctionNamePanel";
            this.AuctionNamePanel.Size = new System.Drawing.Size(468, 24);
            this.AuctionNamePanel.TabIndex = 6;
            this.AuctionNamePanel.Visible = false;
            // 
            // AuctionNameLabel2
            // 
            this.AuctionNameLabel2.AutoSize = true;
            this.AuctionNameLabel2.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuctionNameLabel2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.AuctionNameLabel2.Location = new System.Drawing.Point(3, 0);
            this.AuctionNameLabel2.Name = "AuctionNameLabel2";
            this.AuctionNameLabel2.Size = new System.Drawing.Size(135, 21);
            this.AuctionNameLabel2.TabIndex = 6;
            this.AuctionNameLabel2.Text = "(Placeholder)";
            // 
            // ScreenTitlePanel
            // 
            this.ItemsTableLayoutPanel.SetColumnSpan(this.ScreenTitlePanel, 3);
            this.ScreenTitlePanel.Controls.Add(this.ItemsLabel);
            this.ScreenTitlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScreenTitlePanel.Location = new System.Drawing.Point(3, 33);
            this.ScreenTitlePanel.Name = "ScreenTitlePanel";
            this.ScreenTitlePanel.Size = new System.Drawing.Size(868, 24);
            this.ScreenTitlePanel.TabIndex = 7;
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.AutoSize = true;
            this.ItemsLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ItemsLabel.Location = new System.Drawing.Point(3, 0);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(66, 21);
            this.ItemsLabel.TabIndex = 7;
            this.ItemsLabel.Text = "Items:";
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
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // donorsNameOnlyTableAdapter
            // 
            this.donorsNameOnlyTableAdapter.ClearBeforeFill = true;
            // 
            // itemTypesTableAdapter
            // 
            this.itemTypesTableAdapter.ClearBeforeFill = true;
            // 
            // donationDeliveryTypesTableAdapter
            // 
            this.donationDeliveryTypesTableAdapter.ClearBeforeFill = true;
            // 
            // bidIncrementTypesTableAdapter
            // 
            this.bidIncrementTypesTableAdapter.ClearBeforeFill = true;
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Silent Auction";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.ItemsTableLayoutPanel.ResumeLayout(false);
            this.ItemsTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorsNameOnlyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationDeliveryTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bidIncrementTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.ButtonsPanel.ResumeLayout(false);
            this.ButtonsPanel.PerformLayout();
            this.LabelsPanel.ResumeLayout(false);
            this.LabelsPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.AuctionNamePanel.ResumeLayout(false);
            this.AuctionNamePanel.PerformLayout();
            this.ScreenTitlePanel.ResumeLayout(false);
            this.ScreenTitlePanel.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ItemsDataGridView;
        private System.Windows.Forms.Button ItemsSaveAllButton;
        private System.Windows.Forms.TableLayoutPanel ItemsTableLayoutPanel;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Label ItemsRequirementLabel;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel MainFormStatusLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel LabelsPanel;
        private System.Windows.Forms.Button GoToBottomButton;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewAuctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenAuctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyDonorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel AuctionNamePanel;
        private System.Windows.Forms.Label AuctionNameLabel2;
        private System.Windows.Forms.ToolStripMenuItem NewDonorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditAuctionFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditDonorFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem CloseAuctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditAuctionListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditDonorListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem ShowAllItemsByDonorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentsStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DocumentEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donorNoResponseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateAddressLabelsFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateItemLabelsFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bidCalculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem PrintBidSheetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Panel ScreenTitlePanel;
        private System.Windows.Forms.Label ItemsLabel;
        private System.Windows.Forms.BindingSource donorsNameOnlyBindingSource;
        private SilentAuctionDataSet silentAuctionDataSet;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private SilentAuctionDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private SilentAuctionDataSetTableAdapters.DonorsNameOnlyTableAdapter donorsNameOnlyTableAdapter;
        private System.Windows.Forms.BindingSource itemTypesBindingSource;
        private SilentAuctionDataSetTableAdapters.ItemTypesTableAdapter itemTypesTableAdapter;
        private System.Windows.Forms.BindingSource donationDeliveryTypesBindingSource;
        private SilentAuctionDataSetTableAdapters.DonationDeliveryTypesTableAdapter donationDeliveryTypesTableAdapter;
        private System.Windows.Forms.BindingSource bidIncrementTypesBindingSource;
        private SilentAuctionDataSetTableAdapters.BidIncrementTypesTableAdapter bidIncrementTypesTableAdapter;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsDonorTypeNameColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ItemsDonorNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsItemNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsQtyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsDescriptionColumn;
        private System.Windows.Forms.DataGridViewImageColumn ItemsImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsNotesColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ItemsItemTypeNameColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ItemsDonationDeliveryTypeIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsSellValueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsRetailValueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsBidBuyItNowValueColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ItemsBidIncrementTypeIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsBidMinValueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsBidMaxValueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsBidIncrementValueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsBidNumberOfBidsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsDonorIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsAuctionIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsAuctionNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsItemTypeIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsCreateDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsModifiedDateColumn;
    }
}