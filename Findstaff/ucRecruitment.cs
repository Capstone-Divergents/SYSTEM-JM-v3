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
            ucAppList.Dock = DockStyle.Fill;
            ucJobApp.Dock = DockStyle.Fill;
            ucInterviewInit.Dock = DockStyle.Fill;
            ucInterviewFin.Dock = DockStyle.Fill;
        }

        private void rbApplicantList_CheckedChanged(object sender, EventArgs e)
        {
            
            cmd = "select app.app_id'App ID', concat(app.lname, ', ', app.fname, ' ', app.mname)'Applicant Name', job.jobname'Applying for' "
                    + "from app_t app join job_t job "
                    + "on app.position = job.jobname ";
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
        }

        private void rbJobApplicant_CheckedChanged(object sender, EventArgs e)
        {
            ucAppList.Visible = false;
            ucJobApp.Visible = true;
            ucInterviewInit.Visible = false;
            ucInterviewFin.Visible = false;
        }
        
        private void rbInterview_CheckedChanged(object sender, EventArgs e)
        {
            ucAppList.Visible = false;
            ucJobApp.Visible = false;
            ucInterviewInit.Visible = true;
            ucInterviewFin.Visible = false;
        }

        private void rbInterviewFin_CheckedChanged(object sender, EventArgs e)
        {
            ucAppList.Visible = false;
            ucJobApp.Visible = false;
            ucInterviewInit.Visible = false;
            ucInterviewFin.Visible = true;
        }

        private void ucRecruitment_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
        }
    }
}
