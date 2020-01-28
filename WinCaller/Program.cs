using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinCaller.Core;

namespace WinCaller
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

            Controller.Initialise();

            if (Controller.Settings != null)
            {
                Application.Run(new MainForm());
            } 
            else
            {
                Application.Run(new SetupForm());
            }
            
        }
    }
}
