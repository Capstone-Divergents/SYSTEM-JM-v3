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
    public partial class ucAccoView : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();
        MySqlDataReader dr;
        MySqlDataAdapter adapter;
        private string cmd = "";
        private string appNo = "", appName = "";
        private string jorder = "", jobID = "", empID = "", jobName = "", employerName = "", appID = "";

        public ucAccoView()
        {
            InitializeComponent();
        }

        public void init(string appno, string appname)
        {
            appNo = appno;
            appID = appname;
        }

        private void ucAccoView_Load(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
        }

        private void btnPayBal_Click(object sender, EventArgs e)
        {
            connection.Open();
            int total = 0;
            string[] fees = new string[dgvViewAcco.SelectedRows.Count];
            string fee = "";
            string jobtype = "";
            cmd = "select j.jobtype from job_t j join applications_t a where a.app_no = '" + appNo + "'";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                jobtype = dr[0].ToString();
            }
            dr.Close();
            if (jobtype == "Skilled")
            {
                for (int x = 0; x < dgvViewAcco.SelectedRows.Count; x++)
                {
                    cmd = "select fee_id from genfees_t where feename = '" + dgvViewAcco.SelectedRows[x].Cells[0].Value.ToString() + "'";
                    com = new MySqlCommand(cmd, connection);
                    dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        fees[x] = dr[0].ToString();
                    }
                    dr.Close();
                    fee += dgvViewAcco.SelectedRows[x].Cells[0].Value.ToString() + "\n";
                    total += Convert.ToInt32(dgvViewAcco.SelectedRows[x].Cells[1].Value.ToString());
                    
                }
                DialogResult y = MessageBox.Show("Are you sure you want to pay the balance(s)? \n" + fee, "Pay Balance?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == y)
                {
                    Payment p = new Payment();
                    p.init(appNo, appID, fees, total, dgvViewAcco.SelectedRows.Count);
                    p.Show();
                }
            }
            else
            {
                MessageBox.Show("Applicant doesn't need to pay the any fees.\nApplicant status already set to deployed.");
                cmd = "update applications_t set appstatus = 'Deployed' where app_no = '" + appNo + "'";
                com = new MySqlCommand(cmd, connection);
                com.ExecuteNonQuery();
                this.Hide();
            }
            connection.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ucAccoView_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();
            if (this.Visible == true)
            {
                cmd = "select jorder_id, job_id, employer_id from applications_t where app_no = '" + appNo + "'";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    jorder = dr[0].ToString();
                    jobID = dr[1].ToString();
                    empID = dr[2].ToString();
                }
                dr.Close();
                cmd = "select jobname from job_t where job_id = '" + jobID + "'";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    jobName = dr[0].ToString();
                }
                dr.Close();
                cmd = "select employername from employer_t where employer_id = '" + empID + "'";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    employerName = dr[0].ToString();
                }
                dr.Close();
                cmd = "select concat(lname, ', ', fname, ' ', mname) from app_t where app_id = '" + appID + "'";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    appName = dr[0].ToString();
                }
                dr.Close();
                joborder.Text = jorder;
                jobname.Text = jobName;
                employer.Text = employerName;
                applicant.Text = appName;
                dr.Close();
                cmd = "select f.feename'Fee Name', j.amount'Amount', p.feestatus'Status' "
                    + "from payables_t p join genfees_t f on p.fee_id = f.fee_id "
                    + "join jobfees_t j on p.fee_id = j.fee_id "
                    + "join applications_t app on app.app_no = p.app_no "
                    + "where app.appstats = 'Active' and app.app_no = '" + appNo + "'";
                using (adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvViewAcco.DataSource = ds.Tables[0];
                }
            }
            connection.Close();
        }

        public void resetTable()
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();
            if (this.Visible == true)
            {
                cmd = "select jorder_id, job_id, employer_id from applications_t where app_no = '" + appNo + "'";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    jorder = dr[0].ToString();
                    jobID = dr[1].ToString();
                    empID = dr[2].ToString();
                }
                dr.Close();
                cmd = "select jobname from job_t where job_id = '" + jobID + "'";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    jobName = dr[0].ToString();
                }
                dr.Close();
                cmd = "select employername from employer_t where employer_id = '" + empID + "'";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    employerName = dr[0].ToString();
                }
                dr.Close();
                cmd = "select concat(lname, ', ', fname, ' ', mname) from app_t where app_id = '" + appID + "'";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    appName = dr[0].ToString();
                }
                dr.Close();
                joborder.Text = jorder;
                jobname.Text = jobName;
                employer.Text = employerName;
                applicant.Text = appName;
                dr.Close();
                cmd = "SELECT f.feename'Fee Name', j.amount'Amount', p.feestatus'Status' FROM genfees_t f "
                    + "join payables_t p on f.fee_id = p.fee_id "
                    + "join applications_t app on app.App_no = p.App_no "
                    + "join jobfees_t j on j.jorder_id = app.jorder_id "
                    + "where app.appstats = 'Active' and app.app_no = '" + appNo + "' and app.appstats = 'Active' "
                    + "group by f.feename";
                using (adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvViewAcco.DataSource = ds.Tables[0];
                }
            }
            connection.Close();
        }
    }
}
