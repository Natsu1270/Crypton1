using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Crypton1
{
   
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
         (
             int nLeftRect,     // x-coordinate of upper-left corner
             int nTopRect,      // y-coordinate of upper-left corner
             int nRightRect,    // x-coordinate of lower-right corner
             int nBottomRect,   // y-coordinate of lower-right corner
             int nWidthEllipse, // height of ellipse
             int nHeightEllipse // width of ellipse
         );

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        Point lastClick;
        Form2 rsaForm = new Form2();
        Form3 hashForm = new Form3();
        Form4 desForm = new Form4();
        Form5 aesForm = new Form5();


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

        private void gotoSection(Form form)
        {
            this.Hide();
            form.ShowDialog();
            try
            {
                this.Show();
            }
            catch (ObjectDisposedException error)
            {
                Application.Exit();
            }
        }
        private void btnDES_Click(object sender, EventArgs e)
        {
            gotoSection(desForm);
        }

        private void btnRSA_Click(object sender, EventArgs e)
        {
            gotoSection(rsaForm);

        }

        private void btnXXX_Click(object sender, EventArgs e)
        {
            gotoSection(aesForm);

        }
        private void btnHash_Click(object sender, EventArgs e)
        {

            gotoSection(hashForm);

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 800, WinAPI.CENTER);
        }
    }
}
