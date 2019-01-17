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
                Console.WriteLine("<-------------------------FT01------------------------------>");
                Console.WriteLine("|-------------------------EXE1------------------------------|");
                Console.WriteLine("| [1] - Mensagem Boas Vindas - [A. B. C.]                   |");
                Console.WriteLine("| [2] - Nome Completo - [D]                                 |");
                Console.WriteLine("| [3] - Ler N do Vec das Strings - []                       |");
                Console.WriteLine("| [4] - Ler Vec das Strings - []                            |");
                Console.WriteLine("| [5] - Escrever Vec das Strings - []                       |");
                Console.WriteLine("| [6] - Maior String - [E]                                  |");
                Console.WriteLine("| [7] - Será que têm o mesmo comprimento? - [F]             |");
                Console.WriteLine("| [8] - Soma do comprimento - [G]                           |");
                Console.WriteLine("| [9] - Trocar 'v' por 'b' e 'ão' por 'om' - [H]            |");
                Console.WriteLine("| [10] - A string é constituída apenas por algarismos - [I] |");
                Console.WriteLine("| [11] - A string é constituída ou não por algarismos - [J] |");
                Console.WriteLine("| [12] - Verifica alfabéticamente duas strings - [K]        |");
                Console.WriteLine("| [13] - Ordena alfabéticamente 10 Nomes - [L]              |");
                Console.WriteLine("| [14] - QUIZ - [M]                                         |");
                Console.WriteLine("| [15] - Palíndromo - [N]                                   |");
                Console.WriteLine("| [0] Sair do Programa                                      |");
                Console.WriteLine("<----------------------------------------------------------->");
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
                    case 10:
                        if (apenasAlgarismos()) //se for true
                        {
                            Console.WriteLine("A string é constituída apenas por algarismos.");
                        }
                        else
                        {
                            Console.WriteLine("A string é constituída apenas por algarismos.");
                        }
                        Console.WriteLine("Prima qualquer tecla para voltar ao menu...");
                        break;
                    case 11:
                        if (temAlgarismos()) //se for true
                        {
                            Console.WriteLine("A string não é constituída por algarismos.");
                        }
                        else
                        {
                            Console.WriteLine("A string é constituída por algarismos.");
                        }
                        Console.WriteLine("Prima qualquer tecla para voltar ao menu...");
                        break;
                    case 12:
                        verifAlfabeticamente();
                        break;
                    case 13:
                        ordernarStrings();
                        break;
                    case 14:
                        quiz();
                        break;
                    case 15:
                        palindromo();
                        break;
                    default:
                        sairPrograma();
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (opc != 0);


        }

        private static int lerN()
        {
            //Ler quantos elementos vai ter vetor
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


            str = str.Replace('v', 'b').Replace('V', 'B'); //substitui na string 'str' todas as letras 'v' por 'b'
            str = str.Replace("ão", "om").Replace("ÃO", "OM"); //substitui na string 'str' todas as ocorrências 'ão' por 'om'

            Console.WriteLine(str);
        }


        private static bool apenasAlgarismos()
        {
            //I. Crie uma função para verificar se uma string é constituída apenas por algarismos. A função deverá retornar um valor booleano true neste caso.

            Console.WriteLine("Digite a string:");
            string str = Console.ReadLine();

            bool isNum = str.All(char.IsDigit); //verifica se TODOS os elementos da string são números
            if (isNum) //se for true
                return true;
            else
                return false;

        }


        private static bool temAlgarismos()
        {

            //J. Crie uma função que receba uma string como argumento e retorne true se a string não contiver algarismos.

            Console.WriteLine("Digite a string:");
            string str = Console.ReadLine();

            bool isIntString = str.Any(char.IsDigit); //verifica se QUALQUER UM dos elementos da string é número
            if (isIntString) //se for true
            {
                return false;
            }
            else
            {
                return true;
            }

        }


        private static void verifAlfabeticamente()
        {
            //K. Crie uma função que leia 2 strings do utilizador e indique qual das strings está primeiro na ordem alfabética.
            //https://docs.microsoft.com/en-us/dotnet/api/system.string.compare?view=netframework-4.7.2#System_String_Compare_System_String_System_String_

            Console.WriteLine("Digite a string 1:");
            string str1 = Console.ReadLine();

            Console.WriteLine("Digite a string 2:");
            string str2 = Console.ReadLine();

            //Verifica se por ordem alfabética se a string 1 vem primeiro que a string 2
            if (string.Compare(str1, str2) < 0)
            {
                Console.WriteLine("A string 1, " + str1 + ", vem primerio que a string 2, " + str2 + ", por ordem alfabética.");
            }

            //Verifica se por ordem alfabética se a string 2 vem primeiro que a string 1
            if (string.Compare(str1, str2) > 0)
            {
                Console.WriteLine("A string 2, " + str2 + ", vem primerio que a string 1, " + str1 + ", por ordem alfabética.");
            }

            //Verifica se por ordem alfabética as duas strings estão nas mesma posição
            if (string.Compare(str1, str2) == 0)
            {
                Console.WriteLine("As string estão na mesma posição por ordem alfabética.");
            }
        }


        private static void ordernarStrings()
        {
            //L. Crie uma função que leia 10 nomes para um vector de strings e os ordene alfabeticamente na saída.
            //https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=netframework-4.7.2

            //criar vetor
            string[] nomes = new string[10];

            //ler cada elemento do vetor
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("String[ " + (i + 1) + "]: ");
                nomes[i] = Console.ReadLine();
            }

            //Ordenar o vetor crescentemente / alfabeticamente
            Array.Sort(nomes);

            Console.WriteLine("\n\nString ordenada alfabeticamente:\n\n");

            //Percorrer o vetor, até chegar ao número máximo de elementos (tamanho -> nomes.Lenght)
            for (int i = 0; i < nomes.Length; i++) 
            {
                Console.WriteLine(nomes[i]);
            }

        }


        public static void quiz()
        {
            //M. Crie um jogo com 10 advinhas do tipo "Qual a cor do cavalo branco do Napoleão?", cada uma com 3 alternativas, apresentando o resultado final.


            int c = 0;

            Console.WriteLine("--------------------------------");
            Console.WriteLine("              QUIZ!             ");
            Console.WriteLine("--------------------------------");


            Console.WriteLine("\nAdivinha 1. Qual a cor do cavalo branco do Napoleão ? ");
            Console.WriteLine("\nA. Opção....");
            Console.WriteLine("B. Opção....");
            Console.WriteLine("C. Opção....");
            Console.WriteLine("D. Opção....");

            Console.WriteLine("\n");
            Console.WriteLine("Digite A, B, ou C.");

            string answer1 = Console.ReadLine();


            if (answer1.ToUpper() == "A")
            {
                Console.WriteLine("------Correto!------");
                Console.WriteLine("\n Próxima questão...");
                c++;
            }
            else
            {
                Console.WriteLine("------Errado!------");
                Console.WriteLine("\n Próxima questão...");
            }

            Console.WriteLine("\nAdivinha 2. Qual a cor do cavalo branco do Napoleão ? ");
            Console.WriteLine("\nA. Opção....");
            Console.WriteLine("B. Opção....");
            Console.WriteLine("C. Opção....");
            Console.WriteLine("D. Opção....");

            Console.WriteLine("\n");
            Console.WriteLine("Digite A, B, ou C.");

            string answer2 = Console.ReadLine();


            if (answer2.ToUpper() == "A")
            {
                Console.WriteLine("------Correto!------");
                Console.WriteLine("\n Próxima questão...");
                c++;
            }
            else
            {
                Console.WriteLine("------Errado!------");
                Console.WriteLine("\n Próxima questão...");
            }

            Console.WriteLine("\nAdivinha 3. Qual a cor do cavalo branco do Napoleão ? ");
            Console.WriteLine("\nA. Opção....");
            Console.WriteLine("B. Opção....");
            Console.WriteLine("C. Opção....");
            Console.WriteLine("D. Opção....");

            Console.WriteLine("\n");
            Console.WriteLine("Digite A, B, ou C.");

            string answer3 = Console.ReadLine();


            if (answer3.ToUpper() == "A")
            {
                Console.WriteLine("------Correto!------");
                Console.WriteLine("\n Próxima questão...");
                c++;
            }
            else
            {
                Console.WriteLine("------Errado!------");
                Console.WriteLine("\n Próxima questão...");
            }

            Console.WriteLine("\nAdivinha 4. Qual a cor do cavalo branco do Napoleão ? ");
            Console.WriteLine("\nA. Opção....");
            Console.WriteLine("B. Opção....");
            Console.WriteLine("C. Opção....");
            Console.WriteLine("D. Opção....");

            Console.WriteLine("\n");
            Console.WriteLine("Digite A, B, ou C.");

            string answer4 = Console.ReadLine();


            if (answer4.ToUpper() == "A")
            {
                Console.WriteLine("------Correto!------");
                Console.WriteLine("\n Próxima questão...");
                c++;
            }
            else
            {
                Console.WriteLine("------Errado!------");
                Console.WriteLine("\n Próxima questão...");
            }

            Console.WriteLine("\nAdivinha 5. Qual a cor do cavalo branco do Napoleão ? ");
            Console.WriteLine("\nA. Opção....");
            Console.WriteLine("B. Opção....");
            Console.WriteLine("C. Opção....");
            Console.WriteLine("D. Opção....");

            Console.WriteLine("\n");
            Console.WriteLine("Digite A, B, ou C.");

            string answer5 = Console.ReadLine();


            if (answer5.ToUpper() == "A")
            {
                Console.WriteLine("------Correto!------");
                Console.WriteLine("\n Próxima questão...");
                c++;
            }
            else
            {
                Console.WriteLine("------Errado!------");
                Console.WriteLine("\n Próxima questão...");
            }

            Console.WriteLine("\nAdivinha 6. Qual a cor do cavalo branco do Napoleão ? ");
            Console.WriteLine("\nA. Opção....");
            Console.WriteLine("B. Opção....");
            Console.WriteLine("C. Opção....");
            Console.WriteLine("D. Opção....");

            Console.WriteLine("\n");
            Console.WriteLine("Digite A, B, ou C.");

            string answer6 = Console.ReadLine();


            if (answer6.ToUpper() == "A")
            {
                Console.WriteLine("------Correto!------");
                Console.WriteLine("\n Próxima questão...");
                c++;
            }
            else
            {
                Console.WriteLine("------Errado!------");
                Console.WriteLine("\n Próxima questão...");
            }

            Console.WriteLine("\nAdivinha 7. Qual a cor do cavalo branco do Napoleão ? ");
            Console.WriteLine("\nA. Opção....");
            Console.WriteLine("B. Opção....");
            Console.WriteLine("C. Opção....");
            Console.WriteLine("D. Opção....");

            Console.WriteLine("\n");
            Console.WriteLine("Digite A, B, ou C.");

            string answer7 = Console.ReadLine();


            if (answer7.ToUpper() == "A")
            {
                Console.WriteLine("------Correto!------");
                Console.WriteLine("\n Próxima questão...");
                c++;
            }
            else
            {
                Console.WriteLine("------Errado!------");
                Console.WriteLine("\n Próxima questão...");
            }

            Console.WriteLine("\nAdivinha 8. Qual a cor do cavalo branco do Napoleão ? ");
            Console.WriteLine("\nA. Opção....");
            Console.WriteLine("B. Opção....");
            Console.WriteLine("C. Opção....");
            Console.WriteLine("D. Opção....");

            Console.WriteLine("\n");
            Console.WriteLine("Digite A, B, ou C.");

            string answer8 = Console.ReadLine();


            if (answer8.ToUpper() == "A")
            {
                Console.WriteLine("------Correto!------");
                Console.WriteLine("\n Próxima questão...");
                c++;
            }
            else
            {
                Console.WriteLine("------Errado!------");
                Console.WriteLine("\n Próxima questão...");
            }

            Console.WriteLine("\nAdivinha 9. Qual a cor do cavalo branco do Napoleão ? ");
            Console.WriteLine("\nA. Opção....");
            Console.WriteLine("B. Opção....");
            Console.WriteLine("C. Opção....");
            Console.WriteLine("D. Opção....");

            Console.WriteLine("\n");
            Console.WriteLine("Digite A, B, ou C.");

            string answer9 = Console.ReadLine();


            if (answer9.ToUpper() == "A")
            {
                Console.WriteLine("------Correto!------");
                Console.WriteLine("\n Próxima questão...");
                c++;
            }
            else
            {
                Console.WriteLine("------Errado!------");
                Console.WriteLine("\n Próxima questão...");
            }

            Console.WriteLine("\nAdivinha 10. Qual a cor do cavalo branco do Napoleão ? ");
            Console.WriteLine("\nA. Opção....");
            Console.WriteLine("B. Opção....");
            Console.WriteLine("C. Opção....");
            Console.WriteLine("D. Opção....");

            Console.WriteLine("\n");
            Console.WriteLine("Digite A, B, ou C.");

            string answer10 = Console.ReadLine();


            if (answer10.ToUpper() == "A")
            {
                Console.WriteLine("------Correto!------");
                Console.WriteLine("\n Fim do Quiz...");
                c++;
            }
            else
            {
                Console.WriteLine("------Errado!------");
                Console.WriteLine("\n Fim do Quiz...");
            }

            Console.WriteLine("\n Acertou " + c + " em 10.");
            Console.WriteLine("Prima qualquer tecla para voltar ao menu...");

        }


        public static void palindromo()
        {
            //N. Crie um programa para verificar se uma string é um palíndromo.


            Console.WriteLine("Digite a string para verificar se é palíndromo:");
            string str = Console.ReadLine();

            //Escreve a string inversamente.
            Console.WriteLine(str.Reverse().ToArray());

            //Compara se as strings são iguais, a string inserida pelo utilizador e a string escrita inversamente (Reverse).
            if (str.SequenceEqual(str.Reverse()))
                Console.WriteLine("É um Palíndromo");
            else
                Console.WriteLine("Não é palindromo");

        }

    }

}

    

