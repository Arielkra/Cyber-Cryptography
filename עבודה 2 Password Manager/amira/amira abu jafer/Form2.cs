using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//------------------------------------------------------------------
using System.IO;
//------------------------------------------------------------------
namespace amira_abu_jafer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int length = 8;// length of the password
            Random random = new Random();
            string str = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!?%&*()^$#@-+_=~/`<>/:;'";
            StringBuilder result = new StringBuilder(length);
            int i = 0;
            while ( i < length)
            {
                result.Append(str[random.Next(str.Length)]);
                i++;
            }
            label2.Text= result.ToString();
            
        }
        public bool CheckPassword(string str)
        {
            int i, c = 0, flag = 0;
            string str1 = str;
            for (i = 0; i < str.Length; i++)
            {

                if ((str1[i] >= '0' && str1[i] <= '9')||(str1[i]>='A'&& str1[i]<='Z')|| (str1[i] >= 'a' && str1[i] <= 'z')|| (!((str1[i] >= 'a' && str1[i] <= 'z')|| (str1[i] >= 'A' && str1[i] <= 'Z')|| (str1[i] >= '1' && str1[i] <= '9'))))
                {
                    c++;
                    flag = 0;
                }
                else
                    flag = 1;

            }
            if (flag == 0 && c == 8)
                return true;
            return false;
        }
        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                string user_name = textBox1.Text;
                string user_password = textBox2.Text;
                string storeName = comboBox1.Text;

                if (CheckPassword(user_password))
                {
                   
                    FileStream f = new FileStream("save.txt", FileMode.Append);
                    StreamWriter s = new StreamWriter(f);
                    s.WriteLine(comboBox1.Text);
                    s.WriteLine(textBox1.Text);
                    s.WriteLine(textBox2.Text);
                   
                    s.Close();
                    f.Close();

                }
                else
                {
                    MessageBox.Show("Error!!!"+'\n'+"Go to get a strong password");
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
