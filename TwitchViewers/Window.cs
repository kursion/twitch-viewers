using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitchViewers
{
    public partial class Window : Form
    {
        // This delegate enables asynchronous calls for setting
        // the text property on a TextBox control.
        delegate void SetTextCallback(string text);

        public Window()
        {
            InitializeComponent();
        }

        public String getUsername()
        {
            return this.textBox1.Text;
        }

        public void setViewers(string viewers)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.viewersField.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(setViewers);
                this.Invoke(d, new object[] { viewers });
            }
            else
            {
                this.viewersField.Text = viewers;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

