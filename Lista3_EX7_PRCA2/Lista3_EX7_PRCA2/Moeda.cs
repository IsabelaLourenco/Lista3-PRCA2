using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_EX7_PRCA2
{
    class Moeda
    {
        private double dolar;
        private double cotacao;
        private double real;

        public Moeda()
        {
            dolar = 0;
            cotacao = 0;
            real = 0;
        }

        public Moeda(double dolar, double cotacao, double real)
        {
            this.dolar = dolar;
            this.cotacao = cotacao;
            this.real = real;
        }

        public void setDolar(double dolar)
        {
            this.dolar = dolar;
        }
        public double getDolar()
        {
            return this.dolar;
        }
        public void setCotacao(double cotacao)
        {
            this.cotacao = cotacao;
        }
        public double getCotacaor()
        {
            return this.cotacao;
        }
        public double getReal()
        {
            return this.real;
        }

        public void resultado()
        {
            this.real = this.cotacao * this.dolar;
        }
    }
}
