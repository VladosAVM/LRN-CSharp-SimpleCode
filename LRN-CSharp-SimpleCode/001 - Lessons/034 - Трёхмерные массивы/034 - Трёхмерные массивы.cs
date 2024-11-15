using System;

/* Трёхмерные и более мерные массивы
 * 
 * Источник: https://www.youtube.com/watch?v=NLu9y4LKXQ0
 */

namespace _034___Трёхмерные_массивы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Трёхмерные массивы - трёхмерный массив можно представить как
             * тетрадь в которой есть листы расчерченные в клеточку.
             * Листы будут осью Z, а клеточки оси Y и X.
             * 
             * X ---------→
             * Y| \
             *  |  \
             *  |   \ Z
             *  |
             *  ↓
             * 
             * Синтаксис объявления трёхмерного прямоугольного массива:
             *      тип_данных[,,] имя_массива = new тип_данных[i,j,k];
             * 
             * Синтаксис размещения данных в трёхмерном прямоугольном массиве:
             *      имя_массива[i,j,k] = данные;
             * 
             * Визуальное представление трёхмерного прямоугольного массива:
             *      int[,,] testArray2 =
             *      { // array
             *         { // i
             *             {k,k,k,k,k}, // j
             *             {k,k,k,k,k}, // j
             *             {k,k,k,k,k}  // j
             *         },
             *         { // i
             *             {k,k,k,k,k}, // j
             *             {k,k,k,k,k}, // j
             *             {k,k,k,k,k}  // j
             *         }
             *      };
             */

            // Трёхмерный прямоугольный массив

            int[,,] testArray1 = new int[2, 3, 5];
            testArray1[0, 2, 1] = 74;

            int[,,] testArray2 =
            { // array
                { // i
                    {13,21,56,45,22}, // j,k
                    {45,32,67,71,16}, // j,k
                    {11,90,52,51,24}  // j,k
                },
                { // i
                    {32,51,18,16,21}, // j,k
                    {66,78,83,31,37}, // j,k
                    {36,74,84,38,83}  // j,k
                }
            };

            // Заполнение трёхмерного прямоугольного массива рандомными числами
            Random random = new Random();

            // Инициализация траёхмерного прямоугольного массива
            int[,,] testArray3 = new int[2, 3, 5];

            // Заполнение трёхмерного прямоугольного массива случайными числами от 20 до 100
            for (int i = 0; i < testArray3.GetLength(0); i++)
            {
                for (int j = 0; j < testArray3.GetLength(1); j++)
                {
                    for (int k = 0; k < testArray3.GetLength(2); k++)
                    {
                        testArray3[i, j, k] = random.Next(20, 100);
                    }
                }
            }

            Console.WriteLine("Вывод трёхмерного прямоугольного массива");
            // Вывод трёхмерного прямоугольного массива в консоль в виде таблицы
            for (int i = 0; i < testArray3.GetLength(0); i++)
            {
                Console.WriteLine($"Страница: {i + 1}");
                for (int j = 0; j < testArray3.GetLength(1); j++)
                {
                    for (int k = 0; k < testArray3.GetLength(2); k++)
                    {
                        Console.Write($"\t{testArray3[i, j, k]}");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }


            // Трёхмерный ступенчатый массив
            Console.WriteLine("\n\nВывод трёхмерного ступенчатого массива");

            // Инициализация турёхмерного ступенчатого массива случайными числами от 10 до 100
            int[][][] testArray4 = new int[random.Next(3,6)][][];

            // Инициализация и заполнение зубчатых массивов
            for (int i = 0; i < testArray4.Length; i++)
            {
                testArray4[i] = new int[random.Next(3, 6)][];

                for (int j = 0;j < testArray4[i].Length; j++)
                {
                    testArray4[i][j] = new int[random.Next(3, 6)];

                    for (int k = 0; k < testArray4[i][j].Length; k++)
                    {
                        testArray4[i][j][k] = random.Next(10, 100);
                    }
                }
            }

            // Вывод трёхмерного ступенчатого массива в консоль в виде таблицы
            for (int i = 0; i < testArray4.Length; i++)
            {
                Console.WriteLine($"Страница: {i + 1}");

                for (int j = 0; j < testArray4[i].Length; j++)
                {
                    for (int k = 0; k < testArray4[i][j].Length; k++)
                    {
                        Console.Write($"\t{testArray4[i][j][k]}");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
