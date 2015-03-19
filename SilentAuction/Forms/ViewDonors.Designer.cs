namespace SilentAuction.Forms
{
    partial class ViewDonorsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.donorTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.silentAuctionDataSet = new SilentAuction.SilentAuctionDataSet();
            this.requestFormatTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donorsTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.DonorsTableAdapter();
            this.donorTypesTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.DonorTypesTableAdapter();
            this.requestFormatTypesTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.RequestFormatTypesTableAdapter();
            this.DonorTypeColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestFormatTypeIdColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
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
            this.CreateDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifiedDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestFormatTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DonorTypeColumn,
            this.NameColumn,
            this.RequestFormatTypeIdColumn,
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
            this.CreateDateColumn,
            this.ModifiedDateColumn});
            this.dataGridView1.DataSource = this.donorsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(877, 386);
            this.dataGridView1.TabIndex = 0;
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
            // requestFormatTypesBindingSource
            // 
            this.requestFormatTypesBindingSource.DataMember = "RequestFormatTypes";
            this.requestFormatTypesBindingSource.DataSource = this.silentAuctionDataSet;
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
            // DonorTypeColumn
            // 
            this.DonorTypeColumn.DataPropertyName = "DonorTypeId";
            this.DonorTypeColumn.DataSource = this.donorTypesBindingSource;
            this.DonorTypeColumn.DisplayMember = "Name";
            this.DonorTypeColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.DonorTypeColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DonorTypeColumn.HeaderText = "Donor Type";
            this.DonorTypeColumn.Name = "DonorTypeColumn";
            this.DonorTypeColumn.ReadOnly = true;
            this.DonorTypeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DonorTypeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DonorTypeColumn.ValueMember = "Id";
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "Name";
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
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
            this.RequestFormatTypeIdColumn.ReadOnly = true;
            this.RequestFormatTypeIdColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RequestFormatTypeIdColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.RequestFormatTypeIdColumn.ValueMember = "Id";
            // 
            // ContactNameColumn
            // 
            this.ContactNameColumn.DataPropertyName = "ContactName";
            this.ContactNameColumn.HeaderText = "Contact Name";
            this.ContactNameColumn.Name = "ContactNameColumn";
            this.ContactNameColumn.ReadOnly = true;
            // 
            // EmailColumn
            // 
            this.EmailColumn.DataPropertyName = "Email";
            this.EmailColumn.HeaderText = "Email";
            this.EmailColumn.Name = "EmailColumn";
            this.EmailColumn.ReadOnly = true;
            // 
            // UrlColumn
            // 
            this.UrlColumn.DataPropertyName = "Url";
            this.UrlColumn.HeaderText = "Url";
            this.UrlColumn.Name = "UrlColumn";
            this.UrlColumn.ReadOnly = true;
            // 
            // Street1Column
            // 
            this.Street1Column.DataPropertyName = "Street1";
            this.Street1Column.HeaderText = "Street1";
            this.Street1Column.Name = "Street1Column";
            this.Street1Column.ReadOnly = true;
            // 
            // Street2Column
            // 
            this.Street2Column.DataPropertyName = "Street2";
            this.Street2Column.HeaderText = "Street2";
            this.Street2Column.Name = "Street2Column";
            this.Street2Column.ReadOnly = true;
            // 
            // CityColumn
            // 
            this.CityColumn.DataPropertyName = "City";
            this.CityColumn.HeaderText = "City";
            this.CityColumn.Name = "CityColumn";
            this.CityColumn.ReadOnly = true;
            // 
            // StateColumn
            // 
            this.StateColumn.DataPropertyName = "State";
            this.StateColumn.HeaderText = "State";
            this.StateColumn.Name = "StateColumn";
            this.StateColumn.ReadOnly = true;
            // 
            // ZipCodeColumn
            // 
            this.ZipCodeColumn.DataPropertyName = "ZipCode";
            this.ZipCodeColumn.HeaderText = "ZipCode";
            this.ZipCodeColumn.Name = "ZipCodeColumn";
            this.ZipCodeColumn.ReadOnly = true;
            // 
            // Phone1Column
            // 
            this.Phone1Column.DataPropertyName = "Phone1";
            this.Phone1Column.HeaderText = "Phone1";
            this.Phone1Column.Name = "Phone1Column";
            this.Phone1Column.ReadOnly = true;
            // 
            // Ext1Column
            // 
            this.Ext1Column.DataPropertyName = "Extension1";
            this.Ext1Column.HeaderText = "Extension1";
            this.Ext1Column.Name = "Ext1Column";
            this.Ext1Column.ReadOnly = true;
            // 
            // Phone2Column
            // 
            this.Phone2Column.DataPropertyName = "Phone2";
            this.Phone2Column.HeaderText = "Phone2";
            this.Phone2Column.Name = "Phone2Column";
            this.Phone2Column.ReadOnly = true;
            // 
            // Ext2Column
            // 
            this.Ext2Column.DataPropertyName = "Extension2";
            this.Ext2Column.HeaderText = "Extension2";
            this.Ext2Column.Name = "Ext2Column";
            this.Ext2Column.ReadOnly = true;
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "Id";
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Visible = false;
            // 
            // CreateDateColumn
            // 
            this.CreateDateColumn.DataPropertyName = "CreateDate";
            this.CreateDateColumn.HeaderText = "CreateDate";
            this.CreateDateColumn.Name = "CreateDateColumn";
            this.CreateDateColumn.ReadOnly = true;
            this.CreateDateColumn.Visible = false;
            // 
            // ModifiedDateColumn
            // 
            this.ModifiedDateColumn.DataPropertyName = "ModifiedDate";
            this.ModifiedDateColumn.HeaderText = "ModifiedDate";
            this.ModifiedDateColumn.Name = "ModifiedDateColumn";
            this.ModifiedDateColumn.ReadOnly = true;
            this.ModifiedDateColumn.Visible = false;
            // 
            // ViewDonorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 386);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewDonorsForm";
            this.Text = "View Donors";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewDonorsFormFormClosing);
            this.Load += new System.EventHandler(this.ViewDonorsFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestFormatTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SilentAuctionDataSet silentAuctionDataSet;
        private System.Windows.Forms.BindingSource donorsBindingSource;
        private SilentAuctionDataSetTableAdapters.DonorsTableAdapter donorsTableAdapter;
        private System.Windows.Forms.BindingSource donorTypesBindingSource;
        private SilentAuctionDataSetTableAdapters.DonorTypesTableAdapter donorTypesTableAdapter;
        private System.Windows.Forms.BindingSource requestFormatTypesBindingSource;
        private SilentAuctionDataSetTableAdapters.RequestFormatTypesTableAdapter requestFormatTypesTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn DonorTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn RequestFormatTypeIdColumn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifiedDateColumn;
    }
}