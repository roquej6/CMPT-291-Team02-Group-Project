using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            "select m.movie_id as ID, m.title as Title, m.genre as Genre, m.available as Available from movie as m " +
            "where m.title like @title and (@type = '' or m.genre = @type) order by m.movie_id;",
            Db.P("@title", SqlDbType.VarChar, 50,
            "%" + txtTitle.Text.Trim() + "%"),
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
            "UNION ALL SELECT distinct genre, genre FROM movie " +
            "ORDER BY genre");
            //cboNewDept.DisplayMember = "dept_name";
            //cboNewDept.ValueMember = "dept_name";
            //cboNewDept.DataSource = Db.Query(
            //"SELECT dept_name FROM department ORDER BY dept_name");
            LoadMovies();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string genre = cboType.Text.Trim();
            string title = txtTitle.Text.Trim();
            string movie_id = txtID.Text.Trim();
            string temp_available = cboAvailable.Text.Trim();
            int available;

            if (temp_available == "Yes")
            {
                available = 1;
            }
            else if (temp_available == "No")
            {
                available = 0;
            }
            else
            {
                MessageBox.Show("Select an availability from the combo box.");
                return;
            }

            // 1. Validate in C# first: friendly, and no trip to the server.
            if (movie_id == "" || movie_id.Length > 5)
            {
                MessageBox.Show("Enter ID of up to 5 characters.");
                return;
            }
            if (title == "" || title.Length > 50)
            {
                MessageBox.Show("Enter title of up to 50 characters.");
                return;
            }
            if (!(genre == "Comedy" || genre  == "Drama" || genre == "Action" || genre == "Foreign"))
            {
                MessageBox.Show("Enter one of the following movie types: Comedy, Drama, Action or Foreign");
                return;
            }
            // 2. Send the INSERT with parameters; the database has the final say.
            try
            {
                Db.Execute(
                "INSERT INTO movie (movie_id, title, genre, available) " +
                "VALUES (@movie_id, @title, @genre, @available)",
                Db.P("@movie_id", SqlDbType.VarChar, 5, movie_id),
                Db.P("@title", SqlDbType.VarChar, 50, title),
                Db.P("@genre", SqlDbType.VarChar, 15, genre),
                Db.P("@available", SqlDbType.Int, 0, available));
                MessageBox.Show($"Added {title} ({movie_id}).");
                LoadMovies(); // 3. Refresh the grid.
            }
            catch (SqlException ex) when (ex.Number is 2627 or 2601)
            {
                MessageBox.Show($"A movie with ID {movie_id} already exists.");
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                MessageBox.Show("The database rejected something.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string genre = cboType.Text.Trim();
            string title = txtTitle.Text.Trim();
            string movie_id = txtID.Text.Trim();
            string temp_available = cboAvailable.Text.Trim();
            int available;

            if (temp_available == "Yes")
            {
                available = 1;
            }
            else if (temp_available == "No")
            {
                available = 0;
            }
            else
            {
                MessageBox.Show("Select an availability from the combo box.");
                return;
            }


            // 1. Validate in C# first: friendly, and no trip to the server.
            if (movie_id == "" || movie_id.Length > 5)
            {
                MessageBox.Show("Enter ID of up to 5 characters.");
                return;
            }
            if (title == "" || title.Length > 50)
            {
                MessageBox.Show("Enter title of up to 50 characters.");
                return;
            }
            if (!(genre == "Comedy" || genre == "Drama" || genre == "Action" || genre == "Foreign"))
            {
                MessageBox.Show("Select a genre from the combo box.");
                return;
            }
            // 2. Send the INSERT with parameters; the database has the final say.
            try
            {
                Db.Execute(@"
                update movie set title = @title, available = @available, genre = @genre where @movie_id = movie_id;

                IF @@ROWCOUNT = 0
                    THROW 50174,'Cannot update: Movie of inputted info is not within database.',1; ",

                Db.P("@movie_id", SqlDbType.VarChar, 5, movie_id),
                Db.P("@title", SqlDbType.VarChar, 50, title),
                Db.P("@genre", SqlDbType.VarChar, 15, genre),
                Db.P("@available", SqlDbType.Int, 0, available));
                MessageBox.Show($"Updated {title} ({movie_id}).");
                LoadMovies(); // 3. Refresh the grid.
            }
            catch (SqlException ex) when (ex.Number is 2627 or 2601)
            {
                MessageBox.Show($"A customer with ID {movie_id} already exists.");
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                MessageBox.Show("The database rejected something.");
            }
            catch (SqlException ex) when (ex.Number == 50174)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
    }
}
