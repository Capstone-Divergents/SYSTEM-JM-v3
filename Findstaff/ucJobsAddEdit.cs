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
using System.Text.RegularExpressions;

namespace Findstaff
{
    public partial class ucJobsAddEdit : UserControl
    {

        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();
        private string cmd = "";
        MySqlDataReader dr;

        public ucJobsAddEdit()
        {
            InitializeComponent();
            panel1.Dock = DockStyle.Fill;
            panel2.Dock = DockStyle.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            connection.Open();
            string jobname = txtJobs.Text;
            string categ = cbCategory.Text;
            string jobtype = cbJobType.Text;
            string categID = "", jobtypeID = "";
            if (jobname != "" && categ != "" && jobtype != "")
            {
                int ctr = 0;
                string check = "Select Count(jobname) from job_t where jobname = '" + txtJobs.Text + "'";
                com = new MySqlCommand(check, connection);
                ctr = int.Parse(com.ExecuteScalar() + "");
                if (ctr == 0)
                {
                    string cmd = "Select category_id from jobcategory_t where categoryname = '" + categ + "';";
                    com = new MySqlCommand(cmd, connection);
                    MySqlDataReader dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        categID = dr[0].ToString();
                    }
                    dr.Close();

                    cmd = "select jobtype_id from jobtype_t where typename = '" + cbJobType.Text + "'";
                    com = new MySqlCommand(cmd, connection);
                    dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        jobtypeID = dr[0].ToString();
                    }
                    dr.Close();

                    cmd = "insert into job_t (category_id, jobname, jobtype_id) values ('" + categID + "','" + jobname + "','" + jobtypeID + "');";
                    com = new MySqlCommand(cmd, connection);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Job Record Added!", "New Added!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtJobs.Clear();
                    cbCategory.SelectedIndex = -1;
                    cbJobType.SelectedIndex = -1;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Record already exists.", "Error Message");
                }
            }
            else
            {
                MessageBox.Show("Empty Fields Present", "Error Message");
            }
            connection.Close();
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            txtJobs.Clear();
            cbCategory.SelectedIndex = -1;
            cbJobType.SelectedIndex = -1;
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            connection.Open();
            if (txtJobs2.Text == "")
            {
                MessageBox.Show("Job name must not be empty.", "Empty Job Name Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult rs = MessageBox.Show("Are you sure You want to update the record with the following details?"
                    + "\nJob ID: " + txtID.Text
                    + "\nNew Category: " + cbCategory1.Text
                    + "\nNew Job Name: " + txtJobs2.Text
                    + "\nNew TobType: " + cbJobType2.Text, "Confirmation", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    string categID = "", jobtypeID = "";
                    cmd = "select category_id from jobcategory_t where categoryname = '" + cbCategory1.Text + "'";
                    com = new MySqlCommand(cmd, connection);
                    dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        categID = dr[0].ToString();
                    }
                    dr.Close();

                    cmd = "select jobtype_id from jobtype_t where typename = '" + cbJobType2.Text + "'";
                    com = new MySqlCommand(cmd, connection);
                    dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        jobtypeID = dr[0].ToString();
                    }
                    dr.Close();

                    cmd = "Update Job_t set category_id = '" + categID + "', jobname = '" + txtJobs2.Text + "', jobtype_id = '"+jobtypeID+"' where job_id = '" + txtID.Text + "';";
                    com = new MySqlCommand(cmd, connection);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Changes Saved!", "Updated Requirement Record!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Clear();
                    cbCategory1.SelectedIndex = -1;
                    txtJobs2.Clear();
                    this.Hide();
                }
            }
            connection.Close();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            cbCategory1.SelectedIndex = -1;
            txtJobs2.Clear();
            cbJobType2.SelectedIndex = -1;
            this.Hide();
        }

        private void ucJobsAddEdit_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            if(this.Visible == true)
            {
                connection.Open();
                cmd = "Select categoryname from jobcategory_t;";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cbCategory.Items.Add(dr[0].ToString());
                    cbCategory1.Items.Add(dr[0].ToString());
                }
                dr.Close();
                cmd = "Select typename from jobtype_t;";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cbJobType.Items.Add(dr[0].ToString());
                    cbJobType2.Items.Add(dr[0].ToString());
                }
                dr.Close();
                connection.Close();
            }
            else
            {
                cbCategory.Items.Clear();
                cbCategory1.Items.Clear();
                cbJobType.Items.Clear();
                cbJobType2.Items.Clear();
            }
        }

        private void txtJobs_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[a-zA-Z ]*$").IsMatch(txtJobs.Text)))
            {
                txtJobs.Text = "";
            }
        }

        private void txtJobs2_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[a-zA-Z ]*$").IsMatch(txtJobs2.Text)))
            {
                txtJobs2.Text = "";
            }
        }
    }
}
