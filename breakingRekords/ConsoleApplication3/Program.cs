//Дан массив, необходимо вывести, сколько раз максимальный и минимальный элемент
//преобретали новое значение, относительно  первого элемента массива.

using System;

namespace ConsoleApplication3
{
    class Program
    {
        static int[] breakingRekords(int[] scores)
        {
            var num_high = 0;
            var num_low = 0;
            var max = scores[0];
            var min = scores[0];
            foreach (int i in scores)
            {
                if (i > max)
                {
                    num_high++;
                    max = i;
                }
                if (i < min)
                {
                    num_low++;
                    min = i;
                }
            }
            return new int[] { num_high, num_low };
        }

        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (var i = 0; i != n; ++i)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] res = breakingRekords(arr);
            Console.WriteLine(res[0].ToString() + " " + res[1].ToString());
        }
    }
}
