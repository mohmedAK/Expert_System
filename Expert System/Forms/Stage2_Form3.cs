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
    public partial class Stage2_Form3 : Syncfusion.Windows.Forms.MetroForm
    {
        public Stage2_Form3()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sfButton19_Click(object sender, EventArgs e)
        {
            if (labelR1.Text == "مقبول" &&
                labelR2.Text == "مقبول" &&
                labelR3.Text == "مقبول" &&
                labelR4.Text == "مقبول" &&
                labelR5.Text == "مقبول" &&
                labelR6.Text == "مقبول" &&
                labelR7.Text == "مقبول" &&
                labelR8.Text == "مقبول" &&
                labelR9.Text == "مقبول" )
            {
                Forms.Stage4FromStage2 frm = new Stage4FromStage2();
                frm.Show();
                this.Hide();
            }
            else
            {
                if (MessageBox.Show("لا يمكن الاستمرار لان بعض البيانات المدخله غير مقبوله ,هل تريد البدأ من مرحلة التخطيط؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Forms.InfoProject_Form1 frm = new InfoProject_Form1();
                    frm.Refresh();
                    frm.Show();
                    this.Hide();
                }
            }
           
        }

        private void sfButtonIneffectiveT1_Click(object sender, EventArgs e)
        {
            labelR1.Visible = true;
            labelR1.Text = "مقبول";
            labelR1.ForeColor = Color.Green;
        }

        private void sfButtonIneffectiveT2_Click(object sender, EventArgs e)
        {
            labelR2.Visible = true;
            labelR2.Text = "مقبول";
            labelR2.ForeColor = Color.Green;
        }

        private void sfButtonIneffectiveT3_Click(object sender, EventArgs e)
        {
            labelR3.Visible = true;
            labelR3.Text = "مقبول";
            labelR3.ForeColor = Color.Green;
        }

        private void sfButtonIneffectiveT4_Click(object sender, EventArgs e)
        {
            labelR4.Visible = true;
            labelR4.Text = "مقبول";
            labelR4.ForeColor = Color.Green;
        }

        private void sfButtonIneffectiveT5_Click(object sender, EventArgs e)
        {
            labelR5.Visible = true;
            labelR5.Text = "مقبول";
            labelR5.ForeColor = Color.Green;
        }

        private void sfButtonIneffectiveT6_Click(object sender, EventArgs e)
        {
            labelR6.Visible = true;
            labelR6.Text = "مقبول";
            labelR6.ForeColor = Color.Green;
        }

        private void sfButtonIneffectiveT7_Click(object sender, EventArgs e)
        {
            labelR7.Visible = true;
            labelR7.Text = "مقبول";
            labelR7.ForeColor = Color.Green;
        }

        private void sfButtonIneffectiveT8_Click(object sender, EventArgs e)
        {
            labelR8.Visible = true;
            labelR8.Text = "مقبول";
            labelR8.ForeColor = Color.Green;
        }

        private void sfButtonIneffectiveT9_Click(object sender, EventArgs e)
        {
            labelR9.Visible = true;
            labelR9.Text = "مقبول";
            labelR9.ForeColor = Color.Green;
        }

        private void sfButtonEffectiveT1_Click(object sender, EventArgs e)
        {
            labelR1.Visible = true;
            labelR1.Text = "غير مقبول";
            labelR1.ForeColor = Color.Red;
        }

        private void sfButtonEffectiveT2_Click(object sender, EventArgs e)
        {
            labelR2.Visible = true;
            labelR2.Text = "غير مقبول";
            labelR2.ForeColor = Color.Red;
        }

        private void sfButtonEffectiveT3_Click(object sender, EventArgs e)
        {
            labelR3.Visible = true;
            labelR3.Text = "غير مقبول";
            labelR3.ForeColor = Color.Red;
        }

        private void sfButtonEffectiveT4_Click(object sender, EventArgs e)
        {
            labelR4.Visible = true;
            labelR4.Text = "غير مقبول";
            labelR4.ForeColor = Color.Red;
        }

        private void sfButtonEffectiveT5_Click(object sender, EventArgs e)
        {
            labelR5.Visible = true;
            labelR5.Text = "غير مقبول";
            labelR5.ForeColor = Color.Red;
        }

        private void sfButtonEffectiveT6_Click(object sender, EventArgs e)
        {
            labelR6.Visible = true;
            labelR6.Text = "غير مقبول";
            labelR6.ForeColor = Color.Red;
        }

        private void sfButtonEffectiveT7_Click(object sender, EventArgs e)
        {
            labelR7.Visible = true;
            labelR7.Text = "غير مقبول";
            labelR7.ForeColor = Color.Red;
        }

        private void sfButtonEffectiveT8_Click(object sender, EventArgs e)
        {
            labelR8.Visible = true;
            labelR8.Text = "غير مقبول";
            labelR8.ForeColor = Color.Red;
        }

        private void sfButtonEffectiveT9_Click(object sender, EventArgs e)
        {
            labelR9.Visible = true;
            labelR9.Text = "غير مقبول";
            labelR9.ForeColor = Color.Red;
        }
    }
}
