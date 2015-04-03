namespace SilentAuction.Forms
{
    partial class GenerateAddressLabelsFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateAddressLabelsFile));
            this.label1 = new System.Windows.Forms.Label();
            this.FilterByContactCheckBox = new System.Windows.Forms.CheckBox();
            this.DonorsListBox = new System.Windows.Forms.ListBox();
            this.donorsWithLettersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.silentAuctionDataSet = new SilentAuction.SilentAuctionDataSet();
            this.MakeFileButton = new System.Windows.Forms.Button();
            this.CancelMakeFileButton = new System.Windows.Forms.Button();
            this.donorsWithLettersTableAdapter = new SilentAuction.SilentAuctionDataSetTableAdapters.DonorsWithLettersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.donorsWithLettersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Donors to Include in File";
            // 
            // FilterByContactCheckBox
            // 
            this.FilterByContactCheckBox.AutoSize = true;
            this.FilterByContactCheckBox.Location = new System.Drawing.Point(12, 12);
            this.FilterByContactCheckBox.Name = "FilterByContactCheckBox";
            this.FilterByContactCheckBox.Size = new System.Drawing.Size(150, 17);
            this.FilterByContactCheckBox.TabIndex = 1;
            this.FilterByContactCheckBox.Text = "Filter by Contact Via Letter";
            this.FilterByContactCheckBox.UseVisualStyleBackColor = true;
            this.FilterByContactCheckBox.CheckedChanged += new System.EventHandler(this.FilterByContactCheckBoxCheckedChanged);
            // 
            // DonorsListBox
            // 
            this.DonorsListBox.DataSource = this.donorsWithLettersBindingSource;
            this.DonorsListBox.DisplayMember = "Name";
            this.DonorsListBox.FormattingEnabled = true;
            this.DonorsListBox.Location = new System.Drawing.Point(12, 57);
            this.DonorsListBox.Name = "DonorsListBox";
            this.DonorsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.DonorsListBox.Size = new System.Drawing.Size(256, 186);
            this.DonorsListBox.TabIndex = 2;
            this.DonorsListBox.ValueMember = "Id";
            // 
            // donorsWithLettersBindingSource
            // 
            this.donorsWithLettersBindingSource.DataMember = "DonorsWithLetters";
            this.donorsWithLettersBindingSource.DataSource = this.silentAuctionDataSet;
            // 
            // silentAuctionDataSet
            // 
            this.silentAuctionDataSet.DataSetName = "SilentAuctionDataSet";
            this.silentAuctionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MakeFileButton
            // 
            this.MakeFileButton.Location = new System.Drawing.Point(51, 265);
            this.MakeFileButton.Name = "MakeFileButton";
            this.MakeFileButton.Size = new System.Drawing.Size(75, 23);
            this.MakeFileButton.TabIndex = 3;
            this.MakeFileButton.Text = "Make File";
            this.MakeFileButton.UseVisualStyleBackColor = true;
            this.MakeFileButton.Click += new System.EventHandler(this.MakeFileButtonClick);
            // 
            // CancelMakeFileButton
            // 
            this.CancelMakeFileButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelMakeFileButton.Location = new System.Drawing.Point(158, 265);
            this.CancelMakeFileButton.Name = "CancelMakeFileButton";
            this.CancelMakeFileButton.Size = new System.Drawing.Size(75, 23);
            this.CancelMakeFileButton.TabIndex = 4;
            this.CancelMakeFileButton.Text = "Cancel";
            this.CancelMakeFileButton.UseVisualStyleBackColor = true;
            // 
            // donorsWithLettersTableAdapter
            // 
            this.donorsWithLettersTableAdapter.ClearBeforeFill = true;
            // 
            // GenerateAddressLabelsFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelMakeFileButton;
            this.ClientSize = new System.Drawing.Size(280, 314);
            this.Controls.Add(this.CancelMakeFileButton);
            this.Controls.Add(this.MakeFileButton);
            this.Controls.Add(this.DonorsListBox);
            this.Controls.Add(this.FilterByContactCheckBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GenerateAddressLabelsFile";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Generate Address Labels File";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GenerateLabelsFileFormClosing);
            this.Load += new System.EventHandler(this.GenerateLabelsFileLoad);
            ((System.ComponentModel.ISupportInitialize)(this.donorsWithLettersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silentAuctionDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox FilterByContactCheckBox;
        private System.Windows.Forms.ListBox DonorsListBox;
        private System.Windows.Forms.Button MakeFileButton;
        private System.Windows.Forms.Button CancelMakeFileButton;
        private System.Windows.Forms.BindingSource donorsWithLettersBindingSource;
        private SilentAuctionDataSet silentAuctionDataSet;
        private SilentAuctionDataSetTableAdapters.DonorsWithLettersTableAdapter donorsWithLettersTableAdapter;
    }
}