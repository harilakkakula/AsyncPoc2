using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncPoc2
{
    class Program
    {
           static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Started");
            checkreturn();
            Console.WriteLine("Hello World!");
            Console.WriteLine("final call!");
            Console.ReadLine();
           
        }

        public async static void checkreturn()
        {
            Stopwatch stopwatch = new();
            Console.WriteLine("Started time" + stopwatch.ElapsedMilliseconds);
           var a=  Returnsumvalue();
            Console.WriteLine("after Started time " + stopwatch.ElapsedMilliseconds);
            Console.WriteLine(a);
            var b =  Returnsumvalue();
            Console.WriteLine("After B Started time " + stopwatch.ElapsedMilliseconds);
            Console.WriteLine(b);
            object p = await Task.WhenAll(a, b);
            var c = Returnsumvalue();
        }


        public  static async  Task<int> Returnsumvalue()
        {
            await Task.Delay(10000);
            return 5;
        }
    }
}
