using System;

/* NULLABLE - null совместимые значимые типы
 * 
 * Источник: https://www.youtube.com/watch?v=jhz3Ltc09m4
 */

namespace _052___NULLABLE___null_совместимые_значимые_типы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* null можно использовать со значимыми типами данных, однако поведение
             * переменной будет отличаться от поведения ссылочных типов данных.
             * 
             * 
             * 1. Т.к. у значимых типов нет ссылки, то и null не будет удалять ссылку,
             * а будет просто говорить об отсутствии значения в переменной.
             * 
             * 2. После определения такой переменной у неё появляются 2-а дополнительных
             * поля и метод:
             *      .HasValue - проверяет наличие значения в переменной true\false
             *      .Value    - выдаёт значение которое присвоено переменной. Используется
             *                  в случае когда с переменной совершаются какието действия.
             *                  В случае если в переменной null, а вы пытаетесь напрямую оперировать
             *                  значением переменной то будет ошибка.
             *      .GetValueOrDefault() - выводит текущее значение или дефолтное если
             *                             текущее null, также дефолтное значение можно
             *                             задать самостоятельно
             */

            int? i = null;
            Console.WriteLine(i);                      // 
            Console.WriteLine(i == null);              // True
            Console.WriteLine(i.HasValue);             // False
            Console.WriteLine(i.GetValueOrDefault());  // 0
            Console.WriteLine(i.GetValueOrDefault(4)); // 4
            Console.WriteLine(i ?? 98);                // 98
            Console.WriteLine(i + 1);                  // 
            //Console.WriteLine(i.Value);              // InvalidOperationException
            i = 4;
            Console.WriteLine(i.HasValue);             // True
            Console.WriteLine(i.Value);                // Значение которое присвоено переменной

            /* При работе с nullable переменными стоит учитывать что они могут
             * оказать влияние на дальнейший код.
             * 
             * Например при осуществлении арефметических операций над двумя переменными одна из
             * котороых может быть nullable, стоит помнить и проверять переменную в которую будет
             * записан результат операции.
             * 
             * Пример:
             */

            int x = 7;
            int? y = null;

            // Выражение с Nullable переменной содержащей null - БЕЗ проверки
            int? result1 = x + y;
            Console.WriteLine(result1); // 
            Console.WriteLine(x == y); // false
            Console.WriteLine(x >= y); // false
            Console.WriteLine(x < y);  // false
            Console.WriteLine(x != y); // True


            // Выражение с Nullable переменной содержащей null - С проверкой
            int? result2 = x + y.GetValueOrDefault();
            Console.WriteLine(result2); // 7
            Console.WriteLine(x == y); // false
            Console.WriteLine(x >= y); // false
            Console.WriteLine(x < y);  // false
            Console.WriteLine(x != y); // True

            // Выражение с Nullable переменной содержащей значение - БЕЗ проверки
            y = 7;
            int? result3 = x + y;
            Console.WriteLine(result3); // 14
            Console.WriteLine(x == y); // true
            Console.WriteLine(x >= y); // true
            Console.WriteLine(x < y);  // false
            Console.WriteLine(x != y); // false
        }
    }
}
