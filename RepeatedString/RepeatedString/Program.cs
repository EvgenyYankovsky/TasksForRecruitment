//Дана строка, которая повторяется бесконечное количество раз. Необходимо подсчитать,
//сколько раз в части этой бесконечной строки, начинающейся с начала, и длины n, встречается
//буква 'a'. 

using System;
using System.Linq;

namespace RepeatedString
{
    class Program
    {
        static long repeatedString(string s, long n)
        {
            long num_a = 0;
            foreach (var ch in s)
            {
                if (ch == 'a')
                {
                    num_a++;
                }
            }
            num_a *= n / s.Length;
            var ost = n % s.Length;
            for (var i = 0; i != ost; ++i)
            {
                if (s[i] == 'a')
                {
                    num_a++;
                }
            }
            return num_a;
        }
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var n = long.Parse(Console.ReadLine());
            Console.WriteLine(repeatedString(s, n));
        }
    }
}
