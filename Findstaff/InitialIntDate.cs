using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Findstaff
{
    public partial class InitialInterviewDate : Form
    {
        private MySqlCommand com;
        private MySqlConnection connection;
        private string cmd = "";
        private MySqlDataReader dr;

        public InitialInterviewDate()
        {
            InitializeComponent();
            
        }

        private void InitialInterviewDate_Load(object sender, EventArgs e)
        {
            Connection con = new Findstaff.Connection();
            connection = con.dbConnection();
            for (int x = DateTime.Now.Year; x < DateTime.Now.Year + 10; x++)
            {
                cbYear.Items.Add(x);
            }
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDay.Items.Clear();
            if(cbMonth.SelectedIndex == 0 || cbMonth.SelectedIndex == 2 || cbMonth.SelectedIndex == 4 || cbMonth.SelectedIndex == 6 ||
                cbMonth.SelectedIndex == 7 || cbMonth.SelectedIndex == 9 || cbMonth.SelectedIndex == 11)
            {
                for(int x = 1; x <=31; x++)
                {
                    cbDay.Items.Add(x);
                }
            }
            else if (cbMonth.SelectedIndex == 3 || cbMonth.SelectedIndex == 5 || cbMonth.SelectedIndex == 8 || cbMonth.SelectedIndex == 10)
            {
                for (int x = 1; x <= 30; x++)
                {
                    cbDay.Items.Add(x);
                }
            }
            else
            {
                for (int x = 1; x <= 28; x++)
                {
                    cbDay.Items.Add(x);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            connection.Open();
            ucJobApp ucja = new ucJobApp();
            for (int x = 0; x < ucja.dgvAppMatch.SelectedRows.Count; x++)
            {
                
            }
            connection.Close();
        }
    }
}
