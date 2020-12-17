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
    public partial class Stage2And3_Form4 : Syncfusion.Windows.Forms.MetroForm
    {
        string[] text = new string[10];
        public Stage2And3_Form4()
        {
            InitializeComponent();
        }

        private void sfButtonIneffectiveT1_Click(object sender, EventArgs e)
        {
            text[0] = "";
            labelT1.Visible = true;
            labelT1.Text = "مقبول";
            labelT1.ForeColor = Color.Green;
            buttonT1_1.Enabled = false;
            buttonT1_2.Enabled = false;
            buttonT1_3.Enabled = false;
            buttonT1_4.Enabled = false;

            buttonT1_1.BackColor = Color.FromArgb(224, 224, 224);
            buttonT1_2.BackColor = Color.FromArgb(224, 224, 224);
            buttonT1_3.BackColor = Color.FromArgb(224, 224, 224);
            buttonT1_4.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void sfButtonIneffectiveT2_Click(object sender, EventArgs e)
        {
            text[1] = "";
            labelT2.Visible = true;
            labelT2.Text = "مقبول";
            labelT2.ForeColor = Color.Green;

            buttonT2_1.Enabled = false;
            buttonT2_2.Enabled = false;
           

            buttonT2_1.BackColor = Color.FromArgb(224, 224, 224);
            buttonT2_2.BackColor = Color.FromArgb(224, 224, 224);
           
        }

        private void sfButtonIneffectiveT3_Click(object sender, EventArgs e)
        {
            text[2] = "";
            labelT3.Visible = true;
            labelT3.Text = "مقبول";
            labelT3.ForeColor = Color.Green;

            buttonT3_1.Enabled = false;
            buttonT3_2.Enabled = false;
            buttonT3_3.Enabled = false;
            buttonT3_4.Enabled = false;

            buttonT3_1.BackColor = Color.FromArgb(224, 224, 224);
            buttonT3_2.BackColor = Color.FromArgb(224, 224, 224);
            buttonT3_3.BackColor = Color.FromArgb(224, 224, 224);
            buttonT3_4.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void sfButtonIneffectiveT4_Click(object sender, EventArgs e)
        {
            text[3] = "";
            labelT4.Visible = true;
            labelT4.Text = "مقبول";
            labelT4.ForeColor = Color.Green;

            buttonT4_1.Enabled = false;
            buttonT4_2.Enabled = false;


            buttonT4_1.BackColor = Color.FromArgb(224, 224, 224);
            buttonT4_2.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void sfButtonIneffectiveT5_Click(object sender, EventArgs e)
        {
            text[4] = "";
            labelT5.Visible = true;
            labelT5.Text = "مقبول";
            labelT5.ForeColor = Color.Green;

            buttonT5_1.Enabled = false;
            buttonT5_2.Enabled = false;
           

            buttonT5_1.BackColor = Color.FromArgb(224, 224, 224);
            buttonT5_2.BackColor = Color.FromArgb(224, 224, 224);
           
        }

        private void sfButtonIneffectiveT6_Click(object sender, EventArgs e)
        {
            text[5] = "";
            labelT6.Visible = true;
            labelT6.Text = "مقبول";
            labelT6.ForeColor = Color.Green;

            buttonT6_1.Enabled = false;
           


            buttonT6_1.BackColor = Color.FromArgb(224, 224, 224);
           
        }

        private void sfButtonIneffectiveT7_Click(object sender, EventArgs e)
        {
            text[6] = "";
            labelT7.Visible = true;
            labelT7.Text = "مقبول";
            labelT7.ForeColor = Color.Green;

            buttonT7_1.Enabled = false;
            buttonT7_2.Enabled = false;
           


            buttonT7_1.BackColor = Color.FromArgb(224, 224, 224);
            buttonT7_2.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void sfButtonIneffectiveT8_Click(object sender, EventArgs e)
        {
            text[7] = "";
            labelT8.Visible = true;
            labelT8.Text = "مقبول";
            labelT8.ForeColor = Color.Green;

            buttonT8_1.Enabled = false;
            buttonT8_2.Enabled = false;

            buttonT8_1.BackColor = Color.FromArgb(224, 224, 224);
            buttonT8_2.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void sfButtonIneffectiveT9_Click(object sender, EventArgs e)
        {
            text[8] = "";
            labelT9.Visible = true;
            labelT9.Text = "مقبول";
            labelT9.ForeColor = Color.Green;

            buttonT9_1.Enabled = false;
            buttonT9_2.Enabled = false;

            buttonT9_1.BackColor = Color.FromArgb(224, 224, 224);
            buttonT9_2.BackColor = Color.FromArgb(224, 224, 224);
        }


        private void sfButtonIneffectiveT10_Click(object sender, EventArgs e)
        {
            text[9] = "";
            labelT10.Visible = true;
            labelT10.Text = "مقبول";
            labelT10.ForeColor = Color.Green;

            buttonT10_1.Enabled = false;
            

            buttonT10_1.BackColor = Color.FromArgb(224, 224, 224);
        }


        private void sfButtonEffectiveT1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("يرجى اختيار احد طرق المعالجة المقترحة");
            buttonT1_1.Enabled = true;
            buttonT1_2.Enabled = true;
            buttonT1_3.Enabled = true;
            buttonT1_4.Enabled = true;

        }

        private void buttonT1_1_Click(object sender, EventArgs e)
        {
            buttonT1_1.BackColor = Color.Green;
            labelT1.Visible = true;
            labelT1.Text = "مقبول";
            labelT1.ForeColor = Color.Green;
            text[0] = buttonT1_1.Text;
            //buttonT1_1.BackColor = Color.FromArgb(224, 224, 224);
            buttonT1_2.BackColor = Color.FromArgb(224, 224, 224);
            buttonT1_3.BackColor = Color.FromArgb(224, 224, 224);
            buttonT1_4.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void buttonT1_2_Click(object sender, EventArgs e)
        {
            text[0] = buttonT1_2.Text;
            buttonT1_2.BackColor = Color.Green;
            labelT1.Visible = true;
            labelT1.Text = "مقبول";
            labelT1.ForeColor = Color.Green;

            buttonT1_1.BackColor = Color.FromArgb(224, 224, 224);
           // buttonT1_2.BackColor = Color.FromArgb(224, 224, 224);
            buttonT1_3.BackColor = Color.FromArgb(224, 224, 224);
            buttonT1_4.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void buttonT1_3_Click(object sender, EventArgs e)
        {
            text[0] = buttonT1_3.Text;
            buttonT1_3.BackColor = Color.Green;
            labelT1.Visible = true;
            labelT1.Text = "مقبول";
            labelT1.ForeColor = Color.Green;

            buttonT1_1.BackColor = Color.FromArgb(224, 224, 224);
            buttonT1_2.BackColor = Color.FromArgb(224, 224, 224);
           // buttonT1_3.BackColor = Color.FromArgb(224, 224, 224);
            buttonT1_4.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void buttonT1_4_Click(object sender, EventArgs e)
        {
            text[0] = buttonT1_4.Text;
            buttonT1_4.BackColor = Color.Green;
            labelT1.Visible = true;
            labelT1.Text = "مقبول";
            labelT1.ForeColor = Color.Green;

            buttonT1_1.BackColor = Color.FromArgb(224, 224, 224);
            buttonT1_2.BackColor = Color.FromArgb(224, 224, 224);
            buttonT1_3.BackColor = Color.FromArgb(224, 224, 224);
           // buttonT1_4.BackColor = Color.FromArgb(224, 224, 224);
        }


        private void sfButtonEffectiveT2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("يرجى اختيار احد طرق المعالجة المقترحة");
            buttonT2_1.Enabled = true;
            buttonT2_2.Enabled = true;
            
        }

        private void buttonT2_1_Click(object sender, EventArgs e)
        {
            text[1] = buttonT2_1.Text;
            buttonT2_1.BackColor = Color.Green;
            labelT2.Visible = true;
            labelT2.Text = "مقبول";
            labelT2.ForeColor = Color.Green;

            //buttonT1_1.BackColor = Color.FromArgb(224, 224, 224);
            buttonT2_2.BackColor = Color.FromArgb(224, 224, 224);
           
        }

        private void buttonT2_2_Click(object sender, EventArgs e)
        {
            text[1] = buttonT2_2.Text;
            buttonT2_2.BackColor = Color.Green;
            labelT2.Visible = true;
            labelT2.Text = "مقبول";
            labelT2.ForeColor = Color.Green;

            buttonT1_1.BackColor = Color.FromArgb(224, 224, 224);
           // buttonT2_2.BackColor = Color.FromArgb(224, 224, 224);
        }


        private void sfButtonEffectiveT3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("يرجى اختيار احد طرق المعالجة المقترحة");
            buttonT3_1.Enabled = true;
            buttonT3_2.Enabled = true;
            buttonT3_3.Enabled = true;
            buttonT3_4.Enabled = true;
        }

        private void buttonT3_1_Click(object sender, EventArgs e)
        {
            text[2] = buttonT3_1.Text;
            buttonT3_1.BackColor = Color.Green;
            labelT3.Visible = true;
            labelT3.Text = "مقبول";
            labelT3.ForeColor = Color.Green;

            //buttonT3_1.BackColor = Color.FromArgb(224, 224, 224);
            buttonT3_2.BackColor = Color.FromArgb(224, 224, 224);
            buttonT3_3.BackColor = Color.FromArgb(224, 224, 224);
            buttonT3_4.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void buttonT3_2_Click(object sender, EventArgs e)
        {
            text[2] = buttonT3_2.Text;
            buttonT3_2.BackColor = Color.Green;
            labelT3.Visible = true;
            labelT3.Text = "مقبول";
            labelT3.ForeColor = Color.Green;

            buttonT3_1.BackColor = Color.FromArgb(224, 224, 224);
           // buttonT3_2.BackColor = Color.FromArgb(224, 224, 224);
            buttonT3_3.BackColor = Color.FromArgb(224, 224, 224);
            buttonT3_4.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void buttonT3_3_Click(object sender, EventArgs e)
        {
            text[2] = buttonT3_3.Text;
            buttonT3_3.BackColor = Color.Green;
            labelT3.Visible = true;
            labelT3.Text = "مقبول";
            labelT3.ForeColor = Color.Green;

            buttonT3_1.BackColor = Color.FromArgb(224, 224, 224);
            buttonT3_2.BackColor = Color.FromArgb(224, 224, 224);
            //buttonT3_3.BackColor = Color.FromArgb(224, 224, 224);
            buttonT3_4.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void buttonT3_4_Click(object sender, EventArgs e)
        {
            text[2] = buttonT3_4.Text;
            buttonT3_4.BackColor = Color.Green;
            labelT3.Visible = true;
            labelT3.Text = "مقبول";
            labelT3.ForeColor = Color.Green;

            buttonT3_1.BackColor = Color.FromArgb(224, 224, 224);
            buttonT3_2.BackColor = Color.FromArgb(224, 224, 224);
            buttonT3_3.BackColor = Color.FromArgb(224, 224, 224);
            //buttonT3_4.BackColor = Color.FromArgb(224, 224, 224);
        }


        private void sfButtonEffectiveT4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("يرجى اختيار احد طرق المعالجة المقترحة");
            buttonT4_1.Enabled = true;
            buttonT4_2.Enabled = true;
           
        }

        private void buttonT4_1_Click(object sender, EventArgs e)
        {
            text[3] = buttonT4_1.Text;
            buttonT4_1.BackColor = Color.Green;
            labelT4.Visible = true;
            labelT4.Text = "مقبول";
            labelT4.ForeColor = Color.Green;

           // buttonT4_1.BackColor = Color.FromArgb(224, 224, 224);
            buttonT4_2.BackColor = Color.FromArgb(224, 224, 224);
           
        }

        private void buttonT4_2_Click(object sender, EventArgs e)
        {
            text[3] = buttonT4_2.Text;
            buttonT4_2.BackColor = Color.Green;
            labelT4.Visible = true;
            labelT4.Text = "مقبول";
            labelT4.ForeColor = Color.Green;

             buttonT4_1.BackColor = Color.FromArgb(224, 224, 224);
            //buttonT4_2.BackColor = Color.FromArgb(224, 224, 224);
        }


        private void sfButtonEffectiveT5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("يرجى اختيار احد طرق المعالجة المقترحة");
            buttonT5_1.Enabled = true;
            buttonT5_2.Enabled = true;
           
        }

        private void buttonT5_1_Click(object sender, EventArgs e)
        {
            text[4] = buttonT5_1.Text;
            buttonT5_1.BackColor = Color.Green;
            labelT5.Visible = true;
            labelT5.Text = "مقبول";
            labelT5.ForeColor = Color.Green;

            //buttonT5_1.BackColor = Color.FromArgb(224, 224, 224);
            buttonT5_2.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void buttonT5_2_Click(object sender, EventArgs e)
        {
            text[4] = buttonT5_2.Text;
            buttonT5_2.BackColor = Color.Green;
            labelT5.Visible = true;
            labelT5.Text = "مقبول";
            labelT5.ForeColor = Color.Green;

            buttonT5_1.BackColor = Color.FromArgb(224, 224, 224);
            //buttonT5_2.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void sfButtonEffectiveT6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("يرجى اختيار احد طرق المعالجة المقترحة");
            buttonT6_1.Enabled = true;
           
        }

        private void buttonT6_1_Click(object sender, EventArgs e)
        {
            text[5] = buttonT6_1.Text;
            buttonT6_1.BackColor = Color.Green;
            labelT6.Visible = true;
            labelT6.Text = "مقبول";
            labelT6.ForeColor = Color.Green;
        }

        private void sfButtonEffectiveT7_Click(object sender, EventArgs e)
        {

            MessageBox.Show("يرجى اختيار احد طرق المعالجة المقترحة");
            buttonT7_1.Enabled = true;
            buttonT7_2.Enabled = true;
           
        }

        private void buttonT7_1_Click(object sender, EventArgs e)
        {
            text[6] = buttonT7_1.Text;
            buttonT7_1.BackColor = Color.Green;
            labelT7.Visible = true;
            labelT7.Text = "مقبول";
            labelT7.ForeColor = Color.Green;

            //buttonT7_1.BackColor = Color.FromArgb(224, 224, 224);
            buttonT7_2.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void buttonT7_2_Click(object sender, EventArgs e)
        {
            text[6] = buttonT7_2.Text;
            buttonT7_2.BackColor = Color.Green;
            labelT7.Visible = true;
            labelT7.Text = "مقبول";
            labelT7.ForeColor = Color.Green;

            buttonT7_1.BackColor = Color.FromArgb(224, 224, 224);
           // buttonT7_2.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void sfButtonEffectiveT8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("يرجى اختيار احد طرق المعالجة المقترحة");
            buttonT8_1.Enabled = true;
            buttonT8_2.Enabled = true;
        }

        private void buttonT8_1_Click(object sender, EventArgs e)
        {
            text[7] = buttonT8_1.Text;
            buttonT8_1.BackColor = Color.Green;
            labelT8.Visible = true;
            labelT8.Text = "مقبول";
            labelT8.ForeColor = Color.Green;

            //buttonT8_1.BackColor = Color.FromArgb(224, 224, 224);
            buttonT8_2.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void buttonT8_2_Click(object sender, EventArgs e)
        {
            text[7] = buttonT8_2.Text;
            buttonT8_2.BackColor = Color.Green;
            labelT8.Visible = true;
            labelT8.Text = "مقبول";
            labelT8.ForeColor = Color.Green;

            buttonT8_1.BackColor = Color.FromArgb(224, 224, 224);
            //buttonT8_2.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void sfButtonEffectiveT9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("يرجى اختيار احد طرق المعالجة المقترحة");
            buttonT9_1.Enabled = true;
            buttonT9_2.Enabled = true;
        }

        private void buttonT9_1_Click(object sender, EventArgs e)
        {
            text[8] = buttonT9_1.Text;
            buttonT9_1.BackColor = Color.Green;
            labelT9.Visible = true;
            labelT9.Text = "مقبول";
            labelT9.ForeColor = Color.Green;

            //buttonT9_1.BackColor = Color.FromArgb(224, 224, 224);
            buttonT9_2.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void buttonT9_2_Click(object sender, EventArgs e)
        {
            text[8] = buttonT9_2.Text;
            buttonT9_2.BackColor = Color.Green;
            labelT9.Visible = true;
            labelT9.Text = "مقبول";
            labelT9.ForeColor = Color.Green;

            buttonT9_1.BackColor = Color.FromArgb(224, 224, 224);
           // buttonT9_2.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void sfButtonEffectiveT10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("يرجى اختيار احد طرق المعالجة المقترحة");
            buttonT10_1.Enabled = true;
            
        }

        private void buttonT10_1_Click(object sender, EventArgs e)
        {
            text[9] = buttonT10_1.Text;
            buttonT10_1.BackColor = Color.Green;
            labelT10.Visible = true;
            labelT10.Text = "مقبول";
            labelT10.ForeColor = Color.Green;
        }

        private void sfButtonNext_Click(object sender, EventArgs e)
        {
            if (labelT1.Text == "مقبول" &&
               labelT2.Text == "مقبول" &&
               labelT3.Text == "مقبول" &&
               labelT4.Text == "مقبول" &&
               labelT5.Text == "مقبول" &&
               labelT6.Text == "مقبول" &&
               labelT7.Text == "مقبول" &&
               labelT8.Text == "مقبول" &&
               labelT9.Text == "مقبول" &&
               labelT10.Text == "مقبول")
            {
                Forms.Stage4FromStage3 frm = new Stage4FromStage3(text);
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

        private void Stage2And3_Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
