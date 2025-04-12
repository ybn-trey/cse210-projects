using System;

public class BreathingActivity : Activity
{
    private static int _timesPerformed = 0;

    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();
        int cycleTime = 6;
        int cycles = duration / cycleTime;

        for (int i = 0; i < cycles; i++)
        {
            Console.Write("Breathe in...");
            ShowCountDown(3);
            Console.Write("Now breathe out...");
            ShowCountDown(3);

            Console.WriteLine();
        }
 
        _timesPerformed++;
        DisplayEndingMessage();
        Console.WriteLine($"You've done the Breathing Activity {_timesPerformed} time(s).");
    }
}