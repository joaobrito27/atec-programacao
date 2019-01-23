using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_Trabalho_3
{
    class Reta
    {
        //Usando as Propriedades.
        private Ponto _p1;
        private Ponto _p2;

        public Reta()
        {
            _p1 = new Ponto();
            _p2 = new Ponto();
        }
        public Reta(int x1, int y1, int x2, int y2)
        {
            _p1 = new Ponto(x1, y1);
            _p2 = new Ponto(x2, y2);
        }
        public Reta(Ponto p1, Ponto p2)
        {
            this._p1 = new Ponto(p1);
            this._p2 = new Ponto(p2);
        }
        public Reta(Reta r)
        {
            _p1 = r._p1;
            _p2 = r._p2;
        }
        public Ponto p1
        {
            get { return _p1; }
            set { _p1 = value; }
        }

        public Ponto p2
        {
            get { return _p2; }
            set { _p2 = value; }
        }
        public string toString()
        {
            return "Ponto 1: " + p1.toString() + " Ponto 2: " + p2.toString();
        }

        /*
        //Sem usar propriedades.
        private Ponto p1;
        private Ponto p2;

        public Reta()
        {
            p1 = new Ponto();
            p2 = new Ponto();
        }

        public Reta(int x1, int y1, int x2, int y2)
        {
            p1 = new Ponto(x1, y1);
            p2 = new Ponto(x2, y2);
        }

        public Reta(Ponto p1, Ponto p2)
        {
            this.p1 = new Ponto(p1);
            this.p2 = new Ponto(p2);
        }

        public Reta(Reta r)
        {
            p1 = r.p1;
            p2 = r.p2;
        }

        public Ponto getPonto(int x)
        {
            switch (x)
            {
                case 1:
                    return p1;
                case 2:
                    return p2;
                default:
                    return new Ponto();
            }
        }
        public string toString()
        {
            return "Ponto 1: " + p1.toString() + " Ponto 2: " + p2.toString();
        }
        */
    }
}
