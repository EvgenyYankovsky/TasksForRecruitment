//Дан массив, состоящий из нулей и единиц. Необходимо двигаться по нему скачками, размером
//k, которое тоже задаётся на входе. Каждый прыжок на новый элемент уменьшает счётчик на 1,
//начальное значение счётчика равно 100. Если после прыжка оказываемся на элементе со 
//значением 1, то отнимаются 2 дополнительные единицы счётчика. Размер массива кратен величине
//k. Последний прыжок совершается на начальный элемент. Необходимо вывести значение счётчика
//после возвращения к первому элементу (то есть после прохождения полного круга по массиву).

using System;
using System.Linq;

namespace jumpingOnClouds
{
    class Program
    {
        static int jumpingOnClouds(int[] c, int k)
        {
            var energy = 100;
            for (var i = 0; i != c.Count() - k + 1;)
            {
                if (i + k < c.Count())
                {
                    energy--;
                    if (c[i + k] == 1)
                    {
                        energy -= 2;
                    }
                    i += k;
                }
                else
                {
                    energy--;
                    if (c[0] == 1)
                    {
                        energy -= 2;
                    }
                    break;
                }
            }
            return energy;
        }

        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var k = Convert.ToInt32(Console.ReadLine());
            int[] c = new int[n];
            for (var i = 0; i != n; ++i)
            {
                c[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(jumpingOnClouds(c, k));
        }
    }
}
