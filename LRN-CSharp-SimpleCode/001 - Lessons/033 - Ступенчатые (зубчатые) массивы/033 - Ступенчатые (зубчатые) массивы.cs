using System;

/* Ступенчатые (зубчатые) массивы
 * 
 * Источник: https://www.youtube.com/watch?v=SHMP_gsqWRQ
 */

namespace _033___Ступенчатые__зубчатые__массивы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ступенчатые (зубчатые) массивы это массив массивов.
             * 
             * Ступенчатый массив состоит из одномерных массивов
             * находящихся внутри другого одномерного массива.
             * 
             * Пример: 
             *      {1,2,3,4,5},
             *      {1,2,3,4},
             *      {1,2,3},
             *      {1,2,3,4,5,6,7}
             * 
             * Синтаксис инициализации ступенчатого массива:
             *      тип_данных[][] имя_массива = new int[количество_элементов_основного_массива][];
             */

            Random random = new Random();

            int[][] testArray = new int[4][];
            testArray[0] = new int[5];
            testArray[1] = new int[4];
            testArray[2] = new int[3];
            testArray[3] = new int[7];

            // Заполнение ступеньчатого массива случайными числами
            for (int i = 0; i < testArray.Length; i++)
            {
                for (int j = 0; j < testArray[i].Length; j++)
                {
                    testArray[i][j] = random.Next(10, 100);
                }
                Console.WriteLine();
            }

            // Вывод ступенчатого массива в консоль
            for (int i = 0; i < testArray.Length; i++) 
            { 
                for (int j = 0; j < testArray[i].Length; j++)
                {
                    Console.Write($"{testArray[i][j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
