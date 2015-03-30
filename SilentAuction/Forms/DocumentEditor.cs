using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TXTextControl;
using HorizontalAlignment = TXTextControl.HorizontalAlignment;
using Image = TXTextControl.Image;

namespace SilentAuction.Forms
{
    public partial class DocumentEditor : Form
    {
        public enum DonationDocumentType { DonationRequestDocument, DonationFollowUpDocument }

        #region Fields
        private bool _documentIsDirty;
        private int _fieldId;
        private const string Company = "<<CompanyName>>";
        private const string ContactName = "<<ContactName>>";
        private const string Street1 = "<<Street1>>";
        private const string Street2 = "<<Street2>>";
        private const string City = "<<City>>";
        private const string State = "<<State>>";
        private const string ZipCode = "<<ZipCode>>";
        #endregion

        #region Properties
        private int AuctionId { get; set; }
        private DonationDocumentType DocType { get; set; }
        #endregion

        #region Constructors
        //public DocumentEditor(){}

        public DocumentEditor(int auctionId, DonationDocumentType docType)
        {
            AuctionId = auctionId;
            DocType = docType;

            InitializeComponent();
        }
        #endregion

        #region Form Event Handlers
        private void DocumentEditorLoad(object sender, EventArgs e)
        {
            switch (DocType)
            {
                case DonationDocumentType.DonationRequestDocument:
                    Text = "Document Editor (Request Document)";
                    break;
                case DonationDocumentType.DonationFollowUpDocument:
                    Text = "Document Editor (Follow Up Document)";
                    break;
            }
            requestStatusTypesTableAdapter.FillRequestStatusType(silentAuctionDataSet.RequestStatusTypes);
            requestFormatTypesTableAdapter.FillRequestFormatTypes(silentAuctionDataSet.RequestFormatTypes);
            donorTypesTableAdapter.FillDonorTypes(silentAuctionDataSet.DonorTypes);
            auctionsTableAdapter.FillAuctions(silentAuctionDataSet.Auctions);

            donorsTableAdapter.FillDonors(silentAuctionDataSet.Donors, AuctionId);

            string rtfData = GetDocumentData();
            if(!string.IsNullOrWhiteSpace(rtfData))
                documentEditorControl.Load(rtfData, StringStreamType.RichTextFormat);
        }

        private void DocumentEditorFormClosing(object sender, FormClosingEventArgs e)
        {
            if (_documentIsDirty)
            {
                DialogResult dlgRes = MessageBox.Show("Save changes before exiting?", "Save Changes", MessageBoxButtons.YesNoCancel);
                if (dlgRes == DialogResult.Yes)
                {
                    SaveDocumentData();
                    _documentIsDirty = false;
                }
                else if (dlgRes == DialogResult.Cancel) e.Cancel = true;
            }
        }

        private void DocumentEditorControlKeyPress(object sender, KeyPressEventArgs e)
        {
            _documentIsDirty = true;
        }

        #endregion

        #region Menu Items Event Handlers
        #region File Menu Items Event Handlers
        private void OpenToolStripMenuItemClick(object sender, EventArgs e)
        {
            string rtfData = GetDocumentData();
            documentEditorControl.Load(rtfData, StringStreamType.RichTextFormat);
        }

        private void SaveToolStripMenuItemClick(object sender, EventArgs e)
        {
            SaveDocumentData();
        }

        private void PageSetupToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO: Implement Page Setup?
            //PageSetup.pageSetup_Click(sender, e, _textControl, _fileHandler);
            MessageBox.Show("Should this be implemented??");
        }

        private void PrintToolStripMenuItemClick(object sender, EventArgs e)
        {
            PrintDocuments();
        }

