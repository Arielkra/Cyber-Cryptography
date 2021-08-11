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
namespace UsernamePassword2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
    
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
                     string username = textBox1.Text;
                     string password = textBox2.Text;
                if (checkpass(password)){

                    FileStream pass = new FileStream("password.txt", FileMode.Append);
                    StreamWriter p = new StreamWriter(pass);
                    p.Write(label5.Text);
                    p.Write(label2.Text);
                    p.Write(textBox1.Text);
                    p.Write(label34.Text);
                    p.Write(label3.Text);
                    p.Write(textBox2.Text);
                    p.WriteLine();
                   
                    p.Close();
                     pass.Close();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    MessageBox.Show("Saving Is Complete");

                }
                else
                {
                    MessageBox.Show("Password Not Strong Or Click Random Pass");
                    textBox2.Text = "";
                }
                    
            }
            catch { }

           
            

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
                string username = textBox4.Text;
                string password = textBox3.Text;
                if (checkpass(password))
                {

                    FileStream pass = new FileStream("password.txt", FileMode.Append);
                    StreamWriter p = new StreamWriter(pass);
                    p.Write(label6.Text);
                    p.Write(label2.Text);
                    p.Write(textBox4.Text);
                    p.Write(label34.Text);
                    p.Write(label3.Text);
                    p.Write(textBox3.Text);
                    p.WriteLine();
                    p.Close();
                    pass.Close();
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
                string username = textBox6.Text;
                string password = textBox5.Text;
                if (checkpass(password))
                {

                    FileStream pass = new FileStream("password.txt", FileMode.Append);
                    StreamWriter p = new StreamWriter(pass);
                    p.Write(label9.Text);
                    p.Write(label2.Text);
                    p.Write(textBox6.Text);
                    p.Write(label34.Text);
                    p.Write(label3.Text);
                    p.Write(textBox5.Text);
                    p.WriteLine();
                    p.Close();
                    pass.Close();
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
                string username = textBox8.Text;
                string password = textBox7.Text;
                if (checkpass(password))
                {

                    FileStream pass = new FileStream("password.txt", FileMode.Append);
                    StreamWriter p = new StreamWriter(pass);
                    p.Write(label12.Text);
                    p.Write(label2.Text);
                    p.Write(textBox8.Text);
                    p.Write(label34.Text);
                    p.Write(label3.Text);
                    p.Write(textBox7.Text);
                    p.WriteLine();
                    p.Close();
                    pass.Close();
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
                string username = textBox10.Text;
                string password = textBox9.Text;
                if (checkpass(password))
                {

                    FileStream pass = new FileStream("password.txt", FileMode.Append);
                    StreamWriter p = new StreamWriter(pass);
                    p.Write(label15.Text);
                    p.Write(label2.Text);
                    p.Write(textBox10.Text);
                    p.Write(label34.Text);
                    p.Write(label3.Text);
                    p.Write(textBox9.Text);
                    p.WriteLine();
                    p.Close();
                    pass.Close();
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
                string username = textBox20.Text;
                string password = textBox19.Text;
                if (checkpass(password))
                {

                    FileStream pass = new FileStream("password.txt", FileMode.Append);
                    StreamWriter p = new StreamWriter(pass);
                    p.Write(label30.Text);
                    p.Write(label2.Text);
                    p.Write(textBox20.Text);
                    p.Write(label34.Text);
                    p.Write(label3.Text);
                    p.Write(textBox19.Text);
                    p.WriteLine();
                    p.Close();
                    pass.Close();
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
                string username = textBox18.Text;
                string password = textBox17.Text;
                if (checkpass(password))
                {

                    FileStream pass = new FileStream("password.txt", FileMode.Append);
                    StreamWriter p = new StreamWriter(pass);
                    p.Write(label27.Text);
                    p.Write(label2.Text);
                    p.Write(textBox18.Text);
                    p.Write(label34.Text);
                    p.Write(label3.Text);
                    p.Write(textBox17.Text);
                    p.WriteLine();
                    p.Close();
                    pass.Close();
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
                string username = textBox16.Text;
                string password = textBox15.Text;
                if (checkpass(password))
                {

                    FileStream pass = new FileStream("password.txt", FileMode.Append);
                    StreamWriter p = new StreamWriter(pass);
                    p.Write(label24.Text);
                    p.Write(label2.Text);
                    p.Write(textBox16.Text);
                    p.Write(label34.Text);
                    p.Write(label3.Text);
                    p.Write(textBox15.Text);
                    p.WriteLine();
                    p.Close();
                    pass.Close();
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
                string username = textBox14.Text;
                string password = textBox13.Text;
                if (checkpass(password))
                {

                    FileStream pass = new FileStream("password.txt", FileMode.Append);
                    StreamWriter p = new StreamWriter(pass);
                    p.Write(label21.Text);
                    p.Write(label2.Text);
                    p.Write(textBox14.Text);
                    p.Write(label34.Text);
                    p.Write(label3.Text);
                    p.Write(textBox13.Text);
                    p.WriteLine();
                    p.Close();
                    pass.Close();
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
                string username = textBox12.Text;
                string password = textBox11.Text;
                if (checkpass(password))
                {

                    FileStream pass = new FileStream("password.txt", FileMode.Append);
                    StreamWriter p = new StreamWriter(pass);
                    p.Write(label18.Text);
                    p.Write(label2.Text);
                    p.Write(textBox12.Text);
                    p.Write(label34.Text);
                    p.Write(label3.Text);
                    p.Write(textBox11.Text);
                    p.WriteLine();
                    p.Close();
                    pass.Close();
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
    }
}
