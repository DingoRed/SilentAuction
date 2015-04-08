namespace SilentAuction.Forms
{
    partial class EmailAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailAccount));
            this.label1 = new System.Windows.Forms.Label();
            this.accountTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.SendEmailButton = new System.Windows.Forms.Button();
            this.CancelEmailButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gmail Account to Use for Email";
            // 
            // accountTextBox
            // 
            this.accountTextBox.Location = new System.Drawing.Point(12, 25);
            this.accountTextBox.Name = "accountTextBox";
            this.accountTextBox.Size = new System.Drawing.Size(260, 20);
            this.accountTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(12, 81);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(260, 20);
            this.passwordTextBox.TabIndex = 3;
            // 
            // SendEmailButton
            // 
            this.SendEmailButton.Location = new System.Drawing.Point(51, 128);
            this.SendEmailButton.Name = "SendEmailButton";
            this.SendEmailButton.Size = new System.Drawing.Size(75, 23);
            this.SendEmailButton.TabIndex = 4;
            this.SendEmailButton.Text = "Send Email";
            this.SendEmailButton.UseVisualStyleBackColor = true;
            this.SendEmailButton.Click += new System.EventHandler(this.SendEmailButtonClick);
            // 
            // CancelEmailButton
            // 
            this.CancelEmailButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelEmailButton.Location = new System.Drawing.Point(158, 128);
            this.CancelEmailButton.Name = "CancelEmailButton";
            this.CancelEmailButton.Size = new System.Drawing.Size(75, 23);
            this.CancelEmailButton.TabIndex = 5;
            this.CancelEmailButton.Text = "Cancel";
            this.CancelEmailButton.UseVisualStyleBackColor = true;
            // 
            // EmailAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelEmailButton;
            this.ClientSize = new System.Drawing.Size(284, 180);
            this.Controls.Add(this.CancelEmailButton);
            this.Controls.Add(this.SendEmailButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.accountTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmailAccount";
            this.Text = "Email Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SendEmailButton;
        private System.Windows.Forms.Button CancelEmailButton;
        public System.Windows.Forms.TextBox accountTextBox;
        public System.Windows.Forms.TextBox passwordTextBox;
    }
}