using System;
using System.Linq;

/* Работа с массивами в реальных проектах - Примеры
 * 
 * Источник: https://www.youtube.com/watch?v=NuSiv5Dq6gY
 */

namespace _027___Работа_с_массивами_в_реальных_проектах___Примеры
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* В предидущих уроках была показана работа с массивами
             * в ручном режиме. Внесение данных, вывод данных и т.д.
             * были реализованны через циклы.
             * Однако в реальных проектах так делать не стоит по
             * причине большого объёма создаваемого кода и высокой
             * вероятности наличия ошибок.
             * 
             * В C# есть готовые инструменты для работы с массивами,
             * которые имеют более краткую и лаконичную запись и
             * исключают ошибки при написании обработчиков массивов.
             * 
             * Массивы в C# являются наследниками класса Array,
             * в следствии чего разработчик может использовать
             * статические методы для взаимодействия с массивом.
             *
             * Ниже по коду будут приведены некоторые примеры
             * работы с массивами c использованием готовых библиотек.
             */

            // LinQ

            int[] testArray = { 25, 44, 18, 92, 44, 79, 63, 31 };
            int result;
            int[] resultArray;

            result = testArray.Min(); // Минимальное значение в массиве
            Console.WriteLine($"Минимальное значение = {result}");
            result = testArray.Max(); // Максимальное значение в массиве
            Console.WriteLine($"Максимальное значение = {result}");

            result = testArray.Sum(); // Сумма всех элементов массива
            Console.WriteLine($"Сумма всех элементов = {result}");
            result = testArray.Where(x => x % 2 == 0).Sum(); // Сумма всех 4ётных элементов массива
            Console.WriteLine($"Сумма всех чётных элементов = {result}");
            result = testArray.Where(x => x % 2 != 0).Min(); // Самое маленькое не чётное число в массиве
            Console.WriteLine($"Самое маленькое не чтное число = {result}");

            // Поиск всех уникальных(не повторяющихся) элементов в массиве
            Console.WriteLine("\nВытягивание уникальных элементов из testArray в resultArray");
            resultArray = testArray.Distinct().ToArray();
            for (int i = 0; i < resultArray.Length; i++)
                Console.Write($" {resultArray[i]}");

            // Сортировка массива в порядке возростания
            Console.WriteLine("\nСортировка массива в порядке возростания");
            resultArray = testArray.OrderBy(x => x).ToArray();
            for (int i = 0; i < resultArray.Length; i++)
                Console.Write($" {resultArray[i]}");

            // Сортировка массива в порядке убывания
            Console.WriteLine("\nСортировка массива в порядке убывания");
            resultArray = testArray.OrderByDescending(x => x).ToArray();
            for (int i = 0; i < resultArray.Length; i++)
                Console.Write($" {resultArray[i]}");

            // Поиск первого элемента в массиве с условием что он меньше 70
            result = testArray.Where(x => x < 70).First();
            Console.WriteLine($"\n\nПервый элемент который меньше 70 = {result}");

            // Поиск первого элемента в массиве с условием что он меньше 0
            // или возврат базового значения если элемент отсутствует в массиве
            result = testArray.Where(x => x < 0).FirstOrDefault();
            Console.WriteLine($"\n\nПервый элемент который меньше 0 = {result}");

            // Поиск всех чисел в массиве которые меньше 70 и сохранение их в новый массив
            Console.WriteLine("\nПоиск всех чисел меньше 70");
            resultArray = testArray.Where(x => x < 70).ToArray();
            for (int i = 0; i < resultArray.Length; i++)
                Console.Write($" {resultArray[i]}");


            // Array class
            Array.Sort(testArray); // Сортировка массива в порядке возростания
            Array.Reverse(testArray); // Сортировка элементов в обратном порядке

            result = Array.Find(testArray, x => x < 70); // Поиск первого элемента который меньше 70
            result = Array.FindLast(testArray, x => x < 70); // Поиск первого элемента который меньше 70
                                                             // с конца массива

            resultArray = Array.FindAll(testArray, x => x < 70); // Поиск амех элементов удовлетворяющим
                                                                 // условию поиска

            result = Array.FindIndex(testArray, x => x == 79); // Поиск индекса значения в условии поиска
            
        }
    }
}
