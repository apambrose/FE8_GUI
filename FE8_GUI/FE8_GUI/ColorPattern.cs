using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FE8_GUI
{
    static class DeployedScheme{
        public static Color Background;
        public static Color Button;
        public static Color CloseButton;
        public static FlatStyle ButtonStyle;
    }
    #region ColorPattern customization constructor
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
    #endregion ColorPattern customization constructor
}
