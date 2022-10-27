using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista3_EX13_PRCA2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Triangulo tri;
            tri = new Triangulo();
            tri.setA(int.Parse(textBox1.Text));
            tri.setB(int.Parse(textBox2.Text));
            tri.setC(int.Parse(textBox3.Text));
            MessageBox.Show(tri.ehTretangulo() ?
                "é um triangulo retangulo" :
                "não é triangulo retangulo");

        }
    }
}
