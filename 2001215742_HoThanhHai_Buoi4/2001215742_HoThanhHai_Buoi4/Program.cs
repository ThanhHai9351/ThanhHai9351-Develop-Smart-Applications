using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001215742_HoThanhHai_Buoi4
{
    static class Program
    {
        public static mainForm frmMain = null;
        public static Form1 loginForm = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            loginForm = new Form1();
            Application.Run(new Form1());
        }
    }
}
