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
using System.IO;


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


        static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }


            // Return the encrypted bytes from the memory stream.
            return encrypted;

        }

        static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }

            }
            ResultForm.ShowGenDialog(time, @"D:\UnitTest\DES\");

        }
        public void DESEncrypt(string keyFileName, string plainFileName)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fsInput = new FileStream(plainFileName, FileMode.Open, FileAccess.Read);
            FileStream fsEncrypted = new FileStream(@"D:\UnitTest\DES\enryted", FileMode.Create, FileAccess.Write);
            string sKey = File.ReadAllText(keyFileName, Encoding.UTF8);
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
            ICryptoTransform desencrypt = DES.CreateEncryptor();
            CryptoStream cryptostream = new CryptoStream(fsEncrypted, desencrypt, CryptoStreamMode.Write);
            byte[] bytearrayinput = new byte[fsInput.Length - 1];
            fsInput.Read(bytearrayinput, 0, bytearrayinput.Length);
            cryptostream.Write(bytearrayinput, 0, bytearrayinput.Length);
            cryptostream.Close();
            fsInput.Close();
            fsEncrypted.Close();
            stopwatch.Stop();
            //MessageBox.Show();
            time = stopwatch.Elapsed.ToString("mm\\:ss\\.ff");
        }
        public void DESDecrypt(string keyFileName, string cypherFileName)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            string sKey = File.ReadAllText(keyFileName, Encoding.UTF8);
            DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
            FileStream fsread = new FileStream(cypherFileName, FileMode.Open, FileAccess.Read);
            ICryptoTransform descrypt = DES.CreateDecryptor();
            CryptoStream cryptostreamDecr = new CryptoStream(fsread, descrypt, CryptoStreamMode.Read);
            StreamWriter fsDecrypted = new StreamWriter(@"D:\UnitTest\DES\decrypt");
            fsDecrypted.Write(new StreamReader(cryptostreamDecr).ReadToEnd());
            fsDecrypted.Flush();
            fsDecrypted.Close();
            stopwatch.Stop();
            time = stopwatch.Elapsed.ToString("mm\\:ss\\.ff");
        }
    }
}
