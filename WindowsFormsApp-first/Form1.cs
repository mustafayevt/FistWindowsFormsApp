using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_first
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random random = new Random();
            button1.Left = random.Next(0, Width - button1.Width);
            button1.Top = random.Next(0, Height - button1.Height);
        }
    }
}
