﻿using System;

/* Арифметическое переполнение - Checked Unchecked
 * 
 * Источник: https://www.youtube.com/watch?v=bRwsKSLAgYw
 */

namespace _051___Арифметическое_переполнение___Checked_Unchecked
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Арифметическое переполнение это выход за границы максимального
             * или минимального значения переменной после проведения
             * арефметической операции.  
             * 
             * Например если взять переменную типа byte со значением равным 0
             * и вычисть из неё 1, то мы получим выход за границы минимального
             * значения переменной что приведёт к тому что в результате
             * вычеслений в переменной будет значение 255.
             * 
             * Тоже правило применимо и к другим типам данных.
             * 
             * Особенно необходимо быть внимательным при Явном приведении
             * типов, т.к. в этот момент мы будем пытаться поместить в переменную
             * результат арефметической операции который может быть больше границ
             * конечной переменной и это приведёт не только к потери данных, но и
             * к арефметическому переполнению.
             * 
             * !!! ВНИМАНИЕ !!! 
             *      При выполнении арефметических операций над переменными типа
             *      byte, sbyte, short, ushort - все операнды автоматически
             *      приводятся к типу int.
             */

            // Пример:
            byte a = 1;
            byte b = 200;
            byte result = (byte)(a - b);
            Console.WriteLine(result); // 57

            /* Причины автоматического приведения типов маньше int к int.
             * 
             * 1. Унификация и упрощение вычислений
             * Процессоры большинства архитектур оптимизированы для работы с
             * данными разрядностью, кратной 32 битам. Для улучшения производительности
             * и упрощения реализации арифметики на уровне языка, C# автоматически
             * переводит все меньшие типы в int (32 бита) перед выполнением операций.
             * Это избавляет компилятор от необходимости генерировать сложный код для
             * работы с короткими типами.
             * 
             * 2. Стандарт языка
             * C# следует стандарту CLS (Common Language Specification) в .NET.
             * Этот стандарт требует, чтобы операции с меньшими типами производились
             * на более универсальном типе, таком как int, для обеспечения совместимости
             * между различными языками платформы .NET.
             * 
             * 3. Отсутствие дополнительных перегрузок
             * В C# арифметические операторы (+, -, *, /) перегружены только для
             * типов int, long, float, double, а не для меньших типов.
             * Это упрощает реализацию компилятора, поскольку операции с короткими
             * типами преобразуются в уже существующие операции с int.
             */

            // Также переполнение разделяют на 2 типа:
            //      1. Переполнение через верхнюю границу
            //      2. Переполнение через нижнюю границу

            int intMax = int.MaxValue;
            intMax += 1;
            Console.WriteLine(intMax);

            int intMin = int.MinValue;
            intMin -= 1;
            Console.WriteLine(intMin);

            /* Борьба с арефметическим переполнением.
             * 1. Проверку на арефметическое переполнение можно установить
             * на уровне всего проекта.
             *      Зайти в настройки проекта
             *      Пункт Build
             *      Зайти в Advanced...
             *      Установить чек-бокс на "Check for arithmetic overflow/underflow"
             * В случае если при арефметических операциях произойдёт переполнене то
             * будет выброшена ошибка System.OverflowException
             * 
             * !!! ВНИМАНИЕ !!!
             *      Включение проверки переполнения на уровне всего проекта,
             *      замедляет работу программы.
             *      
             * 2. Проверка на переполнение может проводится непосредственно в момент
             * вычисления при помощи ключевого слова checked.
             */

            // checked в момент вычисления
            try
            {
                result = checked((byte)(a - b)); // OverflowException
            }
            catch (OverflowException)
            {
                Console.WriteLine($"\nresult = checked((byte)(a - b)); // OverflowException");
            }


            // cheked для множества операций
            try
            {
                checked
                {
                    result = ((byte)(a - b));        // OverflowException
                    result = ((byte)(a - b * 1000)); // OverflowException
                    result = ((byte)(a - b + 900));  // OverflowException
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine($"\nchecked\n" +
                                  $"{{\n" +
                                  $"    result = ((byte)(a - b));        // OverflowException\n" +
                                  $"    result = ((byte)(a - b * 1000)); // OverflowException\n" +
                                  $"    result = ((byte)(a - b + 900));  // OverflowException\n" +
                                  $"}}");
            }


            // Если на уровне всего проекта включена проверка на переполнение,
            // то её можно выключить локально при помощи ключевого слова uncheked

            // отключение проверки в момент вычисления
            result = unchecked((byte)(a - b)); // 57

            // отключение проверки для множества операций
            unchecked
            {
                result = ((byte)(a - b)); // 57
                result = ((byte)(a - b * 1000)); // 193
                result = ((byte)(a - b + 900)); // 189
            }
            Console.WriteLine("---------------------------------------------------------");

            /* Дробные типы данных типа double и float не вызывают ошибку при переполнении
             * однако они принимают необычные значения:
             * 
             * Infinity - Бесконечность
             *      NaN - Не число
             */
            double c = 1.0 / 0.0;
            Console.WriteLine(c);                    // ?
            Console.WriteLine(double.IsInfinity(c)); // true

            double d = 0.0 / 0.0;
            Console.WriteLine(d);               // NaN
            Console.WriteLine(double.IsNaN(d)); // true

            double e = double.MaxValue + double.MaxValue;
            Console.WriteLine(e);                    //?
            Console.WriteLine(double.IsInfinity(c)); // true

            // Тип данных decimal при переполнении ВСЕГДА вызывает исключение
            // не зависимо от того установлен флаг проверки на переполнение или нет.

            decimal f = decimal.MaxValue;
            decimal g = decimal.MaxValue;
            decimal h = unchecked(f + g); // OverflowException
        }
    }
}
