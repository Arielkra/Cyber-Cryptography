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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Travel.accdb;" + "Persist Security Info=False";
                OleDbConnection conn = new OleDbConnection(strDb);
                conn.Open();
                OleDbDataReader dr;
                OleDbCommand cmd = new OleDbCommand("Select * from mangers where manger_name='" + textBox1.Text + "' and code_manger='" + textBox2.Text + "' and id_manger='" + textBox3.Text + "' ;", conn); //command sql
              
                dr = cmd.ExecuteReader(); // pointer to table
           
                string str1 = "";
                string str2 = "";
                string str3 = "";                               
                // read row from table
                while (dr.Read())
                {

                    str1 += dr["id_manger"] + "\n";
                    str2 += dr["manger_name"] + "\n";
                    str3 += dr["code_manger"] + "\n";

                }
                dr.Close();
                conn.Close();
               if(str1=="" && str2=="" && str3=="")
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

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                textBox2.Focus();

            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                textBox1.Focus();

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
