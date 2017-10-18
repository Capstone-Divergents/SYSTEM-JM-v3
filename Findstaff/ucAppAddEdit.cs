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
    public partial class ucAppAddEdit : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();
        MySqlDataReader dr;
        private string cmd = "";

        public ucAppAddEdit()
        {
            InitializeComponent();
            panel1.Dock = DockStyle.Fill;
            panel2.Dock = DockStyle.Fill;
        }

        #region btnAdd_Click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int ctr = 0;
            string cID = "";
            connection.Open();
            cmd = "Select count(app_id) from app_t;";
            com = new MySqlCommand(cmd, connection);
            ctr = Convert.ToInt32(com.ExecuteScalar());
            if ((ctr + "").Length == 1)
            {
                cID = "A00000000" + ctr + "";
            }
            else if ((ctr + "").Length == 2)
            {
                cID = "A0000000" + ctr + "";
            }
            else if ((ctr + "").Length == 3)
            {
                cID = "A000000" + ctr + "";
            }
            else if ((ctr + "").Length == 4)
            {
                cID = "A00000" + ctr + "";
            }
            else if ((ctr + "").Length == 5)
            {
                cID = "A0000" + ctr + "";
            }
            else if ((ctr + "").Length == 6)
            {
                cID = "A000" + ctr + "";
            }
            else if ((ctr + "").Length == 7)
            {
                cID = "A00" + ctr + "";
            }
            else if ((ctr + "").Length == 8)
            {
                cID = "A0" + ctr + "";
            }
            else if ((ctr + "").Length == 9)
            {
                cID = "A" + ctr + "";
            }
            else
            {
                MessageBox.Show("Table in the database will not be able to handle more records.");
            }
            if (cID != "")
            {
                string gender = "";
                string bdate = cbYear.Text + "-" + (cbMonth.SelectedIndex + 1).ToString() + "-" + cbDay.Text;
                if (rbMale.Checked == true)
                {
                    gender = rbMale.Text;
                }
                else if (rbFemale.Checked == true)
                {
                    gender = rbFemale.Text;
                }
                cmd = "Insert into app_t (app_id, lname, fname, mname, position, gender, civilstat, contact, citizenship, birthdate, aheight, aweight, appstatus)"
                    + "values ('" + cID + "','" + txtLastName.Text + "','" + txtFirstName.Text + "','" + txtMiddleName.Text + "','"+cbPosition.Text+"','" + gender + "','" + cbCivilStat.Text + "','" + txtPhoneNumber.Text + "','Filipino','" + bdate + "','" + txtHeight.Text + "','" + txtWeight.Text + "','active');";
                com = new MySqlCommand(cmd, connection);
                com.ExecuteNonQuery();

                if (dgvEducBack.Rows.Count != 0)
                {
                    cmd = "insert into appschool_t values ";
                    for (int x = 0; x < dgvEducBack.Rows.Count; x++)
                    {
                        cmd += "('" + cID + "','" + dgvEducBack.Rows[x].Cells[0].Value.ToString() + "','"+ dgvEducBack.Rows[x].Cells[1].Value.ToString() +"','"+ dgvEducBack.Rows[x].Cells[2].Value.ToString() +"','"+ dgvEducBack.Rows[x].Cells[3].Value.ToString() +"','"+ dgvEducBack.Rows[x].Cells[4].Value.ToString() +"')";
                        if(x != dgvEducBack.Rows.Count - 1)
                        {
                            cmd += ",";
                        }
                    }
                    cmd += ";";
                    com = new MySqlCommand(cmd, connection);
                    com.ExecuteNonQuery();
                }

                if (dgvSkills.Rows.Count != 0)
                {
                    string cmd2 = "";
                    string sID = "";
                    cmd = "insert into appskills_t values ";
                    for (int x = 0; x < dgvSkills.Rows.Count; x++)
                    {
                        cmd2 = "Select skill_ID from Genskills_t where skillname = '"+ dgvSkills.Rows[x].Cells[0].Value.ToString() + "'";
                        com = new MySqlCommand(cmd2, connection);
                        dr = com.ExecuteReader();
                        while (dr.Read())
                        {
                            sID = dr[0].ToString();
                        }
                        dr.Close();
                        cmd += "('" + cID + "','" + sID + "','" + dgvSkills.Rows[x].Cells[1].Value.ToString() + "')";
                        if (x != dgvSkills.Rows.Count - 1)
                        {
                            cmd += ",";
                        }
                    }
                    cmd += ";";
                    com = new MySqlCommand(cmd, connection);
                    com.ExecuteNonQuery();
                }
                
                if (dgvEmpHistory.Rows.Count != 0)
                {
                    cmd = "insert into appworkex_t values ";
                    for (int x = 0; x < dgvEmpHistory.Rows.Count; x++)
                    {
                        cmd += "('" + cID + "','" + dgvEmpHistory.Rows[x].Cells[0].Value.ToString() + "','" + dgvEmpHistory.Rows[x].Cells[1].Value.ToString() + "','" + dgvEmpHistory.Rows[x].Cells[2].Value.ToString() +"','"
                            + dgvEmpHistory.Rows[x].Cells[3].Value.ToString() + "','" + dgvEmpHistory.Rows[x].Cells[4].Value.ToString() + "','"
                            + dgvEmpHistory.Rows[x].Cells[5].Value.ToString() + "','" + dgvEmpHistory.Rows[x].Cells[6].Value.ToString() + "')";
                        if (x != dgvEmpHistory.Rows.Count - 1)
                        {
                            cmd += ",";
                        }
                    }
                    cmd += ";";
                    com = new MySqlCommand(cmd, connection);
                    com.ExecuteNonQuery();
                }

                if (txtCityAddress.Text != "")
                {
                    cmd = "Insert into appaddress_t (app_id, addrss, addcat) values ('"+cID+"','"+txtCityAddress.Text+"','Current');";
                    com = new MySqlCommand(cmd, connection);
                    com.ExecuteNonQuery();
                }
                if (txtProvAdd.Text != "")
                {
                    cmd = "Insert into appaddress_t (app_id, addrss, addcat) values ('" + cID + "','" + txtProvAdd.Text + "','Provincial');";
                    com = new MySqlCommand(cmd, connection);
                    com.ExecuteNonQuery();
                }
                cmd = "Insert into apppersonal_t values ('"+cID+"','"+txtFather.Text+"','"+txtFAge.Text+"','"+txtFOccu.Text+"','"+ txtMother.Text+ "','"+txtMAge.Text+"','"+txtMOccu.Text+ "','" + txtSpouse.Text + "','" + txtSAge.Text + "','" + txtSOccu.Text + "');";
                com = new MySqlCommand(cmd, connection);
                com.ExecuteNonQuery();

                if(dgvChildren.Rows.Count != 0)
                {
                    cmd = "Insert into appchildren_t values";
                    for(int x = 0; x < dgvChildren.Rows.Count; x++)
                    {
                        cmd += "('"+cID+"','"+dgvChildren.Rows[x].Cells[0].Value.ToString()+"','"+ dgvChildren.Rows[x].Cells[1].Value.ToString() + "','"+ dgvChildren.Rows[x].Cells[2].Value.ToString() + "')";
                        if(x < dgvChildren.Rows.Count - 1)
                        {
                            cmd += ",";
                        }
                    }
                    cmd += ";";
                    com = new MySqlCommand(cmd, connection);
                    com.ExecuteNonQuery();
                }
                
                if(dgvContactPersons.Rows.Count != 0)
                {
                    cmd = "Insert into appcontact_t values";
                    for (int x = 0; x < dgvContactPersons.Rows.Count; x++)
                    {
                        cmd += "('" + cID + "','" + dgvContactPersons.Rows[x].Cells[0].Value.ToString() + "','" + dgvContactPersons.Rows[x].Cells[1].Value.ToString() + "')";
                        if (x < dgvChildren.Rows.Count - 1)
                        {
                            cmd += ",";
                        }
                    }
                    cmd += ";";
                    com = new MySqlCommand(cmd, connection);
                    com.ExecuteNonQuery();
                }
                MessageBox.Show("Applicant Added!", "New Applicant Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

            }
            connection.Close();
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

        #region btnSave_Click
        private void btnSave_Click(object sender, EventArgs e)
        {
            connection.Open();
            string gender2 = "";

            if (rbFemale2.Checked == true)
            {
                gender2 = rbFemale2.Text;
            }
            if (rbMale2.Checked == true)
            {
                gender2 = rbMale2.Text;
            }
            string bdate2 = cbYear2.Text + "-" + (cbMonth2.SelectedIndex + 1).ToString() + "-" + cbDay2.Text;

            if (txtAppNo.Text == "")
            {
                MessageBox.Show("Applicant Number must not be empty.", "Empty Applicant Number Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult rs = MessageBox.Show("Are you sure you want to update the record with the following details?", "Confirmation", MessageBoxButtons.YesNo);

                if (rs == DialogResult.Yes)
                {
                    cmd = "Update App_T set lname = '" + txtLastName2.Text + "', fname = '" + txtFirstName2.Text
                        + "', mname = '" + txtMiddleName2.Text + "', position = '" + cbPosition2.Text + "', gender = '" + gender2
                        + "', civilstat = '" + cbCivilStat2.Text + "', contact = '" + txtPhoneNumber2.Text
                        + "', birthdate = '" + bdate2 + "', aheight = '" + txtHeight2.Text
                        + "', aweight = '" + txtWeight2.Text + "' where app_id = '" + txtAppNo.Text + "';";
                    com = new MySqlCommand(cmd, connection);
                    com.ExecuteNonQuery();



                    MessageBox.Show("Changes Saved!", "Updated Employee Record!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtAppNo.Clear();
                    txtLastName2.Clear();
                    txtFirstName2.Clear();
                    txtMiddleName2.Clear();
                    cbPosition2.SelectedIndex = -1;
                    rbMale2.Checked = false;
                    rbFemale2.Checked = false;
                    cbCivilStat2.SelectedIndex = -1;
                    txtPhoneNumber2.Clear();
                    cbMonth2.SelectedIndex = -1;
                    cbDay2.SelectedIndex = -1;
                    cbYear2.SelectedIndex = -1;
                    txtHeight2.Clear();
                    txtWeight2.Clear();

                    this.Hide();
                }
            }
            connection.Close();





        }
        #endregion

        private void ucAppAddEdit_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            if(this.Visible == true)
            {
                connection.Open();
                cmd = "Select jobname from job_t;";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read()) 
                {
                    cbPosition.Items.Add(dr[0].ToString());
                    cbPosition2.Items.Add(dr[0].ToString());
                }
                dr.Close();

                cmd = "Select skillname from Genskills_t;";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cbSkills.Items.Add(dr[0].ToString());
                    cbSkills2.Items.Add(dr[0].ToString());
                }
                dr.Close();
                connection.Close();
            }
            else
            {
                cbPosition.Items.Clear();
                cbSkills.Items.Clear();
            }
        }

        #region Validations
        private void cbSchoolType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSchoolType.SelectedIndex == 2)
            {
                txtDegree.Enabled = true;
            }
            else
            {
                txtDegree.Enabled = false;
            }
        }

        private void txtLastName_Enter(object sender, EventArgs e)
        {
            txtLastName.Clear();
            txtLastName.ForeColor = Color.Black;
        }

        private void txtFirstName_Enter(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtFirstName.ForeColor = Color.Black;
        }

        private void txtMiddleName_Enter(object sender, EventArgs e)
        {
            txtMiddleName.Clear();
            txtMiddleName.ForeColor = Color.Black;
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDay.Items.Clear();
            if (cbMonth.SelectedIndex == 0 || cbMonth.SelectedIndex == 2 || cbMonth.SelectedIndex == 4 ||
                cbMonth.SelectedIndex == 6 || cbMonth.SelectedIndex == 7 || cbMonth.SelectedIndex == 9 ||
                cbMonth.SelectedIndex == 11)
            {
                for (int x = 1; x <= 31; x++)
                {
                    cbDay.Items.Add(x);
                }
            }
            else if (cbMonth.SelectedIndex == 3 || cbMonth.SelectedIndex == 5 || cbMonth.SelectedIndex == 8 ||
                cbMonth.SelectedIndex == 10)
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

        private void rbMale_Click(object sender, EventArgs e)
        {
            rbMale.Checked = true;
            rbFemale.Checked = false;
        }

        private void rbFemale_Click(object sender, EventArgs e)
        {
            rbMale.Checked = false;
            rbFemale.Checked = true;
        }

        private void txtYearStarted_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtYearEnded_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHeight_Enter(object sender, EventArgs e)
        {
            txtHeight.Clear();
            txtHeight.ForeColor = Color.Black;
        }

        private void txtWeight_Enter(object sender, EventArgs e)
        {
            txtWeight.Clear();
            txtWeight.ForeColor = Color.Black;
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMiddleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAddEduc_Click(object sender, EventArgs e)
        {
            if (txtSchoolName.Text != "" && cbSchoolType.Text != ""
                && txtYearStarted.Text != "" && txtYearEnded.Text != "")
            {
                dgvEducBack.ColumnCount = 5;
                dgvEducBack.Rows.Add(txtSchoolName.Text, cbSchoolType.Text, txtYearStarted.Text, txtYearEnded.Text, txtDegree.Text);
                txtSchoolName.Clear();
                cbSchoolType.SelectedIndex = -1;
                txtYearStarted.Clear();
                txtYearEnded.Clear();
                txtDegree.Clear();
            }
        }

        private void btnRemoveEduc_Click(object sender, EventArgs e)
        {
            if (dgvEducBack.Rows.Count != 0)
            {
                dgvEducBack.Rows.Remove(dgvEducBack.SelectedRows[0]);
            }
        }

        private void btnAddEmpHistory_Click(object sender, EventArgs e)
        {
            if (txtEmp.Text != "" && txtEmpAdd.Text != "" && txtPos.Text != "" && cbMonthStart.Text != "" && cbYearStart.Text != "" &&
                cbMonthEnd.Text != "" && cbYearEnd.Text != "")
            {
                dgvEmpHistory.ColumnCount = 7;
                dgvEmpHistory.Rows.Add(txtEmp.Text, txtEmpAdd.Text, txtPos.Text, cbMonthStart.Text, cbYearStart.Text, cbMonthEnd.Text, cbYearEnd.Text);
                txtEmp.Clear();
                txtEmpAdd.Clear();
                txtPos.Clear();
                cbMonthStart.SelectedIndex = -1;
                cbYearStart.SelectedIndex = -1;
                cbMonthEnd.SelectedIndex = -1;
                cbYearEnd.SelectedIndex = -1;
            }
        }

        private void btnRemoveEmpHistory_Click(object sender, EventArgs e)
        {
            if(dgvEmpHistory.Rows.Count != 0)
            {
                dgvEmpHistory.Rows.Remove(dgvEmpHistory.SelectedRows[0]);
            }
        }

        private void btnAddSkills_Click(object sender, EventArgs e)
        {
            if (cbSkills.SelectedIndex != -1 && cbProficiency.SelectedIndex != -1)
            {
                dgvSkills.ColumnCount = 2;
                dgvSkills.Rows.Add(cbSkills.Text, cbProficiency.Text);
                cbSkills.Items.Remove(cbSkills.Text);
                cbSkills.SelectedIndex = -1;
                cbProficiency.SelectedIndex = -1;
            }
        }

        private void btnRemoveSkills_Click(object sender, EventArgs e)
        {
            if (dgvSkills.Rows.Count != 0)
            {
                cbSkills.Items.Add(dgvSkills.SelectedRows[0].Cells[0].Value.ToString());
                dgvSkills.Rows.Remove(dgvSkills.SelectedRows[0]);
            }
        }

        private void btnAddChild_Click(object sender, EventArgs e)
        {
            if (txtChildName.Text != "" && cbChildMonth.Text != "" && cbChildDay.Text != "" &&
                cbChildYear.Text != "" && txtChildAge.Text != "")
            {
                dgvEmpHistory.ColumnCount = 3;
                dgvChildren.Rows.Add(txtChildName.Text, txtChildAge.Text, cbChildYear.Text + "-" + (cbChildMonth.SelectedIndex + 1).ToString() + "-" + cbChildDay.Text);
                txtChildName.Clear();
                cbChildMonth.SelectedIndex = -1;
                cbChildDay.SelectedIndex = -1;
                cbChildYear.SelectedIndex = -1;
                txtChildAge.Clear();
            }
        }

        private void btnRemoveChild_Click(object sender, EventArgs e)
        {
            if (dgvChildren.Rows.Count != 0)
            {
                dgvChildren.Rows.Remove(dgvChildren.SelectedRows[0]);
            }
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            if (txtContactPerson.Text != "" && txtContactNo.Text != "")
            {
                dgvContactPersons.ColumnCount = 2;
                dgvContactPersons.Rows.Add(txtContactPerson.Text, txtContactNo.Text);
                txtContactPerson.Clear();
                txtContactNo.Clear();
            }
        }

        private void btnRemoveContact_Click(object sender, EventArgs e)
        {
            if (dgvContactPersons.Rows.Count != 0)
            {
                dgvContactPersons.Rows.Remove(dgvContactPersons.SelectedRows[0]);
            }
        }

        private void cbChildMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbChildDay.Items.Clear();
            if (cbChildMonth.SelectedIndex == 0 || cbChildMonth.SelectedIndex == 2 || cbChildMonth.SelectedIndex == 4 ||
                cbChildMonth.SelectedIndex == 6 || cbChildMonth.SelectedIndex == 7 || cbChildMonth.SelectedIndex == 9 ||
                cbChildMonth.SelectedIndex == 11)
            {
                for (int x = 1; x <= 31; x++)
                {
                    cbChildDay.Items.Add(x);
                }
            }
            else if (cbChildMonth.SelectedIndex == 3 || cbChildMonth.SelectedIndex == 5 || cbChildMonth.SelectedIndex == 8 ||
                cbChildMonth.SelectedIndex == 10)
            {
                for (int x = 1; x <= 30; x++)
                {
                    cbChildDay.Items.Add(x);
                }
            }
            else
            {
                for (int x = 1; x <= 28; x++)
                {
                    cbChildDay.Items.Add(x);
                }
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[a-zA-Z ]*$").IsMatch(txtLastName.Text)))
            {
                txtLastName.Text = "";
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[a-zA-Z ]*$").IsMatch(txtFirstName.Text)))
            {
                txtFirstName.Text = "";
            }
        }

        private void txtMiddleName_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[a-zA-Z ]*$").IsMatch(txtMiddleName.Text)))
            {
                txtMiddleName.Text = "";
            }
        }

        private void txtDegree_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[a-zA-Z ]*$").IsMatch(txtDegree.Text)))
            {
                txtDegree.Text = "";
            }
        }

        private void txtPos_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[a-zA-Z ]*$").IsMatch(txtPos.Text)))
            {
                txtPos.Text = "";
            }
        }

        private void txtFather_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[a-zA-Z ]*$").IsMatch(txtFather.Text)))
            {
                txtFather.Text = "";
            }
        }

        private void txtMother_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[a-zA-Z ]*$").IsMatch(txtMother.Text)))
            {
                txtMother.Text = "";
            }
        }

        private void txtSpouse_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[a-zA-Z ]*$").IsMatch(txtSpouse.Text)))
            {
                txtSpouse.Text = "";
            }
        }

        private void txtFOccu_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[a-zA-Z ]*$").IsMatch(txtFOccu.Text)))
            {
                txtFOccu.Text = "";
            }
        }

        private void txtMOccu_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[a-zA-Z ]*$").IsMatch(txtMOccu.Text)))
            {
                txtMOccu.Text = "";
            }
        }

        private void txtSOccu_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[a-zA-Z ]*$").IsMatch(txtSOccu.Text)))
            {
                txtSOccu.Text = "";
            }
        }

        private void txtChildName_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[a-zA-Z ]*$").IsMatch(txtChildName.Text)))
            {
                txtChildName.Text = "";
            }
        }

        private void txtContactPerson_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[a-zA-Z ]*$").IsMatch(txtContactPerson.Text)))
            {
                txtContactPerson.Text = "";
            }
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cbSchoolType2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSchoolType2.SelectedIndex == 2)
            {
                txtDegree2.Enabled = true;
            }
            else
            {
                txtDegree2.Enabled = false;
            }
        }

        private void txtLastName2_Enter(object sender, EventArgs e)
        {
            txtLastName2.Clear();
            txtLastName2.ForeColor = Color.Black;
        }

        private void txtFirstName2_Enter(object sender, EventArgs e)
        {
            txtFirstName2.Clear();
            txtFirstName2.ForeColor = Color.Black;
        }

        private void txtMiddleName2_Enter(object sender, EventArgs e)
        {
            txtMiddleName2.Clear();
            txtMiddleName2.ForeColor = Color.Black;
        }

        private void cbMonth2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDay2.Items.Clear();
            if (cbMonth2.SelectedIndex == 0 || cbMonth2.SelectedIndex == 2 || cbMonth2.SelectedIndex == 4 ||
                cbMonth2.SelectedIndex == 6 || cbMonth2.SelectedIndex == 7 || cbMonth2.SelectedIndex == 9 ||
                cbMonth2.SelectedIndex == 11)
            {
                for (int x = 1; x <= 31; x++)
                {
                    cbDay2.Items.Add(x);
                }
            }
            else if (cbMonth2.SelectedIndex == 3 || cbMonth2.SelectedIndex == 5 || cbMonth2.SelectedIndex == 8 ||
                cbMonth2.SelectedIndex == 10)
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

        private void rbMale2_Click(object sender, EventArgs e)
        {
            rbMale2.Checked = true;
            rbFemale2.Checked = false;
        }

        private void rbFemale2_Click(object sender, EventArgs e)
        {
            rbMale2.Checked = false;
            rbFemale2.Checked = true;
        }

        private void txtYearStarted2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtYearEnded2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHeight2_Enter(object sender, EventArgs e)
        {
            txtHeight.Clear();
            txtHeight.ForeColor = Color.Black;
        }

        private void txtWeight2_Enter(object sender, EventArgs e)
        {
            txtWeight.Clear();
            txtWeight.ForeColor = Color.Black;
        }

        private void txtLastName2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFirstName2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMiddleName2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbChildMonth2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbChildDay.Items.Clear();
            if (cbChildMonth2.SelectedIndex == 0 || cbChildMonth2.SelectedIndex == 2 || cbChildMonth2.SelectedIndex == 4 ||
                cbChildMonth2.SelectedIndex == 6 || cbChildMonth2.SelectedIndex == 7 || cbChildMonth2.SelectedIndex == 9 ||
                cbChildMonth2.SelectedIndex == 11)
            {
                for (int x = 1; x <= 31; x++)
                {
                    cbChildDay2.Items.Add(x);
                }
            }
            else if (cbChildMonth2.SelectedIndex == 3 || cbChildMonth2.SelectedIndex == 5 || cbChildMonth2.SelectedIndex == 8 ||
                cbChildMonth2.SelectedIndex == 10)
            {
                for (int x = 1; x <= 30; x++)
                {
                    cbChildDay2.Items.Add(x);
                }
            }
            else
            {
                for (int x = 1; x <= 28; x++)
                {
                    cbChildDay2.Items.Add(x);
                }
            }
        }

        private void btnAddEduc2_Click(object sender, EventArgs e)
        {
            if (txtSchoolName2.Text != "" && cbSchoolType2.Text != ""
                && txtYearStarted2.Text != "" && txtYearEnded2.Text != "")
            {
                dgvEducBack2.ColumnCount = 5;
                dgvEducBack2.Rows.Add(txtSchoolName2.Text, cbSchoolType2.Text, txtYearStarted2.Text, txtYearEnded2.Text, txtDegree2.Text);
                txtSchoolName2.Clear();
                cbSchoolType2.SelectedIndex = -1;
                txtYearStarted2.Clear();
                txtYearEnded2.Clear();
                txtDegree2.Clear();
            }
        }

        private void btnRemoveEduc2_Click(object sender, EventArgs e)
        {
            if (dgvEducBack2.Rows.Count != 0)
            {
                dgvEducBack2.Rows.Remove(dgvEducBack2.SelectedRows[0]);
            }
        }

        private void btnAddEmpHistory2_Click(object sender, EventArgs e)
        {
            if (txtEmp2.Text != "" && txtEmpAdd2.Text != "" && txtPos2.Text != "" && cbMonthStart2.Text != "" && cbYearStart2.Text != "" &&
                cbMonthEnd2.Text != "" && cbYearEnd2.Text != "")
            {
                dgvEmpHistory2.ColumnCount = 7;
                dgvEmpHistory2.Rows.Add(txtEmp2.Text, txtEmpAdd2.Text, txtPos2.Text, cbMonthStart2.Text, cbYearStart2.Text, cbMonthEnd2.Text, cbYearEnd2.Text);
                txtEmp2.Clear();
                txtEmpAdd2.Clear();
                txtPos2.Clear();
                cbMonthStart2.SelectedIndex = -1;
                cbYearStart2.SelectedIndex = -1;
                cbMonthEnd2.SelectedIndex = -1;
                cbYearEnd2.SelectedIndex = -1;
            }
        }

        private void btnRemoveEmpHistory2_Click(object sender, EventArgs e)
        {
            if (dgvEmpHistory2.Rows.Count != 0)
            {
                dgvEmpHistory2.Rows.Remove(dgvEmpHistory.SelectedRows[0]);
            }
        }

        private void btnAddSkills2_Click(object sender, EventArgs e)
        {
            if (cbSkills2.SelectedIndex != -1 && cbProficiency2.SelectedIndex != -1)
            {
                dgvSkills2.ColumnCount = 2;
                dgvSkills2.Rows.Add(cbSkills2.Text, cbProficiency2.Text);
                cbSkills2.Items.Remove(cbSkills2.Text);
                cbSkills2.SelectedIndex = -1;
                cbProficiency2.SelectedIndex = -1;
            }
        }

        private void btnRemoveSkills2_Click(object sender, EventArgs e)
        {
            if (dgvSkills2.Rows.Count != 0)
            {
                cbSkills2.Items.Add(dgvSkills2.SelectedRows[0].Cells[0].Value.ToString());
                dgvSkills2.Rows.Remove(dgvSkills2.SelectedRows[0]);
            }
        }

        private void btnAddChild2_Click(object sender, EventArgs e)
        {
            if (txtChildName2.Text != "" && cbChildMonth2.Text != "" && cbChildDay2.Text != "" &&
               cbChildYear2.Text != "" && txtChildAge2.Text != "")
            {
                dgvEmpHistory2.ColumnCount = 3;
                dgvChildren2.Rows.Add(txtChildName2.Text, txtChildAge2.Text, cbChildYear2.Text + "-" + (cbChildMonth2.SelectedIndex + 1).ToString() + "-" + cbChildDay2.Text);
                txtChildName2.Clear();
                cbChildMonth2.SelectedIndex = -1;
                cbChildDay2.SelectedIndex = -1;
                cbChildYear2.SelectedIndex = -1;
                txtChildAge2.Clear();
            }
        }

        private void btnRemoveChild2_Click(object sender, EventArgs e)
        {
            if (dgvChildren2.Rows.Count != 0)
            {
                dgvChildren2.Rows.Remove(dgvChildren2.SelectedRows[0]);
            }
        }

        private void btnAddContact2_Click(object sender, EventArgs e)
        {
            if (txtContactPerson2.Text != "" && txtContactNo2.Text != "")
            {
                dgvContactPersons2.ColumnCount = 2;
                dgvContactPersons2.Rows.Add(txtContactPerson2.Text, txtContactNo2.Text);
                txtContactPerson2.Clear();
                txtContactNo2.Clear();
            }
        }

        private void btnRemoveContact2_Click(object sender, EventArgs e)
        {
            if (dgvContactPersons2.Rows.Count != 0)
            {
                dgvContactPersons2.Rows.Remove(dgvContactPersons2.SelectedRows[0]);
            }
        }
        #endregion Validations
    }
}
