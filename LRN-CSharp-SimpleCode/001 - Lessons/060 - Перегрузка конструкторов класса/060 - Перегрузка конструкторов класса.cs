using System;

/* Перегрузка конструкторов класса
 * 
 * Источник: https://www.youtube.com/watch?v=t7cODl_-X_U
 */

namespace _060___Перегрузка_конструкторов_класса
{
    class Point
    {
        /// <summary>
        /// <para>Конструктор по умолчанию становится перегруженным конструктором -</para>
        /// <para>- после создания второго конструктора с другими параметрами</para>
        /// </summary>
        public Point()
        {

        }

        /// <summary>
        /// Перегруженный конструктор
        /// </summary>
        /// <param name="x">1-ый аргумент</param>
        /// <param name="y">2-ой аргумент</param>
        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        private int _x;
        private int _y;

        public void Print()
        {
            Console.WriteLine($"X: {_x}\tY: {_y}");

        }
    }

    class Student
    {
        // КОНСТРУКТОР
        // Принимает "Фамилию" и "Дату Рождения"
        public Student(string lastName, DateTime birthday)
        {
            _lastName = lastName;
            _birthday = birthday;
        }

        // КОНСТРУКТОР
        // Принимает параметры ВСЕХ полей класса
        public Student(string lastName, string firstName, string middleName, DateTime birthday)
        {
            _firstName = firstName;
            _middleName = middleName;
            _lastName = lastName;
            _birthday = birthday;
        }

        // !!!!!!!!!!!
        // КОНСТРУКТОР КОПИРОВАНИЯ
        // Принимает КЛАСС "Студент"
        public Student(Student student)
        {
            _firstName = student._firstName;
            _middleName = student._middleName;
            _lastName = student._lastName;
            _birthday = student._birthday;
        }

        private string _firstName;
        private string _middleName;
        private string _lastName;
        private DateTime _birthday;

        public void Print()
        {
            Console.WriteLine($"Фамилия: {_lastName}\n" +
                              $"Имя: {_firstName}\n" +
                              $"Отчество: {_middleName}\n" +
                              $"Дата рождения: {_birthday:dd.MM.yyyy}");
        }

        public void SetLastName(string lastName)
        {
            _lastName = lastName;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /* Перегрузка конструторов по сути это тоже самое что и перегрузка методов.
             * 
             * 1. Любой класс имеет свой конструктор.
             * 2. Если конструктор не задан разработчиком явно, то используется конструктор по умолчанию.
             * 3. Если конструктор задан вручную, то конструктор по умолчанию не используется.
             * 4. Есть возможность создать несколько конструкторов для более гибкой работы с классом.
             *    Работает это по аналогии с перегрузкой методов.
             *    
             * Для создания перегруженного конструктора необходимо создать 2+ конструктора
             * и задать им разные параметры.
             * 
             * INFO:
             * В данном уроке есть демонстрация КОНСТРУКТОРА КОПИРОВАНИЯ
             * Этот конструктор используется для создания копии объекта класса НЕ связанного с оригеналом
             * ссылкой на память, что позволяет работать с двумя эдентичными экземплярами класса НЕ затрагивая
             * изменением одного экземпляра - другой.
             */

            // Класс Point
            Point point1 = new Point();
            point1.Print();

            Point point2 = new Point(3, 7);
            point2.Print();

            // Класс Student
            // Создание экземпляра класса с данными
            Student student1 = new Student("Алексеев", "Владислав", "Михайлович", new DateTime(1988, 12, 17));
            // Создание идентичного экземпляра класса (копии) через КОНСТРУКТОР КОПИРОВАНИЯ
            Student student2 = new Student(student1);

            Console.WriteLine("\nstudent1");
            student1.Print();
            Console.WriteLine("\nstudent2");
            student2.Print();

            Console.WriteLine("\n--- Используем метод SetLastName ---");
            
            // Изменение данных в разных экземплярах,
            // ранее эдентичных экземпляров класса,
            // созданных при помощи КОНСТРУКТОРА КОПИРОВАНИЯ
            student1.SetLastName("########");

            // Фамилия student1 изменилась
            Console.WriteLine("\nstudent1");
            student1.Print();

            // Фамилия student2 НЕ изменилась
            Console.WriteLine("\nstudent2");
            student2.Print();
            
        }
    }
}
