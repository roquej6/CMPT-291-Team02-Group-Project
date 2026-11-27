using Microsoft.Data.SqlClient;
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
    public partial class MovieForm : Form
    {
        public MovieForm()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                object n = Db.Scalar("SELECT COUNT(*) FROM movie");
                MessageBox.Show($"Connected. The movie table has {n} rows.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Could not connect: " + ex.Message);
            }

        }

        private void LoadMovies()
        {
            //dgvMovies.DataSource = Db.Query(
            //"SELECT student_id, name AS Name, dept_name AS Department, " +
            //" tot_cred AS Credits " +
            //"FROM student " +
            //"WHERE name LIKE @pattern AND (@dept = '' OR dept_name = @dept) " +
            //"ORDER BY name",
            //Db.P("@pattern", SqlDbType.VarChar, 22,
            //"%" + txtSearch.Text.Trim() + "%"),
            //Db.P("@dept", SqlDbType.VarChar, 20,
            //cboDept.SelectedValue ?? ""));
            dgvMovies.DataSource = Db.Query(
            "select m.title as Title, mg.genre as Genre, m.available as Available from movie as m join movie_genres as mg on m.movie_id = mg.movie_id " +
            "where m.title like @title and (@type = '' or mg.genre = @type) order by m.available DESC, mg.genre, m.title;",
            Db.P("@title", SqlDbType.VarChar, 50,
            "%" + txtSearch.Text.Trim() + "%"),
            Db.P("@type", SqlDbType.VarChar, 15,
            cboType.SelectedValue ?? ""));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadMovies();
        }

        private void MovieForm_Load(object sender, EventArgs e)
        {
            // Drop-down: show a label, keep the key.
            // The first row means "no filter".
            cboType.DisplayMember = "label";
            cboType.ValueMember = "genre";
            cboType.DataSource = Db.Query(
            "SELECT '' AS genre, '(All types)' AS label " +
            "UNION ALL SELECT distinct genre, genre FROM movie_genres " +
            "ORDER BY genre");
            //cboNewDept.DisplayMember = "dept_name";
            //cboNewDept.ValueMember = "dept_name";
            //cboNewDept.DataSource = Db.Query(
            //"SELECT dept_name FROM department ORDER BY dept_name");
            LoadMovies();

        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
