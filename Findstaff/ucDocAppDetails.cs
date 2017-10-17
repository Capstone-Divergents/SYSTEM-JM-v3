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
    public partial class ucDocAppDetails : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();
        MySqlDataReader dr;
        MySqlDataAdapter adapter;
        private string cmd = "";

        public ucDocAppDetails()
        {
            InitializeComponent();
        }

        private void ucDocAppDetails_Load(object sender, EventArgs e)
        {
            string app = "", jname = "", jorder = "", emp = "";

            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();
            string query = "SELECT * FROM EMP_T;";
            com = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = com.ExecuteReader();
            while (dataReader.Read())
            {
                //app = dataReader.GetString();
                //jname = dataReader.GetString();
                //jorder = dataReader.GetString();
                //emp = dataReader.GetString();
            }
            connection.Close();

            applicant.Text = app;
            jobname.Text = jname;
            joborder.Text = jorder;
            employer.Text = emp;
        }

        private void btnMoveToAcco_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ucDocAppDetails_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            //connection.Open();
            //if (this.Visible == true)
            //{
            //    cmd = "SELECT g.reqname'Requirement Name', a.docstat'Status' FROM genreqs_t g ;"
            //        +"join appdoc_t a on g.req_id = a.req_id "
            //        +"join applications_t app on app.App_id = a.App_id "
            //        +"where app.appstats = 'Active' and g.allocation = 'Basic'";
            //    com = new MySqlCommand(cmd, connection);
            //    using (adapter = new MySqlDataAdapter(cmd, connection))
            //    {
            //        DataSet ds = new DataSet();
            //        adapter.Fill(ds);
            //        dgvBasicReqs.DataSource = ds.Tables[0];
            //    }
            //    cmd = "SELECT g.reqname'Requirement Name', a.docstat'Status' FROM genreqs_t g ;"
            //        + "join appdoc_t a on g.req_id = a.req_id "
            //        + "join applications_t app on app.App_id = a.App_id "
            //        + "where app.appstats = 'Active' and g.allocation <> 'Basic'";
            //    com = new MySqlCommand(cmd, connection);
            //    using (adapter = new MySqlDataAdapter(cmd, connection))
            //    {
            //        DataSet ds = new DataSet();
            //        adapter.Fill(ds);
            //        dgvAddlReqs.DataSource = ds.Tables[0];
            //    }
            //}
            connection.Close();
        }

        private void btnPassed1_Click(object sender, EventArgs e)
        {
            bool passed = false;
            string docs = "";
            for(int x = 0; x < dgvBasicReqs.SelectedRows.Count; x++)
            {
                if (dgvBasicReqs.SelectedRows[x].Cells[1].Value.ToString() == "Passed")
                {
                    MessageBox.Show(dgvBasicReqs.SelectedRows[x].Cells[0].Value.ToString() +" has been passed.\nPlease check your selections.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passed = true;
                    docs = "";
                    break;
                }
                else
                {
                    docs += dgvBasicReqs.SelectedRows[x].Cells[0].Value.ToString() + "\n";
                }
            }
            if(!passed)
            {
                DialogResult dr1 = MessageBox.Show("Are you sure the following documents will be passed?\n\n" + docs, "Confirm Documents", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dr1 == DialogResult.Yes)
                {
                    string cmd2 = "", appID = "", appNO = "";
                    cmd = "Update appdoc_t set docstat = 'Passed' where ";
                    for(int x = 0; x < dgvBasicReqs.SelectedRows.Count; x++)
                    {
                        cmd2 = "select req_id from genreqs_t where reqname = '" + dgvBasicReqs.SelectedRows[x].Cells[0].Value.ToString() + "'";
                        com = new MySqlCommand(cmd2, connection);
                        dr = com.ExecuteReader();
                        while (dr.Read())
                        {
                            cmd += "req_id = '" + dr[0].ToString() + "' and ";
                        }
                        dr.Close();
                    }
                    cmd2 = "select app_id from app_t where concat(fname, ' ', mname, ' ', lname, ' ') = '" + applicant.Text + "'";
                    com = new MySqlCommand(cmd2, connection);
                    dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        appID = dr[0].ToString();
                    }
                    dr.Close();
                    cmd2 = "select app.app_no from applications_t app join app_t a on app.App_id = a.app_id where app.appstats = 'Active' and app_id = '" + appID + "'";
                    while (dr.Read())
                    {
                        appNO = dr[0].ToString();
                    }
                    dr.Close();
                    cmd += "app_no = '"+appNO+"'";
                    com = new MySqlCommand(cmd, connection);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Documents status changed to 'Passed'", "Documents Passed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    for(int x = 0; x < dgvBasicReqs.SelectedRows.Count; x++)
                    {
                        dgvBasicReqs.SelectedRows[x].Cells[1].Equals("Passed");
                    }
                }
            }
        }

        private void btnPassed2_Click(object sender, EventArgs e)
        {
            bool passed = false;
            string docs = "";
            for (int x = 0; x < dgvAddlReqs.SelectedRows.Count; x++)
            {
                if (dgvAddlReqs.SelectedRows[x].Cells[1].Value.ToString() == "Passed")
                {
                    MessageBox.Show(dgvAddlReqs.SelectedRows[x].Cells[0].Value.ToString() + " has been passed.\nPlease check your selections.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passed = true;
                    docs = "";
                    break;
                }
                else
                {
                    docs += dgvAddlReqs.SelectedRows[x].Cells[0].Value.ToString() + "\n";
                }
            }
            if (!passed)
            {
                DialogResult dr1 = MessageBox.Show("Are you sure the following documents will be passed?\n\n" + docs, "Confirm Documents", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr1 == DialogResult.Yes)
                {
                    string cmd2 = "", appID = "", appNO = "";
                    cmd = "Update appdoc_t set docstat = 'Passed' where ";
                    for (int x = 0; x < dgvAddlReqs.SelectedRows.Count; x++)
                    {
                        cmd2 = "select req_id from genreqs_t where reqname = '" + dgvAddlReqs.SelectedRows[x].Cells[0].Value.ToString() + "'";
                        com = new MySqlCommand(cmd2, connection);
                        dr = com.ExecuteReader();
                        while (dr.Read())
                        {
                            cmd += "req_id = '" + dr[0].ToString() + "' and ";
                        }
                        dr.Close();
                    }
                    cmd2 = "select app_id from app_t where concat(fname, ' ', mname, ' ', lname, ' ') = '" + applicant.Text + "'";
                    com = new MySqlCommand(cmd2, connection);
                    dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        appID = dr[0].ToString();
                    }
                    dr.Close();
                    cmd2 = "select app.app_no from applications_t app join app_t a on app.App_id = a.app_id where app.appstats = 'Active' and app_id = '" + appID + "'";
                    while (dr.Read())
                    {
                        appNO = dr[0].ToString();
                    }
                    dr.Close();
                    cmd += "app_no = '" + appNO + "'";
                    com = new MySqlCommand(cmd, connection);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Documents status changed to 'Passed'", "Documents Passed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    for (int x = 0; x < dgvAddlReqs.SelectedRows.Count; x++)
                    {
                        dgvAddlReqs.SelectedRows[x].Cells[1].Equals("Passed");
                    }
                }
            }
        }

    }
}
