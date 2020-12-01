//Заданы 2 натуральных числа i и j. Рассматриваем каждое число от i до j включительно,
//получаем для рассматриавемого числа его обратное, получаемое реверсированием цифр начального
//числа (21 => 12). Для изначального числа и ему обратного ищем абсолютную разницу. Надо
//определить, сколько  числе на отрезке [i; j] делятся нацело на число k, которое тоже подаётся
//на вход.

using System;
using System.Linq;

namespace beautifulDays
{
    class Program
    {
        static int beautifulDays(int i, int j, int k)
        {
            var num = 0;
            var i_temp = i;
            var i_differens = 0;
            string init;
            string reverse;
            int reverse_int;
            while (i_temp != j + 1)
            {
                init = i_temp.ToString();
                reverse = new string(init.ToCharArray().Reverse().ToArray());
                reverse_int = Convert.ToInt32(reverse);
                i_differens = Math.Abs(reverse_int - i_temp);
                if (i_differens % k == 0)
                {
                    ++num;
                }
                i_temp++;
            }
            return num;
        }

        static void Main(string[] args)
        {
            var i = Convert.ToInt32(Console.ReadLine());
            var j = Convert.ToInt32(Console.ReadLine());
            var k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(beautifulDays(i, j, k));
        }
    }
}
