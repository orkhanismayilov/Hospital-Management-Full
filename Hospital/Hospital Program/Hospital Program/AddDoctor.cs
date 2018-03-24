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
    public partial class AddDocWindow : Form
    {
        // SQL Connection
        private SqlConnection con = SQLCon.GetConnection();

        public AddDocWindow()
        {
            InitializeComponent();
            FillDepartments();
        }

        // Filling Departments ComboBox
        private void FillDepartments()
        {
            con.Open();
            string query = "SELECT depts.Department FROM Departments depts";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader r = command.ExecuteReader();
            while (r.Read())
            {
                cmbDepts.Items.Add(r.GetString(0));
            }
            con.Close();
        }

        // Adding Doctor to Database
        private void btnAddDoctorToDatabase_Click(object sender, EventArgs e)
        {
            // Checking Name and Surname TextBoxes
            if(txtDocName.Text != "" && txtDocSurname.Text != "")
            {
                string FullName = txtDocName.Text + " " + txtDocSurname.Text;
            }
            else
            {
                MessageBox.Show("Please, enter the Name and Surname of Doctor.", "Error");
                return;
            }

            // Checking Working Days Selected
            string WorkingDays = "";
            if (clbWorkingDays.CheckedItems.Count != 0)
            {
                List<string> days = new List<string>();
                foreach (var item in clbWorkingDays.CheckedItems)
                {
                    days.Add(item.ToString());
                }
                WorkingDays = String.Join(",", days);
            }
            else
            {
                MessageBox.Show("Please, choose working days.", "Error");
                return;
            }

            // Checking Department Selected
            int DepartmentId = 0;
            if (cmbDepts.SelectedIndex != -1)
            {
                con.Open();
                string query = "SELECT depts.Id FROM Departments depts WHERE depts.Department = '"+ cmbDepts.SelectedItem.ToString() + "'";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader r = command.ExecuteReader();
                while (r.Read())
                {
                    DepartmentId = r.GetInt32(0);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please, choose department.", "Error");
                return;
            }

            // Adding Doc to Database
            string DocFullName = txtDocName.Text + ' ' + txtDocSurname.Text;
            con.Open();
            string AddQuery = "INSERT INTO Doctors ([Doc], [DeptId], [Workday], [ShiftStart], [ShiftEnd]) VALUES ('"+ DocFullName + "', "+ DepartmentId + ", '"+ WorkingDays + "', '"+ dtpShiftStart.Value + "', '"+ dtpShiftEnd.Value + "')";
            SqlCommand AddCommand = new SqlCommand(AddQuery, con);
            int ok = AddCommand.ExecuteNonQuery();
            con.Close();

            if (ok == 1)
            {
                MessageBox.Show("Doctor " + DocFullName + " succesfully added to database.", "Success");
                this.Close();
                var MainForm = Application.OpenForms.OfType<MainWindow>().Single();
                MainForm.UpdDoctorsList();
            }
            else
            {
                MessageBox.Show("Error occured while adding doctor to database.", "Error");
            }
        }

        // Cancelling the Operation and Closing the Form
        private void btnCancelAddingDoc_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(" Are you sure? All unsaved data will be lost.", "Cancel", MessageBoxButtons.OKCancel);
            if(r == DialogResult.OK)
            {
                this.Close();
                var MainForm = Application.OpenForms.OfType<MainWindow>().Single();
                MainForm.UpdDoctorsList();
            }
        }
    }
}
