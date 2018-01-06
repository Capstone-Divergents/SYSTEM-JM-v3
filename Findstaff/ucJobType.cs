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
    public partial class ucJobType : UserControl
    {
        MySqlCommand com;
        MySqlConnection connection;

        public ucJobType()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ucJobTypeAddEdit1.Dock = DockStyle.Fill;
            ucJobTypeAddEdit1.Visible = true;
            ucJobTypeAddEdit1.panel1.Visible = true;
            ucJobTypeAddEdit1.panel2.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(dgvJobType.Rows.Count != 0)
            {
                ucJobTypeAddEdit1.Dock = DockStyle.Fill;
                ucJobTypeAddEdit1.txtID.Text = dgvJobType.SelectedRows[0].Cells[0].Value.ToString();
                ucJobTypeAddEdit1.txtType2.Text = dgvJobType.SelectedRows[0].Cells[1].Value.ToString();
                ucJobTypeAddEdit1.Visible = true;
                ucJobTypeAddEdit1.panel1.Visible = false;
                ucJobTypeAddEdit1.panel2.Visible = true;
            }
        }

        private void ucJobTypeAddEdit1_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            string com = "Select JobType_ID'Jobtype ID', Typename'Job Types' from Jobtype_t";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(com, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvJobType.DataSource = ds.Tables[0];
                }
            }
        }
    }
}
