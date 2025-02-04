using System;

namespace _056___Методы_экземпляра_класса
{
    class Car
    {
        private int speed = 0; // Модификатор private отключает доступ к
                               // полю при обращении к экземпляру класса 

        /// <summary>
        /// Выводит в консоль информацию о НАПРАВЛЕНИИ и СКОРОСТИ джевения автомобиля.
        /// </summary>
        public void PrintSpeed()
        {
            if (speed == 0)
                Console.WriteLine("Автомобиль стоит на месте");
            if (speed > 0)
                Console.WriteLine($"Автомобиль движется ВПЕРЁД со скоростью {speed} км/ч");
            if (speed < 0)
                Console.WriteLine($"Автомобиль движется НАЗАД со скоростью {-speed} км/ч");
        }

        /// <summary>
        /// Задаёт скорость движения автомобилю для движения ВПЕРЁД.
        /// </summary>
        public void DriveForward() { speed = 64; }

        /// <summary>
        /// Задаёт скорость движения автомобилю для движения НАЗАД.
        /// </summary>
        public void DriveBackward() { speed = -5; }

        /// <summary>
        /// Останавливает автомобиль.
        /// </summary>
        public void Stop() { speed = 0; }

    }
}
