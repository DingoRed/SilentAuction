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
        #region Fields
        private const string ItemNumber = "<<_ItemNumber_>>";
        private const string RetailValue = "<<_RetailValue_>>";
        private const string BidList = "<<_BidList_>>";
        private const string BuyItNowValue = "<<_BuyItNowValue_>>";
        private const string ItemNumberField = @"{\txfielddef{\*\txfieldstart\txfieldtype0\txfieldflags152\txfielddata 3c003c005f004900740065006d004e0075006d006200650072005f003e003e000000}{\*\txfieldtext <<_ItemNumber_>>{\*\txfieldend}}<<_ItemNumber_>>}";
        private const string RetailValueField = @"{\txfielddef{\*\txfieldstart\txfieldtype0\txfieldflags152\txfielddataval1\txfielddata 3c003c005f00520065007400610069006c00560061006c00750065005f003e003e000000}{\*\txfieldtext <<_RetailValue_>>{\*\txfieldend}}<<_RetailValue_>>}";
        private const string BidListField = @"{\txfielddef{\*\txfieldstart\txfieldtype0\txfieldflags152\txfielddataval2\txfielddata 3c003c005f004200690064004c006900730074005f003e003e000000}{\*\txfieldtext <<_BidList_>>{\*\txfieldend}}<<_BidList_>>}";
        private const string BuyItNowValueField = @"{\txfielddef{\*\txfieldstart\txfieldtype0\txfieldflags152\txfielddataval3\txfielddata 3c003c005f00420075007900490074004e006f007700560061006c00750065005f003e003e000000}{\*\txfieldtext <<_BuyItNowValue_>>{\*\txfieldend}}<<_BuyItNowValue_>>}";
        #endregion

        #region Properties
        private int AuctionId { get; set; }
        private List<int> ItemIdsSelected { get; set; }
        private string BidSheetRtf
        {
            get
            {
                return @"{\rtf1\ansi\ansicpg1252\uc1\deff0\adeff0\deflang0\deflangfe0\adeflang0{\fonttbl
{\f0\fnil\fcharset0\fprq2 Arial;}
{\f1\fswiss\fcharset0\fprq2 Arial;}
{\f2\froman\fcharset2\fprq2 Symbol;}}
{\colortbl;}
{\stylesheet{\s0\ltrpar\itap0\nowidctlpar\ql\li0\ri0\lin0\rin0\rtlch\af0\afs24\ltrch\f0\fs24 [Normal];}{\*\cs10\additive Default Paragraph Font;}}
{\*\generator TX_RTF32 21.0.551.501;}
\paperw12240\paperh15840\margl1440\margt749\margr1440\margb1066\deftab1134\widowctrl\lytexcttp\formshade\sectd
\headery567\footery567\pgwsxn12240\pghsxn15840\marglsxn1440\margtsxn749\margrsxn1440\margbsxn1066\pgbrdropt32\pard\ltrpar\itap0\nowidctlpar\ql\li0\ri0\lin0\rin0\plain\rtlch\af1\afs20\alang1033\ltrch\f1\fs20\lang1033\langnp1033\langfe1033\langfenp1033 
Item #: " + ItemNumberField +
                    @"\par\par 
Retail Value: " + RetailValueField +
                    @"\par\par\plain\rtlch\af1\afs20\alang1033\aul\ltrch\f1\fs20\lang1033\langnp1033\langfe1033\langfenp1033\ul Bid\plain\rtlch\af1\afs20\alang1033\ltrch\f1\fs20\lang1033\langnp1033\langfe1033\langfenp1033\tab\plain\rtlch\af1\afs20\alang1033\aul\ltrch\f1\fs20\lang1033\langnp1033\langfe1033\langfenp1033\ul Bidder's Full Name, Email Address and Phone #\plain\rtlch\af1\afs20\alang1033\ltrch\f1\fs20\lang1033\langnp1033\langfe1033\langfenp1033\par\par 
" + BidListField +
                    @"\par\par\par\par\par 
Buy It Now: " + BuyItNowValueField +
                    @"\par\par\tab\plain\rtlch\af1\afs20\alang1033\aul\ltrch\f1\fs20\lang1033\langnp1033\langfe1033\langfenp1033\ul Bidder's Full Name, Email Address and Phone #\plain\rtlch\af1\afs20\alang1033\ltrch\f1\fs20\lang1033\langnp1033\langfe1033\langfenp1033\par\par\tab _________________________________________________________________________\par }";
            }
        }
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
            
            bidSheetsTextControl.Load(BidSheetRtf, StringStreamType.RichTextFormat);

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

            if (!PrintBidSheet())
            {
                DialogResult = DialogResult.None;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
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

                        int numberOfEmptyLines = 22 - bids.Count;

                        foreach (decimal bid in bids)
                        {
                            bidList += bid.ToString("C0") + "\t_________________________________________________________________________\n\n";
                        }

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
            foreach (TextField field in bidSheetsTextControl.TextFields)
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
                        field.Text = bidList;
                        break;
                    case BuyItNowValue:
                        field.Text = itemsRow.BidBuyItNowValue.ToString("C");
                        break;
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
