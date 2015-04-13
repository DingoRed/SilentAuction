using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SilentAuction.SilentAuctionDataSetTableAdapters;
using SilentAuction.Utilities;
using TXTextControl;
using HorizontalAlignment = TXTextControl.HorizontalAlignment;
using Image = TXTextControl.Image;

namespace SilentAuction.Forms
{
    public partial class DocumentEditor : Form
    {
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
        private const string TitleText = "Document Editor - ";
        #endregion

        #region Properties
        private int AuctionId { get; set; }
        private int DocumentId { get; set; }
        #endregion
        
        #region Constructors
        public DocumentEditor(int auctionId)
        {
            AuctionId = auctionId;
            
            InitializeComponent();
        }
        #endregion

        #region Form Event Handlers
        private void DocumentEditorLoad(object sender, EventArgs e)
        {
            auctionsTableAdapter.FillAuctions(silentAuctionDataSet.Auctions);
            documentsTableAdapter.FillDocuments(silentAuctionDataSet.Documents);

            SetupToolStripMenuItems();
            Text = TitleText + "(new)";
            WindowSettings.SetupInitialWindow(this, "DocumentEditorInitialLocation");
        }

        private void DocumentEditorFormClosing(object sender, FormClosingEventArgs e)
        {
            if (_documentIsDirty)
            {
                DialogResult dlgRes = MessageBox.Show("Save changes before exiting?", "Save Changes", MessageBoxButtons.YesNoCancel);
                if (dlgRes == DialogResult.Yes)
                {
                    FileSave();
                    _documentIsDirty = false;
                }
                else if (dlgRes == DialogResult.Cancel)
                    return;
            }

            WindowSettings.SaveWindowSettings(this, "DocumentEditorInitialLocation");
        }

        private void DocumentEditorControlKeyPress(object sender, KeyPressEventArgs e)
        {
            SetIsDirty();

        }
        #endregion

        #region Menu Items Event Handlers
        #region File Menu Items Event Handlers
        private void NewDocumentToolStripMenuItemClick(object sender, EventArgs e)
        {
            FileNew();
        }

        private void OpenToolStripMenuItemClick(object sender, EventArgs e)
        {
            FileOpen();
        }

        private void SaveToolStripMenuItemClick(object sender, EventArgs e)
        {
            FileSave();
        }

        private void PageSetupToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO: Implement Page Setup?
            //PageSetup.pageSetup_Click(sender, e, _textControl, _fileHandler);
            MessageBox.Show("Should this be implemented??");
        }

        private void PrintToolStripMenuItemClick(object sender, EventArgs e)
        {
            FilePrint();
        }

        private void EmailToolStripMenuItemClick(object sender, EventArgs e)
        {
            FileEmail();
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
            SetIsDirty();
        }

        private void RedoToolStripMenuItemClick(object sender, EventArgs e)
        {
            documentEditorControl.Redo();
            SetIsDirty();
        }

        private void CutToolStripMenuItemClick(object sender, EventArgs e)
        {
            documentEditorControl.Cut();
            SetIsDirty();
        }

        private void CopyToolStripMenuItemClick(object sender, EventArgs e)
        {
            documentEditorControl.Copy();
            SetIsDirty();
        }

        private void PasteToolStripMenuItemClick(object sender, EventArgs e)
        {
            documentEditorControl.Paste();
            SetIsDirty();
        }

        private void DeleteToolStripMenuItemClick(object sender, EventArgs e)
        {
            documentEditorControl.Clear();
            SetIsDirty();
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
            if(documentEditorControl.Images.Add(imageNew, HorizontalAlignment.Left, -1, ImageInsertionMode.DisplaceText))
                SetIsDirty();
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
            SetIsDirty();
        }

        #endregion

        #region Format Menu Items Event Handlers
        private void FormatToolStripMenuItemDropDownOpening(object sender, EventArgs e)
        {
            formatImageToolStripMenuItem.Enabled = (documentEditorControl.Images.GetItem() != null);
        }

