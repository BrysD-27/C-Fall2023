namespace InventoryMaintenance
{
    partial class frmInvMaint
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstItems = new System.Windows.Forms.ListBox();
            btnAdd = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            cboFilterBy = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lstItems
            // 
            lstItems.FormattingEnabled = true;
            lstItems.ItemHeight = 15;
            lstItems.Location = new System.Drawing.Point(19, 55);
            lstItems.Margin = new System.Windows.Forms.Padding(2);
            lstItems.Name = "lstItems";
            lstItems.Size = new System.Drawing.Size(306, 154);
            lstItems.TabIndex = 10;
            lstItems.SelectedIndexChanged += lstItems_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(348, 55);
            btnAdd.Margin = new System.Windows.Forms.Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(97, 25);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add Item";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(348, 92);
            btnDelete.Margin = new System.Windows.Forms.Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(97, 25);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete Item";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(348, 128);
            btnExit.Margin = new System.Windows.Forms.Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(97, 25);
            btnExit.TabIndex = 5;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // cboFilterBy
            // 
            cboFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboFilterBy.FormattingEnabled = true;
            cboFilterBy.Location = new System.Drawing.Point(65, 13);
            cboFilterBy.Margin = new System.Windows.Forms.Padding(2);
            cboFilterBy.Name = "cboFilterBy";
            cboFilterBy.Size = new System.Drawing.Size(129, 23);
            cboFilterBy.TabIndex = 1;
            cboFilterBy.SelectedIndexChanged += cboFilterBy_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(19, 15);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(39, 15);
            label2.TabIndex = 15;
            label2.Text = "Show:";
            // 
            // frmInvMaint
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new System.Drawing.Size(476, 233);
            Controls.Add(label2);
            Controls.Add(cboFilterBy);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(lstItems);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "frmInvMaint";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Inventory Maintenance";
            Load += frmInvMaint_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cboFilterBy;
        private System.Windows.Forms.Label label2;
    }
}

