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
    public partial class ucReports : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        private string cmd = "";

        public ucReports()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();

            if (cbUnderDept.SelectedIndex == 0)
            {
                cmd = "select a.app_id'Applicant ID', Concat(a.fname, ' ', a.mname, ' ', a.lname)'Name', a.position'Position', ap.appstatus'Under Department', ap.appstats'Application Status' from app_t a " +
                            "join applications_t ap on a.app_id = ap.app_id " +
                            "where ap.appstatus = 'Recruitment' and ap.appstats = 'Active';";
                using (connection)
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dgvReports.DataSource = ds.Tables[0];
                    }
                }
            }
            else if (cbUnderDept.SelectedIndex == 1)
            {
                cmd = "select a.app_id'Applicant ID', Concat(a.fname, ' ', a.mname, ' ', a.lname)'Name', a.position'Position', ap.appstatus'Under Department', ap.appstats'Application Status' from app_t a " +
                            "join applications_t ap on a.app_id = ap.app_id " +
                            "where ap.appstatus = 'Documentation' and ap.appstats = 'Active';";
                using (connection)
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dgvReports.DataSource = ds.Tables[0];
                    }
                }
            }
            else if (cbUnderDept.SelectedIndex == 2)
            {
                cmd = "select a.app_id'Applicant ID', Concat(a.fname , ' ' , a.mname, ' ', a.lname )'Name', a.position'Position', ap.appstatus'Under Department', ap.appstats'Application Status' from app_t a " +
                            "join applications_t ap on a.app_id = ap.app_id " +
                            "where ap.appstatus = 'Accounting' and ap.appstats = 'Active';";
                using (connection)
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dgvReports.DataSource = ds.Tables[0];
                    }
                }
            }
            else if (cbUnderDept.SelectedIndex == 3)
            {
                cmd = "select a.app_id'Applicant ID', Concat(a.fname , ' ' , a.mname, ' ', a.lname )'Name', a.position'Position', ap.appstatus'Under Department' from app_t a " +
                            "join applications_t ap on a.app_id = ap.app_id " +
                            "where ap.appstatus = 'Deployed';";
                using (connection)
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dgvReports.DataSource = ds.Tables[0];
                    }
                }
            }
            else if (cbUnderDept.SelectedIndex == 4)
            {
                cmd = "select a.app_id'Applicant ID', Concat(a.fname , ' ' , a.mname, ' ', a.lname )'Name', a.position'Position', ap.appstats'Application Status' from app_t a " +
                            "join applications_t ap on a.app_id = ap.app_id " +
                            "where ap.appstats = 'Forfeited';";
                using (connection)
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dgvReports.DataSource = ds.Tables[0];
                    }
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();

            if (cbUnderDept.SelectedIndex == 0)
            {
                cmd = "select a.app_id'Applicant ID', Concat(a.fname, ' ', a.mname, ' ', a.lname)'Name', a.position'Position', ap.appstatus'Under Department', ap.appstats'Application Status' from app_t a " +
                            "join applications_t ap on a.app_id = ap.app_id " +
                            "where ap.appstatus = 'Recruitment' and ap.appstats = 'Active';";
                using (connection)
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dgvReports.DataSource = ds.Tables[0];
                    }
                }
            }
            else if (cbUnderDept.SelectedIndex == 1)
            {
                cmd = "select a.app_id'Applicant ID', Concat(a.fname, ' ', a.mname, ' ', a.lname)'Name', a.position'Position', ap.appstatus'Under Department', ap.appstats'Application Status' from app_t a " +
                            "join applications_t ap on a.app_id = ap.app_id " +
                            "where ap.appstatus = 'Documentation' and ap.appstats = 'Active';";
                using (connection)
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dgvReports.DataSource = ds.Tables[0];
                    }
                }
            }
            else if (cbUnderDept.SelectedIndex == 2)
            {
                cmd = "select a.app_id'Applicant ID', Concat(a.fname , ' ' , a.mname, ' ', a.lname )'Name', a.position'Position', ap.appstatus'Under Department', ap.appstats'Application Status' from app_t a " +
                            "join applications_t ap on a.app_id = ap.app_id " +
                            "where ap.appstatus = 'Accounting' and ap.appstats = 'Active';";
                using (connection)
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dgvReports.DataSource = ds.Tables[0];
                    }
                }
            }
            else if (cbUnderDept.SelectedIndex == 3)
            {
                cmd = "select a.app_id'Applicant ID', Concat(a.fname , ' ' , a.mname, ' ', a.lname )'Name', a.position'Position', ap.appstatus'Under Department' from app_t a " +
                            "join applications_t ap on a.app_id = ap.app_id " +
                            "where ap.appstatus = 'Deployed';";
                using (connection)
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dgvReports.DataSource = ds.Tables[0];
                    }
                }
            }
            else if (cbUnderDept.SelectedIndex == 4)
            {
                cmd = "select a.app_id'Applicant ID', Concat(a.fname , ' ' , a.mname, ' ', a.lname )'Name', a.position'Position', ap.appstats'Application Status' from app_t a " +
                            "join applications_t ap on a.app_id = ap.app_id " +
                            "where ap.appstats = 'Forfeited';";
                using (connection)
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dgvReports.DataSource = ds.Tables[0];
                    }
                }
            }
        }
    }
}
