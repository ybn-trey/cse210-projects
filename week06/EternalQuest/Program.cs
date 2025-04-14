using System;
// made the program automatically save and load from goals.txt file without user writing the filename
class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}