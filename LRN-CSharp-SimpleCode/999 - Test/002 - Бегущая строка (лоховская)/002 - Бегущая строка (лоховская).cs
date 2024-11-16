using System;
using System.Threading;

namespace _002___Бегущая_строка__лоховская_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст бегущей строки: ");
            string creepingLine = Console.ReadLine();

            Console.Write("Введите задержку бегущей строки: ");
            int delay = int.Parse(Console.ReadLine());

            char[] creepingLineArray = creepingLine.ToCharArray();

            while (true)
            {
                Console.Write($"Текст:    {creepingLine}\n" +
                              $"Задержка: {delay}\n");
                char charSwapper = creepingLineArray[0];
                for (int i = 0; i < creepingLineArray.Length; i++)
                {
                    Console.Write(creepingLineArray[i]);
                }


                for (int i = 0; i < creepingLineArray.Length; i++)
                {
                    if (i + 1 == creepingLineArray.Length)
                        continue;

                    creepingLineArray[i] = creepingLineArray[i + 1];
                }
                creepingLineArray[creepingLineArray.Length - 1] = charSwapper;
                Thread.Sleep(delay);
                Console.Clear();
            }
        }
    }
}
