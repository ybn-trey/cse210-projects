using System;
using System.Collections.Generic;
using System.IO;

//added certain clauses to address a case whereby a wrong input was provided or a situation where nothing was provided.

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Entry newEntry = new Entry();
                    newEntry._date = DateTime.Now.ToString("MM/dd/yyy");
                    newEntry._promptText = promptGen.GetRandomPrompt();
                    
                    Console.WriteLine(newEntry._promptText);
                    Console.Write("> ");
                    newEntry._entryText = Console.ReadLine();
                    
                    myJournal.AddEntry(newEntry);
                    
                    break;

                case "2":
                    myJournal.DisplayAll();
                    break;

                case "3":
                    Console.WriteLine("What is the filename?");
                    string saveFile = Console.ReadLine();
                    myJournal.SaveToFile(saveFile);
                    break;

                case "4":
                    Console.WriteLine("What is the filename?");
                    string loadFile = Console.ReadLine();
                    myJournal.LoadFromFile(loadFile);
                    break;

                case "5":
                    running = false;
                    
                    break;

                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;

            }
        }
    }
}