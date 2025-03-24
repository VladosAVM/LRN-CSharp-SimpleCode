using System;

/* Индексы и диапазоны в "C# 8"
 * 
 * Источник: https://www.youtube.com/watch?v=SqP_osnZJqo
 */

namespace _028___Индексы_и_диапазоны
{
    internal class Program
    {
        static void printArr(int[] arr)
        {
            foreach (var item in arr)
                Console.Write($"{item} ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            // Фичи и синтаксический сахар добавленный в C# 8

            int[] testArray = { 2, 10, 5, 6, 77, 89 };
            
            // Вывод последнего элемента массива
            Console.WriteLine(testArray[testArray.Length - 1]); // Старый формат
            Console.WriteLine(testArray[^1]);                   // Новый формат

            // Извлечение диапазона значений из массива
            Console.Write("printArr(testArray[1..4]; // с 1 по 4) - ");
            printArr(testArray[1..4]); // с 1 по 4

            Console.Write("printArr(testArray[2..]); // со 2 по последний - ");
            printArr(testArray[2..]); // со 2 по последний

            Console.Write("printArr(testArray[^4..^2]); // с 4 с конца по 2 с конца - ");
            printArr(testArray[^4..^2]); // с 4 с конца по 2 с конца
            
            Console.Write("printArr(testArray[^4..6]); // с 4 с конца по 5 с начала - ");
            printArr(testArray[^4..6]); // с 4 с конца по 5 с начала
            

            // Сортировка массива в порядке возростания и
            // вывод в консоль значений массива с 1-го индекса по 3-ий (включительно)
            printArr(testArray.OrderBy(x => x).ToArray()[1..4]);

            // Вывод строки с указанного индекса
            // Т.к. строки в C# являются массивом "чаров",
            // с ними можно работать как с массивами.
            string testStr = "C# - is blowing my mind";
            Console.WriteLine(testStr[5..]);
        }
    }
}
