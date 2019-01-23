using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_Trabalho_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------Data e Hora-----------------");
            Data dt1 = new Data(22, 05, 1998, 22, 00, 00, "Terça-Feira");
            Data dt2 = new Data(17, 01, 2019, 20, 00, 00, "Terça-Feira");
            Console.WriteLine("Data 1:" + dt1.toString());
            Console.WriteLine("Data 2:" + dt2.toString());
            Console.WriteLine("\nDiferença entre 2 horas: " + dt1.Hora.difEntre2Horas(dt2.Hora));
            Console.WriteLine("\n\tDiferença entre 2 anos: " + dt1.difEntre2anos(dt2));

            Console.WriteLine("-----------------Pontos----------------");
            Ponto pt1 = new Ponto(20, 10);
            Ponto pt2 = new Ponto(10, 5);
            Ponto pt3 = new Ponto(1, 1);
            Ponto pt4 = new Ponto(2, 2);

            Console.WriteLine("\nPonto 1:" + pt1.toString());
            Console.WriteLine("\nPonto 2:" + pt2.toString());
            Console.WriteLine("\nDistancia entre o Ponto 1 e o Ponto 2: " + pt1.distEntre2Pontos(pt2));

            Console.WriteLine("-----------------Retas----------------");
            Reta rt1 = new Reta(pt1, pt2);
            Reta rt2 = new Reta(pt3, pt4);
            Console.WriteLine("\nReta 1: " + rt1.toString());
            Console.WriteLine("\nReta 2: " + rt2.toString());

            Console.ReadKey();
        }
    }
}
