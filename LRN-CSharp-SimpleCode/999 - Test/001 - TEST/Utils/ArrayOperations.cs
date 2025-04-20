using System;

namespace _001___TEST.Utils
{
    public static class ArrayOperations
    {
        /// <summary>
        /// Подсчёт суммы элементов массива при помощи рекурсии.
        /// </summary>
        /// <param name="arr">Массив</param>
        /// <param name="index"></param>
        /// <param name="result"></param>
        public static int RecursionArraySum(int[] arr, int index = 0)
        {
            // Точка выхода из рекурсии
            if (index >= arr.Length)
                return 0;

            // Ркурсионный вызов с подсчётом суммы при выоде из рекурсии
            return arr[index] + RecursionArraySum(arr, index + 1);
        }

        /// <summary>
        /// Добавляет новые данные в новую строку в двумерном массиве типа string.
        /// </summary>
        /// <param name="arr"></param>
        public static void AddNewData2DArray(ref string[,] arr)
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
        public static void AddNewData2DArray<T>(ref T[,] arr, Func<string, T> converter)
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
        public static void AddNewLine2DArray<T>(ref T[,] arr)
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
    }
}
