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
    public partial class FinalReportStage4From3 : Syncfusion.Windows.Forms.MetroForm
    {
        object[][] infoData;
        object[][] stage1Data;

        string[] mytext;
        int mychose;

        public FinalReportStage4From3(string []text,int chose)
        {
            InitializeComponent();
            mytext = text;
            mychose = chose;
            getData();
            fillData();
        }


        void getData()
        {
            infoData = GetProjectInformation("infoproject");
            stage1Data = GetProjectInformation("stage1");
        }
        void fillData()
        {
            textBoxType.Text = infoData[0][0].ToString();
            doubleTextBoxProjectCost.Text = infoData[0][1].ToString();
            integerTextBoxProjectTime.Text = infoData[0][2].ToString();
            textBoxFinance.Text = infoData[0][3].ToString();
            textBoxExcecute.Text = infoData[0][4].ToString();
            textBoxBainfit.Text = infoData[0][5].ToString();

            doubleTextBoxCash.Text = stage1Data[0][0].ToString();
            doubleTextBoxSame.Text = stage1Data[0][1].ToString();
            doubleTextBoxBalance.Text = stage1Data[0][2].ToString();

            buttonT1_1.Text = mytext[0]; labelT1.Text = (mytext[0] == "") ? ( "غير مؤثر") : ("مؤثر");
            buttonT2_1.Text = mytext[1]; labelT2.Text = (mytext[1] == "") ? ("غير مؤثر") : ("مؤثر");
            buttonT3_1.Text = mytext[2]; labelT3.Text = (mytext[2] == "") ? ("غير مؤثر") : ("مؤثر");
            buttonT4_1.Text = mytext[3]; labelT4.Text = (mytext[3] == "") ? ("غير مؤثر") : ("مؤثر");
            buttonT5_1.Text = mytext[4]; labelT5.Text = (mytext[4] == "") ? ("غير مؤثر") : ("مؤثر");
            buttonT6_1.Text = mytext[5]; labelT6.Text = (mytext[5] == "") ? ("غير مؤثر") : ("مؤثر");
            buttonT7_1.Text = mytext[6]; labelT7.Text = (mytext[6] == "") ? ("غير مؤثر") : ("مؤثر");
            buttonT8_1.Text = mytext[7]; labelT8.Text = (mytext[7] == "") ? ("غير مؤثر") : ("مؤثر");
            buttonT9_1.Text = mytext[8]; labelT9.Text = (mytext[8] == "") ? ("غير مؤثر") : ("مؤثر");
            buttonT10_1.Text = mytext[9]; labelT10.Text = (mytext[9] == "") ? ("غير مؤثر") : ("مؤثر");

            switch (mychose)
            {
                case 1:
                    labelchose.Text = "تمت الموافقة على المعالجات";
                    break;
                case 2:
                    labelchose.Text = "ثم اعداد خطة طوارئ";
                    break;
                case 3:
                    labelchose.Text = "تمت مفاتحة المكتب الاستشاري";
                    break;
                case 4:
                    labelchose.Text = "تم تامين المشروع";
                    break;
                case 5:
                    labelchose.Text = "تم نقل المشروع لطرف ثالث ";
                    break;
               
            }
        }

        public object[][] GetProjectInformation(string table)
        {
            string query = "SELECT * FROM " + table;
            using (SQLiteConnection conn = new SQLiteConnection(config.DataSource))
            {
                try
                {
                    //Open connection
                    conn.Open();
                    //Create Command
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    //Create a data reader and Execute the command
                    SQLiteDataReader dataReader = cmd.ExecuteReader();

                    //Read the data and store them in the list
                    int ColCount = dataReader.FieldCount;
                    List<object[]> rows = new List<object[]>();


                    while (dataReader.Read())
                    {
                        List<object> row = new List<object>();
                        for (int i = 0; i < ColCount; i++)
                        {
                            row.Add(dataReader[i]);
                        }
                        rows.Add(row.ToArray());
                    }

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    conn.Close();

                    //return list to be displayed
                    return rows.ToArray();
                }
                catch (Exception)
                {

                    return null;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forms.InfoProject_Form1 frm = new InfoProject_Form1();
            frm.Refresh();
            frm.Show();
            this.Hide();
        }

        private void FinalReportStage4From3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
