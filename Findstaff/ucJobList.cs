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
            ucJobListAddEdit.lblJOrder.Text = dgvJobList.SelectedRows[0].Cells[0].Value.ToString();
            ucJobListAddEdit.cbJobName2.Text = dgvJobList.SelectedRows[0].Cells[1].Value.ToString();
            ucJobListAddEdit.cbEmployer2.Text = dgvJobList.SelectedRows[0].Cells[2].Value.ToString();
            ucJobListAddEdit.nddEmployees2.Value = Convert.ToInt32(dgvJobList.SelectedRows[0].Cells[3].Value);

            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();
            string cmd = "select employername from employer_t where employername <> '"+ dgvJobList.SelectedRows[0].Cells[2].Value.ToString() +"' ";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                ucJobListAddEdit.cbEmployer2.Items.Add(dr[0].ToString());
            }
            dr.Close();

            cmd = "select reqapp, salary, heightreq, weightreq, gender, monthname(CNTRCTSTART), day(cntrctstart), year(cntrctstart) from joborder_t where jorder_id = '" + dgvJobList.SelectedRows[0].Cells[0].Value.ToString() + "'";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                ucJobListAddEdit.nddEmployees2.Text = dr[0].ToString();
                ucJobListAddEdit.txtSalary2.Text = dr[1].ToString();
                ucJobListAddEdit.txtHeight2.Text = dr[2].ToString();
                ucJobListAddEdit.txtWeight2.Text = dr[3].ToString();
                if(ucJobListAddEdit.rbMale2.Text == dr[4].ToString())
                {
                    ucJobListAddEdit.rbMale2.Checked = true;
                }
                else if (ucJobListAddEdit.rbFemale2.Text == dr[4].ToString())
                {
                    ucJobListAddEdit.rbFemale2.Checked = true;
                }
                else if (ucJobListAddEdit.rbAll2.Text == dr[4].ToString())
                {
                    ucJobListAddEdit.rbAll2.Checked = true;
                }
                ucJobListAddEdit.cbMonth2.Text = dr[5].ToString();
                ucJobListAddEdit.cbDay2.Text = dr[6].ToString();
                ucJobListAddEdit.cbYear2.Text = dr[7].ToString();
            }
            dr.Close();

            cmd = "select jobname from job_t where jobname <> '"+ dgvJobList.SelectedRows[0].Cells[1].Value.ToString() +"'";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                ucJobListAddEdit.cbJobName2.Text = dr[0].ToString();
            }
            dr.Close();

            cmd = "select jc.categoryname from jobcategory_t jc join joborder_t jo on jc.category_id = jo.category_id where jo.jorder_id = '" + dgvJobList.SelectedRows[0].Cells[0].Value.ToString() + "'";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                ucJobListAddEdit.cbCategory2.Text = dr[0].ToString();
            }
            dr.Close();

            cmd = "select g.skillname'Skill Name', js.proflevel'Proficiency Level' from jobskills_t js join genskills_t g on js.skill_id = g.skill_id where js.jorder_id = '" + dgvJobList.SelectedRows[0].Cells[0].Value.ToString() + "'";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ucJobListAddEdit.dgvSkills2.DataSource = ds.Tables[0];
                }
            }

            cmd = "select g.reqname'Requirement Name' from jobdocs_t j join genreqs_t g on j.req_id = g.req_id where j.jorder_id = '" + dgvJobList.SelectedRows[0].Cells[0].Value.ToString() + "'";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ucJobListAddEdit.dgvReqDocs2.DataSource = ds.Tables[0];
                }
            }

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

            cmd = "select jorder_id, reqapp, salary, gender, heightreq, weightreq, CNTRCTSTART from joborder_t where jorder_id = '" + dgvJobList.SelectedRows[0].Cells[0].Value.ToString() + "'";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                ucJobListView.jono.Text = dr[0].ToString();
                ucJobListView.noofempreq.Text = dr[1].ToString();
                ucJobListView.salary.Text = dr[2].ToString();
                ucJobListView.gender.Text = dr[3].ToString();
                ucJobListView.height.Text = dr[4].ToString();
                ucJobListView.weight.Text = dr[5].ToString();
                ucJobListView.contractStart.Text = dr[6].ToString();
            }
            dr.Close();

            cmd = "select j.jobname from job_t j join joborder_t jo on j.job_id = jo.job_id where jorder_id = '" + dgvJobList.SelectedRows[0].Cells[0].Value.ToString() + "'";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                ucJobListView.jobname.Text = dr[0].ToString();
            }
            dr.Close();

            cmd = "select jc.categoryname from jobcategory_t jc join joborder_t jo on jc.category_id = jo.category_id where jorder_id = '" + dgvJobList.SelectedRows[0].Cells[0].Value.ToString() + "'";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                ucJobListView.category.Text = dr[0].ToString();
            }
            dr.Close();

            cmd = "select g.skillname'Skill Name', js.proflevel'Proficiency Level' from jobskills_t js join genskills_t g on js.skill_id = g.skill_id join job_t j on js.job_id = j.job_id where js.jorder_id = '" + dgvJobList.SelectedRows[0].Cells[0].Value.ToString() + "' and j.jobname = '"+ dgvJobList.SelectedRows[0].Cells[1].Value.ToString() + "'";
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

        public void searchData(string valueToFind)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();

            string cmd = "select jo.jorder_id'Job Order ID', j.jobname'Job', e.employername'Employer', jo.reqapp'No. of Required Applicants' " +
                "from joborder_t jo join employer_t e on jo.employer_id = e.employer_id " +
                "join job_t j on jo.job_id = j.job_id where jo.cntrctstat = 'Active' or jo.cntrctstat = 'Renewed' AND concat(jo.jorder_id, j.jobname, e.employername, jo.reqapp) LIKE '%" + valueToFind + "%'";
            com = new MySqlCommand(cmd, connection);
            com.ExecuteNonQuery();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvJobList.DataSource = table;
        }

        private void ucJobListAddEdit_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();
            cmd = "select jo.jorder_id'Job Order ID', j.jobname'Job', e.employername'Employer', jo.reqapp'No. of Required Applicants', jo.cntrctend'End of Contract' " +
                "from joborder_t jo join employer_t e on jo.employer_id = e.employer_id " +
                "join job_t j on jo.job_id = j.job_id where jo.cntrctstat = 'Active' or jo.cntrctstat = 'Renewed';";
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

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            searchData(txtName.Text);
        }

        private void ucJobList_Load(object sender, EventArgs e)
        {
            searchData(txtName.Text);
        }

        private void ucJobListAddEdit_VisibleChanged_1(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();
            cmd = "select jo.jorder_id'Job Order ID', j.jobname'Job', e.employername'Employer', jo.reqapp'No. of Required Applicants', jo.cntrctend'End of Contract' " +
                "from joborder_t jo join employer_t e on jo.employer_id = e.employer_id " +
                "join job_t j on jo.job_id = j.job_id where jo.cntrctstat = 'Active' or jo.cntrctstat = 'Renewed';";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvJobList.DataSource = ds.Tables[0];
                }
            }
        }
    }
}
