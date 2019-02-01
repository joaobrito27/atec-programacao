using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_Trabalho_4
{
    class ContactoDois
    {
        //private
        protected int _id;
        protected int _telefone;
        protected string _nome;
        protected string _email;

        public ContactoDois()
        {
            _id = 0;
            _telefone = 0;
            _nome = "sem nome";
            _email = "sem email";
        }

        public ContactoDois(int id, int telef, string nome, string email)
        {
            _id = id;
            _telefone = telef;
            _nome = nome;
            _email = email;
        }

        public ContactoDois(ContactoDois c)
        {
            _id = c._id;
            _telefone = c._telefone;
            _nome = c._nome;
            _email = c._email;
        }

        //Sets & Gets
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int Telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
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

        //To String
        public string toString()
        {
            return "ID: " + Id
                 + "\nNome: " + Nome
                 + "\nTelefone: " + Telefone
                 + "\nEmail: " + Email
                 ;
        }
    }

    /* SEM PROPRIEDADES
     
     class ContactoDois
    {
        //private

        protected int id;
        protected int telefone;
        protected string nome;
        protected string email;

        //public

        //construtores
        public ContactoDois()
        {
            id = 0;
            telefone = 0;
            nome = "sem nome";
            email = "sem email";
        }
        public ContactoDois(int i, int telef, string n, string e)
        {
            if (!SetId(i))
                id = 0;
            if (!SetTelefone(telef))
                telefone = 0;
            if (!SetNome(n))
                nome = "erro";
            if (!SetEmail(e))
                email = "erro";
        }
        public ContactoDois(ContactoDois c)
        {
            id = c.id;
            telefone = c.telefone;
            nome = c.nome;
            email = c.email;
        }



        //Sets & Gets
        public bool SetId(int i)
        {
            if (i > 0)
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
            if (!string.IsNullOrEmpty(n))
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
            if (!string.IsNullOrEmpty(e) && e.IndexOf('@') != -1)
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

        //To String
        public string toString()
        {
            return "ID: " + id.ToString()
                 + "\nNome: " + nome
                 + "\nTelefone: " + telefone.ToString()
                 + "\nEmail: " + email
                 ;
        }

        //Funções
    }

     */
}
