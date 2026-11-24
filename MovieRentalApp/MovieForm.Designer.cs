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
            txtForm = new TextBox();
            btnTest = new Button();
            txtInfo = new TextBox();
            dgvMovies = new DataGridView();
            cboType = new ComboBox();
            textBox1 = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnSearch = new Button();
            textBox2 = new TextBox();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvMovies).BeginInit();
            SuspendLayout();
            // 
            // txtForm
            // 
            txtForm.Location = new Point(422, 321);
            txtForm.Name = "txtForm";
            txtForm.Size = new Size(206, 27);
            txtForm.TabIndex = 0;
            txtForm.Text = "MainMenuForm->MovieForm";
            txtForm.TextAlign = HorizontalAlignment.Center;
            txtForm.Visible = false;
            // 
            // btnTest
            // 
            btnTest.Location = new Point(12, 319);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(123, 29);
            btnTest.TabIndex = 1;
            btnTest.Text = "Test Connection";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // txtInfo
            // 
            txtInfo.BorderStyle = BorderStyle.None;
            txtInfo.Location = new Point(151, 306);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.ReadOnly = true;
            txtInfo.Size = new Size(272, 42);
            txtInfo.TabIndex = 2;
            txtInfo.Text = "12 rows. go to Db.cs and experiment with connection string otherwise";
            // 
            // dgvMovies
            // 
            dgvMovies.AllowUserToAddRows = false;
            dgvMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovies.Location = new Point(12, 112);
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
            btnSearch.Location = new Point(215, 62);
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
            // txtSearch
            // 
            txtSearch.Location = new Point(365, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(125, 27);
            txtSearch.TabIndex = 9;
            // 
            // MovieForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(txtSearch);
            Controls.Add(textBox2);
            Controls.Add(btnSearch);
            Controls.Add(textBox1);
            Controls.Add(cboType);
            Controls.Add(dgvMovies);
            Controls.Add(txtInfo);
            Controls.Add(btnTest);
            Controls.Add(txtForm);
            Margin = new Padding(2);
            Name = "MovieForm";
            Text = "Movie Screen";
            Load += MovieForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMovies).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtForm;
        private Button btnTest;
        private TextBox txtInfo;
        private DataGridView dgvMovies;
        private ComboBox cboType;
        private TextBox textBox1;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnSearch;
        private TextBox textBox2;
        private TextBox txtSearch;
    }
}