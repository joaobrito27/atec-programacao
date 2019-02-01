using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_Trabalho_5
{
    class Operario : Funcionario
    {
        private string _departamento;

        public Operario() : base()
        {
            _departamento = "nenhum";
        }

        public Operario(int id, string n, string e, double v, int d, int m, int a, string derp) : base(id, n, e, v, d, m, a)
        {
                _departamento = "Erro";
        }

        public Operario(Operario o) : base(o.Id, o.Nome, o.Email, o.ValorH, o.DataNasc.Dia, o.DataNasc.Mes, o.DataNasc.Ano)
        {
            _departamento = o._departamento;
        }

        public string Departamento
        {
            get { return _departamento; }
            set { _departamento = value; }
        }

        public string toString()
        {
            return "Operario Nº" + Id + ":"
                 + "\nNome:" + Nome
                 + "\nEmail:" + Email
                 + "\nValor Hora:" + ValorH
                 + "\nDepartamento:" + Departamento
                 + "\nData Nascimento:" + DataNasc.toString() + " Idade: " + calcularidade().ToString()
                 ;
        }
    }

    /* SEM PROPRIEDADES
     
    class Operario:Funcionario
    {
        private string departamento;

        public Operario() : base()
        {
            departamento = "nenhum";
        }
        public Operario(int id, string n, string e, double v, int d, int m, int a, string derp) : base(id, n, e, v, d, m, a)
        {
            if (!setDepartamento(derp))
                departamento = "Erro";
        }
        public Operario(Operario o) : base(o.Id, o.Nome, o.Email, o.ValorH, o.DataNasc.Dia, o.DataNasc.Mes, o.DataNasc.Ano)
        {
            departamento = o.departamento;
        }

        public string getDepartamento()
        {
            return departamento;
        }
        public bool setDepartamento(string d)
        {
            if(!string.IsNullOrEmpty(d))
            {
                departamento = d;
                return true;
            }
            return false;
        }
        public string toString()
        {
            return "Operario Nº" + Id + ":"
                 + "\nNome:" + Nome
                 + "\nEmail:" + Email
                 + "\nValor Hora:" + ValorH
                 + "\nDepartamento:" + Departamento
                 + "\nData Nascimento:" + DataNasc.toString() + " Idade: " + calcularidade().ToString()
                 ;
        }
    }

    */
}
