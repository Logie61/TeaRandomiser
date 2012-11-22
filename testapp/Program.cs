using System;
using System.Linq;
using System.Threading;

namespace TeaRandomiser
{
    class Program
    {
        static void Main(string[] args)
        {
            var guys = (from string key in System.Configuration.ConfigurationManager.AppSettings select System.Configuration.ConfigurationManager.AppSettings[key]);
            var r = new Random();
            var k = r.Next(0, guys.Count());
            var teamaker = guys.ElementAt(k);
            PrintVictim(teamaker);
        }

        private static void PrintVictim(string teamaker)
        {
            Console.WriteLine("WHO'S MAKING THE TEA!?!?!?!?!?!?");
            Console.WriteLine("Now Minus Shenanigans!");
            Thread.Sleep(5000);
            Console.Clear();
            Thread.Sleep(5000);
            Console.WriteLine("\nThe tea maker is!: {0} ", teamaker);
            Console.Write("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
