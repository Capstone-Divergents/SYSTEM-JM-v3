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
    public partial class Payment : Form
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();
        MySqlDataAdapter adapter;
        private string cmd = "";
        private string appNo = "", appID = "";
        private string[] fees;
        private int balance = 0, count = 0;

        public Payment()
        {
            InitializeComponent();
        }

        public void init(string appno, string appid, string[] feelist, int total, int cnt)
        {
            appNo = appno;
            appID = appid;
            fees = new string[cnt];
            for(int x = 0; x < cnt; x++)
            {
                fees[x] = feelist[x];
            }
            count = cnt;
            balance = total;
            lblBalance.Text = total + "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            connection.Open();
            if(Convert.ToInt32(txtAmount.Text) >= balance)
            {
                for (int x = 0; x < count; x++)
                {
                    cmd = "update payables_t set feestatus = 'Paid', datepaid = current_date() where app_no = '"+appNo+"' and app_id = '"+appID+"' and fee_id = '"+fees[x]+"'";
                    com = new MySqlCommand(cmd, connection);
                    com.ExecuteNonQuery();
                }
                int ctr = 0;
                cmd = "select count(*) from receipts_t";
                com = new MySqlCommand(cmd, connection);
                ctr = int.Parse(com.ExecuteScalar() + "");
                string payID = "";
                if(ctr.ToString().Length == 1)
                {
                    payID = "P0000" + ctr.ToString();
                }
                else if (ctr.ToString().Length == 2)
                {
                    payID = "P000" + ctr.ToString();
                }
                else if (ctr.ToString().Length == 3)
                {
                    payID = "P00" + ctr.ToString();
                }
                else if (ctr.ToString().Length == 4)
                {
                    payID = "P0" + ctr.ToString();
                }
                else if (ctr.ToString().Length == 5)
                {
                    payID = "P" + ctr.ToString();
                }
                if(payID != "")
                {
                    cmd = "insert into receipts_t values ('"+payID+"','"+appID+"','"+lblBalance.Text+"','"+txtAmount.Text+"','"+ (Convert.ToInt32(txtAmount.Text) - Convert.ToInt32(lblBalance.Text))+"',current_date())";
                    com = new MySqlCommand(cmd, connection);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Balance Paid", "Payment");
                    this.Close();
                }
            }
            connection.Close();
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsSymbol(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsPunctuation(e.KeyChar)
                || Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
