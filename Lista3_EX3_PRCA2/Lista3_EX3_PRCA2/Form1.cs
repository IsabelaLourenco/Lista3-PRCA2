using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista3_EX3_PRCA2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Quadrado quad;
            quad = new Quadrado();
            quad.setDiagonal(int.Parse(textBox1.Text));
            quad.resultado();
            MessageBox.Show("A área do quadrado é " + quad.getArea());
        }
    }
}
