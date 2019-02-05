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
            while (!rdgerentes.EndOfStream) //Enquanto houver conteudo no ficheiro
            {
                string linha = rdgerentes.ReadLine();
                linha = linha.Replace('/', ';');
                string[] atributos = linha.Split(';'); //Escreve o que está na string 'linha' separado por um ;
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
            while (!rdoperarios.EndOfStream) //Enquanto houver conteudo no ficheiro
            {
                string linha = rdoperarios.ReadLine();
                linha = linha.Replace('/', ';');
                string[] atributos = linha.Split(';'); //Escreve o que está na string 'linha' separado por um ;
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
                                + obj.Especialidade + ";"
                                + obj.Extensao.ToString()
                                ;
                wdgerentes.WriteLine(linha);

            }
            wdgerentes.Close();

        }

        //Guardar Operarios
        public static void GuardarOperarios(List<Operario> operarios)
        {
            StreamWriter wdoperarios = new StreamWriter(@"Operarios.txt");
            foreach (Operario obj in operarios)
            {
                string linha = obj.Id.ToString() + ";"
                             + obj.Nome + ";"
                             + obj.Email + ";"
                             + obj.ValorH.ToString() + ";"
                             + obj.DataNasc.ToString() + ";"
                             + obj.Departamento
                             ;
                wdoperarios.WriteLine(linha);
            }
            wdoperarios.Close();
        }

        public static void OpcInvalida()
        {
            Console.WriteLine("Opção inválida.");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            //ArrayList gerentes = new ArrayList();
            List<Gerente> gerentes = new List<Gerente>();

            //ArrayList operarios = new ArrayList();
            List<Operario> operarios = new List<Operario>();

            gerentes = CarregarGerentes(gerentes);
            operarios = CarregarOperarios(operarios);

            int opc = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("<---------------------------FT04------------------------->");
                Console.WriteLine("|---------------------------EXE1-------------------------|");
                Console.WriteLine("| [1] -               Inserir Gerente                    |");
                Console.WriteLine("| [2] -               Inserir Operário                   |");
                Console.WriteLine("| [3] -              Visualizar Gerentes                 |");
                Console.WriteLine("| [4] -             Visualizar Operários                 |");
                Console.WriteLine("| [5] -            Visualizar Funcionários               |");
                Console.WriteLine("| [6] -             Sair do Programa                     |");
                Console.WriteLine("<-------------------------------------------------------->");
                Console.Write("Digite a opção pretendida: ");
                opc = ((int)Ler((typeof(int))));

                switch (opc)
                {
                    case 1:
                        InserirGerente(gerentes);
                        break;
                    case 2:
                        InserirOperario(operarios);
                        break;
                    case 3:
                        gerentes = MenuGerentes(gerentes);
                        break;
                    case 4:
                        operarios = MenuOperarios(operarios);
                        break;
                    case 5:
                        VisualizarFuncionarios(gerentes, operarios);
                        break;
                    case 6:
                        Fechar();
                        break;
                    default:
                        OpcInvalida();
                        break;
                }
            } while (opc != 6);
            GuardarGerentes(gerentes);
            GuardarOperarios(operarios);
        }

        public static void Fechar()
        {
            Console.Clear();
            Console.WriteLine("Fim do Programa!");
            System.Threading.Thread.Sleep(1000);
            Environment.Exit(0);
        }

        public static void VisualizarFuncionarios(List<Gerente> gerentes, List<Operario> operarios)
        {
            
            Console.WriteLine("\nGerentes:\n");
            foreach (Gerente obj in gerentes) //Procura em cada obj dentro da lista gerentes e mostra cada um
            {
                Console.WriteLine("\n" + obj.toString());
            }
            Console.WriteLine("\nOperarios:\n"); //Procura em cada obj dentro da lista operarios e mostra cada um
            foreach (Operario obj in operarios)
            {
                Console.WriteLine("\n" + obj.toString());
            }
            Console.WriteLine("\n\nClique numa tecla para voltar ao menu...");
            Console.ReadKey();
        }

        // Adicionar objectos do tipo Gerente à lista Gerentes
        public static void InserirGerente(List<Gerente> gerentes) 
        {
            bool flag = false;
            do
            {
                try
                {
                    int ano, dia, mes;
                    Gerente ger;
                    ger = new Gerente();
                    Console.WriteLine("Digite o ID:");
                    ger.Id = ((int)Ler((typeof(int))));
                    Console.WriteLine("Digite o Nome:");
                    ger.Nome = (Console.ReadLine());
                    Console.WriteLine("Digite o E-mail:");
                    ger.Email = (Console.ReadLine());
                    Console.WriteLine("Digite o Valor Hora:");
                    ger.ValorH = ((double)Ler((typeof(double))));
                    Console.WriteLine("Digite a especialidade:");
                    ger.Especialidade = (Console.ReadLine());
                    Console.WriteLine("Digite a extensao:");
                    ger.Extensao = ((int)Ler((typeof(int))));
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
                    ger.DataNasc = new Data(dia, mes, ano); //DEBUG
                    gerentes.Add(ger);
                    GuardarGerentes(gerentes);
                    flag = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Introduziu dados incorrectos num dos campos");
                    flag = false;
                } 
            } while (!flag);
        }

        public static void InserirOperario(List<Operario> operarios)
        {
            int ano, dia, mes;
            Operario op;
            op = new Operario();
            Console.WriteLine("Digite o ID:");
            op.Id = ((int)Ler((typeof(int))));
            Console.WriteLine("Digite o Nome:");
            op.Nome = (Console.ReadLine());
            Console.WriteLine("Digite o E-mail:");
            op.Email = (Console.ReadLine());
            Console.WriteLine("Digite o Valor Hora:");
            op.ValorH = ((double)Ler((typeof(double))));
            Console.WriteLine("Digite o Departamento:");
            op.Departamento = (Console.ReadLine());
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
            op.DataNasc = new Data(dia, mes, ano); //DEBUG
            operarios.Add(op);
            GuardarOperarios(operarios);
                
        }

        public static List<Operario> MenuOperarios(List<Operario> operarios)
        {
            int i;
            int opc = 0;
            do
            {
                i = 0;
                Console.Clear();
                Console.WriteLine("Editar Operario:");
                foreach (Operario obj in operarios) //mostrar todos os operarios
                {
                    Console.WriteLine((i + 1) + " - " + obj.Nome); //mostra apenas o nome de cada um
                    i++;
                }
                Console.WriteLine("\n0 - Voltar ao menu anterior");
                opc = ((int)Ler((typeof(int))));
                if (opc <= i && opc > 0) //se a opc estiver de acordo com o nr de operarios
                    operarios[opc - 1] = MenuEditarOperario((Operario)operarios[opc - 1]); //entra dentro do MenuEditarOperario cujo o operario está na posiçao i. 
            } while (opc != 0);                                                            //i é calculado atraves de [opc - 1] pq acrescentamos +1 ao valor de i, apenas por motivos de compreensão do utilizador
            return operarios;                                                              // por isso é necessário subtraí-lo para acedermos ao operario que realmente queremos.
        }

        public static Operario MenuEditarOperario(Operario operario)
        {
            int opc = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Editar dados do operário: " + operario.Nome);
                Console.WriteLine("1 - ID: " + operario.Id.ToString());
                Console.WriteLine("2 - Nome: " + operario.Nome);
                Console.WriteLine("3 - Email: " + operario.Email);
                Console.WriteLine("4 - Valor Hora: " + operario.ValorH.ToString());
                Console.WriteLine("5 - Departamento: " + operario.Departamento);
                Console.WriteLine("6 - Data de Nascimento: " + operario.DataNasc.toString());
                Console.WriteLine("7 - Calcular Idade");
                Console.WriteLine("8 - Calcular Salário");
                Console.WriteLine("\n0 - Voltar ao menu anterior");
                opc = Int32.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine("Digite o ID:");
                        operario.Id = ((int)Ler((typeof(int))));
                        break;
                    case 2:
                        Console.WriteLine("Digite o Nome:");
                        operario.Nome = (Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Digite o E-mail:");
                        operario.Email = (Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Digite o Valor por hora:");
                        operario.ValorH = ((double)Ler((typeof(double))));
                        break;
                    case 5:
                        Console.WriteLine("Digite o Departamento:");
                        operario.Departamento = (Console.ReadLine());
                        break;
                    case 6:
                        int ano, dia, mes;
                        Console.WriteLine("Digite a data(DD/MM/AAAA):");
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
                        operario.DataNasc = new Data(dia, mes, ano); //DEBUG
                        break;
                    case 7:
                        Console.WriteLine("\nIdade do " + operario.Nome + ": " + operario.calcularidade().ToString());
                        Console.WriteLine("\n\nClique numa tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.WriteLine("Indique o número de horas que trabalhou: ");
                        double r;
                        r = operario.calcSal((double)Ler((typeof(double))));
                        Console.WriteLine("Salário bruto sem subsídios: " + r.ToString() + "euros");
                        Console.ReadKey();
                        break;
                }
            } while (opc != 0);
            return operario;
        }

        public static List<Gerente> MenuGerentes(List<Gerente> gerentes)
        {
            int i;
            int opc = 999;

            do
            {
                i = 0;
                Console.Clear();
                Console.WriteLine("Editar Gerente:"); //mostrar todos os operarios
                foreach (Gerente obj in gerentes)
                {
                    Console.WriteLine((i + 1) + " - " + obj.Nome); //mostra apenas o nome de cada um
                    i++;
                }
                Console.WriteLine("\n0 - Voltar ao menu anterior");
                opc = ((int)Ler((typeof(int))));
                if (opc <= i && opc > 0) //se a opc estiver de acordo com o nr de operarios
                    gerentes[opc - 1] = MenuEditarGerente((Gerente)gerentes[opc - 1]); //entra dentro do MenuEditarOperario cujo o operario está na posiçao i. 
            } while (opc != 0);                                                        //i é calculado atraves de [opc - 1] pq acrescentamos +1 ao valor de i, apenas por motivos de compreensão do utilizador
                                                                                       //por isso é necessário subtraí-lo para acedermos ao operario que realmente queremos.
            return gerentes;
        }

        public static Gerente MenuEditarGerente(Gerente gerente)
        {
            int opc;
            do
            {
                Console.Clear();
                Console.WriteLine("1 - ID: " + gerente.Id.ToString());
                Console.WriteLine("2 - Nome: " + gerente.Nome);
                Console.WriteLine("3 - Email: " + gerente.Email);
                Console.WriteLine("4 - Valor Hora: " + gerente.ValorH.ToString());
                Console.WriteLine("5 - Especialidade: " + gerente.Especialidade);
                Console.WriteLine("6 - Extensão: " + gerente.Extensao.ToString());
                Console.WriteLine("7 - Data de Nascimento: " + gerente.DataNasc.toString());
                Console.WriteLine("8 - Calcular Idade");
                Console.WriteLine("9 - Calcular Salário");
                Console.WriteLine("\n0 - Sair");
                opc = Int32.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Digite o ID:");
                        gerente.Id = ((int)Ler((typeof(int))));
                        break;
                    case 2:
                        Console.WriteLine("Digite o Nome:");
                        gerente.Nome = (Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Digite o E-mail:");
                        gerente.Email = (Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Digite o Valor por hora:");
                        gerente.ValorH = ((double)Ler((typeof(double))));
                        break;
                    case 5:
                        Console.WriteLine("Digite a Especialidade:");
                        gerente.Especialidade = (Console.ReadLine());
                        break;
                    case 6:
                        Console.WriteLine("Digite a Extensão:");
                        gerente.Extensao = (Int32.Parse(Console.ReadLine()));
                        break;
                    case 7:
                        int ano, dia, mes;
                        Console.WriteLine("Digite a data(DD/MM/AAAA):");
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
                        gerente.DataNasc = new Data(dia, mes, ano); //DEBUG
                        break;
                    case 8:
                        Console.WriteLine("\nIdade do " + gerente.Nome + ": " + gerente.calcularidade().ToString());
                        Console.WriteLine("\n\nClique numa tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 9:
                        Console.WriteLine("Indique o número de horas que trabalhou: ");
                        double r;
                        r = gerente.calcSal((double)Ler((typeof(double))));
                        Console.WriteLine("Salário bruto sem subsídios: " + r.ToString() + "euros");
                        Console.ReadKey();
                        break;
                }
            } while (opc != 0);
            return gerente;
        }

        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
    }

    /*SEM PROPRIEDADES
     
     class Program
    {
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

        public static void GuardarGerentes(List<Gerente> gerentes)
        {

            StreamWriter wdgerentes = new StreamWriter(@"Gerentes.txt");

            foreach (Gerente obj in gerentes)
            {

                string linha = obj.GetId().ToString() + ";"
                                + obj.GetNome() + ";"
                                + obj.GetEmail() + ";"
                                + obj.GetValorHora().ToString() + ";"
                                + obj.GetDataNascimento().ToString() + ";"
                                + obj.GetEspecialidade() + ";"
                                + obj.GetExtensao().ToString()
                                ;
                wdgerentes.WriteLine(linha);

            }
            wdgerentes.Close();

        }

        public static void GuardarOperarios(List<Operario> operarios)
        {
            StreamWriter wdoperarios = new StreamWriter(@"Operarios.txt");
            foreach (Operario obj in operarios)
            {
                string linha = obj.GetId().ToString() + ";"
                             + obj.GetNome() + ";"
                             + obj.GetEmail() + ";"
                             + obj.GetValorHora().ToString() + ";"
                             + obj.GetDataNascimento().ToString() + ";"
                             + obj.GetDepartamento()
                             ;
                wdoperarios.WriteLine(linha);
            }
            wdoperarios.Close();
        }

        public static void OpcInvalida()
        {
            Console.WriteLine("Opção inválida.");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {

            //ArrayList gerentes = new ArrayList();
            List<Gerente> gerentes = new List<Gerente>();

            //ArrayList operarios = new ArrayList();
            List<Operario> operarios = new List<Operario>();

            gerentes = CarregarGerentes(gerentes);
            operarios = CarregarOperarios(operarios);

            int opc = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("<---------------------------FT04------------------------->");
                Console.WriteLine("|---------------------------EXE1-------------------------|");
                Console.WriteLine("| [1] -               Inserir Gerente              - [1] |");
                Console.WriteLine("| [2] -               Inserir Operário             - [2] |");
                Console.WriteLine("| [3] -              Visualizar Gerentes           - [3] |");
                Console.WriteLine("| [4] -             Visualizar Operários           - [4] |");
                Console.WriteLine("| [5] -            Visualizar Funcionários         - [5] |");
                Console.WriteLine("| [6] -             Sair do Programa               - [6] |");
                Console.WriteLine("<-------------------------------------------------------->");
                Console.Write("Digite a opção pretendida: ");
                opc = ((int)Ler((typeof(int))));

                switch (opc)
                {
                    case 1:
                        InserirGerente(gerentes);
                        break;
                    case 2:
                        InserirOperario(operarios);
                        break;
                    case 3:
                        gerentes = MenuGerentes(gerentes);
                        break;
                    case 4:
                        operarios = MenuOperarios(operarios);
                        break;
                    case 5:
                        VisualizarFuncionarios(gerentes, operarios);
                        break;
                    case 6:
                        Fechar();
                        break;
                    default:
                        OpcInvalida();
                        break;
                }
            } while (opc != 6);
            GuardarGerentes(gerentes);
            GuardarOperarios(operarios);
        }

        public static void Fechar()
        {
            Console.Clear();
            Console.WriteLine("Até à próxima! ;)");
            System.Threading.Thread.Sleep(1000);
            Environment.Exit(0);
        }


        public static void VisualizarFuncionarios(List<Gerente> gerentes, List<Operario> operarios)
        {

            Console.WriteLine("\nGerentes:\n");
            foreach (Gerente obj in gerentes)
            {
                Console.WriteLine("\n" + obj.ToString());
            }
            Console.WriteLine("\nOperarios:\n");
            foreach (Operario obj in operarios)
            {
                Console.WriteLine("\n" + obj.toString());
            }
            Console.WriteLine("\n\nClique numa tecla para voltar ao menu...");
            Console.ReadKey();
        }

        public static void InserirGerente(List<Gerente> gerentes)
        {
            int ano, dia, mes;
            Gerente ger;
            ger = new Gerente();
            Console.WriteLine("Digite o ID:");
            ger.SetId((int)Ler((typeof(int))));
            Console.WriteLine("Digite o Nome:");
            ger.SetNome(Console.ReadLine());
            Console.WriteLine("Digite o E-mail:");
            ger.SetEmail(Console.ReadLine());
            Console.WriteLine("Digite o Valor Hora:");
            ger.SetValorHora((double)Ler((typeof(double))));
            Console.WriteLine("Digite a especialidade:");
            ger.SetEspecialidade(Console.ReadLine());
            Console.WriteLine("Digite a extensao:");
            ger.SetExtensao((int)Ler((typeof(int))));
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
            ger.SetDataNascimento(dia, mes, ano);
            gerentes.Add(ger);
            GuardarGerentes(gerentes);
            
        }

        public static void InserirOperario(List<Operario> operarios)
        {

            int ano, dia, mes;
            Operario op;
            op = new Operario();
            Console.WriteLine("Digite o ID:");
            op.SetId((int)Ler((typeof(int))));
            op.SetNome(Console.ReadLine());
            Console.WriteLine("Digite o E-mail:");
            op.SetEmail(Console.ReadLine());
            Console.WriteLine("Digite o Valor Hora:");
            op.SetValorHora((double)Ler((typeof(double))));
            Console.WriteLine("Digite o Departamento:");
            op.setDepartamento(Console.ReadLine());
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
            op.SetDataNascimento(dia, mes, ano);
            operarios.Add(op);
            GuardarOperarios(operarios);

            
        }

        public static List<Operario> MenuOperarios(List<Operario> operarios)
        {
            int i;
            int opc = 0;
            do
            {
                i = 0;
                Console.Clear();
                Console.WriteLine("Editar Operario:");
                foreach (Operario obj in operarios)
                {
                    Console.WriteLine((i + 1) + " - " + obj.GetNome());
                    i++;
                }
                Console.WriteLine("\n0 - Voltar ao menu anterior");
                opc = ((int)Ler((typeof(int))));
                if (opc <= i && opc > 0)
                    operarios[opc - 1] = MenuEditarOperario((Operario)operarios[opc - 1]);
            } while (opc != 0);
            return operarios;
        }
        public static Operario MenuEditarOperario(Operario operario)
        {
            int opc = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Editar dados do operário: " + operario.GetNome());
                Console.WriteLine("1 - ID: " + operario.GetId().ToString());
                Console.WriteLine("2 - Nome: " + operario.GetNome());
                Console.WriteLine("3 - Email: " + operario.GetEmail());
                Console.WriteLine("4 - Valor Hora: " + operario.GetValorHora().ToString());
                Console.WriteLine("5 - Departamento: " + operario.GetDepartamento());
                Console.WriteLine("6 - Data de Nascimento: " + operario.GetDataNascimento().ToString());
                Console.WriteLine("7 - Calcular Idade");
                Console.WriteLine("8 - Calcular Salário");
                Console.WriteLine("\n0 - Voltar ao menu anterior");
                opc = Int32.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine("Digite o ID:");
                        operario.SetId((int)Ler((typeof(int))));
                        break;
                    case 2:
                        Console.WriteLine("Digite o Nome:");
                        operario.SetNome(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Digite o E-mail:");
                        operario.SetEmail(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Digite o Valor por hora:");
                        operario.SetValorHora((double)Ler((typeof(double))));
                break;
                    case 5:
                        Console.WriteLine("Digite o Departamento:");
                        operario.setDepartamento(Console.ReadLine());
                        break;
                    case 6:
                        int ano, dia, mes;
                        Console.WriteLine("Digite a data(DD/MM/AAAA):");
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
                        operario.SetDataNascimento(dia, mes, ano);
                        break;
                    case 7:
                        Console.WriteLine("Idade do " + operario.GetNome() + ": " + operario.CalcularIdade().ToString());
                        Console.WriteLine("\n\nClique numa tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.WriteLine("Indique o número de horas que trabalhou: ");
                        double r;
                        r = operario.CalcularSalario((double)Ler((typeof(double))));
                        Console.WriteLine("Salário bruto sem subsídios: " + r.ToString() + "euros");
                        Console.ReadKey();
                        break;
                }
            } while (opc != 0);
            return operario;
        }
        public static List<Gerente> MenuGerentes(List<Gerente> gerentes)
        {
            int i;
            int opc = 999;

            do
            {
                i = 0;
                Console.Clear();
                Console.WriteLine("Editar Gerente:");
                foreach (Gerente obj in gerentes)
                {
                    Console.WriteLine((i + 1) + " - " + obj.GetNome());
                    i++;
                }
                Console.WriteLine("\n0 - Voltar ao menu anterior");
                opc = ((int)Ler((typeof(int))));
                if (opc <= i && opc > 0)
                    gerentes[opc - 1] = MenuEditarGerente((Gerente)gerentes[opc - 1]);
            } while (opc != 0);

            return gerentes;
        }
        public static Gerente MenuEditarGerente(Gerente gerente)
        {
            int opc;
            do
            {
                Console.Clear();
                Console.WriteLine("1 - ID: " + gerente.GetId().ToString());
                Console.WriteLine("2 - Nome: " + gerente.GetNome());
                Console.WriteLine("3 - Email: " + gerente.GetEmail());
                Console.WriteLine("4 - Valor Hora: " + gerente.GetValorHora().ToString());
                Console.WriteLine("5 - Especialidade: " + gerente.GetEspecialidade());
                Console.WriteLine("6 - Extensão: " + gerente.GetExtensao().ToString());
                Console.WriteLine("7 - Data de Nascimento: " + gerente.GetDataNascimento().ToString());
                Console.WriteLine("8 - Calcular Idade");
                Console.WriteLine("9 - Calcular Salário");
                Console.WriteLine("\n0 - Sair");
                opc = Int32.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Digite o ID:");
                        gerente.SetId((int)Ler((typeof(int))));
                        break;
                    case 2:
                        Console.WriteLine("Digite o Nome:");
                        gerente.SetNome(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Digite o E-mail:");
                        gerente.SetEmail(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Digite o Valor por hora:");
                        gerente.SetValorHora((double)Ler((typeof(double))));
                        break;
                    case 5:
                        Console.WriteLine("Digite a Especialidade:");
                        gerente.SetEspecialidade(Console.ReadLine());
                        break;
                    case 6:
                        Console.WriteLine("Digite a Extensão:");
                        gerente.SetExtensao(Int32.Parse(Console.ReadLine()));
                        break;
                    case 7:
                        int ano, dia, mes;
                        Console.WriteLine("Digite a data(DD/MM/AAAA):");
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
                        gerente.SetDataNascimento(dia, mes, ano);
                        break;
                    case 8:
                        Console.WriteLine("Idade do " + gerente.GetNome() + ": " + gerente.CalcularIdade().ToString());
                        Console.WriteLine("\n\nClique numa tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 9:
                        Console.WriteLine("Indique o número de horas que trabalhou: ");
                        double r;
                        r = gerente.CalcularSalario((double)Ler((typeof(double))));
                        Console.WriteLine("Salário bruto sem subsídios: " + r.ToString() + "euros");
                        Console.ReadKey();
                        break;
                }
            } while (opc != 0);
            return gerente;
        }

        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

    }
     
     */
}

