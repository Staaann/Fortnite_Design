using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace Fortnite_Design
{
    public partial class UserControl2 : UserControl
    {
        List<int> entryID = new List<int>();
        public UserControl2()
        {
            InitializeComponent();
            Debug.WriteLine("Test");
            InitializeComponent();
            loadFromDatabase();
        }
     
        /*  private void Form4_Load(object sender , EventArgs e)
          {
              Debug.WriteLine("Test");
              loadFromDatabase();
          }*/
        public void loadFromDatabase()
        {
            Debug.WriteLine("Test");
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=fortnite;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            databaseConnection.Open();
            MySqlCommand pulldata = new MySqlCommand("SELECT * FROM fortnite", databaseConnection);
            MySqlDataReader pullingdata = pulldata.ExecuteReader();

            while (pullingdata.Read())
            {
                Debug.WriteLine("Test");
                Debug.WriteLine(pullingdata["SkinID"].ToString() + " - Name : " + pullingdata["SkinNaam"].ToString() + " - location : " + pullingdata["SkinImage"].ToString());
                entryID.Add(Int32.Parse(pullingdata["SkinID"].ToString()));

                var flowbox = new FlowLayoutPanel
                {
                    Size = new Size(320, 320),
                };
                flowLayoutPanel1.Controls.Add(flowbox);
                var nametext = new Label
                {

                    Size = new Size(300, 25),
                    Text = "" + pullingdata["SkinNaam"],
                    //ReadOnly = true

                };
                flowbox.Controls.Add(nametext);

                var picture = new PictureBox
                {
                    Name = "" + pullingdata["SkinNaam"] + ".png",
                    Size = new Size(300, 300),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Image = Image.FromFile(pullingdata["SkinImage"].ToString())
                };
                flowbox.Controls.Add(picture);

            }
            databaseConnection.Close();
            entryID.ForEach(Console.WriteLine);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
