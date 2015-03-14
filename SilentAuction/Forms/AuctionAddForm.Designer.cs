namespace SilentAuction.Forms
{
    partial class AuctionAddForm
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
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.DescriptionTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.AuctionCancelButton = new MetroFramework.Controls.MetroButton();
            this.SubmitButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(156, 111);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(142, 13);
            this.ErrorLabel.TabIndex = 5;
            this.ErrorLabel.Text = "Auction Name Already Exists";
            this.ErrorLabel.Visible = false;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Lines = new string[0];
            this.NameTextBox.Location = new System.Drawing.Point(159, 85);
            this.NameTextBox.MaxLength = 200;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.PasswordChar = '\0';
            this.NameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NameTextBox.SelectedText = "";
            this.NameTextBox.Size = new System.Drawing.Size(162, 23);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.UseSelectable = true;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBoxTextChanged);
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Lines = new string[0];
            this.DescriptionTextBox.Location = new System.Drawing.Point(159, 136);
            this.DescriptionTextBox.MaxLength = 32767;
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.PasswordChar = '\0';
            this.DescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DescriptionTextBox.SelectedText = "";
            this.DescriptionTextBox.Size = new System.Drawing.Size(162, 113);
            this.DescriptionTextBox.TabIndex = 2;
            this.DescriptionTextBox.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(28, 85);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(96, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Auction Name:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(28, 136);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(125, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Auction Description:";
            // 
            // AuctionCancelButton
            // 
            this.AuctionCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AuctionCancelButton.Location = new System.Drawing.Point(186, 312);
            this.AuctionCancelButton.Name = "AuctionCancelButton";
            this.AuctionCancelButton.Size = new System.Drawing.Size(75, 23);
            this.AuctionCancelButton.TabIndex = 4;
            this.AuctionCancelButton.Text = "Cancel";
            this.AuctionCancelButton.UseSelectable = true;
            this.AuctionCancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(78, 312);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 3;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseSelectable = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButtonClick);
            // 
            // AuctionAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.AuctionCancelButton;
            this.ClientSize = new System.Drawing.Size(366, 389);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.AuctionCancelButton);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.ErrorLabel);
            this.Name = "AuctionAddForm";
            this.Text = "Create New Auction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ErrorLabel;
        private MetroFramework.Controls.MetroTextBox NameTextBox;
        private MetroFramework.Controls.MetroTextBox DescriptionTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton AuctionCancelButton;
        private MetroFramework.Controls.MetroButton SubmitButton;
    }
}