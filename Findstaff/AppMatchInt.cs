using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Findstaff
{
    public partial class InitialInterviewDate : Form
    {
        private MySqlCommand com;
        private MySqlConnection connection;
        private string cmd = "";
        private MySqlDataReader dr;
        private string[] apps;
        private string[] details = new string[3];
        private int len = 0;

        public InitialInterviewDate()
        {
            InitializeComponent();
        }

        private void InitialInterviewDate_Load(object sender, EventArgs e)
        {
            Connection con = new Findstaff.Connection();
            connection = con.dbConnection();
            for (int x = DateTime.Now.Year + 10; x >= DateTime.Now.Year; x--)
            {
                cbYear.Items.Add(x);
                if(cbYear.Items.Count == 11)
                {
                    break;
                }
            }
        }

        public void initComponents(String[] applicants, String[] jorderinfo, int length)
        {
            apps = new string[length];
            for (int x = 0; x < length; x++)
            {
                apps[x] = applicants[x];
            }
            details[0] = jorderinfo[0];
            details[1] = jorderinfo[1];
            details[2] = jorderinfo[2];
            len = length;
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDay.Items.Clear();
            if(cbMonth.SelectedIndex == 0 || cbMonth.SelectedIndex == 2 || cbMonth.SelectedIndex == 4 || cbMonth.SelectedIndex == 6 ||
                cbMonth.SelectedIndex == 7 || cbMonth.SelectedIndex == 9 || cbMonth.SelectedIndex == 11)
            {
                for(int x = 1; x <=31; x++)
                {
                    cbDay.Items.Add(x);
                }
            }
            else if (cbMonth.SelectedIndex == 3 || cbMonth.SelectedIndex == 5 || cbMonth.SelectedIndex == 8 || cbMonth.SelectedIndex == 10)
            {
                for (int x = 1; x <= 30; x++)
                {
                    cbDay.Items.Add(x);
                }
            }
            else
            {
                for (int x = 1; x <= 28; x++)
                {
                    cbDay.Items.Add(x);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            connection.Open();
            if (cbMonth.Text != "" && cbDay.Text != "" && cbYear.Text != "")
            {
                string jorder = "", empId = "", jobId = "", jobcateg = "";
                cmd = "Select jo.jorder_id, jo.employer_id, jo.job_id, jc.category_id from joborder_t jo"
                    + " join job_t j "
                    + "on jo.job_id = j.job_id join jobcategory_t jc "
                    + "on jo.category_id = jc.category_id join employer_t e "
                    + "on jo.employer_id = e.employer_id "
                    + "where jo.jorder_id = '" + details[1] + "' and e.employername = '" + details[0] + "' "
                    + "and j.jobname = '" + details[2] + "'";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    jorder = dr[0].ToString();
                    empId = dr[1].ToString();
                    jobId = dr[2].ToString();
                    jobcateg = dr[3].ToString();
                }
                dr.Close();
                for (int x = 0; x < len; x++)
                {
                    int ctr = 0;
                    string appNo = "";
                    string cou = "select count(*) from applications_t;";
                    com = new MySqlCommand(cou, connection);
                    ctr = int.Parse(com.ExecuteScalar() + "");
                    if ((ctr + "").Length == 1)
                    {
                        appNo = "A00000000" + ctr + "";
                    }
                    else if ((ctr + "").Length == 2)
                    {
                        appNo = "A0000000" + ctr + "";
                    }
                    else if ((ctr + "").Length == 3)
                    {
                        appNo = "A000000" + ctr + "";
                    }
                    else if ((ctr + "").Length == 4)
                    {
                        appNo = "A00000" + ctr + "";
                    }
                    else if ((ctr + "").Length == 5)
                    {
                        appNo = "A0000" + ctr + "";
                    }
                    else if ((ctr + "").Length == 6)
                    {
                        appNo = "A000" + ctr + "";
                    }
                    else if ((ctr + "").Length == 7)
                    {
                        appNo = "A00" + ctr + "";
                    }
                    else if ((ctr + "").Length == 8)
                    {
                        appNo = "A0" + ctr + "";
                    }
                    else if ((ctr + "").Length == 9)
                    {
                        appNo = "A" + ctr + "";
                    }
                    else
                    {
                        MessageBox.Show("Table in the database will not be able to handle more records.", "Full Application Records");
                    }
                    if (appNo != "")
                    {
                        cmd = "insert into applications_t (app_no, app_id, jorder_id, employer_id, category_id, job_id, initinterviewdate, appstats) "
                            + "values ('" + appNo + "','" + apps[x] + "','" + details[1] + "','" + empId + "','" + jobcateg + "','" + jobId + "','" + cbYear.Text + "-" + (cbMonth.SelectedIndex + 1) + "-" + cbDay.Text + "','Active')";
                        com = new MySqlCommand(cmd, connection);
                        com.ExecuteNonQuery();
                    }
                    if (x == len - 1)
                    {
                        MessageBox.Show("Applicants set for Initial Interview", "Schedule Initial Interview", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                }
                this.Close();
            }
            connection.Close();
        }
    }
}
