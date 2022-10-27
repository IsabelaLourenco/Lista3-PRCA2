using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_EX4_PRCA2
{
    class Triangulo
    {
       
            private int b;
            private int h;
            private int a;

            public Triangulo()
            {
                b = 0;
                h = 0;
                a = 0;
            }

            public Triangulo(int a, int h, int b)
            {
                this.b = b;
                this.h = h;
                this.a = a;
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
                this.a = (this.b * this.h) / 2;
            }

        }
    }

