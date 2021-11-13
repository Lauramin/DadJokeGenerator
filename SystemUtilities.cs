using System;

namespace DadJokesConsoleApplication
{
    public class SystemUtilities
    {
        public static void Exit()
        {
            Console.WriteLine("Goodbey.");
            Console.WriteLine("Press any key to close the Dad Joke Console Application");

            System.Environment.Exit(0);
        }

        public static void ReturnToMainMenu()
        {
            Console.WriteLine("\r\nPress Enter to return to Main Menu.");
            Console.ReadLine();
        }

        public static void ReturnAfterFailedCase()
        {
            Console.WriteLine("\r\nInvalid characters.Press any key to back to Menu.");
            Console.ReadLine();
        }

        private SystemUtilities()
        {

        }


    }
}
