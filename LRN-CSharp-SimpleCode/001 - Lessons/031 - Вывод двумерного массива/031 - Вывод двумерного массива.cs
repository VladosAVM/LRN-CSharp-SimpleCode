using System;

/* Вывод двумерного массива
 * 
 * Источник: https://www.youtube.com/watch?v=hJR0LHKw1oY
 */

namespace _031___Вывод_двумерного_массива
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Вывод двумерного массива
             * 
             */

            int[,] testArray =
            {
                {2,5,1,7,5},
                {8,1,3,2,9},
                {3,3,8,8,3}
            };
            
            /* Для работы с многомерными массива есть специальные методы.
             * 
             * .Rank - выводит кол-во измерений массива
             * .GetLegth(измерение_массива) - выводит кол-во
             * элементов в указанном измерении
             */


             // Синтаксис вывода кол-ва измерений массива
             //     имя_массива.Rank;
            Console.WriteLine($"{testArray.Rank} - кол-во измерений в массиве");

            // Синтаксис вывода кол-ва элементов в указанном измерении
            //      имя_массива.GetLength(измерение_массива)
            Console.WriteLine($"{testArray.GetLength(0)} - кол-во элементов в измерении {0}");
            Console.WriteLine($"{testArray.GetLength(1)} - кол-во элементов в измерении {1}");

            // Вывод массива циклом ForEach
            Console.WriteLine("\n\nForEach");
            foreach (int i in testArray)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            // Вывод массива циклом For
            Console.WriteLine("\nFor 1");
            for (int i = 0; i < testArray.GetLength(0); i++)
            {
                for (int j = 0; j < testArray.GetLength(1); j++)
                {
                    Console.Write($"{testArray[i,j]}\t");
                }
                Console.WriteLine();
            }

            // Более понятное именование переменных для вывода массива,
            // позволяет мысленно лучше представлять структуру массива
            // и упращает работу в построении циклов для вывода массива,
            // однако подобная конструкция плодит лишние переменные,
            // засоряет как сам код так и память 
            int height = testArray.GetLength(0);
            int width = testArray.GetLength(1);

            Console.WriteLine("\nFor 2");
            for (int y = 0;y < height;y++)
            {
                for(int x = 0;x < width;x++)
                {
                    Console.Write($"{testArray[y, x]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
