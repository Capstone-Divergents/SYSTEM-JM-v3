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
    public partial class ucInterviewCriteria : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();
        private string cmd = "";

        public ucInterviewCriteria()
        {
            InitializeComponent();
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            int ctr = 0, err = 0;
            if (cb1x1.Checked == true)
            {
                ctr += 1;
            }
            else if (cb1x2.Checked == true)
            {
                ctr += 2;
            }
            else if (cb1x3.Checked == true)
            {
                ctr += 3;
            }
            else if (cb1x4.Checked == true)
            {
                ctr += 4;
            }
            else if (cb1x5.Checked == true)
            {
                ctr += 5;
            }
            else
            {
                err += 1;
            }
            if(err == 0)
            {
                if (cb2x1.Checked == true)
                {
                    ctr += 1;
                }
                else if (cb2x2.Checked == true)
                {
                    ctr += 2;
                }
                else if (cb2x3.Checked == true)
                {
                    ctr += 3;
                }
                else if (cb2x4.Checked == true)
                {
                    ctr += 4;
                }
                else if (cb2x5.Checked == true)
                {
                    ctr += 5;
                }
                else
                {
                    err += 1;
                }
                if (err == 0)
                {
                    if (cb3x1.Checked == true)
                    {
                        ctr += 1;
                    }
                    else if (cb3x2.Checked == true)
                    {
                        ctr += 2;
                    }
                    else if (cb3x3.Checked == true)
                    {
                        ctr += 3;
                    }
                    else if (cb3x4.Checked == true)
                    {
                        ctr += 4;
                    }
                    else if (cb3x5.Checked == true)
                    {
                        ctr += 5;
                    }
                    else
                    {
                        err += 1;
                    }
                    if (err == 0)
                    {
                        if (cb4x1.Checked == true)
                        {
                            ctr += 1;
                        }
                        else if (cb4x2.Checked == true)
                        {
                            ctr += 2;
                        }
                        else if (cb4x3.Checked == true)
                        {
                            ctr += 3;
                        }
                        else if (cb4x4.Checked == true)
                        {
                            ctr += 4;
                        }
                        else if (cb4x5.Checked == true)
                        {
                            ctr += 5;
                        }
                        else
                        {
                            err += 1;
                        }
                        if (err == 0)
                        {
                            if (cb5x1.Checked == true)
                            {
                                ctr += 1;
                            }
                            else if (cb5x2.Checked == true)
                            {
                                ctr += 2;
                            }
                            else if (cb5x3.Checked == true)
                            {
                                ctr += 3;
                            }
                            else if (cb5x4.Checked == true)
                            {
                                ctr += 4;
                            }
                            else if (cb5x5.Checked == true)
                            {
                                ctr += 5;
                            }
                            else
                            {
                                err += 1;
                            }
                            if (err == 0)
                            {
                                if (cb6x1.Checked == true)
                                {
                                    ctr += 1;
                                }
                                else if (cb6x2.Checked == true)
                                {
                                    ctr += 2;
                                }
                                else if (cb6x3.Checked == true)
                                {
                                    ctr += 3;
                                }
                                else if (cb6x4.Checked == true)
                                {
                                    ctr += 4;
                                }
                                else if (cb6x5.Checked == true)
                                {
                                    ctr += 5;
                                }
                                else
                                {
                                    err += 1;
                                }
                                if (err == 0)
                                {
                                    if (cb7x1.Checked == true)
                                    {
                                        ctr += 1;
                                    }
                                    else if (cb7x2.Checked == true)
                                    {
                                        ctr += 2;
                                    }
                                    else if (cb7x3.Checked == true)
                                    {
                                        ctr += 3;
                                    }
                                    else if (cb7x4.Checked == true)
                                    {
                                        ctr += 4;
                                    }
                                    else if (cb7x5.Checked == true)
                                    {
                                        ctr += 5;
                                    }
                                    else
                                    {
                                        err += 1;
                                    }
                                    if (err == 0)
                                    {
                                        if (cb8x1.Checked == true)
                                        {
                                            ctr += 1;
                                        }
                                        else if (cb8x2.Checked == true)
                                        {
                                            ctr += 2;
                                        }
                                        else if (cb8x3.Checked == true)
                                        {
                                            ctr += 3;
                                        }
                                        else if (cb8x4.Checked == true)
                                        {
                                            ctr += 4;
                                        }
                                        else if (cb8x5.Checked == true)
                                        {
                                            ctr += 5;
                                        }
                                        else
                                        {
                                            err += 1;
                                        }
                                        if (err == 0)
                                        {
                                            if (cb9x1.Checked == true)
                                            {
                                                ctr += 1;
                                            }
                                            else if (cb9x2.Checked == true)
                                            {
                                                ctr += 2;
                                            }
                                            else if (cb9x3.Checked == true)
                                            {
                                                ctr += 3;
                                            }
                                            else if (cb9x4.Checked == true)
                                            {
                                                ctr += 4;
                                            }
                                            else if (cb9x5.Checked == true)
                                            {
                                                ctr += 5;
                                            }
                                            else
                                            {
                                                err += 1;
                                            }
                                            if (err == 0)
                                            {
                                                if (cb10x1.Checked == true)
                                                {
                                                    ctr += 1;
                                                }
                                                else if (cb10x2.Checked == true)
                                                {
                                                    ctr += 2;
                                                }
                                                else if (cb10x3.Checked == true)
                                                {
                                                    ctr += 3;
                                                }
                                                else if (cb10x4.Checked == true)
                                                {
                                                    ctr += 4;
                                                }
                                                else if (cb10x5.Checked == true)
                                                {
                                                    ctr += 5;
                                                }
                                                else
                                                {
                                                    err += 1;
                                                }
                                                if (err == 0)
                                                {
                                                    if (cb11x1.Checked == true)
                                                    {
                                                        ctr += 1;
                                                    }
                                                    else if (cb11x2.Checked == true)
                                                    {
                                                        ctr += 2;
                                                    }
                                                    else if (cb11x3.Checked == true)
                                                    {
                                                        ctr += 3;
                                                    }
                                                    else if (cb11x4.Checked == true)
                                                    {
                                                        ctr += 4;
                                                    }
                                                    else if (cb11x5.Checked == true)
                                                    {
                                                        ctr += 5;
                                                    }
                                                    else
                                                    {
                                                        err += 1;
                                                    }
                                                    if (err == 0)
                                                    {
                                                        if (cb12x1.Checked == true)
                                                        {
                                                            ctr += 1;
                                                        }
                                                        else if (cb12x2.Checked == true)
                                                        {
                                                            ctr += 2;
                                                        }
                                                        else if (cb12x3.Checked == true)
                                                        {
                                                            ctr += 3;
                                                        }
                                                        else if (cb12x4.Checked == true)
                                                        {
                                                            ctr += 4;
                                                        }
                                                        else if (cb12x5.Checked == true)
                                                        {
                                                            ctr += 5;
                                                        }
                                                        else
                                                        {
                                                            err += 1;
                                                        }
                                                        if (err == 0)
                                                        {
                                                            if (cb13x1.Checked == true)
                                                            {
                                                                ctr += 1;
                                                            }
                                                            else if (cb13x2.Checked == true)
                                                            {
                                                                ctr += 2;
                                                            }
                                                            else if (cb13x3.Checked == true)
                                                            {
                                                                ctr += 3;
                                                            }
                                                            else if (cb13x4.Checked == true)
                                                            {
                                                                ctr += 4;
                                                            }
                                                            else if (cb13x5.Checked == true)
                                                            {
                                                                ctr += 5;
                                                            }
                                                            else
                                                            {
                                                                err += 1;
                                                            }
                                                            if (err == 0)
                                                            {
                                                                if (cb14x1.Checked == true)
                                                                {
                                                                    ctr += 1;
                                                                }
                                                                else if (cb14x2.Checked == true)
                                                                {
                                                                    ctr += 2;
                                                                }
                                                                else if (cb14x3.Checked == true)
                                                                {
                                                                    ctr += 3;
                                                                }
                                                                else if (cb14x4.Checked == true)
                                                                {
                                                                    ctr += 4;
                                                                }
                                                                else if (cb14x5.Checked == true)
                                                                {
                                                                    ctr += 5;
                                                                }
                                                                else
                                                                {
                                                                    err += 1;
                                                                }
                                                                if (err == 0)
                                                                {
                                                                    if (cb15x1.Checked == true)
                                                                    {
                                                                        ctr += 1;
                                                                    }
                                                                    else if (cb15x2.Checked == true)
                                                                    {
                                                                        ctr += 2;
                                                                    }
                                                                    else if (cb15x3.Checked == true)
                                                                    {
                                                                        ctr += 3;
                                                                    }
                                                                    else if (cb15x4.Checked == true)
                                                                    {
                                                                        ctr += 4;
                                                                    }
                                                                    else if (cb15x5.Checked == true)
                                                                    {
                                                                        ctr += 5;
                                                                    }
                                                                    else
                                                                    {
                                                                        err += 1;
                                                                    }
                                                                    if (err == 0)
                                                                    {
                                                                        if (cb16x1.Checked == true)
                                                                        {
                                                                            ctr += 1;
                                                                        }
                                                                        else if (cb16x2.Checked == true)
                                                                        {
                                                                            ctr += 2;
                                                                        }
                                                                        else if (cb16x3.Checked == true)
                                                                        {
                                                                            ctr += 3;
                                                                        }
                                                                        else if (cb16x4.Checked == true)
                                                                        {
                                                                            ctr += 4;
                                                                        }
                                                                        else if (cb16x5.Checked == true)
                                                                        {
                                                                            ctr += 5;
                                                                        }
                                                                        else
                                                                        {
                                                                            err += 1;
                                                                        }
                                                                        if (err == 0)
                                                                        {
                                                                            if (cb17x1.Checked == true)
                                                                            {
                                                                                ctr += 1;
                                                                            }
                                                                            else if (cb17x2.Checked == true)
                                                                            {
                                                                                ctr += 2;
                                                                            }
                                                                            else if (cb17x3.Checked == true)
                                                                            {
                                                                                ctr += 3;
                                                                            }
                                                                            else if (cb17x4.Checked == true)
                                                                            {
                                                                                ctr += 4;
                                                                            }
                                                                            else if (cb17x5.Checked == true)
                                                                            {
                                                                                ctr += 5;
                                                                            }
                                                                            else
                                                                            {
                                                                                err += 1;
                                                                            }
                                                                            if (err == 0)
                                                                            {
                                                                                if (cb18x1.Checked == true)
                                                                                {
                                                                                    ctr += 1;
                                                                                }
                                                                                else if (cb18x2.Checked == true)
                                                                                {
                                                                                    ctr += 2;
                                                                                }
                                                                                else if (cb18x3.Checked == true)
                                                                                {
                                                                                    ctr += 3;
                                                                                }
                                                                                else if (cb18x4.Checked == true)
                                                                                {
                                                                                    ctr += 4;
                                                                                }
                                                                                else if (cb18x5.Checked == true)
                                                                                {
                                                                                    ctr += 5;
                                                                                }
                                                                                else
                                                                                {
                                                                                    err += 1;
                                                                                }
                                                                                if (err == 0)
                                                                                {
                                                                                    if (cb19x1.Checked == true)
                                                                                    {
                                                                                        ctr += 1;
                                                                                    }
                                                                                    else if (cb19x2.Checked == true)
                                                                                    {
                                                                                        ctr += 2;
                                                                                    }
                                                                                    else if (cb19x3.Checked == true)
                                                                                    {
                                                                                        ctr += 3;
                                                                                    }
                                                                                    else if (cb19x4.Checked == true)
                                                                                    {
                                                                                        ctr += 4;
                                                                                    }
                                                                                    else if (cb19x5.Checked == true)
                                                                                    {
                                                                                        ctr += 5;
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        err += 1;
                                                                                    }
                                                                                    if (err == 0)
                                                                                    {
                                                                                        if (cb20x1.Checked == true)
                                                                                        {
                                                                                            ctr += 1;
                                                                                        }
                                                                                        else if (cb20x2.Checked == true)
                                                                                        {
                                                                                            ctr += 2;
                                                                                        }
                                                                                        else if (cb20x3.Checked == true)
                                                                                        {
                                                                                            ctr += 3;
                                                                                        }
                                                                                        else if (cb20x4.Checked == true)
                                                                                        {
                                                                                            ctr += 4;
                                                                                        }
                                                                                        else if (cb20x5.Checked == true)
                                                                                        {
                                                                                            ctr += 5;
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            err += 1;
                                                                                        }
                                                                                        if (err == 0)
                                                                                        {
                                                                                            if (cb21x1.Checked == true)
                                                                                            {
                                                                                                ctr += 1;
                                                                                            }
                                                                                            else if (cb21x2.Checked == true)
                                                                                            {
                                                                                                ctr += 2;
                                                                                            }
                                                                                            else if (cb21x3.Checked == true)
                                                                                            {
                                                                                                ctr += 3;
                                                                                            }
                                                                                            else if (cb21x4.Checked == true)
                                                                                            {
                                                                                                ctr += 4;
                                                                                            }
                                                                                            else if (cb21x5.Checked == true)
                                                                                            {
                                                                                                ctr += 5;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                err += 1;
                                                                                            }
                                                                                            if (err == 0)
                                                                                            {
                                                                                                if (cb22x1.Checked == true)
                                                                                                {
                                                                                                    ctr += 1;
                                                                                                }
                                                                                                else if (cb22x2.Checked == true)
                                                                                                {
                                                                                                    ctr += 2;
                                                                                                }
                                                                                                else if (cb22x3.Checked == true)
                                                                                                {
                                                                                                    ctr += 3;
                                                                                                }
                                                                                                else if (cb22x4.Checked == true)
                                                                                                {
                                                                                                    ctr += 4;
                                                                                                }
                                                                                                else if (cb22x5.Checked == true)
                                                                                                {
                                                                                                    ctr += 5;
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    err += 1;
                                                                                                }
                                                                                                if (err == 0)
                                                                                                {
                                                                                                    if (cb23x1.Checked == true)
                                                                                                    {
                                                                                                        ctr += 1;
                                                                                                    }
                                                                                                    else if (cb23x2.Checked == true)
                                                                                                    {
                                                                                                        ctr += 2;
                                                                                                    }
                                                                                                    else if (cb23x3.Checked == true)
                                                                                                    {
                                                                                                        ctr += 3;
                                                                                                    }
                                                                                                    else if (cb23x4.Checked == true)
                                                                                                    {
                                                                                                        ctr += 4;
                                                                                                    }
                                                                                                    else if (cb23x5.Checked == true)
                                                                                                    {
                                                                                                        ctr += 5;
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        err += 1;
                                                                                                    }
                                                                                                    if (err == 0)
                                                                                                    {
                                                                                                        if (cb24x1.Checked == true)
                                                                                                        {
                                                                                                            ctr += 1;
                                                                                                        }
                                                                                                        else if (cb24x2.Checked == true)
                                                                                                        {
                                                                                                            ctr += 2;
                                                                                                        }
                                                                                                        else if (cb24x3.Checked == true)
                                                                                                        {
                                                                                                            ctr += 3;
                                                                                                        }
                                                                                                        else if (cb24x4.Checked == true)
                                                                                                        {
                                                                                                            ctr += 4;
                                                                                                        }
                                                                                                        else if (cb24x5.Checked == true)
                                                                                                        {
                                                                                                            ctr += 5;
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            err += 1;
                                                                                                        }
                                                                                                        if (err == 0)
                                                                                                        {
                                                                                                            if (cb25x1.Checked == true)
                                                                                                            {
                                                                                                                ctr += 1;
                                                                                                            }
                                                                                                            else if (cb25x2.Checked == true)
                                                                                                            {
                                                                                                                ctr += 2;
                                                                                                            }
                                                                                                            else if (cb25x3.Checked == true)
                                                                                                            {
                                                                                                                ctr += 3;
                                                                                                            }
                                                                                                            else if (cb25x4.Checked == true)
                                                                                                            {
                                                                                                                ctr += 4;
                                                                                                            }
                                                                                                            else if (cb25x5.Checked == true)
                                                                                                            {
                                                                                                                ctr += 5;
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                err += 1;
                                                                                                            }
                                                                                                            if (err == 0)
                                                                                                            {
                                                                                                                if (cb26x1.Checked == true)
                                                                                                                {
                                                                                                                    ctr += 1;
                                                                                                                }
                                                                                                                else if (cb26x2.Checked == true)
                                                                                                                {
                                                                                                                    ctr += 2;
                                                                                                                }
                                                                                                                else if (cb26x3.Checked == true)
                                                                                                                {
                                                                                                                    ctr += 3;
                                                                                                                }
                                                                                                                else if (cb26x4.Checked == true)
                                                                                                                {
                                                                                                                    ctr += 4;
                                                                                                                }
                                                                                                                else if (cb26x5.Checked == true)
                                                                                                                {
                                                                                                                    ctr += 5;
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    err += 1;
                                                                                                                }
                                                                                                                if (err == 0)
                                                                                                                {
                                                                                                                    if (cb27x1.Checked == true)
                                                                                                                    {
                                                                                                                        ctr += 1;
                                                                                                                    }
                                                                                                                    else if (cb27x2.Checked == true)
                                                                                                                    {
                                                                                                                        ctr += 2;
                                                                                                                    }
                                                                                                                    else if (cb27x3.Checked == true)
                                                                                                                    {
                                                                                                                        ctr += 3;
                                                                                                                    }
                                                                                                                    else if (cb27x4.Checked == true)
                                                                                                                    {
                                                                                                                        ctr += 4;
                                                                                                                    }
                                                                                                                    else if (cb27x5.Checked == true)
                                                                                                                    {
                                                                                                                        ctr += 5;
                                                                                                                    }
                                                                                                                    else
                                                                                                                    {
                                                                                                                        err += 1;
                                                                                                                    }
                                                                                                                    if (err == 0)
                                                                                                                    {
                                                                                                                        if (cb28x1.Checked == true)
                                                                                                                        {
                                                                                                                            ctr += 1;
                                                                                                                        }
                                                                                                                        else if (cb28x2.Checked == true)
                                                                                                                        {
                                                                                                                            ctr += 2;
                                                                                                                        }
                                                                                                                        else if (cb28x3.Checked == true)
                                                                                                                        {
                                                                                                                            ctr += 3;
                                                                                                                        }
                                                                                                                        else if (cb28x4.Checked == true)
                                                                                                                        {
                                                                                                                            ctr += 4;
                                                                                                                        }
                                                                                                                        else if (cb28x5.Checked == true)
                                                                                                                        {
                                                                                                                            ctr += 5;
                                                                                                                        }
                                                                                                                        else
                                                                                                                        {
                                                                                                                            err += 1;
                                                                                                                        }
                                                                                                                        if (err == 0)
                                                                                                                        {
                                                                                                                            connection.Open();
                                                                                                                            if(ctr > 140 * 0.75)
                                                                                                                            {
                                                                                                                                cmd = "update applications_t set initinterviewstatus = 'Passed' where app_no = '" + txtAppNo.Text + "'";
                                                                                                                                com = new MySqlCommand(cmd, connection);
                                                                                                                                com.ExecuteNonQuery();
                                                                                                                                cmd = "update app_t set appstatus = 'For Final Interview' where Concat(lname, ', ', fname, ' ', mname) = '" + txtAppName.Text + "'";
                                                                                                                                com = new MySqlCommand(cmd, connection);
                                                                                                                                com.ExecuteNonQuery();
                                                                                                                                MessageBox.Show("Evaluation Result\n\nEvaluation Score : " + ctr.ToString() + " / 140\nInitial Interview Status: Passed");
                                                                                                                            }
                                                                                                                            else
                                                                                                                            {
                                                                                                                                cmd = "update applications_t set initinterviewstatus = 'Failed' where app_no = '" + txtAppNo.Text + "'";
                                                                                                                                com = new MySqlCommand(cmd, connection);
                                                                                                                                com.ExecuteNonQuery();
                                                                                                                                cmd = "update app_t set appstatus = 'Archived' where Concat(lname, ', ', fname, ' ', mname) = '" + txtAppName.Text + "'";
                                                                                                                                com = new MySqlCommand(cmd, connection);
                                                                                                                                com.ExecuteNonQuery();
                                                                                                                                MessageBox.Show("Evaluation Result\n\nEvaluation Score : " + ctr.ToString() + " / 140\nInitial Interview Status: Failed");
                                                                                                                            }
                                                                                                                            txtAppNo.Clear();
                                                                                                                            txtAppName.Clear();
                                                                                                                            txtJobOrderId.Clear();
                                                                                                                            txtJobName.Clear();
                                                                                                                            txtEmpName.Clear();
                                                                                                                            cb1x1.Checked = false;
                                                                                                                            cb1x2.Checked = false;
                                                                                                                            cb1x3.Checked = false;
                                                                                                                            cb1x4.Checked = false;
                                                                                                                            cb1x5.Checked = false;
                                                                                                                            cb2x1.Checked = false;
                                                                                                                            cb2x2.Checked = false;
                                                                                                                            cb2x3.Checked = false;
                                                                                                                            cb2x4.Checked = false;
                                                                                                                            cb2x5.Checked = false;
                                                                                                                            cb3x1.Checked = false;
                                                                                                                            cb3x2.Checked = false;
                                                                                                                            cb3x3.Checked = false;
                                                                                                                            cb3x4.Checked = false;
                                                                                                                            cb3x5.Checked = false;
                                                                                                                            cb4x1.Checked = false;
                                                                                                                            cb4x2.Checked = false;
                                                                                                                            cb4x3.Checked = false;
                                                                                                                            cb4x4.Checked = false;
                                                                                                                            cb4x5.Checked = false;
                                                                                                                            cb5x1.Checked = false;
                                                                                                                            cb5x2.Checked = false;
                                                                                                                            cb5x3.Checked = false;
                                                                                                                            cb5x4.Checked = false;
                                                                                                                            cb5x5.Checked = false;
                                                                                                                            cb6x1.Checked = false;
                                                                                                                            cb6x2.Checked = false;
                                                                                                                            cb6x3.Checked = false;
                                                                                                                            cb6x4.Checked = false;
                                                                                                                            cb6x5.Checked = false;
                                                                                                                            cb7x1.Checked = false;
                                                                                                                            cb7x2.Checked = false;
                                                                                                                            cb7x3.Checked = false;
                                                                                                                            cb7x4.Checked = false;
                                                                                                                            cb7x5.Checked = false;
                                                                                                                            cb8x1.Checked = false;
                                                                                                                            cb8x2.Checked = false;
                                                                                                                            cb8x3.Checked = false;
                                                                                                                            cb8x4.Checked = false;
                                                                                                                            cb8x5.Checked = false;
                                                                                                                            cb9x1.Checked = false;
                                                                                                                            cb9x2.Checked = false;
                                                                                                                            cb9x3.Checked = false;
                                                                                                                            cb9x4.Checked = false;
                                                                                                                            cb9x5.Checked = false;
                                                                                                                            cb10x1.Checked = false;
                                                                                                                            cb10x2.Checked = false;
                                                                                                                            cb10x3.Checked = false;
                                                                                                                            cb10x4.Checked = false;
                                                                                                                            cb10x5.Checked = false;
                                                                                                                            cb11x1.Checked = false;
                                                                                                                            cb11x2.Checked = false;
                                                                                                                            cb11x3.Checked = false;
                                                                                                                            cb11x4.Checked = false;
                                                                                                                            cb11x5.Checked = false;
                                                                                                                            cb12x1.Checked = false;
                                                                                                                            cb12x2.Checked = false;
                                                                                                                            cb12x3.Checked = false;
                                                                                                                            cb12x4.Checked = false;
                                                                                                                            cb12x5.Checked = false;
                                                                                                                            cb13x1.Checked = false;
                                                                                                                            cb13x2.Checked = false;
                                                                                                                            cb13x3.Checked = false;
                                                                                                                            cb13x4.Checked = false;
                                                                                                                            cb13x5.Checked = false;
                                                                                                                            cb14x1.Checked = false;
                                                                                                                            cb14x2.Checked = false;
                                                                                                                            cb14x3.Checked = false;
                                                                                                                            cb14x4.Checked = false;
                                                                                                                            cb14x5.Checked = false;
                                                                                                                            cb15x1.Checked = false;
                                                                                                                            cb15x2.Checked = false;
                                                                                                                            cb15x3.Checked = false;
                                                                                                                            cb15x4.Checked = false;
                                                                                                                            cb15x5.Checked = false;
                                                                                                                            cb16x1.Checked = false;
                                                                                                                            cb16x2.Checked = false;
                                                                                                                            cb16x3.Checked = false;
                                                                                                                            cb16x4.Checked = false;
                                                                                                                            cb16x5.Checked = false;
                                                                                                                            cb17x1.Checked = false;
                                                                                                                            cb17x2.Checked = false;
                                                                                                                            cb17x3.Checked = false;
                                                                                                                            cb17x4.Checked = false;
                                                                                                                            cb17x5.Checked = false;
                                                                                                                            cb18x1.Checked = false;
                                                                                                                            cb18x2.Checked = false;
                                                                                                                            cb18x3.Checked = false;
                                                                                                                            cb18x4.Checked = false;
                                                                                                                            cb18x5.Checked = false;
                                                                                                                            cb19x1.Checked = false;
                                                                                                                            cb19x2.Checked = false;
                                                                                                                            cb19x3.Checked = false;
                                                                                                                            cb19x4.Checked = false;
                                                                                                                            cb19x5.Checked = false;
                                                                                                                            cb20x1.Checked = false;
                                                                                                                            cb20x2.Checked = false;
                                                                                                                            cb20x3.Checked = false;
                                                                                                                            cb20x4.Checked = false;
                                                                                                                            cb20x5.Checked = false;
                                                                                                                            cb21x1.Checked = false;
                                                                                                                            cb21x2.Checked = false;
                                                                                                                            cb21x3.Checked = false;
                                                                                                                            cb21x4.Checked = false;
                                                                                                                            cb21x5.Checked = false;
                                                                                                                            cb22x1.Checked = false;
                                                                                                                            cb22x2.Checked = false;
                                                                                                                            cb22x3.Checked = false;
                                                                                                                            cb22x4.Checked = false;
                                                                                                                            cb22x5.Checked = false;
                                                                                                                            cb23x1.Checked = false;
                                                                                                                            cb23x2.Checked = false;
                                                                                                                            cb23x3.Checked = false;
                                                                                                                            cb23x4.Checked = false;
                                                                                                                            cb23x5.Checked = false;
                                                                                                                            cb24x1.Checked = false;
                                                                                                                            cb24x2.Checked = false;
                                                                                                                            cb24x3.Checked = false;
                                                                                                                            cb24x4.Checked = false;
                                                                                                                            cb24x5.Checked = false;
                                                                                                                            cb25x1.Checked = false;
                                                                                                                            cb25x2.Checked = false;
                                                                                                                            cb25x3.Checked = false;
                                                                                                                            cb25x4.Checked = false;
                                                                                                                            cb25x5.Checked = false;
                                                                                                                            cb26x1.Checked = false;
                                                                                                                            cb26x2.Checked = false;
                                                                                                                            cb26x3.Checked = false;
                                                                                                                            cb26x4.Checked = false;
                                                                                                                            cb26x5.Checked = false;
                                                                                                                            cb27x1.Checked = false;
                                                                                                                            cb27x2.Checked = false;
                                                                                                                            cb27x3.Checked = false;
                                                                                                                            cb27x4.Checked = false;
                                                                                                                            cb27x5.Checked = false;
                                                                                                                            cb28x1.Checked = false;
                                                                                                                            cb28x2.Checked = false;
                                                                                                                            cb28x3.Checked = false;
                                                                                                                            cb28x4.Checked = false;
                                                                                                                            cb28x5.Checked = false;
                                                                                                                            this.Hide();
                                                                                                                            connection.Close();
                                                                                                                        }
                                                                                                                        else
                                                                                                                        {
                                                                                                                            MessageBox.Show("No score chosen for Criteria #28", "Evaluation Constraint");
                                                                                                                        }
                                                                                                                    }
                                                                                                                    else
                                                                                                                    {
                                                                                                                        MessageBox.Show("No score chosen for Criteria #27", "Evaluation Constraint");
                                                                                                                    }
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    MessageBox.Show("No score chosen for Criteria #26", "Evaluation Constraint");
                                                                                                                }
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                MessageBox.Show("No score chosen for Criteria #25", "Evaluation Constraint");
                                                                                                            }
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            MessageBox.Show("No score chosen for Criteria #24", "Evaluation Constraint");
                                                                                                        }
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        MessageBox.Show("No score chosen for Criteria #23", "Evaluation Constraint");
                                                                                                    }
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    MessageBox.Show("No score chosen for Criteria #22", "Evaluation Constraint");
                                                                                                }
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                MessageBox.Show("No score chosen for Criteria #21", "Evaluation Constraint");
                                                                                            }
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            MessageBox.Show("No score chosen for Criteria #20", "Evaluation Constraint");
                                                                                        }
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        MessageBox.Show("No score chosen for Criteria #19", "Evaluation Constraint");
                                                                                    }
                                                                                }
                                                                                else
                                                                                {
                                                                                    MessageBox.Show("No score chosen for Criteria #18", "Evaluation Constraint");
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                MessageBox.Show("No score chosen for Criteria #17", "Evaluation Constraint");
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            MessageBox.Show("No score chosen for Criteria #16", "Evaluation Constraint");
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        MessageBox.Show("No score chosen for Criteria #15", "Evaluation Constraint");
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    MessageBox.Show("No score chosen for Criteria #14", "Evaluation Constraint");
                                                                }
                                                            }
                                                            else
                                                            {
                                                                MessageBox.Show("No score chosen for Criteria #13", "Evaluation Constraint");
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("No score chosen for Criteria #12", "Evaluation Constraint");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("No score chosen for Criteria #11", "Evaluation Constraint");
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("No score chosen for Criteria #10", "Evaluation Constraint");
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("No score chosen for Criteria #9", "Evaluation Constraint");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("No score chosen for Criteria #8", "Evaluation Constraint");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("No score chosen for Criteria #7", "Evaluation Constraint");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No score chosen for Criteria #6", "Evaluation Constraint");
                                }
                            }
                            else
                            {
                                MessageBox.Show("No score chosen for Criteria #5", "Evaluation Constraint");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No score chosen for Criteria #4", "Evaluation Constraint");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No score chosen for Criteria #3", "Evaluation Constraint");
                    }
                }
                else
                {
                    MessageBox.Show("No score chosen for Criteria #2", "Evaluation Constraint");
                }
            }
            else
            {
                MessageBox.Show("No score chosen for Criteria #1","Evaluation Constraint");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            txtAppNo.Clear();
            txtAppName.Clear();
            txtJobOrderId.Clear();
            txtJobName.Clear();
            txtEmpName.Clear();
            cb1x1.Checked = false;
            cb1x2.Checked = false;
            cb1x3.Checked = false;
            cb1x4.Checked = false;
            cb1x5.Checked = false;
            cb2x1.Checked = false;
            cb2x2.Checked = false;
            cb2x3.Checked = false;
            cb2x4.Checked = false;
            cb2x5.Checked = false;
            cb3x1.Checked = false;
            cb3x2.Checked = false;
            cb3x3.Checked = false;
            cb3x4.Checked = false;
            cb3x5.Checked = false;
            cb4x1.Checked = false;
            cb4x2.Checked = false;
            cb4x3.Checked = false;
            cb4x4.Checked = false;
            cb4x5.Checked = false;
            cb5x1.Checked = false;
            cb5x2.Checked = false;
            cb5x3.Checked = false;
            cb5x4.Checked = false;
            cb5x5.Checked = false;
            cb6x1.Checked = false;
            cb6x2.Checked = false;
            cb6x3.Checked = false;
            cb6x4.Checked = false;
            cb6x5.Checked = false;
            cb7x1.Checked = false;
            cb7x2.Checked = false;
            cb7x3.Checked = false;
            cb7x4.Checked = false;
            cb7x5.Checked = false;
            cb8x1.Checked = false;
            cb8x2.Checked = false;
            cb8x3.Checked = false;
            cb8x4.Checked = false;
            cb8x5.Checked = false;
            cb9x1.Checked = false;
            cb9x2.Checked = false;
            cb9x3.Checked = false;
            cb9x4.Checked = false;
            cb9x5.Checked = false;
            cb10x1.Checked = false;
            cb10x2.Checked = false;
            cb10x3.Checked = false;
            cb10x4.Checked = false;
            cb10x5.Checked = false;
            cb11x1.Checked = false;
            cb11x2.Checked = false;
            cb11x3.Checked = false;
            cb11x4.Checked = false;
            cb11x5.Checked = false;
            cb12x1.Checked = false;
            cb12x2.Checked = false;
            cb12x3.Checked = false;
            cb12x4.Checked = false;
            cb12x5.Checked = false;
            cb13x1.Checked = false;
            cb13x2.Checked = false;
            cb13x3.Checked = false;
            cb13x4.Checked = false;
            cb13x5.Checked = false;
            cb14x1.Checked = false;
            cb14x2.Checked = false;
            cb14x3.Checked = false;
            cb14x4.Checked = false;
            cb14x5.Checked = false;
            cb15x1.Checked = false;
            cb15x2.Checked = false;
            cb15x3.Checked = false;
            cb15x4.Checked = false;
            cb15x5.Checked = false;
            cb16x1.Checked = false;
            cb16x2.Checked = false;
            cb16x3.Checked = false;
            cb16x4.Checked = false;
            cb16x5.Checked = false;
            cb17x1.Checked = false;
            cb17x2.Checked = false;
            cb17x3.Checked = false;
            cb17x4.Checked = false;
            cb17x5.Checked = false;
            cb18x1.Checked = false;
            cb18x2.Checked = false;
            cb18x3.Checked = false;
            cb18x4.Checked = false;
            cb18x5.Checked = false;
            cb19x1.Checked = false;
            cb19x2.Checked = false;
            cb19x3.Checked = false;
            cb19x4.Checked = false;
            cb19x5.Checked = false;
            cb20x1.Checked = false;
            cb20x2.Checked = false;
            cb20x3.Checked = false;
            cb20x4.Checked = false;
            cb20x5.Checked = false;
            cb21x1.Checked = false;
            cb21x2.Checked = false;
            cb21x3.Checked = false;
            cb21x4.Checked = false;
            cb21x5.Checked = false;
            cb22x1.Checked = false;
            cb22x2.Checked = false;
            cb22x3.Checked = false;
            cb22x4.Checked = false;
            cb22x5.Checked = false;
            cb23x1.Checked = false;
            cb23x2.Checked = false;
            cb23x3.Checked = false;
            cb23x4.Checked = false;
            cb23x5.Checked = false;
            cb24x1.Checked = false;
            cb24x2.Checked = false;
            cb24x3.Checked = false;
            cb24x4.Checked = false;
            cb24x5.Checked = false;
            cb25x1.Checked = false;
            cb25x2.Checked = false;
            cb25x3.Checked = false;
            cb25x4.Checked = false;
            cb25x5.Checked = false;
            cb26x1.Checked = false;
            cb26x2.Checked = false;
            cb26x3.Checked = false;
            cb26x4.Checked = false;
            cb26x5.Checked = false;
            cb27x1.Checked = false;
            cb27x2.Checked = false;
            cb27x3.Checked = false;
            cb27x4.Checked = false;
            cb27x5.Checked = false;
            cb28x1.Checked = false;
            cb28x2.Checked = false;
            cb28x3.Checked = false;
            cb28x4.Checked = false;
            cb28x5.Checked = false;
            this.Hide();
        }

        private void ucInterviewCriteria_Load(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
        }
    }
}
