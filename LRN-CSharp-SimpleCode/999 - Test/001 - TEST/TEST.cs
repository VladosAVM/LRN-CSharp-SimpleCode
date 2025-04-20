using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _001___TEST
{
    internal class Program
    {

        /// <summary>
        /// <para>Вывод значений одномерного массива в консоль.</para>
        /// <para>Print 1D array values in console.</para>
        /// </summary>
        /// <param name="arr">Массив значений для вывода в консоль.</param>
        static void PrintArr<T>(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]} ");
        }

        /// <summary>
        /// <para>Вывод значений двумерного массива в консоль.</para>
        /// <para>Print 2D array values in console.</para>
        /// </summary>
        /// <param name="arr">Массив значений для вывода в консоль.</param>
        static void PrintArr<T>(T[,] arr)
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
        static void PrintArr<T>(T[][] arr)
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
        /// Подсчёт суммы элементов массива при помощи рекурсии.
        /// </summary>
        /// <param name="arr">Массив</param>
        /// <param name="index"></param>
        /// <param name="result"></param>
        static int RecursionArraySum(int[] arr, int index = 0)
        {
            // Точка выхода из рекурсии
            if (index >= arr.Length)
                return 0;

            // Ркурсионный вызов с подсчётом суммы при выоде из рекурсии
            return arr[index] + RecursionArraySum(arr, index + 1);
        }

        /// <summary>
        /// Расчёт суммы цифр числа при помощи рекурсии.
        /// </summary>
        /// <param name="num">Число для расчёта суммы цифр</param>
        /// <param name="result"></param>
        static int RecursionDigitOfNumberSum(int num)
        {
            if (num < 10)
                return num;

            return (num % 10) + RecursionDigitOfNumberSum(num / 10);
        }

        /// <summary>
        /// Добавляет новые данные в новую строку в двумерном массиве типа string.
        /// </summary>
        /// <param name="arr"></param>
        static void AddNewData2DArray(ref string[,] arr)
        {
            // Добавление строки
            AddNewLine2DArray(ref arr);

            // Добавление данных в пустые ячейки новой строки
            for (int x = 0; x < arr.GetLength(1); x++)
                arr[arr.GetLength(0) - 1, x] = Console.ReadLine();
        }


        // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        // !!!                          НЕ ПОНИМАЮ КАК РАБОТАЕТ - Func<string, T> converter                          !!!
        // !!!                                                                                                       !!!
        // !!! вызов метода - AddNewData2DArray(ref arr, input => int.TryParse(input, out int result) ? result : 0); !!!
        // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        /// <summary>
        /// Добавляет новые данные в новую строку в двумерном массиве с любым типом данных.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <param name="converter"></param>
        static void AddNewData2DArray<T>(ref T[,] arr, Func<string, T> converter)
        {
            AddNewLine2DArray(ref arr);

            for (int x = 0; x < arr.GetLength(1); x++)
                arr[arr.GetLength(0) - 1, x] = converter(Console.ReadLine());
        }
        // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!


        /// <summary>
        /// Добавляет новую строку в двумерных массив с любым типом данных.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        static void AddNewLine2DArray<T>(ref T[,] arr)
        {
            // Добавление строки
            T[,] newArr = new T[arr.GetLength(0) + 1, arr.GetLength(1)];

            // Копирование старого массива
            for (int y = 0; y < arr.GetLength(0); y++)
                for (int x = 0; x < arr.GetLength(1); x++)
                    newArr[y, x] = arr[y, x];

            // Присвоение сcылки нового массива в старую переменную
            arr = newArr;
        }
        static void ASD(ref int? x)
        {

        }

        enum SkinColors
        {
            White,
            Black,
            Yellow
        }

        static void Main(string[] args)
        {
            Test test = new Test();
            test.TestTest();

        }
    }

    class Test
    {
        public Test()
        {
            _x = 30;
            Console.WriteLine(_x);
        }

        int _x = 10;

        public void TestTest()
        {
            Console.WriteLine(_x);
            _x = 20;
            Console.WriteLine(_x);
        }
    }
}