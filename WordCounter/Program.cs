using System;
using System.Collections.Generic;
using WordCounter.Models;

class Program
{
    public static void Main()
    {
        List<ConsoleColor> darkColors = new List<ConsoleColor>(){ConsoleColor.DarkBlue, ConsoleColor.DarkGreen, ConsoleColor.DarkRed, ConsoleColor.DarkCyan};
        List<ConsoleColor> colors = new List<ConsoleColor>() { ConsoleColor.Blue, ConsoleColor.Green, ConsoleColor.Red, ConsoleColor.Cyan };
        
        bool retry = true;
        
        while(retry)
        {
            Console.BackgroundColor = colors[GetRandomInt()];
            Console.ForegroundColor = darkColors[GetRandomInt()];
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

    public static int GetRandomInt()
    {
        Random rand = new Random();
        int index = rand.Next(0,4);
        return index;
    }
}