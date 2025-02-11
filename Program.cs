using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        // Print a message to the console
        Console.WriteLine("Hello, World!");

        // Ask the user for their name
        Console.Write("What is your name? ");
        string name = Console.ReadLine();

        // Greet the user
        Console.WriteLine("Nice to meet you, " + name + "!");

        // End of the program
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
