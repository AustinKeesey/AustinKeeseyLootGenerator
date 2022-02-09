using System;
using System.Collections.Generic;
using System.IO;

namespace AustinKeeseyLootGenerator
{

    class GenerateLoot
    {
        public static bool Runtests()
        {

            List<string> elements = new List<string>();
            elements.Add("fire");
            elements.Add("ice");
            elements.Add("lightning");
            List<string> themes = new List<string>();
            themes.Add("godly");
            themes.Add("cursed");
            themes.Add("magical");

            if(!result.StartsWith("sword fire godly"))
            {
                Console.Error.WriteLine($"The result was expected to be {theme}");
                return false;

            }

            string result = Program.GenerateLoot(weapons, elements, themes);
            return true;
        }

    }
}