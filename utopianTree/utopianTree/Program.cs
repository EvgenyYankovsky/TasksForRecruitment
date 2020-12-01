//Дерево проходит два цикла роста за год - за весну его высота увеличивается в 2 раза,
//а за лето - на 1 метр. Саженец, высотой 1 метр, высаживают в начале весны. Определить
//высоту через n циклов (циклов, не лет).

using System;

namespace utopianTree
{
    class Program
    {
        static int utopianTree(int n)
        {
            var height = 1;
            for (var i = 1; i != n + 1; ++i)
            {
                if (i % 2 == 1)
                {
                    height *= 2;
                }
                else
                {
                    height++;
                }
            }
            return height;
        }

        static void Main(string[] args)
        {
            var quntity_cycles = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(utopianTree(quntity_cycles));
        }
    }
}
