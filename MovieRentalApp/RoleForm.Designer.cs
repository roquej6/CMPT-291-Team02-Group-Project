namespace MovieRentalApp
{
    partial class RoleForm
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
            lblRole = new Label();
            cboRole = new ComboBox();
            btnOpen = new Button();
            SuspendLayout();
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(103, 32);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(138, 25);
            lblRole.TabIndex = 0;
            lblRole.Text = "Select your role:";
            // 
            // cboRole
            // 
            cboRole.FormattingEnabled = true;
            cboRole.Items.AddRange(new object[] { "Customer", "Employee" });
            cboRole.Location = new Point(103, 60);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(182, 33);
            cboRole.TabIndex = 1;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(306, 62);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(112, 34);
            btnOpen.TabIndex = 2;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // RoleForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOpen);
            Controls.Add(cboRole);
            Controls.Add(lblRole);
            Name = "RoleForm";
            Text = "Movie Rental - Select Role";
            Load += RoleForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRole;
        private ComboBox cboRole;
        private Button btnOpen;
    }
}
