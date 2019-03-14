using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fortnite_Design
{
    public partial class Form2 : Form
    {
        private string saveLocation = "D:\\\\\\\\CollectorsEdition/MainCollection/";
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
            string ConnectionString = @"Data Source=STAN;Initial Catalog=Fortnite;Integrated Security=True";
            string fullpath = saveLocation + textBox1.Text + ".png";
            string query = "INSERT INTO Fortnite_Skin(`SkinNaam`, `SkinPrice`) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "')";
//            string query = "INSERT INTO Fortnite_Skin(`SkinNaam`, `SkinPrice`, `SkinImage`) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + fullpath + "')";

            SqlConnection databaseConnection = new SqlConnection(ConnectionString);
            SqlCommand commandDatabase = new SqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            
            try
            {
                databaseConnection.Open();
                SqlDataReader myreader = commandDatabase.ExecuteReader();
                //pictureBox1.Image.Save(fullpath, ImageFormat.Png);

                MessageBox.Show("Entry succesfull");

                databaseConnection.Close();

            }
            catch
            {
                //show any error message
                MessageBox.Show("Whoops");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
