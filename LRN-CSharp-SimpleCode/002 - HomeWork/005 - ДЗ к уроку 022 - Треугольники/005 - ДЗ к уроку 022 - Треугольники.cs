using System;
using System.Data;

/* ДЗ к уроку 022 - Треугольники
 * 
 * Разбор: https://www.youtube.com/watch?v=xpfHG5ifkVE
 */

namespace _005___ДЗ_к_уроку_022___Треугольники
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string drawSymbol = "#";

            /*
                #
                ##
                ###
             */
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(drawSymbol);
                }
                Console.WriteLine();
            }

            /*
                ###
                ##
                #
             */
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 10; j > i; j--)
                {
                    Console.Write(drawSymbol);
                }
                Console.WriteLine();
            }

            /* 3-х уровневый цикл
                  #
                 ##
                ###
             */
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0, k = 9; j <= i; j++)
                {
                    for (; k > i; k--)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(drawSymbol);
                }
                Console.WriteLine();
            }


            /* 3-х уровневый цикл
                ###
                 ##
                  #
             */
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 10, k = 0; j > i; j--)
                {
                    for (; k < i; k++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(drawSymbol);
                }
                Console.WriteLine();
            }

            /* 2-х уровневый цикл
                  #
                 ##
                ###
             */
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 10; j > i + 1; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < i + 1; k++)
                {
                    Console.Write(drawSymbol);
                }
                Console.WriteLine();
            }

            /* 2-х уровневый цикл
                ###
                 ##
                  #
             */
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 10; k > i; k--)
                {
                    Console.Write(drawSymbol);
                }
                Console.WriteLine();
            }
        }
    }
}
