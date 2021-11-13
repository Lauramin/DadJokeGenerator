using System;

namespace DadJokesConsoleApplication.OptionsFunctions
{
    public class MixedJokePrinter
    {
        public void PrintMixedJoke()
        {
            Console.WriteLine("One random joke for You:");
            Random rnd = new Random();
            int jokeIndex = rnd.Next(DadJokesData.DadJokesQuestions.Length);
            int punchlineIndex = rnd.Next(DadJokesData.DadJokesPunchlines.Length);

            Utilities.CreateJokeWithPunchline(jokeIndex,punchlineIndex);

            SystemUtilities.ReturnToMainMenu();
        }
    }
}
