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
    public partial class NewProcedure : Form
    {
        // SQL Connection
        private SqlConnection con = SQLCon.GetConnection();

        public NewProcedure()
        {
            InitializeComponent();
            FillPatients();
            FillDocs();
            FillTypes();
            dtpProcedureDate.Value = DateTime.Now;
        }

        // Filling Patients ComboBox
        private void FillPatients()
        {
            con.Open();
            string query = "SELECT Patient FROM Patients";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader r = command.ExecuteReader();
            while (r.Read())
            {
                cmbPatients.Items.Add(r.GetString(0));
            }
            con.Close();
        }

        // Filling Docs ComboBox
        private void FillDocs()
        {
            con.Open();
            string query = "SELECT Doc FROM Doctors";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader r = command.ExecuteReader();
            while (r.Read())
            {
                cmbDocs.Items.Add(r.GetString(0));
            }
            con.Close();
        }

        // Filling Procedure Types ComboBox
        private void FillTypes()
        {
            con.Open();
            string query = "SELECT [Procedure] FROM [Types]";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader r = command.ExecuteReader();
            while (r.Read())
            {
                cmbTypes.Items.Add(r.GetString(0));
            }
            con.Close();
        }

        // Forcing Price TextBox
        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            double a = 0;
            if (!double.TryParse(txtPrice.Text, out a))
            {
                txtPrice.Text = "";
            }
        }

        // Add Procedure
        private void btnAddProcedureToDatabase_Click(object sender, EventArgs e)
        {
            // Checking Selected Patient
            int PatId = 0;
            if(cmbPatients.SelectedIndex != -1)
            {
                con.Open();
                string PatIdQuery = "SELECT Id FROM Patients WHERE Patient = '" + cmbPatients.SelectedItem.ToString() + "'";
                SqlCommand PatIdFind = new SqlCommand(PatIdQuery, con);
                SqlDataReader r = PatIdFind.ExecuteReader();
                while (r.Read())
                {
                    PatId = r.GetInt32(0);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please, choose a patient.", "Error");
                return;
            }

            // Checking Selected Doc
            int DocId = 0;
            if(cmbDocs.SelectedIndex != -1)
            {
                con.Open();
                string DocIdQuery = "SELECT Id FROM Doctors WHERE Doc = '" + cmbDocs.SelectedItem.ToString() + "'";
                SqlCommand DocIdFind = new SqlCommand(DocIdQuery, con);
                SqlDataReader r = DocIdFind.ExecuteReader();
                while (r.Read())
                {
                    DocId = r.GetInt32(0);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please, choose a doctor.", "Error");
                return;
            }

            // Checking Procedure Type
            int ProcId = 0;
            if(cmbTypes.SelectedIndex != -1)
            {
                con.Open();
                string ProcIdQuery = "SELECT Id FROM [Types] WHERE [Procedure] = '" + cmbTypes.SelectedItem.ToString() + "'";
                SqlCommand ProcIdFind = new SqlCommand(ProcIdQuery, con);
                SqlDataReader r = ProcIdFind.ExecuteReader();
                while (r.Read())
                {
                    ProcId = r.GetInt32(0);
                }
                con.Close();
            }

            // Checking if Doctor is Available at Selected Date & Time
            int available = 0;
            int DayNr = (int)dtpProcedureDate.Value.DayOfWeek;
            if(dtpProcedureDate.Value > DateTime.Now)
            {
                con.Open();
                string GetWorkingDaysOfDoc = "SELECT Workday, ShiftStart, ShiftEnd FROM Doctors WHERE Doc = '" + cmbDocs.SelectedItem.ToString() + "'";
                SqlCommand gwdCommand = new SqlCommand(GetWorkingDaysOfDoc, con);
                SqlDataReader r = gwdCommand.ExecuteReader();
                while (r.Read())
                {
                    string WorkingDays = r.GetString(0);
                    DateTime ShiftStart = r.GetDateTime(1);
                    DateTime ShiftEnd = r.GetDateTime(2);
                    if ((WorkingDays.Contains(DayNr.ToString())) && (dtpProcedureDate.Value.TimeOfDay > ShiftStart.TimeOfDay) && (dtpProcedureDate.Value.TimeOfDay < ShiftEnd.TimeOfDay))
                    {
                        available = 1;
                    }
                    else
                    {
                        available = 0;
                    }
                }
                con.Close();

                if (available == 0)
                {
                    MessageBox.Show("Doctor " + cmbDocs.SelectedItem.ToString() + " is not available at this date. Please, choose another doctor.", "Warning");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please, choose newer date.", "Error");
                return;
            }

            // Checking Price
            double Price = 0;
            if(txtPrice.Text != "")
            {
                Price = Convert.ToDouble(txtPrice.Text);
            }
            else
            {
                MessageBox.Show("Please, enter the price of procedure.", "Warning");
                return;
            }
                
            // Adding Procedure to Databse
            con.Open();
            string addProcQuery = "INSERT INTO [Procedures] ([PatientId], [DocId], [Time], [ProcedureId], [Price], [Note]) VALUES (" + PatId + ", " + DocId + ", '" + dtpProcedureDate.Value + "', " + ProcId + ", " + Price + ", '" + rtbNote.Text + "')";
            SqlCommand AddProcCommand = new SqlCommand(addProcQuery, con);
            int ok = AddProcCommand.ExecuteNonQuery();
            con.Close();

            if(ok == 1)
            {
                MessageBox.Show("Procedure successfully added to database.", "Success");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error occured while adding procedure to database.", "Error");
            }
        }
    }
}
