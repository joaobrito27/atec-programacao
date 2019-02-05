using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConsoleApp6
{
    class Program
    {
        enum Opcao { inserirElem=1, mostrarLista=2, sair=3 };

        static List<string> lista = new List<string>();

        static object lerValor()
        {
            int val=0;
            bool flag=false;
            do
            {
                try
                {
                    val=int.Parse(Console.ReadLine());
                    flag=true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Valor incorrecto, digite novamente:");
                    flag = false;
                }
            }while(!flag);
            return val;
        }

        static object menu()
        {
            int contador=0;
            Console.Clear();
            Console.WriteLine("Qual a opção pretendida?");
            foreach (Opcao val in Enum.GetValues(typeof(Opcao)))
            {
                Console.WriteLine(++contador + " - " + val);
            }
            return lerValor();
        }

        static void fechar()
        {
            Console.Clear();
            Console.WriteLine("Até à próxima!");
            System.Threading.Thread.Sleep(1000);
            Environment.Exit(0);
        }

        static void opInvalida()
        {
            Console.WriteLine("Opção inválida!");
        }

        static void insereElemLista()
        {
            Console.Clear();
            Regex regCodPOstal = new Regex(@"^[0-9]{4}$");
            bool flag=false;
            do
            {
                Console.WriteLine("Digite um código postal de 4 dígitos:");
                string elem = Console.ReadLine();
                if (regCodPOstal.IsMatch(elem)) { 
                    lista.Add(elem);
                    Console.WriteLine("O elemento: {0} foi adicionado.", elem);
                    flag =true;
                }
                else { 
                    Console.WriteLine("O código postal deve ser de 4 dígitos");
                    flag=false;
                }
            }while (!flag);
            System.Threading.Thread.Sleep(3000);
        }

        static void mostraLista()
        {
            Console.Clear();
            int contador=0;
            Console.WriteLine("elementos da lista:");
            Console.WriteLine();
            foreach(string s in lista)
                Console.WriteLine(++contador + " - " + s);
            Console.WriteLine("Digite qualquer tecla para continuar.");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            int op;
            do
            {
                op = (int)menu();
                switch (op)
                {
                    case 1:
                        insereElemLista();
                        break;
                    case 2:
                        mostraLista();
                        break;
                    case 3:
                        fechar();
                        break;
                    default:
                        opInvalida();
                        break;
                }
            }while(op!=(int)Opcao.sair);
            System.Threading.Thread.Sleep(10000);
        }
    }
}
