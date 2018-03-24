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
    public partial class ProcedureInfo : Form
    {
        // SQL Connection
        private SqlConnection con = SQLCon.GetConnection();

        public ProcedureInfo()
        {
            InitializeComponent();
            FillProcData();
        }

        // Filling Procedure Info
        public void FillProcData()
        {
            // Getting Procedure Id
            var MainForm = Application.OpenForms.OfType<MainWindow>().Single();
            int ProcId = MainForm.GetClickedProcessId();

            // Filling Data
            con.Open();
            string query = "SELECT proced.Id, Patients.Patient, Doctors.Doc, proced.Time, Types.[Procedure], proced.Price, proced.Note FROM [Procedures] proced " +
                           " INNER JOIN Patients ON proced.PatientId = Patients.Id " +
                           " INNER JOIN Doctors ON proced.DocId = Doctors.Id " +
                           " INNER JOIN Types ON proced.ProcedureId = Types.Id WHERE proced.Id = " + ProcId + "";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader r = command.ExecuteReader();
            while (r.Read())
            {
                txtPatFullname.Text = r.GetString(1);
                txtDocFullname.Text = r.GetString(2);
                txtProc.Text = r.GetString(4);
                txtDate.Text = r.GetDateTime(3).ToString("dd.MM.yyyy [HH:mm]");
                txtPrice.Text = Math.Round(r.GetDecimal(5), 2).ToString() + " AZN";
                rtbNote.Text = r.GetString(6);
            }
            con.Close();

            // Finding & Filling Dept
            con.Open();
            string deptQuery = "SELECT depts.Department FROM Doctors docs INNER JOIN Departments depts ON docs.DeptId = depts.Id WHERE docs.Doc = '" + txtDocFullname.Text + "'";
            SqlCommand FindDept = new SqlCommand(deptQuery, con);
            SqlDataReader Dept = FindDept.ExecuteReader();
            while (Dept.Read())
            {
                txtDept.Text = Dept.GetString(0);
            }
            con.Close();
        }
    }
}