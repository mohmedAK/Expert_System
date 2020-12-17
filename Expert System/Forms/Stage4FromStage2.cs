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
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace Mazin_Project.Forms
{
    public partial class Stage4FromStage2 : Syncfusion.Windows.Forms.MetroForm
    {
        public Stage4FromStage2()
        {
            InitializeComponent();
        }

        private void buttonMYes_Click(object sender, EventArgs e)
        {
            labelG2.Visible = true;
            groupBoxG2.Visible = true;
        }

        private void buttonTYes_Click(object sender, EventArgs e)
        {
            labelG3.Visible = true;
            groupBoxG3.Visible = true;
            labelResult.Text = "تمت الموافقة على تمؤيل المشروع ";
            labelResult.ForeColor = Color.Green;
            

        }

        private void buttonMNo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من رفض المشروع؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Forms.InfoProject_Form1 frm = new InfoProject_Form1();
                frm.Refresh();
                frm.Show();
                this.Hide();
            }
        }

        private void buttonTNo_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("هل انت متاكد من رفض المشروع؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Forms.InfoProject_Form1 frm = new InfoProject_Form1();
                frm.Refresh();
                frm.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forms.FinalReportStage4Froms2 frm = new FinalReportStage4Froms2();
            frm.Refresh();
            frm.Show();
            this.Hide();
        }

        private void Stage4FromStage2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
