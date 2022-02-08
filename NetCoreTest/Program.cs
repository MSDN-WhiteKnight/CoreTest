using System;

namespace NetCoreTest
{

    class C<T>
    {

    }

    class Program
    {
        public static void Main(string[] args)
        {
            Type t = typeof(C<>).GetGenericArguments()[0];
            Console.WriteLine(t.IsNested);
        }
    }
}
