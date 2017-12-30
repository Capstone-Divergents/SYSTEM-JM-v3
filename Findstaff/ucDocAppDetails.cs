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
    public partial class ucDocAppDetails : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();
        MySqlDataReader dr;
        MySqlDataAdapter adapter;
        private string cmd = "";
        private string appNo = "", appName = "";
        private string jorder = "", jobID = "", empID = "", jobName = "", employerName = "", appID = "";

        public ucDocAppDetails()
        {
            InitializeComponent();
        }

        public void init(string appno, string appname)
        {
            appNo = appno;
            appID = appname;
        }

        private void ucDocAppDetails_Load(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
        }

        private void btnMoveToAcco_Click(object sender, EventArgs e)
        {
            connection.Open();
            int ctr = 0;
            for (int x = 0; x < dgvBasicReqs.Rows.Count; x++)
            {
                if (dgvBasicReqs.Rows[x].Cells[1].Value.ToString() != "Passed")
                {
                    ctr++;
                }
            }
            for (int x = 0; x < dgvAddlReqs.Rows.Count; x++)
            {
                if (dgvAddlReqs.Rows[x].Cells[1].Value.ToString() != "Passed")
                {
                    ctr++;
                }
            }
            if(ctr == 0)
            {
                cmd = "update app_t set appstatus = 'Payment' where app_id = '"+appID+"'";
                com = new MySqlCommand(cmd, connection);
                com.ExecuteNonQuery();
                cmd = "select count(fee_id) from jobfees_t where jorder_id = '" + jorder + "'";
                com = new MySqlCommand(cmd, connection);
                int ctrJ = int.Parse(com.ExecuteScalar() + "");
                string[] feeIDJ = new string[ctrJ];
                int x = 0;
                cmd = "select fee_id from jobfees_t where jorder_id = '" + jorder + "'";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    feeIDJ[x] = dr[0].ToString();
                    x++;
                }
                dr.Close();
                string jobtype = "";
                cmd = "select jobtype from job_t where jobname = '"+jobName+"'";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    jobtype = dr[0].ToString();
                }
                dr.Close();
                if(jobtype == "Skilled")
                {
                    for(x = 0; x < ctrJ; x++)
                    {
                        cmd = "insert into payables_t (app_no, app_id, fee_id, feestatus) values ('" + appNo+"','"+appID+"','"+feeIDJ[x]+"','Balance')";
                        com = new MySqlCommand(cmd, connection);
                        com.ExecuteNonQuery();
                    }
                }
                else
                {
                    for (x = 0; x < ctrJ; x++)
                    {
                        cmd = "insert into payables_t (app_no, app_id, fee_id, feestatus) values ('" + appNo + "','" + appID + "','" + feeIDJ[x] + "','Not Required')";
                        com = new MySqlCommand(cmd, connection);
                        com.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("All documents passed.\nApplicant can now pay.","Fulfilled Document Requirements");
                this.Hide();
            }
            connection.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ucDocAppDetails_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();
            if (this.Visible == true)
            {
                cmd = "select jorder_id, job_id, employer_id from applications_t where app_no = '"+appNo+"'";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    jorder = dr[0].ToString();
                    jobID = dr[1].ToString();
                    empID = dr[2].ToString();
                }
                dr.Close();
                cmd = "select jobname from job_t where job_id = '"+jobID+"'";
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
                cmd = "SELECT g.reqname'Requirement Name', a.docstat'Status' FROM genreqs_t g "
                    + "join appdoc_t a on g.req_id = a.req_id "
                    + "join applications_t app on app.App_no = a.App_no "
                    + "where app.appstats = 'Active' and app.app_no = '"+appNo+"' and g.allocation = 'Basic'";
                using (adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvBasicReqs.DataSource = ds.Tables[0];
                }
                cmd = "SELECT g.reqname'Requirement Name', a.docstat'Status' FROM genreqs_t g "
                    + "join appdoc_t a on g.req_id = a.req_id "
                    + "join applications_t app on app.App_no = a.App_no "
                    + "where app.appstats = 'Active' and app.app_no = '" + appNo + "' and g.allocation <> 'Basic'";
                using (adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvAddlReqs.DataSource = ds.Tables[0];
                }
            }
            connection.Close();
        }

        private void btnPassed1_Click(object sender, EventArgs e)
        {
            connection.Open();
            bool passed = false;
            string docs = "";
            for(int x = 0; x < dgvBasicReqs.SelectedRows.Count; x++)
            {
                if (dgvBasicReqs.SelectedRows[x].Cells[1].Value.ToString() == "Passed")
                {
                    MessageBox.Show(dgvBasicReqs.SelectedRows[x].Cells[0].Value.ToString() +" has been passed.\nPlease check your selections.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passed = true;
                    docs = "";
                    break;
                }
                else
                {
                    docs += dgvBasicReqs.SelectedRows[x].Cells[0].Value.ToString() + "\n";
                }
            }
            if(!passed)
            {
                DialogResult dr1 = MessageBox.Show("Are you sure the following documents will be passed?\n\n" + docs, "Confirm Documents", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dr1 == DialogResult.Yes)
                {
                    string cmd2 = "";
                    for(int x = 0; x < dgvBasicReqs.SelectedRows.Count; x++)
                    {
                        cmd = "Update appdoc_t set docstat = 'Passed' where ";
                        cmd2 = "select req_id from genreqs_t where reqname = '" + dgvBasicReqs.SelectedRows[x].Cells[0].Value.ToString() + "'";
                        com = new MySqlCommand(cmd2, connection);
                        dr = com.ExecuteReader();
                        while (dr.Read())
                        {
                            cmd += "req_id = '" + dr[0].ToString() + "' and app_no = '" + appNo + "'";
                        }
                        dr.Close();
                        com = new MySqlCommand(cmd, connection);
                        com.ExecuteNonQuery();
                    }
                    MessageBox.Show("Documents status changed to 'Passed'", "Documents Passed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmd = "SELECT g.reqname'Requirement Name', a.docstat'Status' FROM genreqs_t g "
                    + "join appdoc_t a on g.req_id = a.req_id "
                    + "join applications_t app on app.App_no = a.App_no "
                    + "where app.appstats = 'Active' and app.app_no = '" + appNo + "' and g.allocation = 'Basic'";
                    using (adapter = new MySqlDataAdapter(cmd, connection))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dgvBasicReqs.DataSource = ds.Tables[0];
                    }
                }
            }
            connection.Close();
        }

        private void btnPassed2_Click(object sender, EventArgs e)
        {
            connection.Open();
            bool passed = false;
            string docs = "";
            for (int x = 0; x < dgvAddlReqs.SelectedRows.Count; x++)
            {
                if (dgvAddlReqs.SelectedRows[x].Cells[1].Value.ToString() == "Passed")
                {
                    MessageBox.Show(dgvAddlReqs.SelectedRows[x].Cells[0].Value.ToString() + " has been passed.\nPlease check your selections.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passed = true;
                    docs = "";
                    break;
                }
                else
                {
                    docs += dgvAddlReqs.SelectedRows[x].Cells[0].Value.ToString() + "\n";
                }
            }
            if (!passed)
            {
                DialogResult dr1 = MessageBox.Show("Are you sure the following documents will be passed?\n\n" + docs, "Confirm Documents", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr1 == DialogResult.Yes)
                {
                    string cmd2 = "";
                    
                    for (int x = 0; x < dgvAddlReqs.SelectedRows.Count; x++)
                    {
                        cmd = "Update appdoc_t set docstat = 'Passed' where ";
                        cmd2 = "select req_id from genreqs_t where reqname = '" + dgvAddlReqs.SelectedRows[x].Cells[0].Value.ToString() + "'";
                        com = new MySqlCommand(cmd2, connection);
                        dr = com.ExecuteReader();
                        while (dr.Read())
                        {
                            cmd += "req_id = '" + dr[0].ToString() + "' and app_no = '" + appNo + "'";
                        }
                        dr.Close();
                        com = new MySqlCommand(cmd, connection);
                        com.ExecuteNonQuery();
                    }
                    MessageBox.Show("Documents status changed to 'Passed'", "Documents Passed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmd = "SELECT g.reqname'Requirement Name', a.docstat'Status' FROM genreqs_t g "
                    + "join appdoc_t a on g.req_id = a.req_id "
                    + "join applications_t app on app.App_no = a.App_no "
                    + "where app.appstats = 'Active' and app.app_no = '" + appNo + "' and g.allocation <> 'Basic'";
                    using (adapter = new MySqlDataAdapter(cmd, connection))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dgvAddlReqs.DataSource = ds.Tables[0];
                    }
                }
            }
            connection.Close();
        }
    }
}
