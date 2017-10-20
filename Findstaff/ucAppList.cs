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
    public partial class ucAppList : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        private string cmd = "";
        MySqlDataReader dr;

        public ucAppList()
        {
            InitializeComponent();
        }

        private void btnAdvSe_Click(object sender, EventArgs e)
        {
            fAdvSearch fas = new fAdvSearch();
            fas.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            connection.Open();
            if(dgvAppList.Rows.Count != 0)
            {
                string cmd = "select app_id, Concat(fname , ' ' , mname, ' ', lname ), position, gender, civilstat, contact, birthdate, aheight, aweight from app_t where app_id = '" + dgvAppList.SelectedRows[0].Cells[0].Value.ToString() + "'";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    ucAppView.appno.Text = dr[0].ToString();
                    ucAppView.name.Text = dr[1].ToString();
                    ucAppView.position.Text = dr[2].ToString();
                    ucAppView.sex.Text = dr[3].ToString();
                    ucAppView.civilstat.Text = dr[4].ToString();
                    ucAppView.contactno.Text = dr[5].ToString();
                    ucAppView.birthday.Text = dr[6].ToString();
                    ucAppView.height.Text = dr[7].ToString();
                    ucAppView.weight.Text = dr[8].ToString();
                }
                dr.Close();

                cmd = "select nameoffather, fage, foccupation, nameofmother, mage, moccupation, nameofspouse, sage, soccupation from apppersonal_t where APP_ID = '" + dgvAppList.SelectedRows[0].Cells[0].Value.ToString() + "'";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    ucAppView.fathersname.Text = dr[0].ToString();
                    ucAppView.fathersage.Text = dr[1].ToString();
                    ucAppView.fathersoccupation.Text = dr[2].ToString();
                    ucAppView.mothersage.Text = dr[3].ToString();
                    ucAppView.mothersname.Text = dr[4].ToString();
                    ucAppView.mothersoccupation.Text = dr[5].ToString();
                    ucAppView.spousename.Text = dr[6].ToString();
                    ucAppView.spouseage.Text = dr[7].ToString();
                    ucAppView.spouseoccupation.Text = dr[8].ToString();
                }
                dr.Close();

                cmd = "select addrss from appaddress_t where addcat = 'Current' and app_id = '" + dgvAppList.SelectedRows[0].Cells[0].Value.ToString() + "'";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    ucAppView.cityadd.Text = dr[0].ToString();
                }
                dr.Close();

                cmd = "select addrss from appaddress_t where addcat = 'Provincial' and app_id = '" + dgvAppList.SelectedRows[0].Cells[0].Value.ToString() + "'";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    ucAppView.provadd.Text = dr[0].ToString();
                }
                dr.Close();

                cmd = "select schoolname'School Name', schooltype'School Type', yrstart'Year Started', yrend'Year Ended', degree'Degree' from appschool_t where APP_ID = '" + dgvAppList.SelectedRows[0].Cells[0].Value.ToString() + "'";
                using (connection)
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        ucAppView.dgvEducBack.DataSource = ds.Tables[0];
                    }
                }
                dr.Close();

                cmd = "select g.skillname'Skill Name', a.proficiency'Proficiency' from appskills_t a join genskills_t g on a.skill_id = g.skill_id where app_id = '" + dgvAppList.SelectedRows[0].Cells[0].Value.ToString() + "'";
                using (connection)
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        ucAppView.dgvSkills.DataSource = ds.Tables[0];
                    }
                }

                cmd = "select company'Employer', companyadd'Address', position'Position', monthstart'Month Started', yearstart'Year Started', monthend'Month Ended', yearend'Year Ended' from appworkex_t where APP_ID = '" + dgvAppList.SelectedRows[0].Cells[0].Value.ToString() + "'";
                using (connection)
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        ucAppView.dgvEmpHistory.DataSource = ds.Tables[0];
                    }
                }
                dr.Close();

                cmd = "select childname'Name', age'Age', birthdate'Birthdate' from appchildren_t where APP_ID = '" + dgvAppList.SelectedRows[0].Cells[0].Value.ToString() + "'";
                using (connection)
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        ucAppView.dgvChildren.DataSource = ds.Tables[0];
                    }
                }
                dr.Close();

                cmd = "select contactname'Contact Person', contactnum'Contact Number' from appcontact_t where APP_ID = '" + dgvAppList.SelectedRows[0].Cells[0].Value.ToString() + "'";
                using (connection)
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        ucAppView.dgvContactPersons.DataSource = ds.Tables[0];
                    }
                }
                dr.Close();
                
                ucAppView.Dock = DockStyle.Fill;
                ucAppView.Visible = true;
            }
            connection.Close();
        }

        public void searchData(string valueToFind)
        {
            connection.Open();

            string cmd = cmd = "select app.app_id'App ID', concat(app.lname, ', ', app.fname, ' ', app.mname)'Applicant Name', job.jobname'Applying for', a.appstatus'Under Department' "
                    + "from app_t app join job_t job "
                    + "on app.position = job.jobname "
                    + "left join applications_t a on app.app_id = a.app_id WHERE concat(app.app_id, app.lname, ', ', app.fname, ' ', app.mname, job.jobname) LIKE '%" + valueToFind + "%'";
            com = new MySqlCommand(cmd, connection);
            com.ExecuteNonQuery();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvAppList.DataSource = table;
            connection.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            searchData(txtName.Text);
        }

        private void ucAppList_Load(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            searchData(txtName.Text);
        }
    }
}
