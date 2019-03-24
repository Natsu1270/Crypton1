using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypton1
{
    public partial class Form3 : Form
    {
        private Point lastClick;

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
        public Form3()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        public void setLbType(String type)
        {
            this.lbType.Text = type;
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 10, WinAPI.CENTER);
        }
        private void btnInput1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string strfilename = openFileDialog1.FileName;
                txtAddress1.Text = strfilename;
            }
        }
        private void btnInput2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string strfilename = openFileDialog1.FileName;
                txtAddress2.Text = strfilename;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;

            }
        }


        
        static string CalculateMD5(string filename)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (txtAddress1.Text == "" && txtAddress2.Text == "")
            {
                MessageBox.Show("Please input a file to process encrypt/decrypt!", "No input file error!");
                return;
            }
            if (txtAddress1.Text != "")
            {
                HashCode1.Text = CalculateMD5(txtAddress1.Text);
            }
            if (txtAddress2.Text != "")
            {
                HashCode2.Text = CalculateMD5(txtAddress2.Text);
            }
            if (txtAddress1.Text != "" && txtAddress2.Text != "")
            {
                if (string.Compare(txtAddress1.Text, txtAddress2.Text) == 0)
                {
                    HashCompare.Text = "The hashes are the same";
                }
                else
                {
                    HashCompare.Text = "The hashes are not same";
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            HashCompare.Text = "";
            HashCode1.Text = "";
            HashCode2.Text = "";
            txtAddress1.Text = "";
            txtAddress2.Text = "";
        }

        private void HashCode2_Click(object sender, EventArgs e)
        {

        }
    }
}
