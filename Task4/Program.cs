using System;
using System.Globalization;
using System.Text;
using System.Threading;

/*
 * Вычислить значение выражения 2^𝑁+2^𝑀, 𝑁, 𝑀 – целые неотрицательные числа вводятся пользователем с клавиатуры.
 * Используйте битовые операции для организации «быстрого умножения». Помните о возможности переполнения
 *
 * Пример входных данных:
 * 2
 * 4
 *
 * Пример выходных данных:
 * 20
 *
 * Примечание:
 *      При некорректных входных данных вывести сообщение "Ошибка" и завершить выполнение программы.
 *      При переполнении вывести сообщение "Переполнение".
 */

namespace Task4
{
    class Program
    {
        // TODO: самостоятельно выделите и напишите методы, использующиеся для решения задачи
        private static bool InputData(out uint N, out uint M)
        {
            bool isInputCorrect = uint.TryParse(Console.ReadLine(), out N);
            isInputCorrect &= uint.TryParse(Console.ReadLine(), out M);

            return isInputCorrect;
        }

        private static bool WillOverflow(uint N, uint M)
        {
            return M > 30 || N > 30 || M == 30 && N == 30;
        }

        private static int BitSum(uint N, uint M)
        {
            return (1 << (int)N) | (1 << (int)M);
        }

        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            Console.OutputEncoding = Encoding.UTF8;
            uint N;
            uint M;
            if (!InputData(out N, out M))
            {
                Console.WriteLine("Ошибка");
                return;
            }
            if (WillOverflow(N, M))
            {
                Console.WriteLine("Переполнение");
                return;
            }
            Console.WriteLine(BitSum(N, M));
        }
    }
}