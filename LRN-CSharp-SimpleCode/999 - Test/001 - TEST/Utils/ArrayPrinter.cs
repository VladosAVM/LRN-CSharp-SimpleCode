using System;

namespace _001___TEST.Utils
{
    public static class ArrayPrinter
    {
        /// <summary>
        /// <para>Вывод значений одномерного массива в консоль.</para>
        /// <para>Print 1D array values in console.</para>
        /// </summary>
        /// <param name="arr">Массив значений для вывода в консоль.</param>
        public static void PrintArr<T>(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]} ");
        }

        /// <summary>
        /// <para>Вывод значений двумерного массива в консоль.</para>
        /// <para>Print 2D array values in console.</para>
        /// </summary>
        /// <param name="arr">Массив значений для вывода в консоль.</param>
        public static void PrintArr<T>(T[,] arr)
        {
            for (int y = 0; y < arr.GetLength(0); y++)
            {
                for (int x = 0; x < arr.GetLength(1); x++)
                {
                    Console.Write($"{arr[y, x]}\t");
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// <para>Вывод значений двумерного зубчатого массива в консоль.</para>
        /// <para>Print 2D jagged array values in console.</para>
        /// </summary>
        /// <param name="arr">Массив значений для вывода в консоль.</param>
        public static void PrintArr<T>(T[][] arr)
        {
            for (int y = 0; y < arr.Length; y++)
            {
                for (int x = 0; x < arr[y].Length; x++)
                {
                    Console.Write($"{arr[y][x]}\t");
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// Вывод массива с помощью рекурсии.
        /// </summary>
        /// <param name="arr">Массив</param>
        /// <param name="index"></param>
        public static void RecursionPrintArray(int[] arr, int index = 0)
        {
            if (index < arr.Length)
            {
                Console.Write($"{arr[index]} ");
                RecursionPrintArray(arr, ++index);
            }
        }
    }
}
