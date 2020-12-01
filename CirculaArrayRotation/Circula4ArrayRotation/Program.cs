using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circula4ArrayRotation
{
    class Program
    {
        static int[] circulaArrayRotation(int[] a, int k, int[] queries)
        {
            int length = a.Count();
            int[] a_after_rotate = new int[length];
            for (int i = 0; i != length; ++i)
            {
                a_after_rotate[i] = a[(i + k % length) - length * ((i + k % length) / length)];
                //Console.WriteLine("a_after_rotate[{0}] = {1}", i, a_after_rotate[i]);
            }

            int[] answer = new int[queries.Count()];
            for (int query_number = 0; query_number != queries.Count(); ++query_number)
            {
                answer[query_number] = a_after_rotate[queries[query_number] - 1];
            }

            return answer;
        }
        static void Main(string[] args)
        {
            int a_size = Convert.ToInt32(Console.ReadLine());
            int queries_size = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[a_size];
            for (int i = 0; i != a_size; ++i)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] queries = new int[queries_size];
            for (int i = 0; i != queries_size; ++i)
            {
                queries[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] afterRotation = circulaArrayRotation(a, k, queries);
            for (int i = 0; i != afterRotation.Count(); ++i)
            {
                Console.WriteLine("a[{0}] = {1}", i, afterRotation[i]);
            }
        }
    }
}
