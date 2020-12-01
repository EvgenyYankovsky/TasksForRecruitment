//Дан массив чисел и число k. Если в массиве отрицательных и нулевых значений больше,
//чем k, то вывести "NO", если нет- вывести "YES".

using System;
using System.Linq;

namespace AngryProfessor
{
    class Program
    {
        static string angryProfessor(int k, int[] a)
        {
            int in_time = 0;
            var students_groped = a.GroupBy(s => s).Select(g => new
            {
                ArrivingTime = g.Key,
                Count = g.Count()
            });
            foreach (var group in students_groped)
            {
                if (group.ArrivingTime <= 0)
                {
                    in_time += group.Count;
                }
            }
            if (in_time < k)
            {
                return "YES";
            }
            else
            {
                return "NO";
            }
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i != n; ++i)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(angryProfessor(k, a));
        }
    }
}
