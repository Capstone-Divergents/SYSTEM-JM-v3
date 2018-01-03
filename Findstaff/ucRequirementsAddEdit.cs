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
    public partial class ucRequirementsAddEdit : UserControl
    {

        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();

        public ucRequirementsAddEdit()
        {
            InitializeComponent();
            panel1.Dock = DockStyle.Fill;
            panel2.Dock = DockStyle.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            connection.Open();
            if (txtRequirement.Text != "")
            {
                int ctr = 0;
                string check = "Select Count(reqname) from Genreqs_t where reqname = '" + txtRequirement.Text + "'";
                com = new MySqlCommand(check, connection);
                ctr = int.Parse(com.ExecuteScalar() + "");
                if (ctr == 0)
                {
                    if (cbDesignation.SelectedIndex != -1)
                    {
                        string cmd = "Insert into Genreqs_t (reqname, allocation, Description) values ('" + txtRequirement.Text + "','" + cbDesignation.Text + "', '"+rtbDesc1.Text+"')";
                        com = new MySqlCommand(cmd, connection);
                        com.ExecuteNonQuery();
                        MessageBox.Show("Requirement Record Added!", "Added!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtRequirement.Clear();
                        cbDesignation.SelectedIndex = -1;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("No Requirement Designation", "Error Message");
                    }
                }
                else if (ctr != 0)
                {
                    MessageBox.Show("Record already exists.", "Error Message");
                }
            }
            else
            {
                MessageBox.Show("Requirement Name Field Empty", "Error Message");
            }
            connection.Close();
        }
        
        private void btnCancel1_Click(object sender, EventArgs e)
        {
            txtRequirement.Clear();
            cbDesignation.SelectedIndex = -1;
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            connection.Open();
            string cmd = "";
            if (txtRequirement2.Text == "")
            {
                MessageBox.Show("Requirement name must not be empty.", "Empty Requirement Name Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult rs = MessageBox.Show("Are you sure You want to update the record with the following details?"
                    + "\nRequirement ID: " + txtRequirementID.Text + "\nNew Requirement Name: " + txtRequirement2.Text
                    +"\nNew Designation: "+ cbDesignation1.Text + "\nNew Description: "+rtbDesc2.Text, "Confirmation", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    cmd = "Update Genreqs_t set reqname = '" + txtRequirement2.Text + "', Allocation = '"+cbDesignation1.Text+"', Description = '"+rtbDesc2.Text+"'  where Req_id = '" + txtRequirementID.Text + "';";
                    com = new MySqlCommand(cmd, connection);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Changes Saved!", "Updated Requirement Record!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRequirementID.Clear();
                    txtRequirement2.Clear();
                    cbDesignation1.SelectedIndex = -1;
                    this.Hide();
                }
            }
            connection.Close();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            txtRequirement.Clear();
            this.Hide();
        }

        private void ucRequirementsAddEdit_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
        }
    }
}
