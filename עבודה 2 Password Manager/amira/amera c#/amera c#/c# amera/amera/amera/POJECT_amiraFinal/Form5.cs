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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // Form7 j = new Form7();
            //j.Show();
           // this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           try
            {
                listBox1.Items.Clear();
                string strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Travel.accdb;" + "Persist Security Info=False";
                OleDbConnection conn = new OleDbConnection(strDb);
                conn.Open();
                OleDbDataReader dr;
                OleDbCommand cmd = new OleDbCommand("Select * from coustmers where travel_to=(select travel_from from Trips where trip_code='" + textBox1.Text + "');", conn); //command sql
                dr = cmd.ExecuteReader(); // pointer to table
               // string str1 = "";

                // read row from table
                while (dr.Read())
                {

                    listBox1.Items.Add(dr["id_coustmer"] + "        " + dr["fname"] + "           " + dr["lname"] + "              " + dr["wORm"] + "                   " + dr["travel_to"] + "              " + dr["go_to"] + "          " + dr["seat"] + "          " + dr["flight_dirction"] + "         ");
                   //str1 += dr["pic"];

                }
                dr.Close();
                conn.Close();

               
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }
    }
}
