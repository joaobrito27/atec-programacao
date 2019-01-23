using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_Trabalho_4
{
    class Data
    {

        private int _dia, _mes, _ano;

        public Data()
        {
            _dia = 1;
            _mes = 1;
            _ano = 2000;
        }

        public Data(int d, int m, int a)
        {
            _dia = d;
            _mes = m;
            _ano = a;
        }

        public Data(Data d)
        {
            _dia = d._dia;
            _mes = d._mes;
            _ano = d._ano;
        }

        public int Dia
        {
            get { return _dia; }
            set {
                if (_dia <= 0 || _dia > 31)
                {
                    _dia = 1;  //Dia invalido
                }
                if (_mes < 8 && _mes != 2)
                {
                    if (_mes % 2 == 0 && _dia <= 30)
                    {
                        _dia = value;
                    }
                    else
                    {
                        if (_mes % 2 == 1 && _dia <= 31)
                        {
                            _dia = value;
                        }
                        else
                        {
                            _dia = 1;//Dia invalido devido ao mes
                        }
                    }
                }
                else
                {
                    if (_mes >= 8 && _mes != 2)
                    {
                        if (_mes % 2 == 1 && _dia <= 30)
                        {
                            _dia = value;
                        }
                        else
                        {
                            if (_mes % 2 == 0 && _dia <= 31)
                            {
                                _dia = value;
                            }
                            else
                            {
                                _dia = 1;//Dia invalido devido ao mes
                            }
                        }
                    }
                }
                if (_mes == 2)
                {
                    if (_ano % 4 == 0 && _dia <= 29)
                    {
                        _dia = value;
                    }
                    else
                    {
                        if (_ano % 4 == 1 && _dia <= 28)
                        {
                            _dia = value;
                        }
                        else
                        {
                            _dia = 1;//Dia invalido devido ao ano e mes
                        }
                    }
                }
                _dia = value;
            }
        }

        public int Ano
        {
            get { return _ano; }
            set {
                if (_ano < 1900)
                {
                    _ano = 2000; //Ano invalido
                }
                if (_mes == 2 && _dia == 29 && _ano % 4 != 0)
                {
                    _ano = 2000; // Ano invalido devido a ser dia 29/2 num ano nao bissexto
                }
                _ano = value;
            }
        }

        public int Mes
        {
            get { return _mes; }
            set
            {
                if (_mes <= 0 || _mes > 12)
                {
                    _mes = 1; //Mes invalido
                }
                if (_mes < 8 && _mes != 2)
                {
                    if (_mes % 2 == 0 && _dia <= 30)
                    {
                        _mes = value;
                    }
                    else
                    {
                        if (_mes % 2 == 1 && _dia <= 31)
                        {
                            _mes = value;
                        }
                        else
                        {
                            _mes = 1;//Mes invalido devido ao dia
                        }
                    }
                }
                else
                {
                    if (_mes >= 8 && _mes != 2)
                    {
                        if (_mes % 2 == 1 && _dia <= 30)
                        {
                           _mes = value;
                        }
                        else
                        {
                            if (_mes % 2 == 0 && _dia <= 31)
                            {
                                _mes = value;
                            }
                            else
                            {
                                _mes = 1;//Mes invalido devido ao dia
                            }
                        }
                    }
                }
                if (_mes == 2)
                {
                    if (_ano % 4 == 0 && _dia <= 29)
                    {
                        _mes = value;
                    }
                    else
                    {
                        if (_ano % 4 == 1 && _dia <= 28)
                        {
                            _mes = value;
                        }
                        else
                        {
                            _mes = 1;//Mes invalido devido ao dia e ano
                        }
                    }
                }
                _mes = value;
            }
        }
        
        public string toString()
        {
            return ("Data:" + _dia.ToString() + " / " + _mes.ToString() + " / " + _ano.ToString());
        }

        public int difEntre2anos(Data d)
        {
            return d._ano - _ano;
        }
    }
}
