using System;
using System.Collections.Generic;
using System.Diagnostics;


public class ListingActivity : Activity
{
    private int _count;
    private static int _timesPerformed = 0;

    private List<string>_prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by listing as many items as you can.") { }

    public void Run()
    {
        DisplayStartingMessage();
        Random rand = new Random();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {_prompts[rand.Next(_prompts.Count)]} ---");
        Console.WriteLine("You may begin in:");
        ShowCountDown(3);

        List<string> items = GetListFromUser();
        _count = items.Count;

        _timesPerformed++;
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
        Console.WriteLine($"You've done the Reflecting Activity {_timesPerformed} time(s).");
    }

    public void GetRandomPrompt()
    {
        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
    }

    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        int duration = GetDuration();

        Stopwatch sw = new Stopwatch();
        sw.Start();

        while (sw.Elapsed.TotalSeconds < duration)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                responses.Add(input);
            }
        }
        sw.Stop();
        return responses;
    }
}