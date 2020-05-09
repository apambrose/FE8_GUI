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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Debug Debugpanel = new Debug();
            Debugpanel.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
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
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
