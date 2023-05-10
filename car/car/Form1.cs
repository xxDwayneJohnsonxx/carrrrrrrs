using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            c.left = true;
            c.right = true;

        }
        CAr c = new CAr();
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (c.left)
            {
                leftON.Visible = !leftON.Visible;
            }
            if (c.right)
            {
                rightON.Visible = !rightON.Visible;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            c.left = true;
        }

        private void leftON_Click(object sender, EventArgs e)
        {

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rightturnstick_Click(object sender, EventArgs e)
        {
            c.right = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            c.left = false;
            c.right= false;

        }

        

        private void BrakesON(object sender, EventArgs e)
        {
            c.brake = true;
            BrakeLON.Visible = true;
            BrakeRON.Visible = true;
        }

        private void BrakesOFF(object sender, EventArgs e)
        {
            c.brake= false;
            BrakeLON.Visible = false;
            BrakeRON.Visible = false;
        }
    }
}
