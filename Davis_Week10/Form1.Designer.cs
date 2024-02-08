namespace Davis_Week10
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.balanceAmount = new System.Windows.Forms.TextBox();
            this.transactionBox = new System.Windows.Forms.TextBox();
            this.transactionAmountLabel = new System.Windows.Forms.Label();
            this.debitButton = new System.Windows.Forms.Button();
            this.creditButton = new System.Windows.Forms.Button();
            this.intRateBtn = new System.Windows.Forms.Button();
            this.accountBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(209, 27);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(49, 13);
            this.balanceLabel.TabIndex = 1;
            this.balanceLabel.Text = "Balance:";
            // 
            // balanceAmount
            // 
            this.balanceAmount.Location = new System.Drawing.Point(282, 27);
            this.balanceAmount.Name = "balanceAmount";
            this.balanceAmount.ReadOnly = true;
            this.balanceAmount.Size = new System.Drawing.Size(100, 20);
            this.balanceAmount.TabIndex = 2;
            // 
            // transactionBox
            // 
            this.transactionBox.Location = new System.Drawing.Point(282, 82);
            this.transactionBox.Name = "transactionBox";
            this.transactionBox.Size = new System.Drawing.Size(100, 20);
            this.transactionBox.TabIndex = 3;
            // 
            // transactionAmountLabel
            // 
            this.transactionAmountLabel.AutoSize = true;
            this.transactionAmountLabel.Location = new System.Drawing.Point(153, 82);
            this.transactionAmountLabel.Name = "transactionAmountLabel";
            this.transactionAmountLabel.Size = new System.Drawing.Size(105, 13);
            this.transactionAmountLabel.TabIndex = 4;
            this.transactionAmountLabel.Text = "Transaction Amount:";
            // 
            // debitButton
            // 
            this.debitButton.Location = new System.Drawing.Point(282, 108);
            this.debitButton.Name = "debitButton";
            this.debitButton.Size = new System.Drawing.Size(47, 23);
            this.debitButton.TabIndex = 5;
            this.debitButton.Text = "Debit";
            this.debitButton.UseVisualStyleBackColor = true;
            this.debitButton.Click += new System.EventHandler(this.debitButton_Click);
            // 
            // creditButton
            // 
            this.creditButton.Location = new System.Drawing.Point(335, 108);
            this.creditButton.Name = "creditButton";
            this.creditButton.Size = new System.Drawing.Size(47, 23);
            this.creditButton.TabIndex = 6;
            this.creditButton.Text = "Credit";
            this.creditButton.UseVisualStyleBackColor = true;
            this.creditButton.Click += new System.EventHandler(this.creditButton_Click);
            // 
            // intRateBtn
            // 
            this.intRateBtn.Location = new System.Drawing.Point(158, 134);
            this.intRateBtn.Name = "intRateBtn";
            this.intRateBtn.Size = new System.Drawing.Size(75, 23);
            this.intRateBtn.TabIndex = 7;
            this.intRateBtn.Text = "Credit Int.";
            this.intRateBtn.UseVisualStyleBackColor = true;
            this.intRateBtn.Click += new System.EventHandler(this.intRateBtn_Click);
            // 
            // accountBox
            // 
            this.accountBox.FormattingEnabled = true;
            this.accountBox.Location = new System.Drawing.Point(12, 27);
            this.accountBox.Name = "accountBox";
            this.accountBox.Size = new System.Drawing.Size(121, 21);
            this.accountBox.TabIndex = 8;
            this.accountBox.SelectedIndexChanged += new System.EventHandler(this.accountBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select Account:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 169);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.accountBox);
            this.Controls.Add(this.intRateBtn);
            this.Controls.Add(this.creditButton);
            this.Controls.Add(this.debitButton);
            this.Controls.Add(this.transactionAmountLabel);
            this.Controls.Add(this.transactionBox);
            this.Controls.Add(this.balanceAmount);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.TextBox balanceAmount;
        private System.Windows.Forms.TextBox transactionBox;
        private System.Windows.Forms.Label transactionAmountLabel;
        private System.Windows.Forms.Button debitButton;
        private System.Windows.Forms.Button creditButton;
        private System.Windows.Forms.Button intRateBtn;
        private System.Windows.Forms.ComboBox accountBox;
        private System.Windows.Forms.Label label2;
    }
}

