//Есть книга, у которой страницы пронумерованы, на одном развороте находится две страницы,
//первая страница находится на правой части разворота.Необходимо найти минимальное число
//перелистываний страниц (перелистывать можно с начала и с конца, по одной), дабы добраться
//сначала или конца до заданной страницы.

using System;

namespace pageCount
{
    class Program
    {
	static int pageCount(int n, int p) 
	{
            var front = p / 2;
            var back = n / 2 - p / 2;
            return Math.Min(front, back);
        }

        static void Main(string[] args)
        {		
	    var n = Convert.ToInt32(Console.ReadLine());
	    var p = Convert.ToInt32(Console.ReadLine());
	    Console.WriteLine(pageCount(n, p));
        }
    }
}
