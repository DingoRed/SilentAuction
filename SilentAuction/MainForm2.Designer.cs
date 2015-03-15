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
            this.ItemsTabControl = new System.Windows.Forms.TabControl();
            this.ItemsTabPage = new System.Windows.Forms.TabPage();
            this.ItemsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ItemsSaveAllButton = new System.Windows.Forms.Button();
            this.ItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.idItemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auctionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.donorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.silentAuctionDataSet = new SilentAuction.SilentAuctionDataSet();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifiedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ItemsToolStrip = new System.Windows.Forms.ToolStrip();
            this.ItemsToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.ItemsToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.DonorsTabPage = new System.Windows.Forms.TabPage();
            this.DonorsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DonorsDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.street1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.street2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extension1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extension2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonorsSaveAllButton = new System.Windows.Forms.Button();
            this.AuctionsTabPage = new System.Windows.Forms.TabPage();
            this.AuctionsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AuctionsDataGridView = new System.Windows.Forms.DataGridView();
            this.auctionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AuctionsSaveAllChangesButton = new System.Windows.Forms.Button();
            this.itemsTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.ItemsTableAdapter();
            this.donorsTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.DonorsTableAdapter();
            this.auctionsTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.AuctionsTableAdapter();
            this.AuctionsIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuctionsNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuctionsDescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuctionsCreateDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuctionsModifiedDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsTabControl.SuspendLayout();
            this.ItemsTabPage.SuspendLayout();
            this.ItemsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.ItemsToolStrip.SuspendLayout();
            this.DonorsTabPage.SuspendLayout();
            this.DonorsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DonorsDataGridView)).BeginInit();
            this.AuctionsTabPage.SuspendLayout();
            this.AuctionsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AuctionsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemsTabControl
            // 
            this.ItemsTabControl.Controls.Add(this.ItemsTabPage);
            this.ItemsTabControl.Controls.Add(this.DonorsTabPage);
            this.ItemsTabControl.Controls.Add(this.AuctionsTabPage);
            this.ItemsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsTabControl.Location = new System.Drawing.Point(0, 0);
            this.ItemsTabControl.Name = "ItemsTabControl";
            this.ItemsTabControl.SelectedIndex = 0;
            this.ItemsTabControl.Size = new System.Drawing.Size(874, 420);
            this.ItemsTabControl.TabIndex = 0;
            // 
            // ItemsTabPage
            // 
            this.ItemsTabPage.Controls.Add(this.ItemsTableLayoutPanel);
            this.ItemsTabPage.Location = new System.Drawing.Point(4, 22);
            this.ItemsTabPage.Name = "ItemsTabPage";
            this.ItemsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ItemsTabPage.Size = new System.Drawing.Size(866, 394);
            this.ItemsTabPage.TabIndex = 0;
            this.ItemsTabPage.Text = "Items";
            this.ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // ItemsTableLayoutPanel
            // 
            this.ItemsTableLayoutPanel.ColumnCount = 2;
            this.ItemsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ItemsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ItemsTableLayoutPanel.Controls.Add(this.ItemsSaveAllButton, 0, 2);
            this.ItemsTableLayoutPanel.Controls.Add(this.ItemsDataGridView, 0, 1);
            this.ItemsTableLayoutPanel.Controls.Add(this.ItemsToolStrip, 0, 0);
            this.ItemsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.ItemsTableLayoutPanel.Name = "ItemsTableLayoutPanel";
            this.ItemsTableLayoutPanel.RowCount = 3;
            this.ItemsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ItemsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ItemsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ItemsTableLayoutPanel.Size = new System.Drawing.Size(860, 388);
            this.ItemsTableLayoutPanel.TabIndex = 3;
            // 
            // ItemsSaveAllButton
            // 
            this.ItemsSaveAllButton.AutoSize = true;
            this.ItemsSaveAllButton.Location = new System.Drawing.Point(3, 351);
            this.ItemsSaveAllButton.Name = "ItemsSaveAllButton";
            this.ItemsSaveAllButton.Size = new System.Drawing.Size(101, 23);
            this.ItemsSaveAllButton.TabIndex = 2;
            this.ItemsSaveAllButton.Text = "Save All Changes";
            this.ItemsSaveAllButton.UseVisualStyleBackColor = true;
            this.ItemsSaveAllButton.Click += new System.EventHandler(this.ItemsSaveAllButtonClick);
            // 
            // ItemsDataGridView
            // 
            this.ItemsDataGridView.AutoGenerateColumns = false;
            this.ItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idItemsDataGridViewTextBoxColumn,
            this.donorIdDataGridViewTextBoxColumn,
            this.auctionIdDataGridViewTextBoxColumn,
            this.donorNameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.CreateDate,
            this.ModifiedDate});
            this.ItemsTableLayoutPanel.SetColumnSpan(this.ItemsDataGridView, 2);
            this.ItemsDataGridView.DataSource = this.itemsBindingSource;
            this.ItemsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsDataGridView.Location = new System.Drawing.Point(3, 43);
            this.ItemsDataGridView.Name = "ItemsDataGridView";
            this.ItemsDataGridView.Size = new System.Drawing.Size(854, 302);
            this.ItemsDataGridView.TabIndex = 0;
            this.ItemsDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.ItemsDataGridViewDataError);
            // 
            // idItemsDataGridViewTextBoxColumn
            // 
            this.idItemsDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idItemsDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idItemsDataGridViewTextBoxColumn.Name = "idItemsDataGridViewTextBoxColumn";
            this.idItemsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // donorIdDataGridViewTextBoxColumn
            // 
            this.donorIdDataGridViewTextBoxColumn.DataPropertyName = "DonorId";
            this.donorIdDataGridViewTextBoxColumn.HeaderText = "DonorId";
            this.donorIdDataGridViewTextBoxColumn.Name = "donorIdDataGridViewTextBoxColumn";
            // 
            // auctionIdDataGridViewTextBoxColumn
            // 
            this.auctionIdDataGridViewTextBoxColumn.DataPropertyName = "AuctionId";
            this.auctionIdDataGridViewTextBoxColumn.HeaderText = "AuctionId";
            this.auctionIdDataGridViewTextBoxColumn.Name = "auctionIdDataGridViewTextBoxColumn";
            // 
            // donorNameDataGridViewTextBoxColumn
            // 
            this.donorNameDataGridViewTextBoxColumn.DataPropertyName = "DonorId";
            this.donorNameDataGridViewTextBoxColumn.DataSource = this.donorsBindingSource;
            this.donorNameDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.donorNameDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.donorNameDataGridViewTextBoxColumn.HeaderText = "DonorName";
            this.donorNameDataGridViewTextBoxColumn.Name = "donorNameDataGridViewTextBoxColumn";
            this.donorNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.donorNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.donorNameDataGridViewTextBoxColumn.ValueMember = "Id";
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
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            // 
            // CreateDate
            // 
            this.CreateDate.DataPropertyName = "CreateDate";
            this.CreateDate.HeaderText = "CreateDate";
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ReadOnly = true;
            // 
            // ModifiedDate
            // 
            this.ModifiedDate.DataPropertyName = "ModifiedDate";
            this.ModifiedDate.HeaderText = "ModifiedDate";
            this.ModifiedDate.Name = "ModifiedDate";
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
            this.ItemsToolStrip.Size = new System.Drawing.Size(266, 25);
            this.ItemsToolStrip.TabIndex = 1;
            this.ItemsToolStrip.Text = "toolStrip1";
            // 
            // ItemsToolStripLabel
            // 
            this.ItemsToolStripLabel.Name = "ItemsToolStripLabel";
            this.ItemsToolStripLabel.Size = new System.Drawing.Size(52, 22);
            this.ItemsToolStripLabel.Text = "Auction:";
            // 
            // ItemsToolStripComboBox
            // 
            this.ItemsToolStripComboBox.DropDownWidth = 200;
            this.ItemsToolStripComboBox.Name = "ItemsToolStripComboBox";
            this.ItemsToolStripComboBox.Size = new System.Drawing.Size(200, 25);
            this.ItemsToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.ItemsToolStripComboBoxSelectedIndexChanged);
            // 
            // DonorsTabPage
            // 
            this.DonorsTabPage.Controls.Add(this.DonorsTableLayoutPanel);
            this.DonorsTabPage.Location = new System.Drawing.Point(4, 22);
            this.DonorsTabPage.Name = "DonorsTabPage";
            this.DonorsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DonorsTabPage.Size = new System.Drawing.Size(866, 394);
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
            this.DonorsTableLayoutPanel.Controls.Add(this.DonorsSaveAllButton, 0, 2);
            this.DonorsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DonorsTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.DonorsTableLayoutPanel.Name = "DonorsTableLayoutPanel";
            this.DonorsTableLayoutPanel.RowCount = 3;
            this.DonorsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.DonorsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DonorsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.DonorsTableLayoutPanel.Size = new System.Drawing.Size(860, 388);
            this.DonorsTableLayoutPanel.TabIndex = 0;
            // 
            // DonorsDataGridView
            // 
            this.DonorsDataGridView.AutoGenerateColumns = false;
            this.DonorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DonorsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.donorTypeIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.contactNameDataGridViewTextBoxColumn,
            this.street1DataGridViewTextBoxColumn,
            this.street2DataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.zipCodeDataGridViewTextBoxColumn,
            this.phone1DataGridViewTextBoxColumn,
            this.extension1DataGridViewTextBoxColumn,
            this.phone2DataGridViewTextBoxColumn,
            this.extension2DataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.modifiedDateDataGridViewTextBoxColumn});
            this.DonorsTableLayoutPanel.SetColumnSpan(this.DonorsDataGridView, 2);
            this.DonorsDataGridView.DataSource = this.donorsBindingSource;
            this.DonorsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DonorsDataGridView.Location = new System.Drawing.Point(3, 43);
            this.DonorsDataGridView.Name = "DonorsDataGridView";
            this.DonorsDataGridView.Size = new System.Drawing.Size(854, 302);
            this.DonorsDataGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // donorTypeIdDataGridViewTextBoxColumn
            // 
            this.donorTypeIdDataGridViewTextBoxColumn.DataPropertyName = "DonorTypeId";
            this.donorTypeIdDataGridViewTextBoxColumn.HeaderText = "DonorTypeId";
            this.donorTypeIdDataGridViewTextBoxColumn.Name = "donorTypeIdDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // contactNameDataGridViewTextBoxColumn
            // 
            this.contactNameDataGridViewTextBoxColumn.DataPropertyName = "ContactName";
            this.contactNameDataGridViewTextBoxColumn.HeaderText = "ContactName";
            this.contactNameDataGridViewTextBoxColumn.Name = "contactNameDataGridViewTextBoxColumn";
            // 
            // street1DataGridViewTextBoxColumn
            // 
            this.street1DataGridViewTextBoxColumn.DataPropertyName = "Street1";
            this.street1DataGridViewTextBoxColumn.HeaderText = "Street1";
            this.street1DataGridViewTextBoxColumn.Name = "street1DataGridViewTextBoxColumn";
            // 
            // street2DataGridViewTextBoxColumn
            // 
            this.street2DataGridViewTextBoxColumn.DataPropertyName = "Street2";
            this.street2DataGridViewTextBoxColumn.HeaderText = "Street2";
            this.street2DataGridViewTextBoxColumn.Name = "street2DataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            // 
            // zipCodeDataGridViewTextBoxColumn
            // 
            this.zipCodeDataGridViewTextBoxColumn.DataPropertyName = "ZipCode";
            this.zipCodeDataGridViewTextBoxColumn.HeaderText = "ZipCode";
            this.zipCodeDataGridViewTextBoxColumn.Name = "zipCodeDataGridViewTextBoxColumn";
            // 
            // phone1DataGridViewTextBoxColumn
            // 
            this.phone1DataGridViewTextBoxColumn.DataPropertyName = "Phone1";
            this.phone1DataGridViewTextBoxColumn.HeaderText = "Phone1";
            this.phone1DataGridViewTextBoxColumn.Name = "phone1DataGridViewTextBoxColumn";
            // 
            // extension1DataGridViewTextBoxColumn
            // 
            this.extension1DataGridViewTextBoxColumn.DataPropertyName = "Extension1";
            this.extension1DataGridViewTextBoxColumn.HeaderText = "Extension1";
            this.extension1DataGridViewTextBoxColumn.Name = "extension1DataGridViewTextBoxColumn";
            // 
            // phone2DataGridViewTextBoxColumn
            // 
            this.phone2DataGridViewTextBoxColumn.DataPropertyName = "Phone2";
            this.phone2DataGridViewTextBoxColumn.HeaderText = "Phone2";
            this.phone2DataGridViewTextBoxColumn.Name = "phone2DataGridViewTextBoxColumn";
            // 
            // extension2DataGridViewTextBoxColumn
            // 
            this.extension2DataGridViewTextBoxColumn.DataPropertyName = "Extension2";
            this.extension2DataGridViewTextBoxColumn.HeaderText = "Extension2";
            this.extension2DataGridViewTextBoxColumn.Name = "extension2DataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            // 
            // modifiedDateDataGridViewTextBoxColumn
            // 
            this.modifiedDateDataGridViewTextBoxColumn.DataPropertyName = "ModifiedDate";
            this.modifiedDateDataGridViewTextBoxColumn.HeaderText = "ModifiedDate";
            this.modifiedDateDataGridViewTextBoxColumn.Name = "modifiedDateDataGridViewTextBoxColumn";
            // 
            // DonorsSaveAllButton
            // 
            this.DonorsSaveAllButton.AutoSize = true;
            this.DonorsSaveAllButton.Location = new System.Drawing.Point(3, 351);
            this.DonorsSaveAllButton.Name = "DonorsSaveAllButton";
            this.DonorsSaveAllButton.Size = new System.Drawing.Size(101, 23);
            this.DonorsSaveAllButton.TabIndex = 1;
            this.DonorsSaveAllButton.Text = "Save All Changes";
            this.DonorsSaveAllButton.UseVisualStyleBackColor = true;
            // 
            // AuctionsTabPage
            // 
            this.AuctionsTabPage.Controls.Add(this.AuctionsTableLayoutPanel);
            this.AuctionsTabPage.Location = new System.Drawing.Point(4, 22);
            this.AuctionsTabPage.Name = "AuctionsTabPage";
            this.AuctionsTabPage.Size = new System.Drawing.Size(866, 394);
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
            this.AuctionsTableLayoutPanel.Controls.Add(this.AuctionsSaveAllChangesButton, 0, 2);
            this.AuctionsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuctionsTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.AuctionsTableLayoutPanel.Name = "AuctionsTableLayoutPanel";
            this.AuctionsTableLayoutPanel.RowCount = 3;
            this.AuctionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.AuctionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AuctionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.AuctionsTableLayoutPanel.Size = new System.Drawing.Size(866, 394);
            this.AuctionsTableLayoutPanel.TabIndex = 0;
            // 
            // AuctionsDataGridView
            // 
            this.AuctionsDataGridView.AutoGenerateColumns = false;
            this.AuctionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AuctionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AuctionsIdColumn,
            this.AuctionsNameColumn,
            this.AuctionsDescriptionColumn,
            this.AuctionsCreateDateColumn,
            this.AuctionsModifiedDateColumn});
            this.AuctionsTableLayoutPanel.SetColumnSpan(this.AuctionsDataGridView, 2);
            this.AuctionsDataGridView.DataSource = this.auctionsBindingSource;
            this.AuctionsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuctionsDataGridView.Location = new System.Drawing.Point(3, 43);
            this.AuctionsDataGridView.Name = "AuctionsDataGridView";
            this.AuctionsDataGridView.Size = new System.Drawing.Size(860, 308);
            this.AuctionsDataGridView.TabIndex = 0;
            this.AuctionsDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.AuctionsDataGridViewDefaultValuesNeeded);
            // 
            // auctionsBindingSource
            // 
            this.auctionsBindingSource.DataMember = "Auctions";
            this.auctionsBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // AuctionsSaveAllChangesButton
            // 
            this.AuctionsSaveAllChangesButton.AutoSize = true;
            this.AuctionsSaveAllChangesButton.Location = new System.Drawing.Point(3, 357);
            this.AuctionsSaveAllChangesButton.Name = "AuctionsSaveAllChangesButton";
            this.AuctionsSaveAllChangesButton.Size = new System.Drawing.Size(101, 23);
            this.AuctionsSaveAllChangesButton.TabIndex = 1;
            this.AuctionsSaveAllChangesButton.Text = "Save All Changes";
            this.AuctionsSaveAllChangesButton.UseVisualStyleBackColor = true;
            this.AuctionsSaveAllChangesButton.Click += new System.EventHandler(this.AuctionsSaveAllChangesButtonClick);
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
            // AuctionsIdColumn
            // 
            this.AuctionsIdColumn.DataPropertyName = "Id";
            this.AuctionsIdColumn.HeaderText = "Id";
            this.AuctionsIdColumn.Name = "AuctionsIdColumn";
            this.AuctionsIdColumn.ReadOnly = true;
            this.AuctionsIdColumn.Visible = false;
            // 
            // AuctionsNameColumn
            // 
            this.AuctionsNameColumn.DataPropertyName = "Name";
            this.AuctionsNameColumn.HeaderText = "Name";
            this.AuctionsNameColumn.Name = "AuctionsNameColumn";
            // 
            // AuctionsDescriptionColumn
            // 
            this.AuctionsDescriptionColumn.DataPropertyName = "Description";
            this.AuctionsDescriptionColumn.HeaderText = "Description";
            this.AuctionsDescriptionColumn.Name = "AuctionsDescriptionColumn";
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
            // MainForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 420);
            this.Controls.Add(this.ItemsTabControl);
            this.Name = "MainForm2";
            this.Text = "MainForm2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm2FormClosed);
            this.Load += new System.EventHandler(this.MainForm2Load);
            this.ItemsTabControl.ResumeLayout(false);
            this.ItemsTabPage.ResumeLayout(false);
            this.ItemsTableLayoutPanel.ResumeLayout(false);
            this.ItemsTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.ItemsToolStrip.ResumeLayout(false);
            this.ItemsToolStrip.PerformLayout();
            this.DonorsTabPage.ResumeLayout(false);
            this.DonorsTableLayoutPanel.ResumeLayout(false);
            this.DonorsTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DonorsDataGridView)).EndInit();
            this.AuctionsTabPage.ResumeLayout(false);
            this.AuctionsTableLayoutPanel.ResumeLayout(false);
            this.AuctionsTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AuctionsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionsBindingSource)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn street1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn street2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extension1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extension2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button DonorsSaveAllButton;
        private System.Windows.Forms.TableLayoutPanel AuctionsTableLayoutPanel;
        private System.Windows.Forms.DataGridView AuctionsDataGridView;
        private System.Windows.Forms.BindingSource auctionsBindingSource;
        private SilentAuctionDataSetTableAdapters.AuctionsTableAdapter auctionsTableAdapter;
        private System.Windows.Forms.Button AuctionsSaveAllChangesButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idItemsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auctionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn donorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifiedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuctionsIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuctionsNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuctionsDescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuctionsCreateDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuctionsModifiedDateColumn;
    }
}