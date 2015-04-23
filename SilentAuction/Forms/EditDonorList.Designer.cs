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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDonorList));
            this.DonorsDataGridView = new System.Windows.Forms.DataGridView();
            this.donorTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.silentAuctionDataSet = new SilentAuction.SilentAuctionDataSet();
            this.requestFormatTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestStatusTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.DonorsDonorTypeColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DonorsNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonorsRequestFormatTypeIdColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DonorsRequestStatusTypeIdColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DonorsContactNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonorsEmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonorsUrlColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonorsStreet1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonorsStreet2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonorsCityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonorsStateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonorsZipCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonorsPhone1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonorsExt1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonorsPhone2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonorsExt2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonorsIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonorsAuctionIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonorsCreateDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonorsModifiedDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.DonorsDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DonorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DonorsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DonorsDonorTypeColumn,
            this.DonorsNameColumn,
            this.DonorsRequestFormatTypeIdColumn,
            this.DonorsRequestStatusTypeIdColumn,
            this.DonorsContactNameColumn,
            this.DonorsEmailColumn,
            this.DonorsUrlColumn,
            this.DonorsStreet1Column,
            this.DonorsStreet2Column,
            this.DonorsCityColumn,
            this.DonorsStateColumn,
            this.DonorsZipCodeColumn,
            this.DonorsPhone1Column,
            this.DonorsExt1Column,
            this.DonorsPhone2Column,
            this.DonorsExt2Column,
            this.DonorsIdColumn,
            this.DonorsAuctionIdColumn,
            this.DonorsCreateDateColumn,
            this.DonorsModifiedDateColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.DonorsDataGridView, 2);
            this.DonorsDataGridView.DataSource = this.donorsBindingSource;
            this.DonorsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DonorsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.DonorsDataGridView.Name = "DonorsDataGridView";
            this.DonorsDataGridView.Size = new System.Drawing.Size(871, 320);
            this.DonorsDataGridView.TabIndex = 0;
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
            // requestStatusTypesBindingSource
            // 
            this.requestStatusTypesBindingSource.DataMember = "RequestStatusTypes";
            this.requestStatusTypesBindingSource.DataSource = this.silentAuctionDataSet;
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
            // DonorsDonorTypeColumn
            // 
            this.DonorsDonorTypeColumn.DataPropertyName = "DonorTypeId";
            this.DonorsDonorTypeColumn.DataSource = this.donorTypesBindingSource;
            this.DonorsDonorTypeColumn.DisplayMember = "Name";
            this.DonorsDonorTypeColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.DonorsDonorTypeColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DonorsDonorTypeColumn.HeaderText = "Donor Type";
            this.DonorsDonorTypeColumn.Name = "DonorsDonorTypeColumn";
            this.DonorsDonorTypeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DonorsDonorTypeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DonorsDonorTypeColumn.ValueMember = "Id";
            // 
            // DonorsNameColumn
            // 
            this.DonorsNameColumn.DataPropertyName = "Name";
            this.DonorsNameColumn.HeaderText = "Name";
            this.DonorsNameColumn.Name = "DonorsNameColumn";
            // 
            // DonorsRequestFormatTypeIdColumn
            // 
            this.DonorsRequestFormatTypeIdColumn.DataPropertyName = "RequestFormatTypeId";
            this.DonorsRequestFormatTypeIdColumn.DataSource = this.requestFormatTypesBindingSource;
            this.DonorsRequestFormatTypeIdColumn.DisplayMember = "Name";
            this.DonorsRequestFormatTypeIdColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.DonorsRequestFormatTypeIdColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DonorsRequestFormatTypeIdColumn.HeaderText = "Request Via";
            this.DonorsRequestFormatTypeIdColumn.Name = "DonorsRequestFormatTypeIdColumn";
            this.DonorsRequestFormatTypeIdColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DonorsRequestFormatTypeIdColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DonorsRequestFormatTypeIdColumn.ValueMember = "Id";
            // 
            // DonorsRequestStatusTypeIdColumn
            // 
            this.DonorsRequestStatusTypeIdColumn.DataPropertyName = "RequestStatusTypeId";
            this.DonorsRequestStatusTypeIdColumn.DataSource = this.requestStatusTypesBindingSource;
            this.DonorsRequestStatusTypeIdColumn.DisplayMember = "Name";
            this.DonorsRequestStatusTypeIdColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.DonorsRequestStatusTypeIdColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DonorsRequestStatusTypeIdColumn.HeaderText = "Request Status";
            this.DonorsRequestStatusTypeIdColumn.Name = "DonorsRequestStatusTypeIdColumn";
            this.DonorsRequestStatusTypeIdColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DonorsRequestStatusTypeIdColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DonorsRequestStatusTypeIdColumn.ValueMember = "Id";
            this.DonorsRequestStatusTypeIdColumn.Width = 130;
            // 
            // DonorsContactNameColumn
            // 
            this.DonorsContactNameColumn.DataPropertyName = "ContactName";
            this.DonorsContactNameColumn.HeaderText = "Contact Name";
            this.DonorsContactNameColumn.Name = "DonorsContactNameColumn";
            // 
            // DonorsEmailColumn
            // 
            this.DonorsEmailColumn.DataPropertyName = "Email";
            this.DonorsEmailColumn.HeaderText = "Email";
            this.DonorsEmailColumn.Name = "DonorsEmailColumn";
            // 
            // DonorsUrlColumn
            // 
            this.DonorsUrlColumn.DataPropertyName = "Url";
            this.DonorsUrlColumn.HeaderText = "Url";
            this.DonorsUrlColumn.Name = "DonorsUrlColumn";
            // 
            // DonorsStreet1Column
            // 
            this.DonorsStreet1Column.DataPropertyName = "Street1";
            this.DonorsStreet1Column.HeaderText = "Street1";
            this.DonorsStreet1Column.Name = "DonorsStreet1Column";
            // 
            // DonorsStreet2Column
            // 
            this.DonorsStreet2Column.DataPropertyName = "Street2";
            this.DonorsStreet2Column.HeaderText = "Street2";
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
            this.DonorsZipCodeColumn.HeaderText = "ZipCode";
            this.DonorsZipCodeColumn.Name = "DonorsZipCodeColumn";
            // 
            // DonorsPhone1Column
            // 
            this.DonorsPhone1Column.DataPropertyName = "Phone1";
            this.DonorsPhone1Column.HeaderText = "Phone1";
            this.DonorsPhone1Column.Name = "DonorsPhone1Column";
            // 
            // DonorsExt1Column
            // 
            this.DonorsExt1Column.DataPropertyName = "Extension1";
            this.DonorsExt1Column.HeaderText = "Extension1";
            this.DonorsExt1Column.Name = "DonorsExt1Column";
            // 
            // DonorsPhone2Column
            // 
            this.DonorsPhone2Column.DataPropertyName = "Phone2";
            this.DonorsPhone2Column.HeaderText = "Phone2";
            this.DonorsPhone2Column.Name = "DonorsPhone2Column";
            // 
            // DonorsExt2Column
            // 
            this.DonorsExt2Column.DataPropertyName = "Extension2";
            this.DonorsExt2Column.HeaderText = "Extension2";
            this.DonorsExt2Column.Name = "DonorsExt2Column";
            // 
            // DonorsIdColumn
            // 
            this.DonorsIdColumn.DataPropertyName = "Id";
            this.DonorsIdColumn.HeaderText = "Id";
            this.DonorsIdColumn.Name = "DonorsIdColumn";
            this.DonorsIdColumn.Visible = false;
            // 
            // DonorsAuctionIdColumn
            // 
            this.DonorsAuctionIdColumn.DataPropertyName = "AuctionId";
            this.DonorsAuctionIdColumn.HeaderText = "AuctionId";
            this.DonorsAuctionIdColumn.Name = "DonorsAuctionIdColumn";
            this.DonorsAuctionIdColumn.Visible = false;
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
            // EditDonorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 386);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.DataGridViewComboBoxColumn DonorsDonorTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonorsNameColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn DonorsRequestFormatTypeIdColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn DonorsRequestStatusTypeIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonorsContactNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonorsEmailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonorsUrlColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonorsStreet1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonorsStreet2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonorsCityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonorsStateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonorsZipCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonorsPhone1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonorsExt1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonorsPhone2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonorsExt2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonorsIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonorsAuctionIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonorsCreateDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonorsModifiedDateColumn;
    }
}