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

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Findstaff
{
    public partial class Payment : Form
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();
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
            #region Query
            connection.Open();
            if(Convert.ToInt32(txtAmount.Text) >= balance)
            {
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
                    MessageBox.Show("Total Amount Paid: P" + lblBalance.Text + "\nPayment: P" + txtAmount.Text + "\nChange: P" + (Convert.ToInt32(txtAmount.Text) - Convert.ToInt32(lblBalance.Text)), "Payment Info");
                    for (int x = 0; x < count; x++)
                    {
                        cmd = "update payables_t set feestatus = 'Paid', datepaid = current_date(), pay_id = '"+payID+"' where app_no = '" + appNo + "' and app_id = '" + appID + "' and fee_id = '" + fees[x] + "'";
                        com = new MySqlCommand(cmd, connection);
                        com.ExecuteNonQuery();
                    }
                    cmd = "select count(fee_id) from payables_t where feestatus <> 'Paid' and app_no = '"+appNo+"'";
                    com = new MySqlCommand(cmd, connection);
                    int cnt = int.Parse(com.ExecuteScalar() + "");
                    if(cnt == 0)
                    {
                        cmd = "update app_t set appstatus = 'Deployed' where app_id = '" + appID + "'";
                        com = new MySqlCommand(cmd, connection);
                        com.ExecuteNonQuery();
                        MessageBox.Show("All fees are paid. Applicant status is deployed.", "Payment of Fees");
                    }

                    //cmd = "select f.feename'Fee Name', j.amount'Amount', p.feestatus'Status', from genfees_t f " +
                    //            "join payables_t p on f.fee_id = p.fee_id " +
                    //            "join applications_t app on app.app_no = p.app_no " +
                    //            "join jobfees_t j on j.jorder_id = j.jorder_id " +
                    //            "where p.app_no = 'A000000001' and j.jorder_id = ";
                    //com = new MySqlCommand(cmd, connection);
                    //int cnt1 = int.Parse(com.ExecuteScalar() + "");
                    //if (cnt1 == 0)
                    //{
                    //    Document doc = new Document(PageSize.A4, 30, 30, 50, 10);
                    //    PdfWriter pdf = PdfWriter.GetInstance(doc, new FileStream("C:\\Users\\jmcamilo435\\Desktop\\Receipt.pdf", FileMode.Create));
                    //    doc.Open();

                    //    doc = Data(doc);

                    //    doc.Close();
                    //    MessageBox.Show("Receipt Created Successfully!");
                    //}

                    //cmd = "select concat(app.lname, ', ', app.fname, ' ', app.mname)'Applicant Name', r.pay_id'Pay ID', r.amount'Amount', r.payment'Payment', r.chnge'Change', r.rdate'Date Paid' from receipts_t r " +
                    //            "join payables_t p on r.pay_id = p.pay_id " +
                    //            "join applications_t a on a.app_no = p.app_no " +
                    //            "join app_t app on app.app_id = a.app_id " +
                    //            "where r.pay_id = '" + payID + "';";
                    //com = new MySqlCommand(cmd, connection);
                    //int cnt2 = int.Parse(com.ExecuteScalar() + "");
                    //if (cnt2 == 0)
                    //{
                    //    Document doc = new Document(PageSize.A4, 30, 30, 50, 10);
                    //    PdfWriter pdf = PdfWriter.GetInstance(doc, new FileStream("C:\\Users\\jmcamilo435\\Desktop\\Receipt.pdf", FileMode.Create));
                    //    doc.Open();

                    //    doc = Data(doc);

                    //    doc.Close();
                    //    MessageBox.Show("Receipt Created Successfully!");
                    //}
                    this.Close();
                    ucAccoView a = new ucAccoView();
                    a.resetTable();
                }
            }
            connection.Close();
            #endregion
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
