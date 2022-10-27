using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista3_EX10_PRCA2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Terreno ter;
            ter = new Terreno();
            ter.setB(int.Parse(textBox1.Text));
            ter.setH(int.Parse(textBox2.Text));
            ter.area();
            if (ter.getA() > 100)
            {
                MessageBox.Show("Terreno grande com área de  "
                    + ter.getA());
            }
            if (ter.getA() < 100)
            {
                MessageBox.Show("Terreno pequeno com área de  "
                    + ter.getA());
            }
        }
    }
}
