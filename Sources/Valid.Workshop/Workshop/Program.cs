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

        }

        static int DoSomeWork()
        {
            Func<int, int> fib = null; 
            fib = x => x > 1 ? fib(x - 1) + fib(x - 2) : x;

            return fib(25);
        }

        public string RobertsMethod()
        {
            return "hoi robert";
        }
    }
}
