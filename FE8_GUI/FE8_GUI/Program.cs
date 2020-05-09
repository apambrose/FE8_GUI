using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FE8_GUI
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
            DeployedColor.Background = System.Drawing.Color.Teal;
            DeployedColor.Button = System.Drawing.Color.Orange;
            DeployedColor.CloseButton = System.Drawing.Color.SaddleBrown;
            Application.Run(new Form1());
        }
    }
}
