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
    public partial class Stage4FromStage3 : Syncfusion.Windows.Forms.MetroForm
    {
        int mychose;
        string[] myText;
        public Stage4FromStage3(string [] text)
        {
            InitializeComponent();
            myText = text;
        }

        private void buttonMYes_Click(object sender, EventArgs e)
        {
            mychose = 1;
            label2.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;

            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;

            button2.BackColor = Color.YellowGreen;
            button3.BackColor = Color.YellowGreen;
            button4.BackColor = Color.YellowGreen;
            button5.BackColor = Color.YellowGreen;

            labelG2.Visible = true;
            groupBoxG2.Visible = true;

        }

        private void buttonMNo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد تعديل المعالجات اضغط نعم او اذا اردت اختيار طرق حل اخرى اضغط كلا", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Forms.Stage2And3_Form4 frm = new Stage2And3_Form4();
                frm.Refresh();
                frm.Show();
                this.Hide();
            }
            else
            {
                label2.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;

                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;

                button2.BackColor = Color.YellowGreen;
                button3.BackColor = Color.YellowGreen;
                button4.BackColor = Color.YellowGreen;
                button5.BackColor = Color.YellowGreen;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mychose = 2;
            button2.BackColor = Color.Blue;
            button3.BackColor = Color.YellowGreen;
            button4.BackColor = Color.YellowGreen;
            button5.BackColor = Color.YellowGreen;

            labelG2.Visible = true;
            groupBoxG2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mychose = 3;
            button2.BackColor = Color.YellowGreen;
            button3.BackColor = Color.Blue;
            button4.BackColor = Color.YellowGreen;
            button5.BackColor = Color.YellowGreen;

            labelG2.Visible = true;
            groupBoxG2.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mychose = 4;
            button2.BackColor = Color.YellowGreen;
            button3.BackColor = Color.YellowGreen;
            button4.BackColor = Color.Blue;
            button5.BackColor = Color.YellowGreen;

            labelG2.Visible = true;
            groupBoxG2.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mychose = 5;
            button2.BackColor = Color.YellowGreen;
            button3.BackColor = Color.YellowGreen;
            button4.BackColor = Color.YellowGreen;
            button5.BackColor = Color.Blue;

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

        private void buttonTNo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("رجوع الى مرحلة تحديد المخاطر بعد الاحاله ؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Forms.Stage2And3_Form4 frm = new Stage2And3_Form4();
                frm.Refresh();
                frm.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forms.FinalReportStage4From3 frm = new FinalReportStage4From3(myText,mychose);
            frm.Refresh();
            frm.Show();
            this.Hide();
        }

        private void Stage4FromStage3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
