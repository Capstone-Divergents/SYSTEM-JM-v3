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
            string empID = "", catID = "", jobID = "", gender = "";
            connection.Open();
            cmd = "select employer_id from employer_t where employername = '" + cbEmployer1.Text + "'";
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
            if(rbMale1.Checked == true)
            {
                gender = rbMale1.Text;
            }
            else if (rbFemale1.Checked == true)
            {
                gender = rbFemale1.Text;
            }
            else if (rbAll1.Checked == true)
            {
                gender = rbAll1.Text;
            }
            cmd = "Select count(*) from joborder_t where  employer_id = '" + empID + "' and category_id = '" + catID + "' and job_id = '" + jobID + "' and monthname(CNTRCTSTART) = '"+cbMonth.Text+"' and day(cntrctstart) = '"+cbDay.Text+"' and year(cntrctstart) = '"+cbYear.Text+"'";
            com = new MySqlCommand(cmd, connection);
            int ctr = int.Parse(com.ExecuteScalar() + "");
            if(ctr == 0)
            {
                cmd = "insert into joborder_t (Employer_id, category_id, job_id, reqapp, salary, gender, heightreq, weightreq, cntrctstart, cntrctend, cntrctstat) "
                + "values ('" + empID + "','" + catID + "','" + jobID + "','" + nddEmployees1.Value + "','" + txtSalary1.Text + "','"+gender+"','" + txtHeight.Text + "','" + txtWeight.Text + "', '" + cbYear.Text + "-" + (cbMonth.SelectedIndex+1).ToString() + "-" + cbDay.Text + "','" + (Convert.ToInt32(cbYear.Text)+5).ToString() + "-" + (cbMonth.SelectedIndex + 1).ToString() + "-" + cbDay.Text + "', 'Active')";
                com = new MySqlCommand(cmd, connection);
                com.ExecuteNonQuery();
                string cmd2 = "",joID = "", sID = "", reqID = "";
                cmd = "Select max(jorder_id) from joborder_t";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    joID = dr[0].ToString();
                }
                dr.Close();
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
                    cmd += "('" + joID + "','" + empID + "','" + catID + "','" + jobID + "','" + sID + "','" + dgvSkills1.Rows[x].Cells[1].Value.ToString() + "')";
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
                    cmd += "('" + joID + "','" + empID + "','" + catID + "','" + jobID + "','" + reqID + "')";
                    if (x < dgvReqdDocs1.Rows.Count - 1)
                    {
                        cmd += ",";
                    }
                }
                com = new MySqlCommand(cmd, connection);
                com.ExecuteNonQuery();
                MessageBox.Show("Job Added!", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
                cbEmployer1.Items.Clear();
                cbCategory1.Items.Clear();
                cbJob1.Items.Clear();
                cbMonth.SelectedIndex = -1;
                cbDay.SelectedIndex = -1;
                cbYear.SelectedIndex = -1;
                rbMale1.Checked = false;
                rbFemale1.Checked = false;
                rbAll1.Checked = false;
                nddEmployees1.Value = 1;
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
                dgvReqdDocs1.Rows.Clear();
            }
            else
            {
                MessageBox.Show("A job record in the list exists.","Add Job to Listings Error");
            }
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            txtJobOrder1.Text = "";
            cbEmployer1.Items.Clear();
            cbCategory1.Items.Clear();
            cbJob1.Items.Clear();
            cbMonth.SelectedIndex = -1;
            cbDay.SelectedIndex = -1;
            cbYear.SelectedIndex = -1;
            rbMale1.Checked = false;
            rbFemale1.Checked = false;
            rbAll1.Checked = false;
            nddEmployees1.Value = 1;
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
            dgvReqdDocs1.Rows.Clear();
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
            if (cbEmployer1.Text != "")
            {
                cbEmployer1.Enabled = false;
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
                cmd = "Select employername from employer_t";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cbEmployer1.Items.Add(dr[0]);
                    cbEmployer2.Items.Add(dr[0]);
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
                cmd = "select count(*) from joborder_t";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    txtJobOrder1.Text = (Convert.ToUInt32(dr[0].ToString()) + 1).ToString();
                }
                dr.Close();
                connection.Close();
            }
            else
            {
                cbEmployer1.Items.Clear();
                cbEmployer2.Items.Clear();
                cbSkillName.Items.Clear();
                cbSkillName2.Items.Clear();
                cbReqName.Items.Clear();
                cbReqName2.Items.Clear();
            }
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

        private void rbMale1_Click(object sender, EventArgs e)
        {
            rbMale1.Checked = true;
            rbFemale1.Checked = false;
            rbAll1.Checked = false;
        }

        private void rbFemale1_Click(object sender, EventArgs e)
        {
            rbMale1.Checked = false;
            rbFemale1.Checked = true;
            rbAll1.Checked = false;
        }

        private void rbAll1_Click(object sender, EventArgs e)
        {
            rbMale1.Checked = false;
            rbFemale1.Checked = false;
            rbAll1.Checked = true;
        }

        private void rbMale2_Click(object sender, EventArgs e)
        {
            rbMale2.Checked = true;
            rbFemale2.Checked = false;
            rbAll2.Checked = false;
        }

        private void rbFemale2_Click(object sender, EventArgs e)
        {
            rbMale2.Checked = false;
            rbFemale2.Checked = true;
            rbAll2.Checked = false;
        }

        private void rbAll2_Click(object sender, EventArgs e)
        {
            rbMale2.Checked = false;
            rbFemale2.Checked = false;
            rbAll2.Checked = true;
        }

        private void cbMonth2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDay2.Items.Clear();
            if(cbMonth2.SelectedIndex == 0 || cbMonth2.SelectedIndex == 2 || cbMonth2.SelectedIndex == 4 || cbMonth2.SelectedIndex == 6 ||
                cbMonth2.SelectedIndex == 7 || cbMonth2.SelectedIndex == 9 || cbMonth2.SelectedIndex == 11)
            {
                for(int x = 1; x <= 31; x++)
                {
                    cbDay2.Items.Add(x);
                }
            }
            else if (cbMonth2.SelectedIndex == 3 || cbMonth2.SelectedIndex == 5 || cbMonth2.SelectedIndex == 8)
            {
                for (int x = 1; x <= 30; x++)
                {
                    cbDay2.Items.Add(x);
                }
            }
            else
            {
                for (int x = 1; x <= 28; x++)
                {
                    cbDay2.Items.Add(x);
                }
            }
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDay.Items.Clear();
            if (cbMonth.SelectedIndex == 0 || cbMonth.SelectedIndex == 2 || cbMonth.SelectedIndex == 4 || cbMonth.SelectedIndex == 6 ||
                cbMonth.SelectedIndex == 7 || cbMonth.SelectedIndex == 9 || cbMonth.SelectedIndex == 11)
            {
                for (int x = 1; x <= 31; x++)
                {
                    cbDay.Items.Add(x);
                }
            }
            else if (cbMonth.SelectedIndex == 3 || cbMonth.SelectedIndex == 5 || cbMonth.SelectedIndex == 8)
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
    }
}
