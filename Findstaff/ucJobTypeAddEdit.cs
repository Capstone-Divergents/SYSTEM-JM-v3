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
    public partial class ucJobTypeAddEdit : UserControl
    {
        MySqlConnection connection;
        MySqlCommand com;
        private string cmd = "";

        public ucJobTypeAddEdit()
        {
            InitializeComponent();
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            txtType.Clear();
            this.Hide();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            if(txtType.Text != "")
            {
                connection.Open();
                cmd = "insert into jobtype_t (typename) values ('"+txtType.Text+"')";
                com = new MySqlCommand(cmd, connection);
                com.ExecuteNonQuery();
                MessageBox.Show("New Job Type Added", "Add Job Type", MessageBoxButtons.OK, MessageBoxIcon.None);
                connection.Close();
                txtType.Clear();
                this.Hide();
            }
        }

        private void ucJobTypeAddEdit_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
        }
    }
}
