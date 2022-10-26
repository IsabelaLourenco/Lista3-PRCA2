using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista3_EX1_PRCA2
{
    public partial class Form1 : Form
    {       
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Retangulo ret;
            ret = new Retangulo();
            ret.setB(int.Parse(textBox3.Text));
            ret.setH(int.Parse(textBox4.Text));
            ret.area();
            MessageBox.Show("a area do retangulo é " + ret.getA().ToString()); ;
        }
    }
}
