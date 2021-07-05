using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            PromptData promptData = new PromptData();

            string anotherPrompt;
            do
            {
                Prompt prompt = promptData.GetPrompt();
                prompt.FillInBlanks();
                prompt.DisplayMadLib();
                Console.WriteLine("Do you want another Mad Lib? Type 'y' for one more, or any other key to quit ");
                anotherPrompt = Console.ReadLine();
            } while (anotherPrompt == "y");
            Console.WriteLine("Goodbye.");
        }
    }
}