        private void FormatCharacterToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (documentEditorControl.FontDialog() == DialogResult.OK)
                SetIsDirty();
        }

        private void FormatParagraphToolStripMenuItemClick(object sender, EventArgs e)
        {
            if(documentEditorControl.ParagraphFormatDialog() == DialogResult.OK)
                SetIsDirty();
        }

        private void FormatStylesToolStripMenuItemClick(object sender, EventArgs e)
        {
            if(documentEditorControl.FormattingStylesDialog() == DialogResult.OK)
                SetIsDirty();
        }

        private void FormatTabsToolStripMenuItemClick(object sender, EventArgs e)
        {
            if(documentEditorControl.TabDialog() == DialogResult.OK)
                SetIsDirty();
        }

        private void FormatImageToolStripMenuItemClick(object sender, EventArgs e)
        {
            if(documentEditorControl.ImageAttributesDialog() == DialogResult.OK)
                SetIsDirty();
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
            if(documentEditorControl.ListFormatDialog() == DialogResult.OK)
                SetIsDirty();
        }

        private void FormatListArabicNumberstoolStripMenuItemClick(object sender, EventArgs e)
        {
            SetIsDirty();
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
            SetIsDirty();
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
            SetIsDirty();
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
            SetIsDirty();
        }

        private void FormatListDecreaseLevelToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (documentEditorControl.Selection.ListFormat.Level >= 2)
            {
                documentEditorControl.Selection.ListFormat.Level -= 1;
                documentEditorControl.Selection.DecreaseIndent();
                SetIsDirty();
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
                SetIsDirty();
            }
        }

        private void TableInsertColumnToTheLeftToolStripMenuItemClick(object sender, EventArgs e)
        {
            if(documentEditorControl.Tables.GetItem().Columns.Add(TableAddPosition.Before))
                SetIsDirty();
        }

        private void TableInsertColumnToTheRightToolStripMenuItemClick(object sender, EventArgs e)
        {
            if(documentEditorControl.Tables.GetItem().Columns.Add(TableAddPosition.After))
                SetIsDirty();
        }

        private void TableInsertRowAboveToolStripMenuItemClick(object sender, EventArgs e)
        {
            if(documentEditorControl.Tables.GetItem().Rows.Add(TableAddPosition.Before, 1))
                SetIsDirty();
        }

        private void TableInsertRowBelowToolStripMenuItemClick(object sender, EventArgs e)
        {
            if(documentEditorControl.Tables.GetItem().Rows.Add(TableAddPosition.After, 1))
                SetIsDirty();
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
            if(documentEditorControl.Tables.Remove())
                SetIsDirty();
        }

        private void TableDeleteColumnToolStripMenuItemClick(object sender, EventArgs e)
        {
            if(documentEditorControl.Tables.GetItem().Columns.Remove())
                SetIsDirty();
        }

        private void TableDeleteRowsToolStripMenuItemClick(object sender, EventArgs e)
        {
            if(documentEditorControl.Tables.GetItem().Rows.Remove())
                SetIsDirty();
        }

        private void TableDeleteCellsShiftCellsLeftToolStripMenuItemClick(object sender, EventArgs e)
        {
            if(documentEditorControl.Tables.GetItem().Cells.Remove())
                SetIsDirty();
        }

        private void TableDeleteCellsDeleteEntireRowToolStripMenuItemClick(object sender, EventArgs e)
        {
            if(documentEditorControl.Tables.GetItem().Rows.Remove())
                SetIsDirty();
        }

        private void TableDeleteDeleteEntireColumnToolStripMenuItemClick(object sender, EventArgs e)
        {
            if(documentEditorControl.Tables.GetItem().Columns.Remove())
                SetIsDirty();
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
            if(documentEditorControl.Tables.GetItem().MergeCells())
                SetIsDirty();
        }

        private void TableSplitCellsToolStripMenuItemClick(object sender, EventArgs e)
        {
            if(documentEditorControl.Tables.GetItem().SplitCells())
                SetIsDirty();
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
            if(documentEditorControl.Tables.GetItem().Split(TableAddPosition.Before))
                SetIsDirty();
        }

        private void TableSplitTableBelowToolStripMenuItemClick(object sender, EventArgs e)
        {
            if(documentEditorControl.Tables.GetItem().Split(TableAddPosition.After))
                SetIsDirty();
        }

        private void TableGridLinesToolStripMenuItemClick(object sender, EventArgs e)
        {
            documentEditorControl.Tables.GridLines = !documentEditorControl.Tables.GridLines;
        }

        private void TablePropertiesToolStripMenuItemClick(object sender, EventArgs e)
        {
            if(documentEditorControl.TableFormatDialog() == DialogResult.OK)
                SetIsDirty();
        }
        #endregion
        #endregion

        #region Context Menu Items Event Handlers
        private void ContextMenuCutClick(object sender, EventArgs e)
        {
            documentEditorControl.Cut();
            SetIsDirty();
        }

        private void ContextMenuCopyClick(object sender, EventArgs e)
        {
            documentEditorControl.Copy();
            SetIsDirty();
        }

        private void ContextMenuPasteClick(object sender, EventArgs e)
        {
            documentEditorControl.Paste();
            SetIsDirty();
        }

        private void ContextMenuCharacterClick(object sender, EventArgs e)
        {
            if(documentEditorControl.FontDialog() == DialogResult.OK)
                SetIsDirty();
        }

        private void ContextMenuParagraphClick(object sender, EventArgs e)
        {
            if(documentEditorControl.ParagraphFormatDialog() == DialogResult.OK)
                SetIsDirty();
        }

        private void ContextMenuBulletsAndNumberingClick(object sender, EventArgs e)
        {
            if(documentEditorControl.ListFormatDialog() == DialogResult.OK)
                SetIsDirty();
        }

        private void ContextMenuStylesClick(object sender, EventArgs e)
        {
            if(documentEditorControl.FormattingStylesDialog() == DialogResult.OK)
                SetIsDirty();
        }

        private void ContextMenuInsertTableClick(object sender, EventArgs e)
        {
            if (documentEditorControl.Tables.Add())
            {
                SetIsDirty();
            }
        }

        private void ContextMenuInsertImageClick(object sender, EventArgs e)
        {
            Image imageNew = new Image();
            if (documentEditorControl.Images.Add(imageNew, HorizontalAlignment.Left, -1, ImageInsertionMode.DisplaceText))
                SetIsDirty();
        }
        #endregion

        #region Toolstrip Button Items Event Handlers
        private void NewDocumentToolStripButtonClick(object sender, EventArgs e)
        {
            FileNew();
        }

        private void OpenToolStripButtonClick(object sender, EventArgs e)
        {
            if (_documentIsDirty)
            {
                DialogResult dlgRes = MessageBox.Show("Save changes before exiting?", "Save Changes", MessageBoxButtons.YesNoCancel);
                if (dlgRes == DialogResult.Yes)
                {
                    FileSave();
                    _documentIsDirty = false;
                }
                else if (dlgRes == DialogResult.Cancel)
                    return;
            }

            FileOpen();
        }

        private void SaveToolStripButtonClick(object sender, EventArgs e)
        {
            FileSave();
        }

        private void SaveAsToolStripButtonClick(object sender, EventArgs e)
        {
            FileSaveAs();
        }

        private void PrintToolStripButtonClick(object sender, EventArgs e)
        {
            FilePrint();
        }

        private void EmailToolStripButtonClick(object sender, EventArgs e)
        {
            FileEmail();
        }

        private void CutToolStripButtonClick(object sender, EventArgs e)
        {
            documentEditorControl.Cut();
            SetIsDirty();
        }

        private void CopyToolStripButtonClick(object sender, EventArgs e)
        {
            documentEditorControl.Copy();
            SetIsDirty();
        }

        private void PasteToolStripButtonClick(object sender, EventArgs e)
        {
            documentEditorControl.Paste();
            SetIsDirty();
        }

        private void DeleteToolStripButtonClick(object sender, EventArgs e)
        {
            documentEditorControl.Clear();
            SetIsDirty();
        }

        private void UndoToolStripButtonClick(object sender, EventArgs e)
        {
            documentEditorControl.Undo();
            SetIsDirty();
        }

        private void RedoToolStripButtonClick(object sender, EventArgs e)
        {
            documentEditorControl.Redo();
            SetIsDirty();
        }

        #endregion

        #region Private Methods

        private void SetIsDirty()
        {
            _documentIsDirty = true;
            bottomToolStripStatusLabel.Visible = false;
        }

        private void FileNew()
        {
            if (_documentIsDirty)
            {
                switch (MessageBox.Show("Save changes?", "Save Changes", MessageBoxButtons.YesNoCancel))
                {
                    case DialogResult.Yes:
                        FileSave();
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        return;
                }
            }

            documentEditorControl.ResetContents();
            _documentIsDirty = false;
            SetupToolStripMenuItems();
            Text = TitleText + "(new)";
        }

        private void FileSave()
        {
            if (DocumentId <= 0)
            {
                FileSaveAs();
                return;
            }

            string rtfData;
            documentEditorControl.Save(out rtfData, StringStreamType.RichTextFormat);

            SilentAuctionDataSet.DocumentsRow dRow = silentAuctionDataSet.Documents.FirstOrDefault(d => d.Id == DocumentId);
            if (dRow != null)
            {
                dRow.Document = rtfData;

                SilentAuctionDataSet.DocumentsDataTable modifiedItems =
                    (SilentAuctionDataSet.DocumentsDataTable)silentAuctionDataSet.Documents.GetChanges(DataRowState.Modified);

                if (modifiedItems != null)
                {
                    documentsTableAdapter.Update(modifiedItems);
                    silentAuctionDataSet.AcceptChanges();
                    modifiedItems.Dispose();
                    _documentIsDirty = false;
                    bottomToolStripStatusLabel.Visible = true;
                }

                Text = TitleText + dRow.Name;
                SetupToolStripMenuItems();
            }
        }

        private void FileSaveAs()
        {
            using (DocumentNameEntry documentNameEntry = new DocumentNameEntry())
            {
                DialogResult dialogResult = documentNameEntry.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    string rtfData;
                    documentEditorControl.Save(out rtfData, StringStreamType.RichTextFormat);

                    SilentAuctionDataSet.AuctionsRow auctionsRow =
                        silentAuctionDataSet.Auctions.FirstOrDefault(a => a.Id == AuctionId);

                    silentAuctionDataSet.Documents.AddDocumentsRow(auctionsRow, documentNameEntry.DocumentName, rtfData);

                    SilentAuctionDataSet.DocumentsDataTable newDocuments =
                        (SilentAuctionDataSet.DocumentsDataTable)silentAuctionDataSet.Documents.GetChanges(DataRowState.Added);

                    if (newDocuments != null)
                    {
                        documentsTableAdapter.Update(newDocuments);
                        silentAuctionDataSet.AcceptChanges();
                        newDocuments.Dispose();
                        documentsTableAdapter.FillDocuments(silentAuctionDataSet.Documents);
                        _documentIsDirty = false;
                        DocumentId = (int) silentAuctionDataSet.Documents.Max(a => a.Id);
                        bottomToolStripStatusLabel.Visible = true;
                    }

                    Text = TitleText + documentNameEntry.DocumentName;
                    SetupToolStripMenuItems();
                }
            }
        }

        private void FileOpen()
        {
            using (DocumentOpenForm documentSelection = new DocumentOpenForm(AuctionId))
            {
                DialogResult dialogResult = documentSelection.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    SilentAuctionDataSet.DocumentsRow row =
                        silentAuctionDataSet.Documents.FirstOrDefault(d => d.Id == documentSelection.DocumentId);

                    if (row != null)
                    {
                        if (!string.IsNullOrEmpty(row.Document))
                        {
                            documentEditorControl.Load(row.Document, StringStreamType.RichTextFormat);
                            SetupToolStripMenuItems();
                            Text = TitleText + row.Name;
                            DocumentId = documentSelection.DocumentId;
                        }
                    }
                }
            }
        }

        private void FilePrint()
        {
            List<int> donorIdsToPrint = new List<int>();

            DocumentPrintForm donorSelections = new DocumentPrintForm(AuctionId);
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
                // TODO: Donors is empty?
                SilentAuctionDataSet.DonorsRow row = silentAuctionDataSet.Donors.FirstOrDefault(d => d.Id == donorId);
                if (row != null)
                {
                    MergeTextFields(row);
                    documentEditorControl.Print(printDocumentMain);
                    ResetTextFields();
                }
            }
        }

        private void FileEmail()
        {
            List<int> donorIdsToEmail = new List<int>();
            List<string> errorEmails = new List<string>();

            DocumentEmailForm emailForm = new DocumentEmailForm(AuctionId);
            DialogResult result = emailForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                donorIdsToEmail = emailForm.DonorIdsToEmail;
            }
            else if (result == DialogResult.Cancel)
            {
                return;
            }

            DialogResult = DialogResult.None;

            foreach (int donorId in donorIdsToEmail)
            {
                SilentAuctionDataSet.DonorsDataTable tbl = new DonorsTableAdapter().GetDonorsData(AuctionId);
                SilentAuctionDataSet.DonorsRow row = tbl.FirstOrDefault(d => d.Id == donorId); 
                if (row != null)
                {
                    List<string> emailList = new List<string>();
                    emailList.Add(row.Email);

                    MergeTextFields(row);

                    // TODO: Figure out what to do when behind firewall
                    // TODO: Show progress screen?
                    string body;
                    documentEditorControl.Save(out body, StringStreamType.HTMLFormat);
                    if (!EmailHelper.SendEmail(emailForm.Account, emailForm.Password, emailForm.Account,
                        emailList, emailForm.CcAddressList, emailForm.Subject, body))
                    {
                        errorEmails.Add(row.Email);
                    }

                    ResetTextFields();
                }
            }

            if (errorEmails.Count > 0)
            {
                string msg = "Unable to send to the following email addresses:\r\n";
                foreach (string errorEmail in errorEmails)
                {
                    msg += errorEmail + "\r\n";
                }

                MessageBox.Show(string.Format(msg), "Error Sending Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if(documentEditorControl.TextFields.Add(newField))
                SetIsDirty();
        }

        private void MergeTextFields(SilentAuctionDataSet.DonorsRow row)
        {
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
        }

        private void ResetTextFields()
        {
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

        private void SetupToolStripMenuItems()
        {
            openToolStripButton.Enabled = silentAuctionDataSet.Documents.Rows.Count > 0;
            openToolStripMenuItem.Enabled = silentAuctionDataSet.Documents.Rows.Count > 0;
        }
        #endregion

    }
}
