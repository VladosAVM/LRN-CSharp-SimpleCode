using System;

/* SWITCH, CASE - Конструкция логического выбора
 * 
 * Источник: https://www.youtube.com/watch?v=KM_VTfygj-E
 */

namespace _015___SWITCH__CASE___Конструкция_логического_выбора
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Конструкция Switch, позволяет осуществлять логику
             * ветвления кода аналогично If Else.
             * 
             * Основным отличием Switch от If, является 2 вещи:
             *  1. Разные типы принимаемых значений
             *  2. Множество вариантов ветвления кода
             * 
             * 1 вариант синтаксис конструкции SWITCH:
             *      switch (принимаемый_параметр)
             *      {
             *          case параметр_1:
             *              исполняемый_код;
             *              break;
             *              
             *          case параметр_2:
             *              исполняемый_код;
             *              break;
             *              
             *          case параметр_N:
             *              исполняемый_код;
             *              break;
             *              
             *          default:
             *              исполняемый_код;
             *              break;
             *      }
             * 
             * 2 вариант синтаксис конструкции SWITCH:
             *      switch (принимаемый_параметр)
             *      {
             *          case параметр_1:
             *          case параметр_2:
             *              исполняемый_код;
             *              break;
             *              
             *          case параметр_N:
             *              исполняемый_код;
             *              break;
             *              
             *          default:
             *              исполняемый_код;
             *              break;
             *      }
             *
             * 3 вариант синтаксис конструкции SWITCH:
             *      switch (принимаемый_параметр)
             *      {
             *          case параметр_N:
             *              {
             *              исполняемый_код;
             *              }
             *              break;
             *              
             *          default:
             *              {
             *              исполняемый_код;
             *              }
             *              break;
             *      }
             */
            int a = int.Parse(Console.ReadLine());
            
            switch (a)
            {
                case 0:
                    Console.WriteLine("a = 0");
                    break;

                case 1:
                    {
                        Console.WriteLine("a = 1");
                    }
                    break;

                case 2:
                case 3:
                case 4:
                    Console.WriteLine("a = 2,3 или 4");
                    break;
                
                default:
                    Console.WriteLine($"a = {a}");
                    break;
            }

        }
    }
}
