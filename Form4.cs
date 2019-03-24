using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace Crypton1
{
    public partial class Form4 : Form
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
        String typeCryp = "";
        public Form4()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form4_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }

        private void Form4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;

            }
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string strfilename = openFileDialog1.FileName;
                txtAddress.Visible = true;
                txtAddress.Text = strfilename;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            DESCryptoServiceProvider desCrypto = (DESCryptoServiceProvider)DESCryptoServiceProvider.Create();
            key.Text = ASCIIEncoding.ASCII.GetString(desCrypto.Key);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string strfilename = openFileDialog1.FileName;
                fileResult.Visible = true;
                fileResult.Text = strfilename;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtAddress_Click(object sender, EventArgs e)
        {

        }
        private void disableOtherBtn(Button curBtn)
        {
            foreach (var button in this.Controls.OfType<Button>())
            {
                button.FlatAppearance.BorderSize = 0;
            }
            curBtn.FlatAppearance.BorderSize = 4;
            curBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
        }
        private void disableAllBtn()
        {
            foreach (var btn in this.Controls.OfType<Button>())
            {
                btn.FlatAppearance.BorderSize = 0;
            }
        }
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            disableOtherBtn(btnEncrypt);
            typeCryp = btnEncrypt.Text.ToString();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            disableOtherBtn(btnDecrypt);
            typeCryp = btnDecrypt.Text.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAddress.Visible = false;
            fileResult.Visible = false;
            typeCryp = "";
            disableAllBtn();
        }
    }
}
