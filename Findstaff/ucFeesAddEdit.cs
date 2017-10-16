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
    public partial class ucFeesAddEdit : UserControl
    {
        private MySqlConnection connection;
        private MySqlCommand com = new MySqlCommand();

        public ucFeesAddEdit()
        {
            InitializeComponent();
            panel1.Dock = DockStyle.Fill;
            panel2.Dock = DockStyle.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            connection.Open();
            int ctr = 0;
            if(txtFees1.Text != "")
            {
                string check = "Select Count(Feename) from Genfees_t where Feename = '" + txtFees1.Text + "'";
                com = new MySqlCommand(check, connection);
                ctr = int.Parse(com.ExecuteScalar() + "");
                if (ctr == 0)
                {
                    string cmd = "Insert into Genfees_t (Feename) values ('" + txtFees1.Text + "')";
                    com = new MySqlCommand(cmd, connection);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Added!", "Added!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFees1.Clear();
                    this.Hide();

                }
                else if (ctr != 0)
                {
                    MessageBox.Show("Record already exists.", "Error Message");
                }
            }
            else
            {
                MessageBox.Show("Fee Text Field Empty","Add Fee Error");
            }
            connection.Close();
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            txtFees1.Clear();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            connection.Open();
            string cmd = "";
            if(txtFee2.Text == "")
            {
                MessageBox.Show("Fee name must not be empty.", "Empty Fee Name Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult rs = MessageBox.Show("Are you sure You want to update the record with the following details?"
                    +"\nFee ID: "+txtID.Text+"\nNew Fee Name: "+txtFee2.Text, "Confirmation", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    cmd = "Update Genfees_t set feename = '" + txtFee2.Text + "' where fee_id = '" + txtID.Text + "';";
                    com = new MySqlCommand(cmd, connection);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Changes Saved!", "Update Fee Record!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Clear();
                    txtFee2.Clear();
                    this.Hide();
                }
            }
            connection.Close();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtFee2.Clear();
            this.Hide();
        }

        private void ucFeesAddEdit_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
        }

        private void txtFees1_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[a-zA-Z ]*$").IsMatch(txtFees1.Text)))
            {
                txtFees1.Text = "";
            }
        }

        private void txtFee2_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[a-zA-Z ]*$").IsMatch(txtFee2.Text)))
            {
                txtFee2.Text = "";
            }
        }
    }
}
