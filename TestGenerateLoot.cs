using System;
using System.Collections.Generic;
using System.IO;

namespace AustinKeeseyLootGenerator
{

    class TestGenerateLoot
    {
        public static bool Runtests()
        {
            List<string> weapons = new List<string>();
            weapons.Add("weapons");
            // weapon.Add("melee")
            // weapon.Add("projectile")
            List<string> elements = new List<string>();
            elements.Add("fire");
            // elements.Add("ice");
            // elements.Add("lightning");
            List<string> themes = new List<string>();
            themes.Add("godly");
            // themes.Add("cursed");
            // themes.Add("magical");
            string result = Program.GenerateLoot(weapons, elements, themes);

            if (!result.StartsWith("sword fire godly"))
            {
                Console.Error.WriteLine($"The result was expected to be {themes[0]}, {elements[0]}, sword");
                return false;

            }

            string result2 = Program.GenerateLoot(elements, weapons, themes);

            if (!result2.StartsWith("sword fire godly"))
            {
                Console.Error.WriteLine($"the result was expected to be fire {themes[0]}, {weapons}");
                return false;
            }
            
            string result3 = Program.GenerateLoot(themes, elements, weapons);
            if (!result3.StartsWith("fire godly sword"))
            {
                Console.Error.WriteLine($"the result was expected to be godly {themes[0]}, {weapons}");
                return false;
            }
            return true;
        }

    }
}