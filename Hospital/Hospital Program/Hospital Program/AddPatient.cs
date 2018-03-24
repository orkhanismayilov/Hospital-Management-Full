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
    public partial class NewPatient : Form
    {
        // SQL Connection
        private SqlConnection con = SQLCon.GetConnection();

        public NewPatient()
        {
            InitializeComponent();
        }

        // Add Patient to Database
        private void btnAddPatToDatabase_Click(object sender, EventArgs e)
        {
            // Checking Name and Surname TextBoxes
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
            if(cmbPatGender.SelectedIndex != -1)
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

            // Adding Patient to Database
            con.Open();
            string addPatQuery = "INSERT INTO Patients ([Patient],[Birthday],[Gender],[Phone]) VALUES ('" + FullName + "', '" + PatBday + "', '" + PatGender + "', '" + PatPhone + "')";
            SqlCommand command = new SqlCommand(addPatQuery, con);
            int ok = command.ExecuteNonQuery();
            con.Close();

            if(ok == 1)
            {
                MessageBox.Show("Patient " + FullName + " successfully added to database", "Success");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error occured while adding patient to database.", "Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(" Are you sure? All unsaved data will be lost.", "Cancel", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
