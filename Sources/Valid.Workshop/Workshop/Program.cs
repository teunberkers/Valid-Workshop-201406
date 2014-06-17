using System;

namespace Workshop
{
    class Program
    {
        /// <summary>
        /// There were no comments in this code!
        /// </summary>
        /// <param name="args">The arguments passed to the console app when started</param>
        static void Main(string[] args)
        {
            var result = DoSomeWork();
            Console.WriteLine("Result={0}", result);

            Console.ReadKey();

        }

        /// <summary>
        /// There were no comments in this code!
        /// </summary>
        /// <returns>Integer that represents a fibonacci figure</returns>
        static int DoSomeWork()
        {
            Func<int, int> fib = null; 
            fib = x => x > 1 ? fib(x - 1) + fib(x - 2) : x;

            return fib(25);
        }
    }
}
