using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using SilentAuction.Utilities;
using TXTextControl;

namespace SilentAuction.Forms
{
    public partial class BidSheetPrintForm : Form
    {
        #region Properties
        private int AuctionId { get; set; }
        private List<int> ItemIdsSelected { get; set; }
        #endregion

        #region Constructor
        public BidSheetPrintForm(int auctionId)
        {
            AuctionId = auctionId;
            
            InitializeComponent();
        }
        #endregion

        #region Form Event Handlers
        private void GenerateItemLabelsFileLoad(object sender, EventArgs e)
        {
            AddCheckBoxColumn();

            itemsTableAdapter.Fill(silentAuctionDataSet.Items, AuctionId);
            
            bidSheetsTextControl.Load(Constants.BidSheetRtf, StringStreamType.RichTextFormat);
            
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

        private void PrintBidSheetsButtonClick(object sender, EventArgs e)
        {
            ItemIdsSelected = new List<int>();

            foreach (DataGridViewRow row in ItemsDataGridView.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    if ((bool)row.Cells[0].Value)
                    {
                        ItemIdsSelected.Add(MathHelper.ParseIntZeroIfNull(row.Cells[1].Value.ToString()));
                    }
                }
            }

            if (ItemIdsSelected.Count == 0)
                return;

            if (PrintBidSheet())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                DialogResult = DialogResult.None;
            }
        }
        #endregion

        #region Private Methods
        private void AddCheckBoxColumn()
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

