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
    public partial class ucSkillsAddEdit : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();

        public ucSkillsAddEdit()
        {
            InitializeComponent();
            panel1.Dock = DockStyle.Fill;
            panel2.Dock = DockStyle.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            connection.Open();
            int ctr = 0;
            if(txtSkillName1.Text != "")
            {
                string check = "Select Count(Skillname) from Genskills_t where Skillname = '" + txtSkillName1.Text + "'";
                com = new MySqlCommand(check, connection);
                ctr = int.Parse(com.ExecuteScalar() + "");
                if (ctr == 0)
                {
                    string cmd = "Insert into Genskills_t (skillname) values ('" + txtSkillName1.Text + "')";
                    com = new MySqlCommand(cmd, connection);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Added!", "Added!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSkillName1.Clear();
                    this.Hide();
                }
                else if (ctr != 0)
                {
                    MessageBox.Show("Record already exists.", "Error Message");
                }
            }
            else
            {
                MessageBox.Show("Skill Name Field Empty", "Error Message");
            }
            connection.Close();
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            txtSkillName1.Clear();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            connection.Open();
            string cmd = "";
            if (txtSkillName2.Text == "")
            {
                MessageBox.Show("Skill name must not be empty.", "Empty Fee Name Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult rs = MessageBox.Show("Are you sure You want to update the record with the following details?"
                    + "\nSkill ID: " + txtSkillID.Text + "\nNew Skill Name: " + txtSkillName2.Text, "Confirmation", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    cmd = "Update Genskills_t set skillname = '" + txtSkillName2.Text + "' where Skill_id = '" + txtSkillID.Text + "';";
                    com = new MySqlCommand(cmd, connection);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Changes Saved!", "Updated Skill Record!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSkillID.Clear();
                    txtSkillName2.Clear();
                    this.Hide();
                }
            }
            connection.Close();
        }
        
        private void btnCancel2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ucSkillsAddEdit_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
        }
    }
}
