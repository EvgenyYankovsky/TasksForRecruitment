//На вход посылается список, число k, обозначающее индекс элемента из списка, который не 
//учитывается, также на вход поступает число b, которое сравнивается с полусуммой
//оставшихся элементов списка. Если b равно этой полусумме, выводится текстовое сообщение,
//если больше (меньше не может быть по условию) - выводится разница. 

using System.Collections.Generic;
using System.Linq;
using System;

namespace Bonappetit
{
    class Program
    {
	static void bonAppetit(List<int> bill, int k, int b) 
	{
            var sum_init = bill.Sum();
            bill.RemoveAt(k);
            var sum_final = bill.Sum();
            if (sum_final / 2 == b) 
	    {
                Console.WriteLine("Bon Appetit");
            } 
	    else 
	    {
                Console.WriteLine(b - sum_final / 2);
            }
        }

        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
	    var k = Convert.ToInt32(Console.ReadLine());
	    List<int> bill = new List<int>();
	    for (var i = 0; i != n; ++i) 
	    {
	        bill.Add(Convert.ToInt32(Console.ReadLine()));
	    }

	    var b = Convert.ToInt32(Console.ReadLine());
	    bonAppetit(bill, k, b);
        }
    }
}
