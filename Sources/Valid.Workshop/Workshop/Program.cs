using System;

namespace Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = DoSomeWork();
 	    
	        Console.BackgroundColor = ConsoleColor.DarkBlue;
            //fixed - yellow was not accepted...try white
           // Console.ForegroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Result={0}", result);

            Console.ReadKey();

        }

        static int DoSomeWork()
        {
            Func<int, int> fib = null; 
            fib = x => x > 1 ? fib(x - 1) + fib(x - 2) : x;

            return fib(25);
        }
    }
}
