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
    public partial class DonorAddForm : MetroForm
    {
        #region Constructor and Form Methods
        public DonorAddForm()
        {
            InitializeComponent();
        }

        private void DonorAddFormLoad(object sender, EventArgs e)
        {
            FillDonorTypeComboBox();
        }
        #endregion

        #region Event Handlers
        private void SubmitButtonClick(object sender, EventArgs e)
        {
            int donorTypeId = MathHelper.ParseIntZeroIfNull(DonorTypeComboBox.SelectedValue.ToString());
            if (donorTypeId <= 0)
                return;

            DateTime currentDate = DateTime.Now;
            IDonorRepository donorRepository = new AdoDonorRepository();

            Donor donor = new Donor
            {
                DonorTypeId = donorTypeId,
                Name = NameTextBox.Text,
                ContactName = ContactNameTextBox.Text,
                Street1 = Street1TextBox.Text,
                Street2 = Street2TextBox.Text,
                City = CityTextBox.Text,
                State = StateComboBox.SelectedValue == null ? "" : StateComboBox.SelectedValue.ToString(),
                ZipCode = ZipCodeTextBox.Text,
                Phone1 = Phone1TextBox.Text,
                Extension1 = Extension1TextBox.Text,
                Phone2 = Phone2TextBox.Text,
                Extension2 = Extension2TextBox.Text,
                Email = EmailTextBox.Text,
                CreateDate = currentDate,
                ModifiedDate = currentDate
            };

            if (donorRepository.Add(donor))
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

        private void FillDonorTypeComboBox()
        {
            IDonorTypeRepository donorTypeRepository = new AdoDonorTypeRepository();
            List<DonorType> donorTypes = donorTypeRepository.GetDonorTypes().OrderBy(a => a.Name).ToList();
            donorTypes.Insert(0, new DonorType{Id = -1, Name = "-- Please Select --" });
            DonorTypeComboBox.DataSource = donorTypes;
            DonorTypeComboBox.ValueMember = "Id";
            DonorTypeComboBox.DisplayMember = "Name";
        }
        #endregion

    }
}
