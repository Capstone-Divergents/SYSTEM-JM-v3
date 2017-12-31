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
    public partial class ucApplicant : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        private string cmd = "";
        MySqlDataReader dr;

        public ucApplicant()
        {
            InitializeComponent();
        }

        #region bntAdd_Click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ucAppAddEdit.Dock = DockStyle.Fill;
            ucAppAddEdit.Visible = true;
            ucAppAddEdit.panel1.Visible = true;
            ucAppAddEdit.panel2.Visible = false;
        }
        #endregion

        #region btnEdit_Click
        private void btnEdit_Click(object sender, EventArgs e)
        {
            ucAppAddEdit.txtAppNo.Text = dgvApplicant.SelectedRows[0].Cells[0].Value.ToString();
            ucAppAddEdit.cbPosition2.Text = dgvApplicant.SelectedRows[0].Cells[2].Value.ToString();

            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();

            cmd = "select lname, fname, mname, position, gender, civilstat, contact, monthname(birthdate), day(birthdate), year(birthdate), aheight, aweight from app_t where APP_ID = '" + dgvApplicant.SelectedRows[0].Cells[0].Value.ToString() + "'";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                ucAppAddEdit.txtLastName2.Text = dr[0].ToString();
                ucAppAddEdit.txtFirstName2.Text = dr[1].ToString();
                ucAppAddEdit.txtMiddleName2.Text = dr[2].ToString();
                ucAppAddEdit.cbPosition2.Text = dr[3].ToString();
                
                if (dr.GetString(4) == "Male")
                {
                    ucAppAddEdit.rbMale2.Select();
                }
                else
                {
                    ucAppAddEdit.rbFemale2.Select();
                }

                ucAppAddEdit.cbCivilStat2.Text = dr[5].ToString();
                ucAppAddEdit.txtPhoneNumber2.Text = dr[6].ToString();
                ucAppAddEdit.cbMonth2.Text = dr[7].ToString();
                ucAppAddEdit.cbDay2.Text = dr[8].ToString();
                ucAppAddEdit.cbYear2.Text = dr[9].ToString();
                ucAppAddEdit.txtHeight2.Text = dr[10].ToString();
                ucAppAddEdit.txtWeight2.Text = dr[11].ToString();
            }

            dr.Close();

            cmd = "select nameoffather, fage, foccupation, nameofmother, mage, moccupation, nameofspouse, sage, soccupation from apppersonal_t where APP_ID = '" + dgvApplicant.SelectedRows[0].Cells[0].Value.ToString() + "'";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                ucAppAddEdit.txtFather2.Text = dr[0].ToString();
                ucAppAddEdit.txtFAge2.Text = dr[1].ToString();
                ucAppAddEdit.txtFOccu2.Text = dr[2].ToString();
                ucAppAddEdit.txtMother2.Text = dr[3].ToString();
                ucAppAddEdit.txtMAge2.Text = dr[4].ToString();
                ucAppAddEdit.txtMOccu2.Text = dr[5].ToString();
                ucAppAddEdit.txtSpouse2.Text = dr[6].ToString();
                ucAppAddEdit.txtSAge2.Text = dr[7].ToString();
                ucAppAddEdit.txtSOccu2.Text = dr[8].ToString();
            }

            dr.Close();

            cmd = "select addrss from appaddress_t where addcat = 'Current' and app_id = '" + dgvApplicant.SelectedRows[0].Cells[0].Value.ToString() + "'";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                ucAppAddEdit.txtCityAddress2.Text = dr[0].ToString();
            }
            dr.Close();

            cmd = "select addrss from appaddress_t where addcat = 'Provincial' and app_id = '" + dgvApplicant.SelectedRows[0].Cells[0].Value.ToString() + "'";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                ucAppAddEdit.txtProvAdd2.Text = dr[0].ToString();
            }
            dr.Close();

            cmd = "select schoolname'School Name', schooltype'School Type', yrstart'Year Started', yrend'Year Ended', degree'Degree' from appschool_t where APP_ID = '" + dgvApplicant.SelectedRows[0].Cells[0].Value.ToString() + "'";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ucAppAddEdit.dgvEducBack2.DataSource = ds.Tables[0];
                }
            }

            cmd = "select g.skillname'Skill Name', a.proficiency'Proficiency' from appskills_t a join genskills_t g on a.skill_id = g.skill_id where app_id = '" + dgvApplicant.SelectedRows[0].Cells[0].Value.ToString() + "'";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ucAppAddEdit.dgvSkills2.DataSource = ds.Tables[0];
                }
            }
            
            cmd = "select company'Employer', companyadd'Address', position'Position', monthstart'Month Started', yearstart'Year Started', monthend'Month Ended', yearend'Year Ended' from appworkex_t where APP_ID = '" + dgvApplicant.SelectedRows[0].Cells[0].Value.ToString() + "'";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ucAppAddEdit.dgvEmpHistory2.DataSource = ds.Tables[0];
                }
            }

            cmd = "select childname'Name', age'Age', birthdate'Birthdate' from appchildren_t where APP_ID = '" + dgvApplicant.SelectedRows[0].Cells[0].Value.ToString() + "'";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ucAppAddEdit.dgvChildren2.DataSource = ds.Tables[0];
                }
            }

            cmd = "select contactname'Contact Person', contactnum'Contact Number' from appcontact_t where APP_ID = '" + dgvApplicant.SelectedRows[0].Cells[0].Value.ToString() + "'";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ucAppAddEdit.dgvContactPersons2.DataSource = ds.Tables[0];
                }
            }
            connection.Close();

            ucAppAddEdit.Dock = DockStyle.Fill;
            ucAppAddEdit.Visible = true;
            ucAppAddEdit.panel1.Visible = false;
            ucAppAddEdit.panel2.Visible = true;
        }
