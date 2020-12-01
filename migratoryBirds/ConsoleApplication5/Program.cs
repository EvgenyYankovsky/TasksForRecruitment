//Дан список чисел. Необходимо вывести число, которое чаще всего повторяется в списке,
//при равенстве вхождений, вывести меньшее.

using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication5
{
    class Program
    {
        static int migratoryBirds(List<int> arr)
        {
            var num = 1;
            var num_possible = 0;
            List<int> arr_sorted = arr.OrderBy(x => x).ToList();
            var current_value = arr_sorted[0];
            var current_value_possible = arr_sorted[0];
            for (var i = 1; i != arr_sorted.Count(); ++i)
            {
                if (arr_sorted[i] == current_value)
                {
                    num++;
                }
                else if (arr_sorted[i] == current_value_possible)
                {
                    num_possible++;
                }
                else
                {
                    current_value_possible = arr_sorted[i];
                    num_possible = 1;
                }
                if (num_possible > num)
                {
                    num = num_possible;
                    num_possible = 0;
                    current_value = current_value_possible;
                }
            }
            return current_value;
        }

        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            List<int> arr = new List<int>();
            for (var i = 0; i != n; ++i)
            {
                arr.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine(migratoryBirds(arr));
        }
    }
}