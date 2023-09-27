namespace Davis_Week5
{
    partial class AirlineReservation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.econClassBtn = new System.Windows.Forms.RadioButton();
            this.firstClassBtn = new System.Windows.Forms.RadioButton();
            this.bookBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.econClassBtn);
            this.groupBox1.Controls.Add(this.firstClassBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 68);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pick a Cabin class";
            // 
            // econClassBtn
            // 
            this.econClassBtn.AutoSize = true;
            this.econClassBtn.Location = new System.Drawing.Point(6, 42);
            this.econClassBtn.Name = "econClassBtn";
            this.econClassBtn.Size = new System.Drawing.Size(96, 17);
            this.econClassBtn.TabIndex = 1;
            this.econClassBtn.Text = "Economy class";
            this.econClassBtn.UseVisualStyleBackColor = true;
            // 
            // firstClassBtn
            // 
            this.firstClassBtn.AutoSize = true;
            this.firstClassBtn.Checked = true;
            this.firstClassBtn.Location = new System.Drawing.Point(6, 19);
            this.firstClassBtn.Name = "firstClassBtn";
            this.firstClassBtn.Size = new System.Drawing.Size(72, 17);
            this.firstClassBtn.TabIndex = 0;
            this.firstClassBtn.TabStop = true;
            this.firstClassBtn.Text = "First Class";
            this.firstClassBtn.UseVisualStyleBackColor = true;
            // 
            // bookBtn
            // 
            this.bookBtn.Location = new System.Drawing.Point(144, 105);
            this.bookBtn.Name = "bookBtn";
            this.bookBtn.Size = new System.Drawing.Size(75, 23);
            this.bookBtn.TabIndex = 2;
            this.bookBtn.Text = "Book";
            this.bookBtn.UseVisualStyleBackColor = true;
            this.bookBtn.Click += new System.EventHandler(this.BookBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 140);
            this.Controls.Add(this.bookBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Airline Reservation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton econClassBtn;
        private System.Windows.Forms.RadioButton firstClassBtn;
        private System.Windows.Forms.Button bookBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

