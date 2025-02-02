using System;

/* ENUM
 * 
 * Источник: https://www.youtube.com/watch?v=lBUFlJbNq-Q
 */

namespace _054___ENUM
{
    internal class Program
    {
        /// <summary>
        /// enum дней недели
        /// </summary>
        enum DayOfWeek : byte
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }


        /// <summary>
        /// enum цветов
        /// </summary>
        enum Colors
        {
            White,
            Red,
            Green,
            Blue,
            Orange
        }


        /// <summary>
        /// // Обычная версия с передачей аргумента
        /// </summary>
        /// <param name="enumType"></param>
        static void PrintEnum(Type enumType)
        {
            if (!enumType.IsEnum)
            {
                Console.WriteLine($"При вызове метода 'PrintEnum', возникла ошибка\n" +
                                  $"{enumType} не является enum\n" +
                                  $"Тип {enumType} = {enumType.GetType()}");
                return;
            }
            
            var values = Enum.GetValues((enumType));

            for (var i = 0; i < values.Length; i++)
            {
                if (i < values.Length - 1)
                    Console.Write($"{values.GetValue(i)}, ");
                else
                    Console.Write($"{values.GetValue(i)}.");
            }

            // Сокращённый вариант для перебора значений enum для
            // вывода на консоль с использование тернарного оператора
            /*
            for (var i = 0; i < values.Length; i++)
                Console.Write($"{values.GetValue(i)}{(i < values.Length - 1 ? ", " : ".")}");
            */

            Console.WriteLine();
        }


        /// <summary>
        /// Вывод всех значений enum в консоль - Дженерик версия принимающая в качестве аргумента только enum
        /// </summary>
        /// <typeparam name="T"></typeparam>
        static void PrintEnum<T>() where T : Enum        
        {
            var values = Enum.GetValues(typeof(T));           

            for (var i = 0; i < values.Length; i++)
            {
                if (i < values.Length - 1)
                    Console.Write($"{values.GetValue(i)}, ");
                else
                    Console.Write($"{values.GetValue(i)}.");
            }

            // Сокращённый вариант для перебора значений enum для
            // вывода на консоль с использование тернарного оператора
            /*
            for (var i = 0; i < values.Length; i++)
                Console.Write($"{values.GetValue(i)}{(i < values.Length - 1 ? ", " : ".")}");
            */

            Console.WriteLine();
        }


        /// <summary>
        /// Получение следующего дня недели
        /// </summary>
        /// <param name="day"></param>
        /// <returns></returns>
        static DayOfWeek GetNextDay(DayOfWeek day)
        {
            if (day < DayOfWeek.Sunday)
                return day + 1;

            return DayOfWeek.Monday;
        }




        static void Main(string[] args)
        {
            // ENUM это структура содержащая в себе понятное человеку представление числовых значений.

            Console.WriteLine("ESC - Выход из цыкла");
            ConsoleKey key = Console.ReadKey(intercept: true).Key;
            while (key != ConsoleKey.Escape)
            {
                int keyCode = (int)key;
                Console.WriteLine($"Enum {key}\t|\tKey Code {keyCode}");
                if (key == ConsoleKey.Enter)
                {
                    Console.WriteLine("ПЫЩ - Enter!!!");
                }
                switch (key)
                {
                    case ConsoleKey.Spacebar:
                        Console.WriteLine("Oh my god - this is Jason Born !!!");
                        break;
                }
                key = Console.ReadKey(intercept: true).Key;
            }
            Console.WriteLine("\n\n-------------------------------\n\n");

            // enum позволяет самостоятельно создавать структуры буквенных значений
            // и присваивать им числовые значения.
            //
            // В enum структуре можно определять тип данных для числового представления
            // и задавать значение вручную.
            // По умолчанию enum использует тип данных int, а все поля enum будут пронумерованны
            // по порядку начиная с 0, но если изменить значение первого поля, а остальные
            // оставить по умолчанию, то автоматическая нумерация будет продолжена с числа
            // указанного в первом поле.

            // Пример: dayOfWeek
            //    enum dayOfWeek : byte
            //      {
            //          Monday = 1,
            //          Tuesday,
            //          Wednesday,
            //          Thursday,
            //          Friday,
            //          Saturday,
            //          Sunday
            //      }

            DayOfWeek dayOfWeek = DayOfWeek.Friday;
            Console.WriteLine(Enum.GetUnderlyingType(typeof(DayOfWeek))); // Вывод типа данных используемом в enum
            Console.WriteLine(dayOfWeek);
            Console.WriteLine((int)dayOfWeek); // Приведение типа DayOfWeek к int
            Console.WriteLine((DayOfWeek)3);   // Приведение типа int к DayOfWeek

            dayOfWeek = DayOfWeek.Sunday;              // Присвоение: Воскресенье
            DayOfWeek nextDay = GetNextDay(dayOfWeek); // Получение следующего дня недели
            Console.WriteLine(nextDay);                // Вывод: Понедельник

            Console.WriteLine("\n\n-------------------------------\n\n");
            // При попытке обращения к enum DayOfWeek со значением которого нет в полях,
            // мы сломаем всю логику и не получим какого-то вменяемого ответа.
            // Такое может происходит при получении данных из-вне.
            // Для решения данной проблемы можно использовать метод IsDefiend, который
            // проверит наличие соответствующего элемента в enum и возвращает true или false.

            int value = 55;

            try
            {
                if (Enum.IsDefined(typeof(DayOfWeek), (byte)value))
                    dayOfWeek = (DayOfWeek)value;
                else
                    throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine($"Ошибочное значение переменной value = {value}");
            }
            Console.WriteLine("\n\n-------------------------------\n\n");

            // Получение информации о всех доступных значениях в enum
            var values = Enum.GetValues(typeof(Colors));

            foreach (var item in values)
                Console.WriteLine(item);

            Console.WriteLine("\n\n-------------------------------\n\n");

            // Парсинг значений в enum
            // Парсинг enum работает идентично методу int.Parse() который был разобран в начале курса.
            // Метод Enum.Parse() принимает в качестве аргументов:
            //      1. Тип Enum
            //      2. Строку с данными которые необходимо найти
            //      3. Модификатор включения/отключения учёта регистра значений данных

            
            Console.WriteLine($"Список доуступных цветов:");

            //PrintEnum<Colors>(); // Дженерик версия принимающая только enum
            PrintEnum(typeof(Colors)); // Обычная версия с передачей аргумента

            Console.WriteLine($"Введите цвет для поиска в enum: ");
            string str = Console.ReadLine();
            Colors color = (Colors)Enum.Parse(typeof(Colors), str, ignoreCase: true);
            Console.WriteLine(color);

            // Также у Enum есть метод TryParse который работает аналогично методу int.TryParse()


        }
    }
}
