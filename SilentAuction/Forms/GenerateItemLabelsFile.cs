using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SilentAuction.Utilities;

namespace SilentAuction.Forms
{
    public partial class GenerateItemLabelsFile : Form
    {
        #region Properties
        private int AuctionId { get; set; }
        public List<int> DonorIdsToInclude { get; set; }
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





            itemsShortListTableAdapter.FillItems(silentAuctionDataSet.ItemsShortList, AuctionId);

            WindowSettings.SetupInitialWindow(this, "GenerateItemLabelsFileInitialLocation");
        }

        private void GenerateItemLabelsFileFormClosing(object sender, FormClosingEventArgs e)
        {
            WindowSettings.SaveWindowSettings(this, "GenerateItemLabelsFileInitialLocation");
        }

        #endregion


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
            DonorIdsToInclude = new List<int>();

            foreach (DataGridViewRow row in ItemsDataGridView.Rows)
            {
                if ((bool) row.Cells[0].Value)
                {
                    DonorIdsToInclude.Add(MathHelper.ParseIntZeroIfNull(row.Cells[1].Value.ToString()));
                }
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
