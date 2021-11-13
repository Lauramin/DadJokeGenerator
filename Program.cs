using System;
using DadJokesConsoleApplication.OptionsFunctions;

namespace DadJokesConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;

            while (showMenu)
            {
                PrintMainMenuOptions();
                showMenu = SelectMenuOption();
            }

        }

        private static void PrintMainMenuOptions()
        {
            Console.Clear();
            Console.WriteLine("Do you want to hear AN AWESOME Dad Joke? Choose an option: ");
            Console.WriteLine("1. The app will print a random joke.");
            Console.WriteLine("2. The app will print a full list of jokes.");
            Console.WriteLine("3. The app will print a joke by Your's selected number.");
            Console.WriteLine("4. The app will print a mixed joke");
            Console.WriteLine("5. Exit the application");
            Console.Write("\r\nSelect an option: ");
        }

        private static bool SelectMenuOption()
        {
            switch (Console.ReadLine())
            {
                case "1":
                    new RandomJokePrinter().PrintRandomJoke();
                    return true;

                case "2":
                    new AllJokesPrinter().PrintAllJokes();
                    return true;

                case "3":
                    new SpecificJokePrinter().PrintSpecificJoke();
                    return true;

                case "4":
                    new MixedJokePrinter().PrintMixedJoke();
                    return true;

                case "5":
                    SystemUtilities.Exit();
                    return false;

                default:
                    SystemUtilities.ReturnAfterFailedCase();
                    return true;
            }
        }

    }
}
