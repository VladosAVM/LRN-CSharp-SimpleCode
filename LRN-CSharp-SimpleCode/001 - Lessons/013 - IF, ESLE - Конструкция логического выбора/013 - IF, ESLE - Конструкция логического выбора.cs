using System;

/* IF, ESLE - Конструкция логического выбора
 * 
 * Источник: https://www.youtube.com/watch?v=qrPuaaVGEp4
 */

namespace _013___IF__ESLE__Конструкция_логического_выбора
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Конструкция if else позволяет организовывать
             * логику поведения программы, основываясь на
             * утверждениях или выражениях результатом которых
             * будет является булевая переменная со значение
             * true или false.
             * 
             * Синтаксис конструкции if else
             *      
             *      if (утверждение или выражение)
             *      {
             *          действие 1;
             *      }
             *      else
             *      {
             *          действие 2;
             *      }
             */

            // Пример кода с использованием утверждения
            bool isInfected = false;

            Console.WriteLine("Состояние персонажа:");
            if (isInfected)
            {
                Console.WriteLine("Вы инфицированны");
            }
            else
            {
                Console.WriteLine("Вы здоровы");
            }

            // Пример кода с использованием выражения
            
            Console.WriteLine("\n\n- - - Стрипуха 18+ - - -\n   Сколько вам лет?");
            int age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("Welcome to the club buddy...");
            }
            else
            {
                Console.WriteLine("ПОШЁЛ ВОН - СОСУНОК!!!");
            }

        }
    }
}
