using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

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

        /// <summary>
        /// Вывод массива с помощью рекурсии.
        /// </summary>
        /// <param name="arr">Массив</param>
        /// <param name="index"></param>
        static void RecursionPrintArray(int[] arr, int index = 0)
        {
            if (index < arr.Length)
            {
                Console.Write($"{arr[index]} ");
                RecursionPrintArray(arr, ++index);
            }
        }

        /// <summary>
        /// Подсчёт суммы элементов массива при помощи рекурсии
        /// </summary>
        /// <param name="arr">Массив</param>
        /// <param name="index"></param>
        /// <param name="result"></param>
        static int RecursionArraySum(int[] arr, int index = 0)
        {
            if (index >= arr.Length)
                return 0;

            return arr[index] + RecursionArraySum(arr, index + 1);
        }

        /// <summary>
        /// Расчёт суммы цифр числа при помощи рекурсии
        /// </summary>
        /// <param name="num">Число для расчёта суммы цифр</param>
        /// <param name="result"></param>
        static int RecursionDigitOfNumberSum(int num)
        {
            if (num < 10)
                return num;

            return (num % 10) + RecursionDigitOfNumberSum(num / 10);
        }



        static void Main(string[] args)
        {
            
        }
    }
}