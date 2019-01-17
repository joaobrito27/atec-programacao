using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ficha_Trabalho_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ficha de Trabalho 2 - Exercicio 1

            Console.WriteLine("<---------- Ficha de Trabalho 2 - Exercicio 1 ---------->\n\n");

            StreamReader rdEx1 = new StreamReader(@"VENCIMENTOS.txt");
            StreamWriter wrEx1 = new StreamWriter(@"SUPMIL.txt", true);

            if (File.Exists("VENCIMENTOS.txt"))
            {
                Console.WriteLine("O ficheiro VENCIMENTOS.txt existe!");
            }
            else {
                Console.WriteLine("O ficheiro VENCIMENTOS.txt não existe!\n\n");
            }

            //Enquanto  houver conteudo no ficheiro VENCIMENTOS.txt
            while (!rdEx1.EndOfStream)
            {
                string linha = rdEx1.ReadLine(); //ler linha a linha e insere o conteudo na string linha
                string[] palavras = linha.Split(' '); //Escreve o que está na string 'linha' separado por um espaço


                if (int.Parse(palavras[2]) > 1000) //se o valor do elemento que está na posicao[2] > 1000 escreve no ficheiro 'SUPMIL.txt' o conteudo.
                {
                    wrEx1.WriteLine(linha); //SUPMIL.txt
                }
                else
                {
                    //wrEx1.Write("Não contém Registos!");
                }
            }
            wrEx1.Close();
            rdEx1.Close();
           // System.Threading.Thread.Sleep(9999);


            //Ficha de Trabalho 2 - Exercicio 2

            Console.WriteLine("<---------- Ficha de Trabalho 2 - Exercicio 2 ---------->\n\n");

            StreamReader rdEx2 = new StreamReader(@"NOTAS.TXT");
            StreamWriter wrEx2 = new StreamWriter(@"APROVADOS.txt", true);
            StreamWriter wr2Ex2 = new StreamWriter(@"REPROVADOS.txt", true);

            if (File.Exists("NOTAS.TXT"))
            {
                Console.WriteLine("O ficheiro NOTAS.TXT existe!");
            }
            else
            {
                Console.WriteLine("O ficheiro NOTAS.TXT não existe!\n\n");
            }

            //Enquanto houver conteudo no ficheiro NOTAS.TXT
            while (!rdEx2.EndOfStream)
            {
                string linha = rdEx2.ReadLine(); //ler linha a linha e insere o conteudo na string linha
                string[] palavras = linha.Split(' '); //Escreve o que está na string 'linha' separado por um espaço

                if (int.Parse(palavras[2]) > 9.5) //se o valor do elemento que está na posicao[2] > 9.5 escreve no ficheiro 'APROVADOS.txt' o conteudo.
                {
                    wrEx2.WriteLine(linha); //'APROVADOS.txt'
                }
                else // se não, escreve no ficheiro 'REPROVADOS.txt' o conteudo
                {
                    wr2Ex2.WriteLine(linha); //'REPROVADOS.txt'
                }
            }
            wrEx2.Close();
            wr2Ex2.Close();
            rdEx2.Close();
            System.Threading.Thread.Sleep(9999);


        }
    }
}
