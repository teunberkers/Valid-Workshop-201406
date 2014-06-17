using System;

namespace Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = DoSomeWork();
            Console.WriteLine("Result={0}", result);

            Console.ReadKey();
            Console.WriteLine("Nice new feature.. by Roger.. fixed acceptence bug too");
        }

        static int DoSomeWork()
        {
            Func<int, int> fib = null; 
            fib = x => x > 1 ? fib(x - 1) + fib(x - 2) : x;

            return fib(25);
        }
    }
}
