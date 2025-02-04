using System;
using System.Reflection;


/* Модификаторы доступа Public и Private
 * 
 * Источник: https://www.youtube.com/watch?v=hGJ6aq5SGSU
 */

namespace _057___Public_и_Private_модификаторы_доступа
{
    class Point
    {
        public int x = 1;   // Поле доступно везде
        private int y = 8;  // Поле доступно только внутри класса

        int z = 4;          // Private (по умолчанию) - поле доступно только внутри класса.
                            // Если не указан модификатор доступа, то
                            // по умолчанию устанавливается модификатор Private

        private void PrintX() { Console.WriteLine($"X = {x}"); } // Метод доступен только внутри класса

        public void PrintY() { Console.WriteLine($"Y = {y}"); } // Метод доступен везде

        public void PrintPoint() // Метод доступен везде
        {
            PrintX();
            PrintY();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /* Public - делает поле и метод доступными для
             * обращения и вызова на всех уровнях.
             * 
             * Privite - делает поле и метод доступными для
             * обращения и вызова только внутри класса.
             */

            Point point = new Point(); // Создание экземпляра класса

            point.x = 2;        // Обращение к Public полю x
            //point.PrintX();   // НЕВОЗМОЖНО - вызов Private метода который выводит значение Public поля

            //point.y = 9;  // НЕВОЗМОЖНО - обращение к Private полю y
            point.PrintY(); // Вызов Public метода который выводит значение Private поля

            point.PrintPoint(); // Вызов Public метода PrintPoint который делает следующее:
                                //      1. Вызывает Private метод PrintX();
                                //      2. Вызывает Public метод PrintY();
                                //
                                // Вызов Private мтода PrintX возможен т.к. сам PrintPoint находится
                                // внутри области видимости класса Point, следовательно все поля и методы
                                // с модификатором Private для него доступны.
            
            // Получения информации о модификаторах доступа полей класса
            var typeInfo = typeof(Point).
                GetFields(BindingFlags.Instance |
                BindingFlags.NonPublic |
                BindingFlags.Public);

            foreach (var item in typeInfo)
            {
                Console.WriteLine($"{item.Name} - IsPrivate: {item.IsPrivate}\t IsPublic: {item.IsPublic}");
            }
        }
    }
}
