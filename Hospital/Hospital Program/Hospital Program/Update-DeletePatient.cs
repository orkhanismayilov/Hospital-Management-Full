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
    public partial class UpdDelPatient : Form
    {
        // SQL Connection
        private SqlConnection con = SQLCon.GetConnection();

        public UpdDelPatient()
        {
            InitializeComponent();
            FillPatInfo();
        }

        // Fill Patient Info
        private void FillPatInfo()
        {
            var SearchForm = Application.OpenForms.OfType<FindPatient>().Single();
            int PatId = SearchForm.SelectedPatId();

            con.Open();
            string query = "SELECT * FROM Patients WHERE Id = " + PatId + "";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader r = command.ExecuteReader();
            while (r.Read())
            {
                string PatFullname = r.GetString(1);
                var PatFullNameArr = PatFullname.Split(' ');
                txtPatName.Text = PatFullNameArr[0];
                txtPatSurname.Text = PatFullNameArr[1];
                txtPatPhone.Text = r.GetString(4);
                cmbPatGender.SelectedItem = r.GetString(3);
                dtpPatBday.Value = r.GetDateTime(2);
            }
            con.Close();
        }

        // Update Patient Info in Database
        private void btnUpdPatInDatabase_Click(object sender, EventArgs e)
        {
            var SearchForm = Application.OpenForms.OfType<FindPatient>().Single();
            int PatId = SearchForm.SelectedPatId();

            // Checking Name and Surname
            string FullName = "";
            if (txtPatName.Text != "" && txtPatSurname.Text != "")
            {
                FullName = txtPatName.Text + " " + txtPatSurname.Text;
            }
            else
            {
                MessageBox.Show("Please, enter the Name and Surname of Patient.", "Error");
                return;
            }

            // Checking Gender ComboBox
            string PatGender = "";
            if (cmbPatGender.SelectedIndex != -1)
            {
                PatGender = cmbPatGender.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Please, choose gender.", " Error");
                return;
            }

            // Birthday
            DateTime PatBday = dtpPatBday.Value;

            // Phone Number
            string PatPhone = txtPatPhone.Text;

            // Updating Patient Info in Database
            con.Open();
            string updPat = "UPDATE Patients SET Patient = '" + FullName + "', Birthday = '" + PatBday + "', Gender = '" + PatGender + "', Phone = '" + PatPhone + "' WHERE Id = " + PatId + "";
            SqlCommand UpdPatInfo = new SqlCommand(updPat, con);
            int ok = UpdPatInfo.ExecuteNonQuery();
            con.Close();

            if(ok == 1)
            {
                MessageBox.Show("Patient " + FullName + " successfully updated in database.", " Success");
                this.Close();
                SearchForm.Search();
            }
            else
            {
                MessageBox.Show("Error occured while updating patient info in database.", "Error");
            }
        }

        // Delete Patient from Database
        private void btnDelPatFromDatabase_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("This will delete patient from database and all procedures info will be corrupted. Are you sure?", "Delete Patient", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                var SearchForm = Application.OpenForms.OfType<FindPatient>().Single();
                int PatId = SearchForm.SelectedPatId();

                con.Open();
                string delPatQuery = "DELETE FROM Patients WHERE Id = " + PatId + "";
                SqlCommand DelPat = new SqlCommand(delPatQuery, con);
                int ok = DelPat.ExecuteNonQuery();
                con.Close();

                if(ok == 1)
                {
                    MessageBox.Show("Patient succesfully deleted from database.", "Success");
                    this.Close();
                    SearchForm.Search();
                }
                else
                {
                    MessageBox.Show("Error occured while deleting patient from database.", "Error");
                }
            }
        }

        // Cancelling the Operation and Closing the Form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(" Are you sure? All unsaved data will be lost.", "Cancel", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                this.Close();
                var SearchForm = Application.OpenForms.OfType<FindPatient>().Single();
                SearchForm.Search();
            }
        }
    }
}
