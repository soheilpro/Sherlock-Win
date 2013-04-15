using System;
using System.Windows.Forms;

namespace Sherlock
{
    public static class Program
    {
        [STAThread]
        public static void Main(params string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain(args));
        }
    }
}
