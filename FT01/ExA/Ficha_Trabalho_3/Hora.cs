using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_Trabalho_3
{
   class Hora
    {
        private int _hora;
        private int _minuto;
        private int _segundo;

        public Hora()
        {
            _hora = 00;
            _minuto = 00;
            _segundo = 00;
        }
        public Hora(int h, int m, int s)
        {
            this._hora = h;
            this._minuto = m;
            this._segundo = s;
        }

        public Hora(Hora h)
        {
            _hora = h._hora;
            _minuto = h._minuto;
            _segundo = h._segundo;
        }

        public int Horas
        {
            get { return _hora; }
            set
            {
                if (_hora > 0 && _hora < 24)
                {
                    _hora = value;
                }
                else
                {
                    _hora = 00;
                }
            }

        }

        public int Minutos
        {
            get { return _minuto; }
            set
            {
                if (_minuto >= 0 && _minuto < 60)
                {
                    _hora = value;
                }
                else
                {
                    _hora = 00;
                }
            }
        }

        public int Segundos
        {
            get { return _segundo; }
            set
            {
                if (_segundo >= 0 && _segundo < 60)
                {
                    _segundo = value;
                }
                else
                {
                    _segundo = 00;
                }
            }
        }

        public string toString()
        {

            return (Horas + " : " + Minutos + " : " + Segundos);

        }

        public int difEntre2Horas(Hora h)
        {

            int segsHora1 = _segundo + (_minuto * 60) + (_hora * 60 * 60); //calcular segundos hora 1
            int segsHora2 = h._segundo + (h._minuto * 60) + (h._hora * 60 * 60); //calcular segundos hora 2


            return (Math.Abs((segsHora1 - segsHora2) / (60 * 60))); //converter em horas

        }
    }
}
