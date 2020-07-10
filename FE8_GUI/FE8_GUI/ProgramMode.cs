using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FE8_GUI
{
    public partial class ProgramMode : Form
    {
        public ProgramMode()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(this.Size.Width, this.Size.Height);
            layout0.Location = new System.Drawing.Point(0, 0);
            layout0.Size = new System.Drawing.Size(this.Width, this.Height);
            DeployedScheme.ChangeColorForAll(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
