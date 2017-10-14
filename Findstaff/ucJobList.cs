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
    public partial class ucJobList : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        private string cmd = "";
        MySqlDataReader dr;

        public ucJobList()
        {
            InitializeComponent();
        }

        private void btnAdvSe_Click(object sender, EventArgs e)
        {
            fAdvSearch fas = new fAdvSearch();
            fas.Show();
        }

        private void btnEmpAdd_Click(object sender, EventArgs e)
        {
            ucJobListAddEdit.Dock = DockStyle.Fill;
            ucJobListAddEdit.Visible = true;
            ucJobListAddEdit.panel1.Visible = true;
            ucJobListAddEdit.panel2.Visible = false;
        }

        private void btnEmpEdit_Click(object sender, EventArgs e)
        {
            ucJobListAddEdit.Dock = DockStyle.Fill;
            ucJobListAddEdit.Visible = true;
            ucJobListAddEdit.panel1.Visible = false;
            ucJobListAddEdit.panel2.Visible = true;
        }

        private void btnEmpDel_Click(object sender, EventArgs e)
        {

        }

        private void btnEmpView_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();
            string cmd = "select employername from employer_t where employername = '" + dgvJobList.SelectedRows[0].Cells[2].Value.ToString() + "'";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                ucJobListView.employer.Text = dr[0].ToString();
            }
            dr.Close();

            cmd = "select reqapp, salary, heightreq, weightreq from joblist_t where jorder_id = '" + dgvJobList.SelectedRows[0].Cells[0].Value.ToString() + "'";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                ucJobListView.noofempreq.Text = dr[0].ToString();
                ucJobListView.salary.Text = dr[1].ToString();
                ucJobListView.height.Text = dr[2].ToString();
                ucJobListView.weight.Text = dr[3].ToString();
            }
            dr.Close();

            cmd = "select j.jobname from job_t j join joblist_t jl on j.job_id = jl.job_id where jorder_id = '" + dgvJobList.SelectedRows[0].Cells[0].Value.ToString() + "'";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                ucJobListView.jobname.Text = dr[0].ToString();
            }
            dr.Close();

            cmd = "select jc.categoryname from jobcategory_t jc join joblist_t jl on jc.category_id = jl.category_id where jorder_id = '" + dgvJobList.SelectedRows[0].Cells[0].Value.ToString() + "'";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                ucJobListView.category.Text = dr[0].ToString();
            }
            dr.Close();

            cmd = "select g.skillname'Skill Name', js.proflevel'Proficiency Level' from jobskills_t js join genskills_t g on js.skill_id = g.skill_id where jorder_id = '" + dgvJobList.SelectedRows[0].Cells[0].Value.ToString() + "'";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ucJobListView.dgvSkills.DataSource = ds.Tables[0];
                }
            }

            cmd = "select g.reqname'Requirement Name' from jobdocs_t j join genreqs_t g on j.req_id = g.req_id where jorder_id = '" + dgvJobList.SelectedRows[0].Cells[0].Value.ToString() + "'";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ucJobListView.dgvRequiredDocs.DataSource = ds.Tables[0];
                }
            }

            ucJobListView.Dock = DockStyle.Fill;
            ucJobListView.Visible = true;
        }

        private void ucJobListAddEdit_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();
            cmd = "select jo.jorder_id'Job Order ID', j.jobname'Job', e.employername'Employer', jl.reqapp'No. of Required Applicants' " +
                "from joborder_t jo join joblist_t jl on jo.JORDER_ID = jl.jorder_id join employer_t e on jo.employer_id = e.employer_id " +
                "join job_t j on jl.job_id = j.job_id where jo.cntrctstat = 'Active' or jo.cntrctstat = 'Renewed';";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvJobList.DataSource = ds.Tables[0];
                }
            }
            connection.Close();
        }
    }
}
