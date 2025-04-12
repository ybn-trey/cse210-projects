using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private static int _timesPerformed = 0;

    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience?",
        "What did you learn about yourself?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times when you've shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") { }

     public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        DisplayPrompt();

        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they are related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(3);

        Console.Clear();

        int duration = GetDuration();
        int elapsed = 0;
        Random rand = new Random();

        while (elapsed < duration)
        {
            Console.WriteLine($"> {GetRandomQuestion()}");
            ShowSpinner(4);
            elapsed += 5;
        }

        _timesPerformed++;
        DisplayEndingMessage();
        Console.WriteLine($"You've done the Reflecting Activity {_timesPerformed} time(s).");
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        Random rand = new Random();
        return _questions[rand.Next(_questions.Count)];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
    }

    public void DisplayQuestions()
    {
        foreach (var question in _questions)
        {
            Console.WriteLine($"> {question}");
            ShowSpinner(3);
        }
    }
}