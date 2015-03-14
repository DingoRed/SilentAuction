namespace SilentAuction.Forms
{
    partial class ItemAddForm
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
            this.DonorComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.NameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.DescriptionTextBox = new MetroFramework.Controls.MetroTextBox();
            this.QtyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NotesTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ItemCancelButton = new MetroFramework.Controls.MetroButton();
            this.SubmitButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.QtyNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // DonorComboBox
            // 
            this.DonorComboBox.FormattingEnabled = true;
            this.DonorComboBox.ItemHeight = 23;
            this.DonorComboBox.Location = new System.Drawing.Point(139, 80);
            this.DonorComboBox.Name = "DonorComboBox";
            this.DonorComboBox.Size = new System.Drawing.Size(600, 29);
            this.DonorComboBox.TabIndex = 0;
            this.DonorComboBox.UseSelectable = true;
            this.DonorComboBox.SelectedIndexChanged += new System.EventHandler(this.DonorComboBoxSelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(84, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Donor:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(55, 139);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(78, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Item Name:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(26, 210);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(107, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Item Description:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(70, 274);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(63, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Item Qty:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(87, 339);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(46, 19);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "Notes:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Lines = new string[0];
            this.NameTextBox.Location = new System.Drawing.Point(139, 139);
            this.NameTextBox.MaxLength = 200;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.PasswordChar = '\0';
            this.NameTextBox.PromptText = "Required";
            this.NameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NameTextBox.SelectedText = "";
            this.NameTextBox.Size = new System.Drawing.Size(600, 23);
            this.NameTextBox.TabIndex = 6;
            this.NameTextBox.UseSelectable = true;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Lines = new string[0];
            this.DescriptionTextBox.Location = new System.Drawing.Point(139, 168);
            this.DescriptionTextBox.MaxLength = 5000;
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.PasswordChar = '\0';
            this.DescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DescriptionTextBox.SelectedText = "";
            this.DescriptionTextBox.Size = new System.Drawing.Size(600, 100);
            this.DescriptionTextBox.TabIndex = 7;
            this.DescriptionTextBox.UseSelectable = true;
            // 
            // QtyNumericUpDown
            // 
            this.QtyNumericUpDown.Location = new System.Drawing.Point(139, 274);
            this.QtyNumericUpDown.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.QtyNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QtyNumericUpDown.Name = "QtyNumericUpDown";
            this.QtyNumericUpDown.Size = new System.Drawing.Size(71, 20);
            this.QtyNumericUpDown.TabIndex = 8;
            this.QtyNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NotesTextBox
            // 
            this.NotesTextBox.Lines = new string[0];
            this.NotesTextBox.Location = new System.Drawing.Point(139, 300);
            this.NotesTextBox.MaxLength = 5000;
            this.NotesTextBox.Multiline = true;
            this.NotesTextBox.Name = "NotesTextBox";
            this.NotesTextBox.PasswordChar = '\0';
            this.NotesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NotesTextBox.SelectedText = "";
            this.NotesTextBox.Size = new System.Drawing.Size(600, 106);
            this.NotesTextBox.TabIndex = 9;
            this.NotesTextBox.UseSelectable = true;
            // 
            // ItemCancelButton
            // 
            this.ItemCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ItemCancelButton.Location = new System.Drawing.Point(288, 447);
            this.ItemCancelButton.Name = "ItemCancelButton";
            this.ItemCancelButton.Size = new System.Drawing.Size(75, 23);
            this.ItemCancelButton.TabIndex = 10;
            this.ItemCancelButton.Text = "Cancel";
            this.ItemCancelButton.UseSelectable = true;
            this.ItemCancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(148, 447);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 11;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseSelectable = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButtonClick);
            // 
            // ItemAddForm
            // 
            this.AcceptButton = this.SubmitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ItemCancelButton;
            this.ClientSize = new System.Drawing.Size(768, 513);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.ItemCancelButton);
            this.Controls.Add(this.NotesTextBox);
            this.Controls.Add(this.QtyNumericUpDown);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.DonorComboBox);
            this.Name = "ItemAddForm";
            this.Text = "ItemAddForm";
            this.Load += new System.EventHandler(this.ItemAddFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.QtyNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox DonorComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox NameTextBox;
        private MetroFramework.Controls.MetroTextBox DescriptionTextBox;
        private System.Windows.Forms.NumericUpDown QtyNumericUpDown;
        private MetroFramework.Controls.MetroTextBox NotesTextBox;
        private MetroFramework.Controls.MetroButton ItemCancelButton;
        private MetroFramework.Controls.MetroButton SubmitButton;
    }
}