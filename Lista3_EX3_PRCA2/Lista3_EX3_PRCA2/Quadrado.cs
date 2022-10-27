using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_EX3_PRCA2
{
    class Quadrado
    {
        private int d;
        private int area;

        public Quadrado()
        {
            d = 0;
            area = 0;
        }

        public Quadrado(int d, int area)
        {
            this.d = d;
            this.area = area;
        }
        public void setDiagonal(int d)
        {
            this.d = d;
        }
        public int getDiagonal()
        {
            return this.d;
        }
        public int getArea()
        {
            return this.area;
        }

        public void resultado()
        {
            this.area = (int)((Math.Pow(this.d, 2)) / 2);
        }
    }
}
