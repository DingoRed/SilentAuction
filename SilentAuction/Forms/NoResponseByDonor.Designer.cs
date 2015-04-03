namespace SilentAuction.Forms
{
    partial class NoResponseByDonor
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
            this.auctionsComboBox = new System.Windows.Forms.ComboBox();
            this.auctionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.silentAuctionDataSet = new SilentAuction.SilentAuctionDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.donorsDataGridView = new System.Windows.Forms.DataGridView();
            this.donorNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestStatusColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.requestStatusTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonorsWithNoResponseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DonorsWithNoResponseTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.DonorsWithNoResponseTableAdapter();
            this.requestStatusTypesTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.RequestStatusTypesTableAdapter();
            this.auctionsTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.AuctionsTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.auctionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donorsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestStatusTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonorsWithNoResponseBindingSource)).BeginInit();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(350, 230);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.auctionsComboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 34);
            this.panel1.TabIndex = 0;
            // 
            // auctionsComboBox
            // 
            this.auctionsComboBox.DataSource = this.auctionsBindingSource;
            this.auctionsComboBox.DisplayMember = "Name";
            this.auctionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.auctionsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.auctionsComboBox.FormattingEnabled = true;
            this.auctionsComboBox.Location = new System.Drawing.Point(61, 3);
            this.auctionsComboBox.Name = "auctionsComboBox";
            this.auctionsComboBox.Size = new System.Drawing.Size(274, 21);
            this.auctionsComboBox.TabIndex = 0;
            this.auctionsComboBox.ValueMember = "Id";
            this.auctionsComboBox.SelectedIndexChanged += new System.EventHandler(this.AuctionsComboBoxSelectedIndexChanged);
            // 
            // auctionsBindingSource
            // 
            this.auctionsBindingSource.DataMember = "Auctions";
            this.auctionsBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // silentAuctionDataSet
            // 
            this.silentAuctionDataSet.DataSetName = "SilentAuctionDataSet";
            this.silentAuctionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Auction:";
            // 
            // panel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 2);
            this.panel2.Controls.Add(this.donorsDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 184);
            this.panel2.TabIndex = 1;
            // 
            // donorsDataGridView
            // 
            this.donorsDataGridView.AllowUserToAddRows = false;
            this.donorsDataGridView.AllowUserToDeleteRows = false;
            this.donorsDataGridView.AutoGenerateColumns = false;
            this.donorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.donorsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.donorNameColumn,
            this.requestStatusColumn,
            this.idDataGridViewTextBoxColumn});
            this.donorsDataGridView.DataSource = this.DonorsWithNoResponseBindingSource;
            this.donorsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.donorsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.donorsDataGridView.Name = "donorsDataGridView";
            this.donorsDataGridView.ReadOnly = true;
            this.donorsDataGridView.Size = new System.Drawing.Size(344, 184);
            this.donorsDataGridView.TabIndex = 0;
            // 
            // donorNameColumn
            // 
            this.donorNameColumn.DataPropertyName = "Name";
            this.donorNameColumn.HeaderText = "Donor Name";
            this.donorNameColumn.Name = "donorNameColumn";
            this.donorNameColumn.ReadOnly = true;
            this.donorNameColumn.Width = 150;
            // 
            // requestStatusColumn
            // 
            this.requestStatusColumn.DataPropertyName = "RequestStatusTypeId";
            this.requestStatusColumn.DataSource = this.requestStatusTypesBindingSource;
            this.requestStatusColumn.DisplayMember = "Name";
            this.requestStatusColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.requestStatusColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.requestStatusColumn.HeaderText = "Request Status";
            this.requestStatusColumn.Name = "requestStatusColumn";
            this.requestStatusColumn.ReadOnly = true;
            this.requestStatusColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.requestStatusColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.requestStatusColumn.ValueMember = "Id";
            this.requestStatusColumn.Width = 150;
            // 
            // requestStatusTypesBindingSource
            // 
            this.requestStatusTypesBindingSource.DataMember = "RequestStatusTypes";
            this.requestStatusTypesBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // noResponseDonorsBindingSource
            // 
            this.DonorsWithNoResponseBindingSource.DataMember = "DonorsWithNoResponse";
            this.DonorsWithNoResponseBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // noResponseDonorsTableAdapter
            // 
            this.DonorsWithNoResponseTableAdapter.ClearBeforeFill = true;
            // 
            // requestStatusTypesTableAdapter
            // 
            this.requestStatusTypesTableAdapter.ClearBeforeFill = true;
            // 
            // auctionsTableAdapter
            // 
            this.auctionsTableAdapter.ClearBeforeFill = true;
            // 
            // DonorsWithNotResponse
            //   
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 230);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NoResponseByDonor";
            this.Text = "No Response By Donor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NoResponseByDonorFormClosing);
            this.Load += new System.EventHandler(this.NoResponseByDonorLoad);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.auctionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.donorsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestStatusTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonorsWithNoResponseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView donorsDataGridView;
        private System.Windows.Forms.BindingSource DonorsWithNoResponseBindingSource;
        private SilentAuctionDataSet silentAuctionDataSet;
        private SilentAuctionDataSetTableAdapters.DonorsWithNoResponseTableAdapter DonorsWithNoResponseTableAdapter;
        private System.Windows.Forms.BindingSource requestStatusTypesBindingSource;
        private SilentAuctionDataSetTableAdapters.RequestStatusTypesTableAdapter requestStatusTypesTableAdapter;
        private System.Windows.Forms.ComboBox auctionsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorNameColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn requestStatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource auctionsBindingSource;
        private SilentAuctionDataSetTableAdapters.AuctionsTableAdapter auctionsTableAdapter;
    }
}