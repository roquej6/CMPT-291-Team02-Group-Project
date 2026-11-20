using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieRentalApp
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }



        private void btnMovie_Click(object sender, EventArgs e)
        {
            new MovieForm().ShowDialog();
        }

        private void btnMovieActor_Click(object sender, EventArgs e)
        {
            new ReportsForm().ShowDialog();
        }

        private void btnRental_Click(object sender, EventArgs e)
        {
            new RentalForm().ShowDialog();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            new CustomerForm().ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            new ReportsForm().ShowDialog();
        }
    }
}
