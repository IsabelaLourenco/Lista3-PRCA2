using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista3_EX7_PRCA2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Moeda moeda;
            moeda = new Moeda();
            moeda.setCotacao(Double.Parse(textBox1.Text));
            moeda.setDolar(Double.Parse(textBox2.Text));
            moeda.resultado();
            MessageBox.Show( moeda.getDolar()+ " dolares equivalem a " 
               + moeda.getReal() + " reais");
        }
    }
}
