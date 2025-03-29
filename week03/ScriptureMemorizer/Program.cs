using System;
using System.IO;

// Made my program read the bible verse from a file

class Program
{
    static void Main(string[] args)
    {
        string fileName = "bible.txt";
        string[] lines = File.ReadAllLines(fileName);
        string[] parts = lines[0].Split('|');

        Reference reference = new Reference(parts[0].Trim(), int.Parse(parts[1]), int.Parse(parts[2]), int.Parse(parts[4]));
        string scriptureText = parts[3].Trim() + " " + parts[5].Trim();

        Scripture scripture = new Scripture(reference, scriptureText);

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress ENTER to hide more words or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(2);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("");
    }
}