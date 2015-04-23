namespace SilentAuction.Forms
{
    partial class EditAuctionList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAuctionList));
            this.AuctionsDataGridView = new System.Windows.Forms.DataGridView();
            this.auctionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.silentAuctionDataSet = new SilentAuction.SilentAuctionDataSet();
            this.auctionsTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.AuctionsTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ItemsRequirementLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AuctionsSaveAllButton = new System.Windows.Forms.Button();
            this.AuctionsNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuctionsDescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuctionsIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuctionsCreateDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuctionsModifiedDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AuctionsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AuctionsDataGridView
            // 
            this.AuctionsDataGridView.AllowUserToAddRows = false;
            this.AuctionsDataGridView.AllowUserToDeleteRows = false;
            this.AuctionsDataGridView.AutoGenerateColumns = false;
            this.AuctionsDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.AuctionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AuctionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AuctionsNameColumn,
            this.AuctionsDescriptionColumn,
            this.AuctionsIdColumn,
            this.AuctionsCreateDateColumn,
            this.AuctionsModifiedDateColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.AuctionsDataGridView, 2);
            this.AuctionsDataGridView.DataSource = this.auctionsBindingSource;
            this.AuctionsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuctionsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.AuctionsDataGridView.Name = "AuctionsDataGridView";
            this.AuctionsDataGridView.Size = new System.Drawing.Size(638, 222);
            this.AuctionsDataGridView.TabIndex = 0;
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
            // auctionsTableAdapter
            // 
            this.auctionsTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.AuctionsDataGridView, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(644, 288);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel4, 2);
            this.panel4.Controls.Add(this.ItemsRequirementLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 271);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(638, 14);
            this.panel4.TabIndex = 5;
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
            this.panel1.Controls.Add(this.AuctionsSaveAllButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 34);
            this.panel1.TabIndex = 4;
            // 
            // AuctionsSaveAllButton
            // 
            this.AuctionsSaveAllButton.AutoSize = true;
            this.AuctionsSaveAllButton.Location = new System.Drawing.Point(3, 3);
            this.AuctionsSaveAllButton.Name = "AuctionsSaveAllButton";
            this.AuctionsSaveAllButton.Size = new System.Drawing.Size(101, 23);
            this.AuctionsSaveAllButton.TabIndex = 2;
            this.AuctionsSaveAllButton.Text = "Save Changes";
            this.AuctionsSaveAllButton.UseVisualStyleBackColor = true;
            this.AuctionsSaveAllButton.Click += new System.EventHandler(this.AuctionsSaveAllButtonClick);
            // 
            // AuctionsNameColumn
            // 
            this.AuctionsNameColumn.DataPropertyName = "Name";
            this.AuctionsNameColumn.HeaderText = "Auction Name";
            this.AuctionsNameColumn.Name = "AuctionsNameColumn";
            this.AuctionsNameColumn.Width = 200;
            // 
            // AuctionsDescriptionColumn
            // 
            this.AuctionsDescriptionColumn.DataPropertyName = "Description";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AuctionsDescriptionColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.AuctionsDescriptionColumn.HeaderText = "Auction Description";
            this.AuctionsDescriptionColumn.Name = "AuctionsDescriptionColumn";
            this.AuctionsDescriptionColumn.Width = 400;
            // 
            // AuctionsIdColumn
            // 
            this.AuctionsIdColumn.DataPropertyName = "Id";
            this.AuctionsIdColumn.HeaderText = "Id";
            this.AuctionsIdColumn.Name = "AuctionsIdColumn";
            this.AuctionsIdColumn.ReadOnly = true;
            this.AuctionsIdColumn.Visible = false;
            // 
            // AuctionsCreateDateColumn
            // 
            this.AuctionsCreateDateColumn.DataPropertyName = "CreateDate";
            this.AuctionsCreateDateColumn.HeaderText = "CreateDate";
            this.AuctionsCreateDateColumn.Name = "AuctionsCreateDateColumn";
            this.AuctionsCreateDateColumn.ReadOnly = true;
            this.AuctionsCreateDateColumn.Visible = false;
            // 
            // AuctionsModifiedDateColumn
            // 
            this.AuctionsModifiedDateColumn.DataPropertyName = "ModifiedDate";
            this.AuctionsModifiedDateColumn.HeaderText = "ModifiedDate";
            this.AuctionsModifiedDateColumn.Name = "AuctionsModifiedDateColumn";
            this.AuctionsModifiedDateColumn.ReadOnly = true;
            this.AuctionsModifiedDateColumn.Visible = false;
            // 
            // EditAuctionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 288);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditAuctionList";
            this.Text = "View/Edit Auctions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewAuctionsFormFormClosing);
            this.Load += new System.EventHandler(this.ViewAuctionsLoad);
            ((System.ComponentModel.ISupportInitialize)(this.AuctionsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AuctionsDataGridView;
        private SilentAuctionDataSet silentAuctionDataSet;
        private System.Windows.Forms.BindingSource auctionsBindingSource;
        private SilentAuctionDataSetTableAdapters.AuctionsTableAdapter auctionsTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AuctionsSaveAllButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label ItemsRequirementLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuctionsNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuctionsDescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuctionsIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuctionsCreateDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuctionsModifiedDateColumn;
    }
}