using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Fortnite_Design
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

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            SqlConnection con = new SqlConnection("Data Source=STAN;Initial Catalog=Fortnite;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Account(username,password) values ('" + textBox1.Text + "','" + textBox2.Text + "')", con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("saved");
            }
            else
            {
                MessageBox.Show("error");
            }
            con.Close();


            this.Hide();
            Form1 f1= new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
