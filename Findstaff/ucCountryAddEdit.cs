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
    public partial class ucCountryAddEdit : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();
        MySqlDataReader dr;
        private string cmd = "";

        public ucCountryAddEdit()
        {
            InitializeComponent();
            panel1.Dock = DockStyle.Fill;
            panel2.Dock = DockStyle.Fill;
        }

        private void btnAddCountry_Click(object sender, EventArgs e)
        {
            connection.Open();
            if(txtCountryName1.Text != "")
            {
                int ctr = 0;
                string cID = "", cmd2 = "";
                if (dgvCountry.Rows.Count != 0)
                {
                    string check = "Select Count(Countryname) from Country_t where Countryname = '" + txtCountryName1.Text + "'";
                    com = new MySqlCommand(check, connection);
                    ctr = int.Parse(com.ExecuteScalar() + "");
                    if (ctr == 0)
                    {
                        cmd = "Insert into Country_t (countryname) values ('" + txtCountryName1.Text + "')";
                        com = new MySqlCommand(cmd, connection);
                        com.ExecuteNonQuery();
                        cmd = "Select country_id from country_t where countryname = '"+txtCountryName1.Text+"'";
                        com = new MySqlCommand(cmd, connection);
                        dr = com.ExecuteReader();
                        while (dr.Read())
                        {
                            cID = dr[0].ToString();
                        }
                        dr.Close();
                        cmd = "Insert into countryreqs_t (country_id, req_id) values ";
                        for(int x = 0; x < dgvCountry.Rows.Count; x++)
                        {
                            cmd2 = "select req_id from genreqs_t where reqname = '"+dgvCountry.Rows[x].Cells[0].Value.ToString()+"'";
                            com = new MySqlCommand(cmd2, connection);
                            dr = com.ExecuteReader();
                            while (dr.Read())
                            {
                                cmd += "('"+cID+"','"+dr[0].ToString()+"')";
                            }
                            dr.Close();
                            if(x < dgvCountry.Rows.Count - 1)
                            {
                                cmd += ",";
                            }
                        }
                        com = new MySqlCommand(cmd, connection);
                        com.ExecuteNonQuery();
                        MessageBox.Show("Added!", "Added!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCountryName1.Clear();
                        dgvCountry.Rows.Clear();
                        cbReq.Items.Clear();
                        this.Hide();
                    }
                    else if (ctr != 0)
                    {
                        MessageBox.Show("Record already exists.", "Error Message");
                    }
                }
                else
                {
                    MessageBox.Show("No documents specified for the country", "Add Country Error");
                }
            }
            else
            {
                MessageBox.Show("Country Text Field Empty", "Add Country Error");
            }
            connection.Close();
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved!", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        
        private void btnAddRequire_Click(object sender, EventArgs e)
        {
            if(cbReq.Text != "")
            {
                dgvCountry.ColumnCount = 1;
                dgvCountry.Rows.Add(cbReq.Text);
                cbReq.Items.Remove(cbReq.Text);
            }
        }

        private void btnRemoveRequire_Click(object sender, EventArgs e)
        {
            if(dgvCountry.Rows.Count != 0)
            {
                cbReq.Items.Add(dgvCountry.SelectedRows[0].Cells[0].Value.ToString());
                dgvCountry.Rows.Remove(dgvCountry.SelectedRows[0]);
            }
        }
        
        private void btnAddRequire2_Click(object sender, EventArgs e)
        {
            if (cbReq2.Text != "")
            {
                string reqId = "";
                dgvReq2.Rows.Add(txtCountryID2.Text, cbReq2.Text);
                cmd = "Select req_id from genreqs_t where reqname = '" + cbReq2.Text + "'";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    reqId = dr[0].ToString();
                }
                dr.Close();

                cmd = "insert into countryreqs_t values ('"+txtCountryID2.Text+"','"+reqId+"')";
                com = new MySqlCommand(cmd, connection);
                com.ExecuteNonQuery();
                cbReq2.Items.Remove(cbReq2.Text);
            }
        }

        private void btnRemoveRequire2_Click(object sender, EventArgs e)
        {
            connection.Open();
            if(dgvReq2.Rows.Count != 0)
            {
                DialogResult a = MessageBox.Show("Are you sure you want to remove the document " + dgvReq2.SelectedRows[0].Cells[1].Value.ToString()
                    + " from the list of documents", "Remove Documents from Country", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(a == DialogResult.Yes)
                {
                    string reqId = "";
                    cbReq2.Items.Add(dgvReq2.SelectedRows[0].Cells[1].Value.ToString());
                    cmd = "Select req_id from genreqs_t where reqname = '" + dgvReq2.SelectedRows[0].Cells[1].Value.ToString() + "'";
                    com = new MySqlCommand(cmd, connection);
                    dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        reqId = dr[0].ToString();
                    }
                    dr.Close();
                    dgvReq2.Rows.Remove(dgvReq2.SelectedRows[0]);
                    cmd = "delete from countryreqs_t where country_id = '"+txtCountryID2.Text+"' and req_id = '"+reqId+"'";
                    com = new MySqlCommand(cmd, connection);
                    com.ExecuteNonQuery();
                }
            }
            connection.Close();
        }

        private void ucCountryAddEdit_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            if (this.Visible == true)
            {
                connection.Open();
                string cmd = "select reqname from genreqs_t where allocation = 'country';";
                com = new MySqlCommand(cmd, connection);
                MySqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cbReq.Items.Add(dr[0].ToString());
                }
                dr.Close();

                cmd = "Select c.COUNTRY_ID'Country ID', g.Reqname'Requirement Name' from country_t c join countryreqs_t cr"
                + " on c.country_id = cr.country_id join genreqs_t g on cr.req_id = g.req_id"
                + " where c.countryname = '" + txtCountryName2.Text + "'";
                int y = 0;
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    y++;
                }
                dr.Close();

                string[,] reqlist = new string[2,y];
                cmd = "Select c.COUNTRY_ID'Country ID', g.Reqname'Requirement Name' from country_t c join countryreqs_t cr"
                + " on c.country_id = cr.country_id join genreqs_t g on cr.req_id = g.req_id"
                + " where c.countryname = '" + txtCountryName2.Text + "'";
                int z = 0;
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    reqlist[0,z] = dr[0].ToString();
                    reqlist[1,z] = dr[1].ToString();
                    z++;
                }
                dr.Close();
                dgvReq2.ColumnCount = 2;
                for(int x = 0; x < y; x++)
                {
                    dgvReq2.Rows.Add(reqlist[0,x], reqlist[1,x]);
                }
                
                for (int x = 0; x < dgvReq2.Rows.Count; x++)
                {
                    if (cbReq2.Items.Contains(dgvReq2.Rows[x].Cells[1].Value.ToString()))
                    {
                        cbReq2.Items.Remove(dgvReq2.Rows[x].Cells[1].Value.ToString());
                    }
                }
            }
            else
            {
                cbReq.Items.Clear();
                cbReq2.Items.Clear();
                dgvReq2.Rows.Clear();
            }
            connection.Close();
        }
    }
}
