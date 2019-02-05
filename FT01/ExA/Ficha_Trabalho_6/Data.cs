using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_Trabalho_6
{
    class Data
    {

        protected int _dia, _mes, _ano;

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
            return ("Data: " + Dia.ToString() + " / " + Mes.ToString() + " / " + Ano.ToString());
        }

        public int difEntre2anos(Data d)
        {
            return d._ano - _ano;
        }

        /*
         
        class Data
    {
        private int dia;
        private int mes;
        private int ano;
        //private Hora hora;
        //private string diasem;

        public Data()
        {
            dia = 1;
            mes = 1;
            ano = 2000;
      
        }
        public Data(int dia,int mes,int ano)
        {
            if (!setAno(ano))
                ano = 2000;
            if (!setMes(mes))
                mes = 1;
            if (!setDia(dia))
                dia = 1;
          
        }
 
    public Data(Data d)
    {
        dia = d.dia;
        mes = d.mes;
        ano = d.ano;
      
    }
    
    public int getDia()
    {
        return dia;
    }
    public bool setDia(int x)
    {
        if (x <= 0 || x > 31)
        {
            return false; //Dia invalido
        }
        if (mes < 8 && mes != 2)
        {
            if (mes % 2 == 0 && x <= 30)
            {
                dia = x;
            }
            else
            {
                if (mes % 2 == 1 && x <= 31)
                {
                    dia = x;
                }
                else
                {
                    return false;//Dia invalido devido ao mes
                }
            }
        }
        else
        {
            if (mes >= 8 && mes != 2)
            {
                if (mes % 2 == 1 && x <= 30)
                {
                    dia = x;
                }
                else
                {
                    if (mes % 2 == 0 && x <= 31)
                    {
                        dia = x;
                    }
                    else
                    {
                        return false;//Dia invalido devido ao mes
                    }
                }
            }
        }
        if (mes == 2)
        {
            if (ano % 4 == 0 && x <= 29)
            {
                dia = x;
            }
            else
            {
                if (ano % 4 == 1 && x <= 28)
                {
                    dia = x;
                }
                else
                {
                    return false;//Dia invalido devido ao ano e mes
                }
            }
        }
        return true;
    }
    public int getMes()
    {
        return mes;
    }
    public bool setMes(int x)
    {
        if (x <= 0 || x > 12)
        {
            return false; //Mes invalido
        }
        if (x < 8 && x != 2)
        {
            if (x % 2 == 0 && dia <= 30)
            {
                mes = x;
            }
            else
            {
                if (x % 2 == 1 && dia <= 31)
                {
                    mes = x;
                }
                else
                {
                    return false;//Mes invalido devido ao dia
                }
            }
        }
        else
        {
            if (x >= 8 && x != 2)
            {
                if (x % 2 == 1 && dia <= 30)
                {
                    mes = x;
                }
                else
                {
                    if (x % 2 == 0 && dia <= 31)
                    {
                        mes = x;
                    }
                    else
                    {
                        return false;//Mes invalido devido ao dia
                    }
                }
            }
        }
        if (x == 2)
        {
            if (ano % 4 == 0 && dia <= 29)
            {
                mes = x;
            }
            else
            {
                if (ano % 4 == 1 && dia <= 28)
                {
                    mes = x;
                }
                else
                {
                    return false;//Mes invalido devido ao dia e ano
                }
            }
        }
        return true;
    }
    public int getAno()
    {
        return ano;
    }
    public bool setAno(int x)
    {
        if (x <= 0)
        {
            return false; //Ano invalido
        }
        if (mes == 2 && dia == 29 && x % 4 != 0)
        {
            return false; // Ano invalido devido a ser dia 29/2 num ano nao bissexto
        }
        ano = x;
        return true;
    }

        public string toString()
        {
            return (dia.ToString() + "/" + mes.ToString() + "/" + ano.ToString());
        }
    public int difEntre2Anos(Data d)
    {
        return d._ano - _ano;
    }
         */
    }
}
