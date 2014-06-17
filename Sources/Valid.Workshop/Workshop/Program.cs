using System;
using System.Threading.Tasks;

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
 	    
	        Console.BackgroundColor = ConsoleColor.DarkBlue;
            //fixed - yellow was not accepted...try white
           // Console.ForegroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("This is an emergency Fix");
            Console.WriteLine("Result={0}", result);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ReadKey();
            Console.WriteLine("Nice new feature.. by Roger.. fixed acceptence bug too");
        }

        /// <summary>
        /// There were no comments in this code!
        /// </summary>
        /// <returns>Integer that represents a fibonacci figure</returns>
        static int DoSomeWork()
        {
            // Commetaar vergeten voor release. nu wel toegevoegd.
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
<<<<<<< HEAD

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string RobertsMethod()
        {
            return "hoi robert";
           
        }
=======
>>>>>>> hotfix/hotfix-Roger-0.1
    }
}
