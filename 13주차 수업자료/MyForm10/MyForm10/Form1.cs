using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyForm10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int quota, remember;
            textBox2.Text = "";
            quota = int.Parse(textBox1.Text);

            while(quota != 0)
            {
                quota = Math.DivRem(quota, 2, out remember);
                textBox2.Text = textBox2.Text.Insert(0, remember.ToString());
            }
        }
    }
}
