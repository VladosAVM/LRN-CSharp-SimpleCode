using System;
/* Индексы и диапазоны в C#8
 * 
 * Источник: https://www.youtube.com/watch?v=SqP_osnZJqo
 */

namespace _028___Индексы_и_диапазоны
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Фичи и синтаксический сахар обавленный в C# 8
             * 
             * INFO: Результаты работы смотрите в дебаге
             */
            int[] testArray = { 2, 10, 5, 6, 77, 89 };
            int[] outputArray;

            // Вывод последнего элемента массива
            // Старый формат
            Console.WriteLine(testArray[testArray.Length - 1]);
            // Новый формат
            Console.WriteLine(testArray[^1]);


            // Извлечение диапазона значений из массива
            // последний элемент НЕ извлекается
            outputArray = testArray[1..4]; // 1 по 4
            outputArray = testArray[..4]; // с 0 по 4
            outputArray = testArray[2..]; // со 2 по последний
            outputArray = testArray[^4..^2]; // с 4 с конца по 2 с конца
            outputArray = testArray[^4..6]; // с 4 с конца по 5 с начала

            string testStr = "C# - is blowing my mind";
            Console.WriteLine(testStr[5..]);
        }
    }
}
