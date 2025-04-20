namespace _001___TEST.Utils
{
    public static class MathOperations
    {
        /// <summary>
        /// Сумма неограниченного числа переменных разного типа.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="parametrs"></param>
        /// <returns></returns>
        public static T Sum<T>(params T[] parametrs)
        {
            dynamic sum = default(T);

            foreach (T t in parametrs)
                sum += t;

            return sum;
        }

        /// <summary>
        /// Расчёт суммы цифр числа при помощи рекурсии.
        /// </summary>
        /// <param name="num">Число для расчёта суммы цифр</param>
        /// <param name="result"></param>
        public static int RecursionDigitOfNumberSum(int num)
        {
            if (num < 10)
                return num;

            return (num % 10) + RecursionDigitOfNumberSum(num / 10);
        }
    }
}
