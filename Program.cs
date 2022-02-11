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
                else if (userChoice >= 4)
                {
                    Console.WriteLine("That is not a number 1-3");
                }
            }

            while (userChoice < 4);

            return userChoice;

        
        }
    }
}
