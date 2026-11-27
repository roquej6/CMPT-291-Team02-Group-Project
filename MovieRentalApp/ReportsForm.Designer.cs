namespace MovieRentalApp
{
    partial class ReportsForm
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
            btnReportMRI = new Button();
            dgvReports = new DataGridView();
            btnReportMAC = new Button();
            btnReportMFRM = new Button();
            btnReportMRBF = new Button();
            btnReportMWMR = new Button();
            textBox1 = new TextBox();
            cboType = new ComboBox();
            textBox2 = new TextBox();
            txtSearch = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            SuspendLayout();
            // 
            // btnReportMRI
            // 
            btnReportMRI.Location = new Point(13, 37);
            btnReportMRI.Margin = new Padding(4);
            btnReportMRI.Name = "btnReportMRI";
            btnReportMRI.Size = new Size(231, 36);
            btnReportMRI.TabIndex = 9;
            btnReportMRI.Text = "Monthly Rental Income";
            btnReportMRI.UseVisualStyleBackColor = true;
            btnReportMRI.Click += btnReportMRI_Click;
            // 
            // dgvReports
            // 
            dgvReports.AllowUserToAddRows = false;
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReports.Location = new Point(13, 202);
            dgvReports.Margin = new Padding(4);
            dgvReports.MultiSelect = false;
            dgvReports.Name = "dgvReports";
            dgvReports.ReadOnly = true;
            dgvReports.RowHeadersWidth = 51;
            dgvReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReports.Size = new Size(770, 235);
            dgvReports.TabIndex = 8;
            dgvReports.CellContentClick += dgvReports_CellContentClick;
            // 
            // btnReportMAC
            // 
            btnReportMAC.Location = new Point(560, 37);
            btnReportMAC.Margin = new Padding(4);
            btnReportMAC.Name = "btnReportMAC";
            btnReportMAC.Size = new Size(231, 36);
            btnReportMAC.TabIndex = 10;
            btnReportMAC.Text = "Most Active Customers";
            btnReportMAC.UseVisualStyleBackColor = true;
            btnReportMAC.Click += btnReportMAC_Click;
            // 
            // btnReportMFRM
            // 
            btnReportMFRM.Location = new Point(266, 37);
            btnReportMFRM.Margin = new Padding(4);
            btnReportMFRM.Name = "btnReportMFRM";
            btnReportMFRM.Size = new Size(275, 36);
            btnReportMFRM.TabIndex = 11;
            btnReportMFRM.Text = "Most Frequently Rented Movies";
            btnReportMFRM.UseVisualStyleBackColor = true;
            btnReportMFRM.Click += btnReportMFRM_Click;
            // 
            // btnReportMRBF
            // 
            btnReportMRBF.Location = new Point(34, 115);
            btnReportMRBF.Margin = new Padding(4);
            btnReportMRBF.Name = "btnReportMRBF";
            btnReportMRBF.Size = new Size(231, 36);
            btnReportMRBF.TabIndex = 12;
            btnReportMRBF.Text = "Movie Rentals By Filter";
            btnReportMRBF.UseVisualStyleBackColor = true;
            btnReportMRBF.Click += btnReportMRBF_Click;
            // 
            // btnReportMWMR
            // 
            btnReportMWMR.Location = new Point(428, 117);
            btnReportMWMR.Margin = new Padding(4);
            btnReportMWMR.Name = "btnReportMWMR";
            btnReportMWMR.Size = new Size(286, 36);
            btnReportMWMR.TabIndex = 13;
            btnReportMWMR.Text = "Movies With Minimum Rating";
            btnReportMWMR.UseVisualStyleBackColor = true;
            btnReportMWMR.Click += btnReportMWMR_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(34, 161);
            textBox1.Margin = new Padding(4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(86, 30);
            textBox1.TabIndex = 15;
            textBox1.Text = "Filter by:";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // cboType
            // 
            cboType.FormattingEnabled = true;
            cboType.Items.AddRange(new object[] { "Title", "Genre", "Customer" });
            cboType.Location = new Point(119, 159);
            cboType.Margin = new Padding(4);
            cboType.Name = "cboType";
            cboType.Size = new Size(115, 33);
            cboType.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(456, 161);
            textBox2.Margin = new Padding(4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(159, 30);
            textBox2.TabIndex = 16;
            textBox2.Text = "Minimum Rating:";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(608, 161);
            txtSearch.Margin = new Padding(4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(106, 31);
            txtSearch.TabIndex = 17;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(266, 123);
            textBox3.Margin = new Padding(4);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(109, 30);
            textBox3.TabIndex = 18;
            textBox3.Text = "Filter Value:";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(277, 161);
            textBox4.Margin = new Padding(4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(84, 31);
            textBox4.TabIndex = 19;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(txtSearch);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(cboType);
            Controls.Add(btnReportMWMR);
            Controls.Add(btnReportMRBF);
            Controls.Add(btnReportMFRM);
            Controls.Add(btnReportMAC);
            Controls.Add(btnReportMRI);
            Controls.Add(dgvReports);
            Name = "ReportsForm";
            Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReportMRI;
        private DataGridView dgvReports;
        private Button btnReportMAC;
        private Button btnReportMFRM;
        private Button btnReportMRBF;
        private Button btnReportMWMR;
        private TextBox textBox1;
        private ComboBox cboType;
        private TextBox textBox2;
        private TextBox txtSearch;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}