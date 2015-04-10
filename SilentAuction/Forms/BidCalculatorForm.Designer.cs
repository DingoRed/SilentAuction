namespace SilentAuction.Forms
{
    partial class BidCalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BidCalculatorForm));
            this.label1 = new System.Windows.Forms.Label();
            this.BMinValueTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BCalcButton = new System.Windows.Forms.Button();
            this.BNbrOfBidsTextBox = new System.Windows.Forms.TextBox();
            this.BMaxValueTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.VCalcButton = new System.Windows.Forms.Button();
            this.VIncrValueTextBox = new System.Windows.Forms.TextBox();
            this.VMaxValueTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.VMinValueTextBox = new System.Windows.Forms.TextBox();
            this.BidsListView = new System.Windows.Forms.ListView();
            this.bidCalculatorErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bidCalculatorErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Min Value:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BMinValueTextBox
            // 
            this.BMinValueTextBox.Location = new System.Drawing.Point(94, 32);
            this.BMinValueTextBox.Name = "BMinValueTextBox";
            this.BMinValueTextBox.Size = new System.Drawing.Size(55, 20);
            this.BMinValueTextBox.TabIndex = 1;
            this.BMinValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BMinValueTextBox.Enter += new System.EventHandler(this.TextBoxEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BCalcButton);
            this.groupBox1.Controls.Add(this.BNbrOfBidsTextBox);
            this.groupBox1.Controls.Add(this.BMaxValueTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BMinValueTextBox);
            this.groupBox1.Location = new System.Drawing.Point(34, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 184);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculate By Number of Bids";
            // 
            // BCalcButton
            // 
            this.BCalcButton.Location = new System.Drawing.Point(47, 141);
            this.BCalcButton.Name = "BCalcButton";
            this.BCalcButton.Size = new System.Drawing.Size(75, 23);
            this.BCalcButton.TabIndex = 4;
            this.BCalcButton.Text = "Calculate";
            this.BCalcButton.UseVisualStyleBackColor = true;
            this.BCalcButton.Click += new System.EventHandler(this.BCalcButtonClick);
            // 
            // BNbrOfBidsTextBox
            // 
            this.BNbrOfBidsTextBox.Location = new System.Drawing.Point(94, 100);
            this.BNbrOfBidsTextBox.Name = "BNbrOfBidsTextBox";
            this.BNbrOfBidsTextBox.Size = new System.Drawing.Size(55, 20);
            this.BNbrOfBidsTextBox.TabIndex = 3;
            this.BNbrOfBidsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BNbrOfBidsTextBox.Enter += new System.EventHandler(this.TextBoxEnter);
            // 
            // BMaxValueTextBox
            // 
            this.BMaxValueTextBox.Location = new System.Drawing.Point(94, 66);
            this.BMaxValueTextBox.Name = "BMaxValueTextBox";
            this.BMaxValueTextBox.Size = new System.Drawing.Size(55, 20);
            this.BMaxValueTextBox.TabIndex = 2;
            this.BMaxValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BMaxValueTextBox.Enter += new System.EventHandler(this.TextBoxEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number of Bids:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Max Value:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.VCalcButton);
            this.groupBox2.Controls.Add(this.VIncrValueTextBox);
            this.groupBox2.Controls.Add(this.VMaxValueTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.VMinValueTextBox);
            this.groupBox2.Location = new System.Drawing.Point(209, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 184);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculate By Increment Value";
            // 
            // VCalcButton
            // 
            this.VCalcButton.Location = new System.Drawing.Point(47, 141);
            this.VCalcButton.Name = "VCalcButton";
            this.VCalcButton.Size = new System.Drawing.Size(75, 23);
            this.VCalcButton.TabIndex = 4;
            this.VCalcButton.Text = "Calculate";
            this.VCalcButton.UseVisualStyleBackColor = true;
            this.VCalcButton.Click += new System.EventHandler(this.VCalcButtonClick);
            // 
            // VIncrValueTextBox
            // 
            this.VIncrValueTextBox.Location = new System.Drawing.Point(99, 100);
            this.VIncrValueTextBox.Name = "VIncrValueTextBox";
            this.VIncrValueTextBox.Size = new System.Drawing.Size(55, 20);
            this.VIncrValueTextBox.TabIndex = 3;
            this.VIncrValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.VIncrValueTextBox.Enter += new System.EventHandler(this.TextBoxEnter);
            // 
            // VMaxValueTextBox
            // 
            this.VMaxValueTextBox.Location = new System.Drawing.Point(99, 66);
            this.VMaxValueTextBox.Name = "VMaxValueTextBox";
            this.VMaxValueTextBox.Size = new System.Drawing.Size(55, 20);
            this.VMaxValueTextBox.TabIndex = 2;
            this.VMaxValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.VMaxValueTextBox.Enter += new System.EventHandler(this.TextBoxEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Increment Value:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Max Value:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Min Value:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VMinValueTextBox
            // 
            this.VMinValueTextBox.Location = new System.Drawing.Point(99, 32);
            this.VMinValueTextBox.Name = "VMinValueTextBox";
            this.VMinValueTextBox.Size = new System.Drawing.Size(55, 20);
            this.VMinValueTextBox.TabIndex = 1;
            this.VMinValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.VMinValueTextBox.Enter += new System.EventHandler(this.TextBoxEnter);
            // 
            // BidsListView
            // 
            this.BidsListView.BackColor = System.Drawing.SystemColors.Control;
            this.BidsListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BidsListView.Location = new System.Drawing.Point(35, 238);
            this.BidsListView.Name = "BidsListView";
            this.BidsListView.Size = new System.Drawing.Size(347, 166);
            this.BidsListView.TabIndex = 3;
            this.BidsListView.UseCompatibleStateImageBehavior = false;
            this.BidsListView.View = System.Windows.Forms.View.List;
            // 
            // bidCalculatorErrorProvider
            // 
            this.bidCalculatorErrorProvider.ContainerControl = this;
            // 
            // BidCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 446);
            this.Controls.Add(this.BidsListView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BidCalculatorForm";
            this.Text = "Bid Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BidCalculatorFormFormClosing);
            this.Load += new System.EventHandler(this.BidCalculatorFormLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bidCalculatorErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BMinValueTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BCalcButton;
        private System.Windows.Forms.TextBox BNbrOfBidsTextBox;
        private System.Windows.Forms.TextBox BMaxValueTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button VCalcButton;
        private System.Windows.Forms.TextBox VIncrValueTextBox;
        private System.Windows.Forms.TextBox VMaxValueTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox VMinValueTextBox;
        private System.Windows.Forms.ListView BidsListView;
        private System.Windows.Forms.ErrorProvider bidCalculatorErrorProvider;
    }
}