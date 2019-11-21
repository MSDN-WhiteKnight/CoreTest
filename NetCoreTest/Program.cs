using System;

namespace NetCoreTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            if (!Console.IsInputRedirected) Console.ReadKey();
        }
    }
}
