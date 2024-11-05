using System;

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
            for (int i = 0; i < 10; i++)
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
            /*
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
            Console.WriteLine();

            /*
                ###
                 ##
                  #
             */
            for (int i = 0; i < 10; i++)
            {
                for (int j = 10, k = 0 ; j > i; j--)
                {
                    for (; k < i; k++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(drawSymbol);
                }
                Console.WriteLine();
            }
        }
    }
}
