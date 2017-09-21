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
                        int ctr = 0;
                        string cID = "";
                        string cou = "select count(*) from emp_t;";
                        com = new MySqlCommand(cou, connection);
                        ctr = int.Parse(com.ExecuteScalar() + "");
                        if ((ctr + "").Length == 1)
                        {
                            cID = "E0000" + ctr + "";
                        }
                        else if ((ctr + "").Length == 2)
                        {
                            cID = "E000" + ctr + "";
                        }
                        else if ((ctr + "").Length == 3)
                        {
                            cID = "E00" + ctr + "";
                        }
                        else if ((ctr + "").Length == 4)
                        {
                            cID = "E0" + ctr + "";
                        }
                        else if ((ctr + "").Length == 5)
                        {
                            cID = "E" + ctr + "";
                        }
                        else
                        {
                            MessageBox.Show("Table in the database will not be able to handle more records.");
                        }
                        if (cID != "")
                        {
                            cmd = "Insert into emp_t(emp_id, Username, pass, lname, fname, mname, gender, birthdate, addrss, contact, deptname) values"+
                                " ('" + cID + "','" + txtUsername.Text + "','" + txtPass.Text 
                                + "','" + txtLastName.Text + "','" + txtFirstName.Text 
                                + "','" + mname + "','" + gender + "','" + bdate + "', '"+txtAddress.Text
                                +"','" + txtContact.Text + "','" + cbDept.Text + "')";
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

        private void panel2_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();
            string query = "SELECT * FROM EMP_T;";
            com = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = com.ExecuteReader();
            while (dataReader.Read())
            {
                txtUsername2.Text = dataReader.GetString(1);
                txtPassword2.Text = dataReader.GetString(2);
                txtLastName2.Text = dataReader.GetString(3);
                txtFirstName2.Text = dataReader.GetString(4);
                txtMiddleName2.Text = dataReader.GetString(5);
                if (dataReader.GetString(6) == "Male")
                {
                    rbMale2.Select();
                }
                else
                {
                    rbFemale2.Select();
                }
                txtAddress2.Text = dataReader.GetString(8);
                txtContact2.Text = dataReader.GetString(9);
                cbDept2.SelectedItem = Convert.ToString(dataReader.GetString(10));
            }
            dataReader.Close();
            connection.Close();

            //connection.Open();
            //string query1 = "select datepart(mm, birthday), datepart(dd, birthday), datepart(yyyy, birthday) from emp_t";
            //MySqlCommand com1 = new MySqlCommand(query1, connection);
            //MySqlDataReader dataReader1 = com1.ExecuteReader();
            //while (dataReader1.Read())
            //{
            //    cbMonth.SelectedItem = Convert.ToString(dataReader1.GetDateTime(7));
            //    cbDay.SelectedItem = Convert.ToString(dataReader1.GetDateTime(7));
            //    cbYear.SelectedItem = Convert.ToString(dataReader1.GetDateTime(7));
            //}
            //dataReader1.Close();
            //connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string empId = "",
                uname = "",
                pword = "",
                lname = "",
                fname = "",
                mname = "",
                gender = "",
                bday = "",
                address = "",
                contact = "",
                dept = "";

            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();
            string query = "SELECT * FROM EMP_T";
            MySqlCommand com = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = com.ExecuteReader();
            while (dataReader.Read())
            {
                empId = dataReader.GetString(0);
                uname = dataReader.GetString(1);
                pword = dataReader.GetString(2);
                lname = dataReader.GetString(3);
                fname = dataReader.GetString(4);
                mname = dataReader.GetString(5);
                gender = dataReader.GetString(6);
                bday = dataReader.GetString(7);
                address = dataReader.GetString(8);
                contact = dataReader.GetString(9);
                dept = dataReader.GetString(10);
            }
            dataReader.Close();
            connection.Close();

            empId = txtEmpId.Text;
            uname = txtUsername2.Text;
            pword = txtPassword2.Text;
            lname = txtLastName.Text;
            fname = txtFirstName.Text;
            mname = txtMiddleName.Text;
            if (rbMale.Checked)
            {
                gender = "Male";
            }
            else if (rbFemale.Checked)
            {
                gender = "Female";
            }
            //bday = 
            address = txtAddress.Text;
            contact = txtContact2.Text;
            dept = cbDept2.SelectedItem.ToString();

            connection.Open();
            string query1 = "UPDATE EMP_T SET USERNAME = '" + uname + "', PASS = '"+ pword +"', LNAME = '"+ lname +"', FNAME = '" +
                fname + "', MNAME = '" + mname + "', GENDER = '" + gender + "', ADDRSS = '" + address + "', CONTACT = '" +
                contact + "', DEPTNAME = '" + dept + "' WHERE EMP_ID = '" + empId + "')";
            MySqlCommand com1 = new MySqlCommand(query1, connection);
            com1.ExecuteNonQuery();
            connection.Close();
            
            MessageBox.Show("Saved!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
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

        #region
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
        }

        private void txtFirstName2_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[a-zA-Z ]*$").IsMatch(txtFirstName2.Text)))
            {
                txtFirstName2.Text = "";
            }
        }

        private void txtMiddleName2_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[a-zA-Z ]*$").IsMatch(txtMiddleName2.Text)))
            {
                txtMiddleName2.Text = "";
            }
        }
        #endregion
    }
}
