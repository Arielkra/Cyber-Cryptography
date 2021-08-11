using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Data.OleDb;

namespace UsernamePassword2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void Sha_Load(object sender, EventArgs e)
        {

        }
        public string maksha1(string str)        {            SHA1CryptoServiceProvider sh = new SHA1CryptoServiceProvider();            sh.ComputeHash(ASCIIEncoding.ASCII.GetBytes(str));            byte[] re = sh.Hash;            StringBuilder sb = new StringBuilder();            foreach (byte b in re)            {                sb.Append(b.ToString("X2"));            }            return sb.ToString();        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                string strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Passwordlogin.accdb;" + "Persist Security Info=False";
                OleDbConnection conn = new OleDbConnection(strDb);
                conn.Open();
                OleDbDataReader dr;
                OleDbCommand cmd = new OleDbCommand("Select * from compusers where username='" + textBox1.Text + "' and password='" + maksha1(textBox2.Text)+"'and company='" + comboBox1.Text + "';", conn);

                dr = cmd.ExecuteReader();

                string str1 = "";
                string str2 = "";
                string str3 = "";
                

                while (dr.Read())
                {

                    str1 += dr["username"] + "\n";
                    str2 += dr["password"] + "\n";
                    str3 += dr["company"] + "\n";


                }
                dr.Close();
                conn.Close();
                if (str1 == "" && str2 == "" && str3 == "")
                {



                     MessageBox.Show("Your User name Or Password Or Site NotGood!\n\n Please Try Again!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                   



                }
                else
                {
                   

                    MessageBox.Show("Your Password OK!", "Your Password OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (comboBox1.Text == "Amazon")
                    {
                        System.Diagnostics.Process.Start("http://www.amazon.com");
                    }
                    else if (comboBox1.Text == "Ebay")
                    {
                        System.Diagnostics.Process.Start("http://www.Ebay.com");
                    }
                    else if (comboBox1.Text == "Facebook")
                    {
                        System.Diagnostics.Process.Start("http://www.Facebook.com");
                    }
                    else if (comboBox1.Text == "Instegram")
                    {
                        System.Diagnostics.Process.Start("http://www.Instegram.com");
                    }
                    else if (comboBox1.Text == "Walla Mail")
                    {
                        System.Diagnostics.Process.Start("https://friends.walla.co.il/recovery");
                    }
                    else if (comboBox1.Text == "Gmail")
                    {
                        System.Diagnostics.Process.Start("https://www.gmail.com");
                    }
                    else if (comboBox1.Text == "Zoom")
                    {
                        System.Diagnostics.Process.Start("https://www.zoom.com");
                    }
                    else if (comboBox1.Text == "Bank")
                    {
                        System.Diagnostics.Process.Start("https://www.bankhapoalim.co.il/he");
                    }
                    else if (comboBox1.Text == "Cellcome")
                    {
                        System.Diagnostics.Process.Start("https://www.Cellcome.co.il/");
                    }
                    else if (comboBox1.Text == "Isracard")
                    {
                        System.Diagnostics.Process.Start("https://www.Isracard.co.il/");
                    }

                }
               

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                string fname = textBox1.Text;



                string strDb;
                strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Passwordlogin.accdb;" + "Persist Security Info=False";
                OleDbConnection conn = new OleDbConnection(strDb);
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from company";
                OleDbDataReader n = cmd.ExecuteReader();
                while (n.Read())
                {
                    comboBox1.Items.Add(n["company"].ToString());

                }


                conn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

           
        }
       

        private void button21_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 aaa = new Form1();
            aaa.Show();
        }
    }
    }

