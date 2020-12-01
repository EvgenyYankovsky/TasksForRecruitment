//Дан массив чисел и число k. Необходимо определить, сколько  пар чисел из данного
//массива в сумме дают число, которое нацело делится на k.

using System;
using System.Linq;

namespace ConsoleApplication4
{
    class Program
    {
        static int divisibleSumPairs(int n, int k, int[] ar)
        {
            var num = 0;
            int[] ar_sorted = ar.OrderBy(x => x).ToArray();
            for (var i = 0; i != n - 1; ++i)
            {
                for (var j = i + 1; j != n;  ++j)
                {
                    if ((ar[i] + ar[j]) % k == 0)
                    {
                        num++;
                    }
                }
            }
            return num;
        }

        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var k = Convert.ToInt32(Console.ReadLine());
            int[] ar = new int[n];
            for (var i = 0; i != n; ++i)
            {
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(divisibleSumPairs(n, k, ar));
        }
    }
}
