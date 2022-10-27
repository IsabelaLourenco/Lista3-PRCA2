using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_EX2_PRCA2
{
    class Quadrado
    {
        private int aresta;
        private int area;

        public Quadrado()
        {
            aresta = 0;
            area = 0;
        }

        public Quadrado(int aresta, int area)
        {
            this.aresta = aresta;
            this.area = area;
        }
        public void setAresta(int aresta)
        {
            this.aresta = aresta;
        }
        public int getAresta()
        {
            return this.aresta;
        }
        public int getArea()
        {
            return this.area;
        }
        public void resultado()
        {
            this.area = (int)Math.Pow(this.aresta, 2);
        }
    }
}
