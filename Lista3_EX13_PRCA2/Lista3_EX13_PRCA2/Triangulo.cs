using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_EX13_PRCA2
{
    class Triangulo
    {
        private int a;
        private int b;
        private int c;

        public Triangulo()
        {
            a = 0;
            b = 0;
            c = 0;
        }
        public Triangulo(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void setA(int a)
        {
            this.a = a;
        }
        public void setB(int b)
        {
            this.b = b;
        }
        public void setC(int c)
        {
            this.c = c;
        }
        public int getA()
        {
            return this.a;
        }
        public int getB()
        {
            return this.b;
        }
        public int getC()
        {
            return this.c;
        }
        public bool ehTretangulo()
        {
            return (
           this.c * this.c == this.a * this.a + this.b * this.b ||
           this.b * this.b == this.a * this.a + this.c * this.c ||
           this.a * this.a == this.b * this.b + this.c * this.c
                );
        }

    }
}
