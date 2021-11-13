using System;


namespace DadJokesConsoleApplication.OptionsFunctions
{
    class AllJokesPrinter
    {
        public void PrintAllJokes()
        {
            Console.WriteLine("      A List of Jokes     ".ToUpper());
            Console.WriteLine(" Press Enter for a next joke    ");

            System.Threading.Thread.Sleep(1000);

            for (int i = 0; i < DadJokesData.DadJokesQuestions.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($" {DadJokesData.DadJokesQuestions[i]}");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($" {DadJokesData.DadJokesPunchlines[i]}");
                Console.ReadLine();

                Console.ResetColor();
            }

            Console.WriteLine("     The end of the list     ".ToUpper());
            Console.WriteLine("Press Enter to return to Menu");
            Console.ReadLine();
        }
    }
}
