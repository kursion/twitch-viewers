namespace TwitchViewers
{
    partial class Window
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
      this.label1 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.viewersField = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.DarkGray;
      this.label1.Location = new System.Drawing.Point(136, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(55, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Viewers:";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // textBox1
      // 
      this.textBox1.AccessibleName = "";
      this.textBox1.Location = new System.Drawing.Point(12, 5);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(118, 20);
      this.textBox1.TabIndex = 1;
      this.textBox1.Text = "kursion";
      // 
      // viewersField
      // 
      this.viewersField.AutoSize = true;
      this.viewersField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.viewersField.ForeColor = System.Drawing.Color.DodgerBlue;
      this.viewersField.Location = new System.Drawing.Point(197, 5);
      this.viewersField.Name = "viewersField";
      this.viewersField.Size = new System.Drawing.Size(19, 20);
      this.viewersField.TabIndex = 2;
      this.viewersField.Text = "0";
      this.viewersField.Click += new System.EventHandler(this.label2_Click);
      // 
      // Window
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(328, 31);
      this.Controls.Add(this.viewersField);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Window";
      this.Opacity = 0.9D;
      this.Text = "TwitchViewers";
      this.TopMost = true;
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label viewersField;
    }
}

