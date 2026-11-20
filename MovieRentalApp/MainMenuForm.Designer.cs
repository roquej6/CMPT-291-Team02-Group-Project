namespace MovieRentalApp
{
    partial class MainMenuForm
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
            lblMainMenu = new Label();
            btnCustomer = new Button();
            btnMovie = new Button();
            btnMovieActor = new Button();
            btnRental = new Button();
            btnReports = new Button();
            SuspendLayout();
            // 
            // lblMainMenu
            // 
            lblMainMenu.AutoSize = true;
            lblMainMenu.Location = new Point(215, 28);
            lblMainMenu.Name = "lblMainMenu";
            lblMainMenu.Size = new Size(208, 25);
            lblMainMenu.TabIndex = 0;
            lblMainMenu.Text = "Movie Rental Main Menu";
            // 
            // btnCustomer
            // 
            btnCustomer.Location = new Point(12, 86);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(112, 34);
            btnCustomer.TabIndex = 1;
            btnCustomer.Text = "Customer";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnMovie
            // 
            btnMovie.Location = new Point(12, 126);
            btnMovie.Name = "btnMovie";
            btnMovie.Size = new Size(112, 34);
            btnMovie.TabIndex = 2;
            btnMovie.Text = "Movie";
            btnMovie.UseVisualStyleBackColor = true;
            btnMovie.Click += btnMovie_Click;
            // 
            // btnMovieActor
            // 
            btnMovieActor.Location = new Point(12, 166);
            btnMovieActor.Name = "btnMovieActor";
            btnMovieActor.Size = new Size(112, 34);
            btnMovieActor.TabIndex = 3;
            btnMovieActor.Text = "Movie-Actor";
            btnMovieActor.UseVisualStyleBackColor = true;
            btnMovieActor.Click += btnMovieActor_Click;
            // 
            // btnRental
            // 
            btnRental.Location = new Point(12, 206);
            btnRental.Name = "btnRental";
            btnRental.Size = new Size(112, 34);
            btnRental.TabIndex = 4;
            btnRental.Text = "Rental";
            btnRental.UseVisualStyleBackColor = true;
            btnRental.Click += btnRental_Click;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(12, 246);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(112, 34);
            btnReports.TabIndex = 5;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReports);
            Controls.Add(btnRental);
            Controls.Add(btnMovieActor);
            Controls.Add(btnMovie);
            Controls.Add(btnCustomer);
            Controls.Add(lblMainMenu);
            Name = "MainMenuForm";
            Text = "Movie Rental - Main Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMainMenu;
        private Button btnCustomer;
        private Button btnMovie;
        private Button btnMovieActor;
        private Button btnRental;
        private Button btnReports;
    }
}