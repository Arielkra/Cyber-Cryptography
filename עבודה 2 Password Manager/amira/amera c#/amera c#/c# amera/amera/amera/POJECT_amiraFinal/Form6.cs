using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//--------------------------------
using System.Data.OleDb;
//--------------------------------
namespace POJECT_amiraFinal
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        public bool CheckName(string str)
        {
            int i, c = 0, flag = 0;
            string str1 = str;
            for (i = 0; i < str.Length; i++)
            {

                if (str1[i] >= '0' && str1[i] <= '9')
                {
                    c++;
                    flag = 0;
                }
                else
                    flag = 1;

            }
            if (flag == 0 && c == 9)
                return true;
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string id_coustmer = textBox1.Text;
                if (CheckName(id_coustmer))
                {
                    string strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Travel.accdb;" + "Persist Security Info=False";
                    OleDbConnection conn = new OleDbConnection(strDb);
                    conn.Open();
                    OleDbDataReader dr;
                    OleDbCommand cmd = new OleDbCommand("Select * from coustmers where id_coustmer='" + textBox1.Text + "'  ;", conn); //command sql
                    dr = cmd.ExecuteReader(); // pointer to table


                    string str1 = "";
                    string str2 = "";
                    string str3 = "";
                    string str4 = "";
                    string str5 = "";
                    string str6 = "";
                    string str7 = "";
                    string str8 = "";
                    string str9 = "";
                    string str10 = "";


                    // read row from table
                    while (dr.Read())
                    {

                        str1 += dr["id_coustmer"] + "\n";
                        str2 += dr["fname"] + "\n";
                        str3 += dr["lname"] + "\n";
                        str4 += dr["wORm"] + "\n";
                        str10 += dr["travel_to"] + "\n";
                        str5 += dr["go_to"] + "\n";
                        str6 += dr["seat"] + "\n";
                        str7 += dr["price"] + "\n";
                        str8 += dr["flight_dirction"] + "\n";
                        str9 += dr["pic"];
                    }


                    dr.Close();
                    conn.Close();
                    label1.Text = str1;
                    label2.Text = str2;
                    label3.Text = str3;
                    label4.Text = str4;
                    label5.Text = str5;
                    label6.Text = str6;
                    label19.Text = str10;
                    label7.Text = str7;
                    label8.Text = str8;
                    // label9.Text = str9;
                    // pictureBox1.Image = Image.FromFile(@"D:\dugmaaccessandpicture\dugmaaccesscsharp\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\picture\" + str4);
                    pictureBox1.Image = Image.FromFile(@"pic\" + str9);
                }
                else
                {

                    MessageBox.Show("Your Id Number is more than 9 digits!!!");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
