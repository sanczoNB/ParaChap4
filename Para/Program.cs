using System;

namespace Para
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();

            //int-double
            var pairs = new Para<int, double>[10];
            for (int i = 0; i < pairs.Length; i++)
            {
                pairs[i] = new Para<int, double>(r.Next(10), r.NextDouble());
            }
            Console.WriteLine("Para<int, double>:");
            foreach (var pair in pairs)
            {
                Console.WriteLine(pair);
            }
            Array.Sort(pairs);
            Console.WriteLine("\nPara<int, double> po sortowaniu:");
            foreach (var pair in pairs)
            {
                Console.WriteLine(pair);
            }

            Console.ReadKey();
        }
    }
}
