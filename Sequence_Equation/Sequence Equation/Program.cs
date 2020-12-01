//дана последовательность n целых чисел, p(1), p(2), ... p(n), где каждый элемент отличается и удовлетворяет
//условию 1 <= p(x) <= n. Для каждого x, где 1 <= x <= n, надо найти любое целое число y, такое, что 
//p(p(y)) == x, и вывести значение y на новой строке.

using System;
using System.Linq;

namespace Sequence_Equation
{
    class Program
    {
        static int[] permutationEquation(int[] p)
        {
            int[] y = new int[p.Count()];
	    for (var i = 0; i != p.Count(); ++i)
	    {
	        y[p[p[i] - 1] - 1] = i + 1;
	    }
            return y;
        }

        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            int[] p = new int[n];
            for (var i = 0; i != n; ++i)
            {
                p[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] y = permutationEquation(p);
            for (var i = 0; i != n; ++i)
            {
                Console.WriteLine(y[i]);
            }
        }
    }
}