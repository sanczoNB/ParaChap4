using System;
using Para.Extension;

namespace Para
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O\'Brien\'s Tower".DeleteApostrophe(c => (c == '\'' ? '#' : c)));

            Console.ReadKey();
        }
    }
}
