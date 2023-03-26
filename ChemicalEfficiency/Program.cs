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
        static float mostEfficient = 0;
        static string bestChemName = "";

        static float leastEfficient = 0;
        static string worstChemName = "";

        static int timesRan = 0;
        // Lists

        static void OneChemical()
        {
            //Randomly generate number of live germs in a live sample
            Random random = new Random();
            int germNum = random.Next(500, 1000);

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
            Console.WriteLine("Test Commencing...\nPlease wait 10 seconds");
            Thread.Sleep(10000);



            //Generate average number

            float avgEfficiency = 0;
            for (int i = 0; i <= 5; i++)
            {
                int sampleNum = i + 1;
                //Generate new value after chemical is tested
                int newGermNum = random.Next(0, 499);
                int numRemoved = germNum - newGermNum;

                //Display new value
                Console.WriteLine($"Sample {sampleNum}: {numRemoved} germs were killed leaving {newGermNum} remaining.\n");

                //Determine efficiency of chemical
                float efficiency = (float)numRemoved / 10;
                avgEfficiency += efficiency;
                
            }
          
            avgEfficiency = avgEfficiency / 5;
            if (timesRan == 0)
            {
                leastEfficient = avgEfficiency;
            }
            timesRan++;
            Console.WriteLine($"effiency of {chemical} is{avgEfficiency}");

            Console.WriteLine(leastEfficient);

            //check if chemical is more or less effiecient than previous most or least

            if (avgEfficiency < leastEfficient)
            {
                leastEfficient = avgEfficiency;
            }

            if (avgEfficiency > mostEfficient)
            {
                mostEfficient = avgEfficiency;
            }
            
            

        }
        static void Main(string[] args)
        {
            string flag = "";
            while (!flag.Equals("stop"))
            {
                OneChemical();
                Console.WriteLine("type 'stop' to end and press <Enter> to continue");
                flag = Console.ReadLine();

            }
        }
    }
}
