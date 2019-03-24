using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypton1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        String fileResult = "";
        Form2 f2 = new Form2();
        public void setMkey(String mkey)
        {
            this.mKey.Text = mkey;
        }
        public void setEkey(String ekey)
        {
            this.eKey.Text = ekey;
        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        public static void ShowGenDialog(String ekey,String mkey)
        {
            Form6 gd = new Form6();
            gd.eKey.Text = ekey;
            gd.mKey.Text = mkey;
            gd.ShowDialog();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
