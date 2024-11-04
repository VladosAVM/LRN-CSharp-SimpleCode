﻿using System;

/* For - Разные виды применения цикла For
 * 
 * Источник: https://www.youtube.com/watch?v=AxIRBCi4DHg
 */

namespace _019___For___Разные_виды_применения_цикла_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Цикл For может иметь несколько форм записи и использования.
             * 
             * 
             * 
             */

            /* В цикле For можно вынести объявление переменной(итератора)
             * за границы цикла, что позволит использовать эту
             * переменную(итератор) внутри других циклов или логики.
             * 
             * Также можно перенести инкремент в тело цикла, что позволит
             * манипулировать кодом в теле цикла, инкрементирую переменную
             * до вывода сообщения или после.
             * 
             * Ещё можно объявить несколько переменных в скобках и присвоить
             * им разные значения или значения других переменных
             *
             * Также есть возможность указать несколько итераторов в скобках
             * и инкрементировать их одновременно или один итератор инкрементировать,
             * а другой декрементировать.
             * 
             * С условиями также самая ситуация, их можно указывать в
             * неограниченном количестве.
             */

            Console.WriteLine("- - - For_1 - - -");
            int i = 0; // Вынос переменной(итератора) за границы цикла, для
                       // изменения области видимости этой переменной.
            for (; i < 3; i++)
            {
                Console.WriteLine($"For_1: i={i}");
            }
            Console.WriteLine("\n- - - For_2 - - -");
            // Объявление нескольких переменных, условий и инкрементов
            for (int j = 0, k = 1; i < 6 || k == -5; j++, k--)
            {
                i++; // Вынос инкремента в тело цикла после вывода сообщения
                     // для манипуляции результатами самого вывода.
                Console.WriteLine($"\nFor_2: i={i}");
                Console.WriteLine($"For_2: j={j}");
                Console.WriteLine($"For_2: k={k}");
            }


            /* Также можно полностью убрать все условия и оставить
             * скобки пустыми, что сделает цикл бесконечным.
             */

            /*
            for (;;) 
            {
                Console.WriteLine("Inf.For");
            }
            */
        }
    }
}
