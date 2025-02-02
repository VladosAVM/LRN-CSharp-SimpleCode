﻿using System;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Messaging;

/* Рекурсия - Переполнение стека - Стек вызовов
 * 
 * Источник: https://www.youtube.com/watch?v=B50p1BRyb_E
 */

namespace _049___Рекурсия___Переполнение_стека___Стек_вызовов
{
    internal class Program
    {
        static void Foo1()
        {
            Console.WriteLine("Foo");
            Foo1();
        }

        static void Foo2(int x)
        {
            Console.WriteLine(x); // Вывод x на консоль

            if (x >= 3) // точка выхода из рекурсии
                return;

            x++;
            Foo2(x); // Ркурсивный вызов
        }
        static void Main(string[] args)
        {
            /* Рекурсия - вызов метода самого себя.
             * 
             * Пример: 
             * static void Foo()
             * {
             *      Console.WriteLine("Foo");
             *      Foo();
             * }
             * 
             * Можно сказать что рекурсия аналогична бесконечному циклу,
             * однако рекурсия ограничена размером стека (около 1мб).
             * Если при создании рекурсивного метода не предусмотреть
             * условие выхода из рекурсии, тогда мы получим ошибку -
             * переполнение стека.
             * Также стоит учитывать что чем больше данных (переменных)
             * обрабатывается в методе, тем больше места в стеке будет занимать
             * методи тем меньше рекурсивных вызовов мы можем совершить.
             * 
             * Пример: 
             *      static void Foo2(int x)
             *      {
             *          Console.WriteLine(x); // Вывод x на консоль
             *
             *          if (x >= 3) // точка выхода из рекурсии
             *             return;
             *
             *              x++;
             *              Foo2(x); // Ркурсивный вызов
             *      }
             *      
             * 
             * 
             */

            // Пример вызова рекурсивного метода БЕЗ предусмотренного условия выхода из рекурсии,
            // что в конечном итоге приведёт к ошибке переполнения стека вызовов
            // Foo1(); 

            // Вызов рекурсивного метода с предусмотренным условием выхода из рекурсии
            Foo2(0);


        }
    }
}
