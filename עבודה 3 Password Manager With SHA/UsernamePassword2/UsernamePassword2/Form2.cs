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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string maksha1(string str)        {            SHA1CryptoServiceProvider sh = new SHA1CryptoServiceProvider();            sh.ComputeHash(ASCIIEncoding.ASCII.GetBytes(str));            byte[] re = sh.Hash;            StringBuilder sb = new StringBuilder();            foreach (byte b in re)            {                sb.Append(b.ToString("X2"));            }            return sb.ToString();        }

        public bool checkpass(string str)
        {
            int i, c = 0, flag1 = 0, flag2 = 0, flag3 = 0, flag4 = 0;
            string str1 = str;
            for (i = 0; i < str.Length; i++)
            {

                if ((str1[i] >= '0' && str1[i] <= '9'))
                {
                    c++;
                    flag1 = 1;
                }
                else if ((str1[i] >= 'A' && str1[i] <= 'Z'))
                {
                    c++;
                    flag2 = 1;
                }
                else if ((str1[i] >= 'a' && str1[i] <= 'z'))
                {

                    c++;
                    flag3 = 1;
                }
                else
                {
                    c++;
                    flag4 = 1;
                }
            }
            if (flag1 == 1 && flag2 == 1 && flag3 == 1 && flag4 == 1 && c == 8)
                return true;
            return false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            


            try
            {
                     string company1 = label5.Text;
                     string username1 = textBox1.Text;
                     string password1 = textBox2.Text;
                     

                if (checkpass(password1)){
                    password1 = maksha1(textBox2.Text);
                    string strDb;
                    strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Passwordlogin.accdb;" + "Persist Security Info=False";
                    OleDbConnection conn = new OleDbConnection(strDb);
                    conn.Open();
                    OleDbCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "insert into compusers values('" + company1 + "','" + username1 + "','" + password1 + "'); ";

                    int n = cmd.ExecuteNonQuery();

                   

                    conn.Close();
                    MessageBox.Show(" Save Is Complated!!!");
                    
                    textBox1.Text = "";
                    textBox2.Text = "";


                }
                else
                {
                    MessageBox.Show("Password Not Strong Or Click Random Pass");
                    textBox2.Text = "";
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }


           
            

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int length = 8;
            Random random = new Random();
            string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!#$%&*()@";
            StringBuilder result = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                result.Append(characters[random.Next(characters.Length)]);
                
            }
            textBox2.Text = result.ToString();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int length = 8;
            Random random = new Random();
            string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!#$%&*()@";
            StringBuilder result = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                result.Append(characters[random.Next(characters.Length)]);
            }
            textBox3.Text = result.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int length = 8;
            Random random = new Random();
            string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!#$%&*()@";
            StringBuilder result = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                result.Append(characters[random.Next(characters.Length)]);
            }
            textBox5.Text = result.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int length = 8;
            Random random = new Random();
            string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!#$%&*()@";
            StringBuilder result = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                result.Append(characters[random.Next(characters.Length)]);
            }
            textBox7.Text = result.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int length = 8;
            Random random = new Random();
            string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!#$%&*()@";
            StringBuilder result = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                result.Append(characters[random.Next(characters.Length)]);
            }
            textBox9.Text = result.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int length = 8;
            Random random = new Random();
            string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!#$%&*()@";
            StringBuilder result = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                result.Append(characters[random.Next(characters.Length)]);
            }
            textBox19.Text = result.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            int length = 8;
            Random random = new Random();
            string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!#$%&*()@";
            StringBuilder result = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                result.Append(characters[random.Next(characters.Length)]);
            }
            textBox17.Text = result.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int length = 8;
            Random random = new Random();
            string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!#$%&*()@";
            StringBuilder result = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                result.Append(characters[random.Next(characters.Length)]);
            }
            textBox15.Text = result.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int length = 8;
            Random random = new Random();
            string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!#$%&*()@";
            StringBuilder result = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                result.Append(characters[random.Next(characters.Length)]);
            }
            textBox13.Text = result.ToString();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int length = 8;
            Random random = new Random();
            string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!#$%&*()@";
            StringBuilder result = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                result.Append(characters[random.Next(characters.Length)]);
            }
            textBox11.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                string company1 = label6.Text;
                string username1 = textBox4.Text;
                string password1 = textBox3.Text;
                if (checkpass(password1))
                {
                    password1 = maksha1(textBox3.Text);
                    string strDb;
                    strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Passwordlogin.accdb;" + "Persist Security Info=False";
                    OleDbConnection conn = new OleDbConnection(strDb);
                    conn.Open();
                    OleDbCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "insert into compusers values('" + company1 + "','" + username1 + "','" + password1 + "'); ";

                    int n = cmd.ExecuteNonQuery();



                    conn.Close();
                    

                    textBox4.Text = "";
                    textBox3.Text = "";
                    MessageBox.Show("Saving Is Complete");
                }
                else
                {
                    MessageBox.Show("Password Not Strong Or Click Random Pass");
                    textBox3.Text = "";
                }

            }
            catch { }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string company1 = label9.Text;
                string username1 = textBox6.Text;
                string password1 = textBox5.Text;
                if (checkpass(password1))
                {

                    password1 = maksha1(textBox5.Text);
                    string strDb;
                    strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Passwordlogin.accdb;" + "Persist Security Info=False";
                    OleDbConnection conn = new OleDbConnection(strDb);
                    conn.Open();
                    OleDbCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "insert into compusers values('" + company1 + "','" + username1 + "','" + password1 + "'); ";

                    int n = cmd.ExecuteNonQuery();



                    conn.Close();
                    textBox6.Text = "";
                    textBox5.Text = "";
                    MessageBox.Show("Saving Is Complete");
                }
                else
                {
                    MessageBox.Show("Password Not Strong Or Click Random Pass");
                    textBox5.Text = "";
                    
                }
                
            }
            catch { }
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                string company1 = label12.Text;
                string username1 = textBox8.Text;
                string password1 = textBox7.Text;
                if (checkpass(password1))
                {

                    password1 = maksha1(textBox7.Text);
                    string strDb;
                    strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Passwordlogin.accdb;" + "Persist Security Info=False";
                    OleDbConnection conn = new OleDbConnection(strDb);
                    conn.Open();
                    OleDbCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "insert into compusers values('" + company1 + "','" + username1 + "','" + password1 + "'); ";

                    int n = cmd.ExecuteNonQuery();



                    conn.Close();
                    textBox8.Text = "";
                    textBox7.Text = "";
                    MessageBox.Show("Saving Is Complete");
                }
                else
                {
                    MessageBox.Show("Password Not Strong Or Click Random Pass");
                    textBox7.Text = "";

                }

            }
            catch { }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                string company1 = label15.Text;
                string username1 = textBox10.Text;
                string password1 = textBox9.Text;
                if (checkpass(password1))
                {
                    password1 = maksha1(textBox9.Text);
                    string strDb;
                    strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Passwordlogin.accdb;" + "Persist Security Info=False";
                    OleDbConnection conn = new OleDbConnection(strDb);
                    conn.Open();
                    OleDbCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "insert into compusers values('" + company1 + "','" + username1 + "','" + password1 + "'); ";

                    int n = cmd.ExecuteNonQuery();



                    conn.Close();
                    textBox10.Text = "";
                    textBox9.Text = "";
                    MessageBox.Show("Saving Is Complete");
                }
                else
                {
                    MessageBox.Show("Password Not Strong Or Click Random Pass");
                    textBox9.Text = "";

                }

            }
            catch { }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string company1 = label30.Text;
                string username1 = textBox20.Text;
                string password1 = textBox19.Text;
                if (checkpass(password1))
                {

                    password1 = maksha1(textBox19.Text);
                    string strDb;
                    strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Passwordlogin.accdb;" + "Persist Security Info=False";
                    OleDbConnection conn = new OleDbConnection(strDb);
                    conn.Open();
                    OleDbCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "insert into compusers values('" + company1 + "','" + username1 + "','" + password1 + "'); ";

                    int n = cmd.ExecuteNonQuery();



                    conn.Close();
                    textBox20.Text = "";
                    textBox19.Text = "";
                    MessageBox.Show("Saving Is Complete");
                }
                else
                {
                    MessageBox.Show("Password Not Strong Or Click Random Pass");
                    textBox19.Text = "";

                }

            }
            catch { }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                string company1 = label27.Text;
                string username1 = textBox18.Text;
                string password1 = textBox17.Text;
                if (checkpass(password1))
                {
                    password1 = maksha1(textBox17.Text);
                    string strDb;
                    strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Passwordlogin.accdb;" + "Persist Security Info=False";
                    OleDbConnection conn = new OleDbConnection(strDb);
                    conn.Open();
                    OleDbCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "insert into compusers values('" + company1 + "','" + username1 + "','" + password1 + "'); ";

                    int n = cmd.ExecuteNonQuery();



                    conn.Close();
                    textBox18.Text = "";
                    textBox17.Text = "";
                    MessageBox.Show("Saving Is Complete");
                }
                else
                {
                    MessageBox.Show("Password Not Strong Or Click Random Pass");
                    textBox17.Text = "";

                }

            }
            catch { }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                string company1 = label24.Text;
                string username1 = textBox16.Text;
                string password1 = textBox15.Text;
                if (checkpass(password1))
                {

                    password1 = maksha1(textBox15.Text);
                    string strDb;
                    strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Passwordlogin.accdb;" + "Persist Security Info=False";
                    OleDbConnection conn = new OleDbConnection(strDb);
                    conn.Open();
                    OleDbCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "insert into compusers values('" + company1 + "','" + username1 + "','" + password1 + "'); ";

                    int n = cmd.ExecuteNonQuery();



                    conn.Close();
                    textBox16.Text = "";
                    textBox15.Text = "";
                    MessageBox.Show("Saving Is Complete");
                }
                else
                {
                    MessageBox.Show("Password Not Strong Or Click Random Pass");
                    textBox15.Text = "";

                }

            }
            catch { }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                string company1 = label21.Text;
                string username1 = textBox14.Text;
                string password1 = textBox13.Text;
                if (checkpass(password1))
                {

                    password1 = maksha1(textBox13.Text);
                    string strDb;
                    strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Passwordlogin.accdb;" + "Persist Security Info=False";
                    OleDbConnection conn = new OleDbConnection(strDb);
                    conn.Open();
                    OleDbCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "insert into compusers values('" + company1 + "','" + username1 + "','" + password1 + "'); ";

                    int n = cmd.ExecuteNonQuery();



                    conn.Close();
                    textBox14.Text = "";
                    textBox13.Text = "";
                    MessageBox.Show("Saving Is Complete");
                }
                else
                {
                    MessageBox.Show("Password Not Strong Or Click Random Pass");
                    textBox13.Text = "";

                }

            }
            catch { }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                string company1 = label18.Text;
                string username1 = textBox12.Text;
                string password1 = textBox11.Text;
                if (checkpass(password1))
                {
                    password1 = maksha1(textBox11.Text);
                    string strDb;
                    strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Passwordlogin.accdb;" + "Persist Security Info=False";
                    OleDbConnection conn = new OleDbConnection(strDb);
                    conn.Open();
                    OleDbCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "insert into compusers values('" + company1 + "','" + username1 + "','" + password1 + "'); ";

                    int n = cmd.ExecuteNonQuery();



                    conn.Close();
                    textBox12.Text = "";
                    textBox11.Text = "";
                    MessageBox.Show("Saving Is Complete");
                }
                else
                {
                    MessageBox.Show("Password Not Strong Or Click Random Pass");
                    textBox11.Text = "";

                }

            }
            catch { }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 aaa = new Form1();
            aaa.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            Form3 d = new Form3();
            d.Show();
            this.Hide();
        }
    }
    }

