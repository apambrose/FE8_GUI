using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FE8_GUI
{
    static class DeployedColor {
        public static Color Background;
        public static Color Button;
        public static Color CloseButton;
    }
    #region ColorPattern customization constructor
    public class ColorPattern
    {
        Color Background = System.Drawing.Color.Empty;
        Color Button = System.Drawing.Color.Empty;
        Color CloseButton = System.Drawing.Color.Empty;
        public  ColorPattern(Color back, Color button, Color close ) {
            if (back == button || back == close) { 
                throw new InvalidOperationException("Back color should not be the same as button");
            }
            Background = back;
            Button = button;
            CloseButton = close;
        }
     
    }
    #endregion ColorPattern customization constructor
}
