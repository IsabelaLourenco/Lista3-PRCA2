using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_EX11_PRCA2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Peso peso;
            peso = new Peso();
            peso.setPeso(Double.Parse(textBox1.Text));
            peso.setAltura(Double.Parse(textBox2.Text));
            peso.indice();
            if(peso.getIMC() < 20)
            {
                MessageBox.Show("Você está abaixo do peso");
            }
            if (20 <= peso.getIMC() && peso.getIMC() < 25)
            {
                MessageBox.Show("Você está com o peso ideal");
            }
            if (peso.getIMC() > 25)
            {
                MessageBox.Show("Você está acima do peso");
            }
        }
    }
}
