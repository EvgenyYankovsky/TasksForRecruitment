//Дан массив целых чисел. Из него по одному удаляются числа, пока все оставшиеся числа не будут
//одинаковы. Необходимо найти, сколько минимально чисел надо удалить из массива для этого.

using System;
using System.Collections.Generic;
using System.Linq;

namespace EqualizeTheArray
{
    class Program
    {
        static int equalizeArray(int[] arr)
        {
            var grouped_array = arr.GroupBy(a => a).
                                    Select(g => new
                                    {
                                        Value = g.Key,
                                        Count = g.Count()
                                    });
            var max_count = grouped_array.Max(g => g.Count);
            var max_value = grouped_array.Where(g => g.Count == max_count).
                                          Max(g => g.Value);
            var num = 0;
            foreach (var group in grouped_array)
            {
                if (group.Value != max_value)
                {
                    num += group.Count;
                }
            }
            return num;
        }

        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (var i = 0; i != n; ++i)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(equalizeArray(arr));
        }
    }
}
