/*

 2 - Escreva um programa que calcule e escreva a multiplicação e a
divisão inteira de dois números inteiros, N1 por N2, que devem ser lidos
do teclado. É importante observar que a máquina que irá executar este
programa é capaz de efetuar apenas duas operações matemáticas: adição e
subtração. Ou seja, você não poderá usar os operadores de multiplicação,
divisão, módulo etc. bem como truncamentos.
 
 */

using System;

namespace CodingTankME
{
    class Calculate
    {

        public static void run()
        {
            int[] arrayNumbers = new int[2];
            int counter = 0;

            while (counter < 2)
            {
                Console.WriteLine(Assets.horizontalLine());
                Console.WriteLine($"\nDigite o {counter+1}º número inteiro: ");

                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    arrayNumbers[counter] = number;
                    counter++;
                }
                else
                /* trata os erros de parsing (strings, doubles, etc.)
                 * exibindo a mensagem de erro e retomando o loop*/
                {
                    Console.WriteLine("Número inválido. Tente novamente.");
                }
            }

            int n1 = arrayNumbers[0],
                n2 = arrayNumbers[1],
                multiply = 0,
                divide = 0,
                sign = 1;

            /*captura o módulo dos números para utilizar*/

            if (n1 < 0)
            {
                sign *= -1;
                n1 = -n1;
            }
            if (n2 < 0)
            {
                sign *= -1;
                n2 = -n2;
            }

            /*calcula multiplicação através de adição repetida*/

            for (int i = 0; i < n2; i++)
            {
                multiply += n1;
            }

            /* calcula a divisão por inteiros
            * (quantas vezes n2 cabe em n1?)*/

            while (n1 >= n2)
            {
                n1 -= n2;
                divide++;
            }

            /*ajusta o sinal correto na divisão e na multiplicação*/

            divide *= sign;
            multiply *= sign;

            Console.WriteLine(Assets.horizontalLine());
            Console.WriteLine($"\nMultiplicação: {multiply}");
            Console.WriteLine($"Divisão Inteira: {divide}");

        }
    }
}
