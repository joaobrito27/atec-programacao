using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_Trabalho_4
{
    class Pessoa : ContactoDois
    {
        //privado
        private Data _dataNasc;

        public Pessoa() : base()
        {
            _dataNasc = new Data();
        }

        public Pessoa(int id, int telef, string nome, string email, int dia, int mes, int ano) : base(id, telef, nome, email)
        {
            _dataNasc = new Data(dia, mes, ano);
        }

        public Pessoa(Pessoa p) : base(p._id, p._telefone, p._nome, p._email)
        {
            _dataNasc = new Data(p._dataNasc);
        }

        //Sets & Gets
        public Data Datanasc
        {
            get { return _dataNasc; }
            set { _dataNasc = value; }
        }

        public string toString()
        {
            return "ID: " + Id
                 + "\nNome: " + Nome
                 + "\nTelefone: " + Telefone
                 + "\nEmail: " + Email
                 + "\nData de nascimento: " + Datanasc.toString();
                 ;
        }

        //Funções
        public int calcularidade()
        {
            //calcula a idade
            int idade = DateTime.Now.Year - _dataNasc.Ano;

            //verifica se já chegou ao dia de aniversário definido na Data
            if ((_dataNasc.Mes > DateTime.Now.Month) || (_dataNasc.Mes == DateTime.Now.Month && _dataNasc.Dia > DateTime.Now.Day))
                idade--;

            return idade;
        }
    }

    /* SEM PROPRIEDADES
     
     class Pessoa : ContactoDois
    {
        //privado
        private Data dataNasc;


        //publico

        //Construtores
        public Pessoa():base()
        {
            dataNasc = new Data();
        }
        public Pessoa(int id, int telef, string nome, string email, int dia, int mes, int ano) : base(id, telef, nome, email)
        {
            dataNasc = new Data(dia, mes, ano);
        }
        public Pessoa(Pessoa p):base(p.id,p.telefone,p.nome,p.email)
        {
            dataNasc = new Data(p.dataNasc);
        }

        //Sets & Gets
        public bool SetData(int dia, int mes, int ano)
        {
            return (dataNasc.setAno(ano) &&
                    dataNasc.setMes(mes) &&
                    dataNasc.setDia(dia));
        }
        public bool SetData(Data d)
        {
            return (dataNasc.setAno(d.getAno()) &&
                    dataNasc.setMes(d.getMes()) &&
                    dataNasc.setDia(d.getDia()));
        }
        public Data GetData()
        {
            return dataNasc;
        }

        //to String
        public string toString()
        {
            return "ID: " + id.ToString()
                 + "\nNome: " + nome
                 + "\nTelefone: " + telefone.ToString()
                 + "\nEmail: " + email
                 + "\nData de nascimento: " + dataNasc.toString()
                 ;
        }

        //Funções

        public int calcularidade()
        {
            //calcula a idade
            int idade = DateTime.Now.Year - _dataNasc.Ano;

            //verifica se já chegou ao dia de aniversário definido na Data
            if ((_dataNasc.Mes > DateTime.Now.Month) || (_dataNasc.Mes == DateTime.Now.Month && _dataNasc.Dia > DateTime.Now.Day))
                idade--;

            return idade;
        }
    }
     
     */
}
