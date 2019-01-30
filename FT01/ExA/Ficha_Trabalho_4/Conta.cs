using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_Trabalho_4
{
    class Conta
    {
        private string _titular;
        private int _numero, _estado;
        private double _saldo;

        public Conta()
        {
            _titular = "sem nome";
            _numero = 0;
            _saldo = 0;
            _estado = -1;
        }

        public Conta(string t, int n, double s, int e)
        {
            _titular = t;
            _numero = n;
            _saldo = s;
            _estado = e;
        }

        public Conta(Conta c)
        {
            _titular = c._titular;
            _numero = c._numero;
            _saldo = c._saldo;
            _estado = c._estado;
        }

        public string Titular
        {
            get { return _titular; }
            set { _titular = value; }
        }

        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        public double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        public int Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public string toString()
        {
            return "\nTitular: " + Titular
              + "\n\tNúmero: " + Numero
              + "\n\tSaldo: " + Saldo
              + "\n\tEstado: " + Estado;
        }

        public int levantar(int valor)
        {
            //verificar se o valor a levantar é positivo e se é menor que o saldo que a conta tem
            if (valor > 0 && valor <= _saldo)
            {
               _saldo -= valor;
                return 0; //foi possivel levantar
            }
            return -1; //nao foi possivel levantar
        } 

        public int depositar(int valor)
        {
            //verifica se o valor a depositar é positivo
            if (valor > 0)
            {
                _saldo += valor;
                return 0; //foi possivel depositar
            }
            return -1; //foi possivel levantar
        }

        public void AlterarEstado()
        {
            if (_estado == 1)
            {
                _estado = -1;
            }
            else
            {
                _estado = 1;
            }
        }

        public double Credito()
        {
            if (_saldo >= 5000)
                return _saldo * 0.5;
            else if (_saldo >= 1000)
                return _saldo * 0.3;
            else if (_saldo >= 500)
                return _saldo * 0.1;
            else return 0;
        }
    }
}
