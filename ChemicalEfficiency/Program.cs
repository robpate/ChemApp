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
                Console.WriteLine("type 'stop' to end and press <Enter> to continue");
                string userInput = Console.ReadLine();
                userInput = userInput.ToLower();
                if (userInput.Equals("") | userInput.Equals("stop"))
                {

                    return userInput;


                }
                Console.WriteLine("Please type 'stop' or press <Enter> to continue");
                Console.WriteLine(userInput);
            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("------Welcome to ChemicalApp------\n" +
                "ChemicalApp is a program that allows you to test different cleaning chemicals and determine which of them is the most and least efficient at killing germs.");
            string flag = "";
            while (!flag.Equals("stop"))
            {
                OneChemical();
                flag = CheckFlag();

            }
            Console.WriteLine($"Best Chemical was {bestChemName}, with an efficiency of {mostEfficient}\nWorst chemical was {worstChemName}, with an efficiency of {leastEfficient}");
            Console.ReadLine();
        }

    }
}