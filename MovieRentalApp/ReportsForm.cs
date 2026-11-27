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
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }
        private void LoadReportMRI()
        {
            dgvReports.DataSource = Db.Query(
                "SELECT Year(date_added) AS year, Month(date_added) AS month, count(rental_id) AS num_of_rentals, count(rental_id) * 5 AS total_charges FROM rental GROUP BY Year(date_added), Month(date_added) ORDER BY year, month");
        }
        private void LoadReportMAC()
        {
            dgvReports.DataSource = Db.Query(
                "select c.customer_id, c.name AS customerName, count(*) AS total_rentals, count(*) * 5 AS total_charges From customer AS c join renting as r ON c.customer_id = r.customer_id join rental As rt on r.rental_id = rt.rental_id Group by c.customer_id, c.name Order by total_rentals DESC");
        }
        private void LoadReportMFRM()
        {
            dgvReports.DataSource = Db.Query(
                "Select TOP 5 WITH TIES m.title, g.genre, count(distinct r.rental_id) AS num_of_rentals, AVG(mr.rating) AS avg_rating From movie AS m join rental AS R ON m.movie_id = r.movie_id join movie_genres AS g ON m.movie_id = g.movie_id left join movie_ratings AS mr ON m.movie_id = mr.movie_id Group By m.movie_id, m.title, g.genre Order by num_of_rentals DESC");
        }
        private void LoadReportMRBF()
        {
            dgvReports.DataSource = Db.Query(
                "Select TOP 5 WITH TIES m.title, g.genre, count(distinct r.rental_id) AS num_of_rentals, AVG(mr.rating) AS avg_rating From movie AS m join rental AS R ON m.movie_id = r.movie_id join movie_genres AS g ON m.movie_id = g.movie_id left join movie_ratings AS mr ON m.movie_id = mr.movie_id Group By m.movie_id, m.title, g.genre Order by num_of_rentals DESC");
        }
        private void LoadReportMWMR()
        {
            dgvReports.DataSource = Db.Query(
                "Select TOP 5 WITH TIES m.title, g.genre, count(distinct r.rental_id) AS num_of_rentals, AVG(mr.rating) AS avg_rating From movie AS m join rental AS R ON m.movie_id = r.movie_id join movie_genres AS g ON m.movie_id = g.movie_id left join movie_ratings AS mr ON m.movie_id = mr.movie_id Group By m.movie_id, m.title, g.genre Order by num_of_rentals DESC");
        }
        private void dgvReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnReportMRI_Click(object sender, EventArgs e)
        {
            LoadReportMRI();
        }

        private void btnReportMFRM_Click(object sender, EventArgs e)
        {
            LoadReportMFRM();
        }

        private void btnReportMAC_Click(object sender, EventArgs e)
        {
            LoadReportMAC();
        }

        private void btnReportMRBF_Click(object sender, EventArgs e)
        {
            LoadReportMRBF();
        }

        private void btnReportMWMR_Click(object sender, EventArgs e)
        {
            LoadReportMWMR();
        }
    }
}
