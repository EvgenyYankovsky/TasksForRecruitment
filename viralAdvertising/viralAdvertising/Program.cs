//Необходимо определить, скольким людям понравилась реклама ко дню n, если
//в первый день её показывают 5 людям, реклама всегда нравится целому от деления
//на 2 просмотревших за день, каждый, кому понравилось, показывает её 3 друзьям
//на следующий день.

using System;

namespace viralAdvertising
{
    class Program
    {
        static int viralAdvertising(int n)
        {
            var shared = 5;
            var liked = 0;
            var cumulative = 0;
            for (int day = 1; day != n + 1; ++day)
            {
                liked = shared / 2;
                cumulative += liked;
                shared = liked * 3;
            }
            return cumulative;
        }

        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(viralAdvertising(n));
        }
    }
}
