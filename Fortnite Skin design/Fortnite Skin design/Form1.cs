using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fortnite_Skin_design
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
         
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void BTNmenu_Click(object sender, EventArgs e)
        {
            if (slidemenu.Width == 60)
            {
                slidemenu.Visible = false;
                slidemenu.Width = 260;
                PanelAnimator.ShowSync(slidemenu);
            }
            else
            {

                slidemenu.Visible = false;
                slidemenu.Width = 60;
                PanelAnimator.ShowSync(slidemenu);
            }
                
            
        }
    }
}
