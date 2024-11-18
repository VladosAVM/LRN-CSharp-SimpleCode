using System;

/* ?? - Оператор объединения с null
 * 
 * Источник: https://www.youtube.com/watch?v=mXh0ci6O6og
 */

namespace _040___Оператор_объединения_с_null
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ?? - данный оператор позволяет присвоить новое
             * дефолтное значение в переменные которые имеют
             * значение null.
             * 
             * Данный оператор позволяет избежать использования
             * конструкций типа if else для проверки и внесения
             * изменений в значение переменной.
             * Что позволяет сделать запись более краткой и понятной,
             * а также избежать создания дополнительных переменных.
             * 
             * Пример БЕЗ использования ??:
             *      string str = null;
             *      string result;
             *      Console.WriteLine(str ?? "Нет данных");
             *
             *      if (str == null)
             *          result = "Нет данных";
             *      else
             *          result= str;
             *
             *      Console.WriteLine(result);
             *      
             */

            // Пример с использованием ??:
            string str = null;
            string result = str ?? "Нет данных";
            Console.WriteLine(result);

            // Без создания дополнительной переменной result
            Console.WriteLine(str ?? "Нет данных");

            /* Также при помощи оператора ?? можно избегать
             * появления ошибок в ходе выполнения программы.
             * 
             * Предположим к нам в программу приходят какието
             * данные из-вне, и одними из таких данных будет null.
             * При попытке както обработать подобные данные,
             * с высокой долей вероятности мы получим ошибку
             * NullReferenceException.
             */

            // Пример:
            string testStr = null;
            string testStrResult = str ?? string.Empty;
            Console.WriteLine($"Длинна строки: {testStrResult.Length}"); // Без ошибки

            Console.WriteLine($"Длинна строки: {testStr.Length}"); // С ошибкой NullReferenceException
        }
    }
}
