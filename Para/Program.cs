using System;
using Para.Extension;

namespace Para
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O\'Brien\'s Tower".DeleteApostrophe(c => (c == '\'' ? '#' : c)));

            var anonim = new {i = 1, l = 1L, s = "Helion", f = 1.0f, d = 1.0};

            Console.WriteLine(anonim.GetTypeName());

            Console.ReadKey();
        }
    }
}
