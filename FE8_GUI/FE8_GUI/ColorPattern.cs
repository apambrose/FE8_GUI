using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FE8_GUI
{

    /// <summary>
    /// The class that can have only one instance and it will be 
    /// the class name itself.
    /// In visual studio the preview does not show anycolor because
    /// the colors are  deployed at run time.
    /// </summary>
    static class DeployedScheme{
        public static Color Background;
        public static Color Button;
        public static Color CloseButton;
        public static FlatStyle ButtonStyle;

        //to change a form's color
        public static void ChangeColorForAll(Form form)
        { 
            int loop = 0;
            form.BackColor = DeployedScheme.Background;

           
            foreach (Control control in form.Controls)
            {
                loop++;
                // THIS LAYER OF CONTROLS ALSO NEED TO
                // BE COLORED, BUT FOR THE SAKE OF RESIZING
                // OBSERVATION, IT WILL BE FINISHED LATER IN
                // THE CASE.
                ChangeColorandPatternForAllControls(control);
            }
            Console.WriteLine(loop);
           
        }
       //A recursive function is needed because there
       //are inclusive relationships once  a control(container control, common control
       // and more...) is added inside a control.
        private static void ChangeColorandPatternForAllControls(Control controls)
        { 
            
            foreach (Control c in controls.Controls)
            {
                //Console.WriteLine("{0}", c.GetType());
                if (c is Button)
                {
                    //Console.WriteLine("there are buttons");
                    if (c.Name != "close")
                    {
                        c.BackColor = DeployedScheme.Button;
                    }
                    else
                    {
                        c.BackColor = DeployedScheme.CloseButton;
                    }
                    ((Button)c).FlatStyle = DeployedScheme.ButtonStyle;
                    ChangeColorandPatternForAllControls(c);

                }
                else if (c is FlowLayoutPanel || c is TableLayoutPanel || c is Panel)
                {
                    //Console.WriteLine("there are panels");
                    c.BackColor = DeployedScheme.Background;
                    ChangeColorandPatternForAllControls(c);
                }
                
            }
           
        }
    }
    #region ColorPattern & customization constructor
    public class ColorPattern
    {
        Color Background = System.Drawing.Color.Empty;
        Color Button = System.Drawing.Color.Empty;
        Color CloseButton = System.Drawing.Color.Empty;
        FlatStyle ButtonStyle = System.Windows.Forms.FlatStyle.System;
        public  ColorPattern(Color back, Color button, Color close, FlatStyle buttonstyle ) {
            if (back == button || back == close) { 
                throw new InvalidOperationException("Back color should not be the same as button");
            }
            Background = back;
            Button = button;
            CloseButton = close;
            ButtonStyle = buttonstyle;
        }
       
        
    }
    #endregion ColorPattern & customization constructor
}
