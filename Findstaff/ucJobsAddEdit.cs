﻿using System;
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
            string categID = "";
            if (jobname != "" && categ != "" && jobtype != "")
            {
                int ctr = 0;
                string cID = "";
                string cou = "select count(*) from Job_t;";
                com = new MySqlCommand(cou, connection);
                ctr = int.Parse(com.ExecuteScalar() + "");
                if ((ctr + "").Length == 1)
                {
                    cID = "J0000" + ctr + "";
                }
                else if ((ctr + "").Length == 2)
                {
                    cID = "J000" + ctr + "";
                }
                else if ((ctr + "").Length == 3)
                {
                    cID = "J00" + ctr + "";
                }
                else if ((ctr + "").Length == 4)
                {
                    cID = "J0" + ctr + "";
                }
                else if ((ctr + "").Length == 5)
                {
                    cID = "J" + ctr + "";
                }
                else
                {
                    MessageBox.Show("Table in the database will not be able to handle more records.");
                }
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
                    cmd = "insert into job_t values ('" + categID + "','" + cID + "','" + jobname + "','" + jobtype + "');";
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
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ucJobsAddEdit_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            if(this.Visible == true)
            {
                connection.Open();
                string cmd = "Select categoryname from jobcategory_t;";
                com = new MySqlCommand(cmd, connection);
                MySqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cbCategory.Items.Add(dr[0].ToString());
                    cbCategory1.Items.Add(dr[0].ToString());
                }
                dr.Close();
                connection.Close();
            }
            else
            {
                cbCategory.Items.Clear();
                cbCategory1.Items.Clear();
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
