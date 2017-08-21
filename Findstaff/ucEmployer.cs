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
    public partial class ucEmployer : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();

        public ucEmployer()
        {
            InitializeComponent();
        }

        private void btnAdvSe_Click(object sender, EventArgs e)
        {
            fAdvSearch fas = new fAdvSearch();
            fas.Show();
        }

        private void btnEmpAdd_Click(object sender, EventArgs e)
        {
            ucEmployerAddEdit.Dock = DockStyle.Fill;
            ucEmployerAddEdit.Visible = true;
            ucEmployerAddEdit.panel1.Visible = true;
            ucEmployerAddEdit.panel2.Visible = false;
        }

        private void btnEmpEdit_Click(object sender, EventArgs e)
        {
            ucEmployerAddEdit.Dock = DockStyle.Fill;
            ucEmployerAddEdit.Visible = true;
            ucEmployerAddEdit.panel1.Visible = false;
            ucEmployerAddEdit.panel2.Visible = true;
        }

        private void btnEmpDel_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();
            string cmd = "delete from employer_t where employer_id = '" + dgvEmployer.SelectedRows[0].Cells[0].Value.ToString() + "';";
            com = new MySqlCommand(cmd, connection);
            com.ExecuteNonQuery();
            dgvEmployer.Rows.Remove(dgvEmployer.SelectedRows[0]);
            MessageBox.Show("Employer Deleted!", "Employer Record Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
        }

        private void btnEmpView_Click(object sender, EventArgs e)
        {
            ucEmployerView.Dock = DockStyle.Fill;
            ucEmployerView.Visible = true;
        }

        private void ucEmployerAddEdit_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            string com = "Select EMPLOYER_ID'Employer ID', EMPLOYERNAME'Employer Name', FOREIGNPRIN'Foreign Principal' from employer_t";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(com, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvEmployer.DataSource = ds.Tables[0];
                }
            }
        }
    }
}
