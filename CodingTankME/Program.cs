using System;

namespace CodingTankME { 

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\nCODING TANK ME - ANA CAROLINA ARMENTANO\n" +
                "\nQual programa você deseja executar?" +
                "\n(1) Questão 1 - Números Pares, Ímpares e Negativos" +
                "\n(2) Questão 2 - Operações Matemáticas" +
                "\n(3) Questão 3 - Análise de Frase" +
                "\n(0) Sair");

            try
            {
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nQuestão 1");
                        Numbers.run();
                        Main(args);
                        break;
                    case 2:
                        Console.WriteLine("\nQuestão 2");
                        Calculate.run();
                        Main(args);
                        break;
                    case 3:
                        Console.WriteLine("\nQuestão 3");
                        AnalyzePhrase.run();
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