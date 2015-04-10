namespace SilentAuction.Forms
{
    partial class CreateNewDonorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewDonorForm));
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DonorTypeComboBox = new System.Windows.Forms.ComboBox();
            this.donorTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.silentAuctionDataSet = new SilentAuction.SilentAuctionDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.RequestFormatTypeComboBox = new System.Windows.Forms.ComboBox();
            this.requestFormatTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.ContactNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Ext2TextBox = new System.Windows.Forms.TextBox();
            this.Phone2TextBox = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Ext1TextBox = new System.Windows.Forms.TextBox();
            this.Phone1TextBox = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.UrlTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.StateComboBox = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ZipCodeTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Street1TextBox = new System.Windows.Forms.TextBox();
            this.Street2TextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SaveDonorAndCloseButton = new System.Windows.Forms.Button();
            this.SaveDonorButton = new System.Windows.Forms.Button();
            this.CancelDonorButton = new System.Windows.Forms.Button();
            this.donorTypesTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.DonorTypesTableAdapter();
            this.requestFormatTypesTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.RequestFormatTypesTableAdapter();
            this.donorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donorsTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.DonorsTableAdapter();
            this.auctionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auctionsTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.AuctionsTableAdapter();
            this.AuctionsComboBox = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.CreateDonorErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.requestStatusTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestStatusTypesTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.RequestStatusTypesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.donorTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestFormatTypesBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateDonorErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestStatusTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Donor Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(134, 34);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(219, 20);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBoxTextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Donor Type:";
            // 
            // DonorTypeComboBox
            // 
            this.DonorTypeComboBox.DataSource = this.donorTypesBindingSource;
            this.DonorTypeComboBox.DisplayMember = "Name";
            this.DonorTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DonorTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DonorTypeComboBox.FormattingEnabled = true;
            this.DonorTypeComboBox.Location = new System.Drawing.Point(451, 34);
            this.DonorTypeComboBox.Name = "DonorTypeComboBox";
            this.DonorTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.DonorTypeComboBox.TabIndex = 2;
            this.DonorTypeComboBox.ValueMember = "Id";
            // 
            // donorTypesBindingSource
            // 
            this.donorTypesBindingSource.DataMember = "DonorTypes";
            this.donorTypesBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // silentAuctionDataSet
            // 
            this.silentAuctionDataSet.DataSetName = "SilentAuctionDataSet";
            this.silentAuctionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Make Request Via:";
            // 
            // RequestFormatTypeComboBox
            // 
            this.RequestFormatTypeComboBox.DataSource = this.requestFormatTypesBindingSource;
            this.RequestFormatTypeComboBox.DisplayMember = "Name";
            this.RequestFormatTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RequestFormatTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RequestFormatTypeComboBox.FormattingEnabled = true;
            this.RequestFormatTypeComboBox.Location = new System.Drawing.Point(419, 31);
            this.RequestFormatTypeComboBox.Name = "RequestFormatTypeComboBox";
            this.RequestFormatTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.RequestFormatTypeComboBox.TabIndex = 4;
            this.RequestFormatTypeComboBox.ValueMember = "Id";
            // 
            // requestFormatTypesBindingSource
            // 
            this.requestFormatTypesBindingSource.DataMember = "RequestFormatTypes";
            this.requestFormatTypesBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Contact Name:";
            // 
            // ContactNameTextBox
            // 
            this.ContactNameTextBox.Location = new System.Drawing.Point(102, 32);
            this.ContactNameTextBox.Name = "ContactNameTextBox";
            this.ContactNameTextBox.Size = new System.Drawing.Size(153, 20);
            this.ContactNameTextBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Ext2TextBox);
            this.groupBox1.Controls.Add(this.Phone2TextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.RequestFormatTypeComboBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Ext1TextBox);
            this.groupBox1.Controls.Add(this.Phone1TextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.UrlTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.EmailTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ContactNameTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(10, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 136);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contact";
            // 
            // Ext2TextBox
            // 
            this.Ext2TextBox.Location = new System.Drawing.Point(565, 84);
            this.Ext2TextBox.Name = "Ext2TextBox";
            this.Ext2TextBox.Size = new System.Drawing.Size(46, 20);
            this.Ext2TextBox.TabIndex = 10;
            // 
            // Phone2TextBox
            // 
            this.Phone2TextBox.Location = new System.Drawing.Point(419, 84);
            this.Phone2TextBox.Mask = "(999) 000-0000";
            this.Phone2TextBox.Name = "Phone2TextBox";
            this.Phone2TextBox.Size = new System.Drawing.Size(100, 20);
            this.Phone2TextBox.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(525, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Ext 2:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(363, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Phone 2:";
            // 
            // Ext1TextBox
            // 
            this.Ext1TextBox.Location = new System.Drawing.Point(565, 58);
            this.Ext1TextBox.Name = "Ext1TextBox";
            this.Ext1TextBox.Size = new System.Drawing.Size(46, 20);
            this.Ext1TextBox.TabIndex = 7;
            // 
            // Phone1TextBox
            // 
            this.Phone1TextBox.Location = new System.Drawing.Point(419, 58);
            this.Phone1TextBox.Mask = "(999) 000-0000";
            this.Phone1TextBox.Name = "Phone1TextBox";
            this.Phone1TextBox.Size = new System.Drawing.Size(100, 20);
            this.Phone1TextBox.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(525, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ext 1:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(363, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Phone 1:";
            // 
            // UrlTextBox
            // 
            this.UrlTextBox.Location = new System.Drawing.Point(102, 84);
            this.UrlTextBox.Name = "UrlTextBox";
            this.UrlTextBox.Size = new System.Drawing.Size(153, 20);
            this.UrlTextBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Website:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(102, 58);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(153, 20);
            this.EmailTextBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.StateComboBox);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.ZipCodeTextBox);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.Street1TextBox);
            this.groupBox2.Controls.Add(this.Street2TextBox);
            this.groupBox2.Controls.Add(this.CityTextBox);
            this.groupBox2.Location = new System.Drawing.Point(10, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(630, 134);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Address";
            // 
            // StateComboBox
            // 
            this.StateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StateComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StateComboBox.FormattingEnabled = true;
            this.StateComboBox.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.StateComboBox.Location = new System.Drawing.Point(367, 84);
            this.StateComboBox.Name = "StateComboBox";
            this.StateComboBox.Size = new System.Drawing.Size(49, 21);
            this.StateComboBox.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(68, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "City:";
            // 
            // ZipCodeTextBox
            // 
            this.ZipCodeTextBox.Location = new System.Drawing.Point(481, 84);
            this.ZipCodeTextBox.Name = "ZipCodeTextBox";
            this.ZipCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.ZipCodeTextBox.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Street 2:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(422, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Zip Code:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(326, 87);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "State:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Street 1:";
            // 
            // Street1TextBox
            // 
            this.Street1TextBox.Location = new System.Drawing.Point(102, 32);
            this.Street1TextBox.Name = "Street1TextBox";
            this.Street1TextBox.Size = new System.Drawing.Size(218, 20);
            this.Street1TextBox.TabIndex = 11;
            // 
            // Street2TextBox
            // 
            this.Street2TextBox.Location = new System.Drawing.Point(102, 58);
            this.Street2TextBox.Name = "Street2TextBox";
            this.Street2TextBox.Size = new System.Drawing.Size(218, 20);
            this.Street2TextBox.TabIndex = 12;
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(101, 84);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(219, 20);
            this.CityTextBox.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DonorTypeComboBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.NameTextBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(10, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(630, 87);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Required";
            // 
            // SaveDonorAndCloseButton
            // 
            this.SaveDonorAndCloseButton.AutoSize = true;
            this.SaveDonorAndCloseButton.Location = new System.Drawing.Point(280, 438);
            this.SaveDonorAndCloseButton.Name = "SaveDonorAndCloseButton";
            this.SaveDonorAndCloseButton.Size = new System.Drawing.Size(92, 23);
            this.SaveDonorAndCloseButton.TabIndex = 6;
            this.SaveDonorAndCloseButton.Text = "Save and Close";
            this.SaveDonorAndCloseButton.UseVisualStyleBackColor = true;
            this.SaveDonorAndCloseButton.Click += new System.EventHandler(this.SaveAndCloseButtonClick);
            // 
            // SaveDonorButton
            // 
            this.SaveDonorButton.Location = new System.Drawing.Point(165, 438);
            this.SaveDonorButton.Name = "SaveDonorButton";
            this.SaveDonorButton.Size = new System.Drawing.Size(75, 23);
            this.SaveDonorButton.TabIndex = 5;
            this.SaveDonorButton.Text = "Save";
            this.SaveDonorButton.UseVisualStyleBackColor = true;
            this.SaveDonorButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // CancelDonorButton
            // 
            this.CancelDonorButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelDonorButton.Location = new System.Drawing.Point(412, 438);
            this.CancelDonorButton.Name = "CancelDonorButton";
            this.CancelDonorButton.Size = new System.Drawing.Size(75, 23);
            this.CancelDonorButton.TabIndex = 7;
            this.CancelDonorButton.Text = "Cancel";
            this.CancelDonorButton.UseVisualStyleBackColor = true;
            // 
            // donorTypesTableAdapter
            // 
            this.donorTypesTableAdapter.ClearBeforeFill = true;
            // 
            // requestFormatTypesTableAdapter
            // 
            this.requestFormatTypesTableAdapter.ClearBeforeFill = true;
            // 
            // donorsBindingSource
            // 
            this.donorsBindingSource.DataMember = "Donors";
            this.donorsBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // donorsTableAdapter
            // 
            this.donorsTableAdapter.ClearBeforeFill = true;
            // 
            // auctionsBindingSource
            // 
            this.auctionsBindingSource.DataMember = "Auctions";
            this.auctionsBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // auctionsTableAdapter
            // 
            this.auctionsTableAdapter.ClearBeforeFill = true;
            // 
            // AuctionsComboBox
            // 
            this.AuctionsComboBox.DataSource = this.auctionsBindingSource;
            this.AuctionsComboBox.DisplayMember = "Name";
            this.AuctionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AuctionsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuctionsComboBox.FormattingEnabled = true;
            this.AuctionsComboBox.Location = new System.Drawing.Point(227, 12);
            this.AuctionsComboBox.Name = "AuctionsComboBox";
            this.AuctionsComboBox.Size = new System.Drawing.Size(250, 21);
            this.AuctionsComboBox.TabIndex = 1;
            this.AuctionsComboBox.ValueMember = "Id";
            this.AuctionsComboBox.SelectedIndexChanged += new System.EventHandler(this.AuctionsComboBoxSelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(175, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Auction:";
            // 
            // CreateDonorErrorProvider
            // 
            this.CreateDonorErrorProvider.ContainerControl = this;
            // 
            // requestStatusTypesBindingSource
            // 
            this.requestStatusTypesBindingSource.DataMember = "RequestStatusTypes";
            this.requestStatusTypesBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // requestStatusTypesTableAdapter
            // 
            this.requestStatusTypesTableAdapter.ClearBeforeFill = true;
            // 
            // CreateNewDonorForm
            // 
            this.AcceptButton = this.SaveDonorButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelDonorButton;
            this.ClientSize = new System.Drawing.Size(652, 493);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.AuctionsComboBox);
            this.Controls.Add(this.CancelDonorButton);
            this.Controls.Add(this.SaveDonorButton);
            this.Controls.Add(this.SaveDonorAndCloseButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateNewDonorForm";
            this.Text = "Create New Donor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateNewDonorFormFormClosing);
            this.Load += new System.EventHandler(this.CreateNewDonorFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.donorTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestFormatTypesBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateDonorErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestStatusTypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DonorTypeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox RequestFormatTypeComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ContactNameTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Ext2TextBox;
        private System.Windows.Forms.MaskedTextBox Phone2TextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Ext1TextBox;
        private System.Windows.Forms.MaskedTextBox Phone1TextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox UrlTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox StateComboBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ZipCodeTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Street1TextBox;
        private System.Windows.Forms.TextBox Street2TextBox;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button SaveDonorAndCloseButton;
        private System.Windows.Forms.Button SaveDonorButton;
        private System.Windows.Forms.Button CancelDonorButton;
        private SilentAuctionDataSet silentAuctionDataSet;
        private System.Windows.Forms.BindingSource donorTypesBindingSource;
        private SilentAuctionDataSetTableAdapters.DonorTypesTableAdapter donorTypesTableAdapter;
        private System.Windows.Forms.BindingSource requestFormatTypesBindingSource;
        private SilentAuctionDataSetTableAdapters.RequestFormatTypesTableAdapter requestFormatTypesTableAdapter;
        private System.Windows.Forms.BindingSource donorsBindingSource;
        private SilentAuctionDataSetTableAdapters.DonorsTableAdapter donorsTableAdapter;
        private System.Windows.Forms.BindingSource auctionsBindingSource;
        private SilentAuctionDataSetTableAdapters.AuctionsTableAdapter auctionsTableAdapter;
        private System.Windows.Forms.ComboBox AuctionsComboBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ErrorProvider CreateDonorErrorProvider;
        private System.Windows.Forms.BindingSource requestStatusTypesBindingSource;
        private SilentAuctionDataSetTableAdapters.RequestStatusTypesTableAdapter requestStatusTypesTableAdapter;
    }
}