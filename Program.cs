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

            
            List<string> elements = new List<string>();

            elements.Add("fire");
            elements.Add("ice");
            elements.Add("lightning");

            List<string> themes = new List<string>();

            themes.Add("godly");
            themes.Add("cursed");
            themes.Add("magical");

            List<string> weapons = new List<string>();

            weapons.Add("dagger");
            weapons.Add("bow and arrow");
            weapons.Add("axe");

            int combos = GetValidInt("How many loot combinations would you like?");


            while (combos > 0)
            {

                string loot = GenerateLoot(weapons, elements, themes);
                Console.WriteLine($"You acquired {loot}");
                combos = combos - 1;
            }
                    // why is this underlined I am confused
       
        }


        public static void TestAll()
        {
            bool testGetValidInt = TestGetValidInt.Runtests();
            Console.WriteLine($"Test LoadFile(GetValidInt): {testGetValidInt}");

            bool testGenerateLoot = TestGenerateLoot.Runtests();
            Console.WriteLine($"Test LoadFile(GetValidInt): {testGenerateLoot}");
        }
        public static string GenerateLoot(List<string> weapons, List<string> elements, List<string> themes)
        {
            // TODO(jcollard 2022-02-11): You're almost done! This method is a
            // little tricky but I've created an example that I hope will help:
            // https://jcollard.github.io/IntroToCSharpSite/examples/random-dog-generator

            

            Random generator = new Random();
            int index = generator.Next(0, weapons.Count);

            string randomWeapon = weapons[index];
            // Console.WriteLine($"You found a {randomWeapon}");

            int index2 = generator.Next(0, elements.Count);

            string randomElement = elements[index2];
            // Console.WriteLine($"You found a {randomElement}");

            int index3 = generator.Next(0, themes.Count);

            string randomTheme = themes[index3];
            // Console.WriteLine($"You found a {randomTheme}");


            return $"{randomTheme} {randomElement} {randomWeapon}";
        }

        public static int GetValidInt(string prompt)
        {

            if (prompt == null)
            {
                throw new Exception("That is invalid");
            }

            int userChoice;

            do
            {
                Console.Write($"{prompt}: ");

                string input = Console.ReadLine();

                bool isANumber = int.TryParse(input, out userChoice);

                if (isANumber == false)
                {
                    Console.Error.WriteLine("you failed to enter a number");

                }
                else if (userChoice >= 4 || userChoice <= 0) //TODO(jcollard 2022-02-11): What if the user selects 0? or -5?
                {
                    Console.WriteLine("That is not a number 1-3");
                    
                }
            }

            while (userChoice >= 4 || userChoice <= 0); //TODO(jcollard 2022-02-11): Are you sure you should keep looping if the user selected a number less than 4?

            return userChoice;


        }
    }
}
