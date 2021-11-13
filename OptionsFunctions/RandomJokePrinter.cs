using System;

namespace DadJokesConsoleApplication.OptionsFunctions
{
    public class RandomJokePrinter
    {
        public void PrintRandomJoke()
        {
            Random rnd = new Random();
            int index = rnd.Next(DadJokesData.DadJokesQuestions.Length);

            Utilities.CreateJokeWithPunchline(index, index);

            SystemUtilities.ReturnToMainMenu();
        }
    }
}
