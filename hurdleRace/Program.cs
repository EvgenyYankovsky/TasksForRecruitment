//Даётся массив чисел и число k, которое надо сравнить с максимальным числом
//из массива, если k меньше, чем максимальное число из массива, то вывести разницу,
//если нет, то вернуть 0.

using System.Linq;
using System;

namespace hurdleRace
{
    class Program
    {
	static int hurdleRace(int k, int[] height) 
	{
            var max_height = height.Max();
            if (max_height <= k) 
	    {
                return 0;
            } 
            else 
	    {
                return max_height - k;
            }
        }

        static void Main(string[] args)
        {
	    var n = Convert.ToInt32(Console.ReadLine());
	    var k = Convert.ToInt32(Console.ReadLine());
	    int[] height = new int[n];
	    for (var i = 0; i != n; ++i) 
	    {
	        height[i] = Convert.ToInt32(Console.ReadLine());
	    }
	    Console.WriteLine(hurdleRace(k, height));
        }
    }
}
