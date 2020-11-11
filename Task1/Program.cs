using System;

/*
 * Пользователь вводит неотрицательные целые (int) числа q и p, такие, что q <= p.
 * Определить все тройки попарно различных целых чисел a, b, c \in [q; p],
 * для которых верно a^2 + b^2 = c^2.
 *
 * Пример входных данных:
 * 1
 * 10
 *
 * Пример выходных данных:
 * 3 4 5
 * 6 8 10
 *
 * Примечание:
 *      Тройки необходимо выводить в алфавитном порядке, то есть по возрастанию чисел в них.
 *      При некорректных входных данных вывести сообщение "Ошибка" и завершить выполнение программы.
 *      Разрешается модифицировать предложенные методы и дополнять программу своими при необходимости.
 */

namespace Task1
{
    class Program
    {
        static bool ReadBoundaries(out int q, out int p)
        {
            bool isInputCorrect = int.TryParse(Console.ReadLine(), out q);
            isInputCorrect &= int.TryParse(Console.ReadLine(), out p);
            if (isInputCorrect && q <= p)
            {
                return true;
            }
            return false;
        }

        static void PrintPythagorasNumbers(int minValue, int maxValue)
        {
            for (int a = minValue; a <= maxValue; ++a)
            {
                for (int b = a + 1; b <= maxValue; ++b)
                {
                    for (int c = b + 1; c <= maxValue; ++c)
                    {
                        if (a * a + b * b == c * c)
                        {
                            Console.WriteLine($"{a} {b} {c}");
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            if (!ReadBoundaries(out int q, out int p))
            {
                Console.WriteLine("Ошибка");
                return;
            }
            PrintPythagorasNumbers(q, p);
        }
    }
}