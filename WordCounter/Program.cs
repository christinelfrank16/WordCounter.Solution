using System;
using WordCounter.Models;

class Program
{
    public static void Main()
    {

        bool retry = true;
        while(retry)
        {
            string sentence = GetInput("Please enter a sentence.", "No value detected. Please retry.");
            string word = GetInput("Please enter a search word.", "No value detected. Please retry.");
            
            int wordCount = Counter.RunCounter(sentence, word);
            Console.WriteLine(wordCount.ToString() + (wordCount == 1 ? " instance " : " instances ") + "of " + word + (wordCount == 1 ? " was " : " were ")  +"found!");
            retry = PlayAgain(retry);
        }
    }

    public static string GetInput(string message, string retryMessage)
    {
        Console.WriteLine(message);
        string value = "";
        bool hasContent = false;
        while (!hasContent)
        {
            value = Console.ReadLine();
            hasContent = Counter.CheckForContent(value);
            if (!hasContent)
            {
                Console.WriteLine(retryMessage);
            }
        }
        return value;
    }

    public static bool PlayAgain(bool retry)
    {
        Console.WriteLine("");
        Console.WriteLine("Would you like to play again? [Y/N]");
        string reply = Console.ReadLine().ToLower();
        if (reply != "y" && reply != "yes")
        {
            retry = false;
            Console.WriteLine("Exiting the app. Thanks for playing!");
        }
        return retry;
    }
}