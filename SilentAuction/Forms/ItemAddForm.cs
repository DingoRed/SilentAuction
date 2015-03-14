using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using SilentAuction.Core.Abstract;
using SilentAuction.Core.Concrete;
using SilentAuction.Core.Entities;
using SilentAuction.Utilities.General;

namespace SilentAuction.Forms
{
    public partial class ItemAddForm : MetroForm
    {
        public int AuctionId { get; set; }

        #region Constructor and Form Methods
        public ItemAddForm()
        {
            InitializeComponent();
        }
        
        private void ItemAddFormLoad(object sender, EventArgs e)
        {
            if (AuctionId <= 0)
            {
                DialogResult = DialogResult.Abort;
                Close();
            }
            else
            {
                FillDonorComboBox();
            }
        }        
        #endregion

        #region Event Handlers
        private void SubmitButtonClick(object sender, EventArgs e)
        {
            int donorId = MathHelper.ParseIntZeroIfNull(DonorComboBox.SelectedValue.ToString());
            if (donorId <= 0 || AuctionId <= 0)
                return;

            DateTime currentDate = DateTime.Now;
            IItemRepository itemRepository = new AdoItemRepository();

            Item item = new Item
            {
                DonorId = donorId,
                AuctionId = AuctionId,
                Name = NameTextBox.Text,
                Description = DescriptionTextBox.Text,
                Qty = (int) QtyNumericUpDown.Value,
                Notes = NotesTextBox.Text,
                CreateDate = currentDate,
                ModifiedDate = currentDate
            };

            if(itemRepository.Add(item))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                DialogResult = DialogResult.Abort;
                Close();
            }
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        #endregion

        #region Private Methods
        private void FillDonorComboBox()
        {
            IDonorRepository donorRepository = new AdoDonorRepository();
            List<Donor> donors = donorRepository.GetDonors().OrderBy(a => a.Name).ToList();
            donors.Insert(0, new Donor { Id = -1, Name = "-- Please Select --" });
            DonorComboBox.DataSource = donors;
            DonorComboBox.ValueMember = "Id";
            DonorComboBox.DisplayMember = "Name";
        }

        #endregion

        private void DonorComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            int donorId = MathHelper.ParseIntZeroIfNull(DonorComboBox.SelectedValue.ToString());
            SubmitButton.Enabled = (donorId > 0);
        }

    }
}
