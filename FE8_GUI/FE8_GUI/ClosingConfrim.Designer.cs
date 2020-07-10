namespace FE8_GUI
{
    partial class ClosingConfrim
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
            this.Yes = new System.Windows.Forms.Button();
            this.No = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Yes
            // 
            this.Yes.Location = new System.Drawing.Point(2, 2);
            this.Yes.Margin = new System.Windows.Forms.Padding(2);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(60, 32);
            this.Yes.TabIndex = 0;
            this.Yes.Text = "Yes";
            this.Yes.UseVisualStyleBackColor = true;
            this.Yes.Click += new System.EventHandler(this.button1_Click);
            // 
            // No
            // 
            this.No.Location = new System.Drawing.Point(66, 2);
            this.No.Margin = new System.Windows.Forms.Padding(2);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(60, 32);
            this.No.TabIndex = 1;
            this.No.Text = "No";
            this.No.UseVisualStyleBackColor = true;
            this.No.Click += new System.EventHandler(this.button2_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Yes);
            this.flowLayoutPanel1.Controls.Add(this.No);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(133, 32);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // ClosingConfrim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(133, 32);
            this.ControlBox = false;
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ClosingConfrim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Closing";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Yes;
        private System.Windows.Forms.Button No;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}