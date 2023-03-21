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
        static string mostEfficient = "";
        static string leastEfficient = "";
        // Lists

        static void OneChemical()
        {
            //Randomly generate number of live germs in a live sample
            Random random = new Random();
            
            int germNum = random.Next(20000, 40000);
            //Display value generated
            Console.WriteLine($"Number of germs in sample is {germNum}");
            //Select chemical to add to the sample
            Console.WriteLine("1: Cyanide\n" +
                "2: Vinegar\n" +
                "3: Butoxyethanol\n" +
                "4: Ammonia\n" +
                "5: Chlorine\n");
            int userInput = Convert.ToInt32(Console.ReadLine());
            string chemical = "";

            if (userInput == 1) 
            {
                chemical = "Cyanide";
            }
            else if (userInput == 2)
            {
                chemical = "Vinegar";
            }
            else if (userInput == 3)
            {
                chemical = "Butoxyenthanol";
            }
            else if (userInput == 4)
            {
                chemical = "Ammonia";
            }
            else if (userInput == 5)
            {
                chemical = "Chlorine";
            }

            //Wait 10 seconds
            Thread.Sleep(10000);
            //Generate new value after chemical is tested
            int newGermNum = random.Next(10000, 25000);
            int numRemoved = germNum - newGermNum;
            //Display new value
            Console.WriteLine($"After testing {chemical} against the sample {numRemoved} germs were killed leaving {newGermNum} remaining. ");
            //Determine efficiency of chemical
            float efficiency = (float)numRemoved / 10000;
            Console.WriteLine($"efficieny is {efficiency}");
            
            //Check if chemical is more or less efficient than the previous most and least efficient
        }
        static void Main(string[] args)
        {
            OneChemical();
            Console.ReadLine();
        }
    }
}
