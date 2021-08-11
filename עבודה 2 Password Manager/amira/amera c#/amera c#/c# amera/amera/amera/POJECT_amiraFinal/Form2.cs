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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Travel.accdb;" + "Persist Security Info=False";
            OleDbConnection conn = new OleDbConnection(strDb);
            conn.Open();
            OleDbDataReader dr;
            OleDbCommand cmd = new OleDbCommand("Select * from Trips", conn); //command sql
            dr = cmd.ExecuteReader(); // pointer to table
            string str1 = "";
            string str2 = "";
            string str3 = "";
            string str4 = "";
            string str5 = "";
            string str6 = "";
            // string str7 = "";


            // read row from table
            while (dr.Read())
            {

                str1 += dr["trip_code"] + "\n";
                str2 += dr["travel_from"] + "\n";
                str3 += dr["goto"] + "\n";
                str4 += dr["date"] + "\n";
                str5 += dr["price"] + "\n";
                str6 += dr["staying"] + "\n";
                //  str7 += dr["pic"] + ToString()+"\n";
            }
            dr.Close();
            conn.Close();
            label1.Text = str1;
            label2.Text = str2;
            label3.Text = str3;
            label4.Text = str4;
            label5.Text = str5;
            label6.Text = str6;
            //label7.Text = str7;
        }
        public bool CheckName1(string str)
        {
            int i, c = 0, flag = 0;// flag1=0;
            string str1 = str;
            for (i = 0; i < str.Length; i++)
            {

                if (str1[i] >= '0' && str1[i] <= '9' || str1[i] == '/')
                {
                    c++;
                    // if ((str1[0] >= '0' || str1[0] == '3'|| str1[0] == '1'|| str1[0] == '2')  &&(str1[3] == '0' || str1[3] == '1'))
                    //{
                    //  flag1 = 1;
                    // }
                    flag = 0;
                }
                else
                {
                    flag = 1;
                    // flag1 = 1;
                }
            }
            if (flag == 0 && c == 10)
                return true;
            return false;
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
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string trip_code = textBox1.Text;
                string travel_from = textBox2.Text;
                string go_to = textBox3.Text;
                string date = textBox4.Text;
                int price = int.Parse(textBox5.Text);
                string staying = textBox6.Text;
                string pic = textBox7.Text;
                if (int.Parse(textBox5.Text) > 0 && CheckName(trip_code) && CheckName1(date) &&(travel_from!=go_to))
                {


                    string strDb;
                    strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Travel.accdb;" + "Persist Security Info=False";
                    OleDbConnection conn = new OleDbConnection(strDb);
                    conn.Open();
                    OleDbCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "insert into Trips values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "'," + textBox5.Text + ",'" + textBox6.Text + "','" + textBox7.Text + "');";
                    int n = cmd.ExecuteNonQuery();

                    MessageBox.Show("added " + n.ToString() + " row");
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("price not good OR travel code not 9 digits OR date not good && can not travel to same cuntry!!!");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Travel.accdb;" + "Persist Security Info=False";
                OleDbConnection conn = new OleDbConnection(strDb);
                conn.Open();
                OleDbDataReader dr;
                OleDbCommand cmd = new OleDbCommand("Select * from Trips where trip_code='" + textBox1.Text + "';", conn); //command sql
                dr = cmd.ExecuteReader(); // pointer to table
                string str1 = "";
                string str2 = "";
                string str3 = "";                                /*אם הוא מחפש ,אז יחפש את מקום יעד זה משחשוב*/
                string str4 = "";
                string str5 = "";
                string str6 = "";
                string str7 = "";
                // read row from table
                while (dr.Read())
                {

                    str1 += dr["trip_code"] + "\n";
                    str2 += dr["travel_from"] + "\n";
                    str3 += dr["goto"] + "\n";
                    str4 += dr["date"] + "\n";
                    str5 += dr["price"] + "\n";
                    str6 += dr["staying"] + "\n";
                    str7 += dr["pic"];

                }
                dr.Close();
                conn.Close();
                label1.Text = str1;
                label2.Text = str2;
                label3.Text = str3;
                label4.Text = str4;
                label5.Text = str5;
                label6.Text = str6;
                label7.Text = str7;
                // pictureBox1.Image = Image.FromFile(@"D:\dugmaaccessandpicture\dugmaaccesscsharp\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\picture\" + str4);
                pictureBox1.Image = Image.FromFile(@"pic\" + str7);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string trip_code = textBox1.Text;
                string strDb;
                strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Travel.accdb;" + "Persist Security Info=False";
                OleDbConnection conn = new OleDbConnection(strDb);
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandText = "delete from Trips where trip_code ='" + textBox1.Text + "';";
                int n = cmd.ExecuteNonQuery();

                MessageBox.Show("deleted " + n.ToString() + " row");
                conn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                textBox7.Text = openFileDialog1.SafeFileName;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {

                textBox2.Focus();

            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {

                textBox3.Focus();

            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {

                textBox4.Focus();

            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {

                textBox5.Focus();

            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {

                textBox6.Focus();

            }
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {

                textBox7.Focus();

            }
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {

                button5.Focus();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 j= new Form1();
            j.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form5 c = new Form5();
            c.Show();
            this.Hide();
        }
    }
}
