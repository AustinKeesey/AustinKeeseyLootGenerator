using System;
using System.IO;

namespace AustinKeeseyLootGenerator
{

    class TestGetValidInt
    {
        public static bool Runtests()
    {
        Console.WriteLine("The method should display 'How many options would you like?'");
        Console.WriteLine("Type '!'. You should see 'Invalid!'");
        Console.WriteLine("Then type '-4'. You should see 'Invalid'.");
        int result = Program.GetValidInt("How many options would you like?");

        if (result !=3)
        {
            Console.Error.WriteLine($"The result was expected to be 3 but it was {result}.");
            return false;
        }        


        return true;
    }
    
    }
}