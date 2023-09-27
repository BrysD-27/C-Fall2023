namespace Davis_Week2
{
    partial class AreaAndPerimeterForm
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
            this.lengthBox = new System.Windows.Forms.TextBox();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.areaBox = new System.Windows.Forms.TextBox();
            this.perimeterBox = new System.Windows.Forms.TextBox();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Length:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Width:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Area:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Perimeter:";
            // 
            // lengthBox
            // 
            this.lengthBox.Location = new System.Drawing.Point(169, 32);
            this.lengthBox.Name = "lengthBox";
            this.lengthBox.Size = new System.Drawing.Size(100, 20);
            this.lengthBox.TabIndex = 4;
            this.lengthBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AreaAndPerimeterForm_KeyDown);
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(169, 75);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(100, 20);
            this.widthBox.TabIndex = 5;
            this.widthBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AreaAndPerimeterForm_KeyDown);
            // 
            // areaBox
            // 
            this.areaBox.Location = new System.Drawing.Point(169, 118);
            this.areaBox.Name = "areaBox";
            this.areaBox.ReadOnly = true;
            this.areaBox.Size = new System.Drawing.Size(100, 20);
            this.areaBox.TabIndex = 6;
            this.areaBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AreaAndPerimeterForm_KeyDown);
            // 
            // perimeterBox
            // 
            this.perimeterBox.Location = new System.Drawing.Point(169, 161);
            this.perimeterBox.Name = "perimeterBox";
            this.perimeterBox.ReadOnly = true;
            this.perimeterBox.Size = new System.Drawing.Size(100, 20);
            this.perimeterBox.TabIndex = 7;
            this.perimeterBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AreaAndPerimeterForm_KeyDown);
            // 
            // CalcBtn
            // 
            this.CalcBtn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.CalcBtn.Location = new System.Drawing.Point(44, 211);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(75, 23);
            this.CalcBtn.TabIndex = 8;
            this.CalcBtn.Text = "&Calculate";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            this.CalcBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AreaAndPerimeterForm_KeyDown);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(194, 211);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 9;
            this.ExitBtn.Text = "E&xit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            this.ExitBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AreaAndPerimeterForm_KeyDown);
            // 
            // AreaAndPerimeterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 249);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.CalcBtn);
            this.Controls.Add(this.perimeterBox);
            this.Controls.Add(this.areaBox);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.lengthBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AreaAndPerimeterForm";
            this.Text = "Area And Perimeter";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AreaAndPerimeterForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lengthBox;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.TextBox areaBox;
        private System.Windows.Forms.TextBox perimeterBox;
        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}

