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
            txtForm.Location = new Point(528, 401);
            txtForm.Margin = new Padding(4, 4, 4, 4);
            txtForm.Name = "txtForm";
            txtForm.Size = new Size(256, 31);
            txtForm.TabIndex = 0;
            txtForm.Text = "MainMenuForm->MovieForm";
            txtForm.TextAlign = HorizontalAlignment.Center;
            txtForm.Visible = false;
            // 
            // btnTest
            // 
            btnTest.Location = new Point(15, 399);
            btnTest.Margin = new Padding(4, 4, 4, 4);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(154, 36);
            btnTest.TabIndex = 1;
            btnTest.Text = "Test Connection";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // txtInfo
            // 
            txtInfo.BorderStyle = BorderStyle.None;
            txtInfo.Location = new Point(189, 382);
            txtInfo.Margin = new Padding(4, 4, 4, 4);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.ReadOnly = true;
            txtInfo.Size = new Size(340, 52);
            txtInfo.TabIndex = 2;
            txtInfo.Text = "12 rows. go to Db.cs and experiment with connection string otherwise";
            // 
            // dgvMovies
            // 
            dgvMovies.AllowUserToAddRows = false;
            dgvMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovies.Location = new Point(15, 140);
            dgvMovies.Margin = new Padding(4, 4, 4, 4);
            dgvMovies.MultiSelect = false;
            dgvMovies.Name = "dgvMovies";
            dgvMovies.ReadOnly = true;
            dgvMovies.RowHeadersWidth = 51;
            dgvMovies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMovies.Size = new Size(770, 235);
            dgvMovies.TabIndex = 3;
            // 
            // cboType
            // 
            cboType.FormattingEnabled = true;
            cboType.Location = new Point(138, 15);
            cboType.Margin = new Padding(4, 4, 4, 4);
            cboType.Name = "cboType";
            cboType.Size = new Size(188, 33);
            cboType.TabIndex = 4;
            cboType.SelectedIndexChanged += cboType_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(15, 15);
            textBox1.Margin = new Padding(4, 4, 4, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(115, 30);
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
            btnSearch.Location = new Point(269, 78);
            btnSearch.Margin = new Padding(4, 4, 4, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(118, 36);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(334, 15);
            textBox2.Margin = new Padding(4, 4, 4, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(115, 30);
            textBox2.TabIndex = 8;
            textBox2.Text = "Title";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(456, 15);
            txtSearch.Margin = new Padding(4, 4, 4, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(155, 31);
            txtSearch.TabIndex = 9;
            // 
            // MovieForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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