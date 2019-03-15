using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fortnite_Design
{
    public partial class Form2 : Form
    {
        private string saveLocation = @"D:\\MP_Upload/";

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png|*.BMP;*.JPG;*.JPEG;*.PNG";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    textBox3.Text = dlg.FileName;
                    pictureBox1.Image = Image.FromFile(dlg.FileName);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            string fullpath = saveLocation + textBox1.Text + ".png";

            SqlConnection con = new SqlConnection("Data Source=STAN;Initial Catalog=Fortnite;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Fortnite(SkinNaam,SkinPrice,SkinImage) values ('" + textBox1.Text + "','" + textBox2.Text + "',' " + fullpath+  "')", con);
            pictureBox1.Image.Save(@fullpath, ImageFormat.Png);
            int i = cmd.ExecuteNonQuery();
            if(i!=0)
            {
                MessageBox.Show("saved");
            }
            else
            {
                MessageBox.Show("error");
            }
            con.Close(); 
               
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string path = @"D:\MP_Upload";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
    }
}
