using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace UsernamePassword2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Passwordlogin.accdb;" + "Persist Security Info=False";
                OleDbConnection conn = new OleDbConnection(strDb);
                conn.Open();
                OleDbDataReader dr;
                OleDbCommand cmd = new OleDbCommand("Select * from mangers where id_username='" + textBox1.Text + "' and password='" + textBox2.Text + "' ;", conn); 

                dr = cmd.ExecuteReader(); 

                string str1 = "";
                string str2 = "";
                

                while (dr.Read())
                {

                    str1 += dr["id_username"] + "\n";
                    str2 += dr["password"] + "\n";
                    

                }
                dr.Close();
                conn.Close();
                if (str1 == "" && str2 == "")
                {

                    MessageBox.Show("Your Username or password is incorrect Please try again!");
                }
                else
                {
                    Form2 d = new Form2();
                    d.Show();
                    this.Hide();
                }


            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 d = new Form3();
            d.Show();
            this.Hide();
        }
    }
}
