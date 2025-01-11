using System;
using System.Runtime.InteropServices;

namespace _001___TEST
{
    internal class Program
    {
        /// <summary>
        /// <para>Вывод значений массива в консоль.</para>
        /// <para>Print array values in console.</para>
        /// </summary>
        /// <param name="arr">Массив значений для вывода в консоль.</param>
        static void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]} ");
        }
        /// <summary>
        /// Генератор одномерного массива со случаными значениями.
        /// </summary>
        /// <param name="arrayLength">Длинна массива</param>
        /// <param name="arrayMinVlue">Минимальное значение в мссиве</param>
        /// <param name="arrayMaxValue">Максимальное значение в массиве</param>
        /// <returns></returns>
        static int[] RandomArrayGenerator(int arrayLength, int arrayMinVlue, int arrayMaxValue)
        {
            Random random = new Random();
            int[] arr = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
                arr[i] = random.Next(arrayMinVlue, arrayMaxValue);

            return arr;
        }

        /// <summary>
        /// Сумма неограниченного числа переменных разного типа.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="parametrs"></param>
        /// <returns></returns>
        static T Sum<T>(params T[] parametrs)
        {
            dynamic sum = default(T);

            foreach (T t in parametrs)
                sum += t;

            return sum;
        }
        static void Main(string[] args)
        {
            int[] arr = RandomArrayGenerator(20, 10, 100);
            PrintArr(arr);
            Console.WriteLine();
            Console.WriteLine(Sum(3.1,4.1));
            Sum<int>();



        }
    }
}