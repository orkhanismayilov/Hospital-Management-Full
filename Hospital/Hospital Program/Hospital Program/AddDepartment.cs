using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital_Program
{
    public partial class AddingDept : Form
    {
        // SQL Connection
        private SqlConnection con = SQLCon.GetConnection();

        public AddingDept()
        {
            InitializeComponent();
        }

        // Adding New Department to Database
        private void btnAddDeptToDatabase_Click(object sender, EventArgs e)
        {
            if (txtNewDeptName.Text != "")
            {
                // Checking Existence
                con.Open();
                int ok = 0;
                string checkDeptQuery = "SELECT Department FROM Departments";
                SqlCommand CheckDeptsCommand = new SqlCommand(checkDeptQuery, con);
                SqlDataReader r = CheckDeptsCommand.ExecuteReader();
                
                while (r.Read())
                {
                    if(r.GetString(0) == txtNewDeptName.Text)
                    {
                        MessageBox.Show("Department " + txtNewDeptName.Text + " is already existing in database.", "Error");
                        return;
                    }
                }
                con.Close();

                // Adding Dept to Database
                con.Open();
                string addDeptQuery = "INSERT INTO Departments ([Department]) VALUES ('" + txtNewDeptName.Text + "')";
                SqlCommand AddDeptCommand = new SqlCommand(addDeptQuery, con);
                ok = AddDeptCommand.ExecuteNonQuery();
                con.Close();

                if(ok == 1)
                {
                    MessageBox.Show("Department " + txtNewDeptName.Text + " successfully added to database.", "Success");
                    this.Close();
                    var MainForm = Application.OpenForms.OfType<MainWindow>().Single();
                    MainForm.FillDepartments();
                }
            }
            else
            {
                MessageBox.Show("Please, enter department name first.", "Error");
            }
        }

        private void btnCancelAddingDept_Click(object sender, EventArgs e)
        {
            this.Close();
            var MainForm = Application.OpenForms.OfType<MainWindow>().Single();
            MainForm.FillDepartments();
        }
    }
}
