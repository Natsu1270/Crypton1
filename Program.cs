using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypton1
{

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
       
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"D:\VAN BANG 2\HK182\MM&ANM\Github\Crypton1\asset\b.wav");

            //sp.PlayLooping();

            //sp.Play();
            Application.Run(new Form1());
        }
        enum type { DES, RSA, XXX, HASH };
        
    }
}
