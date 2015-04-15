using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SilentAuction.Utilities;
using TXTextControl;

namespace SilentAuction.Forms
{
    public partial class BidSheetPrintForm : Form
    {
//        #region Fields
        private const string ItemNumber = "<<ItemNumber>>";
        private const string RetailValue = "<<RetailValue>>";
        private const string BidList = "<<BidList>>";
        private const string BuyItNowValue = "<<BuyItNowValue>>";
        private const string AuctionName = "<<AuctionName>>";
        private const string ItemName = "<<ItemName>>";
        private const string ItemDescription = "<<ItemDescription>>";
        private const string DonorName = "<<DonorName>>";


//        private const string ItemNumberField = @"{\txfielddef{\*\txfieldstart\txfieldtype0\txfieldflags152\txfielddata 3c003c005f004900740065006d004e0075006d006200650072005f003e003e000000}{\*\txfieldtext <<_ItemNumber_>>{\*\txfieldend}}<<_ItemNumber_>>}";
//        private const string RetailValueField = @"{\txfielddef{\*\txfieldstart\txfieldtype0\txfieldflags152\txfielddataval1\txfielddata 3c003c005f00520065007400610069006c00560061006c00750065005f003e003e000000}{\*\txfieldtext <<_RetailValue_>>{\*\txfieldend}}<<_RetailValue_>>}";
//        private const string BidListField = @"{\txfielddef{\*\txfieldstart\txfieldtype0\txfieldflags152\txfielddataval2\txfielddata 3c003c005f004200690064004c006900730074005f003e003e000000}{\*\txfieldtext <<_BidList_>>{\*\txfieldend}}<<_BidList_>>}";
//        private const string BuyItNowValueField =   @"{\txfielddef{\*\txfieldstart\txfieldtype0\txfieldflags152\txfielddataval3\txfielddata 3c003c005f00420075007900490074004e006f007700560061006c00750065005f003e003e000000}{\*\txfieldtext <<_BuyItNowValue_>>{\*\txfieldend}}<<_BuyItNowValue_>>}";

//        private const string AuctionNameField = @"{\txfielddef{\*\txfieldstart\txfieldtype0\txfieldflags152\txfielddataval4\txfielddata 3c003c00410075006300740069006f006e004e0061006d0065003e003e000000}{\*\txfieldtext <<AuctionName>>{\*\txfieldend}}<<AuctionName>>}"; // 
//        private const string ItemNameField = @"{\txfielddef{\*\txfieldstart\txfieldtype0\txfieldflags152\txfielddataval5\txfielddata 3c003c004900740065006d004e0061006d0065003e003e000000}{\*\txfieldtext <<ItemName>>{\*\txfieldend}}<<ItemName>>}"; // 
//        private const string ItemDescriptionField = @"{\txfielddef{\*\txfieldstart\txfieldtype0\txfieldflags152\txfielddataval6\txfielddata 3c003c004900740065006d004400650073006300720069007000740069006f006e003e003e000000}{\*\txfieldtext <<ItemDescription>>{\*\txfieldend}}<<ItemDescription>>}"; // 
//        private const string DonorNameField = @"{\txfielddef{\*\txfieldstart\txfieldtype0\txfieldflags152\txfielddataval7\txfielddata 3c003c0044006f006e006f0072004e0061006d0065003e003e000000}{\*\txfieldtext <<DonorName>>{\*\txfieldend}}<<DonorName>>}"; // 

//        #endregion

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

            itemsShortListTableAdapter.FillItems(silentAuctionDataSet.ItemsShortList, AuctionId);
            
