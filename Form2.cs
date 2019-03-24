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

namespace Crypton1
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
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
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSAParameters publicKey = RSA.ExportParameters(false);
                RSAParameters privateKey = RSA.ExportParameters(true);


                using (XmlWriter writer = XmlWriter.Create(@"D:\UnitTest\RSA\publicKey.xml"))
                {
                    writer.WriteStartElement("RSAKeyValue");
                    writer.WriteElementString("Modulus", Convert.ToBase64String(publicKey.Modulus));
                    writer.WriteElementString("Exponent", Convert.ToBase64String(publicKey.Exponent));
                    writer.WriteEndElement();
                    writer.Flush();
                }

                using (XmlWriter writer = XmlWriter.Create(@"D:\UnitTest\RSA\privateKey.xml"))
                {
                    writer.WriteStartElement("RSAKeyValue");
                    writer.WriteElementString("Modulus", Convert.ToBase64String(privateKey.Modulus));
                    writer.WriteElementString("Exponent", Convert.ToBase64String(privateKey.Exponent));
                    writer.WriteElementString("P", Convert.ToBase64String(privateKey.P));
                    writer.WriteElementString("Q", Convert.ToBase64String(privateKey.Q));
                    writer.WriteElementString("DP", Convert.ToBase64String(privateKey.DP));
                    writer.WriteElementString("DQ", Convert.ToBase64String(privateKey.DQ));
                    writer.WriteElementString("InverseQ", Convert.ToBase64String(privateKey.InverseQ));
                    writer.WriteElementString("D", Convert.ToBase64String(privateKey.D));
                    writer.WriteEndElement();
                    writer.Flush();
                }
            }

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
            if (typeCryp == btnEncrypt.Text)
            {
                RSAEncrypt(fileResult.Text, txtAddress.Text);
            }
            else
            {
                RSADecrypt(fileResult.Text, txtAddress.Text);
            }

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

            byte[] byteArrayPlain = File.ReadAllBytes(plainFileName);
            byte[] encryptedData;
            RSAParameters RSAKeyInfo = new RSAParameters();
            RSAKeyInfo.Modulus = Convert.FromBase64String(mOutput.Text);
            RSAKeyInfo.Exponent = Convert.FromBase64String(eOutput.Text);

            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.ImportParameters(RSAKeyInfo);
                encryptedData = RSA.Encrypt(byteArrayPlain, false);
            }
            string encryptedString = Convert.ToBase64String(encryptedData);
            System.IO.File.WriteAllBytes(@"D:\UnitTest\RSA\encrypted.txt", encryptedData);
        }

        public void RSADecrypt(string keyFileName, string cypherFileName)

        {
            //Get private key
            RSAParameters RSAKeyInfo = new RSAParameters();
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(File.ReadAllText(keyFileName));
            XmlNode xnList = xml.SelectSingleNode("/RSAKeyValue/Modulus");
            RSAKeyInfo.Modulus = Convert.FromBase64String(xnList.InnerText);
            xnList = xml.SelectSingleNode("/RSAKeyValue/Exponent");
            RSAKeyInfo.Exponent = Convert.FromBase64String(xnList.InnerText);
            xnList = xml.SelectSingleNode("/RSAKeyValue/P");
            RSAKeyInfo.P = Convert.FromBase64String(xnList.InnerText);
            xnList = xml.SelectSingleNode("/RSAKeyValue/Q");
            RSAKeyInfo.Q = Convert.FromBase64String(xnList.InnerText);
            xnList = xml.SelectSingleNode("/RSAKeyValue/DP");
            RSAKeyInfo.DP = Convert.FromBase64String(xnList.InnerText);
            xnList = xml.SelectSingleNode("/RSAKeyValue/DQ");
            RSAKeyInfo.DQ = Convert.FromBase64String(xnList.InnerText);
            xnList = xml.SelectSingleNode("/RSAKeyValue/InverseQ");
            RSAKeyInfo.InverseQ = Convert.FromBase64String(xnList.InnerText);
            xnList = xml.SelectSingleNode("/RSAKeyValue/D");
            RSAKeyInfo.D = Convert.FromBase64String(xnList.InnerText);

            byte[] byteArrayCipher = File.ReadAllBytes(cypherFileName);
            byte[] decryptedData;

            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.ImportParameters(RSAKeyInfo);
                decryptedData = RSA.Decrypt(byteArrayCipher, false);
            }
            string decryptedString = Convert.ToBase64String(decryptedData);
            System.IO.File.WriteAllBytes(@"D:\UnitTest\RSA\decrypted.txt", decryptedData);
        }
    }
}




