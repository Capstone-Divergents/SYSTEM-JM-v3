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
    public partial class ucEmployerAddEdit : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();
        MySqlDataReader dr;

        public ucEmployerAddEdit()
        {
            InitializeComponent();
            panel1.Dock = DockStyle.Fill;
            panel2.Dock = DockStyle.Fill;
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            connection.Open();
            int ctr = 0;
            if (txtEmp1.Text != "")
            {
                string check = "Select Count(Employername) from employer_t where Employername = '" + txtEmp1.Text + "'";
                com = new MySqlCommand(check, connection);
                ctr = int.Parse(com.ExecuteScalar() + "");
                if (ctr == 0)
                {
                    string cmd1 = "Select country_id from country_t where countryname = '"+cbCountry1.Text+"'", countID = "";
                    com = new MySqlCommand(cmd1, connection);
                    MySqlDataReader dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        countID = dr[0].ToString();
                    }
                    dr.Close();
                    string cmd = "Insert into Employer_t (employername, foreignprin, country_id, email, contact, companyadd) values ('" + txtEmp1.Text + "','"+txtPrincipal1.Text+"','"+countID+"','"+txtEmail1.Text+"','"+txtContact1.Text+"','"+txtCompAddress1.Text+"')";
                    com = new MySqlCommand(cmd, connection);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Added!", "Added!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmp1.Clear();
                    txtPrincipal1.Clear();
                    this.Hide();
                }
                else if (ctr != 0)
                {
                    MessageBox.Show("Record already exists.", "Error Message");
                }
            }
            else
            {
                MessageBox.Show("Employer text Field Empty", "Add Employer Error");
            }
            connection.Close();
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnEditEmp_Click(object sender, EventArgs e)
        {
            connection.Open();
            string cmd = "";
            if (txtEmp2.Text == "")
            {
                MessageBox.Show("Employer name must not be empty.", "Empty Employer Name Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult rs = MessageBox.Show("Are you sure you want to update the record with the following details?"
                    + "\nEmployer ID: " + txtEmpID.Text + "\nNew Employer Name: " + txtEmp2.Text
                    + "\nNew Foreign Principal: " + txtPrincipal2.Text + "\nNew Country: " + cbCountry2.Text, "Confirmation", MessageBoxButtons.YesNo);

                if (rs == DialogResult.Yes)
                {
                    string countID = "";
                    cmd = "select country_id from country_t where countryname = '" + cbCountry2.Text + "'";
                    com = new MySqlCommand(cmd, connection);
                    dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        countID = dr[0].ToString();
                    }
                    dr.Close();

                    cmd = "Update Employer_T set Employername = '" + txtEmp2.Text + "', Foreignprin = '" + txtPrincipal2.Text + "', Country_id = '" + countID + "', contact = '"+txtContact2.Text+"', email = '"+txtEmail2.Text+"', companyadd = '"+txtCompAddress2.Text+"' where Employer_id = '" + txtEmpID.Text + "';";
                    com = new MySqlCommand(cmd, connection);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Changes Saved!", "Updated Employer Record!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmpID.Clear();
                    txtEmp2.Clear();
                    txtPrincipal2.Clear();
                    cbCountry2.SelectedIndex = -1;
                    this.Hide();
                }
            }
            connection.Close();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ucEmployerAddEdit_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            if (this.Visible == true)
            {
                connection.Open();
                string cmd = "select countryname from country_t;";
                com = new MySqlCommand(cmd, connection);
                MySqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cbCountry1.Items.Add(dr[0].ToString());
                    cbCountry2.Items.Add(dr[0].ToString());
                }
                dr.Close();
                connection.Close();
            }
            else
            {
                cbCountry1.Items.Clear();
                cbCountry2.Items.Clear();
            }
        }
    }
    
}
