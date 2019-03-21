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
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Fortnite_Design
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (slidemenu.Width > 285)
                slidemenu.Width = 285;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (slidemenu.Width == 50)
            {
              
                slidemenu.Width = 285;
                PanelAnimator.ShowSync(slidemenu);
            }
            else
            {
                slidemenu.Width = 50;
                PanelAnimator.ShowSync(slidemenu);
               

            }
            //dit is nog niet klaar de slidepanel doet telkens plus 50 
            Console.Write(slidemenu.Location);

           

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            /*string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=fortnite;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            databaseConnection.Open();
            MessageBox.Show("Connection Created");
            MySqlCommand cmd = new MySqlCommand(connectionString);
            cmd.CommandText = "Select * from [Fortnite]";*/
            
            /*while (rd.Read())
            {
                MessageBox.Show(rd["SkinNaam"].ToString());
            }
            */
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fortniteDataSet2.Account' table. You can move, or remove it, as needed.
            // this.accountTableAdapter.Fill(this.fortniteDataSet2.Account);
           
            
            // TODO: This line of code loads data into the 'fortniteDataSet1.Fortnite' table. You can move, or remove it, as needed.
            //this.fortniteTableAdapter.Fill(this.fortniteDataSet1.Fortnite);
            // TODO: This line of code loads data into the 'fortniteDataSet.Fortnite_Skin' table. You can move, or remove it, as needed.
            //this.fortnite_SkinTableAdapter.Fill(this.fortniteDataSet.Fortnite_Skin);

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png|*.BMP;*.JPG;*.JPEG;*.PNG";

                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    pictureBox2.Image = Image.FromFile(dlg.FileName);
                }
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           // this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=STAN;Initial Catalog=Fortnite;Integrated Security=True";
            MySqlConnection databaseConnection = new MySqlConnection(ConnectionString);
            
            databaseConnection.Open();
            MessageBox.Show("Connection Created");
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select * from [Fortnite]";
            cmd.Connection = databaseConnection;
            MySqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                MessageBox.Show(rd["SkinNaam"].ToString());
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=STAN;Initial Catalog=Fortnite;Integrated Security=True";
            con.Open();
            //MessageBox.Show("Connection Created");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from [Account]";
            cmd.Connection = con;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
            this.Close();
        }
    }
}
