/*
 
 3 - Escreva um programa que recebe como entrada uma frase do usuário.
Como saída o programa deve exibir no console as seguintes informações:
quantas palavras são maiúsculas, quantas palavras são minúsculas, quantas
palavras iniciam com letra maiúscula, quantas palavras iniciam com letra
minúscula e a quantidade de palavras.
 
 */

using System.Text.RegularExpressions;

namespace CodingTankME
{
    class AnalyzePhrase
    {

        public static void run()
        {
            Console.Write("Digite uma frase: ");
            string input = Console.ReadLine().Trim();

            int upperCaseWords = 0,
                lowerCaseWords = 0,
                wordsStartingWithUpper = 0,
                wordsStartingWithLower = 0,
                totalWords = 0;

            // utilizando regex para inserir as palavras em um array de string
            string[] words = Regex.Split(input, @"\s+");

            foreach (string word in words)
            {

                /* sai do loop se a string for nula ou vazia ou 
                 * 100% composta por números*/
                if (string.IsNullOrEmpty(word) || word.All(char.IsDigit))
                {
                    continue;
                }

                //começa somando a palavra que não cai na condição anterior
                totalWords++;

                /*se todos os caracteres são maiúsculos adiciona na 
                 * todas maiúsculas e também na começa maiúsculas 
                 * (porque 100% maiúscula também começa com maiúscula)*/

                if (word.All(char.IsUpper))
                {
                    upperCaseWords++;
                    wordsStartingWithUpper++;
                }

                //faz o mesmo para as minúsculas

                else if (word.All(char.IsLower))
                {
                    lowerCaseWords++;
                    wordsStartingWithLower++;
                }

                //se não cair nas condições anteriores 
                else
                {
                    //analisa se o primeiro caractere é maiúsculo
                    if (char.IsUpper(word[0]))
                        wordsStartingWithUpper++;
                    else
                    //se não for, é porque é minúsculo
                        wordsStartingWithLower++;
                }
            }

            /*removendo da contagem as palavras que são 100% maiúsculas
            ou minúsculas, conforme orientação dada em sala*/

            wordsStartingWithUpper -= upperCaseWords;
            wordsStartingWithLower -= lowerCaseWords;

            Console.WriteLine($"\nPalavras 100% maiúsculas: {upperCaseWords}");
            Console.WriteLine($"Palavras 100% minúsculas: {lowerCaseWords}");
            Console.WriteLine($"Palavras que começam com letra maiúscula: {wordsStartingWithUpper}");
            Console.WriteLine($"Palavras que começam com letra minúscula: {wordsStartingWithLower}");
            Console.WriteLine($"Total de palavras: {totalWords}");

        }
    }
}