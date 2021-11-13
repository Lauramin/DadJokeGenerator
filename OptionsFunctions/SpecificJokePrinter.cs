using System;

namespace DadJokesConsoleApplication.OptionsFunctions
{
    public class SpecificJokePrinter
    {
        public void PrintSpecificJoke()
        {
            Console.WriteLine("Do you want to know how many jokes I know? (Yes/No)");
            string userAnswer = Console.ReadLine().ToLower();

            if (userAnswer == "yes" | userAnswer == "y")
            {
                int arrayLenght = DadJokesData.DadJokesQuestions.Length;
                Console.Write("Well, I know " + arrayLenght + " jokes. Now, pick a number: ");

                int userSelectedQuestionNumber;
                int requestedQuestionIndex;

                while (true)
                {
                    userSelectedQuestionNumber = int.Parse(Console.ReadLine());
                    requestedQuestionIndex = userSelectedQuestionNumber - 1;

                    if (requestedQuestionIndex < arrayLenght && requestedQuestionIndex >= 0)
                    {
                        break;
                    }
                    Console.WriteLine("Wrong number. Choose number between 1 and " + arrayLenght);

                }
                Console.WriteLine("A joke number " + userSelectedQuestionNumber + ".");

                Utilities.CreateJokeWithPunchline(requestedQuestionIndex, requestedQuestionIndex);

                SystemUtilities.ReturnToMainMenu();
            }

            else
            {
                int arrayLenght = DadJokesData.DadJokesQuestions.Length;
                Console.WriteLine("Well, that a shame. I know " + arrayLenght + " AWESOME jokes. But I will keep it to myself.");

                SystemUtilities.ReturnToMainMenu();
            }
        }
    }
}