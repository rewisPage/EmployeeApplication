using System;
using System.ComponentModel;
using System.Windows.Forms;
// Importing the required namespace as per instructions
using EmployeeNamespace;

namespace EmployeeApplication
{
    public partial class frmEmployeeDatabase : Form
    {
        // Using BindingList so the DataGridView updates automatically
        private BindingList<Employee> employeeList;

        public frmEmployeeDatabase()
        {
            InitializeComponent();
            employeeList = new BindingList<Employee>();

            // Bind the list to the DataGridView
            dgvEmployeeList.DataSource = employeeList;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Simple validation to ensure fields aren't empty
            if (string.IsNullOrWhiteSpace(txtEmployeeID.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtPosition.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Using the parameterized overloaded constructor and 'new' operator
            Employee newEmployee = new Employee(
                txtEmployeeID.Text,
                txtFirstName.Text,
                txtLastName.Text,
                txtPosition.Text
            );

            // Add to list (DataGridView updates automatically)
            employeeList.Add(newEmployee);

            // Clear textboxes for the next entry
            txtEmployeeID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPosition.Clear();

            // Set focus back to the first text box
            txtEmployeeID.Focus();
        }
    }
}