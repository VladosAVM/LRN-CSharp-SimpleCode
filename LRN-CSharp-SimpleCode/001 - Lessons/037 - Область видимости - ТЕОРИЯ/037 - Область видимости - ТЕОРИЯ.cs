﻿using System;

/* Область видимости (контекст) переменных - ТЕОРИЯ
 * 
 * Источник: https://www.youtube.com/watch?v=FyCp19W_5d8
 */

namespace _037___Область_видимости___ТЕОРИЯ
{
    internal class Program
    {
        int a = 9;        // Переменная объявленна БЕЗ использования модификатора STATIC
        static int b = 9; // Переменная объявленна С использованием модификатора STATIC

        static void Test1()
        {
            int b = 4;
            Console.WriteLine(b); // 4
        }
        static void Test2()
        {
            Console.WriteLine(b); // 9
        }
        static void Main(string[] args)
        {
            /* Область видимости (контекст) переменных определяется
             * границами фигурных скобок в которых они находятся.
             * 
             * Переменные объявленные внутри какого-нибудь конекста
             * будут доступны внутри текущего и вложенного контекста
             * и НЕ доступны внутри внешнего контекста.
             * 
             * Пример: 
             *      { a = 9;           // Переменная НЕ доступная
             *           { int a;      // Переменная Объявленна
             *              {
             *                   a = 4 // Переменная Доступна
             *              }
             *          }
             *      }
             * 
             * Также на область видимости переменных влияет модификатор "static".
             * Если мы будем объявлять переменну внутри класса, но при этом
             * не укажем модификатор static, то мы не сможем обратиттся к этой
             * переменной внутри методов которые заявлены как статические.
             * 
             * Для того чтобы получить доступ к такой переменной нам необходимо
             * сделать её статической или создать экземпляр класса и обратится
             * к переменной через этот экземпляр.
             * 
             * Пример: 
             *      class Program
             *      {
             *          int a = 9;        // Переменная объявленна
             *          static int b = 9; // Переменная объявленна
             *          
             *          static void Main(string[] args)
             *          {
             *              a = 4;          // Переменная НЕ доступна
             *              
             *              Program program = new Program(); // Создание экземпляра класса Program
             *              program.a = 4; // Переменная доступна
             *              
             *              b = 4;         // Переменная доступна
             *          }
             *      }
             */

            a = 4;          // Переменная НЕ доступна

            Program program = new Program(); // Создание экземпляра класса Program
            program.a = 4; // Переменная доступна
            b = 4;         // Переменная доступна

            /* При объявлении статических переменных в контексте класса надо быть
             * осторожным, т.к. может возникнуть конфликт переменных в классе с
             * переменными внутри методов, если они имеют одно и тоже имя.
             * 
             * Пример: 
             *      class Program
             *      {
             *          static int b = 9; // Переменная объявленна
             *          
             *          static void Test()
             *          {
             *              int b = 4;   // Переменная объявленна
             *              Console.WriteLine(a); ?? Значение какой переменной
             *                                       будет выведено в консоль?
             *          }
             *      } 
             * 
             * В примере выше на консоль будет выведено значение переменной
             * объявленной внутри метода, т.е. 4
             * Если мы удалим объявление данной переменной внутри метода и
             * оставим объявление только внутри контекста класса, то
             * переменная по прежнему будет доступна, а выводимое значение
             * изменится на 9.
             */
        }
    }
}
