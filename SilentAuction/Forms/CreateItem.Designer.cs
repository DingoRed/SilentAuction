namespace SilentAuction.Forms
{
    partial class CreateNewItemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewItemForm));
            this.label16 = new System.Windows.Forms.Label();
            this.AuctionsComboBox = new System.Windows.Forms.ComboBox();
            this.auctionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.silentAuctionDataSet = new SilentAuction.SilentAuctionDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.DonorsComboBox = new System.Windows.Forms.ComboBox();
            this.donorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ItemPictureBox = new System.Windows.Forms.PictureBox();
            this.DonationDeliveryTypesComboBox = new System.Windows.Forms.ComboBox();
            this.donationDeliveryTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ItemTypesComboBox = new System.Windows.Forms.ComboBox();
            this.itemTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NotesTextBox = new System.Windows.Forms.TextBox();
            this.QtyTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BidCalculatorButton = new System.Windows.Forms.Button();
            this.NumberOfBidsTextBox = new System.Windows.Forms.TextBox();
            this.BidIncrementTypesComboBox = new System.Windows.Forms.ComboBox();
            this.bidIncrementTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BidIncrementValueTextBox = new System.Windows.Forms.TextBox();
            this.MaximumBidTextBox = new System.Windows.Forms.TextBox();
            this.MinimumBidTextBox = new System.Windows.Forms.TextBox();
            this.BuyItNowTextBox = new System.Windows.Forms.TextBox();
            this.RetailValueTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SaveItemButton = new System.Windows.Forms.Button();
            this.SaveItemAndCloseButton = new System.Windows.Forms.Button();
            this.CancelItemButton = new System.Windows.Forms.Button();
            this.auctionsTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.AuctionsTableAdapter();
            this.donorsTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.DonorsTableAdapter();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemTypesTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.ItemTypesTableAdapter();
            this.bidIncrementTypesTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.BidIncrementTypesTableAdapter();
            this.donationDeliveryTypesTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.DonationDeliveryTypesTableAdapter();
            this.itemErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.itemsTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.ItemsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.auctionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationDeliveryTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTypesBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bidIncrementTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(106, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "Auction:";
            // 
            // AuctionsComboBox
            // 
            this.AuctionsComboBox.DataSource = this.auctionsBindingSource;
            this.AuctionsComboBox.DisplayMember = "Name";
            this.AuctionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AuctionsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuctionsComboBox.FormattingEnabled = true;
            this.AuctionsComboBox.Location = new System.Drawing.Point(158, 12);
            this.AuctionsComboBox.Name = "AuctionsComboBox";
            this.AuctionsComboBox.Size = new System.Drawing.Size(200, 21);
            this.AuctionsComboBox.TabIndex = 1;
            this.AuctionsComboBox.ValueMember = "Id";
            this.AuctionsComboBox.SelectedIndexChanged += new System.EventHandler(this.AuctionsComboBoxSelectedIndexChanged);
            // 
            // auctionsBindingSource
            // 
            this.auctionsBindingSource.DataMember = "Auctions";
            this.auctionsBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // silentAuctionDataSet
            // 
            this.silentAuctionDataSet.DataSetName = "SilentAuctionDataSet";
            this.silentAuctionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Donor:";
            // 
            // DonorsComboBox
            // 
            this.DonorsComboBox.DataSource = this.donorsBindingSource;
            this.DonorsComboBox.DisplayMember = "Name";
            this.DonorsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DonorsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DonorsComboBox.FormattingEnabled = true;
            this.DonorsComboBox.Location = new System.Drawing.Point(434, 12);
            this.DonorsComboBox.Name = "DonorsComboBox";
            this.DonorsComboBox.Size = new System.Drawing.Size(200, 21);
            this.DonorsComboBox.TabIndex = 2;
            this.DonorsComboBox.ValueMember = "Id";
            // 
            // donorsBindingSource
            // 
            this.donorsBindingSource.DataMember = "Donors";
            this.donorsBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.ItemPictureBox);
            this.groupBox1.Controls.Add(this.DonationDeliveryTypesComboBox);
            this.groupBox1.Controls.Add(this.ItemTypesComboBox);
            this.groupBox1.Controls.Add(this.NotesTextBox);
            this.groupBox1.Controls.Add(this.QtyTextBox);
            this.groupBox1.Controls.Add(this.DescriptionTextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.NameTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 278);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Information";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(487, 257);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "(click above to add image)";
            // 
            // ItemPictureBox
            // 
            this.ItemPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ItemPictureBox.Location = new System.Drawing.Point(478, 104);
            this.ItemPictureBox.Name = "ItemPictureBox";
            this.ItemPictureBox.Size = new System.Drawing.Size(150, 150);
            this.ItemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ItemPictureBox.TabIndex = 35;
            this.ItemPictureBox.TabStop = false;
            this.ItemPictureBox.Click += new System.EventHandler(this.ItemPictureBoxClick);
            // 
            // DonationDeliveryTypesComboBox
            // 
            this.DonationDeliveryTypesComboBox.DataSource = this.donationDeliveryTypesBindingSource;
            this.DonationDeliveryTypesComboBox.DisplayMember = "Name";
            this.DonationDeliveryTypesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DonationDeliveryTypesComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DonationDeliveryTypesComboBox.FormattingEnabled = true;
            this.DonationDeliveryTypesComboBox.Location = new System.Drawing.Point(478, 64);
            this.DonationDeliveryTypesComboBox.Name = "DonationDeliveryTypesComboBox";
            this.DonationDeliveryTypesComboBox.Size = new System.Drawing.Size(150, 21);
            this.DonationDeliveryTypesComboBox.TabIndex = 6;
            this.DonationDeliveryTypesComboBox.ValueMember = "Id";
            // 
            // donationDeliveryTypesBindingSource
            // 
            this.donationDeliveryTypesBindingSource.DataMember = "DonationDeliveryTypes";
            this.donationDeliveryTypesBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // ItemTypesComboBox
            // 
            this.ItemTypesComboBox.DataSource = this.itemTypesBindingSource;
            this.ItemTypesComboBox.DisplayMember = "Name";
            this.ItemTypesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemTypesComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemTypesComboBox.FormattingEnabled = true;
            this.ItemTypesComboBox.Location = new System.Drawing.Point(478, 23);
            this.ItemTypesComboBox.Name = "ItemTypesComboBox";
            this.ItemTypesComboBox.Size = new System.Drawing.Size(150, 21);
            this.ItemTypesComboBox.TabIndex = 5;
            this.ItemTypesComboBox.ValueMember = "Id";
            // 
            // itemTypesBindingSource
            // 
            this.itemTypesBindingSource.DataMember = "ItemTypes";
            this.itemTypesBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // NotesTextBox
            // 
            this.NotesTextBox.Location = new System.Drawing.Point(84, 165);
            this.NotesTextBox.Multiline = true;
            this.NotesTextBox.Name = "NotesTextBox";
            this.NotesTextBox.Size = new System.Drawing.Size(270, 80);
            this.NotesTextBox.TabIndex = 4;
            // 
            // QtyTextBox
            // 
            this.QtyTextBox.Location = new System.Drawing.Point(314, 23);
            this.QtyTextBox.Name = "QtyTextBox";
            this.QtyTextBox.Size = new System.Drawing.Size(40, 20);
            this.QtyTextBox.TabIndex = 2;
            this.QtyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.QtyTextBox.Enter += new System.EventHandler(this.TextBoxEnter);
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(84, 64);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(270, 80);
            this.DescriptionTextBox.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Notes:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Qty:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(433, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Image:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(84, 23);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(184, 20);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.Enter += new System.EventHandler(this.TextBoxEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Delivery Method:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Item Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Description:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(249, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Bid Incr Type:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BidCalculatorButton);
            this.groupBox3.Controls.Add(this.NumberOfBidsTextBox);
            this.groupBox3.Controls.Add(this.BidIncrementTypesComboBox);
            this.groupBox3.Controls.Add(this.BidIncrementValueTextBox);
            this.groupBox3.Controls.Add(this.MaximumBidTextBox);
            this.groupBox3.Controls.Add(this.MinimumBidTextBox);
            this.groupBox3.Controls.Add(this.BuyItNowTextBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.RetailValueTextBox);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(13, 323);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(660, 192);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bid Information";
            // 
            // BidCalculatorButton
            // 
            this.BidCalculatorButton.AutoSize = true;
            this.BidCalculatorButton.Location = new System.Drawing.Point(435, 146);
            this.BidCalculatorButton.Name = "BidCalculatorButton";
            this.BidCalculatorButton.Size = new System.Drawing.Size(111, 23);
            this.BidCalculatorButton.TabIndex = 39;
            this.BidCalculatorButton.Text = "Open Bid Calculator";
            this.BidCalculatorButton.UseVisualStyleBackColor = true;
            this.BidCalculatorButton.Click += new System.EventHandler(this.BidCalculatorButtonClick);
            // 
            // NumberOfBidsTextBox
            // 
            this.NumberOfBidsTextBox.Location = new System.Drawing.Point(328, 148);
            this.NumberOfBidsTextBox.MaxLength = 2;
            this.NumberOfBidsTextBox.Name = "NumberOfBidsTextBox";
            this.NumberOfBidsTextBox.Size = new System.Drawing.Size(40, 20);
            this.NumberOfBidsTextBox.TabIndex = 7;
            this.NumberOfBidsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumberOfBidsTextBox.Enter += new System.EventHandler(this.TextBoxEnter);
            // 
            // BidIncrementTypesComboBox
            // 
            this.BidIncrementTypesComboBox.DataSource = this.bidIncrementTypesBindingSource;
            this.BidIncrementTypesComboBox.DisplayMember = "Name";
            this.BidIncrementTypesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BidIncrementTypesComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BidIncrementTypesComboBox.FormattingEnabled = true;
            this.BidIncrementTypesComboBox.Location = new System.Drawing.Point(328, 66);
            this.BidIncrementTypesComboBox.Name = "BidIncrementTypesComboBox";
            this.BidIncrementTypesComboBox.Size = new System.Drawing.Size(200, 21);
            this.BidIncrementTypesComboBox.TabIndex = 5;
            this.BidIncrementTypesComboBox.ValueMember = "Id";
            this.BidIncrementTypesComboBox.SelectedIndexChanged += new System.EventHandler(this.BidIncrementTypesComboBoxSelectedIndexChanged);
            // 
            // bidIncrementTypesBindingSource
            // 
            this.bidIncrementTypesBindingSource.DataMember = "BidIncrementTypes";
            this.bidIncrementTypesBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // BidIncrementValueTextBox
            // 
            this.BidIncrementValueTextBox.Location = new System.Drawing.Point(328, 110);
            this.BidIncrementValueTextBox.Name = "BidIncrementValueTextBox";
            this.BidIncrementValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.BidIncrementValueTextBox.TabIndex = 6;
            this.BidIncrementValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BidIncrementValueTextBox.Enter += new System.EventHandler(this.TextBoxEnter);
            this.BidIncrementValueTextBox.Leave += new System.EventHandler(this.TextBoxLeaveFormatCurrency);
            // 
            // MaximumBidTextBox
            // 
            this.MaximumBidTextBox.Location = new System.Drawing.Point(84, 110);
            this.MaximumBidTextBox.Name = "MaximumBidTextBox";
            this.MaximumBidTextBox.Size = new System.Drawing.Size(100, 20);
            this.MaximumBidTextBox.TabIndex = 4;
            this.MaximumBidTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MaximumBidTextBox.Enter += new System.EventHandler(this.TextBoxEnter);
            this.MaximumBidTextBox.Leave += new System.EventHandler(this.TextBoxLeaveFormatCurrency);
            // 
            // MinimumBidTextBox
            // 
            this.MinimumBidTextBox.Location = new System.Drawing.Point(84, 66);
            this.MinimumBidTextBox.Name = "MinimumBidTextBox";
            this.MinimumBidTextBox.Size = new System.Drawing.Size(100, 20);
            this.MinimumBidTextBox.TabIndex = 3;
            this.MinimumBidTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MinimumBidTextBox.Enter += new System.EventHandler(this.TextBoxEnter);
            this.MinimumBidTextBox.Leave += new System.EventHandler(this.TextBoxLeaveFormatCurrency);
            // 
            // BuyItNowTextBox
            // 
            this.BuyItNowTextBox.Location = new System.Drawing.Point(328, 22);
            this.BuyItNowTextBox.Name = "BuyItNowTextBox";
            this.BuyItNowTextBox.Size = new System.Drawing.Size(100, 20);
            this.BuyItNowTextBox.TabIndex = 2;
            this.BuyItNowTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BuyItNowTextBox.Enter += new System.EventHandler(this.TextBoxEnter);
            this.BuyItNowTextBox.Leave += new System.EventHandler(this.TextBoxLeaveFormatCurrency);
            // 
            // RetailValueTextBox
            // 
            this.RetailValueTextBox.Location = new System.Drawing.Point(84, 22);
            this.RetailValueTextBox.Name = "RetailValueTextBox";
            this.RetailValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.RetailValueTextBox.TabIndex = 1;
            this.RetailValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RetailValueTextBox.Enter += new System.EventHandler(this.TextBoxEnter);
            this.RetailValueTextBox.Leave += new System.EventHandler(this.TextBoxLeaveFormatCurrency);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(227, 151);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 13);
            this.label17.TabIndex = 38;
            this.label17.Text = "# of Bids (max 20):";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(247, 113);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "Bid Increment:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Maximum Bid:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Minimum Bid:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(221, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Buy It Now Amount:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Retail Value:";
            // 
            // SaveItemButton
            // 
            this.SaveItemButton.Location = new System.Drawing.Point(181, 535);
            this.SaveItemButton.Name = "SaveItemButton";
            this.SaveItemButton.Size = new System.Drawing.Size(75, 23);
            this.SaveItemButton.TabIndex = 5;
            this.SaveItemButton.Text = "Save";
            this.SaveItemButton.UseVisualStyleBackColor = true;
            this.SaveItemButton.Click += new System.EventHandler(this.SaveItemButtonClick);
            // 
            // SaveItemAndCloseButton
            // 
            this.SaveItemAndCloseButton.AutoSize = true;
            this.SaveItemAndCloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SaveItemAndCloseButton.Location = new System.Drawing.Point(296, 535);
            this.SaveItemAndCloseButton.Name = "SaveItemAndCloseButton";
            this.SaveItemAndCloseButton.Size = new System.Drawing.Size(92, 23);
            this.SaveItemAndCloseButton.TabIndex = 6;
            this.SaveItemAndCloseButton.Text = "Save and Close";
            this.SaveItemAndCloseButton.UseVisualStyleBackColor = true;
            this.SaveItemAndCloseButton.Click += new System.EventHandler(this.SaveItemAndCloseButtonClick);
            // 
            // CancelItemButton
            // 
            this.CancelItemButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelItemButton.Location = new System.Drawing.Point(428, 535);
            this.CancelItemButton.Name = "CancelItemButton";
            this.CancelItemButton.Size = new System.Drawing.Size(75, 23);
            this.CancelItemButton.TabIndex = 7;
            this.CancelItemButton.Text = "Cancel";
            this.CancelItemButton.UseVisualStyleBackColor = true;
            // 
            // auctionsTableAdapter
            // 
            this.auctionsTableAdapter.ClearBeforeFill = true;
            // 
            // donorsTableAdapter
            // 
            this.donorsTableAdapter.ClearBeforeFill = true;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // itemTypesTableAdapter
            // 
            this.itemTypesTableAdapter.ClearBeforeFill = true;
            // 
            // bidIncrementTypesTableAdapter
            // 
            this.bidIncrementTypesTableAdapter.ClearBeforeFill = true;
            // 
            // donationDeliveryTypesTableAdapter
            // 
            this.donationDeliveryTypesTableAdapter.ClearBeforeFill = true;
            // 
            // itemErrorProvider
            // 
            this.itemErrorProvider.ContainerControl = this;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // CreateNewItemForm
            // 
            this.AcceptButton = this.SaveItemButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelItemButton;
            this.ClientSize = new System.Drawing.Size(685, 582);
            this.Controls.Add(this.CancelItemButton);
            this.Controls.Add(this.SaveItemAndCloseButton);
            this.Controls.Add(this.SaveItemButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DonorsComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AuctionsComboBox);
            this.Controls.Add(this.label16);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateNewItemForm";
            this.Text = "Create New Item";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateNewItemFormFormClosing);
            this.Load += new System.EventHandler(this.CreateItemLoad);
            ((System.ComponentModel.ISupportInitialize)(this.auctionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationDeliveryTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTypesBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bidIncrementTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox AuctionsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DonorsComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ComboBox DonationDeliveryTypesComboBox;
        private System.Windows.Forms.ComboBox ItemTypesComboBox;
        private System.Windows.Forms.TextBox NotesTextBox;
        private System.Windows.Forms.TextBox QtyTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox NumberOfBidsTextBox;
        private System.Windows.Forms.ComboBox BidIncrementTypesComboBox;
        private System.Windows.Forms.TextBox BidIncrementValueTextBox;
        private System.Windows.Forms.TextBox MaximumBidTextBox;
        private System.Windows.Forms.TextBox MinimumBidTextBox;
        private System.Windows.Forms.TextBox BuyItNowTextBox;
        private System.Windows.Forms.TextBox RetailValueTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox ItemPictureBox;
        private System.Windows.Forms.Button SaveItemButton;
        private System.Windows.Forms.Button SaveItemAndCloseButton;
        private System.Windows.Forms.Button CancelItemButton;
        private System.Windows.Forms.BindingSource auctionsBindingSource;
        private SilentAuctionDataSet silentAuctionDataSet;
        private SilentAuctionDataSetTableAdapters.AuctionsTableAdapter auctionsTableAdapter;
        private System.Windows.Forms.BindingSource donorsBindingSource;
        private SilentAuctionDataSetTableAdapters.DonorsTableAdapter donorsTableAdapter;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.BindingSource itemTypesBindingSource;
        private SilentAuctionDataSetTableAdapters.ItemTypesTableAdapter itemTypesTableAdapter;
        private System.Windows.Forms.BindingSource bidIncrementTypesBindingSource;
        private SilentAuctionDataSetTableAdapters.BidIncrementTypesTableAdapter bidIncrementTypesTableAdapter;
        private System.Windows.Forms.BindingSource donationDeliveryTypesBindingSource;
        private SilentAuctionDataSetTableAdapters.DonationDeliveryTypesTableAdapter donationDeliveryTypesTableAdapter;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ErrorProvider itemErrorProvider;
        private System.Windows.Forms.Button BidCalculatorButton;
        private SilentAuctionDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
    }
}