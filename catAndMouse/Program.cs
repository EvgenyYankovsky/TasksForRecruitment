//Два объекта находятся на расстоянии от третьего, двигаются к нему с одинаковой скоростью.
//На вход подаются координаты начальных положений всех трёх объектов. В зависимости от того,
//какой объект будет первым, или если они прибудут одновременно, выводится разное сообщение.

using System;

namespace catAndMouse
{
    class Program
    {
	static string catAndMouse(int x, int y, int z) 
	{
            if (Math.Abs(z - x) < Math.Abs(z - y)) 
	    {
                return "Cat A";
            } 
	    else if (Math.Abs(z - x) > Math.Abs(z - y)) 
	    {
                return "Cat B";
            } 
	    else 
	    {
                return "Mouse C";
            }
        }

        static void Main(string[] args)
        {
	    var x = Convert.ToInt32(Console.ReadLine());
	    var y = Convert.ToInt32(Console.ReadLine());
	    var z = Convert.ToInt32(Console.ReadLine());
	    Console.WriteLine(catAndMouse(x, y, z));
        }
    }
}
