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
                Console.WriteLine("| [8] - Soma do comprimento - [G]                      |");
                Console.WriteLine("| [9] - Trocar 'v' por 'b' e 'ão' por 'om' - [H]        |");
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
                        if (!mesmaDim(n, vec)) //se for falso
                        {
                            Console.WriteLine("As strings introduzidas não são iguais.");
                        }
                        else //se for verdade
                        {
                            Console.WriteLine("As strings introduzidas são iguais.");
                        }
                        Console.WriteLine("Prima qualquer tecla para voltar ao menu...");
                        break;
                    case 8:
                        if (somarStrings(n, vec) > 0)
                        {
                            Console.Write("Soma das Lenghts: " + somarStrings(n, vec) + ".");
                        }
                        Console.WriteLine("Prima qualquer tecla para voltar ao menu...");
                        break;
                    case 9:
                        substituirString();
                        Console.WriteLine("Prima qualquer tecla para voltar ao menu...");
                        break;
                    default:
                        sairPrograma();
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


        private static void sairPrograma()
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

            int dimensao = vec[0].Length; //a variavel "dimensao" guarda o numero de carateres do vec[0]

            for (int i = 0; i < n; i++) //percorrer todo o vetor
            {
                if (vec[i].Length > dimensao) //Comparar cada posicao do vetor com a variavel "dimensao" que guarda o tamanho da posicao inicial
                    maiorString = vec[i]; //guardar o maior tamanho na variavel "maior string"                  
            }

            Console.WriteLine("A string que tem o maior comprimento é " + maiorString + ".");
        }


        private static bool mesmaDim(int n, string[] vec)
        {

            //F. Crie uma função que receba um vector de strings como argumento e retorne um valor booleano indicando se todas as strings têm o mesmo comprimento.

            int contStrings = 0;

            int dimensao = vec[0].Length; //a variavel "dimensao" guarda o numero de carateres do vec[0]

            for (int i = 0; i < n; i++) //percorrer todo o vetor
            {
                if (vec[i].Length == dimensao) //Comparar cada posicao do vetor com a variavel "dimensao" que guarda o tamanho da posicao inicial
                    contStrings++;  //contar as vezes que tem o mesmo comprimento
            }

            if (contStrings == n) //se o valor da variavel "contStrings" for igual ao N de elementos do vetor significa que o tamanho é igual em todos (true).
                return true;//retorna true se todos os elementos tiverem o mesmo tamanho
            return false;//retorna false se os elementos nao tiverem o mesmo tamanho
        }


        private static int somarStrings(int n, string[] vec)
        {
            //G. Crie uma função que receba um vector de strings como argumento e retorne um valor inteiro correspondendo à soma de todos os comprimentos das strings.


            int somaStrings = vec[0].Length; //a variavel "somaStrings" guarda todos os comprimentos das strings começando por vec[0]

            for (int i = 1; i < n; i++) //percorrer todo o vetor
            {
                somaStrings += vec[i].Length; //Somar todos os comprimentos
            }

            return somaStrings; //retornar a soma de todos os comprimentos

        }


        private static void substituirString()
        {

            //H. Crie uma função que, numa string substitua todas as letras “v” por “b” e todas as ocorrências de “ão” por “om”.

            Console.WriteLine("Digite a string para ser convertida: ");
            string str = Console.ReadLine();


            str=str.Replace('v', 'b').Replace('V', 'B');
            str=str.Replace("ão", "om").Replace("ÃO", "OM");

            Console.WriteLine(str);  
        }


        private static bool apenasalgarismos()
        {
            Console.WriteLine("Digite a string para ser convertida: ");
            string str = Console.ReadLine();

            return true;

        }

    }
}
