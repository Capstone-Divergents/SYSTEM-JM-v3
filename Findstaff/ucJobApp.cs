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
    public partial class ucJobApp : UserControl
    {
        private MySqlConnection connection;
        private MySqlDataReader dr;
        MySqlCommand com = new MySqlCommand();
        private string cmd = "";

        public ucJobApp()
        {
            InitializeComponent();
        }

        private void btnSetForInitInt_Click(object sender, EventArgs e)
        {

        }

        private void ucJobApp_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            if(this.Visible == true)
            {
                connection.Open();
                cmd = "Select employername from employer_t";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cbEmployer.Items.Add(dr[0]);
                }
                dr.Close();
                connection.Close();
            }
            else
            {
                cbEmployer.Items.Clear();
                cbJobOrder.Items.Clear();
                txtJob.Text = "";
            }
        }

        private void cbEmployer_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbJobOrder.Items.Clear();
            txtJob.Text = "";
            connection.Open();
            cmd = "Select j.jorder_id from joborder_t j join employer_t e "
                + "on j.employer_id = e.employer_id "
                + "where j.cntrctstat = 'Active' and e.employername = '"+cbEmployer.Text+"' "
                + "and (select count(job_id) from joborder_t) <> 0 "
                + "group by j.jorder_id";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                cbJobOrder.Items.Add(dr[0]);
            }
            dr.Close();
            connection.Close();
        }

        private void cbJobOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            cmd = "select job.jobname from joborder_t j join job_t job on j.job_id = job.job_id where j.jorder_id = '"+cbJobOrder.Text+"'";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                txtJob.Text = dr[0].ToString();
            }
            dr.Close();
            connection.Close();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            dgvAppMatch.Rows.Clear();
            connection.Open();
            int y = 0;
            cmd = "Select count(*) from jobskills_t where jorder_id = '" + cbJobOrder.Text + "' and job_id = (select job_id from job_t where jobname = '" + txtJob.Text + "')";
            com = new MySqlCommand(cmd, connection);
            y = int.Parse(com.ExecuteScalar() + "");
            string[,] skills = new string[y, 2];
            int z = 0;
            cmd = "Select skill_id, proflevel from jobskills_t where jorder_id = '" + cbJobOrder.Text + "' and job_id = (select job_id from job_t where jobname = '" + txtJob.Text + "')";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                skills[z, 0] = dr[0].ToString();
                skills[z, 1] = dr[1].ToString();
                z++;
            }
            dr.Close();
            y = 0;
            int a = 0;
            cmd = "select count(a.app_id) from app_t a left join applications_t b on a.app_id = b.app_id where (b.appstats is null or b.appstats <> 'Active') and position = '" + txtJob.Text + "'";
            com = new MySqlCommand(cmd, connection);
            y = int.Parse(com.ExecuteScalar() + "");
            if (y != 0)
            {
                string[,] apps = new string[y, 2];
                cmd = "select a.app_id, concat(a.lname, ', ', a.fname, ' ', a.mname) from app_t a left join applications_t b on a.app_id = b.app_id where (b.appstats is null or b.appstats <> 'Active') and position = '" + txtJob.Text + "'";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    apps[a, 0] = dr[0].ToString();
                    apps[a, 1] = dr[1].ToString();
                    a++;
                }
                dr.Close();
                int ctr = 0;
                dgvAppMatch.ColumnCount = 3;
                dgvAppMatch.Columns[0].HeaderText = "Applicant ID";
                dgvAppMatch.Columns[1].HeaderText = "Applicant Name";
                dgvAppMatch.Columns[2].HeaderText = "Satisfactory Rating";
                for (int x = 0; x < y; x++)
                {
                    decimal rate = 0;
                    for (int b = 0; b < z; b++)
                    {
                        int c = 0;
                        cmd = "select skill_id, proficiency from appskills_t where app_id = '" + apps[x, 0] + "'";
                        com = new MySqlCommand(cmd, connection);
                        dr = com.ExecuteReader();
                        while (dr.Read())
                        {
                            c++;
                        }
                        dr.Close();
                        string[,] skill = new string[c, 3];
                        c = 0;
                        cmd = "select skill_id, proficiency from appskills_t where app_id = '" + apps[x, 0] + "'";
                        com = new MySqlCommand(cmd, connection);
                        dr = com.ExecuteReader();
                        while (dr.Read())
                        {
                            skill[c, 0] = dr[0].ToString();
                            skill[c, 1] = dr[1].ToString();
                            c++;
                        }
                        dr.Close();
                        for (int d = 0; d < c; d++)
                        {
                            for (int f = 0; f < z; f++)
                            {
                                if (skill[d, 0] == skills[f, 0])
                                {
                                    if (Convert.ToInt32(skill[d, 1]) >= Convert.ToInt32(skills[f, 1]))
                                    {
                                        ctr++;
                                    }
                                }
                            }
                        }
                    }
                    rate = Convert.ToDecimal(ctr / z) * 100;
                    dgvAppMatch.Rows.Add(apps[x, 0], apps[x, 1], rate);
                    ctr = 0;
                }
                dgvAppMatch.Sort(dgvAppMatch.Columns[2], ListSortDirection.Descending);
            }
            connection.Close();
        }
        
        private void txtLast_Click(object sender, EventArgs e)
        {
            txtLast.Clear();
            txtLast.ForeColor = Color.Black;
        }

        private void txtFirst_Click(object sender, EventArgs e)
        {
            txtFirst.Clear();
            txtFirst.ForeColor = Color.Black;
        }

        private void txtMiddle_Click(object sender, EventArgs e)
        {
            txtMiddle.Clear();
            txtMiddle.ForeColor = Color.Black;
        }

        private void txtLast_TextChanged(object sender, EventArgs e)
        {
            txtLast.ForeColor = Color.Black;
        }

        private void txtFirst_TextChanged(object sender, EventArgs e)
        {
            txtFirst.ForeColor = Color.Black;
        }

        private void txtMiddle_TextChanged(object sender, EventArgs e)
        {
            txtMiddle.ForeColor = Color.Black;
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            dgvJobSuggest.ColumnCount = 3;
            dgvJobSuggest.Columns[0].HeaderText = "Job Order ID";
            dgvJobSuggest.Columns[1].HeaderText = "Job Name";
            dgvJobSuggest.Columns[2].HeaderText = "Satisfactory Rating";
            dgvJobSuggest.Rows.Clear();
            connection.Open();
            string appID = "";
            int skillctr = 0, joctr = 0;
            cmd = "select app_id from app_t where concat (lname, ', ', fname, ' ', mname) = '"+txtLast.Text+", "+txtFirst.Text+" "+txtMiddle.Text+"'";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                appID = dr[0].ToString();
            }
            dr.Close();
            cmd = "Select count(skill_id) from appskills_t where app_id = '"+appID+"'";
            com = new MySqlCommand(cmd, connection);
            skillctr = int.Parse(com.ExecuteScalar() + "");
            string[,] skills = new string[skillctr, 2];
            skillctr = 0;
            cmd = "Select skill_id, proficiency from appskills_t where app_id = '" + appID + "'";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                skills[skillctr, 0] = dr[0].ToString();
                skills[skillctr, 1] = dr[1].ToString();
                skillctr++;
            }
            dr.Close();
            cmd = "Select j.jorder_id from joborder_t j join employer_t e "
                + "on j.employer_id = e.employer_id "
                + "where j.cntrctstat = 'Active' "
                + "and (select count(job_id) from joborder_t ) <> 0 "
                + "group by j.jorder_id";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                joctr++;
            }
            dr.Close();
            string[] jorders = new string[joctr];
            joctr = 0;
            cmd = "Select j.jorder_id from joborder_t j join employer_t e "
                + "on j.employer_id = e.employer_id "
                + "where j.cntrctstat = 'Active' "
                + "and (select count(job_id) from join joborder_t) <> 0 "
                + "group by j.jorder_id";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                jorders[joctr] = dr[0].ToString();
                joctr++;
            }
            dr.Close();
            for (int x = 0; x < joctr; x++)
            {
                int jobctr = 0;
                cmd = "select job_id from joborder_t where jorder_id = '"+jorders[x]+"'";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    jobctr++;
                }
                dr.Close();
                string[] jobs = new string[jobctr];
                jobctr = 0;
                cmd = "select job_id from joborder_t where jorder_id = '" + jorders[x] + "'";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    jobs[jobctr] = dr[0].ToString();
                    jobctr++;
                }
                dr.Close();
                for(int y = 0; y < jobctr; y++)
                {
                    Decimal sat = 0;
                    string jobname = "";
                    cmd = "select jobname from job_t where job_id = '" + jobs[y] + "'";
                    com = new MySqlCommand(cmd, connection);
                    dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        jobname = dr[0].ToString();
                    }
                    dr.Close();
                    int skillsctr = 0;
                    cmd = "select skill_id, proflevel from jobskills_t where jorder_id = '" + jorders[x] + "' and job_id = '" + jobs[y] + "'";
                    com = new MySqlCommand(cmd, connection);
                    dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        skillsctr++;
                    }
                    dr.Close();
                    string[,] jobskill = new string[skillsctr, 2];
                    skillsctr = 0;
                    cmd = "select skill_id, proflevel from jobskills_t where jorder_id = '" + jorders[x] + "' and job_id = '" + jobs[y] + "'";
                    com = new MySqlCommand(cmd, connection);
                    dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        jobskill[skillsctr, 0] = dr[0].ToString();
                        jobskill[skillsctr, 1] = dr[1].ToString();
                        skillsctr++;
                    }
                    dr.Close();
                    int satisfactory = 0;
                    for(int z = 0; z < skillctr; z++)
                    {
                        for(int a = 0; a < skillsctr; a++)
                        {
                            if(skills[z,0] == jobskill[a,0])
                            {
                                if(Convert.ToInt32(skills[z, 1]) > Convert.ToInt32(jobskill[a, 1]) || Convert.ToInt32(skills[z, 1]) == Convert.ToInt32(jobskill[a, 1]))
                                {
                                    satisfactory++;
                                }
                            }
                        }
                    }
                    sat = Convert.ToDecimal(satisfactory / skillsctr) * 100;
                    dgvJobSuggest.Rows.Add(jorders[x], jobname, sat);
                }
            }
            dgvJobSuggest.Sort(dgvJobSuggest.Columns[2], ListSortDirection.Descending);
            connection.Close();
        }

        private void btnAppMatchInt_Click(object sender, EventArgs e)
        {
            if(dgvAppMatch.Rows.Count != 0)
            {
                int length = dgvAppMatch.SelectedRows.Count;
                string[] apps = new string[length];
                string[] job = new string[3];
                job[0] = cbEmployer.Text;
                job[1] = cbJobOrder.Text;
                job[2] = txtJob.Text;
                for (int x = 0; x < length; x++)
                {
                    apps[x] = dgvAppMatch.SelectedRows[x].Cells[0].Value.ToString();
                }
                InitialInterviewDate intdate = new InitialInterviewDate();
                intdate.initComponents(apps, job, length);
                intdate.Show();
            }
        }

        private void btnJobSuggestInt_Click(object sender, EventArgs e)
        {
            if(dgvJobSuggest.Rows.Count != 0)
            {
                string name = txtLast.Text + " " + txtFirst.Text + " " + txtMiddle.Text, appid = "";
                connection.Open();
                cmd = "select app_id from app_t where concat(lname, ' ', fname, ' ', mname) = '"+name+"'";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    appid = dr[0].ToString();
                }
                dr.Close();
                string[] job = new string[3];
                cmd = "select employer_id from joborder_t where jorder_id = '" + dgvJobSuggest.SelectedRows[0].Cells[0].Value.ToString() + "'";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    job[0] = dr[0].ToString();
                }
                job[1] = dgvJobSuggest.SelectedRows[0].Cells[0].Value.ToString();
                cmd = "select job_id from job_t where jobname = '"+ dgvJobSuggest.SelectedRows[0].Cells[1].Value.ToString() + "'";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    job[2] = dr[0].ToString();
                }
                dr.Close();
                connection.Close();
                JobSuggestInt jb = new JobSuggestInt();
                jb.initComponents(appid, job);
                jb.Show();
            }
        }
    }
}
