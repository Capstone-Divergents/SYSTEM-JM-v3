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
            if(dgvCountry.Rows.Count != 0)
            {
                int ctr = 0;
                string cID = "", cmd2 = "";
                string cou = "select count(*) from country_t;";
                com = new MySqlCommand(cou, connection);
                ctr = int.Parse(com.ExecuteScalar() + "");
                if ((ctr + "").Length == 1)
                {
                    cID = "C0000" + ctr + "";
                }
                else if ((ctr + "").Length == 2)
                {
                    cID = "C000" + ctr + "";
                }
                else if ((ctr + "").Length == 3)
                {
                    cID = "C00" + ctr + "";
                }
                else if ((ctr + "").Length == 4)
                {
                    cID = "C0" + ctr + "";
                }
                else if ((ctr + "").Length == 5)
                {
                    cID = "C" + ctr + "";
                }
                else
                {
                    MessageBox.Show("Table in the database will not be able to handle more records.");
                }
                if (cID != "")
                {
                    string check = "Select Count(Countryname) from Country_t where Countryname = '" + txtCountryName1.Text + "'";
                    com = new MySqlCommand(check, connection);
                    ctr = int.Parse(com.ExecuteScalar() + "");
                    if (ctr == 0)
                    {
                        cmd = "Insert into Country_t (Country_id, countryname) values ('" + cID + "','" + txtCountryName1.Text + "')";
                        com = new MySqlCommand(cmd, connection);
                        com.ExecuteNonQuery();
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


        private void cbReq_SelectedIndexChanged(object sender, EventArgs e)
        {

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

                cmd = "select reqname from genreqs_t where allocation = 'country'";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cbReq2.Items.Add(dr[0].ToString());
                }
                dr.Close();

                cmd = "Select c.COUNTRY_ID'Country ID', g.Reqname'Requirement Name' from country_t c join countryreqs_t cr"
                + " on c.country_id = cr.country_id join genreqs_t g on cr.req_id = g.req_id"
                + " where c.countryname = '"+txtCountryName2.Text+"'";
                using (connection)
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dgvReq2.DataSource = ds.Tables[0];
                    }
                }
                
                for(int x = 0; x < dgvReq2.Rows.Count; x++)
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
            }

            connection.Close();
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
                dgvReq2.ColumnCount = 1;
                dgvReq2.Rows.Add(cbReq2.Text);
                cbReq2.Items.Remove(cbReq2.Text);
            }
        }

        private void btnRemoveRequire2_Click(object sender, EventArgs e)
        {
            if (dgvReq2.Rows.Count != 0)
            {
                cbReq2.Items.Add(dgvReq2.SelectedRows[0].Cells[0].Value.ToString());
                dgvReq2.Rows.Remove(dgvReq2.SelectedRows[0]);
            }
        }
    }
}
