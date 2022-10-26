using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_EX1_PRCA2
{
    class Retangulo
    {
        private int b;
        private int h;
        private int a;

        public Retangulo()
        {
            this.b = 0;
            this.h = 0;
            this.a = 0;
        }

        public Retangulo(int a, int b, int h)
        {
            this.a = a;
            this.b = b;
            this.h = h;
        }
        public void setB(int b)
        {
            this.b = b;
        }
        public void setH(int h)
        {
            this.h = h;
        }
        public int getB()
        {
            return this.b;
        }
        public int getH()
        {
            return this.h;
        }
        public int getA()
        {
            return this.a;
        }
        public void area()
        {
            this.a = this.b * this.h;
        }

    }
}

