namespace MovieRentalApp
{
    partial class MovieForm
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
            components = new System.ComponentModel.Container();
            dgvMovies = new DataGridView();
            cboType = new ComboBox();
            textBox1 = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnSearch = new Button();
            textBox2 = new TextBox();
            txtTitle = new TextBox();
            textBox3 = new TextBox();
            cboAvailable = new ComboBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            txtID = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMovies).BeginInit();
            SuspendLayout();
            // 
            // dgvMovies
            // 
            dgvMovies.AllowUserToAddRows = false;
            dgvMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovies.Location = new Point(12, 47);
            dgvMovies.MultiSelect = false;
            dgvMovies.Name = "dgvMovies";
            dgvMovies.ReadOnly = true;
            dgvMovies.RowHeadersWidth = 51;
            dgvMovies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMovies.Size = new Size(616, 188);
            dgvMovies.TabIndex = 3;
            // 
            // cboType
            // 
            cboType.FormattingEnabled = true;
            cboType.Location = new Point(110, 12);
            cboType.Name = "cboType";
            cboType.Size = new Size(151, 28);
            cboType.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(92, 24);
            textBox1.TabIndex = 5;
            textBox1.Text = "Type (Genre)";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(522, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(267, 12);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(92, 24);
            textBox2.TabIndex = 8;
            textBox2.Text = "Title";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(365, 12);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(125, 27);
            txtTitle.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(12, 241);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(196, 24);
            textBox3.TabIndex = 10;
            textBox3.Text = "Additional Add/Update Info";
            // 
            // cboAvailable
            // 
            cboAvailable.FormattingEnabled = true;
            cboAvailable.Items.AddRange(new object[] { "Yes", "No" });
            cboAvailable.Location = new Point(110, 283);
            cboAvailable.Name = "cboAvailable";
            cboAvailable.Size = new Size(151, 28);
            cboAvailable.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(12, 286);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(92, 24);
            textBox4.TabIndex = 12;
            textBox4.Text = "Availability";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Location = new Point(267, 287);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(92, 24);
            textBox5.TabIndex = 13;
            textBox5.Text = "ID";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // txtID
            // 
            txtID.Location = new Point(365, 283);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 14;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(522, 263);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(522, 298);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // MovieForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtID);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(cboAvailable);
            Controls.Add(textBox3);
            Controls.Add(txtTitle);
            Controls.Add(textBox2);
            Controls.Add(btnSearch);
            Controls.Add(textBox1);
            Controls.Add(cboType);
            Controls.Add(dgvMovies);
            Margin = new Padding(2);
            Name = "MovieForm";
            Text = "Movie Screen (Employee)";
            Load += MovieForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMovies).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvMovies;
        private ComboBox cboType;
        private TextBox textBox1;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnSearch;
        private TextBox textBox2;
        private TextBox txtTitle;
        private TextBox textBox3;
        private ComboBox cboAvailable;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox txtID;
        private Button btnAdd;
        private Button btnUpdate;
    }
}