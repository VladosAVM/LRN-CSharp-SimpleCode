using System;

namespace _002___ENUM___Меню_напитков
{
    internal class Program
    {
        /// <summary>
        /// Enum со списком напитков и началом нумерации с 1
        /// </summary>
        enum Drink
        {
            Чай = 1,
            Кофе,
            Сок,
            Вода,
            Кола
        }

        /// <summary>
        /// Вывод меню в консоль.
        /// </summary>
        /// <param name="enumDrink">Enum напитков</param>
        static void PrintMenu(Type enumDrink)
        {
            // Присвоение списка напитков в переменную menu
            var menu = Enum.GetValues(enumDrink);

            // Вывод списка напитков в консоль через цикл foreach
            Console.Write("Меню напитков: ");
            foreach (var item in menu)
                Console.Write($"{item}" + $"{((int)item < menu.Length ? ", " : ".")}");

            // Переход на новую строку из-за использованного ранее "Console.Write"
            Console.WriteLine();
        }

        /// <summary>
        /// Выбор напитков клиентом.
        /// </summary>
        static void CustomerChoice()
        {
            // Переменная для проверки получил пользователь заказ или нет
            bool orderComplete = false;

            // Проверка на выполненность заказа пользователя
            while (!orderComplete)
            {
                // Информирование пользователя о необходимом действии
                Console.Write("Какой напиток вам подать?\n" +
                          "Введите название или номер напитка: ");

                // Запись выбора пользователя в переменную "customerDrinkChoice"
                string customerDrinkChoice = Console.ReadLine();

                // Поиск пользовательского ввода в enum Drink
                Enum.TryParse(customerDrinkChoice, true, out Drink drinkParseResult);


                // Варианты действий зависящие от выбора пользователя
                switch (drinkParseResult)
                {
                    case Drink.Чай:
                        Console.WriteLine("\nВы выбрали: Чай\n" +
                                          "Приятного вам чаепития...");
                        orderComplete = true;
                        break;
                    case Drink.Кофе:
                        Console.WriteLine("\nВы выбрали: Кофе\n" +
                                          "Вот ваш кофе, взбодритесь немного...");
                        orderComplete = true;
                        break;
                    case Drink.Сок:
                        Console.WriteLine("\nВы выбрали: Сок\n" +
                                          "Витаминный 'БУМ' прибыл, приятно освежится...");
                        orderComplete = true;
                        break;
                    case Drink.Вода:
                        Console.WriteLine("\nВы выбрали: Воду\n" +
                                          "Ваши почки скажут вам спасибо...");
                        orderComplete = true;
                        break;
                    case Drink.Кола:
                        Console.WriteLine("\nВы выбрали: Колу\n" +
                                          "Кола, она и в Африке кола...");
                        orderComplete = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("!!! Такого напитка нет в меню !!!\n");
                        PrintMenu(typeof(Drink));
                        orderComplete = false;
                        break;     
                }
                
            }

        }

        static void Main(string[] args)
        {
            PrintMenu(typeof(Drink));
            CustomerChoice();

        }
    }
}
