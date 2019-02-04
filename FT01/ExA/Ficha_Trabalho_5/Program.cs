using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_Trabalho_5
{
    class Program
    {
        //Verificar inserção de dados pelo utilizador
        public static object Ler(Type e)
        {
            if (e == typeof(string))
            {
                return Console.ReadLine();
            }
            else if (e == typeof(int))
            {
                int vint = 0;
                while (!int.TryParse(Console.ReadLine(), out vint))
                    Console.WriteLine("Erro, deve introduzir um valor inteiro.");
                return vint;
            }
            else if (e == typeof(double))
            {
                double vdouble = 0;
                while (!double.TryParse(Console.ReadLine(), out vdouble))
                    Console.WriteLine("Erro, deve introduzir um valor double.");
                return vdouble;
            }
            return "Erro.";
        }
        
        //Inserir Gerentes
        public static List<Gerente> CarregarGerentes(List<Gerente> gerentes)
        {
            StreamReader rdgerentes = new StreamReader(@"Gerentes.txt");
            while (!rdgerentes.EndOfStream)
            {
                string linha = rdgerentes.ReadLine();
                linha = linha.Replace('/', ';');
                string[] atributos = linha.Split(';');
                if (atributos.Length == 9)
                {
                    gerentes.Add(new Gerente(
                                             int.Parse(atributos[0]),
                                             atributos[1],
                                             atributos[2],
                                             double.Parse(atributos[3]),
                                             int.Parse(atributos[4]),
                                             int.Parse(atributos[5]),
                                             int.Parse(atributos[6]),
                                             atributos[7],
                                             int.Parse(atributos[8])
                                            ));
                }
            }
            rdgerentes.Close();
            return gerentes;
        }

        //Inserir Operarios
        public static List<Operario> CarregarOperarios(List<Operario> operarios)
        {

            StreamReader rdoperarios = new StreamReader(@"Operarios.txt");
            while (!rdoperarios.EndOfStream)
            {
                string linha = rdoperarios.ReadLine();
                linha = linha.Replace('/', ';');
                string[] atributos = linha.Split(';');
                if (atributos.Length == 8)
                {
                    operarios.Add(new Operario(
                                             int.Parse(atributos[0]),
                                             atributos[1],
                                             atributos[2],
                                             double.Parse(atributos[3]),
                                             int.Parse(atributos[4]),
                                             int.Parse(atributos[5]),
                                             int.Parse(atributos[6]),
                                             atributos[7]
                                            ));
                }
            }
            rdoperarios.Close();

            return operarios;
        }

        //Guardar Gerentes
        public static void GuardarGerentes(List<Gerente> gerentes)
        {

            StreamWriter wdgerentes = new StreamWriter(@"Gerentes.txt");

            foreach (Gerente obj in gerentes)
            {

                string linha = obj.Id.ToString() + ";"
                                + obj.Nome + ";"
                                + obj.Email + ";"
                                + obj.ValorH.ToString() + ";"
                                + obj.DataNasc.ToString() + ";"
                                + obj._especialidade + ";"
                                + obj._extensao.ToString()
                                ;
                wdgerentes.WriteLine(linha);

            }
            wdgerentes.Close();

        }
        static void Main(string[] args)
        {

        }
    }
}
