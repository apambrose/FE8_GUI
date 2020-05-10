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

namespace FE8_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            timer1.Start();
        }

        #region Internal Control Flow
        #region variables
        bool IsCollapsed;
        #endregion variables



        //
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

        private void button1_Click(object sender, EventArgs e)
        {
            Debug Debugpanel = new Debug();
            Debugpanel.ShowDialog();
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

        
    }
}
