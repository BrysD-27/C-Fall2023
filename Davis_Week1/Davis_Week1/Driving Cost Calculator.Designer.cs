namespace Davis_Week1
{
    partial class DrivingCostCalculator_Form
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.milesDrivenBox = new System.Windows.Forms.TextBox();
            this.costPerGallonBox = new System.Windows.Forms.TextBox();
            this.avgMpgBox = new System.Windows.Forms.TextBox();
            this.parkingFeeBox = new System.Windows.Forms.TextBox();
            this.tollsPerDayBox = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter total miles driven per day:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cost per gallon of gasoline(in cents):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Average miles per gallon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Parking fees per day( in cents):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tolls per day(in cents):";
            // 
            // milesDrivenBox
            // 
            this.milesDrivenBox.Location = new System.Drawing.Point(256, 29);
            this.milesDrivenBox.Name = "milesDrivenBox";
            this.milesDrivenBox.Size = new System.Drawing.Size(100, 20);
            this.milesDrivenBox.TabIndex = 5;
            // 
            // costPerGallonBox
            // 
            this.costPerGallonBox.Location = new System.Drawing.Point(256, 71);
            this.costPerGallonBox.Name = "costPerGallonBox";
            this.costPerGallonBox.Size = new System.Drawing.Size(100, 20);
            this.costPerGallonBox.TabIndex = 6;
            // 
            // avgMpgBox
            // 
            this.avgMpgBox.Location = new System.Drawing.Point(256, 113);
            this.avgMpgBox.Name = "avgMpgBox";
            this.avgMpgBox.Size = new System.Drawing.Size(100, 20);
            this.avgMpgBox.TabIndex = 7;
            // 
            // parkingFeeBox
            // 
            this.parkingFeeBox.Location = new System.Drawing.Point(256, 155);
            this.parkingFeeBox.Name = "parkingFeeBox";
            this.parkingFeeBox.Size = new System.Drawing.Size(100, 20);
            this.parkingFeeBox.TabIndex = 8;
            // 
            // tollsPerDayBox
            // 
            this.tollsPerDayBox.Location = new System.Drawing.Point(256, 197);
            this.tollsPerDayBox.Name = "tollsPerDayBox";
            this.tollsPerDayBox.Size = new System.Drawing.Size(100, 20);
            this.tollsPerDayBox.TabIndex = 9;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(256, 256);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(75, 23);
            this.calculateBtn.TabIndex = 10;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cost per day(cents):";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(133, 256);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 12;
            // 
            // DrivingCostCalculator_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 328);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.tollsPerDayBox);
            this.Controls.Add(this.parkingFeeBox);
            this.Controls.Add(this.avgMpgBox);
            this.Controls.Add(this.costPerGallonBox);
            this.Controls.Add(this.milesDrivenBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DrivingCostCalculator_Form";
            this.Text = "Driving Cost Calculator";
            this.Load += new System.EventHandler(this.DrivingCostCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox milesDrivenBox;
        private System.Windows.Forms.TextBox costPerGallonBox;
        private System.Windows.Forms.TextBox avgMpgBox;
        private System.Windows.Forms.TextBox parkingFeeBox;
        private System.Windows.Forms.TextBox tollsPerDayBox;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label resultLabel;
    }
}

