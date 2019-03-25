using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypton1
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }
        String path = @"D:\UnitTest\RSA\";
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static void ShowGenDialog(String time, String path)
        {
            ResultForm res = new ResultForm();
            res.lbTime.Text = time;
            res.ShowDialog();
            
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string path = this.path;
            if (Directory.Exists(path)){
                System.Diagnostics.Process.Start(path);
            }
            else
            {
                MessageBox.Show("An error has occured!");
                return;
            }
        }
    }
}
