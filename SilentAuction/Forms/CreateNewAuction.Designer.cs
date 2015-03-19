namespace SilentAuction.Forms
{
    partial class CreateNewAuctionForm
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.CreateAuctionButton = new System.Windows.Forms.Button();
            this.CancelAuctionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(12, 25);
            this.NameTextBox.MaxLength = 200;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(260, 20);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBoxTextChanged);
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(12, 79);
            this.DescriptionTextBox.MaxLength = 5000;
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(260, 93);
            this.DescriptionTextBox.TabIndex = 2;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(129, 13);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Auction Name (Required):";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(12, 63);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(102, 13);
            this.DescriptionLabel.TabIndex = 3;
            this.DescriptionLabel.Text = "Auction Description:";
            // 
            // CreateAuctionButton
            // 
            this.CreateAuctionButton.Location = new System.Drawing.Point(43, 211);
            this.CreateAuctionButton.Name = "CreateAuctionButton";
            this.CreateAuctionButton.Size = new System.Drawing.Size(75, 23);
            this.CreateAuctionButton.TabIndex = 3;
            this.CreateAuctionButton.Text = "Create";
            this.CreateAuctionButton.UseVisualStyleBackColor = true;
            this.CreateAuctionButton.Click += new System.EventHandler(this.CreateAuctionButtonClick);
            // 
            // CancelAuctionButton
            // 
            this.CancelAuctionButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelAuctionButton.Location = new System.Drawing.Point(156, 210);
            this.CancelAuctionButton.Name = "CancelAuctionButton";
            this.CancelAuctionButton.Size = new System.Drawing.Size(75, 23);
            this.CancelAuctionButton.TabIndex = 4;
            this.CancelAuctionButton.Text = "Cancel";
            this.CancelAuctionButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(147, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name Already Exists";
            this.label1.Visible = false;
            // 
            // CreateNewAuctionForm
            // 
            this.AcceptButton = this.CreateAuctionButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelAuctionButton;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelAuctionButton);
            this.Controls.Add(this.CreateAuctionButton);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Name = "CreateNewAuctionForm";
            this.Text = "Create New Auction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Button CreateAuctionButton;
        private System.Windows.Forms.Button CancelAuctionButton;
        private System.Windows.Forms.Label label1;
    }
}