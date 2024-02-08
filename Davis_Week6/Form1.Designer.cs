namespace Davis_Week6
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
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.conversionBox = new System.Windows.Forms.ComboBox();
            this.fromMeasurement = new System.Windows.Forms.TextBox();
            this.toMeasurement = new System.Windows.Forms.TextBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversion:";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(12, 66);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(42, 13);
            this.fromLabel.TabIndex = 1;
            this.fromLabel.Text = "Meters:";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(12, 117);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(31, 13);
            this.toLabel.TabIndex = 2;
            this.toLabel.Text = "Feet:";
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Location = new System.Drawing.Point(15, 159);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(75, 23);
            this.CalculateBtn.TabIndex = 3;
            this.CalculateBtn.Text = "&Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(185, 159);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 4;
            this.ExitBtn.Text = "E&xit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // conversionBox
            // 
            this.conversionBox.Location = new System.Drawing.Point(113, 15);
            this.conversionBox.Name = "conversionBox";
            this.conversionBox.Size = new System.Drawing.Size(121, 21);
            this.conversionBox.TabIndex = 8;
            this.conversionBox.SelectedIndexChanged += new System.EventHandler(this.conversionBox_SelectedIndexChanged);
            // 
            // fromMeasurement
            // 
            this.fromMeasurement.Location = new System.Drawing.Point(113, 59);
            this.fromMeasurement.Name = "fromMeasurement";
            this.fromMeasurement.Size = new System.Drawing.Size(100, 20);
            this.fromMeasurement.TabIndex = 6;
            this.fromMeasurement.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fromMeasurement_KeyDown);
            // 
            // toMeasurement
            // 
            this.toMeasurement.Location = new System.Drawing.Point(113, 110);
            this.toMeasurement.Name = "toMeasurement";
            this.toMeasurement.ReadOnly = true;
            this.toMeasurement.Size = new System.Drawing.Size(100, 20);
            this.toMeasurement.TabIndex = 7;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(100, 159);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 9;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 194);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.toMeasurement);
            this.Controls.Add(this.fromMeasurement);
            this.Controls.Add(this.conversionBox);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Conversions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.ComboBox conversionBox;
        private System.Windows.Forms.TextBox fromMeasurement;
        private System.Windows.Forms.TextBox toMeasurement;
        private System.Windows.Forms.Button ClearBtn;
    }
}

