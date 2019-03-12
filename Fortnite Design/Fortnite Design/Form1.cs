using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (slidemenu.Width == 285)
            {
                slidemenu.Width = 50;
                slidemenu.Visible = false;
                PanelAnimator.ShowSync(slidemenu);

            }
            else
            {
                slidemenu.Visible = true;
                slidemenu.Width = 285;

                PanelAnimator.ShowSync(slidemenu);
               

            }
            Console.WriteLine(slidemenu.Location);

           

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
