using System;
using System.Drawing;
using System.Windows.Forms;

namespace FE8_GUI
{
    partial class Form1
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
            this.start = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.layout1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.scheme = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.layout2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.layout3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.layout0 = new System.Windows.Forms.TableLayoutPanel();
            this.layout1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.layout2.SuspendLayout();
            this.layout3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.layout0.SuspendLayout();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.start.Cursor = System.Windows.Forms.Cursors.Default;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.Location = new System.Drawing.Point(3, 387);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(520, 89);
            this.start.TabIndex = 0;
            this.start.Text = "Program Mode";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.button1_Click);
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Location = new System.Drawing.Point(295, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(126, 80);
            this.close.TabIndex = 1;
            this.close.Text = "X\r\n";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.button2_Click);
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.title.AutoSize = true;
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(41, 236);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(444, 148);
            this.title.TabIndex = 2;
            this.title.Text = "Telemetry : Serial Monitor";
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // layout1
            // 
            this.layout1.Controls.Add(this.panel1);
            this.layout1.Dock = System.Windows.Forms.DockStyle.Left;
            this.layout1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.layout1.Location = new System.Drawing.Point(3, 3);
            this.layout1.Name = "layout1";
            this.layout1.Size = new System.Drawing.Size(393, 962);
            this.layout1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.scheme);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.MaximumSize = new System.Drawing.Size(240, 242);
            this.panel1.MinimumSize = new System.Drawing.Size(120, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 80);
            this.panel1.TabIndex = 5;
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(0, 202);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(240, 38);
            this.button6.TabIndex = 4;
            this.button6.Text = "Personalize a Scheme";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // scheme
            // 
            this.scheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scheme.Location = new System.Drawing.Point(0, 0);
            this.scheme.Name = "scheme";
            this.scheme.Size = new System.Drawing.Size(117, 80);
            this.scheme.TabIndex = 0;
            this.scheme.Text = "Scheme";
            this.scheme.UseVisualStyleBackColor = true;
            this.scheme.Click += new System.EventHandler(this.Scheme_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(0, 162);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(210, 38);
            this.button5.TabIndex = 3;
            this.button5.Text = "Personal Scheme";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(0, 122);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 38);
            this.button4.TabIndex = 2;
            this.button4.Text = "BlackandWhite";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(0, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 38);
            this.button3.TabIndex = 1;
            this.button3.Text = "ArduinoBasic";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // layout2
            // 
            this.layout2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layout2.ColumnCount = 1;
            this.layout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout2.Controls.Add(this.textBox1, 0, 2);
            this.layout2.Controls.Add(this.start, 0, 1);
            this.layout2.Controls.Add(this.title, 0, 0);
            this.layout2.Location = new System.Drawing.Point(402, 3);
            this.layout2.Name = "layout2";
            this.layout2.RowCount = 3;
            this.layout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.layout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout2.Size = new System.Drawing.Size(526, 962);
            this.layout2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Peru;
            this.textBox1.Location = new System.Drawing.Point(0, 480);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(526, 382);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Connect Board(s) with USB and begin\r\nA Board has been Detected.(ID: 1)\r\nA Board h" +
    "as been Detected.(ID: 2)\r\n...\r\n...\r\n...\r\nskr";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // layout3
            // 
            this.layout3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 438F));
            this.layout3.Controls.Add(this.panel2);
            this.layout3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout3.Location = new System.Drawing.Point(934, 3);
            this.layout3.Name = "layout3";
            this.layout3.RowCount = 2;
            this.layout3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout3.Size = new System.Drawing.Size(395, 962);
            this.layout3.TabIndex = 6;
            this.layout3.Paint += new System.Windows.Forms.PaintEventHandler(this.layout3_Paint);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.close);
            this.panel2.Location = new System.Drawing.Point(4, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 471);
            this.panel2.TabIndex = 2;
            // 
            // layout0
            // 
            this.layout0.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.layout0.ColumnCount = 3;
            this.layout0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.layout0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.layout0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.layout0.Controls.Add(this.layout2, 1, 0);
            this.layout0.Controls.Add(this.layout1, 0, 0);
            this.layout0.Controls.Add(this.layout3, 2, 0);
            this.layout0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout0.Location = new System.Drawing.Point(0, 0);
            this.layout0.Name = "layout0";
            this.layout0.RowCount = 1;
            this.layout0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout0.Size = new System.Drawing.Size(1332, 968);
            this.layout0.TabIndex = 0;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1332, 968);
            this.Controls.Add(this.layout0);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.SeaShell;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.layout1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.layout2.ResumeLayout(false);
            this.layout2.PerformLayout();
            this.layout3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.layout0.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        
        
        /// <summary>
        /// this file should not be modified in anyway, 
        /// because it is going to get rewritted to its
        /// inital form, under many circumstances.
        /// </summary>
        

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.FlowLayoutPanel layout1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button scheme;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer1;
        private TableLayoutPanel layout2;
        private TableLayoutPanel layout3;
        private TableLayoutPanel layout0;
        private Panel panel2;
        private TextBox textBox1;
    }
}

