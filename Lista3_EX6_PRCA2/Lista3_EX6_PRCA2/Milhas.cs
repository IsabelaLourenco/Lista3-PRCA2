using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_EX6_PRCA2
{
    class Milhas
    {
        private double milhas;
        private double valor;
        private double km = 1.852;

        public Milhas()
        {
            km = 0;
            milhas = 0;
            valor = 0;
        }

        public Milhas(double milhas, double valor, double km)
        {
            this.milhas = milhas;
            this.valor = valor;
            this.km = km;
        }

        public void setValormilhas(double milhas)
        {
            this.milhas = milhas;
        }
        public double getValormilhas()
        {
            return this.milhas;
        }
        public double getValorkm()
        {
            return this.valor;
        }

        public void resultado()
        {
            this.valor = this.milhas * this.km;
        }
    }
}
