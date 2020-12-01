//На вход подаётся строка, содержащая символы двух типов: D и U. Первый символ
//означает уменьшение высоты от плоскости на 1 условную единицу, второй - увеличение
//высоты на 1 единицу. Если с плоскости (то есть нулевого уровня) спуститься вниз, 
//потом подняться до нулевого уровня, то засчитывается один объект (в терминах 
//задачи - долина). Необходимо по заданной на входе строке выдать ответ, сколько
//всего долин было. Известно, что начальная и конечная точки нахоядтся на нулевом уровне

using System;

namespace countingValleys
{
    class Program
    {
	public static int countingValleys(int steps, string path)
    	{
            var up = 0;
            var down = 0;
            var valleyes_count = 0;
            var begin_index = 0;

            for (var  i = 0; i != path.Length; ++i) 
	    {
                if (path[i] == 'D')
		{
                    down++;
            	} 
		else 
		{
                    up++;
            	}
            	if (path[begin_index] == 'D') 
		{
                    if (down == up) 
		    {
                    	    valleyes_count++;
                    	    begin_index = i + 1;
                    }
            	} 
		else 
		{
                    if (down == up) 
		    {
                        begin_index = i + 1;
                    }
            	}
            }
            return valleyes_count;
    	}

        static void Main(string[] args)
        {
	    var steps = Convert.ToInt32(Console.ReadLine());
	    var path = Console.ReadLine();
	    Console.WriteLine(countingValleys(steps, path));
        }
    }
}
