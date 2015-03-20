namespace SilentAuction.Forms
{
    partial class EditDonorList
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
            this.DonorsDataGridView = new System.Windows.Forms.DataGridView();
            this.DonorTypeColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.donorTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.silentAuctionDataSet = new SilentAuction.SilentAuctionDataSet();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestFormatTypeIdColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.requestFormatTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RequestStatusTypeIdColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.requestStatusTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ContactNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrlColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Street1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Street2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZipCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ext1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ext2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuctionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifiedDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donorsTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.DonorsTableAdapter();
            this.donorTypesTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.DonorTypesTableAdapter();
            this.requestFormatTypesTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.RequestFormatTypesTableAdapter();
            this.requestStatusTypesTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.RequestStatusTypesTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ItemsRequirementLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DonorsSaveAllButton = new System.Windows.Forms.Button();
            this.auctionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auctionsTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.AuctionsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DonorsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestFormatTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestStatusTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.auctionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DonorsDataGridView
            // 
            this.DonorsDataGridView.AllowUserToAddRows = false;
            this.DonorsDataGridView.AllowUserToDeleteRows = false;
            this.DonorsDataGridView.AutoGenerateColumns = false;
            this.DonorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DonorsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DonorTypeColumn,
            this.NameColumn,
            this.RequestFormatTypeIdColumn,
            this.RequestStatusTypeIdColumn,
            this.ContactNameColumn,
            this.EmailColumn,
            this.UrlColumn,
            this.Street1Column,
            this.Street2Column,
            this.CityColumn,
            this.StateColumn,
            this.ZipCodeColumn,
            this.Phone1Column,
            this.Ext1Column,
            this.Phone2Column,
            this.Ext2Column,
            this.IdColumn,
            this.AuctionId,
            this.CreateDateColumn,
            this.ModifiedDateColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.DonorsDataGridView, 2);
            this.DonorsDataGridView.DataSource = this.donorsBindingSource;
            this.DonorsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DonorsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.DonorsDataGridView.Name = "DonorsDataGridView";
            this.DonorsDataGridView.Size = new System.Drawing.Size(871, 320);
            this.DonorsDataGridView.TabIndex = 0;
            // 
            // DonorTypeColumn
            // 
            this.DonorTypeColumn.DataPropertyName = "DonorTypeId";
            this.DonorTypeColumn.DataSource = this.donorTypesBindingSource;
            this.DonorTypeColumn.DisplayMember = "Name";
            this.DonorTypeColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.DonorTypeColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DonorTypeColumn.HeaderText = "Donor Type";
            this.DonorTypeColumn.Name = "DonorTypeColumn";
            this.DonorTypeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DonorTypeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DonorTypeColumn.ValueMember = "Id";
            // 
            // donorTypesBindingSource
            // 
            this.donorTypesBindingSource.DataMember = "DonorTypes";
            this.donorTypesBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // silentAuctionDataSet
            // 
            this.silentAuctionDataSet.DataSetName = "SilentAuctionDataSet";
            this.silentAuctionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "Name";
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            // 
            // RequestFormatTypeIdColumn
            // 
            this.RequestFormatTypeIdColumn.DataPropertyName = "RequestFormatTypeId";
            this.RequestFormatTypeIdColumn.DataSource = this.requestFormatTypesBindingSource;
            this.RequestFormatTypeIdColumn.DisplayMember = "Name";
            this.RequestFormatTypeIdColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.RequestFormatTypeIdColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RequestFormatTypeIdColumn.HeaderText = "Request Via";
            this.RequestFormatTypeIdColumn.Name = "RequestFormatTypeIdColumn";
            this.RequestFormatTypeIdColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RequestFormatTypeIdColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.RequestFormatTypeIdColumn.ValueMember = "Id";
            // 
            // requestFormatTypesBindingSource
            // 
            this.requestFormatTypesBindingSource.DataMember = "RequestFormatTypes";
            this.requestFormatTypesBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // RequestStatusTypeIdColumn
            // 
            this.RequestStatusTypeIdColumn.DataPropertyName = "RequestStatusTypeId";
            this.RequestStatusTypeIdColumn.DataSource = this.requestStatusTypesBindingSource;
            this.RequestStatusTypeIdColumn.DisplayMember = "Name";
            this.RequestStatusTypeIdColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.RequestStatusTypeIdColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RequestStatusTypeIdColumn.HeaderText = "Request Status";
            this.RequestStatusTypeIdColumn.Name = "RequestStatusTypeIdColumn";
            this.RequestStatusTypeIdColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RequestStatusTypeIdColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.RequestStatusTypeIdColumn.ValueMember = "Id";
            this.RequestStatusTypeIdColumn.Width = 130;
            // 
            // requestStatusTypesBindingSource
            // 
            this.requestStatusTypesBindingSource.DataMember = "RequestStatusTypes";
            this.requestStatusTypesBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // ContactNameColumn
            // 
            this.ContactNameColumn.DataPropertyName = "ContactName";
            this.ContactNameColumn.HeaderText = "Contact Name";
            this.ContactNameColumn.Name = "ContactNameColumn";
            // 
            // EmailColumn
            // 
            this.EmailColumn.DataPropertyName = "Email";
            this.EmailColumn.HeaderText = "Email";
            this.EmailColumn.Name = "EmailColumn";
            // 
            // UrlColumn
            // 
            this.UrlColumn.DataPropertyName = "Url";
            this.UrlColumn.HeaderText = "Url";
            this.UrlColumn.Name = "UrlColumn";
            // 
            // Street1Column
            // 
            this.Street1Column.DataPropertyName = "Street1";
            this.Street1Column.HeaderText = "Street1";
            this.Street1Column.Name = "Street1Column";
            // 
            // Street2Column
            // 
            this.Street2Column.DataPropertyName = "Street2";
            this.Street2Column.HeaderText = "Street2";
            this.Street2Column.Name = "Street2Column";
            // 
            // CityColumn
            // 
            this.CityColumn.DataPropertyName = "City";
            this.CityColumn.HeaderText = "City";
            this.CityColumn.Name = "CityColumn";
            // 
            // StateColumn
            // 
            this.StateColumn.DataPropertyName = "State";
            this.StateColumn.HeaderText = "State";
            this.StateColumn.Name = "StateColumn";
            // 
            // ZipCodeColumn
            // 
            this.ZipCodeColumn.DataPropertyName = "ZipCode";
            this.ZipCodeColumn.HeaderText = "ZipCode";
            this.ZipCodeColumn.Name = "ZipCodeColumn";
            // 
            // Phone1Column
            // 
            this.Phone1Column.DataPropertyName = "Phone1";
            this.Phone1Column.HeaderText = "Phone1";
            this.Phone1Column.Name = "Phone1Column";
            // 
            // Ext1Column
            // 
            this.Ext1Column.DataPropertyName = "Extension1";
            this.Ext1Column.HeaderText = "Extension1";
            this.Ext1Column.Name = "Ext1Column";
            // 
            // Phone2Column
            // 
            this.Phone2Column.DataPropertyName = "Phone2";
            this.Phone2Column.HeaderText = "Phone2";
            this.Phone2Column.Name = "Phone2Column";
            // 
            // Ext2Column
            // 
            this.Ext2Column.DataPropertyName = "Extension2";
            this.Ext2Column.HeaderText = "Extension2";
            this.Ext2Column.Name = "Ext2Column";
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "Id";
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.Visible = false;
            // 
            // AuctionId
            // 
            this.AuctionId.DataPropertyName = "AuctionId";
            this.AuctionId.HeaderText = "AuctionId";
            this.AuctionId.Name = "AuctionId";
            this.AuctionId.Visible = false;
            // 
            // CreateDateColumn
            // 
            this.CreateDateColumn.DataPropertyName = "CreateDate";
            this.CreateDateColumn.HeaderText = "CreateDate";
            this.CreateDateColumn.Name = "CreateDateColumn";
            this.CreateDateColumn.Visible = false;
            // 
            // ModifiedDateColumn
            // 
            this.ModifiedDateColumn.DataPropertyName = "ModifiedDate";
            this.ModifiedDateColumn.HeaderText = "ModifiedDate";
            this.ModifiedDateColumn.Name = "ModifiedDateColumn";
            this.ModifiedDateColumn.Visible = false;
            // 
            // donorsBindingSource
            // 
            this.donorsBindingSource.DataMember = "Donors";
            this.donorsBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // donorsTableAdapter
            // 
            this.donorsTableAdapter.ClearBeforeFill = true;
            // 
            // donorTypesTableAdapter
            // 
            this.donorTypesTableAdapter.ClearBeforeFill = true;
            // 
            // requestFormatTypesTableAdapter
            // 
            this.requestFormatTypesTableAdapter.ClearBeforeFill = true;
            // 
            // requestStatusTypesTableAdapter
            // 
            this.requestStatusTypesTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DonorsDataGridView, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(877, 386);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel4, 2);
            this.panel4.Controls.Add(this.ItemsRequirementLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 369);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(871, 14);
            this.panel4.TabIndex = 6;
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
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.DonorsSaveAllButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 34);
            this.panel1.TabIndex = 5;
            // 
            // DonorsSaveAllButton
            // 
            this.DonorsSaveAllButton.AutoSize = true;
            this.DonorsSaveAllButton.Location = new System.Drawing.Point(3, 3);
            this.DonorsSaveAllButton.Name = "DonorsSaveAllButton";
            this.DonorsSaveAllButton.Size = new System.Drawing.Size(101, 23);
            this.DonorsSaveAllButton.TabIndex = 2;
            this.DonorsSaveAllButton.Text = "Save Changes";
            this.DonorsSaveAllButton.UseVisualStyleBackColor = true;
            this.DonorsSaveAllButton.Click += new System.EventHandler(this.DonorsSaveAllButtonClick);
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
            // EditDonorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 386);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EditDonorList";
            this.Text = "View/Edit Donors";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditDonorListFormClosing);
            this.Load += new System.EventHandler(this.EditDonorListFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.DonorsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestFormatTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestStatusTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.auctionsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DonorsDataGridView;
        private SilentAuctionDataSet silentAuctionDataSet;
        private System.Windows.Forms.BindingSource donorsBindingSource;
        private SilentAuctionDataSetTableAdapters.DonorsTableAdapter donorsTableAdapter;
        private System.Windows.Forms.BindingSource donorTypesBindingSource;
        private SilentAuctionDataSetTableAdapters.DonorTypesTableAdapter donorTypesTableAdapter;
        private System.Windows.Forms.BindingSource requestFormatTypesBindingSource;
        private SilentAuctionDataSetTableAdapters.RequestFormatTypesTableAdapter requestFormatTypesTableAdapter;
        private System.Windows.Forms.BindingSource requestStatusTypesBindingSource;
        private SilentAuctionDataSetTableAdapters.RequestStatusTypesTableAdapter requestStatusTypesTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DonorsSaveAllButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label ItemsRequirementLabel;
        private System.Windows.Forms.BindingSource auctionsBindingSource;
        private SilentAuctionDataSetTableAdapters.AuctionsTableAdapter auctionsTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn DonorTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn RequestFormatTypeIdColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn RequestStatusTypeIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrlColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Street1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Street2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZipCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ext1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ext2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuctionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifiedDateColumn;
    }
}