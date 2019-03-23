using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Crypton1
{
   
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        Point lastClick;
        Form2 f2 = new Form2();



        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;

            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;

            }
        }

        private void btnDES_Click(object sender, EventArgs e)
        {
            this.Hide();
            f2.ShowDialog();
            try
            {
            this.Show();
            }
            catch (ObjectDisposedException error)
            {
                Application.Exit();
            }
        }

        private void btnRSA_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnXXX_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
