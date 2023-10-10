/*
 
1 - Escreva um programa que faça a leitura de 5 valores Inteiros do
usuário. Em seguida, o programa deve exibir no console a informação de
quantos dos valores digitados são pares, quantos dos valores digitados
são ímpares, quantos deles são positivos e, por fim, quantos são negativos.
Cada uma das informações deve ser escrita em uma linha diferente.

 */

namespace CodingTankME
{
    class Numbers
    {
        public static void run()
        {

            List<int> listNumbers = new List<int>();

            int counter = 1,
                even = 0, //pares
                odd = 0, //ímpares
                positives = 0, //positivos
                negatives = 0; //negativos

            while (counter <= 5)
            {
                Console.WriteLine(Assets.horizontalLine());
                Console.WriteLine($"\nDigite o {counter}º número inteiro: ");
                
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    listNumbers.Add(number);
                    counter++;
                }
                else
                /* trata os erros de parsing (strings, doubles, etc.)
                 * exibindo a mensagem de erro e retomando o loop*/
                {
                    Console.WriteLine("Número inválido. Tente novamente.");
                }
            }

            foreach (var number in listNumbers)
            {
                _ = number > 0 ? positives++ : (number < 0 ? negatives++ : 0);
                _ = number % 2 == 0 ? even++ : odd++;
            }

            Console.WriteLine($"\nPares: {even}");
            Console.WriteLine($"\nÍmpares: {odd}");
            Console.WriteLine($"\nPositivos: {positives}");
            Console.WriteLine($"\nNegativos: {negatives}");
        }
    }
}