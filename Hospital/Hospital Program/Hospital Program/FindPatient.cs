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
    public partial class FindPatient : Form
    {
        // SQL Connection
        private SqlConnection con = SQLCon.GetConnection();

        public FindPatient()
        {
            InitializeComponent();
            FillPatientsOnLoad();
        }

        // SearchBox Focus Event
        private void txtSearchBox_Enter(object sender, EventArgs e)
        {
            txtSearchBox.Text = "";
            txtSearchBox.ForeColor = SystemColors.ControlText;
        }

        // SearchBox Leave Event
        private void txtSearchBox_Leave(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtSearchBox.Text))
            {
                txtSearchBox.Text = "Enter Patient Name";
                txtSearchBox.ForeColor = SystemColors.ScrollBar;
            }
        }

        // Filling Patients on Load
        public void FillPatientsOnLoad()
        {
            dgvPatients.Rows.Clear();
            con.Open();
            string query = "SELECT * FROM Patients";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader r = command.ExecuteReader();
            while (r.Read())
            {
                dgvPatients.Rows.Add(r.GetSqlInt32(0), r.GetString(1), ((DateTime.Now - r.GetDateTime(2)).Days) / 365, r.GetString(3), r.GetString(4));
            }
            con.Close();
        }

        // Search
        public void Search()
        {
            string searchtext;
            if (txtSearchBox.Text != "Enter Patient Name")
            {
                searchtext = txtSearchBox.Text;
                dgvPatients.Rows.Clear();
                con.Open();
                string searchQuery = "SELECT * FROM Patients WHERE Patient LIKE '%" + searchtext + "%'";
                SqlCommand Search = new SqlCommand(searchQuery, con);
                SqlDataReader r = Search.ExecuteReader();
                while (r.Read())
                {
                    dgvPatients.Rows.Add(r.GetSqlInt32(0), r.GetString(1), ((DateTime.Now - r.GetDateTime(2)).Days) / 365, r.GetString(3), r.GetString(4));
                }
                con.Close();
            }
            else
            {
                FillPatientsOnLoad();
            }
        }

        // Search Button
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        // Enter and Esc Keys
        private void FindPatient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FillPatientsOnLoad();
                txtSearchBox.Text = "Enter Patient Name";
                txtSearchBox.ForeColor = SystemColors.ScrollBar;
            }
            else if(e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        // Selected Patient Id
        public int SelectedPatId()
        {
            int PatId = Convert.ToInt32(dgvPatients.CurrentRow.Cells[0].Value.ToString());
            return PatId;
        }

        // Update/Delete Patient
        private void dgvPatients_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UpdDelPatient updp = new UpdDelPatient();
            updp.ShowDialog();
        }
    }
}
