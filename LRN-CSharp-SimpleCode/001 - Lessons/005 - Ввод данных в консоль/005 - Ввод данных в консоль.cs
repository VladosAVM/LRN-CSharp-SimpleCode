using System;

/*
 * Ввод данных в консоль
 * 
 * Источник: https://www.youtube.com/watch?v=Wp8hDQs3J4o
 */

namespace _005___Ввод_данных_в_консоль
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Получение данных из консоли
             * 
             * Для получения данных пользовательского ввода из консоли
             * необходимо объявить строковую переменную типа string
             * и присвоить ей метод ReadLine.
             * 
             * Синтаксис получения данных:
             * string имя_переменной = Console.ReadLine();
             */
            Console.WriteLine("Введите данные");
            string data = Console.ReadLine();
            Console.WriteLine(data);

            /* Модефицированный вывод полученных данных
             * 
             * Вывод полученных данных можно модифицировать множеством способов.
             * Как пример можно запросить имя пользователя
             * и поприветствовать его по указанному имени.
             * 
             * Пример:
             */
            Console.WriteLine("Введите ваше имя:");
            string userName = Console.ReadLine();
            Console.WriteLine("Привет " + userName);
        }
    }
}
