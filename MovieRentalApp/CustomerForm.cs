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
using System.Xml.Linq;

namespace MovieRentalApp
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadCustomers()
        {
            dgvCustomerList.DataSource = Db.Query(
            "SELECT customer_id, name AS Name, email AS Email, " +
            " age AS Age " +
            "FROM customer " +
            "WHERE name LIKE @name AND (@ID LIKE '' OR customer_id LIKE @ID) " +
            "ORDER BY name",
            Db.P("@name", SqlDbType.VarChar, 22,
            "%" + txtSearchName.Text.Trim() + "%"),
            Db.P("@ID", SqlDbType.VarChar, 20,
            "%" + txtSearchID.Text.Trim() + "%"));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string id = txtCreateID.Text.Trim();
            string name = txtCreateName.Text.Trim();
            string email = txtEmail.Text.Trim();
            int age = int.TryParse(txtAge.Text.Trim(), out int ageValue) ? ageValue : -1;

            // 1. Validate in C# first: friendly, and no trip to the server.
            if (id.Length != 5) 
            {
                MessageBox.Show("Enter a 5-character ID.");
                return;
            }
            if (name == "" || name.Length >50)
            {
                MessageBox.Show("Enter name of up to 50 characters.");
                return;
            }
            if (age < 0 || age > 99)
            {
                MessageBox.Show("Age must be a whole number from 0 to 99.");
                return;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Enter an email address.");
                return;
            }
            // 2. Send the INSERT with parameters; the database has the final say.
            try
            {
                Db.Execute(
                "INSERT INTO customer (customer_id, name, email, age, account_active) " +
                "VALUES (@id, @name, @email, @age, @active)",
                Db.P("@id", SqlDbType.VarChar, 5, id),
                Db.P("@name", SqlDbType.VarChar, 50, name),
                Db.P("@email", SqlDbType.VarChar, 100, email),
                Db.P("@age", SqlDbType.Int, 0, age),
                Db.P("@active", SqlDbType.Int, 0, 1));
                MessageBox.Show($"Added {name} ({id}).");
                LoadCustomers(); // 3. Refresh the grid.
            }
            catch (SqlException ex) when (ex.Number is 2627 or 2601)
            {
                MessageBox.Show($"A customer with ID {id} already exists.");
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                MessageBox.Show("The database rejected the email.");
            }
        }
    }
}
