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
            //reading a file could 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DeployedScheme.Background = System.Drawing.Color.Teal;
            DeployedScheme.Button = System.Drawing.Color.Orange;
            DeployedScheme.CloseButton = System.Drawing.Color.SaddleBrown;
            DeployedScheme.ButtonStyle = System.Windows.Forms.FlatStyle.Popup;
            Application.Run(new Form1());
        }
    }
}
