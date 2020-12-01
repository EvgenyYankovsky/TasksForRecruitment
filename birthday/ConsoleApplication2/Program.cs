//Дан список целых чисел, два целых числа, m и d. Необходимо найти количество способов, которыми
//можно выбрать m подряд идущих чисел из списка, так, что бы сумма этих чисел была равна d.

using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication2
{
    class Program
    {
        public static int birthday(List<int> numbers, int m, int d)
        {
            var num = 0;
            for (int i = 0; i != numbers.Count() - m + 1; ++i)
            {
                var sum = 0;
                for (int j = 0; j != m; ++j)
                {
                    sum += numbers[i + j];
                }
                if (sum == d)
                {
                    num++;
                }
            }
            return num;
        }

        static void Main(string[] args)
        {
            var list_length = Convert.ToInt32(Console.ReadLine());
            List<int> numbers = new List<int>();

            for (var i = 0; i != list_length; ++i)
            {
                numbers.Add(Convert.ToInt32(Console.ReadLine()));
            }
            var day = Convert.ToInt32(Console.ReadLine());
            var month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(birthday(numbers, month, day));
        }
    }
}
