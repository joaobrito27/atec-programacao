using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_Trabalho_5
{   //uma classe abstract não pode instaciar objetos no main.
    //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/abstract-and-sealed-classes-and-class-members

    abstract class Funcionario
    {
        protected int _id;
        protected double _valorHora;
        protected string _nome;
        protected string _email;
        public Data DataNasc { get; set; } //Auto-Propriedade tem de estar public para poder aceder noutro sitio do projeto.
            
        public Funcionario()
        {
            _id = 0;
            _nome = "sem nome";
            _email = "";
            _valorHora = 0;
            DataNasc = new Data();
        }

        public Funcionario(int id, string nome, string email, double valorh, int dia, int mes, int ano)
        {            
            id = 0;            
            _nome = "erro";            
            _email = "email invalido";
            _valorHora = 0;
            DataNasc = new Data(dia, mes, ano);
        }

        public Funcionario(Funcionario f)
        {
            _id = f._id;
            _nome = f._nome;
            _email = f._email;
            _valorHora = f._valorHora;
            DataNasc = f.DataNasc;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public double ValorH
        {
            get { return _valorHora; }
            set { _valorHora = value; }
        }

        /*public Data DataN
        {
            get { return _dataNasc; }
            set { _dataNasc = value; }
        }*/

        public int calcularidade()
        {
            //calcula a idade
            int idade = DateTime.Now.Year - DataNasc.Ano;

            //verifica se já chegou ao dia de aniversário definido na Data
            if ((DataNasc.Mes > DateTime.Now.Month) || (DataNasc.Mes == DateTime.Now.Month && DataNasc.Dia > DateTime.Now.Day))
                idade--;

            return idade;
        }

        public double calcSal(double hora)
        {
            if (hora > 0)
                return hora * _valorHora;
            return -1;
        }
    }

    /*
     abstract class Funcionario
    {
        protected int id;
        protected string nome;
        protected string email;
        protected double valorHora;
        protected Data dataNasc;

        public Funcionario()
        {
            id = 0;
            nome = "sem nome";
            email = "";
            valorHora = 0;
            dataNasc = new Data();
        }

        public Funcionario(int id,string n,string e,double v,int d,int m,int a)
        {
            if (!setId(id))
                id = 0;
            if (!setNome(n))
                nome = "erro";
            if (!setEmail(e))
                email = "email invalido";
            if (!setValorHora(v))
                valorHora = 0;
            dataNasc = new Data(d, m, a);
        }

        public Funcionario(int id, string n, string e, double v, Data d)
        {
            if (!setId(id))
                id = 0;
            if (!setNome(n))
                nome = "erro";
            if (!setEmail(e))
                email = "email invalido";
            if (!setValorHora(v))
                valorHora = 0;
            dataNasc = d;
        }

        public Funcionario(Funcionario f)
        {
            id = f.id;
            nome = f.nome;
            email = f.email;
            valorHora = f.valorHora;
            dataNasc = f.dataNasc;
        }
        
        public int getId()
        {
            return id;
        }

        public bool setId(int x)
        {
            if(x>=0)
            {
                id = x;
                return true;
            }
            return false;
        }

        public string getNome()
        {
            return nome;
        }

        public bool setNome(string n)
        {
            if(!string.IsNullOrEmpty(n))
            {
                nome = n;
                return true;
            }
            return false;
        }

        public string getEmail()
        {
            return email;
        }

        public bool setEmail(string email)
        {
            if(!string.IsNullOrEmpty(email))
            {
                this.email = email;
                return true;
            }
            return false;
        }

        public double getValorHora()
        {
            return valorHora;
        }

        public bool setValorHora(double valor)
        {
            if (valor >= 0)
            {
                valorHora = valor;
                return true;
            }
            return false;
        }

        public Data getDataNascimento()
        {
            return dataNasc;
        }

        public bool setDataNascimento(int dia, int mes, int ano)
        {
            return (dataNasc.setAno(ano) && dataNasc.setMes(mes) && dataNasc.setDia(dia));
        }

        public bool setDataNascimento(Data d)
        {
            return (dataNasc.setAno(d.getAno()) && dataNasc.setMes(d.getMes()) && dataNasc.setDia(d.getDia()));
        }
     
        public int calcularidade()
        {
            //calcula a idade
            int idade = DateTime.Now.Year - _dataNasc.Ano;

            //verifica se já chegou ao dia de aniversário definido na Data
            if ((_dataNasc.Mes > DateTime.Now.Month) || (_dataNasc.Mes == DateTime.Now.Month && _dataNasc.Dia > DateTime.Now.Day))
                idade--;

            return idade;
        }

        public double calcSal(double hora)
        {
            if (hora > 0)
                return hora * _valorHora;
            return -1;
        }
     */
}
