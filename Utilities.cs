using System;

namespace DadJokesConsoleApplication
{
    public class Utilities
    {
        public static void CreateJokeWithPunchline(int jokeIndex, int punchlineIndex)
        {
        System.Threading.Thread.Sleep(500);

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(DadJokesData.DadJokesQuestions[jokeIndex]);

        System.Threading.Thread.Sleep(1500);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(DadJokesData.DadJokesPunchlines[punchlineIndex]);

        System.Threading.Thread.Sleep(500);

        Console.ResetColor();
        }
        
        private Utilities()
        {
        }
    }
}
