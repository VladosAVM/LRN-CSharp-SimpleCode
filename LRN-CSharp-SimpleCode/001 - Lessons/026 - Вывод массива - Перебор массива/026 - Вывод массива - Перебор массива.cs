using System;

/* Вывод массива - Перебор массива
 * 
 * Источник: https://www.youtube.com/watch?v=uRi-fKUYzUM
 */

namespace _026___Вывод_массива___Перебор_массива
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Для перебора массива используются циклы.
             * Осуществлять перебор массива можно любым циклом,
             * но наиболее удобными для этого будут циклы For и ForEach
             */
            
            int[] firstArray = { 10, 3, 2, 55 };

            // Цикл For
            Console.WriteLine("For:");
            Console.WriteLine("Вывод массива в прямом порядке");
            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write($"{firstArray[i]} ");
            }

            Console.WriteLine("\nВывод массива в обратном порядке");
            for (int i = firstArray.Length - 1; i >= 0; i--)
            {
                Console.Write($"{firstArray[i]} ");
            }
            Console.WriteLine("\n\n");

            // Цикл ForEach
            Console.WriteLine("ForEach:\n" +
                              "Вывод массива в прямом порядке");
            foreach (var item in firstArray)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\n\n\n\n");
        }
    }
}
