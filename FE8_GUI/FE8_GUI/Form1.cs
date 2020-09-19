using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
//to use the dll import
using System.Runtime.InteropServices;

namespace FE8_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            timer1.Start();
            
            Console.WriteLine(Screen.PrimaryScreen.Bounds);
            Console.WriteLine(GetScalingFactor());
            float scale = GetScalingFactor();
            int W = Screen.PrimaryScreen.Bounds.Width;
            int H = Screen.PrimaryScreen.Bounds.Height;

            Size size = new Size(W,H);
            Console.WriteLine(size.Width.ToString());
            Console.WriteLine(size.Height.ToString());
            this.ChangeLayoutSize(size, scale);
            DeployedScheme.ChangeColorForAll(this);
           //this.ChangeElementSize(size);

        }

        #region GetScalingFactor
        //some people  have a scaling factor for their desktop
        //but this is going to mess up the resolution info
        //so here is a solution from GitHub
        [DllImport("gdi32.dll")]
        static extern int GetDeviceCaps(IntPtr hdc, int nIndex);
        public enum DeviceCap
        {
            VERTRES = 10,
            DESKTOPVERTRES = 117,

            
        }


        private float GetScalingFactor()
        {
            Graphics g = Graphics.FromHwnd(IntPtr.Zero);
            IntPtr desktop = g.GetHdc();
            int LogicalScreenHeight = GetDeviceCaps(desktop, (int)DeviceCap.VERTRES);
            int PhysicalScreenHeight = GetDeviceCaps(desktop, (int)DeviceCap.DESKTOPVERTRES);

            float ScreenScalingFactor = (float)PhysicalScreenHeight / (float)LogicalScreenHeight;

            return ScreenScalingFactor; // 1.25 = 125%
        }
        #endregion GetScalingFactor

        #region SizeManagement
        public void ChangeLayoutSize(Size size, float scale)
        {
            //Although there is scaling factor, PCs will still
            //translate the drawing scale back to the actual screen size,
            //so here are supposed to see if the physical resolutions are supported
            //it may be redundent to do so, but it shows what we can play with
            int W = (int)((float)(Screen.PrimaryScreen.Bounds.Width) * scale);
            int H = (int)((float)(Screen.PrimaryScreen.Bounds.Height) * scale);
            if (!((W >= 1680) && (H >= 1050)))
            {
                Console.WriteLine((int)(size.Width));
                Console.WriteLine(size.Height);

                size.Width = 800;
                size.Height = 600;
                Console.WriteLine("the reso is too small");
            }
            
            this.ClientSize = new System.Drawing.Size((int)(size.Width ), (int)(size.Height));
            this.layout0.Location = new System.Drawing.Point(0, 0);
            this.layout1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.layout2.Location = new System.Drawing.Point((int)(size.Width * 0.3), 0);
            this.layout3.Location = new System.Drawing.Point((int)(size.Width * 0.7), 0);
            this.panel2.Location = new System.Drawing.Point((int)(size.Width * 0.7), 0);

            //sublayouts resize proportionally
            //layout0, the underlying layout is going to
            //resize its column based on the deployed layouts
            //this is to achieve the dividing lines effect.
            this.layout0.Size = ClientSize;
            Console.WriteLine("{0},{1}", layout0.Size.Width.ToString(), layout0.Size.Height.ToString());
            //Console.WriteLine((int)(size.Width * 0.3));
            //Console.WriteLine(size.Height);
            this.layout1.Size = new System.Drawing.Size((int)(size.Width * 0.3), size.Height);
            //this.panel1.Size = new System.Drawing.Size((int)(size.Width * 0.3), size.Height);

            Console.WriteLine("From");
            Console.WriteLine("{0},{1}",layout1.Size.Width,layout1.Size.Height);
            this.textBox1.Size = new System.Drawing.Size((int)(size.Width * 0.4), (int)(size.Height * 0.4));
            Console.WriteLine("{0},{1}", textBox1.Size.Width.ToString(), textBox1.Size.Height.ToString());

            this.layout2.Size = new System.Drawing.Size((int)(layout0.Size.Width * 0.4), layout0.Size.Height);
            Console.WriteLine("{0},{1}", layout2.Size.Width.ToString(), layout2.Size.Height.ToString());
            this.layout3.Size = new System.Drawing.Size((int)(layout0.Size.Width * 0.3) , layout0.Size.Height);
            Console.WriteLine("{0},{1}", layout3.Size.Width.ToString(), layout3.Size.Height.ToString());
            Console.WriteLine("till");
            this.panel2.Size = new System.Drawing.Size((int)(layout0.Size.Width * 0.3), layout0.Size.Height);
            Console.WriteLine(size.Width);
            Console.WriteLine(size.Height);


            return;

        }
        public void ChangeElementSize(Size size)
        {
            this.start.Location = new System.Drawing.Point(0, 0);
            this.start.Size = new System.Drawing.Size((int)(size.Width * 0.3), 0);
            this.close.Location = new System.Drawing.Point(0, 0);
            this.close.Size = new System.Drawing.Size((int)(size.Width * 0.4), 0);
            this.scheme.Location = new System.Drawing.Point(0, 0);
            this.scheme.Size = new System.Drawing.Size((int)(size.Width * 0.3), 0);
        }

        #endregion SizeManagement


        #region Internal Control Flow
        #region variables
        bool IsCollapsed;
        #endregion variables

        
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    ClosingConfrim closing = new ClosingConfrim();
                    closing.ShowDialog();
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (IsCollapsed)
            {
                panel1.Height += 30;
                panel1.Width += 30;
                if (panel1.Size == panel1.MaximumSize)
                {
                    timer1.Stop();
                    IsCollapsed = false;

                }
            }
            else
            {
                panel1.Height -= 30;
                panel1.Width -= 30;
                if (panel1.Size == panel1.MinimumSize)
                {
                    timer1.Stop();
                    IsCollapsed = true;

                }
            }
        }
        #endregion Internal Control Flow

        #region Button Clicks
        private void button1_Click(object sender, EventArgs e)
        {
            ProgramMode programwindow = new ProgramMode(this.Size);
            programwindow.Size = this.Size;
            programwindow.ShowDialog();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
 
        }

        private void Scheme_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        #endregion Button Clicks

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void layout3_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
