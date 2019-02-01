class Program
{
    enum Opcao { isto=1, aquilo=2, aqueloutro=3, sair=4 };

    //static List<string> lista = new List<string>();

    static int lerValor()
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

    static int menu()
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

    static void Main(string[] args)
    {
        int op;
        do
        {
            op = menu();
            switch (op)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
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