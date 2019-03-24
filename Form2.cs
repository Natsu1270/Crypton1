using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.Security.Cryptography;
using System.IO;
using System.Xml;
using RSACryptography;
using System.Runtime.InteropServices;

namespace Crypton1
{
    public partial class Form2 : Form
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
        public Form2()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        Point lastClick;
        String typeCryp = "";
        

        public void clearAdd()
        {
            this.txtAddress.Text = "";
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //file input
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


        public void disableCreatekey(bool t)
        {
            //this.m.Visible = t;
            //this.e.Visible = t;
            //this.pInput.Visible = t;
            //this.eOutput.Visible = t;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAddress.Text = "";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 10, WinAPI.CENTER);
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            btnEncrypt.BackColor = System.Drawing.Color.Red;
            btnDecrypt.BackColor = System.Drawing.Color.FromArgb(23, 9, 34);
            typeCryp = btnEncrypt.Text.ToString();

        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            btnDecrypt.BackColor = System.Drawing.Color.Red;
            btnEncrypt.BackColor = System.Drawing.Color.FromArgb(23, 9, 34);
            typeCryp = btnDecrypt.Text.ToString();
        }

        private void btnCreateKey_Click(object sender, EventArgs e)
        {
            
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            /*
            generateKeys();
            //mOutput.Text = (publicKey.Exponent).ToString();
            Convert.ToBase64String(publicKey.P);
            */
            
        }

        private void btnOpenKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string strfilename = openFileDialog1.FileName;
                fileResult.Text = strfilename;
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (!txtAddress.Visible)
            {
                MessageBox.Show("Please load a file to encrypt");
                return;
            }
            RSAEncrypt(fileResult.Text, txtAddress.Text);
        }



        public void RSAEncrypt(string keyFileName, string plainFileName)

        {
            //Get public key
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(File.ReadAllText(keyFileName));
            XmlNode xnList = xml.SelectSingleNode("/RSAKeyValue/Modulus");
            mOutput.Text = xnList.InnerText;
            xnList = xml.SelectSingleNode("/RSAKeyValue/Exponent");
            eOutput.Text = xnList.InnerText;

            //using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            //{
            //    RSAParameters x = RSA.ExportParameters(false);
            //    if (x.D != null)
            //    {
            //        mOutput.Text = "1";
            //    }
            //    if (x.DP != null)
            //    {
            //        mOutput.Text = "1";
            //    }
            //    if (x.DQ != null)
            //    {
            //        mOutput.Text = "1";
            //    }
            //    if (x.InverseQ != null)
            //    {
            //        mOutput.Text = "1";
            //    }
            //    if (x.Exponent != null)
            //    {
            //        mOutput.Text = ;
            //    }

            //}

            byte[] byteArrayPlain = File.ReadAllBytes(plainFileName);
            byte[] encryptedData;
            RSAParameters RSAKeyInfo = new RSAParameters();
            RSAKeyInfo.Modulus = Convert.FromBase64String(mOutput.Text);
            RSAKeyInfo.Exponent = Convert.FromBase64String(eOutput.Text);

            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {

                //Import the RSA Key information. This only needs
                //toinclude the public key information.
                RSA.ImportParameters(RSAKeyInfo);

                //Encrypt the passed byte array and specify OAEP padding.  
                //OAEP padding is only available on Microsoft Windows XP or
                //later.  
                encryptedData = RSA.Encrypt(byteArrayPlain, true);
            }
            string encryptedString = Convert.ToBase64String(encryptedData);
            System.IO.File.WriteAllText(@"D:\test.txt", encryptedString);
        }
    }
}




