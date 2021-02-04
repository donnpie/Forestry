using System;

namespace ForestryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleAppMethods Methods = new ConsoleAppMethods();

            //Show welcome message
            Methods.WelcomeMessage();
            Methods.ShowMainMenu();
            Methods.MainLoop();





            Console.WriteLine($"The program has reached the end");

        }
    }
}
