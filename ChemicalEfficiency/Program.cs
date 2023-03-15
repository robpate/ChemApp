using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ChemicalEfficiency
{
    internal class Program
    {
        // Global Variables

        // Lists

        static void ChemTest()
        {

        }
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Thread.Sleep(5000);
            Console.WriteLine($"5 seconds should have passed");
            Console.ReadLine();
        }
    }
}
