using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_Trabalho_5
{
    class Gerente : Funcionario
    {
        public string _especialidade;
        public int _extensao;

        public Gerente() : base()
        {
            _especialidade = "nenhuma";
            _extensao = 0;
        }

        public Gerente(int id, string nome, string email, double valorh, int dia, int mes, int ano, string esp, int ext) : base(id, nome, email, valorh, dia, mes, ano)
        {
            _especialidade = "Erro";
            _extensao = 0;
        }

        public Gerente(Gerente g) : base(g.Id, g.Nome, g.Email, g.ValorH, g.DataNasc.Dia, g.DataNasc.Mes, g.DataNasc.Ano)
        {
            _especialidade = g._especialidade;
            _extensao = g._extensao;
        }

        public string Especialidade
        {
            get { return _especialidade; }
            set { _especialidade = value; }
        }

        public int Extensao
        {
            get { return _extensao; }
            set { _extensao = value; }
        }

        public string toString()
        {
            return "Gerente Nº" + Id + ":"
                 + "\nNome:" + Nome
                 + "\nEmail:" + Email
                 + "\nValor Hora:" + ValorH.ToString()
                 + "\nEspecialidade:" + Especialidade
                 + "\nExtensao: " + Extensao
                 + "\nData Nascimento:" + DataNasc + " Idade: " + calcularidade().ToString()
                 ;
        }

    }

    /* SEM PROPRIEDADES
     
     class Gerente : Funcionario
    {
        private string especialidade;
        private int extensao;

        public Gerente():base()
        {
            especialidade = "nenhuma";
            extensao = 0;
        }
        public Gerente(int id, string n, string e, double v, int d, int m, int a,string esp,int ext) : base(id, n, e, v, d, m, a)
        {
            if (!setEspecialidade(esp))
                especialidade = "Erro";
            if (!setExtensao(ext))
                extensao = 0;
        }
        public Gerente(Gerente g): base(g.id,g.nome,g.email,g.valorHora,g.dataNasc)
        {
            especialidade = g.especialidade;
            extensao = g.extensao;
        }

        public string getEspecialidade()
        {
            return especialidade;
        }
        public bool setEspecialidade(string e)
        {
            if (!string.IsNullOrEmpty(e))
            {
                especialidade = e;
                return true;
            }
            return false;
        }
        public int getExtensao()
        {
            return extensao;
        }
        public bool setExtensao(int e)
        {
            if (e >= 0)
            {
                extensao = e;
                return true;
            }
            return false;
        }
        public string toString()
        {
            return "Gerente Nº" + id.ToString() + ":"
                 + "\nNome:" + nome
                 + "\nEmail:" + email
                 + "\nValor Hora:" + valorHora.ToString()
                 + "\nEspecialidade:" + especialidade
                 + "\nExtensao: " + extensao.ToString()
                 + "\nData Nascimento:"+dataNasc.toString()+" Idade: "+calcularIdade().ToString()
                 ;
        }
        //Calc sal?
    }
     
     */
}
