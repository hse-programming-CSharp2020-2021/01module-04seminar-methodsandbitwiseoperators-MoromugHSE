using System;
using System.Threading;
using System.Globalization;

/*
 * Пользователь последовательно вводит целые числа.
 * Для хранения полученных чисел в программе используется одна переменная.
 * Окончание ввода чисел определяется либо желанием пользователя (ввод строки "q"),
 * либо когда сумма уже введённых отрицательных чисел становится меньше -1000.
 * Определить и вывести на экран среднее арифметическое отрицательных чисел.
 *
 * Пример входных данных:
 *  1
 *  3
 *  -4
 *  2
 *  -3
 *  q
 *
 * Пример выходных данных:
 * -3.5
 *
 * Примечание:
 *      При некорректном вводе вывести сообщение "Ошибка" и завершить выполнение программы.
 *      Разрешается модифицировать предложенные методы и дополнять программу своими при необходимости.
 *      Вывод чисел необходимо производить с точностью до двух знаков после запятой.
 */

namespace Task2
{
    class Program
    {
        // TODO: используйте передачу параметров по ссылке
        static bool ReadData(out int negativeSum, out int negativeAmount)
        {
            // TODO: Прочитать вводимые данные
            negativeAmount = negativeSum = 0;
            bool isInputCorrect = true;
            string s = Console.ReadLine();
            //Console.WriteLine(s);
            int cur;
            while (negativeSum >= -1000 && s != "q" && (isInputCorrect &= int.TryParse(s, out cur)))
            {
                if (cur < 0)
                {
                    ++negativeAmount;
                    negativeSum += cur;
                }
                s = Console.ReadLine();
                //Console.WriteLine(s);
            }
            return isInputCorrect;
        }

        private static double FindAverage(int sum, int amount)
        {
            if (amount == 0)
            {
                return 0.0;
            }
            return (double)sum / amount;
        }


        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            int negativeSum;
            int negativeAmount;
            if (!ReadData(out negativeSum, out negativeAmount))
            {
                Console.WriteLine("Ошибка");
                return;
            }
            Console.WriteLine($"{FindAverage(negativeSum, negativeAmount):F2}");
        }
    }
}