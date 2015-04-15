namespace SilentAuction.Forms
{
    partial class BidSheetPrintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BidSheetPrintForm));
            this.ItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsShortListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.silentAuctionDataSet = new SilentAuction.SilentAuctionDataSet();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bidSheetsTextControl = new TXTextControl.TextControl();
            this.CancelPrintButton = new System.Windows.Forms.Button();
            this.PrintBidSheetButton = new System.Windows.Forms.Button();
            this.bidSheetsPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.itemsShortListTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.ItemsShortListTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsShortListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemsDataGridView
            // 
            this.ItemsDataGridView.AllowUserToAddRows = false;
            this.ItemsDataGridView.AllowUserToDeleteRows = false;
            this.ItemsDataGridView.AutoGenerateColumns = false;
            this.ItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.donorNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.itemTypeDataGridViewTextBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.ItemsDataGridView, 2);
            this.ItemsDataGridView.DataSource = this.itemsShortListBindingSource;
            this.ItemsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.ItemsDataGridView.Name = "ItemsDataGridView";
            this.ItemsDataGridView.RowHeadersVisible = false;
            this.ItemsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemsDataGridView.Size = new System.Drawing.Size(563, 94);
            this.ItemsDataGridView.TabIndex = 0;
            this.ItemsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsDataGridViewCellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 41;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "Item Name";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemNameDataGridViewTextBoxColumn.Width = 90;
            // 
            // donorNameDataGridViewTextBoxColumn
            // 
            this.donorNameDataGridViewTextBoxColumn.DataPropertyName = "DonorName";
            this.donorNameDataGridViewTextBoxColumn.HeaderText = "Donor";
            this.donorNameDataGridViewTextBoxColumn.Name = "donorNameDataGridViewTextBoxColumn";
            this.donorNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.donorNameDataGridViewTextBoxColumn.Width = 70;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 200;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.qtyDataGridViewTextBoxColumn.Width = 55;
            // 
            // itemTypeDataGridViewTextBoxColumn
            // 
            this.itemTypeDataGridViewTextBoxColumn.DataPropertyName = "ItemType";
            this.itemTypeDataGridViewTextBoxColumn.HeaderText = "Item Type";
            this.itemTypeDataGridViewTextBoxColumn.Name = "itemTypeDataGridViewTextBoxColumn";
            // 
            // itemsShortListBindingSource
            // 
            this.itemsShortListBindingSource.DataMember = "ItemsShortList";
            this.itemsShortListBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // silentAuctionDataSet
            // 
            this.silentAuctionDataSet.DataSetName = "SilentAuctionDataSet";
            this.silentAuctionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.bidSheetsTextControl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ItemsDataGridView, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(874, 728);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 2);
            this.panel2.Controls.Add(this.CancelPrintButton);
            this.panel2.Controls.Add(this.PrintBidSheetButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 691);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(868, 34);
            this.panel2.TabIndex = 0;
            // 
            // bidSheetsTextControl
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.bidSheetsTextControl, 2);
            this.bidSheetsTextControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bidSheetsTextControl.Font = new System.Drawing.Font("Arial", 10F);
            this.bidSheetsTextControl.Location = new System.Drawing.Point(3, 103);
            this.bidSheetsTextControl.Name = "bidSheetsTextControl";
            this.bidSheetsTextControl.Size = new System.Drawing.Size(868, 582);
            this.bidSheetsTextControl.TabIndex = 2;
            this.bidSheetsTextControl.Text = "textControl1";
            // 
            // CancelPrintButton
            // 
            this.CancelPrintButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelPrintButton.Location = new System.Drawing.Point(295, 3);
            this.CancelPrintButton.Name = "CancelPrintButton";
            this.CancelPrintButton.Size = new System.Drawing.Size(75, 23);
            this.CancelPrintButton.TabIndex = 1;
            this.CancelPrintButton.Text = "Cancel";
            this.CancelPrintButton.UseVisualStyleBackColor = true;
            // 
            // PrintBidSheetButton
            // 
            this.PrintBidSheetButton.Location = new System.Drawing.Point(188, 4);
            this.PrintBidSheetButton.Name = "PrintBidSheetButton";
            this.PrintBidSheetButton.Size = new System.Drawing.Size(75, 23);
            this.PrintBidSheetButton.TabIndex = 0;
            this.PrintBidSheetButton.Text = "Print";
            this.PrintBidSheetButton.UseVisualStyleBackColor = true;
            this.PrintBidSheetButton.Click += new System.EventHandler(this.PrintBidSheetsButtonClick);
            // 
            // itemsShortListTableAdapter
            // 
            this.itemsShortListTableAdapter.ClearBeforeFill = true;
            // 
            // BidSheetPrintForm
            // 
            this.AcceptButton = this.PrintBidSheetButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelPrintButton;
            this.ClientSize = new System.Drawing.Size(874, 728);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BidSheetPrintForm";
            this.Text = "Print Bid Sheet Items";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GenerateItemLabelsFileFormClosing);
            this.Load += new System.EventHandler(this.GenerateItemLabelsFileLoad);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsShortListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ItemsDataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private SilentAuctionDataSet silentAuctionDataSet;
        private System.Windows.Forms.Button CancelPrintButton;
        private System.Windows.Forms.Button PrintBidSheetButton;
        private TXTextControl.TextControl bidSheetsTextControl;
        private System.Drawing.Printing.PrintDocument bidSheetsPrintDocument;
        private System.Windows.Forms.BindingSource itemsShortListBindingSource;
        private SilentAuctionDataSetTableAdapters.ItemsShortListTableAdapter itemsShortListTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemTypeDataGridViewTextBoxColumn;
    }
}