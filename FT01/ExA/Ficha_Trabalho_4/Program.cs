using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_Trabalho_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t-----------------Contacto-----------------");
            Contacto c1 = new Contacto(20, 917012665, "Joao", "joao@gmail.com", 01, 12, 1998);
            Contacto c2 = new Contacto(15, 965474555, "Pedro", "pedro@gmail.com", 01, 12, 1997);
            Console.Write(c1.toString());
            Console.Write(c2.toString());

            //calcular idade
            Console.WriteLine("\n\n-----------------Calcular Idade de cada Contacto-----------------");
            Console.WriteLine("\n\nIdade do " + c1.Nome + ":"  + c1.calcularidade() + " anos");
            Console.WriteLine("\n\nIdade do " + c2.Nome + ":" + c2.calcularidade() + " anos");

            //diferença entre 2 anos
            Console.WriteLine("\n\t-----------------Data-----------------");
            Data dt1 = new Data(01, 12, 1998);
            Data dt2 = new Data(01, 12, 1999);
            Console.WriteLine("\nDiferença entre 2 anos: " + dt1.difEntre2anos(dt2));

            Console.WriteLine("\n\t-----------------Conta-----------------");
            Conta ct1 = new Conta();
            ct1.depositar(200);

            Console.WriteLine(ct1.toString());

            Console.ReadKey();
        }
    }
}
