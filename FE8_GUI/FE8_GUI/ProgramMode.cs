using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FE8_GUI
{
    public partial class ProgramMode : Form
    {
       
       public ProgramMode(Size size)
        {
            
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(this.Size.Width, this.Size.Height);
            layout0.Location = new System.Drawing.Point(0, 0);
            layout0.Size = new System.Drawing.Size(this.Width, this.Height);
            DeployedScheme.ChangeColorForAll(this);
            ChangelayoutSize(size);

            
        }
        #region SizeManagementx
        public void ChangelayoutSize(Size size)
        {
            this.layout0.Size = size;
        }
        #endregion SizeManagement

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void send_Click(object sender, EventArgs e)
        {

            String line = ports.Text;
            if (line.Length == 0) {
                window.Text = "no selected port.\n";
                return; }
            if (!serialPort1.IsOpen || serialPort1.PortName != line)
            {
                /* foreach (char i in line) {

                     Console.WriteLine(i);
                 */
                serialPort1.BaudRate = 2000000;
                serialPort1.PortName = line;
                Console.WriteLine(serialPort1.PortName);
                serialPort1.Open();
                Console.WriteLine(serialPort1.IsOpen);
                ports.DropDownStyle = ComboBoxStyle.Simple;
              
                try { serialPort1.Write(line + "\n"); }
                catch (InvalidOperationException)
                {
                    Console.WriteLine("failure caused by writing or connection");
                }
            }

            //simplly reading from serialport will stop and freeze after
            //a few successful trials
            //serialPort1.DataReceived += new SerialDataReceivedEventHandler(ReadfromSerial);
            String str = "";

            bool Completed = ThreadTimer(TimeSpan.FromMilliseconds(1), () =>
            {
                //using window.Text += ReadLine() will produce
                //exception for window is not created in this 
                //worker's thread but master's.
                str = serialPort1.ReadLine();
                //Console.Write("finished");

                

            });
            if (Completed)
            {
                Console.WriteLine("recieved from another thread: " + str);
                window.Text += str;
            }
            else
            {
                Console.WriteLine("failed to recieved from another thread.");
            }


        }

        private void add_Click(object sender, EventArgs e)
        {
            //add the current line in command textbox to droplist
        }

        private void getports_Click(object sender, EventArgs e)
        {
            ports.DropDownStyle = ComboBoxStyle.DropDown;
            String[] portlist = SerialPort.GetPortNames();
           
            foreach (String i  in portlist) {
                //tableLayoutPanel2.
                
                foreach (String j in ports.Items) {
                    if (i == j) {
                        goto Skip;
                    }
                }

                ports.Items.Add(i);
                if (portlist.Length == 1)
                {
                    ports.SelectedItem = ports.Items[0];
                    goto Skip;
                }
            Skip:
                /*donothing*/;

            }
        }
        #region refreshacontrol
        bool realtime = true;
        int refresh;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (realtime) {
                //SerialPortClearBuffers();
                try { window.Text = window.Text += serialPort1.ReadLine(); }//.Replace(window.Text,serialPort1.ReadLine()); }
                catch (Exception) { realtime = false; }
            }
            
        }
        #endregion refreshcontrol

        public static bool ThreadTimer(TimeSpan timeSpan, Action codeBlock)
        {
            try
            {
                //this is going to create a new thread
                Task task = Task.Factory.StartNew(() => codeBlock());
                task.Wait(timeSpan);
                return task.IsCompleted;
            }
            catch (AggregateException ae)
            {
                throw ae.InnerExceptions[0]; 
            }
        }
      
        private void SerialPortClearBuffers()
        {  
            serialPort1.DiscardOutBuffer();
            serialPort1.DiscardInBuffer();
            serialPort1.BaseStream.Flush();
        }

        private void live_CheckedChanged(object sender, EventArgs e)
        {
            this.live.Checked = true;
            if (serialPort1.IsOpen) {
                String str = "";
                while (this.live.Checked)
                {
                    str = serialPort1.ReadLine();
                    this.window.Text += str + "\n";
                    ProcessCmdKey()
                }
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
           // serialPort1.ReadLine();
        }
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
}
