using System;
using System.Threading.Tasks;

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
            var tsk = new Task<int>(() =>
            {
                Func<int, int> fib = null;
                fib = x => x > 1 ? fib(x - 1) + fib(x - 2) : x;

                return fib(25);
            });

            tsk.Start();
            tsk.Wait();
            return tsk.Result;
        }
    }
}