#endregion

        #region btnDelete_Click
        private void btnDelete_Click(object sender, EventArgs e)
        {
            connection.Open();
            string cmd = "delete from app_t where app_id = '" + dgvApplicant.SelectedRows[0].Cells[0].Value.ToString() + "';";
            com = new MySqlCommand(cmd, connection);
            com.ExecuteNonQuery();
            dgvApplicant.Rows.Remove(dgvApplicant.SelectedRows[0]);
            MessageBox.Show("Applicant Deleted!", "Applicant Record Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
        }
        #endregion

        #region btnView_Click
        private void btnView_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();
            string cmd = "select app_id, Concat(fname , ' ' , mname, ' ', lname ), position, gender, civilstat, contact, birthdate, aheight, aweight from app_t where app_id = '" + dgvApplicant.SelectedRows[0].Cells[0].Value.ToString() + "'";
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

            cmd = "select nameoffather, fage, foccupation, nameofmother, mage, moccupation, nameofspouse, sage, soccupation from apppersonal_t where APP_ID = '" + dgvApplicant.SelectedRows[0].Cells[0].Value.ToString() + "'";
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

            cmd = "select addrss from appaddress_t where addcat = 'Current' and app_id = '" + dgvApplicant.SelectedRows[0].Cells[0].Value.ToString() + "'";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                ucAppView.cityadd.Text = dr[0].ToString();
            }
            dr.Close();

            cmd = "select addrss from appaddress_t where addcat = 'Provincial' and app_id = '" + dgvApplicant.SelectedRows[0].Cells[0].Value.ToString() + "'";
            com = new MySqlCommand(cmd, connection);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                ucAppView.provadd.Text = dr[0].ToString();
            }
            dr.Close();

            cmd = "select schoolname'School Name', schooltype'School Type', yrstart'Year Started', yrend'Year Ended', degree'Degree' from appschool_t where APP_ID = '" + dgvApplicant.SelectedRows[0].Cells[0].Value.ToString() + "'";
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

            cmd = "select g.skillname'Skill Name', a.proficiency'Proficiency' from appskills_t a join genskills_t g on a.skill_id = g.skill_id where app_id = '" + dgvApplicant.SelectedRows[0].Cells[0].Value.ToString() + "'";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ucAppView.dgvSkills.DataSource = ds.Tables[0];
                }
            }

            cmd = "select company'Employer', companyadd'Address', position'Position', monthstart'Month Started', yearstart'Year Started', monthend'Month Ended', yearend'Year Ended' from appworkex_t where APP_ID = '" + dgvApplicant.SelectedRows[0].Cells[0].Value.ToString() + "'";
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

            cmd = "select childname'Name', age'Age', birthdate'Birthdate' from appchildren_t where APP_ID = '" + dgvApplicant.SelectedRows[0].Cells[0].Value.ToString() + "'";
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

            cmd = "select contactname'Contact Person', contactnum'Contact Number' from appcontact_t where APP_ID = '" + dgvApplicant.SelectedRows[0].Cells[0].Value.ToString() + "'";
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
        #endregion

        public void searchData(string valueToFind)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();

            string cmd = "select app.app_id'App ID', concat(app.lname, ', ', app.fname, ' ', app.mname)'Applicant Name', job.jobname'Applying for' "
                    + "from app_t app join job_t job "
                    + "on app.position = job.jobname WHERE concat(app.app_id, app.lname, ', ', app.fname, ' ', app.mname, job.jobname) LIKE '%" + valueToFind + "%'";
            com = new MySqlCommand(cmd, connection);
            com.ExecuteNonQuery();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvApplicant.DataSource = table;
        }

        private void ucAppAddEdit_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            cmd = "select app.app_id'App ID', concat(app.lname, ', ', app.fname, ' ', app.mname)'Applicant Name', job.jobname'Applying for', App.appstatus'Status' "
                    + "from app_t app join job_t job "
                    + "on app.position = job.jobname "
                    + "left join applications_t a on app.app_id = a.app_id ";
            using (connection)
            {
                using (adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvApplicant.DataSource = ds.Tables[0];
                }
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            searchData(txtName.Text);
        }

        private void ucApplicant_Load(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            searchData(txtName.Text);
        }

        private void ucAppAddEdit_VisibleChanged_1(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            cmd = "select app.app_id'App ID', concat(app.lname, ', ', app.fname, ' ', app.mname)'Applicant Name', job.jobname'Applying for', App.appstatus'Status' "
                    + "from app_t app join job_t job "
                    + "on app.position = job.jobname "
                    + "left join applications_t a on app.app_id = a.app_id ";
            using (connection)
            {
                using (adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvApplicant.DataSource = ds.Tables[0];
                }
            }
        }
    }
}
