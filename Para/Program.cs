using System;
using System.Reflection.Emit;

namespace Para
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            //int
            var pi = new Para<int>[10];
            for (var i = 0; i < pi.Length; i++)
            {
                pi[i] = new Para<int>(random.Next(10), random.Next(10));
            }
            Console.WriteLine("Para<int>:");
            foreach (var para in pi)
            {
                Console.WriteLine(para);
            }

            
            //double
            var pd = new Para<double>[10];
            for (var i = 0; i < pd.Length; i++)
            {
                pd[i] = new Para<double>(random.Next(), random.Next());
            }
            Console.WriteLine("\nPara<double>:");
            foreach (var para in pd)
            {
                Console.WriteLine(para);
            }

            //string
            var ps = new Para<string>[12];
            ps[0] = new Para<string>("Bester", "Alfred");
            ps[1] = new Para<string>("Dick", "Philip");
            ps[2] = new Para<string>("Tolkien", "John");
            ps[3] = new Para<string>("Lem", "Stanisław");
            ps[4] = new Para<string>("Anderson", "Poul");
            ps[5] = new Para<string>("Pohl", "Frederik");
            ps[6] = new Para<string>("Le Guin", "Ursula");
            ps[7] = new Para<string>("Card", "Orson");
            ps[8] = new Para<string>("Gibson", "William");
            ps[9] = new Para<string>("Asimov", "Isaac");
            ps[10] = new Para<string>("Niven", "Larry");
            ps[11] = new Para<string>("Herbert", "Frank");
            Console.WriteLine("\nPara<string>:");
            foreach (var para in ps)
            {
                Console.WriteLine(para);
            }

            Console.ReadKey();
        }
    }
}