            bidSheetsTextControl.Load(RtfHelper.BidSheetRtf, StringStreamType.RichTextFormat);
            
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
            foreach (SilentAuctionDataSet.ItemsShortListRow row in silentAuctionDataSet.ItemsShortList.Rows)
            {
                if (ItemIdsSelected.Contains((int)row.Id))
                {
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

                        int numberOfEmptyLines = 20 - bids.Count;
                        int rowNumber = 1;
                        // TODO:  Clean this up.
                        foreach (decimal bid in bids)
                        {
                            bidList += string.Format(@"\trowd\irow{0}\irowband1\trgaph108\trrh428\trleft0\trftsWidth1\trftsWidthB3\trftsWidthA3\trpaddl108\trpaddr108\trpaddfl3\trpaddft3\trpaddfr3\trpaddfb3\clvertalc\clbrdrl\brdrs\brdrw10\clbrdrt\brdrs\brdrw10\clbrdrr\brdrs\brdrw10\clbrdrb\brdrs\brdrw10\clftsWidth3\clwWidth648\cellx648\clvertalt\clbrdrl\brdrs\brdrw10\clbrdrt\brdrs\brdrw10\clbrdrr\brdrs\brdrw10\clbrdrb\brdrs\brdrw10\clftsWidth3\clwWidth3420\cellx4068\clvertalt\clbrdrl\brdrs\brdrw10\clbrdrt\brdrs\brdrw10\clbrdrr\brdrs\brdrw10\clbrdrb\brdrs\brdrw10\clftsWidth3\clwWidth3521\cellx7589\clvertalt\clbrdrl\brdrs\brdrw10\clbrdrt\brdrs\brdrw10\clbrdrr\brdrs\brdrw10\clbrdrb\brdrs\brdrw10\clftsWidth3\clwWidth2635\cellx10224\pard\ltrpar\intbl\widctlpar\ql\li0\ri0\lin0\rin0\tx720\tx1440\tx2160\tx2880\tx3600\tx4320\tx5040\tx5760\tx6480\tx7200\tx7920\tx8640\tx9360\tx10080\plain\rtlch\af4\afs24\alang1033\ltrch\f4\fs24\lang1033\langnp1033\langfe1033\langfenp1033 {1}\cell\cell\cell\cell
\trowd\irow1\irowband1\trgaph108\trrh428\trleft0\trftsWidth1\trftsWidthB3\trftsWidthA3\trpaddl108\trpaddr108\trpaddfl3\trpaddft3\trpaddfr3\trpaddfb3\clvertalc\clbrdrl\brdrs\brdrw10\clbrdrt\brdrs\brdrw10\clbrdrr\brdrs\brdrw10\clbrdrb\brdrs\brdrw10\clftsWidth3\clwWidth648\cellx648\clvertalt\clbrdrl\brdrs\brdrw10\clbrdrt\brdrs\brdrw10\clbrdrr\brdrs\brdrw10\clbrdrb\brdrs\brdrw10\clftsWidth3\clwWidth3420\cellx4068\clvertalt\clbrdrl\brdrs\brdrw10\clbrdrt\brdrs\brdrw10\clbrdrr\brdrs\brdrw10\clbrdrb\brdrs\brdrw10\clftsWidth3\clwWidth3521\cellx7589\clvertalt\clbrdrl\brdrs\brdrw10\clbrdrt\brdrs\brdrw10\clbrdrr\brdrs\brdrw10\clbrdrb\brdrs\brdrw10\clftsWidth3\clwWidth2635\cellx10224\row", rowNumber, bid.ToString("C0"));
                            rowNumber++;
                        }

                        // TODO:  Lines are not being added
                        for (int i = 0; i < numberOfEmptyLines; i++)
                        {
                            bidList += "\n\n";
                        }

                        MergeTextFields(row, bidList);
                        bidSheetsTextControl.Print(bidSheetsPrintDocument);
                        ResetTextFields();
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
                return false;
            }
            return true;
        }

        private void MergeTextFields(SilentAuctionDataSet.ItemsShortListRow itemsRow, string bidList)
        {
            // TODO:  The doc has a bunch of frames.  the textfields are inside
            // ((TXTextControl.TextFrame)((new System.Linq.SystemCore_EnumerableDebugView(bidSheetsTextControl.Frames)).Items[0])).TextFields

            foreach (TextFrame frame in bidSheetsTextControl.Frames)
            {
                foreach (TextField field in frame.TextFields)
                {
                    switch (field.Name)
                    {
                        case ItemNumber:
                            field.Text = itemsRow.Id.ToString();
                            break;
                        case RetailValue:
                            field.Text = itemsRow.RetailValue.ToString("C");
                            break;
                        case BidList:
                            //field.Text = bidList;
                            break;
                        case BuyItNowValue:
                            field.Text = itemsRow.BidBuyItNowValue.ToString("C");
                            break;
                        case AuctionName:
                            field.Text = "Auction Name!";
                            break;
                        case ItemName:
                            field.Text = itemsRow.ItemName;
                            break;
                        case ItemDescription:
                            field.Text = itemsRow.Description;
                            break;
                        case DonorName:
                            field.Text = itemsRow.DonorName;
                            break;
                    }
                }
            }
        }

        private void ResetTextFields()
        {
            foreach (TextField field in bidSheetsTextControl.TextFields)
            {
                switch (field.Name)
                {
                    case ItemNumber:
                        field.Text = ItemNumber;
                        break;
                    case RetailValue:
                        field.Text = RetailValue;
                        break;
                    case BidList:
                        field.Text = BidList;
                        break;
                    case BuyItNowValue:
                        field.Text = BuyItNowValue;
                        break;
                }
            }
        }

        #endregion

    }
}
