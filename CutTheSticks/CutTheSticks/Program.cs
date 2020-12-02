//Дан массив целых чисел. Находится минимальное значение в массиве, из всех чисел массива оно вычитается
//(соответствено, это минимальное значение удаляется). Далее ищется снова минимальное число, и опять оно
//из всех вычитается, так до тех пор, пока не уйдут все числа. Если в конце остаётся несколько одинаковых 
//чисел, то они удаляются все вместе. Необходимо вернуть в виде массива, сколько чисел оставалось в начальном 
//массиве после каждой итерации.

using System;
using System.Collections.Generic;
using System.Linq;

namespace CutTheSticks
{
    class Program
    {
        static int[] cutTheSticks(int[] arr)
        {
            List<int> quantity = new List<int>();
            var min = arr.Min();
            var size = arr.Count();
            quantity.Add(size);
            Array.Sort(arr);
            var grouped_lengths = arr.GroupBy(l => l)
                                     .Select(g => new 
                                         { 
                                             Number = g.Key,
                                             Count = g.Count()
                                         });
            var grouped_lengths_copy = grouped_lengths;
            foreach (var group in grouped_lengths)
            {
                if (group.Number == min)
                {
                    size -= group.Count;
                    if (size == 0)
                    {
                        break;
                    }
                    quantity.Add(size);
                    grouped_lengths_copy = grouped_lengths_copy.Where(g => g.Number != group.Number);
                    min = grouped_lengths_copy.Min(g => g.Number);
                }
            }
            return quantity.ToArray();
        }
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (var i = 0; i != n; ++i)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] ans = cutTheSticks(arr);
            for (var i = 0; i != ans.Count(); ++i)
            {
                Console.WriteLine(ans[i]);
            }
        }
    }
}
