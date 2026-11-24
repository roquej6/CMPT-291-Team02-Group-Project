namespace MovieRentalApp
{
    partial class CustomerForm
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
            labelName = new Label();
            LabelID = new Label();
            txtSearchName = new TextBox();
            txtSearchID = new TextBox();
            btnSearch = new Button();
            labelCreateID = new Label();
            txtCreateID = new TextBox();
            lableCreateName = new Label();
            txtCreateName = new TextBox();
            labelEmail = new Label();
            txtEmail = new TextBox();
            labelAge = new Label();
            txtAge = new TextBox();
            btnAddCustomer = new Button();
            dgvCustomerList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerList).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(49, 28);
            labelName.Name = "labelName";
            labelName.Size = new Size(49, 20);
            labelName.TabIndex = 0;
            labelName.Text = "Name";
            // 
            // LabelID
            // 
            LabelID.AutoSize = true;
            LabelID.Location = new Point(283, 28);
            LabelID.Name = "LabelID";
            LabelID.Size = new Size(24, 20);
            LabelID.TabIndex = 1;
            LabelID.Text = "ID";
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new Point(104, 28);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(125, 27);
            txtSearchName.TabIndex = 2;
            // 
            // txtSearchID
            // 
            txtSearchID.Location = new Point(313, 28);
            txtSearchID.Name = "txtSearchID";
            txtSearchID.Size = new Size(125, 27);
            txtSearchID.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(512, 28);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // labelCreateID
            // 
            labelCreateID.AutoSize = true;
            labelCreateID.Location = new Point(74, 242);
            labelCreateID.Name = "labelCreateID";
            labelCreateID.Size = new Size(24, 20);
            labelCreateID.TabIndex = 5;
            labelCreateID.Text = "ID";
            // 
            // txtCreateID
            // 
            txtCreateID.Location = new Point(104, 235);
            txtCreateID.Name = "txtCreateID";
            txtCreateID.Size = new Size(125, 27);
            txtCreateID.TabIndex = 6;
            // 
            // lableCreateName
            // 
            lableCreateName.AutoSize = true;
            lableCreateName.Location = new Point(258, 242);
            lableCreateName.Name = "lableCreateName";
            lableCreateName.Size = new Size(49, 20);
            lableCreateName.TabIndex = 7;
            lableCreateName.Text = "Name";
            // 
            // txtCreateName
            // 
            txtCreateName.Location = new Point(313, 238);
            txtCreateName.Name = "txtCreateName";
            txtCreateName.Size = new Size(125, 27);
            txtCreateName.TabIndex = 8;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(52, 289);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(46, 20);
            labelEmail.TabIndex = 9;
            labelEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(104, 286);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 10;
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Location = new Point(273, 289);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(36, 20);
            labelAge.TabIndex = 11;
            labelAge.Text = "Age";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(313, 289);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(125, 27);
            txtAge.TabIndex = 12;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(512, 258);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(94, 51);
            btnAddCustomer.TabIndex = 13;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // dgvCustomerList
            // 
            dgvCustomerList.AllowUserToAddRows = false;
            dgvCustomerList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerList.Location = new Point(12, 74);
            dgvCustomerList.MultiSelect = false;
            dgvCustomerList.Name = "dgvCustomerList";
            dgvCustomerList.ReadOnly = true;
            dgvCustomerList.RowHeadersWidth = 51;
            dgvCustomerList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomerList.Size = new Size(616, 155);
            dgvCustomerList.TabIndex = 14;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(dgvCustomerList);
            Controls.Add(btnAddCustomer);
            Controls.Add(txtAge);
            Controls.Add(labelAge);
            Controls.Add(txtEmail);
            Controls.Add(labelEmail);
            Controls.Add(txtCreateName);
            Controls.Add(lableCreateName);
            Controls.Add(txtCreateID);
            Controls.Add(labelCreateID);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchID);
            Controls.Add(txtSearchName);
            Controls.Add(LabelID);
            Controls.Add(labelName);
            Margin = new Padding(2);
            Name = "CustomerForm";
            Text = "Customer";
            Load += CustomerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomerList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label LabelID;
        private TextBox txtSearchName;
        private TextBox txtSearchID;
        private Button btnSearch;
        private Label labelCreateID;
        private TextBox txtCreateID;
        private Label lableCreateName;
        private TextBox txtCreateName;
        private Label labelEmail;
        private TextBox txtEmail;
        private Label labelAge;
        private TextBox txtAge;
        private Button btnAddCustomer;
        private DataGridView dgvCustomerList;
    }
}