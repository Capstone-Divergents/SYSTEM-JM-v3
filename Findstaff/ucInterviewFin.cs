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
    public partial class ucInterviewFin : UserControl
    {
        private MySqlConnection connection;
        private MySqlCommand com = new MySqlCommand();
        private string cmd = "";
        MySqlDataReader dr;

        public ucInterviewFin()
        {
            InitializeComponent();
        }

        private void btnViewIntList_Click(object sender, EventArgs e)
        {
            if(dgvFinInt.Rows.Count != 0)
            {
                connection.Open();
                string jobID = "", empID = "", jorder = dgvFinInt.SelectedRows[0].Cells[0].Value.ToString(), jobname = dgvFinInt.SelectedRows[0].Cells[1].Value.ToString(), employer = "";
                cmd = "select e.employername from employer_t e join joborder_t j "
                    + "on e.employer_id = j.employer_id where j.jorder_id = '" + jorder + "'";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    employer = dr[0].ToString();
                }
                dr.Close();
                cmd = "select job_id from job_t where jobname = '" + jobname + "'";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    jobID = dr[0].ToString();
                }
                dr.Close();
                cmd = "select employer_id from employer_t where employername = '" + employer + "'";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    empID = dr[0].ToString();
                }
                dr.Close();
                cmd = "select app.app_no'Application No.', a.app_id'Applicant ID', concat(a.lname, ', ', a.fname, ' ', a.mname)'Applicant Name' from applications_t app "
                    + "join app_t a on app.app_id = a.app_id where app.appstats = 'Active' and a.appstatus = 'For Final Interview' "
                    + "and app.jorder_id = '" + jorder + "' and app.job_id = '" + jobID + "' and app.employer_id = '" + empID + "' and finalinterviewstatus is null and initinterviewstatus = 'Passed'";
                using (connection)
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        ucIntListFinal.dgvIntervieweeList.DataSource = ds.Tables[0];
                    }
                }
                ucIntListFinal.joborder.Text = jorder;
                ucIntListFinal.jobname.Text = jobname;
                ucIntListFinal.employer.Text = employer;
                connection.Close();
                ucIntListFinal.Dock = DockStyle.Fill;
                ucIntListFinal.Visible = true;
            }
        }
        
        private void ucIntListFinal_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            cmd = "Select j.jorder_id'Job Order No.', jb.jobname'Job Name', count(a.appstats)'No. of Interviewees' from joborder_t j "
                + "join job_t jb on j.job_id = jb.job_id join applications_t a "
                + "on a.jorder_id = j.jorder_id and a.job_id = jb.job_id "
                + "where a.appstats = 'Active' and a.initinterviewstatus = 'Passed' and a.finalinterviewstatus is null group by j.jorder_id, jb.jobname";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvFinInt.DataSource = ds.Tables[0];
                }
            }
        }
    }
}
