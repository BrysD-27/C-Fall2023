namespace Davis_Week3
{
    partial class LunchOrder
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
            this.mainCourseBox = new System.Windows.Forms.GroupBox();
            this.saladBtn = new System.Windows.Forms.RadioButton();
            this.pizzaBtn = new System.Windows.Forms.RadioButton();
            this.hamburgerBtn = new System.Windows.Forms.RadioButton();
            this.addonBox = new System.Windows.Forms.GroupBox();
            this.addonBox3 = new System.Windows.Forms.CheckBox();
            this.addonBox2 = new System.Windows.Forms.CheckBox();
            this.addonBox1 = new System.Windows.Forms.CheckBox();
            this.totalBox = new System.Windows.Forms.GroupBox();
            this.orderTotalBox = new System.Windows.Forms.TextBox();
            this.taxBox = new System.Windows.Forms.TextBox();
            this.subtotalBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.placeOrderBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.mainCourseBox.SuspendLayout();
            this.addonBox.SuspendLayout();
            this.totalBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainCourseBox
            // 
            this.mainCourseBox.Controls.Add(this.saladBtn);
            this.mainCourseBox.Controls.Add(this.pizzaBtn);
            this.mainCourseBox.Controls.Add(this.hamburgerBtn);
            this.mainCourseBox.Location = new System.Drawing.Point(12, 12);
            this.mainCourseBox.Name = "mainCourseBox";
            this.mainCourseBox.Size = new System.Drawing.Size(130, 90);
            this.mainCourseBox.TabIndex = 0;
            this.mainCourseBox.TabStop = false;
            this.mainCourseBox.Text = "Main course";
            // 
            // saladBtn
            // 
            this.saladBtn.AutoSize = true;
            this.saladBtn.Location = new System.Drawing.Point(6, 65);
            this.saladBtn.Name = "saladBtn";
            this.saladBtn.Size = new System.Drawing.Size(88, 17);
            this.saladBtn.TabIndex = 2;
            this.saladBtn.Text = "Salad - $4.95";
            this.saladBtn.UseVisualStyleBackColor = true;
            this.saladBtn.CheckedChanged += new System.EventHandler(this.updateMainCourse);
            // 
            // pizzaBtn
            // 
            this.pizzaBtn.AutoSize = true;
            this.pizzaBtn.Location = new System.Drawing.Point(6, 42);
            this.pizzaBtn.Name = "pizzaBtn";
            this.pizzaBtn.Size = new System.Drawing.Size(86, 17);
            this.pizzaBtn.TabIndex = 1;
            this.pizzaBtn.Text = "Pizza - $5.95";
            this.pizzaBtn.UseVisualStyleBackColor = true;
            this.pizzaBtn.CheckedChanged += new System.EventHandler(this.updateMainCourse);
            // 
            // hamburgerBtn
            // 
            this.hamburgerBtn.AutoSize = true;
            this.hamburgerBtn.Checked = true;
            this.hamburgerBtn.Location = new System.Drawing.Point(6, 19);
            this.hamburgerBtn.Name = "hamburgerBtn";
            this.hamburgerBtn.Size = new System.Drawing.Size(113, 17);
            this.hamburgerBtn.TabIndex = 0;
            this.hamburgerBtn.TabStop = true;
            this.hamburgerBtn.Text = "Hamburger - $6.95";
            this.hamburgerBtn.UseVisualStyleBackColor = true;
            // 
            // addonBox
            // 
            this.addonBox.Controls.Add(this.addonBox3);
            this.addonBox.Controls.Add(this.addonBox2);
            this.addonBox.Controls.Add(this.addonBox1);
            this.addonBox.Location = new System.Drawing.Point(148, 12);
            this.addonBox.Name = "addonBox";
            this.addonBox.Size = new System.Drawing.Size(174, 90);
            this.addonBox.TabIndex = 1;
            this.addonBox.TabStop = false;
            this.addonBox.Text = "Add-on items ($.75/each)";
            // 
            // addonBox3
            // 
            this.addonBox3.AutoSize = true;
            this.addonBox3.Location = new System.Drawing.Point(6, 64);
            this.addonBox3.Name = "addonBox3";
            this.addonBox3.Size = new System.Drawing.Size(81, 17);
            this.addonBox3.TabIndex = 4;
            this.addonBox3.Text = "French fries";
            this.addonBox3.UseVisualStyleBackColor = true;
            this.addonBox3.CheckStateChanged += new System.EventHandler(this.ClearTotals);
            // 
            // addonBox2
            // 
            this.addonBox2.AutoSize = true;
            this.addonBox2.Location = new System.Drawing.Point(6, 42);
            this.addonBox2.Name = "addonBox2";
            this.addonBox2.Size = new System.Drawing.Size(161, 17);
            this.addonBox2.TabIndex = 3;
            this.addonBox2.Text = "Ketchup, mustard, and mayo";
            this.addonBox2.UseVisualStyleBackColor = true;
            this.addonBox2.CheckStateChanged += new System.EventHandler(this.ClearTotals);
            // 
            // addonBox1
            // 
            this.addonBox1.AutoSize = true;
            this.addonBox1.Location = new System.Drawing.Point(6, 20);
            this.addonBox1.Name = "addonBox1";
            this.addonBox1.Size = new System.Drawing.Size(158, 17);
            this.addonBox1.TabIndex = 2;
            this.addonBox1.Text = "Lettuce, tomato, and onions";
            this.addonBox1.UseVisualStyleBackColor = true;
            this.addonBox1.CheckStateChanged += new System.EventHandler(this.ClearTotals);
            // 
            // totalBox
            // 
            this.totalBox.Controls.Add(this.orderTotalBox);
            this.totalBox.Controls.Add(this.taxBox);
            this.totalBox.Controls.Add(this.subtotalBox);
            this.totalBox.Controls.Add(this.label1);
            this.totalBox.Controls.Add(this.label2);
            this.totalBox.Controls.Add(this.label3);
            this.totalBox.Location = new System.Drawing.Point(18, 111);
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(200, 108);
            this.totalBox.TabIndex = 0;
            this.totalBox.TabStop = false;
            this.totalBox.Text = "Order Total";
            // 
            // orderTotalBox
            // 
            this.orderTotalBox.Location = new System.Drawing.Point(116, 77);
            this.orderTotalBox.Name = "orderTotalBox";
            this.orderTotalBox.ReadOnly = true;
            this.orderTotalBox.Size = new System.Drawing.Size(59, 20);
            this.orderTotalBox.TabIndex = 7;
            // 
            // taxBox
            // 
            this.taxBox.Location = new System.Drawing.Point(116, 48);
            this.taxBox.Name = "taxBox";
            this.taxBox.ReadOnly = true;
            this.taxBox.Size = new System.Drawing.Size(59, 20);
            this.taxBox.TabIndex = 6;
            // 
            // subtotalBox
            // 
            this.subtotalBox.Location = new System.Drawing.Point(116, 19);
            this.subtotalBox.Name = "subtotalBox";
            this.subtotalBox.ReadOnly = true;
            this.subtotalBox.Size = new System.Drawing.Size(59, 20);
            this.subtotalBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Subtotal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tax (7.75%):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Order Total:";
            // 
            // placeOrderBtn
            // 
            this.placeOrderBtn.Location = new System.Drawing.Point(237, 120);
            this.placeOrderBtn.Name = "placeOrderBtn";
            this.placeOrderBtn.Size = new System.Drawing.Size(75, 23);
            this.placeOrderBtn.TabIndex = 0;
            this.placeOrderBtn.Text = "Place Order";
            this.placeOrderBtn.UseVisualStyleBackColor = true;
            this.placeOrderBtn.Click += new System.EventHandler(this.PlaceOrder);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(237, 196);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.Exit);
            // 
            // LunchOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 240);
            this.Controls.Add(this.placeOrderBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.addonBox);
            this.Controls.Add(this.mainCourseBox);
            this.Name = "LunchOrder";
            this.Text = "z`";
            this.mainCourseBox.ResumeLayout(false);
            this.mainCourseBox.PerformLayout();
            this.addonBox.ResumeLayout(false);
            this.addonBox.PerformLayout();
            this.totalBox.ResumeLayout(false);
            this.totalBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mainCourseBox;
        private System.Windows.Forms.RadioButton hamburgerBtn;
        private System.Windows.Forms.RadioButton saladBtn;
        private System.Windows.Forms.RadioButton pizzaBtn;
        private System.Windows.Forms.GroupBox addonBox;
        private System.Windows.Forms.GroupBox totalBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button placeOrderBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox orderTotalBox;
        private System.Windows.Forms.TextBox taxBox;
        private System.Windows.Forms.TextBox subtotalBox;
        private System.Windows.Forms.CheckBox addonBox3;
        private System.Windows.Forms.CheckBox addonBox2;
        private System.Windows.Forms.CheckBox addonBox1;
    }
}

