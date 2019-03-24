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
        private void btnReset_Click(object sender, EventArgs e)
        {
            //txtAddress.Text = "";
            txtAddress.Visible = false;
            fileResult.Visible = false;
            typeCryp = "";
            disableAllBtn();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 10, WinAPI.CENTER);
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
                fileResult.Visible = true;
                fileResult.Text = strfilename;
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (!txtAddress.Visible)
            {
                MessageBox.Show("Please input a file to process encrypt/decrypt!", "No input file error!");
                return;
            }else if (!fileResult.Visible)
            {
                MessageBox.Show("Please input a key file to process encrypt/decrypt!", "No key file error!");
                return;
            }else if (Path.GetExtension(fileResult.Text.ToString()) != ".xml")
            {
                //MessageBox.Show(Path.GetExtension(fileResult.Text.ToString()));
                MessageBox.Show("Wrong key extension!", "Extension error!");
                return;
            }else if (typeCryp == "")
            {
                MessageBox.Show("Please choose encrypt/decrypt mode to process", "Mode error!");
                return;
            }
            if (typeCryp == btnEncrypt.Text)
            {
                RSAEncrypt(fileResult.Text, txtAddress.Text);
            }
            else
            {
                RSADecrypt(fileResult.Text, txtAddress.Text);
            }

        }


        public void RSAGetPublicKey(string keyFileName)
        {
            //Get public key
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(File.ReadAllText(keyFileName));
            XmlNode xnList = xml.SelectSingleNode("/RSAKeyValue/Modulus");
            mOutput.Text = xnList.InnerText;
            xnList = xml.SelectSingleNode("/RSAKeyValue/Exponent");
            eOutput.Text = xnList.InnerText;
        }
        public void RSAEncrypt(string keyFileName, string plainFileName)

        {

            RSAGetPublicKey(keyFileName);

            byte[] byteArrayPlain = File.ReadAllBytes(plainFileName);
            byte[] encryptedData = new byte[byteArrayPlain.Length];
            RSAParameters RSAKeyInfo = new RSAParameters();
            RSAKeyInfo.Modulus = Convert.FromBase64String(mOutput.Text);
            RSAKeyInfo.Exponent = Convert.FromBase64String(eOutput.Text);
            
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.ImportParameters(RSAKeyInfo);
                int maxBytesCanEncrypted = ((RSA.KeySize - 384) / 8) + 37;
                int len = 0;
                byte[] binData = new byte[maxBytesCanEncrypted];
                byte[] binEncrypt = new byte[maxBytesCanEncrypted];
                while (len < byteArrayPlain.Length)
                {
                    if (byteArrayPlain.Length - len > maxBytesCanEncrypted)
                    {
                        Array.Copy(byteArrayPlain, len, binData, 0, maxBytesCanEncrypted);
                        binEncrypt = RSA.Encrypt(binData, false);
                        System.Buffer.BlockCopy(binEncrypt, 0, encryptedData, 0, maxBytesCanEncrypted);
                    }
                    else
                    {
                        Array.Copy(byteArrayPlain, len, binData, 0, byteArrayPlain.Length - len);
                        binEncrypt = RSA.Encrypt(binData, false);
                        System.Buffer.BlockCopy(binEncrypt, 0, encryptedData, 0, byteArrayPlain.Length - len);
                    }
                        
                    len += maxBytesCanEncrypted;
                }
               
            }
            //string encryptedString = Convert.ToBase64String(encryptedData);
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
            byte[] decryptedData = new byte[byteArrayCipher.Length];

            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.ImportParameters(RSAKeyInfo);
                int maxBytesCanEncrypted = RSA.KeySize / 8;
                int len = 0;
                byte[] binData = new byte[maxBytesCanEncrypted];
                byte[] binDecrypt = new byte[maxBytesCanEncrypted];
                while (len < byteArrayCipher.Length)
                {
                    if (byteArrayCipher.Length - len > maxBytesCanEncrypted)
                    {
                        Array.Copy(byteArrayCipher, len, binData, 0, maxBytesCanEncrypted);
                        binDecrypt = RSA.Decrypt(binData, false);
                        System.Buffer.BlockCopy(binDecrypt, 0, decryptedData, 0, maxBytesCanEncrypted);
                    }
                    else
                    {
                        Array.Copy(byteArrayCipher, len, binData, 0, byteArrayCipher.Length - len);
                        binDecrypt = RSA.Decrypt(binData, false);
                        System.Buffer.BlockCopy(binDecrypt, 0, decryptedData, 0, byteArrayCipher.Length - len);
                    }
                    len += maxBytesCanEncrypted;
                }

            }
            //string encryptedString = Convert.ToBase64String(decryptedData);
            System.IO.File.WriteAllBytes(@"D:\UnitTest\RSA\encrypted.txt", decryptedData);
        }

        private void fileResult_Click(object sender, EventArgs e)
        {

        }

        private void btnOnHover(Button btn)
        {
            btn.FlatAppearance.BorderSize = 3;
            btn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
        }

        private void btnOnLeave(Button btn)
        {
            btn.FlatAppearance.BorderSize = 0;
        }

       
    }
}




