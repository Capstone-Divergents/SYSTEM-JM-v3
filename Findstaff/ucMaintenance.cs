﻿using System;
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
    public partial class ucMaintenance : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        private string cmd = "";

        public ucMaintenance()
        {
            InitializeComponent();
            ucEmployee.Dock = DockStyle.Fill;
            ucApplicant.Dock = DockStyle.Fill;
            ucCountry.Dock = DockStyle.Fill;
            ucEmployer.Dock = DockStyle.Fill;
            ucJobOrder.Dock = DockStyle.Fill;
            ucJobList.Dock = DockStyle.Fill;
            ucJobFees.Dock = DockStyle.Fill;
            ucGenReqs.Dock = DockStyle.Fill;
            ucEmployee.Visible = false;
            ucApplicant.Visible = false;
            ucCountry.Visible = false;
            ucEmployer.Visible = false;
            ucJobOrder.Visible = false;
            ucJobList.Visible = false;
            ucJobFees.Visible = false;
            ucGenReqs.Visible = false;
        }

        private void rbEmployee_CheckedChanged(object sender, EventArgs e)
        {
            ucEmployee.Visible = true;
            ucApplicant.Visible = false;
            ucCountry.Visible = false;
            ucEmployer.Visible = false;
            ucJobOrder.Visible = false;
            ucJobList.Visible = false;
            ucJobFees.Visible = false;
            ucGenReqs.Visible = false;
            cmd = "select username'Username', Concat(fname , ' ' , lname)'Employee Name', DEPTNAME'Department' from Emp_t;";
            using (connection)
            {
                using (adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ucEmployee.dgvEmployee.DataSource = ds.Tables[0];
                }
            }
        }

        private void rbApplicant_CheckedChanged(object sender, EventArgs e)
        {
            ucEmployee.Visible = false;
            ucApplicant.Visible = true;
            ucCountry.Visible = false;
            ucEmployer.Visible = false;
            ucJobOrder.Visible = false;
            ucJobList.Visible = false;
            ucJobFees.Visible = false;
            ucGenReqs.Visible = false;
            cmd = "select username'Username', Concat(fname , ' ' , lname)'Employee Name', DEPTNAME'Department' from Emp_t;";
            using (connection)
            {
                using (adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ucEmployee.dgvEmployee.DataSource = ds.Tables[0];
                }
            }
        }

        private void rbCountry_CheckedChanged(object sender, EventArgs e)
        {
            ucEmployee.Visible = false;
            ucApplicant.Visible = false;
            ucCountry.Visible = true;
            ucEmployer.Visible = false;
            ucJobOrder.Visible = false;
            ucJobList.Visible = false;
            ucJobFees.Visible = false;
            ucGenReqs.Visible = false;
            cmd = "select username'Username', fname + ' ' + lname'Employee Name', DEPTNAME'Department' from Emp_t;";
            using (connection)
            {
                using (adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ucEmployee.dgvEmployee.DataSource = ds.Tables[0];
                }
            }
        }

        private void rbEmployer_CheckedChanged(object sender, EventArgs e)
        {
            ucEmployee.Visible = false;
            ucApplicant.Visible = false;
            ucCountry.Visible = false;
            ucEmployer.Visible = true;
            ucJobOrder.Visible = false;
            ucJobList.Visible = false;
            ucJobFees.Visible = false;
            ucGenReqs.Visible = false;
            cmd = "select username'Username', fname + ' ' + lname'Employee Name', DEPTNAME'Department' from Emp_t;";
            using (connection)
            {
                using (adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ucEmployee.dgvEmployee.DataSource = ds.Tables[0];
                }
            }
        }

        private void rbJobOrder_CheckedChanged(object sender, EventArgs e)
        {
            ucEmployee.Visible = false;
            ucApplicant.Visible = false;
            ucCountry.Visible = false;
            ucEmployer.Visible = false;
            ucJobOrder.Visible = true;
            ucJobList.Visible = false;
            ucJobFees.Visible = false;
            ucGenReqs.Visible = false;
            cmd = "select username'Username', fname + ' ' + lname'Employee Name', DEPTNAME'Department' from Emp_t;";
            using (connection)
            {
                using (adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ucEmployee.dgvEmployee.DataSource = ds.Tables[0];
                }
            }
        }

        private void rbJob_CheckedChanged(object sender, EventArgs e)
        {
            ucEmployee.Visible = false;
            ucApplicant.Visible = false;
            ucCountry.Visible = false;
            ucEmployer.Visible = false;
            ucJobOrder.Visible = false;
            ucJobList.Visible = true;
            ucJobFees.Visible = false;
            ucGenReqs.Visible = false;
            cmd = "select username'Username', fname + ' ' + lname'Employee Name', DEPTNAME'Department' from Emp_t;";
            using (connection)
            {
                using (adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ucEmployee.dgvEmployee.DataSource = ds.Tables[0];
                }
            }
        }

        private void rbFees_CheckedChanged(object sender, EventArgs e)
        {
            ucEmployee.Visible = false;
            ucApplicant.Visible = false;
            ucCountry.Visible = false;
            ucEmployer.Visible = false;
            ucJobOrder.Visible = false;
            ucJobList.Visible = false;
            ucJobFees.Visible = true;
            ucGenReqs.Visible = false;
            cmd = "select username'Username', fname + ' ' + lname'Employee Name', DEPTNAME'Department' from Emp_t;";
            using (connection)
            {
                using (adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ucEmployee.dgvEmployee.DataSource = ds.Tables[0];
                }
            }
        }

        private void rbGeneralRequirements_CheckedChanged(object sender, EventArgs e)
        {
            ucEmployee.Visible = false;
            ucApplicant.Visible = false;
            ucCountry.Visible = false;
            ucEmployer.Visible = false;
            ucJobOrder.Visible = false;
            ucJobList.Visible = false;
            ucJobFees.Visible = false;
            ucGenReqs.Visible = true;
        }

        private void ucMaintenance_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
        }
    }
}
