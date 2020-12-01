//Для массива целых чисел найти самый длинный подмассив, в котором абсолютная разница
//между любыми двумя элементами меньше или равна 1.

using System;
using System.Collections.Generic;
using System.Linq;

namespace pickingNumbers
{
    class Result
    {
        public static int pickingnumbers(List<int> a)
        {
            var a_Gruped = a.GroupBy(i => i)
			    .Select(q => new 
			    { 
				Number = q.Key, 
				Count = q.Count() 
			    });
            if (a_Gruped.Count() == 1)
            {
                return a.Count();
            }
            else
            {
		List<int> all = new List<int>();
                var max_abs = 0;
                var current_max = 0;
                foreach (var group_big in a_Gruped)
                {
		    all.Add(group_big.Count);
                    foreach (var group_less in a_Gruped)
                    {
                        if ((Math.Abs(group_big.Number - group_less.Number) <= 1) && 
			    (group_big.Number != group_less.Number))
                        {
                            current_max = group_big.Count + group_less.Count;
                            if (current_max > max_abs)
                            {
                                max_abs = current_max;
                            }
                        }
                    }
                }
		all.Add(max_abs);
                return all.Max();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var length = Convert.ToInt32(Console.ReadLine());
            List<int> a = new List<int>();
            for (var i = 0; i != length; ++i)
            {
                a.Add(Convert.ToInt32(Console.ReadLine()));
            }
	    Console.WriteLine(Result.pickingnumbers(a));
        }
    }
}