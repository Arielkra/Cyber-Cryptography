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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                textBox2.Text = openFileDialog1.SafeFileName;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {

                textBox3.Focus();

            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {

                textBox4.Focus();

            }
            if (e.KeyCode == Keys.Up)
            {

                textBox1.Focus();

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {

                textBox3.Focus();

            }
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
                string id_coustmer = textBox1.Text;
                string pic = textBox2.Text;
                string fname = textBox3.Text;
                string lname = textBox4.Text;
                string wORm =string.Empty;
                
                string travel_to = comboBox1.Text;
                string go_to = comboBox2.Text;
                string seat = comboBox3.Text;
                string price = comboBox4.Text;
                string flight_dirction=string.Empty;
                if ((travel_to != go_to )&& CheckName(id_coustmer))
                {
                    if (checkBox1.Checked)
                    {
                        flight_dirction = "one dirction";
                    }
                    if (checkBox2.Checked)
                    {
                        flight_dirction = "two dirction";
                    }
                    if (radioButton1.Checked)
                    {
                        wORm = "male";
                    }
                    if (radioButton2.Checked)
                    {
                        wORm = "famle";
                    }
                    string strDb;
                    strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Travel.accdb;" + "Persist Security Info=False";
                    OleDbConnection conn = new OleDbConnection(strDb);
                    conn.Open();



                    OleDbCommand cmd = conn.CreateCommand();




                    cmd.CommandText = "insert into coustmers values('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + wORm + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "','" + flight_dirction + "','" + textBox2.Text + "');";


                    int n = cmd.ExecuteNonQuery();


                    MessageBox.Show("added " + n.ToString() + " row");

                    conn.Close();
                }
                else
                {
                    MessageBox.Show("countries have to be diffrents Or id number not 9 digits!!!!!");
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 c = new Form1();
            c.Show();
            this.Hide();
        }
    }
}