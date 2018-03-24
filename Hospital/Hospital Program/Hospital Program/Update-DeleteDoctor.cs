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
    public partial class UpdDelDoctor : Form
    {
        // SQL Connection
        private SqlConnection con = SQLCon.GetConnection();

        public UpdDelDoctor()
        {
            InitializeComponent();
            FillDepartments();
            GetDocInfo();
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

        // Getting and Filling Doctor Info
        private void GetDocInfo()
        {
            var MainForm = Application.OpenForms.OfType<MainWindow>().Single();
            int DocId = MainForm.GetSelectedDocId();

            con.Open();
            string query = "SELECT * FROM Doctors WHERE Id = " + DocId + "";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader r = command.ExecuteReader();
            while (r.Read())
            {
                // Name and Surname Fill
                string FullName = r.GetString(1);
                var NameSurname = FullName.Split(' ');
                txtDocName.Text = NameSurname[0];
                txtDocSurname.Text = NameSurname[1];

                // Fill WorkDays 
                string WorkDays = r.GetString(3);
                var WorkDaysArray = WorkDays.Split(',');
                foreach (var item in WorkDaysArray)
                {
                    int i = Convert.ToInt32(item) - 1;
                    for (var a = 0; a < clbWorkingDays.Items.Count; a++) 
                    {
                        if (a == i)
                        {
                            clbWorkingDays.SetItemCheckState(a, CheckState.Checked);
                        }
                    }
                }

                // Fill ShiftStart
                DateTime ShiftStartTime = r.GetDateTime(4);
                dtpShiftStart.Value = ShiftStartTime;

                //Fill ShiftEnd
                DateTime ShiftEndTime = r.GetDateTime(5);
                dtpShiftEnd.Value = ShiftEndTime;
            }
            con.Close();

            // Choose the Department of Doctor in ComboBox
            string selected = MainForm.GetSelectedDocDept();
            int selectedIndex = cmbDepts.FindString(selected);
            cmbDepts.SelectedIndex = selectedIndex;
        }

        // Updating Doc Info in Database
        private void btnUpdDoctorInDatabase_Click(object sender, EventArgs e)
        {
            // Checking Name and Surname TextBoxes
            if (txtDocName.Text != "" && txtDocSurname.Text != "")
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
                string query = "SELECT depts.Id FROM Departments depts WHERE depts.Department = '" + cmbDepts.SelectedItem.ToString() + "'";
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

            // Updating Info in Database
            var MainForm = Application.OpenForms.OfType<MainWindow>().Single();
            int DocId = MainForm.GetSelectedDocId();
            string DocFullName = txtDocName.Text + ' ' + txtDocSurname.Text;

            con.Open();
            string updQuery = "UPDATE Doctors SET Doc = '" + DocFullName + "', DeptId = " + DepartmentId + ", Workday = '" + WorkingDays + "', ShiftStart = '" + dtpShiftStart.Value + "', ShiftEnd = '" + dtpShiftEnd.Value + "' WHERE Id = " + DocId + "";
            SqlCommand UpdCommand = new SqlCommand(updQuery, con);
            int updOK = UpdCommand.ExecuteNonQuery();
            con.Close();

            if (updOK == 1)
            {
                MessageBox.Show("Doctor " + DocFullName + " succesfully updated in database.", "Success");
                this.Close();
                MainForm.UpdDoctorsList();
            }
            else
            {
                MessageBox.Show("Error occured while updating doctor info in database.", "Error");
            }
        }

        // Deleting Doc from Database
        private void btnDeleteDocfromDatabase_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("This will delete doctor from database and all procedures info will be corrupted. Are you sure?", "Delete Doctor", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                var MainForm = Application.OpenForms.OfType<MainWindow>().Single();
                int DocId = MainForm.GetSelectedDocId();

                con.Open();
                string delQuery = "DELETE FROM Doctors WHERE Id = " + DocId + "";
                SqlCommand DelCommand = new SqlCommand(delQuery, con);
                int delOK = DelCommand.ExecuteNonQuery();
                con.Close();

                if (delOK == 1)
                {
                    MessageBox.Show("Doctor succesfully deleted from database.", "Success");
                    this.Close();
                    MainForm.UpdDoctorsList();
                }
                else
                {
                    MessageBox.Show("Error occured while deleting doctor from database.", "Error");
                }
            }
        }

        // Cancelling the Operation and Closing the Form
        private void btnCancelUpdDel_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(" Are you sure? All unsaved data will be lost.", "Cancel", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                this.Close();
                var MainForm = Application.OpenForms.OfType<MainWindow>().Single();
                MainForm.UpdDoctorsList();
            }
        }
    }
}
