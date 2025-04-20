using System;

namespace _001___TEST.Utils
{
    public static class ArrayGenerators
    {
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
    }
}
