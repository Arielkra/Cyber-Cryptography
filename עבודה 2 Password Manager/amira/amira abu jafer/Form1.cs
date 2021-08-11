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
namespace amira_abu_jafer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dugma.accdb;" + "Persist Security Info=False";
                OleDbConnection conn = new OleDbConnection(strDb);
                conn.Open();
                OleDbDataReader dr;
                OleDbCommand cmd = new OleDbCommand("Select * from users where user_name='" + textBox1.Text + "' and user_code='" + textBox2.Text + "' ;", conn); //command sql

                dr = cmd.ExecuteReader(); // pointer to table

                string str1 = "";
                string str2 = "";
               
                // read row from table
                while (dr.Read())
                {

                    str1 += dr["user_name"] + "\n";
                    str2 += dr["user_code"] + "\n";
                    

                }
                dr.Close();
                conn.Close();
                if (str1 == "" && str2 == "" )
                {

                    MessageBox.Show("user name or password is not true");
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
    }
}
