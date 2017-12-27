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
    public partial class ucIntListFinal : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();
        MySqlDataReader dr;
        private string cmd = "";

        public ucIntListFinal()
        {
            InitializeComponent();
        }

        private void ucIntListFinal_Load(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
        }

        private void btnPassInt_Click(object sender, EventArgs e)
        {
            connection.Open();
            if (dgvIntervieweeList.Rows.Count != 0)
            {
                string country = "", jobID = "", categID = "";
                cmd = "select country_id from employer_t where employername = '" + employer.Text + "'";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    country = dr[0].ToString();
                }
                dr.Close();
                cmd = "Select category_id, job_id from job_t where jobname = '" + jobname.Text + "'";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    categID = dr[0].ToString();
                    jobID = dr[1].ToString();
                }
                dr.Close();
                int ctr = 0;
                cmd = "select reqapp from joborder_t where jorder_id = '"+joborder.Text+"' and job_id = '"+jobID+"'";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    ctr = Convert.ToInt32(dr[0].ToString());
                }
                dr.Close();
                if(ctr != 0)
                {
                    int ctrB = 0, ctrJ = 0, ctrC = 0, x = 0, y = 0, z = 0;
                    cmd = "update applications_t set finalinterviewstatus = 'Passed' where app_no = '" + dgvIntervieweeList.SelectedRows[0].Cells[0].Value.ToString() + "'";
                    com = new MySqlCommand(cmd, connection);
                    com.ExecuteNonQuery();
                    cmd = "update app_t set appstatus = 'Selected' where app_id = '" + dgvIntervieweeList.SelectedRows[0].Cells[1].Value.ToString() + "'";
                    com = new MySqlCommand(cmd, connection);
                    com.ExecuteNonQuery();
                    cmd = "select count(req_id) from genreqs_t where allocation = 'Basic'";
                    com = new MySqlCommand(cmd, connection);
                    ctrB = int.Parse(com.ExecuteScalar() + "");
                    string[] reqIDBasic = new string[ctrB];
                    cmd = "select req_id from genreqs_t where allocation = 'Basic'";
                    com = new MySqlCommand(cmd, connection);
                    dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        reqIDBasic[x] = dr[0].ToString();
                        x++;
                    }
                    dr.Close();
                    cmd = "select count(req_id) from jobdocs_t where jorder_id = '" + joborder.Text + "' and job_id = '" + jobID + "'";
                    com = new MySqlCommand(cmd, connection);
                    ctrJ = int.Parse(com.ExecuteScalar() + "");
                    string[] reqIDJob = new string[ctrJ];
                    cmd = "select req_id from jobdocs_t where jorder_id = '" + joborder.Text + "' and job_id = '" + jobID + "'";
                    com = new MySqlCommand(cmd, connection);
                    dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        reqIDJob[y] = dr[0].ToString();
                        y++;
                    }
                    dr.Close();
                    cmd = "select count(req_id) from countryreqs_t where country_id = '" + country + "'";
                    com = new MySqlCommand(cmd, connection);
                    ctrC = int.Parse(com.ExecuteScalar() + "");
                    string[] reqIDCountry = new string[ctrC];
                    cmd = "select req_id from countryreqs_t where country_id = '" + country + "'";
                    com = new MySqlCommand(cmd, connection);
                    dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        reqIDCountry[z] = dr[0].ToString();
                        z++;
                    }
                    dr.Close();
                    x = 0; y = 0; z = 0;
                    for (x = 0; x < ctrB; x++)
                    {
                        cmd = "insert into appdoc_t values ('" + dgvIntervieweeList.SelectedRows[0].Cells[0].Value.ToString() + "','" + dgvIntervieweeList.SelectedRows[0].Cells[1].Value.ToString() + "','" + Convert.ToInt32(reqIDBasic[x]) + "','Required');";
                        com = new MySqlCommand(cmd, connection);
                        com.ExecuteNonQuery();
                    }
                    for (y = 0; y < ctrJ; y++)
                    {
                        cmd = "insert into appdoc_t values ('" + dgvIntervieweeList.SelectedRows[0].Cells[0].Value.ToString() + "','" + dgvIntervieweeList.SelectedRows[0].Cells[1].Value.ToString() + "','" + Convert.ToInt32(reqIDJob[y]) + "','Required');";
                        com = new MySqlCommand(cmd, connection);
                        com.ExecuteNonQuery();
                    }
                    for (z = 0; z < ctrC; z++)
                    {
                        cmd = "insert into appdoc_t values ('" + dgvIntervieweeList.SelectedRows[0].Cells[0].Value.ToString() + "','" + dgvIntervieweeList.SelectedRows[0].Cells[1].Value.ToString() + "','" + Convert.ToInt32(reqIDCountry[z]) + "','Required');";
                        com = new MySqlCommand(cmd, connection);
                        com.ExecuteNonQuery();
                    }
                    MessageBox.Show(dgvIntervieweeList.SelectedRows[0].Cells[2].Value.ToString() + " Passed Final Interview!", "Final Interview Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmd = "update joborder_t set reqapp = reqapp - 1 where jorder_id = '" + joborder.Text + "' and job_id = '" + jobID + "'";
                    com = new MySqlCommand(cmd, connection);
                    com.ExecuteNonQuery();
                    string empID = "";
                    cmd = "select employer_id from employer_t where employername = '" + employer.Text + "'";
                    com = new MySqlCommand(cmd, connection);
                    dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        empID = dr[0].ToString();
                    }
                    dr.Close();
                    cmd = "select app.app_no'Application No.', a.app_id'Applicant ID', concat(a.lname, ', ', a.fname, ' ', a.mname)'Applicant Name' from applications_t app "
                        + "join app_t a on app.app_id = a.app_id where app.appstats = 'Active' and a.appstatus = 'For Final Interview' "
                        + "and app.jorder_id = '" + joborder.Text + "' and app.job_id = '" + jobID + "' and app.employer_id = '" + empID + "' and finalinterviewstatus is null and initinterviewstatus = 'Passed'";
                    using (connection)
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                        {
                            DataSet ds = new DataSet();
                            adapter.Fill(ds);
                            dgvIntervieweeList.DataSource = ds.Tables[0];
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Required applicants for the job specified is already satisfied.", "Final Interview Contraint");
                }
            }
            connection.Close();
        }

        private void btnFailInt_Click(object sender, EventArgs e)
        {
            connection.Open();
            cmd = "update applications_t set finalinterviewstatus = 'Passed' where app_no = '" + dgvIntervieweeList.SelectedRows[0].Cells[0].Value.ToString() + "'";
            com = new MySqlCommand(cmd, connection);
            com.ExecuteNonQuery();
            cmd = "update app_t set appstatus = 'Archived' where Concat(lname, ', ', fname, ' ', mname) = '" + dgvIntervieweeList.SelectedRows[0].Cells[1].Value.ToString() + "'";
            com = new MySqlCommand(cmd, connection);
            com.ExecuteNonQuery();
            MessageBox.Show(dgvIntervieweeList.SelectedRows[0].Cells[2].Value.ToString() + " Failed Final Interview!", "Final Interview Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvIntervieweeList.Rows.Remove(dgvIntervieweeList.SelectedRows[0]);
            connection.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
