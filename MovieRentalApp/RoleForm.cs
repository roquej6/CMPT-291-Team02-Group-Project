namespace MovieRentalApp
{
    public partial class RoleForm : Form
    {
        public RoleForm()
        {
            InitializeComponent();
        }

        private void RoleForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (cboRole.Text == "Employee")
                new MainMenuForm().ShowDialog();
            else if (cboRole.Text == "Customer")
                new CustomerForm().ShowDialog();
            else
                MessageBox.Show("Choose a role first:");
        }
    }
}
