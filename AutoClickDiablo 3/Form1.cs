using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClickDiablo_3
{
    public partial class Form1 : Form
    {
        int _A,_A1=0;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            _A = 120;
            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled==true)
            {
                button1.BackColor = Color.Green;
            }
            else
            {
                button1.BackColor = Color.Red;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Control.IsKeyLocked(Keys.Scroll))
            {
                SendKeys.Send("1");
                SendKeys.Send("2");
                SendKeys.Send("3");
            }
            _A1++;
            if (_A1 ==_A)
            {
                SendKeys.Send("1");
                SendKeys.Send("2");
                SendKeys.Send("3");
                _A1 = 0;
            }
        }
    }
}
