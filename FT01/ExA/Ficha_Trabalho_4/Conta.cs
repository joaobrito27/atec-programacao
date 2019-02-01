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
            return "\nConta:" 
              + "\n\tTitular: " + Titular
              + "\n\tNúmero: " + Numero
              + "\n\tSaldo: " + Saldo + " euros"
              + "\n\tEstado: " + Estado;
        }

        public int levantar(int valor)
        {
            //verificar se o valor a levantar é positivo e se é menor que o saldo que a conta tem
            if (valor > 0 && valor <= _saldo)
            {
                Console.WriteLine("Levantamento efetuado com sucesso!");
                _saldo -= valor;
                return 0; //foi possivel levantar
            }
            Console.WriteLine("ERRO! Não foi levantamento qualquer valor!");
            return -1; //nao foi possivel levantar
        }
        

        public int depositar(int valor)
        {
            //verifica se o valor a depositar é positivo
            if (valor > 0)
            {
                _saldo += valor;
                Console.WriteLine("\nValor depositado com sucesso!");
                return 0; //foi possivel depositar
            }
            Console.WriteLine("\nERRO! Valor não depositado!");
            return -1; //foi possivel levantar
        }

        public void AlterarEstado()
        {
            if (_estado == 1)
            {
                Console.WriteLine("\nEstado da Conta - Ativa");
                _estado = -1;
            }
            else
            {
                Console.WriteLine("\nEstado da Conta - Inativa");
                _estado = 1;
            }
        }

        public double Credito()
        {
            if (_saldo >= 5000)
            {
                Console.WriteLine("O crédito é 50% do valor do saldo.");
                return _saldo * 0.5;
            }
            else if (_saldo >= 1000)
            {
                Console.WriteLine("O crédito é 30% do valor do saldo.");
                return _saldo * 0.3;
            }

            else if (_saldo >= 500)
            {
                Console.WriteLine("O crédito é 10% do valor do saldo.");
                return _saldo * 0.1;
            }
            else
            {
                Console.WriteLine("O crédito é 0% do valor do saldo.");
                return 0;
            }
        }
    }

    /* SEM USAR PROPRIEDADES
      
    class Conta
    {
        //private
        private string titular;
        private int numero;
        private double saldo;
        private int estado;

        //Construtores
        public Conta()
        {
            titular = "sem nome";
            numero = 0;
            saldo = 0;
            estado = -1;
        }
        public Conta(string t,int n,double s,bool e)
        {
            if (!SetTitular(t))
                titular = "erro";
            if (!SetNumero(n))
                n = 0;
            saldo = 0;
            Depositar(s);
            estado = e;
        }
        public Conta(Conta c)
        {
            titular = c.titular;
            numero = c.numero;
            saldo = c.saldo;
            estado = c.estado;
        }


        //Sets & Gets
        public bool SetTitular(string t)
        {
            if(!string.IsNullOrEmpty(t))
            {
                titular = t;
                return true;
            }
            return false;
        }
        public string GetTitular()
        {
            return titular;
        }
        public bool SetNumero(int n)
        {
            if(n>0)
            {
                numero = n;
                return true;
            }
            return false;
        }
        public int GetNumero()
        {
            return numero;
        }
        public double GetSaldo()
        {
            return saldo;
        }
        public int GetEstado()
        {
            return estado;
        }

        //To string
        public string toString()
        {
            return "Titular: " + titular
                 + "\nNumero: " + numero.ToString()
                 + "\nSaldo: " + saldo.ToString("0.00") + " Euros"
                 + "\nEstado da conta: " + estado.ToString()
                 ;
        }

        //Outras funções
        public bool Levantar(double valor)
        {
            //verificar se o valor a levantar é positivo e se é menor que o saldo que a conta tem
            if (valor > 0 && valor <= saldo)
            {
                Console.WriteLine("Levantamento efetuado com sucesso!");
                saldo -= valor;
                return 0; //foi possivel levantar
            }
            Console.WriteLine("ERRO! Não foi levantamento qualquer valor!");
            return -1; //nao foi possivel levantar
        }
        public bool Depositar(double valor)
        {
            /verifica se o valor a depositar é positivo
            if (valor > 0)
            {
                saldo += valor;
                Console.WriteLine("\nValor depositado com sucesso!");
                return 0; //foi possivel depositar
            }
            Console.WriteLine("\nERRO! Valor não depositado!");
            return -1; //foi possivel levantar
        }
        public void AlterarEstado()
        {
            if (estado == 1)
            {
                Console.WriteLine("\nEstado da Conta - Ativa");
                estado = -1;
            }
            else
            {
                Console.WriteLine("\nEstado da Conta - Inativa");
                estado = 1;
            }
        }
        public double Credito()
        {
           if (saldo >= 5000)
            {
                Console.WriteLine("O crédito é 50% do valor do saldo.");
                return saldo * 0.5;
            }
            else if (saldo >= 1000)
            {
                Console.WriteLine("O crédito é 30% do valor do saldo.");
                return saldo * 0.3;
            }

            else if (saldo >= 500)
            {
                Console.WriteLine("O crédito é 10% do valor do saldo.");
                return saldo * 0.1;
            }
            else
            {
                Console.WriteLine("O crédito é 0% do valor do saldo.");
                return 0;
            }
        }
    } 

     */
}
