namespace FE8_GUI
{
    partial class ProgramMode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.back = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.layout0 = new System.Windows.Forms.TableLayoutPanel();
            this.close = new System.Windows.Forms.Button();
            this.window = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.add = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ports = new System.Windows.Forms.ComboBox();
            this.getports = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.commandline = new System.Windows.Forms.ComboBox();
            this.live = new System.Windows.Forms.CheckBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.layout0.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(2, 2);
            this.back.Margin = new System.Windows.Forms.Padding(2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(82, 23);
            this.back.TabIndex = 0;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // send
            // 
            this.send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.send.Location = new System.Drawing.Point(2, 2);
            this.send.Margin = new System.Windows.Forms.Padding(2);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(77, 36);
            this.send.TabIndex = 1;
            this.send.Text = "Go and Refresh";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // layout0
            // 
            this.layout0.ColumnCount = 3;
            this.layout0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout0.Controls.Add(this.back, 0, 0);
            this.layout0.Controls.Add(this.close, 2, 0);
            this.layout0.Controls.Add(this.window, 1, 2);
            this.layout0.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.layout0.Controls.Add(this.tableLayoutPanel2, 2, 1);
            this.layout0.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.layout0.Location = new System.Drawing.Point(-1, 1);
            this.layout0.Name = "layout0";
            this.layout0.RowCount = 3;
            this.layout0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.10381F));
            this.layout0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.17301F));
            this.layout0.Size = new System.Drawing.Size(531, 289);
            this.layout0.TabIndex = 3;
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.Location = new System.Drawing.Point(453, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 46);
            this.close.TabIndex = 2;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.button3_Click);
            // 
            // window
            // 
            this.window.AcceptsReturn = true;
            this.window.AllowDrop = true;
            this.window.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.window.Location = new System.Drawing.Point(135, 146);
            this.window.Multiline = true;
            this.window.Name = "window";
            this.window.Size = new System.Drawing.Size(259, 140);
            this.window.TabIndex = 4;
            this.window.Text = "Results and status of the board";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.send, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.add, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(48, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(81, 80);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(3, 43);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 34);
            this.add.TabIndex = 2;
            this.add.Text = "Add Common";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.ports, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.getports, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(400, 60);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(128, 80);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // ports
            // 
            this.ports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.ports.FormattingEnabled = true;
            this.ports.Location = new System.Drawing.Point(3, 3);
            this.ports.Name = "ports";
            this.ports.Size = new System.Drawing.Size(89, 21);
            this.ports.TabIndex = 7;
            // 
            // getports
            // 
            this.getports.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.getports.Location = new System.Drawing.Point(3, 43);
            this.getports.Name = "getports";
            this.getports.Size = new System.Drawing.Size(103, 34);
            this.getports.TabIndex = 8;
            this.getports.Text = "Get Ports";
            this.getports.UseVisualStyleBackColor = true;
            this.getports.Click += new System.EventHandler(this.getports_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.commandline, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.live, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(135, 60);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(259, 80);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // commandline
            // 
            this.commandline.AllowDrop = true;
            this.commandline.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commandline.FormattingEnabled = true;
            this.commandline.Location = new System.Drawing.Point(3, 3);
            this.commandline.MaxDropDownItems = 4;
            this.commandline.Name = "commandline";
            this.commandline.Size = new System.Drawing.Size(253, 21);
            this.commandline.TabIndex = 5;
            this.commandline.Text = "command to go or nothing but refresh";
            // 
            // live
            // 
            this.live.AutoSize = true;
            this.live.Location = new System.Drawing.Point(3, 43);
            this.live.Name = "live";
            this.live.Size = new System.Drawing.Size(65, 17);
            this.live.TabIndex = 6;
            this.live.Text = "real time";
            this.live.UseVisualStyleBackColor = true;
            this.live.CheckedChanged += new System.EventHandler(this.live_CheckedChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 2000000;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // ProgramMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.layout0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProgramMode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DebugPanel";
            this.layout0.ResumeLayout(false);
            this.layout0.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TableLayoutPanel layout0;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.TextBox window;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox commandline;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox ports;
        private System.Windows.Forms.Button getports;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.CheckBox live;
    }
}