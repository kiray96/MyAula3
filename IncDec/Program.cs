using System;

namespace IncDec
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 1;
            int c;

            c = a++ + b++;

            Console.WriteLine(c);
            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}
