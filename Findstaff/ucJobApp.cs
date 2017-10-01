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
            }
        }

        private void cbEmployer_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            cmd = "Select j.jorder_id from joborder_t j join employer_t e "
                + "on j.employer_id = e.employer_id "
                + "join joblist_t jl on j.jorder_id = jl.jorder_id "
                + "where j.cntrctstat = 'Active' and e.employername = '"+cbEmployer.Text+"' "
                + "and (select count(jl.job_id) from joblist_t jl join joborder_t j "
                + "on j.jorder_id = jl.jorder_id) <> 0";
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
            cmd = "select job.jobname from joblist_t j join job_t job on j.job_id = job.job_id where j.jorder_id = '"+cbJobOrder.Text+"'";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                cbJob.Items.Add(dr[0].ToString());
            }
            dr.Close();
            connection.Close();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            connection.Open();
            int y = 0;
            cmd = "Select skill_id, proflevel from jobskills_t where jorder_id = '"+cbJobOrder.Text+"' and job_id = (select job_id from job_t where jobname = '"+cbJob.Text+"')";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            {
                y++;
            }
            dr.Close();
            string[,] skills = new string[y,3];
            int z = 0;
            cmd = "Select skill_id, proflevel from jobskills_t where jorder_id = '" + cbJobOrder.Text + "' and job_id = (select job_id from job_t where jobname = '" + cbJob.Text + "')";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while(dr.Read())
            {
                skills[z, 0] = dr[0].ToString();
                skills[z, 1] = dr[1].ToString();
                z++;
            }
            dr.Close();
            y = 0;
            int a = 0;
            cmd = "select app_id from app_t where position = '" + cbJob.Text + "'";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                y++;
            }
            dr.Close();
            string[,] apps = new string[y, 2];
            cmd = "select app_id, concat(lname, ' ', fname, ' ', mname) from app_t where position = '" + cbJob.Text + "'";
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
                    string[,] skill = new string[c,3];
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
                    for(int d = 0; d < c; d++)
                    {
                        for(int f = 0; f < z; f++)
                        {
                            if(skill[d,0] == skills[f, 0] && skills[f, 2] != "1")
                            {
                                if(skill[d, 1] == skills[f, 1] || Convert.ToInt32(skill[d, 1]) > Convert.ToInt32(skills[f, 1]))
                                {
                                    ctr++;
                                    skills[f, 2] = "1";
                                    break;
                                }
                            }
                        }
                        for(int g = 0; g < z; g++)
                        {
                            skill[g, 2] = "0";
                        }
                        rate = Convert.ToDecimal(ctr / z) * 100;
                        ctr = 0;
                    }
                }
                dgvAppMatch.Rows.Add(apps[x, 0], apps[x, 1], rate);
            }
            dgvAppMatch.Sort(dgvAppMatch.Columns[2], ListSortDirection.Descending);
            connection.Close();
        }
    }
}
