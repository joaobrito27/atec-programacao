using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_Trabalho_3
{
    class Ponto
    {
        //Usando as Propriedades
        //Auto Propriedade é quando retornamos algo sem validação*!
        private int _x, _y;

        public Ponto()
        {
            _x = 0;
            _y = 0;
        }

        public Ponto(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public Ponto(Ponto p)
        {
            _x = p._x;
            _y = p._y;
        }

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public string toString()
        {
            return "(" + X + "," + Y + ")";
        }

        public double distEntre2Pontos(Ponto p)
        {
            // Math.Sqrt -> Retorna a raiz quadrada de um número especificado.
            // Math.Pow -> Retorna um número especificado elevado à potência especificada.
            return (double)Math.Sqrt(Math.Pow((p._x - _x), 2) + Math.Pow((p._y - _y), 2));
        }

        /*
        //Sem usar propriedades
        private int x;
        private int y;

        public Ponto()
        {
            x = 0;
            y = 0;
        }
        public Ponto(int x, int y)
        {
            if (!setX(x))
                x = 0;
            if (!setY(y))
                y = 0;

        }
        public Ponto(Ponto p)
        {
            x = p.x;
            y = p.y;
        }
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        public bool setX(int x)
        {
            this.x = x;
            return true;
        }
        public bool setY(int y)
        {
            this.y = y;
            return true;
        }
        public string toString()
        {
            return "(" + x.ToString() + "," + y.ToString() + ")";
        }
        public double distEntre2Pontos(Ponto p)
        {
            // Math.Sqrt -> Retorna a raiz quadrada de um número especificado.
            // Math.Pow -> Retorna um número especificado elevado à potência especificada.
            return (double)Math.Sqrt(Math.Pow((p.x - x), 2) + Math.Pow((p.y - y), 2));
        }
        */
    }
}