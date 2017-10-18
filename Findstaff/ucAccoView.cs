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
            connection.Open();
            appNo = appno;
            appName = appname;
            cmd = "select app_id from app_t where concat(lname, ', ', fname, ' ', mname) = '" + appName + "'";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                appID = dr[0].ToString();
            }
            dr.Close();
            connection.Close();
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
                joborder.Text = jorder;
                jobname.Text = jobName;
                employer.Text = employerName;
                applicant.Text = appName;
                dr.Close();
                cmd = "SELECT f.feename'Fee Name', j.amount'Amount', p.feestatus'Status' FROM genfees_t f "
                    + "join payables_t p on f.fee_id = p.fee_id "
                    + "join applications_t app on app.App_no = p.App_no "
                    + "join jobfees_t j on j.jorder_id = app.jorder_id "
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
    }
}
