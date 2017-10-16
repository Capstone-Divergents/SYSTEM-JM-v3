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
    public partial class ucJobListAddEdit : UserControl
    {
        private MySqlConnection connection;
        private MySqlDataReader dr;
        MySqlCommand com = new MySqlCommand();
        private string cmd = "";


        public ucJobListAddEdit()
        {
            InitializeComponent();
            panel1.Dock = DockStyle.Fill;
            panel2.Dock = DockStyle.Fill;
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            string empID = "", catID = "", jobID = "";
            connection.Open();
            cmd = "select employer_id from employer_t where employername = '" + txtEmployer1.Text + "'";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                empID = dr[0].ToString();
            }
            dr.Close();
            cmd = "select category_id from jobcategory_t where categoryname = '" + cbCategory1.Text + "'";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                catID = dr[0].ToString();
            }
            dr.Close();
            cmd = "select job_id from job_t where jobname = '" + cbJob1.Text + "'";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                jobID = dr[0].ToString();
            }
            dr.Close();
            cmd = "Select count(*) from joblist_t where jorder_id = '" + cbJOrder1.Text + "' and employer_id = '" + empID + "' and category_id = '" + catID + "' and job_id = '" + jobID + "'";
            com = new MySqlCommand(cmd, connection);
            int ctr = int.Parse(com.ExecuteScalar() + "");
            if(ctr == 0)
            {
                cmd = "insert into joblist_t(jorder_id, Employer_id, category_id, job_id, reqapp, salary, heightreq, weightreq, placementfee)"
                + "values ('" + cbJOrder1.Text + "','" + empID + "','" + catID + "','" + jobID + "','" + txtReqApp1.Text + "','" + txtSalary1.Text + "','" + txtHeight.Text + "','" + txtWeight.Text + "','" + txtSalary1.Text + "')";
                com = new MySqlCommand(cmd, connection);
                com.ExecuteNonQuery();
                string cmd2 = "", sID = "", reqID = "";
                cmd = "insert into jobskills_t values ";
                for (int x = 0; x < dgvSkills1.Rows.Count; x++)
                {
                    cmd2 = "select skill_id from genskills_t where skillname = '" + dgvSkills1.Rows[x].Cells[0].Value.ToString() + "'";
                    com = new MySqlCommand(cmd2, connection);
                    dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        sID = dr[0].ToString();
                    }
                    dr.Close();
                    cmd += "('" + cbJOrder1.Text + "','" + empID + "','" + catID + "','" + jobID + "','" + sID + "','" + dgvSkills1.Rows[x].Cells[1].Value.ToString() + "')";
                    if (x < dgvSkills1.Rows.Count - 1)
                    {
                        cmd += ",";
                    }
                }
                com = new MySqlCommand(cmd, connection);
                com.ExecuteNonQuery();
                cmd = "insert into jobdocs_t values ";
                for (int x = 0; x < dgvReqdDocs1.Rows.Count; x++)
                {
                    cmd2 = "select req_id from genreqs_t where reqname = '" + dgvReqdDocs1.Rows[x].Cells[0].Value.ToString() + "'";
                    com = new MySqlCommand(cmd2, connection);
                    dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        reqID = dr[0].ToString();
                    }
                    dr.Close();
                    cmd += "('" + cbJOrder1.Text + "','" + empID + "','" + catID + "','" + jobID + "','" + reqID + "')";
                    if (x < dgvReqdDocs1.Rows.Count - 1)
                    {
                        cmd += ",";
                    }
                }
                com = new MySqlCommand(cmd, connection);
                com.ExecuteNonQuery();
                MessageBox.Show("Job Added!", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbJOrder1.SelectedIndex = -1;
                cbCategory1.SelectedIndex = -1;
                cbJob1.SelectedIndex = -1;
                txtReqApp1.Clear();
                txtSalary1.Clear();
                txtHeight.Clear();
                txtWeight.Clear();
                for (int x = 0; x < dgvSkills1.Rows.Count; x++)
                {
                    cbSkillName.Items.Add(dgvSkills1.Rows[x].Cells[0].Value.ToString());
                }
                dgvSkills1.Rows.Clear();
                for (int x = 0; x < dgvReqdDocs1.Rows.Count; x++)
                {
                    cbSkillName.Items.Add(dgvReqdDocs1.Rows[x].Cells[0].Value.ToString());
                }
                dgvSkills1.Rows.Clear();
            }
            else
            {
                MessageBox.Show("A job record in the list exists.","Add Job to Listings Error");
            }
            connection.Close();
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            cbJOrder1.Items.Clear();
            txtEmployer1.Clear();
            cbCategory1.Items.Clear();
            cbJob1.Items.Clear();
            txtReqApp1.Clear();
            txtSalary1.Clear();
            txtHeight.Clear();
            txtWeight.Clear();
            cbSkillName.Items.Clear();
            cbReqName.Items.Clear();
            for (int x = 0; x < dgvSkills1.Rows.Count; x++)
            {
                cbSkillName.Items.Add(dgvSkills1.Rows[x].Cells[0].Value.ToString());
            }
            dgvSkills1.Rows.Clear();
            for (int x = 0; x < dgvReqdDocs1.Rows.Count; x++)
            {
                cbSkillName.Items.Add(dgvReqdDocs1.Rows[x].Cells[0].Value.ToString());
            }
            dgvSkills1.Rows.Clear();
            cbJOrder1.Enabled = true;
            btnAddSkill.Enabled = false;
            btnReqAdd.Enabled = false;
            btnAddAll.Enabled = false;
            this.Hide();
        }

        private void btnEditJob_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbJOrder1.Text != "")
            {
                cbJOrder1.Enabled = false;
                btnAddSkill.Enabled = true;
                btnReqAdd.Enabled = true;
                btnAddAll.Enabled = true;
            }
        }

        private void ucJobListAddEdit_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            if(this.Visible == true)
            {
                connection.Open();
                cmd = "Select jorder_id from joborder_t where cntrctstat = 'Active'";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cbJOrder1.Items.Add(dr[0]);
                }
                dr.Close();

                cmd = "Select categoryname from jobcategory_t";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cbCategory1.Items.Add(dr[0]);
                    cbCategory2.Items.Add(dr[0]);
                }
                dr.Close();

                cmd = "Select skillname from genskills_t";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cbSkillName.Items.Add(dr[0]);
                    cbSkillName2.Items.Add(dr[0]);
                }
                dr.Close();
                cmd = "Select Reqname from genreqs_t where allocation = 'job'";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cbReqName.Items.Add(dr[0]);
                    cbReqName2.Items.Add(dr[0]);
                }
                dr.Close();
                connection.Close();
            }
            else
            {
                cbJOrder1.Items.Clear();
                cbSkillName.Items.Clear();
                cbReqName.Items.Clear();
                cbSkillName2.Items.Clear();
                cbReqName2.Items.Clear();
            }
        }

        private void cbJOrder1_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            cmd = "select e.employername from joborder_t j join employer_t e on j.employer_id = e.employer_id where j.jorder_id = '"+cbJOrder1.Text+"'";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                txtEmployer1.Text = dr[0].ToString();
            }
            dr.Close();
            connection.Close();
        }

        private void btnAddSkill_Click(object sender, EventArgs e)
        {
            if(cbSkillName.Text != "" && cbProf.Text != "")
            {
                dgvSkills1.ColumnCount = 2;
                dgvSkills1.Rows.Add(cbSkillName.Text, cbProf.Text);
                cbSkillName.Items.Remove(cbSkillName.Text);
                cbProf.SelectedIndex = -1;
            }
        }

        private void btnRemoveSkill_Click(object sender, EventArgs e)
        {
            if(dgvSkills1.Rows.Count != 0)
            {
                cbSkillName.Items.Add(dgvSkills1.SelectedRows[0].Cells[0].Value.ToString());
                dgvSkills1.Rows.Remove(dgvSkills1.SelectedRows[0]);
            }
        }

        private void btnReqAdd_Click(object sender, EventArgs e)
        {
            if (cbReqName.Text != "")
            {
                dgvReqdDocs1.ColumnCount = 1;
                dgvReqdDocs1.Rows.Add(cbReqName.Text);
                cbReqName.Items.Remove(cbReqName.Text);
            }
        }

        private void btnReqRemove_Click(object sender, EventArgs e)
        {
            if (dgvReqdDocs1.Rows.Count != 0)
            {
                cbReqName.Items.Add(dgvReqdDocs1.SelectedRows[0].Cells[0].Value.ToString());
                dgvReqdDocs1.Rows.Remove(dgvReqdDocs1.SelectedRows[0]);
            }
        }

        private void cbCategory1_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            cbJob1.Items.Clear();
            cmd = "select j.jobname from job_t j join jobcategory_t c on j.category_id = c.category_id where c.categoryname = '"+cbCategory1.Text+"'";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                cbJob1.Items.Add(dr[0].ToString());
            }
            dr.Close();
            connection.Close();
        }

        private void txtReqApp1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSalary1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
