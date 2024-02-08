namespace StateMaintenance
{
    partial class frmStateMaintenance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            btnAdd = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            dataGridView = new System.Windows.Forms.DataGridView();
            nextPage = new System.Windows.Forms.Button();
            lastPage = new System.Windows.Forms.Button();
            previousPage = new System.Windows.Forms.Button();
            firstPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(21, 300);
            btnAdd.Margin = new System.Windows.Forms.Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(78, 25);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(394, 300);
            btnExit.Margin = new System.Windows.Forms.Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(78, 25);
            btnExit.TabIndex = 4;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // dataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new System.Drawing.Point(21, 12);
            dataGridView.Name = "dataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new System.Drawing.Size(451, 272);
            dataGridView.TabIndex = 5;
            dataGridView.CellClick += dataGridView_CellClick;
            // 
            // nextPage
            // 
            nextPage.Location = new System.Drawing.Point(260, 302);
            nextPage.Name = "nextPage";
            nextPage.Size = new System.Drawing.Size(40, 23);
            nextPage.TabIndex = 6;
            nextPage.Text = ">";
            nextPage.UseVisualStyleBackColor = true;
            nextPage.Click += nextPage_Click;
            // 
            // lastPage
            // 
            lastPage.Location = new System.Drawing.Point(327, 302);
            lastPage.Name = "lastPage";
            lastPage.Size = new System.Drawing.Size(40, 23);
            lastPage.TabIndex = 7;
            lastPage.Text = ">>";
            lastPage.UseVisualStyleBackColor = true;
            lastPage.Click += lastPage_Click;
            // 
            // previousPage
            // 
            previousPage.Location = new System.Drawing.Point(193, 302);
            previousPage.Name = "previousPage";
            previousPage.Size = new System.Drawing.Size(40, 23);
            previousPage.TabIndex = 9;
            previousPage.Text = "<";
            previousPage.UseVisualStyleBackColor = true;
            previousPage.Click += previousPage_Click;
            // 
            // firstPage
            // 
            firstPage.Location = new System.Drawing.Point(126, 302);
            firstPage.Name = "firstPage";
            firstPage.Size = new System.Drawing.Size(40, 23);
            firstPage.TabIndex = 8;
            firstPage.Text = "<<";
            firstPage.UseVisualStyleBackColor = true;
            firstPage.Click += firstPage_Click;
            // 
            // frmStateMaintenance
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new System.Drawing.Size(494, 336);
            Controls.Add(previousPage);
            Controls.Add(firstPage);
            Controls.Add(lastPage);
            Controls.Add(nextPage);
            Controls.Add(dataGridView);
            Controls.Add(btnExit);
            Controls.Add(btnAdd);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "frmStateMaintenance";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "State Maintenance";
            Load += frmStateMaintenance_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button nextPage;
        private System.Windows.Forms.Button lastPage;
        private System.Windows.Forms.Button previousPage;
        private System.Windows.Forms.Button firstPage;
    }
}

