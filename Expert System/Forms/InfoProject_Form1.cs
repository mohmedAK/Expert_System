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
    public partial class InfoProject_Form1 : Syncfusion.Windows.Forms.MetroForm
    {
        public InfoProject_Form1()
        {
            InitializeComponent();
        }
        bool isClear()
        {
            if (textBoxType.Text ==string.Empty ||
                doubleTextBoxProjectCost.Text == "0.00" ||
                integerTextBoxProjectTime.Text == "0" ||
                textBoxFinance.Text == string.Empty ||
                textBoxExcecute.Text ==string.Empty ||
                textBoxBainfit.Text == string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void sfButtonNextS1_Click(object sender, EventArgs e)
        {
            if (!isClear())
            {

                if (MessageBox.Show("هل انت متاكد من البيانات المدخله", "بيانات المشروع", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SQLiteConnection conn = new SQLiteConnection(config.DataSource))

                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        cmd.Connection = conn;
                        conn.Open();

                        SQLiteHelper sh = new SQLiteHelper(cmd);

                        sh.Execute("DELETE FROM infoproject");
                        var dic = new Dictionary<string, object>();

                        dic["ptype"] = textBoxType.Text;
                       
                        dic["pcost"] = double.Parse(doubleTextBoxProjectCost.Text);
                        dic["ptime"] = int.Parse(integerTextBoxProjectTime.Text);
                        dic["pfinance"] = textBoxFinance.Text;
                        dic["pexcute"] = textBoxExcecute.Text;
                        dic["pbainfit"] = textBoxBainfit.Text;

                        sh.Insert("infoproject", dic);

                        conn.Close();
                    }
                    Forms.Stage1_Form2 frm = new Stage1_Form2(double.Parse(doubleTextBoxSame.Text));
                    frm.Refresh();
                    frm.Show();
                    this.Hide();


                }
            }
            else
            {
                MessageBox.Show("Please Full All Data");
            }
           
        }

        private void InfoProject_Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
