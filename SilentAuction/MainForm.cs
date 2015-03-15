using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using SilentAuction.Core.Abstract;
using SilentAuction.Core.Concrete;
using SilentAuction.Core.Entities;
using SilentAuction.Forms;
using SilentAuction.SilentAuctionDataSetTableAdapters;
using SilentAuction.Utilities.Extensions;
using SilentAuction.Utilities.General;

namespace SilentAuction
{
    public partial class MainForm : MetroForm
    {
        #region Constructor and Form Methods
        public MainForm()
        {
            InitializeComponent();

            

        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'silentAuctionDataSet.Auctions' table. You can move, or remove it, as needed.
            auctionsTableAdapter.FillAuctions(silentAuctionDataSet.Auctions);

            //itemsToolStripComboBox.ComboBox.Items.AddRange(new object[] {"1", "2", "3", "4"});

            List<Auction> auctions = silentAuctionDataSet.Auctions.DataTableToList<Auction>();

            //auctionsBindingSource.DataSource = silentAuctionDataSet.Auctions;
            //itemsToolStripComboBox.ComboBox.BindingContext = BindingContext;
            //itemsToolStripComboBox.ComboBox.DataSource = auctionsBindingSource.DataSource;
            //itemsToolStripComboBox.ComboBox.DisplayMember = "Id";
            //itemsToolStripComboBox.ComboBox.DisplayMember = "Name";
            //itemsToolStripComboBox.ComboBox.Items.Insert(0, new object[]{0,""});


            
            //auctions.Insert(0, new Auction{Id = 0, Name = ""});

            if (itemsToolStripComboBox.ComboBox != null)
            {
                //itemsToolStripComboBox.ComboBox.DataSource = auctions;
                itemsToolStripComboBox.ComboBox.Items.AddRange(auctions.ToArray());
                itemsToolStripComboBox.ComboBox.ValueMember = "Id";
                itemsToolStripComboBox.ComboBox.DisplayMember = "Name";
            }



            // TODO: This line of code loads data into the 'silentAuctionDataSet.Donors' table. You can move, or remove it, as needed.
            donorsTableAdapter.FillDonors(silentAuctionDataSet.Donors);
            // TODO: This line of code loads data into the 'silentAuctionDataSet.Items' table. You can move, or remove it, as needed.
            //itemsTableAdapter.FillItemsByAuctionId(this.silentAuctionDataSet.Items, 0);






            //FillAuctionComboBox();

            //FillItemsGrid();
            //FillDonorsGrid();
            //FillAuctionsGrid();
            
        }
        #endregion

        #region Event Handlers
        //private void CreateItemButtonClick(object sender, EventArgs e)
        //{
        //    ItemAddForm itemsForm = new ItemAddForm();
        //    int auctionId = MathHelper.ParseIntZeroIfNull(AuctionComboBox.SelectedValue.ToString());
        //    itemsForm.AuctionId = auctionId;
        //    itemsForm.ShowDialog();
        //    FillItemsGrid();
        //}

        private void CreateAuctionButtonClick(object sender, EventArgs e)
        {
            //AuctionAddForm auctionsForm = new AuctionAddForm();
            //int auctionId = MathHelper.ParseIntZeroIfNull(AuctionComboBox.SelectedValue.ToString());
            //auctionsForm.ShowDialog();
            //FillAuctionsGrid();
            //FillAuctionComboBox();
            //AuctionComboBox.SelectedValue = auctionId;
        }

        private void CreateDonorButtonClick(object sender, EventArgs e)
        {
            //DonorAddForm donorsForm = new DonorAddForm();
            //donorsForm.ShowDialog();
            //FillDonorsGrid();
        }

        //private void AuctionComboBoxSelectedIndexChanged(object sender, EventArgs e)
        //{
        //    FillItemsGrid();
        //    int auctionId = MathHelper.ParseIntZeroIfNull(AuctionComboBox.SelectedValue.ToString());
        //    CreateItemButton.Enabled = auctionId > 0;
        //}

        private void MainFormFormClosed(object sender, FormClosedEventArgs e)
        {
            MetroMessageBox.Show(this, "Save window location, etc.");
        }
        #endregion

        #region Private Methods
        //private void FillItemsGrid()
        //{
        //    int auctionId = MathHelper.ParseIntZeroIfNull(AuctionComboBox.SelectedValue.ToString());
        //    if (auctionId > 0)
        //    {
        //        IItemRepository itemRepository = new AdoItemRepository();
        //        var items = itemRepository.GetItems(auctionId).OrderBy(a => a.DonorId).ToList();
        //        ItemsGrid.DataSource = items;
        //    }
        //}

        //private void FillDonorsGrid()
        //{
        //    IDonorRepository donorRepository = new AdoDonorRepository();
        //    var donors = donorRepository.GetDonors();
        //    DonorsGrid.DataSource = donors;
        //}

        //private void FillAuctionsGrid()
        //{
        //    IAuctionRepository auctionRepository = new AdoAuctionRepository();
        //    AuctionsGrid.DataSource = auctionRepository.GetAuctions();
        //}

        //private void FillAuctionComboBox()
        //{
        //    IAuctionRepository auctionRepository = new AdoAuctionRepository();
        //    List<Auction> auctions = auctionRepository.GetAuctions().OrderBy(a => a.Name).ToList();
        //    auctions.Insert(0, new Auction{Id = -1, Name = "-- Please Select --"});
        //    AuctionComboBox.DataSource = auctions;
        //    AuctionComboBox.ValueMember = "Id";
        //    AuctionComboBox.DisplayMember = "Name";
        //}

        #endregion


        private void ItemsToolStripComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //itemsTableAdapter.FillItemsByAuctionId(silentAuctionDataSet.Items,
                //    MathHelper.ParseIntZeroIfNull(itemsToolStripComboBox.SelectedItem.ToString()));

            //    itemsTableAdapter.FillItemsByAuctionId(silentAuctionDataSet.Items,
            //        ((long)(Convert.ChangeType(
            //        (((DataRowView)(itemsToolStripComboBox.SelectedItem)).Row).ItemArray[0].ToString(),
            //        typeof(long)))));

                itemsTableAdapter.FillItems(silentAuctionDataSet.Items,
                    ((Auction)itemsToolStripComboBox.SelectedItem).Id);

                //itemsTableAdapter.FillItemsByAuctionId(silentAuctionDataSet.Items,
                //        ((long)(Convert.ChangeType(
                //        ((Auction)itemsToolStripComboBox.SelectedItem).Id,
                //        typeof(long)))));
            
            
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ItemsGridDataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
        }







    }
}
