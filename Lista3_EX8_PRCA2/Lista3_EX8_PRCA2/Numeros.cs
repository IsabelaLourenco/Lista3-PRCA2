using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_EX8_PRCA2
{
    class Numeros
    {
        private int n1;
        private int n2;

        public Numeros()
        {
            n1 = 0;
            n2 = 0;
        }

        public Numeros(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }
        public void setN1(int n1)
        {
            this.n1 = n1;
        }
        public int getN1()
        {
            return this.n1;
        }
        public void setN2(int n2)
        {
            this.n2 = n2;
        }
        public int getN2()
        {
            return this.n2;
        }
    }
}
