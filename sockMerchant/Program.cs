//Имеется некоторое количество носков, цвет каждого из которых задан в массиве.
//Необходимо определить, сколько пар носков с совпадающими цветами существует.

using System.Linq;
using System;

namespace sockMerchant
{
    class Program
    {
	static int sockMerchant(int n, int[] ar) 
	{
            Array.Sort(ar);
            var num = 0;
            var current_value_number = 0;
            var current_value = ar[0];

            for (var i = 0; i != ar.Count(); ++i) 
	    {
                if (ar[i] == current_value) 
		{
                    current_value_number++;
            	} 
		else 
		{
                    num += current_value_number / 2;
                    current_value = ar[i];
                    current_value_number = 1;
                }
                if (i + 1 == ar.Count()) 
		{
                    num += current_value_number / 2;
                }
            }
            return num;
        }

        static void Main(string[] args)
        {
	    var n = Convert.ToInt32(Console.ReadLine());
	    int[] ar = new int[n];
	    for (var i = 0; i != n; ++i) 
	    {
		ar[i] = Convert.ToInt32(Console.ReadLine());
	    }
	    Console.WriteLine(sockMerchant(n, ar));
        }
    }
}
