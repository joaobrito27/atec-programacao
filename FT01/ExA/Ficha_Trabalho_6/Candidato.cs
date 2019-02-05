using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_Trabalho_6
{
    class Candidato
    {
        public string Nome { get; set; }
        public string Localidade { get; set; }
        public string Sexo { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }
        public Data DataNasc { get; set; }
        public string[] Habilitacao { get; set; }
        public string[] Experiencia { get; set; }
        public string[] Competencia { get; set; }

        public Candidato()
        {
            Nome = "";
            Localidade = "";
            DataNasc = new Data();
            Sexo = "Male";
            Email = "nenhum";
            Telefone = 0;
            Habilitacao = new string[4];
            Experiencia = new string[6];
            Competencia = new string[6];
        }
        public Candidato(string n, string l, int d, int m, int a, string s, string e, int t)
        {
            Nome = n;
            Localidade = l;
            DataNasc = new Data(d, m, a);
            Sexo = s;
            Email = e;
            Telefone = t;
            Habilitacao = new string[4];
            Experiencia = new string[6];
            Competencia = new string[6];

        }
        public Candidato(Candidato c)
        {
            Nome = c.Nome;
            Localidade = c.Localidade;
            DataNasc = c.DataNasc;
            Sexo = c.Sexo;
            Email = c.Email;
            Telefone = c.Telefone;
            Habilitacao = c.Habilitacao;
            Experiencia = c.Experiencia;
            Competencia = c.Competencia;
        }


        public override string ToString()
        {
            string r = "Nome: " + Nome
                     + "\nLocalidade: " + Localidade
                     + "\nData de nascimento: " + DataNasc.ToString()
                     + "\nSexo: " + Sexo
                     + "\nEmail: " + Email
                     + "\nTelefone: " + Telefone.ToString()
                     ;
            r += "\nHabilitações: ";
            for (int i = 0; i <= 3; i++)
                r += "\n" + Habilitacao[i];
            r += "\nExperiencias: ";
            for (int i = 0; i <= 5; i++)
                r += "\n" + Experiencia[i];
            r += "\nCompetencias: ";
            for (int i = 0; i <= 5; i++)
                r += "\n" + Competencia[i];
            return r;
        }
    }
}
