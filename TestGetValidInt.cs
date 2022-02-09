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



            // TODO(jcollard 2022-02-02): Make a call to the method ValidateInput:
            // Program.GetValidInt("Some String Here");
            // What should the user see when this method is called?
            // What inputs should the user test? Give the tester instructions on how they
            // should test the method. e.g. "Enter 'a'. This should result in an invalid message."
            // "Then, enter -2. This should result in an invalid message."
            // "Finally, enter a valid option 4. This should result in the method returning the int value 4."

            Console.WriteLine("Testing GetValidInt with the string 'How many items to generate?'");
            Console.WriteLine("You should expect to see ?????");
            Console.WriteLine("Type a. This should result in ????.");
            Console.WriteLine("Type -5. This should result in ????.");
            Console.WriteLine("Type 3. This should result in ????.");
            int result = Program.GetValidInt("How many items to generate?");

            if (result != ???) // Check that the result is the expected value. If it is NOT the expected value
            {
                Console.Error.WriteLine($"Failed: Expected the result to be ???? but was {result}.");
                return false;
            }
        return false;
    }
    
    }
}