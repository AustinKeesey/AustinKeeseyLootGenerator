using System;
using System.Collections.Generic;

namespace AustinKeeseyLootGenerator
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length > 0 && args[0] == "test")
            {
                TestAll();
                return; // Exits the program
            }

            // TODO(jcollard 2022-02-11):
            // 1. Prompt the user to get their input from GetValidInt
            // 2. Create an Elements List
            // 3. Create a Powers List
            // 4. Call GenerateRandomLoot with the proper arguments
        }


        public static void TestAll()
        {
            bool testGetValidInt = TestGetValidInt.Runtests();
            Console.WriteLine($"Test LoadFile(GetValidInt): {testGetValidInt}");

            bool testGenerateLoot = TestGenerateLoot.Runtests();
            Console.WriteLine($"Test LoadFile(GetValidInt): {testGenerateLoot}");
        }
        public static string GenerateLoot(List<string> weaponType, List<string> ElementType, List<string> ThemeType)
        {
            // TODO(jcollard 2022-02-11): You're almost done! This method is a
            // little tricky but I've created an example that I hope will help:
            // https://jcollard.github.io/IntroToCSharpSite/examples/random-dog-generator
            return null;
        }

        public static int GetValidInt(string prompt)
        {

            int userChoice;

            do
            {
                Console.Write("Enter a number that is ");

                string input = Console.ReadLine();

                bool isANumber = int.TryParse(input, out userChoice);

                if (isANumber == false)
                {
                    Console.Error.WriteLine("you failed to enter a number");

                }
                else if (userChoice >= 4) //TODO(jcollard 2022-02-11): What if the user selects 0? or -5?
                {
                    Console.WriteLine("That is not a number 1-3");
                }
            }

            while (userChoice < 4); //TODO(jcollard 2022-02-11): Are you sure you should keep looping if the user selected a number less than 4?

            return userChoice;


        }
    }
}
