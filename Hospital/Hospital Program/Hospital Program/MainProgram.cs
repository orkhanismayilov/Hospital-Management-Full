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
    public partial class MainWindow : Form
    {
        // SQL Connection
        private SqlConnection con = SQLCon.GetConnection();
            
        public MainWindow()
        {
            InitializeComponent();
            FillDepartments();
        }

        // Filling Departments ComboBox
        public void FillDepartments()
        {
            cmbDepts.Items.Clear();
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

        // Filling Doctors List by Department Selected
        private void cmbDepts_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvDoctors.Rows.Clear();
            string deptName = cmbDepts.SelectedItem.ToString();
            con.Open();
            string query = "SELECT * FROM Doctors docs INNER JOIN Departments depts ON docs.DeptId = depts.Id WHERE depts.Department = '" + deptName + "'";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader r = command.ExecuteReader();
            while (r.Read())
            {
                dgvDoctors.Rows.Add(r.GetSqlInt32(0), r.GetString(1), r.GetString(3), r.GetDateTime(4).ToString("HH:mm"), r.GetDateTime(5).ToString("HH:mm"));
            }
            con.Close();
        }

        // Opening AddDoc Form
        private void btnAddDoc_Click(object sender, EventArgs e)
        {
            AddDocWindow adcw = new AddDocWindow();
            adcw.ShowDialog();
        }

        // Opening Edit/Delete Form
        private void btnEditDel_Click(object sender, EventArgs e)
        {
            if (dgvDoctors.Rows.Count !=0)
            {
                UpdDelDoctor upd = new UpdDelDoctor();
                upd.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please, select doctor first.", "Error");
                return;
            }
        }

        // Updating Doctors List after Update and Delete Form Closed
        public void UpdDoctorsList()
        {
            dgvDoctors.Rows.Clear();
            string deptName = cmbDepts.SelectedItem.ToString();
            con.Open();
            string query = "SELECT * FROM Doctors docs INNER JOIN Departments depts ON docs.DeptId = depts.Id WHERE depts.Department = '" + deptName + "'";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader r = command.ExecuteReader();
            while (r.Read())
            {
                dgvDoctors.Rows.Add(r.GetSqlInt32(0), r.GetString(1), r.GetString(3), r.GetDateTime(4).ToString("HH:mm"), r.GetDateTime(5).ToString("HH:mm"));
            }
            con.Close();
        }

        // Getting Selected Docs Id
        public int GetSelectedDocId()
        {
            int DocId = Convert.ToInt32(dgvDoctors.CurrentRow.Cells[0].Value.ToString());
            return DocId;
        }

        // Getting Selected Docs Dept
        public string GetSelectedDocDept()
        {
            string selected = cmbDepts.SelectedItem.ToString();
            return selected;
        }

        // Filling Procedures by Selected Doc
        private void dgvDoctors_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvProcesses.Rows.Clear();
            con.Open();
            string query = "SELECT proced.Id, Patients.Patient, Doctors.Doc, proced.Time, Types.[Procedure], proced.Price, proced.Note FROM [Procedures] proced " +
                           " INNER JOIN Patients ON proced.PatientId = Patients.Id " +
                           " INNER JOIN Doctors ON proced.DocId = Doctors.Id " +
                           " INNER JOIN Types ON proced.ProcedureId = Types.Id WHERE DocId = " + dgvDoctors.CurrentRow.Cells[0].Value + "";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader r = command.ExecuteReader();
            while (r.Read())
            {
                dgvProcesses.Rows.Add(r.GetInt32(0), r.GetString(1), r.GetString(4), r.GetDateTime(3).ToString("dd.MM.yyyy [HH:mm]"), Math.Round(r.GetDecimal(5), 2) + " AZN");
            }
            con.Close();
        }

        // Add Department
        private void btnAddDept_Click(object sender, EventArgs e)
        {
            AddingDept addDept = new AddingDept();
            addDept.ShowDialog();
        }

        // Add Patient
        private void btnNewPatient_Click(object sender, EventArgs e)
        {
            NewPatient npt = new NewPatient();
            npt.ShowDialog();
        }

        // Add Procedure
        private void btnNewProc_Click(object sender, EventArgs e)
        {
            NewProcedure npc = new NewProcedure();
            npc.ShowDialog();
        }

        // View Procedure Details
        private void dgvProcesses_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ProcedureInfo procinfo = new ProcedureInfo();
            procinfo.ShowDialog();
        }

        // Getting Clicked Process
        public int GetClickedProcessId()
        {
            int ProcId = Convert.ToInt32(dgvProcesses.CurrentRow.Cells[0].Value);
            return ProcId;
        }

        // Find Patient
        private void btnFindPatient_Click(object sender, EventArgs e)
        {
            FindPatient fndp = new FindPatient();
            fndp.ShowDialog();
        }
    }
}