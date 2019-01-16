using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExA
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            string[] vec = new string[n];

            for (int i = 0; i < n; i++)
            {
                vec[i] = String.Empty;

            }

            //https://code.msdn.microsoft.com/windowsdesktop/Menu-em-Console-Application-b1309a1c

            int opc;
            do
            {
                Console.WriteLine("<-------------------------FT01------------------------->");
                Console.WriteLine("|-------------------------EXE1-------------------------|");
                Console.WriteLine("| [1] - Mensagem Boas Vindas - [A. B. C.]              |");
                Console.WriteLine("| [2] - Nome Completo - [D]                            |");
                Console.WriteLine("| [3] - Ler N do Vec das Strings - []                  |");
                Console.WriteLine("| [4] - Ler Vec das Strings - []                       |");
                Console.WriteLine("| [5] - Escrever Vec das Strings - []                  |");
                Console.WriteLine("| [6] - Maior String - [E]                             |");
                Console.WriteLine("| [7] - Será que têm o mesmo comprimento? - [F]        |");
                Console.WriteLine("| [0] Sair do Programa                                 |");
                Console.WriteLine("<------------------------------------------------------>");
                Console.Write("Digite uma opção: ");
                opc = Int32.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        mensagem();
                        break;
                    case 2:
                        nomeCompleto();
                        break;
                    case 3:
                        n = lerN();
                        Console.WriteLine("Leitura do N Concluída! \nPrima qualquer tecla para voltar ao menu...");
                        break;
                    case 4:
                        vec = lerVec(n);
                        Console.WriteLine("Leitura do Vetor Concluída! \nPrima qualquer tecla para voltar ao menu...");
                        break;
                    case 5:
                        escreverVec(n, vec);
                        Console.WriteLine("Escrita do Vetor Concluída! \nPrima qualquer tecla para voltar ao menu...");
                        break;
                    case 6:
                        maiorString(n, vec);
                        Console.WriteLine("Prima qualquer tecla para voltar ao menu...");
                        break;
                    case 7:
                        mesmaDim(n, vec);
                        Console.WriteLine("Prima qualquer tecla para voltar ao menu...");
                        break;
                    default:
                        saiPrograma();
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }while (opc != 0);

            
        }

        private static int lerN()
        {
            Console.WriteLine("Quantas o valor de N? ");
            int n = Convert.ToInt32(Console.ReadLine());

            return n;
        }


        private static string[] lerVec(int n)
        {
            //Criação do vetor
            string[] vec = new string[n];

            //Ler cada elemento de vetor
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("String[ " + (i + 1) + "]: ");
                vec[i] = Console.ReadLine();
            }

            return vec;
        }


        public static void escreverVec(int n, string[] vec)
        {
            //Percorrer todo o vetor
            for (int i = 0; i < n; i++)
            {
                //Mostrar no ecra o valor de cada elemento do vetor
                Console.WriteLine("String[" + (i + 1) + "]: ");
                Console.WriteLine(vec[i]);

            }

        }


        private static void saiPrograma()
        {
            Console.WriteLine();
            Console.WriteLine("Saiu do programa. Clique qualquer tecla para fechar...");
        }


        private static void mensagem()
        {
            //A. Crie um programa que leia o nome próprio do utilizador e imprima uma mensagem personalizada do tipo: "Olá João!"
            //B. Altere o programa de modo a que se o nome for "Bartolomeu", o programa imprima "Dá cá o meu!".
            //C. Altere o programa anterior para que a mensagem surja para todos os nomes terminados em "eu". Exemplo:> Olá Zebedeu! Dá cá o meu!

            string nome;
            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine();

            //Para entrada de usuário e strings que serão exibidas para o usuário final, use o parâmetro StringComparison nos métodos que o possuem para especificar como combinar strings.
            //Caso insira "eu".
            bool endsWithSearchResult = nome.EndsWith("eu", System.StringComparison.CurrentCultureIgnoreCase); 

            if (nome == "Bartolomeu" || endsWithSearchResult)
                Console.WriteLine("Olá " + nome + "! " + "Dá cá o meu!"); //escrever o nome caso acabe em "eu" ou caso o nome seja "Bartolomeu"
            else
                Console.WriteLine("Olá " + nome + "!"); //escrever "Olá" + o nome digitado pelo utilizador
            
            Console.WriteLine("Prima qualquer tecla para voltar ao menu...");
        }


        private static void nomeCompleto()
        {
            //D. Altere o programa de modo a pedir o nome completo e apresentar apenas o primeiro e o último nome.

            string fullName;
            Console.WriteLine("Digite o seu nome completo: ");
            fullName = Console.ReadLine();

            string firstName = fullName.Split(' ').First(); //Achar o Primeiro Nome
            string lastName = fullName.Split(' ').Last();   //Achar o Ultimo Nome


            Console.WriteLine("Olá " + firstName + " " + lastName + "."); //escrever primeiro e ultimo nome
            Console.WriteLine("Prima qualquer tecla para voltar ao menu...");
        }


        private static void maiorString(int n, string[] vec)
        {
            //E. Crie uma função que indique qual de três strings introduzidas pelo utilizador tem um comprimento superior.
            
            string maiorString = "";

             for (int i = 0; i < n; i++) //percorrer todo o vetor
            {
                int dimensao = vec[0].Length; //a variavel "dimensao" guarda o numero de carateres do vec[0]

                if (vec[i].Length > dimensao) //Comparar cada posicao do vetor com a variavel "dimensao" que guarda o tamanho da posicao inicial
                    maiorString = vec[i]; //guardar o maior tamanho na variavel "maior string"                  
            }

            Console.WriteLine("A string que tem o maior comprimento é " + maiorString + ".");
        }


        private static bool mesmaDim(int n, string[] vec)
        {
            return true;
        }

    }
}
