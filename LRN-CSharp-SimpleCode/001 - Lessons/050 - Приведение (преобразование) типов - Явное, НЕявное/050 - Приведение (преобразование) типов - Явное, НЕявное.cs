using System;

/* Приведение (преобразование) типов - Явное, НЕявное
 * 
 * Источник: https://www.youtube.com/watch?v=cfoec_hRfPU
 */

namespace _050___Приведение__преобразование__типов___Явное__НЕявное
{
    internal class Program
    {
        static void Test(float value)
        {
        }
        static void Main(string[] args)
        {
            /* Приведение типов - процесс конвертации объекта одного типа данных в другой
             * 
             * Явное приведение   - Explicit
             * НЕявное приведение - Implicit
             * 
             * Явное преобразование - это когда разработчик вручную конвертирует данные из
             * одного типа в другой.
             * НЕявное преобразование - это когда конвертация проихсодит БЕЗ указания типа
             * данных для конвертации переменной.
             * 
             * !!! ВНИМАНИЕ !!! - ПОТЕРЯ ДАННЫХ
             * При приведение типа переменной с бОльшим значением к типу с меньшим
             * возможна потеря данных.
             * 
             */

            // НЕявное преобразование
            int a = 5;
            Test(a);     // int --> float
            float b = a; // int --> float

            // Явное преобразование
            double c = 5.3;
            //float d = c;      // !!! ОШИБКА !!! int --> double
                                // НЕявное преобразование невозможно, поэтому
                                // необходимо использовать Явное преобразование
            float e = (float)c; // int --> double

            /* НЕявное (Implicit) приведение типов возможно в том случае если объём
             * данных в первой меременной меньше чем во второй.
             * 
             * Пример:
             *                      Целочисленные типы
             * sbyte → short, int, long, float, double, decimal
             * byte → short, ushort, int, uint, long, ulong, float, double, decimal
             * short → int, long, float, double, decimal
             * ushort → int, uint, long, ulong, float, double, decimal
             * int → long, float, double, decimal
             * uint → long, ulong, float, double, decimal
             * long → float, double, decimal
             * char → ushort, int, uint, long, ulong, float, double, decimal
             * 
             *                      С плавающей точкой
             * float → double
             * 
             * 
             * Явное (Explicit) приведение типов необходимо в случае когда объём 
             * данных в первой переменной больше чем во второй.
             * 
             * Пример:
             * 
             * float → int, short, byte, sbyte, uint, ushort, ulong
             * double → float, int, short, byte, sbyte, uint, ushort, ulong
             * decimal → float, double, int, short, byte, sbyte
             * long → int, short, byte
             * 
             * 
             */

            // Потеря данных
            double f = double.MaxValue;
            float g = (float)f;
            Console.WriteLine($"Явное приведение типов С потерей данных\n\n" +
                              $"double x = double.MaxValue = {f}\n" +
                              $"float y  =     (float)x    = {g}\n" +
                              $"x == y = {f == g}\n" +
                              $"\n---------------------------------------------------\n");

            // БЕЗ потери данных
            f = float.MaxValue;
            g = (float)f;
            Console.WriteLine($"Явное приведение типов БЕЗ потери данных\n\n" +
                              $"double x = float.MaxValue = {f}\n" +
                              $"float y  =    (float)x    = {g}\n" +
                              $"x == y = {f == g}\n\n\n\n");

            /* Сужающее преобразование это когда мы помещаем данные из бОльшего контейнера
             * в меньший контейнер.
             * Пример:
             *      float --> double
             * 
             * Расширяющее преобразование это когда мы помещаем из меньшего контейнера
             * в бОльший контейнер.
             * Пример:
             *      double --> float
             *      
             * Также приведение типов возможно по отношению к несовместимым типам данных,
             * например int --> bool.
             * Сделать это возможно с примененbем класса Convert.
             */

            int h = 5;
            bool i = Convert.ToBoolean(h); // True

            // Приведение типов в арефметических операциях
            int j = 5;
            float k = 2.5f;
            // Приведение типов происходит НЕявно т.к. диапазон
            // значений типа int меньше чем float
            float result1 = j + k; // 7.5
            // Если приведение типов происходит с помещением результата
            // операции в тип данных который вмещает значение меньше
            // чем тип данных используемый в арефметической операции,
            // тогда требуется Явное преобразование
            int result2 = (int)(j + k); // 7
            int result3 = j + (int)k;   // 7

            /* Для приведения типов при использовании строковых переменных
             * необходимо использовать класс Convert или метод Parse.
             */
            string str = "3";
            int l = int.Parse(str);

            int m;
            bool n = int.TryParse(str,out m);

            int o = Convert.ToInt32(str);
        }
    }
}