        private bool PrintBidSheet()
        {
            List<Exception> exceptions = new List<Exception>();
            string exceptionString = "";
            PrintController printController = new StandardPrintController();
            bidSheetsPrintDocument.PrintController = printController;

            progressBar1.Maximum = ItemIdsSelected.Count;
            progressBar1.Step = 1;
            progressBar1.Value = 0;

            // TODO: Move progress bar to background worker?
            foreach (SilentAuctionDataSet.ItemsRow row in silentAuctionDataSet.Items.Rows)
            {
                if (ItemIdsSelected.Contains((int)row.Id))
                {
                    progressBar1.PerformStep();
                    
                    string bidList = "";
                    BidIncrementType bidIncrementType = (BidIncrementType) row.BidIncrementTypeId;
                    decimal minValue = MathHelper.ParseDecimalZeroIfNull(row.BidMinValue.ToString());
                    decimal maxValue = MathHelper.ParseDecimalZeroIfNull(row.BidMaxValue.ToString());
                    decimal incrementValue = MathHelper.ParseDecimalZeroIfNull(row.BidIncrementValue.ToString());
                    int numberOfBids = MathHelper.ParseIntZeroIfNull(row.BidNumberOfBids.ToString());

                    BidCalculator bidCalculator = new BidCalculator();

                    try
                    {
                        var bids = bidCalculator.GetBidList(bidIncrementType, minValue, maxValue, incrementValue, numberOfBids);

                        int rowNumber = 1;
                        foreach (decimal bid in bids)
                        {
                            bidList +=
                                string.Format(
                                    @"\trowd\irow{0}\irowband1\trgaph108\trrh428\trleft0\trftsWidth1\trftsWidthB3\trftsWidthA3\trpaddl108\trpaddr108\trpaddfl3\trpaddft3\trpaddfr3\trpaddfb3\clvertalc\clbrdrl\brdrs\brdrw10\clbrdrt\brdrs\brdrw10\clbrdrr\brdrs\brdrw10\clbrdrb\brdrs\brdrw10\clftsWidth3\clwWidth1014\cellx1014\clvertalt\clbrdrl\brdrs\brdrw10\clbrdrt\brdrs\brdrw10\clbrdrr\brdrs\brdrw10\clbrdrb\brdrs\brdrw10\clftsWidth3\clwWidth3054\cellx4068\clvertalt\clbrdrl\brdrs\brdrw10\clbrdrt\brdrs\brdrw10\clbrdrr\brdrs\brdrw10\clbrdrb\brdrs\brdrw10\clftsWidth3\clwWidth3521\cellx7589\clvertalt\clbrdrl\brdrs\brdrw10\clbrdrt\brdrs\brdrw10\clbrdrr\brdrs\brdrw10\clbrdrb\brdrs\brdrw10\clftsWidth3\clwWidth2635\cellx10224\pard\ltrpar\intbl\widctlpar\ql\li0\ri0\lin0\rin0\tx720\tx1440\tx2160\tx2880\tx3600\tx4320\tx5040\tx5760\tx6480\tx7200\tx7920\tx8640\tx9360\tx10080\plain\rtlch\af4\afs24\alang1033\ltrch\f5\fs24\lang1033\langnp1033\langfe1033\langfenp1033 {1}\cell\cell\cell\cell
\trowd\irow{0}\irowband1\trgaph108\trrh428\trleft0\trftsWidth1\trftsWidthB3\trftsWidthA3\trpaddl108\trpaddr108\trpaddfl3\trpaddft3\trpaddfr3\trpaddfb3\clvertalc\clbrdrl\brdrs\brdrw10\clbrdrt\brdrs\brdrw10\clbrdrr\brdrs\brdrw10\clbrdrb\brdrs\brdrw10\clftsWidth3\clwWidth1014\cellx1014\clvertalt\clbrdrl\brdrs\brdrw10\clbrdrt\brdrs\brdrw10\clbrdrr\brdrs\brdrw10\clbrdrb\brdrs\brdrw10\clftsWidth3\clwWidth3054\cellx4068\clvertalt\clbrdrl\brdrs\brdrw10\clbrdrt\brdrs\brdrw10\clbrdrr\brdrs\brdrw10\clbrdrb\brdrs\brdrw10\clftsWidth3\clwWidth3521\cellx7589\clvertalt\clbrdrl\brdrs\brdrw10\clbrdrt\brdrs\brdrw10\clbrdrr\brdrs\brdrw10\clbrdrb\brdrs\brdrw10\clftsWidth3\clwWidth2635\cellx10224\row",
                                    rowNumber, bid.ToString("C0")); 
                            rowNumber++;
                        }

                        MergeTextFields(row, bidList);
                        bidSheetsTextControl.Print(bidSheetsPrintDocument);
                        bidSheetsTextControl.Load(Constants.BidSheetRtf, StringStreamType.RichTextFormat);
                    }
                    catch (Exception exception)
                    {
                        exceptionString += row.Id + "\t" + exception.Message + "\n";

                        exceptions.Add(exception);
                    }
                }
            }

            if (exceptions.Count > 0)
            {
                MessageBox.Show(string.Format("Unable to print the following Items:\n\nID\tError\n{0}", exceptionString),
                    "Error Printing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                progressBar1.Value = 0;
                return false;
            }
            return true;
        }

        private void MergeTextFields(SilentAuctionDataSet.ItemsRow itemsRow, string bidList)
        {
            string rtfData;
            bidSheetsTextControl.Save(out rtfData, StringStreamType.RichTextFormat);
            rtfData = rtfData.Replace(Constants.BidList, bidList);
            bidSheetsTextControl.Load(rtfData, StringStreamType.RichTextFormat);

            foreach (TextField field in bidSheetsTextControl.TextFields)
            {
                SetTextFieldValue(itemsRow, bidList, field);
            }
            
            foreach (TextFrame frame in bidSheetsTextControl.Frames)
            {
                foreach (TextField field in frame.TextFields)
                {
                    SetTextFieldValue(itemsRow, bidList, field);
                }
            }
        }

        private static void SetTextFieldValue(SilentAuctionDataSet.ItemsRow itemsRow, string bidList, TextField field)
        {
            switch (field.Name)
            {
                case Constants.ItemNumber:
                    field.Text = itemsRow.Id.ToString();
                    break;
                case Constants.RetailValue:
                    field.Text = itemsRow.RetailValue.ToString("C");
                    break;
                case Constants.BidList:
                    field.Text = bidList;
                    break;
                case Constants.BuyItNowValue:
                    field.Text = itemsRow.BidBuyItNowValue.ToString("C");
                    break;
                case Constants.AuctionName:
                    field.Text = itemsRow.AuctionName;
                    break;
                case Constants.ItemName:
                    field.Text = itemsRow.Name;
                    break;
                case Constants.ItemDescription:
                    field.Text = itemsRow.Description ?? "";
                    break;
                case Constants.DonorName:
                    field.Text = itemsRow.DonorName;
                    break;
            }
        }
        #endregion

    }
}
