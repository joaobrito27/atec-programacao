using System;
using System.Collections.Generic;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_Trabalho_6
{
    class Program
    {

        public static class Globals
        {
            public static int nhabs = 0;
            public static int ncomps = 0;
            public static int nexps = 0;
        }

        public static void InserirCandidatos(List<Candidato> candidatos)
        {
            Candidato c = new Candidato();
            int ano, mes, dia;
            Console.Clear();
            Console.WriteLine("Insira o nome: ");
            c.Nome = Console.ReadLine();
            Console.WriteLine("Insira a localidade: ");
            c.Localidade = Console.ReadLine();
            Console.WriteLine("Insira a Data de nascimento: ");
            Console.WriteLine("Digite a data (DD/MM/AAAA):");
            Console.WriteLine("Insira o dia: ");
            dia = ((int)Ler((typeof(int))));
            Console.SetCursorPosition(0, Console.CursorTop - 2);
            ClearCurrentConsoleLine();
            Console.WriteLine("Insira o mês: ");
            Console.Write(dia + "/");
            mes = ((int)Ler((typeof(int))));
            Console.SetCursorPosition(0, Console.CursorTop - 2);
            ClearCurrentConsoleLine();
            Console.WriteLine("Insira o ano: ");
            Console.Write(dia + "/" + mes + "/");
            ano = ((int)Ler((typeof(int))));
            c.DataNasc = new Data(dia, mes, ano);
            Console.WriteLine("Insira o Sexo(M/F/N):");
            c.Sexo = Console.ReadLine();
            Console.WriteLine("\nInsira o email: ");
            c.Email = Console.ReadLine();
            Console.WriteLine("Insira o telefone");
            c.Telefone = ((int)Ler((typeof(int))));
            int n;
            Console.WriteLine("Quantas habilitações? (máximo de três):");
            do
            {
                n = ((int)Ler((typeof(int))));
                if (n < 0 || n > 3)
                    Console.WriteLine("Erro (>0 e <3)");
            } while (n < 0 || n > 3);
            for (int i = 0; i < n; i++)
            {

                Globals.nhabs++;
                Console.WriteLine("Habilitação nrº" + (i + 1) + ":");
                c.Habilitacao[i] = Console.ReadLine();
            }
            Console.WriteLine("Quantas Experiencias? (máximo de cinco):");
            do
            {
                n = ((int)Ler((typeof(int))));
                if (n < 0 || n > 5)
                    Console.WriteLine("Erro (>0 e <5)");
            } while (n < 0 || n > 5);
            for (int i = 0; i < n; i++)
            {
                Globals.nexps++;
                Console.WriteLine("Experiencia nrº" + (i + 1) + ":");
                c.Experiencia[i] = Console.ReadLine();
            }
            Console.WriteLine("Quantas Competencias? (máximo de cinco):");
            do
            {
                Globals.ncomps++;
                n = ((int)Ler((typeof(int))));
                if (n < 0 || n > 5)
                    Console.WriteLine("Erro (>0 e <5)");
            } while (n < 0 || n > 5);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Competencia nrº" + (i + 1) + ":");
                c.Competencia[i] = Console.ReadLine();
            }
            candidatos.Add(c);
            Guardar(candidatos);
        }


        public static List<Candidato> Carregar(List<Candidato> candidatos)
        {
            if (!File.Exists("Candidatos.txt"))
                File.Create("Candidatos.txt").Close();
            StreamReader rd = new StreamReader("Candidatos.txt");
            while (!rd.EndOfStream)
            {
                string linha = rd.ReadLine();
                linha = linha.Replace('/', ';');
                string[] atributos = linha.Split(';');
                if (atributos.Length > 0)
                {
                    Candidato c = new Candidato(
                                            atributos[0],
                                            atributos[1],
                                            int.Parse(atributos[2]),
                                            int.Parse(atributos[3]),
                                            int.Parse(atributos[4]),
                                            (atributos[5]),
                                            atributos[6],
                                            int.Parse(atributos[7])
                                            );
                    int lenghts = 8;
                    for (int i = 0; i < int.Parse(atributos[lenghts]); i++)
                        c.Habilitacao[i] = atributos[lenghts + 1 + i];
                    lenghts += int.Parse(atributos[lenghts]) + 1;
                    for (int i = 0; i < int.Parse(atributos[lenghts]); i++)
                        c.Experiencia[i] = atributos[lenghts + 1 + i];
                    lenghts += int.Parse(atributos[lenghts]) + 1;
                    for (int i = 0; i < int.Parse(atributos[lenghts]); i++)
                        c.Competencia[i] = atributos[lenghts + 1 + i];
                    candidatos.Add(c);
                }
            }
            return candidatos;
        }

        public static void Guardar(List<Candidato> candidatos)
        {
            StreamWriter wd = new StreamWriter(@"Candidatos.txt");

            foreach (Candidato obj in candidatos)
            {
                string linha = obj.Nome + ";"
                             + obj.Localidade + ";"
                             + obj.DataNasc + ";"
                             + obj.Sexo + ";"
                             + obj.Email + ";"
                             + obj.Telefone + ";"
                             ;
                string[] holder = obj.Habilitacao;
                for (int i = 0; i <= Globals.nhabs; i++)
                    linha += holder[i] + ";";
                holder = obj.Experiencia;
                for (int i = 0; i <= Globals.nexps; i++)
                    linha += holder[i] + ";";
                holder = obj.Competencia;
                for (int i = 0; i <= Globals.ncomps; i++)
                    linha += holder[i] + ";";
                wd.WriteLine(linha);
            }
        }


        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

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


        public static void OpcInvalida()
        {
            Console.WriteLine("Opção inválida.");
            Console.ReadKey();
        }

        public static void Fechar()
        {
            Console.Clear();
            Console.WriteLine("Até à próxima! ;)");
            System.Threading.Thread.Sleep(1000);
            Environment.Exit(0);
        }

        static void Main(string[] args)
        {

            List<Candidato> candidatos = new List<Candidato>();
            Candidato c;
            c = new Candidato();

            int opc;
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Inserir Candidato");
                Console.WriteLine("2 - Mostrar Candidatos");
                Console.WriteLine("\n\n0 - Sair");
                opc = ((int)Ler((typeof(int))));
                switch (opc)
                {
                    case 0:
                        Fechar();
                        break;
                    case 1:
                        InserirCandidatos(candidatos);
                        break;
                    case 2:
                        Console.Clear();
                        foreach (Candidato can in candidatos)
                            Console.WriteLine(can.ToString());
                        Console.ReadKey();
                        break;
                    default:
                        OpcInvalida();
                        break;

                }
            } while (opc != 0);
        }
    }

}
