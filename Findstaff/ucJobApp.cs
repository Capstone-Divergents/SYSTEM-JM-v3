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
                + "and (select count(jl.job_id) from joblist_t jl join on joborder_t j "
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
            cmd = "Select skill_id, proficiency from jobskills_t where jorder_id = '"+cbJobOrder.Text+"' and job_id = (select job_id from job_t where jobname = '"+cbJob.Text+"')";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            {
                y++;
            }
            dr.Close();
            string[,] skills = new string[y,2];
            int z = 0;
            cmd = "Select skill_id, proficiency from jobskills_t where jorder_id = '" + cbJobOrder.Text + "' and job_id = (select job_id from job_t where jobname = '" + cbJob.Text + "')";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
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
            string[,] appskill = new string[y, 3];
            for(int x = 0; x < y; x++)
            {
                int ctr = 0;
                for (int b = 0; b < z; x++)
                {
                    int c = 0;
                    appskill[x, 0] = apps[x, 0];
                    appskill[x, 1] = apps[x, 1];
                    cmd = "select skill_id, proficiency from appskills_t where app_id = '" + appskill[x, 0] + "'";
                    com = new MySqlCommand(cmd, connection);
                    dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        c++;
                    }
                    dr.Close();
                    string[,] skill = new string[c,2];
                    c = 0;
                    cmd = "select skill_id, proficiency from appskills_t where app_id = '" + appskill[x, 0] + "'";
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
                        
                    }
                }
            }
            connection.Close();
        }
    }
}
