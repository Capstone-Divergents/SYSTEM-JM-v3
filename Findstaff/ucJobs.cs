using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Findstaff
{
    public partial class ucJobs : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();

        public ucJobs()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ucJobsAddEdit.Dock = DockStyle.Fill;
            ucJobsAddEdit.Visible = true;
            ucJobsAddEdit.panel1.Visible = true;
            ucJobsAddEdit.panel2.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvJobs.Rows.Count != 0)
            {
                ucJobsAddEdit.Dock = DockStyle.Fill;
                ucJobsAddEdit.txtID.Text = dgvJobs.SelectedRows[0].Cells[0].Value.ToString();
                ucJobsAddEdit.txtJobs2.Text = dgvJobs.SelectedRows[0].Cells[1].Value.ToString();
                ucJobsAddEdit.Visible = true;
                ucJobsAddEdit.panel1.Visible = false;
                ucJobsAddEdit.panel2.Visible = true;
                ucJobsAddEdit.cbCategory1.Text = dgvJobs.SelectedRows[0].Cells[2].Value.ToString();
            }
            else
            {
                MessageBox.Show("No record available for edit.", "No Existing Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();
            string cmd = "delete from job_t where job_id = '" + dgvJobs.SelectedRows[0].Cells[0].Value.ToString() + "';";
            com = new MySqlCommand(cmd, connection);
            com.ExecuteNonQuery();
            dgvJobs.Rows.Remove(dgvJobs.SelectedRows[0]);
            MessageBox.Show("Job Deleted!", "Job Record Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
        }

        private void ucJobsAddEdit_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            string com = "select j.job_id'Job ID', j.Jobname'Job Name', c.categoryname'Category', j.jobtype'Type of Job' from jobcategory_t c join job_t j on c.category_id = j.category_id";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(com, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvJobs.DataSource = ds.Tables[0];
                }
            }
        }
    }
}
