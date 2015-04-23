using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SilentAuction.Extensions;
using SilentAuction.Utilities;

namespace SilentAuction.Forms
{
    public partial class GenerateItemLabelsFile : Form
    {
        #region Properties
        private int AuctionId { get; set; }
        //public List<int> ItemIdsToInclude { get; set; }
        #endregion

        #region Constructor
        public GenerateItemLabelsFile(int auctionId)
        {
            AuctionId = auctionId;

            InitializeComponent();
        }
        #endregion

        #region Form Event Handlers
        private void GenerateItemLabelsFileLoad(object sender, EventArgs e)
        {
            SetupDataGridView();

            itemsTableAdapter.Fill(silentAuctionDataSet.Items, AuctionId);

            WindowSettings.SetupInitialWindow(this, "SelectItemsFormInitialLocation");
        }

        private void GenerateItemLabelsFileFormClosing(object sender, FormClosingEventArgs e)
        {
            WindowSettings.SaveWindowSettings(this, "SelectItemsFormInitialLocation");
        }

        #endregion

        #region Event Handlers
        private void CheckboxHeaderCheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < ItemsDataGridView.RowCount; i++)
            {
                ItemsDataGridView[0, i].Value = ((CheckBox)ItemsDataGridView.Controls.Find("checkboxHeader", true)[0]).Checked;
            }
            ItemsDataGridView.EndEdit();
        }

        private void ItemsDataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ItemsDataGridView[0, e.RowIndex].Value = !(bool) ItemsDataGridView[0, e.RowIndex].EditedFormattedValue;
                ItemsDataGridView.EndEdit();
            }
        }

        private void MakeFileButtonClick(object sender, EventArgs e)
        {
            List<int> itemIdsToInclude = new List<int>();

            foreach (DataGridViewRow row in ItemsDataGridView.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    if ((bool) row.Cells[0].Value)
                    {
                        itemIdsToInclude.Add(MathHelper.ParseIntZeroIfNull(row.Cells[1].Value.ToString()));
                    }
                }
            }

            if (itemIdsToInclude.Count == 0) return;

            SilentAuctionDataSet.ItemsDataTable dt = new SilentAuctionDataSet.ItemsDataTable();

            foreach (SilentAuctionDataSet.ItemsRow row in silentAuctionDataSet.Items.Rows)
            {
                if (itemIdsToInclude.Contains((int)row.Id))
                {
                    dt.Rows.Add(row.ItemArray);
                }
            }

            dt.Columns.Remove(dt.AuctionIdColumn);
            dt.Columns.Remove(dt.AuctionNameColumn);
            dt.Columns.Remove(dt.BidBuyItNowValueColumn);
            dt.Columns.Remove(dt.BidIncrementTypeIdColumn);
            dt.Columns.Remove(dt.BidIncrementValueColumn);
            dt.Columns.Remove(dt.BidMaxValueColumn);
            dt.Columns.Remove(dt.BidMinValueColumn);
            dt.Columns.Remove(dt.BidNumberOfBidsColumn);
            dt.Columns.Remove(dt.CreateDateColumn);
            dt.Columns.Remove(dt.DonationDeliveryTypeIdColumn);
            dt.Columns.Remove(dt.DonorIdColumn);
            dt.Columns.Remove(dt.DonorTypeNameColumn);
            dt.Columns.Remove(dt.ImageColumn);
            dt.Columns.Remove(dt.ItemTypeIdColumn);
            dt.Columns.Remove(dt.ItemTypeNameColumn);
            dt.Columns.Remove(dt.ModifiedDateColumn);
            dt.Columns.Remove(dt.NotesColumn);
            dt.Columns.Remove(dt.RetailValueColumn);
            dt.Columns.Remove(dt.SellValueColumn);
            
            string csvFile = dt.DataTableToCsvFormat();

            if (FileHelper.SaveCsvFile(csvFile, "Silent Auction Items"))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else DialogResult = DialogResult.None;
        }
        #endregion

        #region Private Methods
        private void SetupDataGridView()
        {
            // customize dataviewgrid, add checkbox column
            DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
            checkboxColumn.Width = 30;
            checkboxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ItemsDataGridView.Columns.Insert(0, checkboxColumn);

            // add checkbox header
            Rectangle rect = ItemsDataGridView.GetCellDisplayRectangle(0, -1, true);
            // set checkbox header to center of header cell. +1 pixel to position correctly.
            rect.X = rect.Location.X + (rect.Width / 4);

            CheckBox checkboxHeader = new CheckBox();
            checkboxHeader.Name = "checkboxHeader";
            checkboxHeader.Size = new Size(18, 18);
            checkboxHeader.Location = rect.Location;
            checkboxHeader.CheckedChanged += CheckboxHeaderCheckedChanged;

            ItemsDataGridView.Controls.Add(checkboxHeader);
        }
        #endregion
    }
}
