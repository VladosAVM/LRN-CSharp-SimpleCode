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
             * Ступенчатые массивы отличаются от прямоугольных тем что
             * в каждом элемента массива можнет содержаться разное количество
             * элементов.
             * 
             * Пример: 
             *      {1,2,3},
             *      {1,2},
             *      {1,2,3,4},
             *      {1,2}
             * 
             * Синтаксис инициализации ступенчатого массива:
             *      тип_данных[][] имя_массива = new int[количество_элементов_основного_массива][];
             */

            // Инициализация зубчатого массива
            int[][] testArray = new int[4][];

            // Заполнение зубачтого массива и массивов
            // внутри него, темиже данными, что в примере выше
            testArray[0] = new int[3]; // {1,2,3},
                testArray[0][0] = 1;
                testArray[0][1] = 2;
                testArray[0][2] = 3;
            testArray[1] = new int[2]; // {1,2},
                testArray[1][0] = 1;
                testArray[1][1] = 2;
            testArray[2] = new int[4]; // {1,2,3,4},
                testArray[2][0] = 1;
                testArray[2][1] = 2;
                testArray[2][2] = 3;
                testArray[2][3] = 4;
            testArray[3] = new int[2]; // {1,2}
                testArray[3][0] = 1;
                testArray[3][1] = 2;

            // Вывод ступенчатого массива в консоль
            Console.WriteLine("Массив заполненный вручную");
            for (int i = 0; i < testArray.Length; i++)
            {
                for (int j = 0; j < testArray[i].Length; j++)
                {
                    Console.Write($"{testArray[i][j]}\t");
                }
                Console.WriteLine();
            }

            // Заполнение ступеньчатого массива случайными числами

            Random random = new Random();

            for (int i = 0; i < testArray.Length; i++)
            {
                for (int j = 0; j < testArray[i].Length; j++)
                {
                    testArray[i][j] = random.Next(10, 100);
                }
                Console.WriteLine();
            }

            // Вывод ступенчатого массива в консоль
            Console.WriteLine("Массив заполненный случайными числами");
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
