using System;

namespace CodingTankME { 

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\nCODING TANK ME - ANA CAROLINA ARMENTANO E SILVA\n" +
                "\nQual programa você deseja executar?\n" +
                "\n(1) Questão 1" +
                "\n(2) Questão 2" +
                "\n(3) Questão 3" +
                "\n(0) Sair");

            try
            {
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nQuestão 1\n");
                        //SimpleCalculator.run();
                        Main(args);
                        break;
                    case 2:
                        Console.WriteLine("\nQuestão 2\n");
                        //AgeCalculator.run();
                        Main(args);
                        break;
                    case 3:
                        Console.WriteLine("\nQuestão 3\n");
                        //TipCalculator.run();
                        Main(args);
                        break;
                    case 0:
                        Console.WriteLine("\nPrograma finalizado.");
                        break;
                    default:
                        throw new ArgumentException("Por gentileza, informe um número inteiro dentre as opções disponíveis.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Main(args);
            }
        }
    }
}