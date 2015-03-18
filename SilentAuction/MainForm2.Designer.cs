namespace SilentAuction
{
    partial class MainForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm2));
            this.ItemsTabControl = new System.Windows.Forms.TabControl();
            this.ItemsTabPage = new System.Windows.Forms.TabPage();
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
            this.ItemsToolStrip = new System.Windows.Forms.ToolStrip();
            this.ItemsToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.ItemsToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddItemsButton = new System.Windows.Forms.Button();
            this.ItemsSaveAllButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ItemsRequirementLabel = new System.Windows.Forms.Label();
            this.DonorsTabPage = new System.Windows.Forms.TabPage();
            this.DonorsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DonorsDataGridView = new System.Windows.Forms.DataGridView();
            this.donorTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddDonorButton = new System.Windows.Forms.Button();
            this.DonorsSaveAllButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DonorsRequirementLabel = new System.Windows.Forms.Label();
            this.AuctionsTabPage = new System.Windows.Forms.TabPage();
            this.AuctionsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AuctionsDataGridView = new System.Windows.Forms.DataGridView();
            this.AuctionsNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuctionsDescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuctionsCreateDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuctionsModifiedDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuctionsIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auctionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.AddAuctionButton = new System.Windows.Forms.Button();
            this.AuctionsSaveAllChangesButton = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.AuctionsRequirementLabel = new System.Windows.Forms.Label();
            this.itemsTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.ItemsTableAdapter();
            this.donorsTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.DonorsTableAdapter();
            this.auctionsTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.AuctionsTableAdapter();
            this.donorTypesTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.DonorTypesTableAdapter();
            this.bidIncrementTypesTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.BidIncrementTypesTableAdapter();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.MainFormStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewAuctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewDonorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.PrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DonorsDonorTypeColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DonorsNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonorsContactNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonorsStreet1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonorsStreet2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonorsCityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonorsStateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonorsZipCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonorsPhone1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonorsExt1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonorsPhone2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonorsExt2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonorsEmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonorsCreateDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonorsModifiedDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonorsIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsTabControl.SuspendLayout();
            this.ItemsTabPage.SuspendLayout();
            this.ItemsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bidIncrementTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.ItemsToolStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.DonorsTabPage.SuspendLayout();
            this.DonorsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DonorsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorTypesBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.AuctionsTabPage.SuspendLayout();
            this.AuctionsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AuctionsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionsBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemsTabControl
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ItemsTabControl, 2);
            this.ItemsTabControl.Controls.Add(this.ItemsTabPage);
            this.ItemsTabControl.Controls.Add(this.DonorsTabPage);
            this.ItemsTabControl.Controls.Add(this.AuctionsTabPage);
            this.ItemsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsTabControl.Location = new System.Drawing.Point(3, 27);
            this.ItemsTabControl.Name = "ItemsTabControl";
            this.ItemsTabControl.SelectedIndex = 0;
            this.ItemsTabControl.Size = new System.Drawing.Size(868, 384);
            this.ItemsTabControl.TabIndex = 0;
            // 
            // ItemsTabPage
            // 
            this.ItemsTabPage.Controls.Add(this.ItemsTableLayoutPanel);
            this.ItemsTabPage.Location = new System.Drawing.Point(4, 22);
            this.ItemsTabPage.Name = "ItemsTabPage";
            this.ItemsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ItemsTabPage.Size = new System.Drawing.Size(860, 358);
            this.ItemsTabPage.TabIndex = 0;
            this.ItemsTabPage.Text = "Items";
            this.ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // ItemsTableLayoutPanel
            // 
            this.ItemsTableLayoutPanel.ColumnCount = 2;
            this.ItemsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ItemsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ItemsTableLayoutPanel.Controls.Add(this.ItemsDataGridView, 0, 1);
            this.ItemsTableLayoutPanel.Controls.Add(this.ItemsToolStrip, 0, 0);
            this.ItemsTableLayoutPanel.Controls.Add(this.panel1, 0, 2);
            this.ItemsTableLayoutPanel.Controls.Add(this.panel4, 0, 3);
            this.ItemsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.ItemsTableLayoutPanel.Name = "ItemsTableLayoutPanel";
            this.ItemsTableLayoutPanel.RowCount = 4;
            this.ItemsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ItemsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ItemsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ItemsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ItemsTableLayoutPanel.Size = new System.Drawing.Size(854, 352);
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
            this.ItemsDataGridView.Location = new System.Drawing.Point(3, 43);
            this.ItemsDataGridView.Name = "ItemsDataGridView";
            this.ItemsDataGridView.Size = new System.Drawing.Size(848, 246);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.ItemsQtyColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.ItemsQtyColumn.HeaderText = "* Qty";
            this.ItemsQtyColumn.Name = "ItemsQtyColumn";
            this.ItemsQtyColumn.Width = 55;
            // 
            // ItemsItemDescriptionColumn
            // 
            this.ItemsItemDescriptionColumn.DataPropertyName = "Description";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsItemDescriptionColumn.DefaultCellStyle = dataGridViewCellStyle2;
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
            // ItemsRetailValueColumn
            // 
            this.ItemsRetailValueColumn.DataPropertyName = "RetailValue";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            this.ItemsRetailValueColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.ItemsRetailValueColumn.HeaderText = "Retail Value";
            this.ItemsRetailValueColumn.Name = "ItemsRetailValueColumn";
            this.ItemsRetailValueColumn.Width = 90;
            // 
            // ItemsBidBuyItNowValueColumn
            // 
            this.ItemsBidBuyItNowValueColumn.DataPropertyName = "BidBuyItNowValue";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C2";
            this.ItemsBidBuyItNowValueColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.ItemsBidBuyItNowValueColumn.HeaderText = "Buy It Now Amount";
            this.ItemsBidBuyItNowValueColumn.Name = "ItemsBidBuyItNowValueColumn";
            this.ItemsBidBuyItNowValueColumn.Width = 140;
            // 
            // ItemsBidIncrementTypeColumn
            // 
            this.ItemsBidIncrementTypeColumn.DataPropertyName = "BidIncrementTypeId";
            this.ItemsBidIncrementTypeColumn.DataSource = this.bidIncrementTypesBindingSource;
            this.ItemsBidIncrementTypeColumn.DisplayMember = "Name";
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.ItemsBidMinValueColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.ItemsBidMinValueColumn.HeaderText = "Minimum Bid";
            this.ItemsBidMinValueColumn.Name = "ItemsBidMinValueColumn";
            this.ItemsBidMinValueColumn.Width = 95;
            // 
            // ItemsBidMaxValueColumn
            // 
            this.ItemsBidMaxValueColumn.DataPropertyName = "BidMaxValue";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "C2";
            this.ItemsBidMaxValueColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.ItemsBidMaxValueColumn.HeaderText = "Maximum Bid";
            this.ItemsBidMaxValueColumn.Name = "ItemsBidMaxValueColumn";
            this.ItemsBidMaxValueColumn.Width = 95;
            // 
            // ItemsBidIncrementValueColumn
            // 
            this.ItemsBidIncrementValueColumn.DataPropertyName = "BidIncrementValue";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "C2";
            this.ItemsBidIncrementValueColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.ItemsBidIncrementValueColumn.HeaderText = "Bid Incr";
            this.ItemsBidIncrementValueColumn.Name = "ItemsBidIncrementValueColumn";
            this.ItemsBidIncrementValueColumn.Width = 70;
            // 
            // ItemsBidNumberOfBidsColumn
            // 
            this.ItemsBidNumberOfBidsColumn.DataPropertyName = "BidNumberOfBids";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.NullValue = null;
            this.ItemsBidNumberOfBidsColumn.DefaultCellStyle = dataGridViewCellStyle8;
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
            // ItemsToolStrip
            // 
            this.ItemsToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.ItemsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemsToolStripLabel,
            this.ItemsToolStripComboBox});
            this.ItemsToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ItemsToolStrip.Name = "ItemsToolStrip";
            this.ItemsToolStrip.Size = new System.Drawing.Size(316, 25);
            this.ItemsToolStrip.TabIndex = 1;
            this.ItemsToolStrip.Text = "toolStrip1";
            // 
            // ItemsToolStripLabel
            // 
            this.ItemsToolStripLabel.Name = "ItemsToolStripLabel";
            this.ItemsToolStripLabel.Size = new System.Drawing.Size(102, 22);
            this.ItemsToolStripLabel.Text = "Select an Auction:";
            // 
            // ItemsToolStripComboBox
            // 
            this.ItemsToolStripComboBox.DropDownWidth = 200;
            this.ItemsToolStripComboBox.Name = "ItemsToolStripComboBox";
            this.ItemsToolStripComboBox.Size = new System.Drawing.Size(200, 25);
            this.ItemsToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.ItemsToolStripComboBoxSelectedIndexChanged);
            // 
            // panel1
            // 
            this.ItemsTableLayoutPanel.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.AddItemsButton);
            this.panel1.Controls.Add(this.ItemsSaveAllButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 295);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 34);
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
            this.panel4.Location = new System.Drawing.Point(3, 335);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(848, 14);
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
            // DonorsTabPage
            // 
            this.DonorsTabPage.Controls.Add(this.DonorsTableLayoutPanel);
            this.DonorsTabPage.Location = new System.Drawing.Point(4, 22);
            this.DonorsTabPage.Name = "DonorsTabPage";
            this.DonorsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DonorsTabPage.Size = new System.Drawing.Size(860, 358);
            this.DonorsTabPage.TabIndex = 1;
            this.DonorsTabPage.Text = "Donors";
            this.DonorsTabPage.UseVisualStyleBackColor = true;
            // 
            // DonorsTableLayoutPanel
            // 
            this.DonorsTableLayoutPanel.ColumnCount = 2;
            this.DonorsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DonorsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DonorsTableLayoutPanel.Controls.Add(this.DonorsDataGridView, 0, 1);
            this.DonorsTableLayoutPanel.Controls.Add(this.panel2, 0, 2);
            this.DonorsTableLayoutPanel.Controls.Add(this.panel5, 0, 3);
            this.DonorsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DonorsTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.DonorsTableLayoutPanel.Name = "DonorsTableLayoutPanel";
            this.DonorsTableLayoutPanel.RowCount = 4;
            this.DonorsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.DonorsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DonorsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.DonorsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DonorsTableLayoutPanel.Size = new System.Drawing.Size(854, 352);
            this.DonorsTableLayoutPanel.TabIndex = 0;
            // 
            // DonorsDataGridView
            // 
            this.DonorsDataGridView.AllowUserToDeleteRows = false;
            this.DonorsDataGridView.AutoGenerateColumns = false;
            this.DonorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DonorsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DonorsDonorTypeColumn,
            this.DonorsNameColumn,
            this.DonorsContactNameColumn,
            this.DonorsStreet1Column,
            this.DonorsStreet2Column,
            this.DonorsCityColumn,
            this.DonorsStateColumn,
            this.DonorsZipCodeColumn,
            this.DonorsPhone1Column,
            this.DonorsExt1Column,
            this.DonorsPhone2Column,
            this.DonorsExt2Column,
            this.DonorsEmailColumn,
            this.DonorsCreateDateColumn,
            this.DonorsModifiedDateColumn,
            this.DonorsIdColumn});
            this.DonorsTableLayoutPanel.SetColumnSpan(this.DonorsDataGridView, 2);
            this.DonorsDataGridView.DataSource = this.donorsBindingSource;
            this.DonorsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DonorsDataGridView.Location = new System.Drawing.Point(3, 43);
            this.DonorsDataGridView.Name = "DonorsDataGridView";
            this.DonorsDataGridView.Size = new System.Drawing.Size(848, 246);
            this.DonorsDataGridView.TabIndex = 0;
            this.DonorsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DonorsDataGridViewCellClick);
            this.DonorsDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DonorsDataGridViewDataError);
            this.DonorsDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.DonorsDataGridViewDefaultValuesNeeded);
            // 
            // donorTypesBindingSource
            // 
            this.donorTypesBindingSource.DataMember = "DonorTypes";
            this.donorTypesBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // panel2
            // 
            this.DonorsTableLayoutPanel.SetColumnSpan(this.panel2, 2);
            this.panel2.Controls.Add(this.AddDonorButton);
            this.panel2.Controls.Add(this.DonorsSaveAllButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 295);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(848, 34);
            this.panel2.TabIndex = 2;
            // 
            // AddDonorButton
            // 
            this.AddDonorButton.AutoSize = true;
            this.AddDonorButton.Location = new System.Drawing.Point(110, 3);
            this.AddDonorButton.Name = "AddDonorButton";
            this.AddDonorButton.Size = new System.Drawing.Size(101, 23);
            this.AddDonorButton.TabIndex = 2;
            this.AddDonorButton.Text = "Add Donor";
            this.AddDonorButton.UseVisualStyleBackColor = true;
            this.AddDonorButton.Click += new System.EventHandler(this.AddDonorButtonClick);
            // 
            // DonorsSaveAllButton
            // 
            this.DonorsSaveAllButton.AutoSize = true;
            this.DonorsSaveAllButton.Location = new System.Drawing.Point(3, 3);
            this.DonorsSaveAllButton.Name = "DonorsSaveAllButton";
            this.DonorsSaveAllButton.Size = new System.Drawing.Size(101, 23);
            this.DonorsSaveAllButton.TabIndex = 1;
            this.DonorsSaveAllButton.Text = "Save Changes";
            this.DonorsSaveAllButton.UseVisualStyleBackColor = true;
            this.DonorsSaveAllButton.Click += new System.EventHandler(this.DonorsSaveAllButtonClick);
            // 
            // panel5
            // 
            this.DonorsTableLayoutPanel.SetColumnSpan(this.panel5, 2);
            this.panel5.Controls.Add(this.DonorsRequirementLabel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 335);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(848, 14);
            this.panel5.TabIndex = 3;
            // 
            // DonorsRequirementLabel
            // 
            this.DonorsRequirementLabel.AutoSize = true;
            this.DonorsRequirementLabel.Location = new System.Drawing.Point(3, 0);
            this.DonorsRequirementLabel.Name = "DonorsRequirementLabel";
            this.DonorsRequirementLabel.Size = new System.Drawing.Size(218, 13);
            this.DonorsRequirementLabel.TabIndex = 4;
            this.DonorsRequirementLabel.Text = "Items marked with an asterisk (*) are required";
            // 
            // AuctionsTabPage
            // 
            this.AuctionsTabPage.Controls.Add(this.AuctionsTableLayoutPanel);
            this.AuctionsTabPage.Location = new System.Drawing.Point(4, 22);
            this.AuctionsTabPage.Name = "AuctionsTabPage";
            this.AuctionsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AuctionsTabPage.Size = new System.Drawing.Size(860, 358);
            this.AuctionsTabPage.TabIndex = 2;
            this.AuctionsTabPage.Text = "Auctions";
            this.AuctionsTabPage.UseVisualStyleBackColor = true;
            // 
            // AuctionsTableLayoutPanel
            // 
            this.AuctionsTableLayoutPanel.ColumnCount = 2;
            this.AuctionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AuctionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AuctionsTableLayoutPanel.Controls.Add(this.AuctionsDataGridView, 0, 1);
            this.AuctionsTableLayoutPanel.Controls.Add(this.panel3, 0, 2);
            this.AuctionsTableLayoutPanel.Controls.Add(this.panel6, 0, 3);
            this.AuctionsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuctionsTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.AuctionsTableLayoutPanel.Name = "AuctionsTableLayoutPanel";
            this.AuctionsTableLayoutPanel.RowCount = 4;
            this.AuctionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.AuctionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AuctionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.AuctionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AuctionsTableLayoutPanel.Size = new System.Drawing.Size(854, 352);
            this.AuctionsTableLayoutPanel.TabIndex = 0;
            // 
            // AuctionsDataGridView
            // 
            this.AuctionsDataGridView.AllowUserToDeleteRows = false;
            this.AuctionsDataGridView.AutoGenerateColumns = false;
            this.AuctionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AuctionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AuctionsNameColumn,
            this.AuctionsDescriptionColumn,
            this.AuctionsCreateDateColumn,
            this.AuctionsModifiedDateColumn,
            this.AuctionsIdColumn});
            this.AuctionsTableLayoutPanel.SetColumnSpan(this.AuctionsDataGridView, 2);
            this.AuctionsDataGridView.DataSource = this.auctionsBindingSource;
            this.AuctionsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuctionsDataGridView.Location = new System.Drawing.Point(3, 43);
            this.AuctionsDataGridView.Name = "AuctionsDataGridView";
            this.AuctionsDataGridView.Size = new System.Drawing.Size(848, 246);
            this.AuctionsDataGridView.TabIndex = 0;
            this.AuctionsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AuctionsDataGridViewCellClick);
            this.AuctionsDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.AuctionsDataGridViewDataError);
            this.AuctionsDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.AuctionsDataGridViewDefaultValuesNeeded);
            // 
            // AuctionsNameColumn
            // 
            this.AuctionsNameColumn.DataPropertyName = "Name";
            this.AuctionsNameColumn.HeaderText = "* Auction Name";
            this.AuctionsNameColumn.Name = "AuctionsNameColumn";
            this.AuctionsNameColumn.Width = 200;
            // 
            // AuctionsDescriptionColumn
            // 
            this.AuctionsDescriptionColumn.DataPropertyName = "Description";
            this.AuctionsDescriptionColumn.HeaderText = "Auction Description";
            this.AuctionsDescriptionColumn.Name = "AuctionsDescriptionColumn";
            this.AuctionsDescriptionColumn.Width = 400;
            // 
            // AuctionsCreateDateColumn
            // 
            this.AuctionsCreateDateColumn.DataPropertyName = "CreateDate";
            this.AuctionsCreateDateColumn.HeaderText = "CreateDate";
            this.AuctionsCreateDateColumn.Name = "AuctionsCreateDateColumn";
            this.AuctionsCreateDateColumn.Visible = false;
            // 
            // AuctionsModifiedDateColumn
            // 
            this.AuctionsModifiedDateColumn.DataPropertyName = "ModifiedDate";
            this.AuctionsModifiedDateColumn.HeaderText = "ModifiedDate";
            this.AuctionsModifiedDateColumn.Name = "AuctionsModifiedDateColumn";
            this.AuctionsModifiedDateColumn.Visible = false;
            // 
            // AuctionsIdColumn
            // 
            this.AuctionsIdColumn.DataPropertyName = "Id";
            this.AuctionsIdColumn.HeaderText = "Id";
            this.AuctionsIdColumn.Name = "AuctionsIdColumn";
            this.AuctionsIdColumn.ReadOnly = true;
            this.AuctionsIdColumn.Visible = false;
            // 
            // auctionsBindingSource
            // 
            this.auctionsBindingSource.DataMember = "Auctions";
            this.auctionsBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // panel3
            // 
            this.AuctionsTableLayoutPanel.SetColumnSpan(this.panel3, 2);
            this.panel3.Controls.Add(this.AddAuctionButton);
            this.panel3.Controls.Add(this.AuctionsSaveAllChangesButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 295);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(848, 34);
            this.panel3.TabIndex = 2;
            // 
            // AddAuctionButton
            // 
            this.AddAuctionButton.AutoSize = true;
            this.AddAuctionButton.Location = new System.Drawing.Point(110, 3);
            this.AddAuctionButton.Name = "AddAuctionButton";
            this.AddAuctionButton.Size = new System.Drawing.Size(101, 23);
            this.AddAuctionButton.TabIndex = 2;
            this.AddAuctionButton.Text = "Add Auction";
            this.AddAuctionButton.UseVisualStyleBackColor = true;
            this.AddAuctionButton.Click += new System.EventHandler(this.AddAuctionButtonClick);
            // 
            // AuctionsSaveAllChangesButton
            // 
            this.AuctionsSaveAllChangesButton.AutoSize = true;
            this.AuctionsSaveAllChangesButton.Location = new System.Drawing.Point(3, 3);
            this.AuctionsSaveAllChangesButton.Name = "AuctionsSaveAllChangesButton";
            this.AuctionsSaveAllChangesButton.Size = new System.Drawing.Size(101, 23);
            this.AuctionsSaveAllChangesButton.TabIndex = 1;
            this.AuctionsSaveAllChangesButton.Text = "Save Changes";
            this.AuctionsSaveAllChangesButton.UseVisualStyleBackColor = true;
            this.AuctionsSaveAllChangesButton.Click += new System.EventHandler(this.AuctionsSaveAllButtonClick);
            // 
            // panel6
            // 
            this.AuctionsTableLayoutPanel.SetColumnSpan(this.panel6, 2);
            this.panel6.Controls.Add(this.AuctionsRequirementLabel);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 335);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(848, 14);
            this.panel6.TabIndex = 3;
            // 
            // AuctionsRequirementLabel
            // 
            this.AuctionsRequirementLabel.AutoSize = true;
            this.AuctionsRequirementLabel.Location = new System.Drawing.Point(3, 0);
            this.AuctionsRequirementLabel.Name = "AuctionsRequirementLabel";
            this.AuctionsRequirementLabel.Size = new System.Drawing.Size(218, 13);
            this.AuctionsRequirementLabel.TabIndex = 5;
            this.AuctionsRequirementLabel.Text = "Items marked with an asterisk (*) are required";
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
            // donorTypesTableAdapter
            // 
            this.donorTypesTableAdapter.ClearBeforeFill = true;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ItemsTabControl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(874, 414);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.menuStrip1, 2);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(874, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator,
            this.SaveToolStripMenuItem,
            this.toolStripSeparator1,
            this.PrintToolStripMenuItem,
            this.PrintPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.ExitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewAuctionToolStripMenuItem,
            this.AddNewDonorToolStripMenuItem,
            this.AddNewItemToolStripMenuItem});
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // AddNewAuctionToolStripMenuItem
            // 
            this.AddNewAuctionToolStripMenuItem.Name = "AddNewAuctionToolStripMenuItem";
            this.AddNewAuctionToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.AddNewAuctionToolStripMenuItem.Text = "Add New Auction";
            this.AddNewAuctionToolStripMenuItem.Click += new System.EventHandler(this.NewAuctionToolStripMenuItemClick);
            // 
            // AddNewDonorToolStripMenuItem
            // 
            this.AddNewDonorToolStripMenuItem.Name = "AddNewDonorToolStripMenuItem";
            this.AddNewDonorToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.AddNewDonorToolStripMenuItem.Text = "Add New Donor";
            this.AddNewDonorToolStripMenuItem.Click += new System.EventHandler(this.AddNewDonorToolStripMenuItemClick);
            // 
            // AddNewItemToolStripMenuItem
            // 
            this.AddNewItemToolStripMenuItem.Name = "AddNewItemToolStripMenuItem";
            this.AddNewItemToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.AddNewItemToolStripMenuItem.Text = "Add New Item";
            this.AddNewItemToolStripMenuItem.Click += new System.EventHandler(this.AddNewItemToolStripMenuItemClick);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(140, 6);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SaveToolStripMenuItem.Image")));
            this.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.SaveToolStripMenuItem.Text = "&Save";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItemClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(140, 6);
            // 
            // PrintToolStripMenuItem
            // 
            this.PrintToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("PrintToolStripMenuItem.Image")));
            this.PrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem";
            this.PrintToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.PrintToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.PrintToolStripMenuItem.Text = "&Print";
            this.PrintToolStripMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItemClick);
            // 
            // PrintPreviewToolStripMenuItem
            // 
            this.PrintPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("PrintPreviewToolStripMenuItem.Image")));
            this.PrintPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem";
            this.PrintPreviewToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.PrintPreviewToolStripMenuItem.Text = "Print Pre&view";
            this.PrintPreviewToolStripMenuItem.Click += new System.EventHandler(this.PrintPreviewToolStripMenuItemClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(140, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.ExitToolStripMenuItem.Text = "E&xit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
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
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.AboutToolStripMenuItem});
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
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.AboutToolStripMenuItem.Text = "&About...";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
            // 
            // DonorsDonorTypeColumn
            // 
            this.DonorsDonorTypeColumn.DataPropertyName = "DonorTypeId";
            this.DonorsDonorTypeColumn.DataSource = this.donorTypesBindingSource;
            this.DonorsDonorTypeColumn.DisplayMember = "Name";
            this.DonorsDonorTypeColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DonorsDonorTypeColumn.HeaderText = "* Donor Type";
            this.DonorsDonorTypeColumn.Name = "DonorsDonorTypeColumn";
            this.DonorsDonorTypeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DonorsDonorTypeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DonorsDonorTypeColumn.ValueMember = "Id";
            // 
            // DonorsNameColumn
            // 
            this.DonorsNameColumn.DataPropertyName = "Name";
            this.DonorsNameColumn.HeaderText = "* Donor Name";
            this.DonorsNameColumn.Name = "DonorsNameColumn";
            // 
            // DonorsContactNameColumn
            // 
            this.DonorsContactNameColumn.DataPropertyName = "ContactName";
            this.DonorsContactNameColumn.HeaderText = "Contact Name";
            this.DonorsContactNameColumn.Name = "DonorsContactNameColumn";
            // 
            // DonorsStreet1Column
            // 
            this.DonorsStreet1Column.DataPropertyName = "Street1";
            this.DonorsStreet1Column.HeaderText = "Street 1";
            this.DonorsStreet1Column.Name = "DonorsStreet1Column";
            // 
            // DonorsStreet2Column
            // 
            this.DonorsStreet2Column.DataPropertyName = "Street2";
            this.DonorsStreet2Column.HeaderText = "Street 2";
            this.DonorsStreet2Column.Name = "DonorsStreet2Column";
            // 
            // DonorsCityColumn
            // 
            this.DonorsCityColumn.DataPropertyName = "City";
            this.DonorsCityColumn.HeaderText = "City";
            this.DonorsCityColumn.Name = "DonorsCityColumn";
            // 
            // DonorsStateColumn
            // 
            this.DonorsStateColumn.DataPropertyName = "State";
            this.DonorsStateColumn.HeaderText = "State";
            this.DonorsStateColumn.Name = "DonorsStateColumn";
            // 
            // DonorsZipCodeColumn
            // 
            this.DonorsZipCodeColumn.DataPropertyName = "ZipCode";
            this.DonorsZipCodeColumn.HeaderText = "Zip Code";
            this.DonorsZipCodeColumn.Name = "DonorsZipCodeColumn";
            // 
            // DonorsPhone1Column
            // 
            this.DonorsPhone1Column.DataPropertyName = "Phone1";
            this.DonorsPhone1Column.HeaderText = "Phone 1";
            this.DonorsPhone1Column.Name = "DonorsPhone1Column";
            // 
            // DonorsExt1Column
            // 
            this.DonorsExt1Column.DataPropertyName = "Extension1";
            this.DonorsExt1Column.HeaderText = "Ext 1";
            this.DonorsExt1Column.Name = "DonorsExt1Column";
            // 
            // DonorsPhone2Column
            // 
            this.DonorsPhone2Column.DataPropertyName = "Phone2";
            this.DonorsPhone2Column.HeaderText = "Phone 2";
            this.DonorsPhone2Column.Name = "DonorsPhone2Column";
            // 
            // DonorsExt2Column
            // 
            this.DonorsExt2Column.DataPropertyName = "Extension2";
            this.DonorsExt2Column.HeaderText = "Ext 2";
            this.DonorsExt2Column.Name = "DonorsExt2Column";
            // 
            // DonorsEmailColumn
            // 
            this.DonorsEmailColumn.DataPropertyName = "Email";
            this.DonorsEmailColumn.HeaderText = "Email";
            this.DonorsEmailColumn.Name = "DonorsEmailColumn";
            // 
            // DonorsCreateDateColumn
            // 
            this.DonorsCreateDateColumn.DataPropertyName = "CreateDate";
            this.DonorsCreateDateColumn.HeaderText = "CreateDate";
            this.DonorsCreateDateColumn.Name = "DonorsCreateDateColumn";
            this.DonorsCreateDateColumn.Visible = false;
            // 
            // DonorsModifiedDateColumn
            // 
            this.DonorsModifiedDateColumn.DataPropertyName = "ModifiedDate";
            this.DonorsModifiedDateColumn.HeaderText = "ModifiedDate";
            this.DonorsModifiedDateColumn.Name = "DonorsModifiedDateColumn";
            this.DonorsModifiedDateColumn.Visible = false;
            // 
            // DonorsIdColumn
            // 
            this.DonorsIdColumn.DataPropertyName = "Id";
            this.DonorsIdColumn.HeaderText = "Id";
            this.DonorsIdColumn.Name = "DonorsIdColumn";
            this.DonorsIdColumn.Visible = false;
            // 
            // MainForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 436);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm2";
            this.Text = "Silent Auction";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm2FormClosing);
            this.Load += new System.EventHandler(this.MainForm2Load);
            this.ItemsTabControl.ResumeLayout(false);
            this.ItemsTabPage.ResumeLayout(false);
            this.ItemsTableLayoutPanel.ResumeLayout(false);
            this.ItemsTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bidIncrementTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.ItemsToolStrip.ResumeLayout(false);
            this.ItemsToolStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.DonorsTabPage.ResumeLayout(false);
            this.DonorsTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DonorsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorTypesBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.AuctionsTabPage.ResumeLayout(false);
            this.AuctionsTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AuctionsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionsBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl ItemsTabControl;
        private System.Windows.Forms.TabPage ItemsTabPage;
        private System.Windows.Forms.TabPage DonorsTabPage;
        private System.Windows.Forms.DataGridView ItemsDataGridView;
        private System.Windows.Forms.TabPage AuctionsTabPage;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private SilentAuctionDataSet silentAuctionDataSet;
        private SilentAuctionDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.ToolStrip ItemsToolStrip;
        private System.Windows.Forms.ToolStripLabel ItemsToolStripLabel;
        private System.Windows.Forms.ToolStripComboBox ItemsToolStripComboBox;
        private System.Windows.Forms.Button ItemsSaveAllButton;
        private System.Windows.Forms.TableLayoutPanel ItemsTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel DonorsTableLayoutPanel;
        private System.Windows.Forms.DataGridView DonorsDataGridView;
        private System.Windows.Forms.BindingSource donorsBindingSource;
        private SilentAuctionDataSetTableAdapters.DonorsTableAdapter donorsTableAdapter;
        private System.Windows.Forms.Button DonorsSaveAllButton;
        private System.Windows.Forms.TableLayoutPanel AuctionsTableLayoutPanel;
        private System.Windows.Forms.DataGridView AuctionsDataGridView;
        private System.Windows.Forms.BindingSource auctionsBindingSource;
        private SilentAuctionDataSetTableAdapters.AuctionsTableAdapter auctionsTableAdapter;
        private System.Windows.Forms.Button AuctionsSaveAllChangesButton;
        private System.Windows.Forms.BindingSource donorTypesBindingSource;
        private SilentAuctionDataSetTableAdapters.DonorTypesTableAdapter donorTypesTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ItemsRequirementLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label DonorsRequirementLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuctionsNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuctionsDescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuctionsCreateDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuctionsModifiedDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuctionsIdColumn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label AuctionsRequirementLabel;
        private System.Windows.Forms.BindingSource bidIncrementTypesBindingSource;
        private SilentAuctionDataSetTableAdapters.BidIncrementTypesTableAdapter bidIncrementTypesTableAdapter;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel MainFormStatusLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem PrintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrintPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNewAuctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNewDonorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNewItemToolStripMenuItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button AddItemsButton;
        private System.Windows.Forms.Button AddDonorButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button AddAuctionButton;
        private System.Windows.Forms.DataGridViewComboBoxColumn ItemsDonorIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsAuctionIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsQtyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsItemDescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsNotesColumn;
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
        private System.Windows.Forms.DataGridViewComboBoxColumn DonorsDonorTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonorsNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonorsContactNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonorsStreet1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonorsStreet2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonorsCityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonorsStateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonorsZipCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonorsPhone1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonorsExt1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonorsPhone2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonorsExt2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonorsEmailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonorsCreateDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonorsModifiedDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonorsIdColumn;
    }
}