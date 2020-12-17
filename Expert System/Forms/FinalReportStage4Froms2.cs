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
    public partial class FinalReportStage4Froms2 : Syncfusion.Windows.Forms.MetroForm
    {
        object[][] infoData;
        object[][] stage1Data;

        public FinalReportStage4Froms2()
        {
            InitializeComponent();
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
            textBoxExcecute.Text  = infoData[0][4].ToString();
            textBoxBainfit.Text = infoData[0][5].ToString();


            doubleTextBoxCash.Text = stage1Data[0][0].ToString();
            doubleTextBoxSame.Text = stage1Data[0][1].ToString();
            doubleTextBoxBalance.Text = stage1Data[0][2].ToString();


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
        private void FinalReportStage4Froms2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forms.InfoProject_Form1 frm = new InfoProject_Form1();
            frm.Refresh();
            frm.Show();
            this.Hide();
        }

        private void FinalReportStage4Froms2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
