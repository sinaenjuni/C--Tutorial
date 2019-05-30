using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyForm6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            button1.Text = Width.ToString();
            button2.Text = Height.ToString();

            if(Width <= 500)
            {

                Width = 500;
               
            }
            if (Height <= 500)
            {
                Height = 500;
               
            }
        }
    }
}
