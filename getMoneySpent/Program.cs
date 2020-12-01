//Есть два массива, содержащие цены на два вида покупок, а также запас денег у покупателя.
//Ему необходио купить по одной вещи из каждого массива на максимально возможную сумму.
//Если это получается, то необходимо вывести сумму покупки, если денег не хватает даже 
//на самый дешёвый комплект, то вывести "-1" (купить обязательно из обоих массивов).

using System;

namespace getMoneySpent
{
    class Program
    {
	static int getMoneySpent(int[] keyboards, int[] drives, int b)	
	{
            var current_sum = 0;
            var max_sum = 0;

            foreach (int kb in keyboards) 
	    {
                foreach (int dr in drives) 
		{
                    current_sum = kb + dr;
                    if ((current_sum > max_sum) && (b >= current_sum)) 
		    {
                        max_sum = current_sum;
                    }
                }
            }
            if (max_sum > 0) 
	    {
	        return max_sum;
	    } 
	    else 
	    {
		return -1;
	    }
        }

        static void Main(string[] args)
        {
	    var b = Convert.ToInt32(Console.ReadLine());
	    var n = Convert.ToInt32(Console.ReadLine());
	    var m = Convert.ToInt32(Console.ReadLine());
	    int[] kb = new int[n];
            int[] dr = new int[m];

	    for (var i = 0; i != n; ++i) 
	    {
		kb[i] = Convert.ToInt32(Console.ReadLine());
	    }
	    for (var i = 0; i != m; ++i) 
	    {
		dr[i] = Convert.ToInt32(Console.ReadLine());
	    }

	    Console.WriteLine(getMoneySpent(kb, dr, b));
        }
    }
}
