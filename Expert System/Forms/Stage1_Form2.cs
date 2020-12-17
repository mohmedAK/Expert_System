#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace Mazin_Project.Forms
{
    public partial class Stage1_Form2 : Syncfusion.Windows.Forms.MetroForm
    {
        double costProject;
        double ProjectSame;
        public Stage1_Form2(double sameCost)
        {
            InitializeComponent();
            ProjectSame = sameCost;
            getData();
           
        }

        bool isClear()
        {
            if (labelCash.Text == string.Empty ||
                labelBalance.Text == string.Empty ||
                labelSame.Text == string.Empty ||
                labelADDNot.Text == string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        void getData()
        {
            using (SQLiteConnection conn = new SQLiteConnection(config.DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);

                    DataTable dt = sh.Select("SELECT * FROM infoproject");

                    if (dt.Rows.Count > 0)
                    { 
                        costProject =double.Parse( dt.Rows[0][1].ToString());
                    }
                    dt.Clear();
                    conn.Close();
                }
            }
        }
        bool checkValid()
        {
            if (labelBalance.Text =="مقبول" &&
                labelCash.Text == "مقبول" &&
                labelSame.Text == "مقبول" &&
                labelADDNot.Text == "مقبول")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void sfButton1_Click(object sender, EventArgs e)
        {
            if (!isClear())
            {
                if (checkValid())
                {
                    using (SQLiteConnection conn = new SQLiteConnection(config.DataSource))

                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        cmd.Connection = conn;
                        conn.Open();

                        SQLiteHelper sh = new SQLiteHelper(cmd);

                        sh.Execute("DELETE FROM stage1");
                        var dic = new Dictionary<string, object>();

                        dic["cash"] =double.Parse( doubleTextBoxCash.Text);
                        dic["same"] = double.Parse(doubleTextBoxSame.Text);
                        dic["balance"] = double.Parse(doubleTextBoxBalance.Text);
                       

                        sh.Insert("stage1", dic);

                        conn.Close();
                    }

                    if (MessageBox.Show("اضغط نعم للانتقال الى مرحلة قبل الاحاله او اضغط كلا للانتقال الى مرحلة بعد الاحاله", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Forms.Stage2_Form3 frm = new Stage2_Form3();
                        frm.Refresh();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        Forms.Stage2And3_Form4 frm = new Stage2And3_Form4();
                        frm.Refresh();
                        frm.Show();
                        this.Hide();
                    }
                   
                }
                else
                {
                    if (MessageBox.Show("لا يمكن الاستمرار لان بعض البيانات المدخله غير مقبوله ,هل تريد البداء من جديد ؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        Forms.InfoProject_Form1 frm = new InfoProject_Form1();
                        frm.Refresh();
                        frm.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("يرجى ملىء جميع الحقول");
            }
           
        }

        private void sfButtonCheckCash_Click(object sender, EventArgs e)
        {
            double cash = Convert.ToDouble(doubleTextBoxCash.Text);
            if (cash >= costProject)
            {
                labelCash.Visible = true;
                labelCash.Text = "مقبول";
                labelCash.ForeColor = Color.Green;
                
            }
            else
            {
                labelCash.Visible = true;
                labelCash.Text = "غير مقبول";
                labelCash.ForeColor = Color.Red;
            }
        }

        private void sfButtonCheckSame_Click(object sender, EventArgs e)
        {
            double same = Convert.ToDouble(doubleTextBoxSame.Text);
            if (ProjectSame >= ((30 * costProject) /100) )
            {
                labelSame.Visible = true;
                labelSame.Text = "مقبول";
                labelSame.ForeColor = Color.Green;

            }
            else
            {
                labelSame.Visible = true;
                labelSame.Text = "غير مقبول";
                labelSame.ForeColor = Color.Red;
            }
        }

        private void sfButtonChackBalance_Click(object sender, EventArgs e)
        {
            double balance = double.Parse(doubleTextBoxBalance.Text);
            if (balance >= costProject)
            {
                labelBalance.Visible = true;
                labelBalance.Text = "مقبول";
                labelBalance.ForeColor = Color.Green;
            }
            else
            {
                labelBalance.Visible = true;
                labelBalance.Text = "غير مقبول";
                labelBalance.ForeColor = Color.Red;
            }
        }

        private void sfButtonAdd_Click(object sender, EventArgs e)
        {
            labelADDNot.Visible = true;
            labelADDNot.Text = "مقبول";
            labelADDNot.ForeColor = Color.Green;
        }

        private void sfButtonNotAdd_Click(object sender, EventArgs e)
        {
            labelADDNot.Visible = true;
            labelADDNot.Text = "غير مقبول";
            labelADDNot.ForeColor = Color.Red;
        }

        private void Stage1_Form2_Load(object sender, EventArgs e)
        {

        }

        private void Stage1_Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
