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
    public partial class ucRecruitment : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        private string cmd = "";

        public ucRecruitment()
        {
            InitializeComponent();
            //ucAppList.Dock = DockStyle.Fill;
            ucJobApp.Dock = DockStyle.Fill;
            ucInterviewInit.Dock = DockStyle.Fill;
            ucInterviewFin.Dock = DockStyle.Fill;
            ucApplicant.Dock = DockStyle.Fill;
            ucDocumentation.Dock = DockStyle.Fill;
        }

        /*private void rbApplicantList_CheckedChanged(object sender, EventArgs e)
        {
            
            cmd = "select app.app_id'App ID', concat(app.lname, ', ', app.fname, ' ', app.mname)'Applicant Name', job.jobname'Applying for', a.appstatus'Under Department' "
                    + "from app_t app join job_t job "
                    + "on app.position = job.jobname "
                    + "left join applications_t a on app.app_id = a.app_id ";
            using (connection)
            {
                using (adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ucAppList.dgvAppList.DataSource = ds.Tables[0];
                }
            }

            ucAppList.Visible = true;
            ucJobApp.Visible = false;
            ucInterviewInit.Visible = false;
            ucInterviewFin.Visible = false;
        }*/

        private void rbJobApplicant_CheckedChanged(object sender, EventArgs e)
        {
            //ucAppList.Visible = false;
            ucJobApp.Visible = true;
            ucInterviewInit.Visible = false;
            ucInterviewFin.Visible = false;
            ucApplicant.Visible = false;
            ucDocumentation.Visible = false;
        }
        
        private void rbInterview_CheckedChanged(object sender, EventArgs e)
        {
            cmd = "Select j.jorder_id'Job Order No.', jb.jobname'Job Name', count(a.appstats)'No. of Interviewees' from joborder_t j "
                + "join job_t jb on j.job_id = jb.job_id join applications_t a "
                + "on a.jorder_id = j.jorder_id and a.job_id = jb.job_id "
                + "where a.appstats = 'Active' and a.initinterviewstatus is null group by j.jorder_id, jb.jobname";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ucInterviewInit.dgvInitInt.DataSource = ds.Tables[0];
                }
            }
            //ucAppList.Visible = false;
            ucJobApp.Visible = false;
            ucInterviewInit.Visible = true;
            ucInterviewFin.Visible = false;
            ucApplicant.Visible = false;
            ucDocumentation.Visible = false;
        }

        private void rbInterviewFin_CheckedChanged(object sender, EventArgs e)
        {
            cmd = "Select j.jorder_id'Job Order No.', jb.jobname'Job Name', count(a.appstats)'No. of Interviewees' from joborder_t j "
                + "join job_t jb on j.job_id = jb.job_id join applications_t a "
                + "on a.jorder_id = j.jorder_id and a.job_id = jb.job_id "
                + "where a.appstats = 'Active' and a.finalinterviewstatus is null and a.initinterviewstatus = 'passed' group by j.jorder_id, jb.jobname";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ucInterviewFin.dgvFinInt.DataSource = ds.Tables[0];
                }
            }
            //ucAppList.Visible = false;
            ucJobApp.Visible = false;
            ucInterviewInit.Visible = false;
            ucInterviewFin.Visible = true;
            ucApplicant.Visible = false;
            ucDocumentation.Visible = false;
        }

        private void rbApplicant_CheckedChanged(object sender, EventArgs e)
        {
            cmd = "select app.app_id'App ID', concat(app.lname, ', ', app.fname, ' ', app.mname)'Applicant Name', job.jobname'Applying for', app.appstatus'Status' "
                    + "from app_t app join job_t job "
                    + "on app.position = job.jobname "
                    + "left join applications_t a on app.app_id = a.app_id ";
            using (connection)
            {
                using (adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ucApplicant.dgvApplicant.DataSource = ds.Tables[0];
                }
            }

            ucJobApp.Visible = false;
            ucInterviewInit.Visible = false;
            ucInterviewFin.Visible = false;
            ucApplicant.Visible = true;
            ucDocumentation.Visible = false;
        }

        private void rbDocu_CheckedChanged(object sender, EventArgs e)
        {
            ucJobApp.Visible = false;
            ucInterviewInit.Visible = false;
            ucInterviewFin.Visible = false;
            ucApplicant.Visible = false;
            ucDocumentation.Visible = true;
        }

        private void ucRecruitment_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
        }
    }
}
