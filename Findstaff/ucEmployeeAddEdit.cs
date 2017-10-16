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
    public partial class ucEmployeeAddEdit : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();
        MySqlDataReader dr;
        string cmd = "";

        public ucEmployeeAddEdit()
        {
            InitializeComponent();
            panel1.Dock = DockStyle.Fill;
            panel2.Dock = DockStyle.Fill;
        }

        #region btnAdd_Click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            connection.Open();
            string mname = "", gender = "", existuser = "", existname = "";
            if (txtMiddleName.Text == "Middle Name" || txtMiddleName.Text == "")
            {
                mname = "";
            }
            else
            {
                mname = txtMiddleName.Text;
            }
            if(lblUserStatus.Text == "" && lblPassStatus.Text == "" && lblConPassStatus.Text == "" &&
                lblLNameStatus.Text == "" && lblFNameStatus.Text == "" && lblGenderStatus.Text == "" &&
                lblBirthdayStatus.Text == "" && lblAddressStatus.Text == "" && lblContactStatus.Text == "" &&
                lblDeptStatus.Text == "")
            {
                cmd = "select username from emp_t where username = '"+txtUsername.Text+"'";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    existuser = dr[0].ToString();
                }
                dr.Close();
                cmd = "select fname, mname, lname from emp_t where fname = '"+txtFirstName.Text+"' and  mname = '" + txtMiddleName.Text + "' and lname =  '" + txtLastName.Text + "'";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    existname = dr[0].ToString();
                }
                dr.Close();
                if (existuser != "")
                {
                    MessageBox.Show("Username already exists.","Existing Username Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(existname != "")
                    {
                        MessageBox.Show("Employee already exists.", "Existing Employee Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (rbFemale.Checked == true)
                        {
                            gender = rbFemale.Text;
                        }
                        if (rbMale.Checked == true)
                        {
                            gender = rbMale.Text;
                        }
                        string bdate = cbYear.Text + "-" + (cbMonth.SelectedIndex + 1).ToString() + "-" + cbDay.Text;
                        cmd = "Insert into emp_t(Username, pass, lname, fname, mname, gender, birthdate, addrss, contact, deptname) values" +
                                " ('" + txtUsername.Text + "','" + txtPass.Text
                                + "','" + txtLastName.Text + "','" + txtFirstName.Text
                                + "','" + mname + "','" + gender + "','" + bdate + "', '" + txtAddress.Text
                                + "','" + txtContact.Text + "','" + cbDept.Text + "')";
                        com = new MySqlCommand(cmd, connection);
                        com.ExecuteNonQuery();
                        MessageBox.Show("Added!", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUsername.Clear();
                        lblUserStatus.Text = "*";
                        txtPass.Clear();
                        lblPassStatus.Text = "*";
                        txtConPass.Clear();
                        lblConPassStatus.Text = "*";
                        txtLastName.Text = "Last Name";
                        lblLNameStatus.Text = "*";
                        txtLastName.ForeColor = Color.Gray;
                        txtLastName.Font = new Font(txtLastName.Font, FontStyle.Italic);
                        txtFirstName.Text = "First Name";
                        lblFNameStatus.Text = "*";
                        txtFirstName.ForeColor = Color.Gray;
                        txtFirstName.Font = new Font(txtFirstName.Font, FontStyle.Italic);
                        txtMiddleName.Text = "Middle Name";
                        txtMiddleName.ForeColor = Color.Gray;
                        txtMiddleName.Font = new Font(txtMiddleName.Font, FontStyle.Italic);
                        rbMale.Checked = false;
                        rbFemale.Checked = false;
                        lblGenderStatus.Text = "*";
                        cbMonth.SelectedIndex = -1;
                        cbDay.Items.Clear();
                        cbYear.SelectedIndex = -1;
                        lblBirthdayStatus.Text = "*";
                        txtAddress.Text = "House Number, Street, City/Province";
                        txtAddress.ForeColor = Color.Gray;
                        txtAddress.Font = new Font(txtAddress.Font, FontStyle.Italic);
                        lblAddressStatus.Text = "*";
                        txtContact.Clear();
                        lblContactStatus.Text = "*";
                        cbDept.SelectedIndex = -1;
                        lblDeptStatus.Text = "*";
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("Errors still present!\nCannot add employee record.","Add Employee Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            lblUserStatus.Text = "*";
            txtPass.Clear();
            lblPassStatus.Text = "*";
            txtConPass.Clear();
            lblConPassStatus.Text = "*";
            txtLastName.Text = "Last Name";
            lblLNameStatus.Text = "*";
            txtLastName.ForeColor = Color.Gray;
            txtLastName.Font = new Font(txtLastName.Font, FontStyle.Italic);
            txtFirstName.Text = "First Name";
            lblFNameStatus.Text = "*";
            txtFirstName.ForeColor = Color.Gray;
            txtFirstName.Font = new Font(txtFirstName.Font, FontStyle.Italic);
            txtMiddleName.Text = "Middle Name";
            txtMiddleName.ForeColor = Color.Gray;
            txtMiddleName.Font = new Font(txtMiddleName.Font, FontStyle.Italic);
            rbMale.Checked = false;
            rbFemale.Checked = false;
            lblGenderStatus.Text = "*";
            cbMonth.SelectedIndex = -1;
            cbDay.Items.Clear();
            cbYear.SelectedIndex = -1;
            lblBirthdayStatus.Text = "*";
            txtAddress.Text = "House Number, Street, City/Province";
            txtAddress.ForeColor = Color.Gray;
            txtAddress.Font = new Font(txtAddress.Font, FontStyle.Italic);
            lblAddressStatus.Text = "*";
            txtContact.Clear();
            lblContactStatus.Text = "*";
            cbDept.SelectedIndex = -1;
            lblDeptStatus.Text = "*";
            this.Hide();
        }
        #endregion

        #region btnSave2_Click
        private void btnSave2_Click(object sender, EventArgs e)
        {
            connection.Open();
            string mname2 = "", gender2 = "";

            if (txtMiddleName2.Text == "Middle Name" || txtMiddleName2.Text == "")
            {
                mname2 = "";
            }
            else
            {
                mname2 = txtMiddleName2.Text;
            }
                    if (rbFemale2.Checked == true)
                    {
                        gender2 = rbFemale2.Text;
                    }
                    if (rbMale2.Checked == true)
                    {
                        gender2 = rbMale2.Text;
                    }
                    string bdate2 = cbYear2.Text + "-" + (cbMonth2.SelectedIndex + 1).ToString() + "-" + cbDay2.Text;

            if (txtUsername2.Text == "")
            {
                MessageBox.Show("Username must not be empty.", "Empty Username Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult rs = MessageBox.Show("Are you sure you want to update the record with the following details?"
                    + "\nEmployee ID.: " + txtEmpId.Text + "\nNew Username: " + txtUsername2.Text
                    + "\nNew Password: " + txtPassword2.Text + "\nLast Name: " + txtLastName2.Text
                    + "\nFirst Name: " + txtFirstName2.Text + "\nMiddle Name: " + txtMiddleName2.Text
                    + "\nGender: " + gender2 + "\nBirthday: " + bdate2
                    + "\nAddress: " + txtAddress2.Text + "\nContact Number: " + txtContact2.Text
                    + "\nDepartment: " + cbDept2.Text, "Confirmation", MessageBoxButtons.YesNo);

                if (rs == DialogResult.Yes)
                {
                    cmd = "Update Emp_T set Username = '" + txtUsername2.Text + "', pass = '" + txtPassword2.Text
                        + "', lname = '" + txtLastName2.Text + "', fname = '" + txtFirstName2.Text
                        + "', mname = '" + txtMiddleName2.Text + "', gender = '" + gender2
                        + "', birthdate = '" + bdate2 + "', addrss = '" + txtAddress2.Text
                        + "', deptname = '" + cbDept2.Text + "' where emp_id = '" + txtEmpId.Text + "';";
                    com = new MySqlCommand(cmd, connection);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Changes Saved!", "Updated Employee Record!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtEmpId.Clear();
                    txtUsername2.Clear();
                    txtPassword2.Clear();
                    txtLastName2.Clear();
                    txtFirstName2.Clear();
                    txtMiddleName2.Clear();
                    rbMale2.Checked = false;
                    rbFemale2.Checked = false;
                    cbMonth2.SelectedIndex = -1;
                    cbDay2.SelectedIndex = -1;
                    cbYear2.SelectedIndex = -1;
                    txtAddress2.Clear();
                    txtContact2.Clear();
                    cbDept2.SelectedIndex = -1;
                    this.Hide();
                }
            }
            connection.Close();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            txtUsername2.Clear();
            lblUserStatus2.Text = "*";
            txtPassword2.Clear();
            lblPassStatus2.Text = "*";
            txtConPass2.Clear();
            lblConPassStatus2.Text = "*";
            txtLastName2.Text = "Last Name";
            lblLNameStatus2.Text = "*";
            txtLastName2.ForeColor = Color.Gray;
            txtLastName2.Font = new Font(txtLastName.Font, FontStyle.Italic);
            txtFirstName2.Text = "First Name";
            lblFNameStatus2.Text = "*";
            txtFirstName2.ForeColor = Color.Gray;
            txtFirstName2.Font = new Font(txtFirstName.Font, FontStyle.Italic);
            txtMiddleName2.Text = "Middle Name";
            txtMiddleName2.ForeColor = Color.Gray;
            txtMiddleName2.Font = new Font(txtMiddleName.Font, FontStyle.Italic);
            rbMale2.Checked = false;
            rbFemale2.Checked = false;
            lblGenderStatus2.Text = "*";
            cbMonth2.SelectedIndex = -1;
            cbDay2.Items.Clear();
            cbYear2.SelectedIndex = -1;
            lblBirthdayStatus2.Text = "*";
            txtAddress2.Text = "House Number, Street, City/Province";
            txtAddress2.ForeColor = Color.Gray;
            txtAddress2.Font = new Font(txtAddress.Font, FontStyle.Italic);
            lblAddressStatus2.Text = "*";
            txtContact2.Clear();
            lblContactStatus2.Text = "*";
            cbDept2.SelectedIndex = -1;
            lblDeptStatus2.Text = "*";
            this.Hide();
        }
        #endregion

        #region Validations
        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsSymbol(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar)|| Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsSymbol(e.KeyChar) || Char.IsDigit(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsSymbol(e.KeyChar) || Char.IsDigit(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMiddleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsSymbol(e.KeyChar) || Char.IsDigit(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsSymbol(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsPunctuation(e.KeyChar)
                || Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDay.Items.Clear();
            if (cbMonth.SelectedIndex == 0 || cbMonth.SelectedIndex == 2 || cbMonth.SelectedIndex == 4 ||
                cbMonth.SelectedIndex == 6 || cbMonth.SelectedIndex == 7 || cbMonth.SelectedIndex == 9 ||
                cbMonth.SelectedIndex == 11)
            {
                for(int x = 1; x<= 31; x++)
                {
                    cbDay.Items.Add(x);
                }
            }
            else if(cbMonth.SelectedIndex == 3 || cbMonth.SelectedIndex == 5 || cbMonth.SelectedIndex == 8 ||
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
            BirthdayChecker();
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsSymbol(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtConPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsSymbol(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLastName_Enter(object sender, EventArgs e)
        {
            txtLastName.ForeColor = Color.Black;
            txtLastName.Font = new Font(txtLastName.Font, FontStyle.Regular);
            txtLastName.Clear();
        }

        private void txtFirstName_Enter(object sender, EventArgs e)
        {
            txtFirstName.ForeColor = Color.Black;
            txtFirstName.Font = new Font(txtLastName.Font, FontStyle.Regular);
            txtFirstName.Clear();
        }

        private void txtMiddleName_Enter(object sender, EventArgs e)
        {
            txtMiddleName.ForeColor = Color.Black;
            txtMiddleName.Font = new Font(txtLastName.Font, FontStyle.Regular);
            txtMiddleName.Clear();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length >= 8)
            {
                lblUserStatus.Text = "";
            }
            else if (txtUsername.Text.Length == 0)
            {
                lblUserStatus.Text = "* Field Required!";
            }
            else
            {
                lblUserStatus.Text = "* Username must be at least 8 characters!";
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (txtPass.Text.Length >= 8)
            {
                lblPassStatus.Text = "";
            }
            else if (txtPass.Text.Length == 0)
            {
                lblPassStatus.Text = "* Field Required!";
            }
            else
            {
                lblPassStatus.Text = "* Password must be at least 8 characters!";
            }
        }

        private void txtConPass_TextChanged(object sender, EventArgs e)
        {
            if (txtConPass.Text.Length >= 8)
            {
                lblConPassStatus.Text = "";
                if (txtPass.Text != txtConPass.Text)
                {
                    lblConPassStatus.Text = "* Passwords not matching!";
                }
            }
            else if (txtConPass.Text.Length == 0)
            {
                lblConPassStatus.Text = "* Field Required!";
            }
            else
            {
                lblConPassStatus.Text = "* Password must be at least 8 characters!";
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[a-zA-Z ]*$").IsMatch(txtLastName.Text)))
            {
                txtLastName.Text = "";
            }

            if (txtLastName.Text != "")
            {
                lblLNameStatus.Text = "";
            }
            else
            {
                lblLNameStatus.Text = "* Field Required!";
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[a-zA-Z ]*$").IsMatch(txtFirstName.Text)))
            {
                txtFirstName.Text = "";
            }

            if (txtFirstName.Text != "")
            {
                lblFNameStatus.Text = "";
            }
            else
            {
                lblFNameStatus.Text = "* Field Required!";
            }
        }

        private void txtAddress_Enter(object sender, EventArgs e)
        {
            txtAddress.ForeColor = Color.Black;
            txtAddress.Font = new Font(txtAddress.Font, FontStyle.Regular);
            txtAddress.Clear();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (txtAddress.Text != "")
            {
                lblAddressStatus.Text = "";
            }
            else
            {
                lblAddressStatus.Text = "* Field Required!";
            }
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            if (txtContact.Text.Length == 7 || txtContact.Text.Length == 11)
            {
                lblContactStatus.Text = "";
            }
            else if (txtContact.Text.Length != 7 || txtContact.Text.Length != 11)
            {
                lblContactStatus.Text = "* Incorrect contact format!";
            }
            else
            {
                lblContactStatus.Text = "* Field Required!";
            }
        }

        private void cbDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbDept.SelectedIndex != -1)
            {
                lblDeptStatus.Text = "";
            }
        }

        private void BirthdayChecker()
        {
            if(cbMonth.Text != "" && cbDay.Text != "" && cbYear.Text != "")
            {
                lblBirthdayStatus.Text = "";
            }
            else
            {
                lblBirthdayStatus.Text = "* Complete Birthdate!";
            }
        }

        private void BirthdayChecker2()
        {
            if (cbMonth2.Text != "" && cbDay2.Text != "" && cbYear2.Text != "")
            {
                lblBirthdayStatus2.Text = "";
            }
            else
            {
                lblBirthdayStatus2.Text = "* Complete Birthdate!";
            }
        }

        private void cbDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            BirthdayChecker();
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            BirthdayChecker();
        }

        private void rbMale_Click(object sender, EventArgs e)
        {
            rbFemale.Checked = false;
            rbMale.Checked = true;
            lblGenderStatus.Text = "";
        }

        private void rbFemale_Click(object sender, EventArgs e)
        {
            rbMale.Checked = false;
            rbFemale.Checked = true;
            lblGenderStatus.Text = "";
        }

        private void ucEmployeeAddEdit_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
        }

        private void txtMiddleName_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[a-zA-Z ]*$").IsMatch(txtMiddleName.Text)))
            {
                txtMiddleName.Text = "";
            }
        }

        private void txtLastName2_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[a-zA-Z ]*$").IsMatch(txtLastName2.Text)))
            {
                txtLastName2.Text = "";
            }

            if (txtLastName2.Text != "")
            {
                lblLNameStatus2.Text = "";
            }
            else
            {
                lblLNameStatus2.Text = "* Field Required!";
            }
        }

        private void txtFirstName2_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[a-zA-Z ]*$").IsMatch(txtFirstName2.Text)))
            {
                txtFirstName2.Text = "";
            }

            if (txtFirstName2.Text != "")
            {
                lblFNameStatus2.Text = "";
            }
            else
            {
                lblFNameStatus2.Text = "* Field Required!";
            }
        }

        private void txtMiddleName2_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[a-zA-Z ]*$").IsMatch(txtMiddleName2.Text)))
            {
                txtMiddleName2.Text = "";
            }
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
            BirthdayChecker2();
        }

        private void cbDay2_SelectedIndexChanged(object sender, EventArgs e)
        {
            BirthdayChecker2();
        }

        private void cbYear2_SelectedIndexChanged(object sender, EventArgs e)
        {
            BirthdayChecker2();
        }

        private void txtAddress2_TextChanged(object sender, EventArgs e)
        {
            if (txtAddress2.Text != "")
            {
                lblAddressStatus2.Text = "";
            }
            else
            {
                lblAddressStatus2.Text = "* Field Required!";
            }
        }

        private void txtContact2_TextChanged(object sender, EventArgs e)
        {
            if (txtContact2.Text.Length == 7 || txtContact2.Text.Length == 11)
            {
                lblContactStatus2.Text = "";
            }
            else if (txtContact2.Text.Length != 7 || txtContact2.Text.Length != 11)
            {
                lblContactStatus2.Text = "* Incorrect contact format!";
            }
            else
            {
                lblContactStatus2.Text = "* Field Required!";
            }
        }

        private void cbDept2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDept2.SelectedIndex != -1)
            {
                lblDeptStatus2.Text = "";
            }
        }

        private void txtConPass2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsSymbol(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPassword2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsSymbol(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtContact2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsSymbol(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLastName2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsSymbol(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFirstName2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsSymbol(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMiddleName2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsSymbol(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtConPass2_TextChanged(object sender, EventArgs e)
        {
            if (txtConPass2.Text.Length >= 8)
            {
                lblConPassStatus2.Text = "";
                if (txtPassword2.Text != txtConPass2.Text)
                {
                    lblConPassStatus2.Text = "* Passwords not matching!";
                }
            }
            else if (txtConPass2.Text.Length == 0)
            {
                lblConPassStatus2.Text = "* Field Required!";
            }
            else
            {
                lblConPassStatus2.Text = "* Password must be at least 8 characters!";
            }
        }

        private void txtPassword2_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword2.Text.Length >= 8)
            {
                lblPassStatus2.Text = "";
            }
            else if (txtPassword2.Text.Length == 0)
            {
                lblPassStatus2.Text = "* Field Required!";
            }
            else
            {
                lblPassStatus2.Text = "* Password must be at least 8 characters!";
            }
        }

        private void txtUsername2_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername2.Text.Length >= 8)
            {
                lblUserStatus2.Text = "";
            }
            else if (txtUsername2.Text.Length == 0)
            {
                lblUserStatus2.Text = "* Field Required!";
            }
            else
            {
                lblUserStatus2.Text = "* Username must be at least 8 characters!";
            }
        }

        private void rbMale2_Click(object sender, EventArgs e)
        {
            rbFemale2.Checked = false;
            rbMale2.Checked = true;
            lblGenderStatus2.Text = "";
        }

        private void rbFemale2_Click(object sender, EventArgs e)
        {
            rbMale2.Checked = false;
            rbFemale2.Checked = true;
            lblGenderStatus2.Text = "";
        }
    }
    #endregion
}
