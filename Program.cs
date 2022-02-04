﻿using System;
using System.Collections.Generic;

namespace AustinKeeseyLootGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Checks if the user added a command line argument
            // Also checks if the first argument is "test"
            if (args.Length > 0 && args[0] == "test")
            {
                TestAll();
                return; // Exits the program
            }

            // Otherwise, the program continues
        }


        public static void TestAll()
        {
            bool testGetValidInt = TestGetValidInt.Runtests();
            Console.WriteLine($"Test LoadFile(GetValidInt): {testGetValidInt}");

            bool testGetUserSelection = TestGetUserSelection.Runtests();
            Console.WriteLine($"Test LoadFile(GetValidInt): {testGetValidInt}");
        }

        public static string GenerateLoot(List<string> weaponType, List<string> ElementType, List<string>ThemeType)
        {
            // 1. Validate the prompt is a string
            // 2. Display the Prompt
            // 3. Read input from the user
            // 4. If the user entered an invalid type, element, or theme
            // - display an error message
            // - go to step 2
            // 5. Otherwise, return the users input
            return null;
        }

        /// <summary>
        /// Given a prompt to show the user, display the prompt then reads the input from the keyboard until the user enters a valid type. If the user enters an invalid type, this method displays an error message and prompts the user to try again.
        /// </summary>
        /// <param name="prompt">TODO: Complete documentation</param>
        /// <returns>TODO: Complete documentaiton</returns>
        public static int GetValidInt(string prompt)
        {
            // TODO 1.) Create a random loot generator
            // 2.) Generate a random number, TypeIndex, between 0 and Type.Count
            // 3.) Generate a random number, ElementIndex, between 0 and Element.Count
            // 4.) Generate a random number, ThemeIndex, between 0 and Theme.Count
            // 5.) Combine the different aspects of the loot together
            // Type[TypeIndex] + " " + Element[ElementIndex] + " " + Theme[ThemeIndex];
            // 6.) Return the loot
            return -1;
        }
    }
}
