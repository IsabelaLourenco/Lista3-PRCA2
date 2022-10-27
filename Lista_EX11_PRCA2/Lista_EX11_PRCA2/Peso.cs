using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_EX11_PRCA2
{
    class Peso
    {
        private double altura;
        private double peso;
        private double imc;

        public Peso()
        {
            altura = 0;
            peso = 0;
            imc = 0;
        }
        public Peso(double altura, double peso, double imc)
        {
            this.altura = altura;
            this.peso = peso;
            this.imc = imc;
        }
        public void setAltura(double altura)
        {
            this.altura = altura;
        }
        public double getAltura()
        {
            return this.altura;
        }
        public void setPeso(double peso)
        {
            this.peso = peso;
        }
        public double getPeso()
        {
            return this.peso;
        }
        public double getIMC()
        {
            return this.imc;
        }
        public void indice()
        {
            this.imc = this.peso / (this.altura * this.altura);
        }
    }
}
