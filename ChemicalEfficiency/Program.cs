using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ChemicalApp
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
            int userInput = CheckChemical();
            
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




            //Do waiting animation
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                //Wait 500ms
                Console.WriteLine("Test Commencing\nPlease wait 5 seconds");
                Thread.Sleep(250);

                Console.Clear();
                //Wait 500ms
                Console.WriteLine("Test Commencing.\nPlease wait 5 seconds");
                Thread.Sleep(250);


                Console.Clear();
                //Wait 500ms
                Console.WriteLine("Test Commencing..\nPlease wait 5 seconds");
                Thread.Sleep(250);


                Console.Clear();
                //Wait 500ms
                Console.WriteLine("Test Commencing...\nPlease wait 5 seconds");
                Thread.Sleep(250);
            }
            
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
                worstChemName = chemical;
            }
            timesRan++;

            //check if chemical is more or less effiecient than previous most or least

            if (avgEfficiency < leastEfficient)
            {
                leastEfficient = avgEfficiency;
                worstChemName = chemical;
            }

            if (avgEfficiency > mostEfficient)
            {
                mostEfficient = avgEfficiency;
                bestChemName = chemical;
            }

            Console.WriteLine($"effiency of {chemical} is {avgEfficiency}");

        }
      
        static int CheckChemical()
        {
            while (true)
            {
                
                Console.WriteLine("1: Cyanide\n" +
                "2: Vinegar\n" +
                "3: Butoxyethanol\n" +
                "4: Ammonia\n" +
                "5: Chlorine\n");
                


                //Check for invalid and boundry case data
                
                try
                {
                    int userInput = Convert.ToInt32(Console.ReadLine());
                    if (userInput >= 1 && userInput <= 5)
                    {

                        return userInput;
                    }
                    Console.WriteLine("Enter a integer value between between 1 and 5");

                }

                catch
                {
                    Console.WriteLine("Please enter a integer value between 1 and 5");
                }
               
            }
        

        }
        static string CheckFlag()
        {
            
            while (true)
            {
                Console.WriteLine("\ntype 'stop' to end and press <Enter> to continue");
                string userInput1 = Console.ReadLine();
                userInput1 = userInput1.ToLower();
                if (userInput1.Equals("") | userInput1.Equals("stop"))
                {

                    return userInput1;


                }
                Console.WriteLine("\nPlease type 'stop' or press <Enter> to continue");
                Console.WriteLine(userInput1);
            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine(  @" /$$$$$$  / $$                                /$$$$$$" + "\n" +
                                @"/ $$__  $$| $$                               /$$__  $$" + "\n" +
                                @"| $$  \__/| $$$$$$$   /$$$$$$  /$$$$$$/$$$$ | $$  \ $$  /$$$$$$   /$$$$$$ " + "\n" +
                                @"| $$      | $$__  $$ /$$__  $$| $$_  $$_  $$| $$$$$$$$ /$$__  $$ /$$__  $$" + "\n" +
                                @"| $$      | $$  \ $$| $$$$$$$$| $$ \ $$ \ $$| $$__  $$| $$  \ $$| $$  \ $$" + "\n" +
                                @"| $$    $$| $$  | $$| $$_____/| $$ | $$ | $$| $$  | $$| $$  | $$| $$  | $$" + "\n" +
                                @"|  $$$$$$/| $$  | $$|  $$$$$$$| $$ | $$ | $$| $$  | $$| $$$$$$$/| $$$$$$$/" + "\n" +
                                @" \______/ |__/  |__/ \_______/|__/ |__/ |__/|__/  |__/| $$____/ | $$____/" + "\n" +
                                @"                                                      | $$      | $$" + "\n" +
                                @"                                                      | $$      | $$" + "\n" +
                                @"                                                      |__/      |__/" + "\n");
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine("ChemApp is a program that allows you to find the efficiency of\n" +
                "different cleaning chemicals and see the best and worst chemical for cleaning");
            Console.WriteLine("---------------------------------------------------------------------------------------");
            string flag = "";
            while (!flag.Equals("stop"))
            {
                OneChemical();
                flag = CheckFlag();

            }
            Console.WriteLine("#########################################################################\n-Summary-\n");
            Console.WriteLine($"Best Chemical was {bestChemName}, with an efficiency of {mostEfficient}\nWorst chemical was {worstChemName}, with an efficiency of {leastEfficient}");
            Console.WriteLine("#########################################################################");
            Console.ReadLine();
        }

    }
}