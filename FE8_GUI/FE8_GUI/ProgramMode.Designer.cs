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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.layout0 = new System.Windows.Forms.TableLayoutPanel();
            this.close = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.layout0.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(46, 59);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Go and Refresh";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // layout0
            // 
            this.layout0.ColumnCount = 3;
            this.layout0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout0.Controls.Add(this.button1, 0, 0);
            this.layout0.Controls.Add(this.close, 2, 0);
            this.layout0.Controls.Add(this.textBox1, 1, 1);
            this.layout0.Controls.Add(this.textBox2, 1, 2);
            this.layout0.Controls.Add(this.button2, 0, 1);
            this.layout0.Location = new System.Drawing.Point(-1, 1);
            this.layout0.Name = "layout0";
            this.layout0.RowCount = 3;
            this.layout0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.layout0.Size = new System.Drawing.Size(522, 289);
            this.layout0.TabIndex = 3;
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.Location = new System.Drawing.Point(444, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 46);
            this.close.TabIndex = 2;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AllowDrop = true;
            this.textBox1.Location = new System.Drawing.Point(133, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Command to go or nothing but refresh\r\n";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.AcceptsReturn = true;
            this.textBox2.AllowDrop = true;
            this.textBox2.Location = new System.Drawing.Point(133, 117);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(255, 140);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Results and status of the board";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel layout0;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}