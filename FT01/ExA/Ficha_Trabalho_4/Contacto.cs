using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_Trabalho_4
{
    class Contacto
    {
        private int _id, _telef;
        private string _nome, _email;
        private Data _dataNasc;

        public Contacto()
        {
            _id = 0;
            _nome = "Sem Nome";
            _telef = 0;
            _email = "";
        }

        public Contacto(int id, int tel, string nome, string email, int dia, int mes, int ano)
        {
            _id = id;
            _telef = tel;
            _nome = nome;
            _email = email;
            _dataNasc = new Data(dia,mes,ano);
        }

        public Contacto(Contacto c)
        {
            _id = c._id;
            _telef = c._telef;
            _nome = c._nome;
            _email = c._email;
            _dataNasc = new Data(c._dataNasc);
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int Telef
        {
            get { return _telef; }
            set { _telef = value; }
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

        public Data DataN
        {
            get { return _dataNasc; } 
            set { _dataNasc = value; }
        }

        public string toString()
        {
            return "\nNome: " + Nome
              + "\n\tID: " + Id
              + "\n\tEmail: " + Email
              + "\n\tTelefone: " + Telef
              + "\n\tData de nascimento: " + DataN.toString();
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


        /* SEM PROPRIEDADES
         
         class Contacto
    {
        //private

        private int id;
        private int telefone;
        private string nome;
        private string email;
        private Data dataNasc;

        //public

        //construtores
        public Contacto()
        {
            id = 0;
            telefone = 0;
            nome = "sem nome";
            email = "sem email";
            dataNasc = new Data();
        }
        public Contacto(int i,int telef,string n,string e,int d,int m,int a)
        {
            if (!SetId(i))
                id = 0;
            if (!SetTelefone(telef))
                telefone = 0;
            if (!SetNome(n))
                nome = "erro";
            if (!SetEmail(e))
                email = "erro";
            dataNasc = new Data(d, m, a);
        }
        public Contacto(Contacto c)
        {
            id = c.id;
            telefone = c.telefone;
            nome = c.nome;
            email = c.email;
            dataNasc = new Data(c.dataNasc);
        }
        


        //Sets & Gets
        public bool SetId(int i)
        {
            if(i>0)
            {
                id = i;
                return true;
            }
            return false;
        }
        public int GetId()
        {
            return id;
        }
        public bool SetTelefone(int telef)
        {
            if (telef > 100000000 && telef < 999999999) 
            {
                telefone = telef;
                return true;
            }
            return false;
        }
        public int GetTelefone()
        {
            return telefone;
        }
        public bool SetNome(string n)
        {
            if(!string.IsNullOrEmpty(n))
            {
                nome = n;
                return true;
            }
            return false;
        }
        public string GetNome()
        {
            return nome;
        }
        public bool SetEmail(string e)
        {
            if(!string.IsNullOrEmpty(e)&&e.IndexOf('@')!=-1)
            {
                email = e;
                return true;
            }
            return false;
        }
        public string GetEmail()
        {
            return email;
        }
        public bool SetData(int d,int m,int a)
        {
            return (dataNasc.setAno(a) &&
                    dataNasc.setMes(m) &&
                    dataNasc.setDia(d));
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

        //To String
        public string toString()
        {
            return "ID: " + id.ToString()
                 + "\nNome: " + nome
                 + "\nTelefone: " + telefone.ToString()
                 + "\nEmail: " + email
                 + "\nData de nascimento: " +dataNasc.toString()
                 ;
        }

        //Funções
        public int calcularidade()
        {
            //calcula a idade
            int idade = DateTime.Now.Year - dataNasc.setAno; 

            //verifica se já chegou ao dia de aniversário definido na Data
            if ((dataNasc.setMes > DateTime.Now.Month) || (dataNasc.setMes == DateTime.Now.Month && dataNasc.setDia > DateTime.Now.Day)) 
                idade--;

            return idade;
        }
    }
         
         */

    }

}
