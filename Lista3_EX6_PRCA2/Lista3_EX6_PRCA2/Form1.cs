using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista3_EX6_PRCA2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Milhas milhas;
            milhas = new Milhas();
            milhas.setValormilhas(Double.Parse(textBox1.Text));
            milhas.resultado();
            MessageBox.Show(milhas.getValormilhas() + " milhas equivalem a " + milhas.getValorkm() + " Km");
        }
    }
}