        private void PrintPreviewToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO: Remove Print Preview?
            documentEditorControl.PrintPreview(printDocumentMain);
        }

        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Edit Menu Items Event Handlers
        private void EditToolStripMenuItemDropDownOpening(object sender, EventArgs e)
        {
            undoToolStripMenuItem.Enabled = documentEditorControl.CanUndo;
            redoToolStripMenuItem.Enabled = documentEditorControl.CanRedo;
            cutToolStripMenuItem.Enabled = documentEditorControl.CanCopy;
            copyToolStripMenuItem.Enabled = documentEditorControl.CanCopy;
            pasteToolStripMenuItem.Enabled = documentEditorControl.CanPaste;

            undoToolStripMenuItem.Text = "Undo " + documentEditorControl.UndoActionName;
            redoToolStripMenuItem.Text = "Redo " + documentEditorControl.RedoActionName;
        }

        private void UndoToolStripMenuItemClick(object sender, EventArgs e)
        {
            documentEditorControl.Undo();
        }

        private void RedoToolStripMenuItemClick(object sender, EventArgs e)
        {
            documentEditorControl.Redo();
        }

        private void CutToolStripMenuItemClick(object sender, EventArgs e)
        {
            documentEditorControl.Cut();
        }

        private void CopyToolStripMenuItemClick(object sender, EventArgs e)
        {
            documentEditorControl.Copy();
        }

        private void PasteToolStripMenuItemClick(object sender, EventArgs e)
        {
            documentEditorControl.Paste();
        }

        private void DeleteToolStripMenuItemClick(object sender, EventArgs e)
        {
            documentEditorControl.Clear();
        }

        private void SelectAllToolStripMenuItemClick(object sender, EventArgs e)
        {
            documentEditorControl.SelectAll();
        }
        #endregion

        #region View Menu Items Event Handlers
        private void ViewToolStripMenuItemDropDownOpening(object sender, EventArgs e)
        {
            viewToolbarToolStripMenuItem.Checked = toolStripMain.Visible;
            viewButtonBarToolStripMenuItem.Checked = documentButtonBar.Visible;
            viewStatusBarToolStripMenuItem.Checked = documentStatusBar.Visible;
            viewHorizontalRulerToolStripMenuItem.Checked = horizontalRulerBar.Visible;
            viewVerticalRulerToolStripMenuItem.Checked = verticalRulerBar.Visible;
        }

        private void ViewToolbarToolStripMenuItemClick(object sender, EventArgs e)
        {
            toolStripMain.Visible = !toolStripMain.Visible;
        }

        private void ViewButtonBarToolStripMenuItemClick(object sender, EventArgs e)
        {
            documentButtonBar.Visible = !documentButtonBar.Visible;
        }

        private void ViewStatusBarToolStripMenuItemClick(object sender, EventArgs e)
        {
            documentStatusBar.Visible = !documentStatusBar.Visible;
        }

        private void ViewHorizontalRulerToolStripMenuItemClick(object sender, EventArgs e)
        {
            horizontalRulerBar.Visible = !horizontalRulerBar.Visible;
        }

        private void ViewVerticalRulerToolStripMenuItemClick(object sender, EventArgs e)
        {
            verticalRulerBar.Visible = !verticalRulerBar.Visible;
        }
        #endregion

        #region Insert Menu Items Event Handlers
        private void InsertCompanyNameToolStripMenuItemClick(object sender, EventArgs e)
        {
            InsertNewField(Company);
        }

        private void InsertContactNameToolStripMenuItemClick(object sender, EventArgs e)
        {
            InsertNewField(ContactName);
        }

        private void InsertStreet1ToolStripMenuItemClick(object sender, EventArgs e)
        {
            InsertNewField(Street1);
        }

        private void InsertStreet2ToolStripMenuItemClick(object sender, EventArgs e)
        {
            InsertNewField(Street2);
        }

        private void InsertCityToolStripMenuItemClick(object sender, EventArgs e)
        {
            InsertNewField(City);
        }

        private void InsertStateToolStripMenuItemClick(object sender, EventArgs e)
        {
            InsertNewField(State);
        }

        private void InsertZipCodeToolStripMenuItemClick(object sender, EventArgs e)
        {
            InsertNewField(ZipCode);
        }

        private void InsertImageToolStripMenuItemClick(object sender, EventArgs e)
        {
            Image imageNew = new Image();
            documentEditorControl.Images.Add(imageNew, HorizontalAlignment.Left, -1, ImageInsertionMode.DisplaceText);
        }

        private void InsertPageBreakToolStripMenuItemClick(object sender, EventArgs e)
        {
            int dpi = (int)(1440 / documentEditorControl.CreateGraphics().DpiX);

            documentEditorControl.Selection.Text = "\f";
            documentEditorControl.ScrollLocation
               = new Point(
                  documentEditorControl.ScrollLocation.X,
                  (int)(documentEditorControl.InputPosition.Location.Y - (documentEditorControl.Selection.SectionFormat.PageMargins.Top * dpi))
                 );
        }

        #endregion

        #region Format Menu Items Event Handlers
        private void FormatToolStripMenuItemDropDownOpening(object sender, EventArgs e)
        {
            formatImageToolStripMenuItem.Enabled = (documentEditorControl.Images.GetItem() != null);
        }

        private void FormatCharacterToolStripMenuItemClick(object sender, EventArgs e)
        {
            documentEditorControl.FontDialog();
        }

        private void FormatParagraphToolStripMenuItemClick(object sender, EventArgs e)
        {
            documentEditorControl.ParagraphFormatDialog();
        }

        private void FormatStylesToolStripMenuItemClick(object sender, EventArgs e)
        {
            documentEditorControl.FormattingStylesDialog();
        }

        private void FormatTabsToolStripMenuItemClick(object sender, EventArgs e)
        {
            documentEditorControl.TabDialog();
        }

        private void FormatImageToolStripMenuItemClick(object sender, EventArgs e)
        {
            documentEditorControl.ImageAttributesDialog();
        }

        private void FormatListToolStripMenuItemDropDownOpening(object sender, EventArgs e)
        {
            formatListIncreaseLevelToolStripMenuItem.Enabled = 
                (documentEditorControl.Selection.ListFormat.Type != ListType.None) && 
                (documentEditorControl.Selection.ListFormat.Level < ListFormat.MaxLevel);

            formatListDecreaseLevelToolStripMenuItem.Enabled = 
                (documentEditorControl.Selection.ListFormat.Type != ListType.None) && 
                (documentEditorControl.Selection.ListFormat.Level > 1);

            CheckListMenuItem();
        }

        private void FormatListPropertiesToolStripMenuItemClick(object sender, EventArgs e)
        {
            documentEditorControl.ListFormatDialog();
        }

        private void FormatListArabicNumberstoolStripMenuItemClick(object sender, EventArgs e)
        {
            if (formatListArabicNumberstoolStripMenuItem.Checked)
            {
                documentEditorControl.Selection.ListFormat.Type = ListType.None;
                documentEditorControl.Selection.ListFormat.NumberFormat = NumberFormat.None;
                return;
            }

            documentEditorControl.Selection.ListFormat.Type = ListType.Numbered;
            documentEditorControl.Selection.ListFormat.NumberFormat = NumberFormat.ArabicNumbers;
        }

        private void FormatListCapitalLettersToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (formatListCapitalLettersToolStripMenuItem.Checked)
            {
                documentEditorControl.Selection.ListFormat.Type = ListType.None;
                documentEditorControl.Selection.ListFormat.NumberFormat = NumberFormat.None;
                return;
            }

            documentEditorControl.Selection.ListFormat.Type = ListType.Numbered;
            documentEditorControl.Selection.ListFormat.NumberFormat = NumberFormat.CapitalLetters;
        }

        private void FormatListBulletsToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (formatListBulletsToolStripMenuItem.Checked)
            {
                documentEditorControl.Selection.ListFormat.Type = ListType.None;
                documentEditorControl.Selection.ListFormat.NumberFormat = NumberFormat.None;
                return;
            }

            documentEditorControl.Selection.ListFormat.Type = ListType.Bulleted;
        }

        private void FormatListIncreaseLevelToolStripMenuItemClick(object sender, EventArgs e)
        {
            documentEditorControl.Selection.ListFormat.Level += 1;
            documentEditorControl.Selection.IncreaseIndent();
        }

        private void FormatListDecreaseLevelToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (documentEditorControl.Selection.ListFormat.Level >= 2)
            {
                documentEditorControl.Selection.ListFormat.Level -= 1;
                documentEditorControl.Selection.DecreaseIndent();
            }
        }

        #endregion

        #region Table Menu Items Event Handlers
        private void TableToolStripMenuItemDropDownOpening(object sender, EventArgs e)
        {
            Table thisTable = documentEditorControl.Tables.GetItem();

            tablePropertiesToolStripMenuItem.Enabled = (thisTable != null);
            tableGridLinesToolStripMenuItem.Checked = documentEditorControl.Tables.GridLines;

            if (thisTable != null)
            {
                tableDeleteToolStripMenuItem.Enabled = true;
                tableSplitTableToolStripMenuItem.Enabled = thisTable.CanSplit;
                tableMergeCellsToolStripMenuItem.Enabled = thisTable.CanMergeCells;
                tableSplitCellsToolStripMenuItem.Enabled = thisTable.CanSplitCells;
                tableSelectTableToolStripMenuItem.Enabled = true;
            }
            else
            {
                tableSplitTableToolStripMenuItem.Enabled = false;
                tableDeleteToolStripMenuItem.Enabled = false;
                tableMergeCellsToolStripMenuItem.Enabled = false;
                tableSplitCellsToolStripMenuItem.Enabled = false;
                tableSelectTableToolStripMenuItem.Enabled = false;
            }
        }

        private void TableInsertToolStripMenuItemDropDownOpening(object sender, EventArgs e)
        {
            tableInsertTableToolStripMenuItem.Enabled = documentEditorControl.Tables.CanAdd;

            Table tableAtInputPosition = documentEditorControl.Tables.GetItem();
            if (tableAtInputPosition == null)
            {
                tableInsertColumnToTheLeftToolStripMenuItem.Enabled = false;
                tableInsertColumnToTheRightToolStripMenuItem.Enabled = false;
                tableInsertRowAboveToolStripMenuItem.Enabled = false;
                tableInsertRowBelowToolStripMenuItem.Enabled = false;
            }
            else
            {
                tableInsertColumnToTheLeftToolStripMenuItem.Enabled = tableAtInputPosition.Columns.CanAdd;
                tableInsertColumnToTheRightToolStripMenuItem.Enabled = tableAtInputPosition.Columns.CanAdd;
                tableInsertRowAboveToolStripMenuItem.Enabled = tableAtInputPosition.Rows.CanAdd;
                tableInsertRowBelowToolStripMenuItem.Enabled = tableAtInputPosition.Rows.CanAdd;
            }
        }

        private void TableInsertTableToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (documentEditorControl.Tables.Add())
            {
                _documentIsDirty = true;
            }
        }

        private void TableInsertColumnToTheLeftToolStripMenuItemClick(object sender, EventArgs e)
        {
            documentEditorControl.Tables.GetItem().Columns.Add(TableAddPosition.Before);
        }

        private void TableInsertColumnToTheRightToolStripMenuItemClick(object sender, EventArgs e)
        {
            documentEditorControl.Tables.GetItem().Columns.Add(TableAddPosition.After);
        }

        private void TableInsertRowAboveToolStripMenuItemClick(object sender, EventArgs e)
        {
            documentEditorControl.Tables.GetItem().Rows.Add(TableAddPosition.Before, 1);
        }

        private void TableInsertRowBelowToolStripMenuItemClick(object sender, EventArgs e)
        {
            documentEditorControl.Tables.GetItem().Rows.Add(TableAddPosition.After, 1);
        }

        private void TableDeleteToolStripMenuItemDropDownOpening(object sender, EventArgs e)
        {
            Table tableAtInputPosition = documentEditorControl.Tables.GetItem();

            if (tableAtInputPosition == null)
            {
                tableDeleteTableToolStripMenuItem.Enabled = false;
                tableDeleteColumnToolStripMenuItem.Enabled = false;
                tableDeleteRowsToolStripMenuItem.Enabled = false;
                tableDeleteCellsToolStripMenuItem.Enabled = false;
            }
            else
            {
                tableDeleteTableToolStripMenuItem.Enabled = tableAtInputPosition.Columns.CanRemove;
                tableDeleteColumnToolStripMenuItem.Enabled = tableAtInputPosition.Columns.CanRemove;
                tableDeleteRowsToolStripMenuItem.Enabled = tableAtInputPosition.Rows.CanRemove;
                tableDeleteCellsToolStripMenuItem.Enabled = tableAtInputPosition.Cells.CanRemove;
                tableDeleteDeleteEntireColumnToolStripMenuItem.Enabled = tableAtInputPosition.Columns.CanRemove;
                tableDeleteCellsDeleteEntireRowToolStripMenuItem.Enabled = tableAtInputPosition.Rows.CanRemove;
            }
        }

        private void TableDeleteTableToolStripMenuItemClick(object sender, EventArgs e)
        {
            documentEditorControl.Tables.Remove();
        }

        private void TableDeleteColumnToolStripMenuItemClick(object sender, EventArgs e)
        {
            documentEditorControl.Tables.GetItem().Columns.Remove();
        }

        private void TableDeleteRowsToolStripMenuItemClick(object sender, EventArgs e)
        {
            documentEditorControl.Tables.GetItem().Rows.Remove();
        }

        private void TableDeleteCellsShiftCellsLeftToolStripMenuItemClick(object sender, EventArgs e)
        {
            documentEditorControl.Tables.GetItem().Cells.Remove();
        }

        private void TableDeleteCellsDeleteEntireRowToolStripMenuItemClick(object sender, EventArgs e)
        {
            documentEditorControl.Tables.GetItem().Rows.Remove();
        }

        private void TableDeleteDeleteEntireColumnToolStripMenuItemClick(object sender, EventArgs e)
        {
            documentEditorControl.Tables.GetItem().Columns.Remove();
        }

        private void TableSelectToolStripMenuItemDropDownOpening(object sender, EventArgs e)
        {
            TableRow rowAtInputPosition = null;
            TableCell cellAtInputPosition = null;
            TableColumn columnAtInputPosition = null;

            var tableAtInputPosition = documentEditorControl.Tables.GetItem();
            if (tableAtInputPosition != null)
            {
                rowAtInputPosition = tableAtInputPosition.Rows.GetItem();
                cellAtInputPosition = tableAtInputPosition.Cells.GetItem();
                columnAtInputPosition = tableAtInputPosition.Columns.GetItem();
            }

            tableSelectTableToolStripMenuItem.Enabled = (tableAtInputPosition != null);
            tableSelectRowToolStripMenuItem.Enabled = (rowAtInputPosition != null);
            tableSelectCellToolStripMenuItem.Enabled = (cellAtInputPosition != null);
            tableSelectColumnToolStripMenuItem.Enabled = (columnAtInputPosition != null);
        }

        private void TableSelectTableToolStripMenuItemClick(object sender, EventArgs e)
        {
            documentEditorControl.Tables.GetItem().Select();
        }

        private void TableSelectColumnToolStripMenuItemClick(object sender, EventArgs e)
        {
            documentEditorControl.Tables.GetItem().Columns.GetItem().Select();
        }

        private void TableSelectRowToolStripMenuItemClick(object sender, EventArgs e)
        {
            documentEditorControl.Tables.GetItem().Rows.GetItem().Select();
        }

        private void TableSelectCellToolStripMenuItemClick(object sender, EventArgs e)
        {
            documentEditorControl.Tables.GetItem().Cells.GetItem().Select();
        }

        private void TableMergeCellsToolStripMenuItemClick(object sender, EventArgs e)
        {
            documentEditorControl.Tables.GetItem().MergeCells();
        }

        private void TableSplitCellsToolStripMenuItemClick(object sender, EventArgs e)
        {
            documentEditorControl.Tables.GetItem().SplitCells();
        }

        private void TableSplitTableToolStripMenuItemDropDownOpening(object sender, EventArgs e)
        {
            Table tableAtInputPosition = documentEditorControl.Tables.GetItem();

            if (tableAtInputPosition == null)
            {
                tableSplitTableAboveToolStripMenuItem.Enabled = false;
                tableSplitTableBelowToolStripMenuItem.Enabled = false;
            }
            else
            {
                tableSplitTableAboveToolStripMenuItem.Enabled = true;
                tableSplitTableBelowToolStripMenuItem.Enabled = true;
            }
        }

        private void TableSplitTableAboveToolStripMenuItemClick(object sender, EventArgs e)
        {
            documentEditorControl.Tables.GetItem().Split(TableAddPosition.Before);
        }

        private void TableSplitTableBelowToolStripMenuItemClick(object sender, EventArgs e)
        {
            documentEditorControl.Tables.GetItem().Split(TableAddPosition.After);
        }

        private void TableGridLinesToolStripMenuItemClick(object sender, EventArgs e)
        {
            documentEditorControl.Tables.GridLines = !documentEditorControl.Tables.GridLines;
        }

        private void TablePropertiesToolStripMenuItemClick(object sender, EventArgs e)
        {
            documentEditorControl.TableFormatDialog();
        }
        #endregion
        #endregion

        #region Toolstrip Button Items Event Handlers
        private void OpenToolStripButtonClick(object sender, EventArgs e)
        {
            string rtfData = GetDocumentData();
            documentEditorControl.Load(rtfData, StringStreamType.RichTextFormat);
        }

        private void SaveToolStripButtonClick(object sender, EventArgs e)
        {
            SaveDocumentData();
        }
        
        private void PrintToolStripButtonClick(object sender, EventArgs e)
        {
            PrintDocuments();
        }

        private void PrintPreviewToolStripButtonClick(object sender, EventArgs e)
        {
            // TODO: Remove Print Preview?
            documentEditorControl.PrintPreview(printDocumentMain);
        }

        private void CutToolStripButtonClick(object sender, EventArgs e)
        {
            documentEditorControl.Cut();
        }

        private void CopyToolStripButtonClick(object sender, EventArgs e)
        {
            documentEditorControl.Copy();
        }

        private void PasteToolStripButtonClick(object sender, EventArgs e)
        {
            documentEditorControl.Paste();
        }

        private void DeleteToolStripButtonClick(object sender, EventArgs e)
        {
            documentEditorControl.Clear();
        }

        private void UndoToolStripButtonClick(object sender, EventArgs e)
        {
            documentEditorControl.Undo();
        }

        private void RedoToolStripButtonClick(object sender, EventArgs e)
        {
            documentEditorControl.Redo();
        }

        #endregion

        #region Private Methods
        private void SaveDocumentData()
        {
            string rtfData;

            documentEditorControl.Save(out rtfData, StringStreamType.RichTextFormat);
            DateTime currentDate = DateTime.Now;
            
            SilentAuctionDataSet.AuctionsRow row = silentAuctionDataSet.Auctions.FirstOrDefault(a => a.Id == AuctionId);
            if (row != null)
            {
                switch (DocType)
                {
                    case DonationDocumentType.DonationRequestDocument:
                        row.DonationRequestDocument = rtfData;
                        break;
                    case DonationDocumentType.DonationFollowUpDocument:
                        row.DonationFollowUpDocument = rtfData;
                        break;
                }
                row.ModifiedDate = currentDate.ToString();
            }

            SilentAuctionDataSet.AuctionsDataTable modifiedItems =
                (SilentAuctionDataSet.AuctionsDataTable)silentAuctionDataSet.Auctions.GetChanges(DataRowState.Modified);

            if (modifiedItems != null)
            {
                auctionsTableAdapter.Update(modifiedItems);
                silentAuctionDataSet.AcceptChanges();
                modifiedItems.Dispose();
                silentAuctionDataSet.Donors.Clear();
                auctionsTableAdapter.FillAuctions(silentAuctionDataSet.Auctions);
                donorsTableAdapter.FillDonors(silentAuctionDataSet.Donors, AuctionId);
            }
        }

        private string GetDocumentData()
        {
            string rtfData = "";
            SilentAuctionDataSet.AuctionsRow row = silentAuctionDataSet.Auctions.FirstOrDefault(a => a.Id == AuctionId);
            if (row != null)
            {
                switch (DocType)
                {
                    case DonationDocumentType.DonationRequestDocument:
                        rtfData = row.DonationRequestDocument.ToString();
                        break;
                    case DonationDocumentType.DonationFollowUpDocument:
                        rtfData = row.DonationFollowUpDocument.ToString();
                        break;
                }
            }

            return rtfData;
        }

        private void PrintDocuments()
        {
            List<int> donorIdsToPrint = new List<int>();

            DonorSelections donorSelections = new DonorSelections(AuctionId);
            DialogResult result = donorSelections.ShowDialog();
            if (result == DialogResult.OK)
            {
                donorIdsToPrint = donorSelections.DonorIdsToPrint;
            }
            else if (result == DialogResult.Cancel)
                return;

            DialogResult = DialogResult.None;


            foreach (int donorId in donorIdsToPrint)
            {
                SilentAuctionDataSet.DonorsRow row = silentAuctionDataSet.Donors.FirstOrDefault(d => d.Id == donorId);
                if (row != null)
                {
                    //string contactName = row.ContactName;

                    foreach (TextField field in documentEditorControl.TextFields)
                    {
                        switch (field.Name)
                        {
                            case Company:
                                field.Text = row.Name;
                                break;
                            case ContactName:
                                field.Text = row.ContactName;
                                break;
                            case Street1:
                                field.Text = row.Street1;
                                break;
                            case Street2:
                                field.Text = row.Street2;
                                break;
                            case City:
                                field.Text = row.City;
                                break;
                            case State:
                                field.Text = row.State;
                                break;
                            case ZipCode:
                                field.Text = row.ZipCode;
                                break;
                        }
                    }

                    documentEditorControl.Print(printDocumentMain);

                    foreach (TextField field in documentEditorControl.TextFields)
                    {
                        switch (field.Name)
                        {
                            case Company:
                                field.Text = Company;
                                break;
                            case ContactName:
                                field.Text = ContactName;
                                break;
                            case Street1:
                                field.Text = Street1;
                                break;
                            case Street2:
                                field.Text = Street2;
                                break;
                            case City:
                                field.Text = City;
                                break;
                            case State:
                                field.Text = State;
                                break;
                            case ZipCode:
                                field.Text = ZipCode;
                                break;
                        }
                    }
                }
            }
        }

        private void InsertNewField(string fieldType)
        {
            TextField newField = new TextField
            {
                Text = fieldType,
                Name = fieldType,
                ID = _fieldId,
                DoubledInputPosition = true,
                ShowActivated = true
            };

            // Insert a new field and increase field ID
            _fieldId += 1;
            documentEditorControl.TextFields.Add(newField);
        }

        private void CheckListMenuItem()
        {
            // Uncheck all list items
            foreach (var obj in formatListToolStripMenuItem.DropDownItems)
            {
                var item = obj as ToolStripMenuItem;
                if (item == null) continue;

                item.Checked = false;
            }

            switch (documentEditorControl.Selection.ListFormat.Type)
            {
                case ListType.Bulleted:
                    formatListBulletsToolStripMenuItem.Checked = true;
                    return;

                case ListType.None: return;
            }

            switch (documentEditorControl.Selection.ListFormat.NumberFormat)
            {
                case NumberFormat.ArabicNumbers:
                    formatListArabicNumberstoolStripMenuItem.Checked = true;
                    break;

                case NumberFormat.CapitalLetters:
                    formatListCapitalLettersToolStripMenuItem.Checked = true;
                    break;

                //case NumberFormat.Letters:
                //    mnuFormat_List_Letters.Checked = true;
                //    break;

                //case NumberFormat.RomanNumbers:
                //    mnuFormat_List_RomanNumbers.Checked = true;
                //    break;

                //case NumberFormat.SmallRomanNumbers:
                //    mnuFormat_List_SmallRomanNumbers.Checked = true;
                //    break;
            }
        }
        #endregion

    }
}
