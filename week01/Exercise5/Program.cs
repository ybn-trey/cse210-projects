using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);

        DisplayResult(userName, squareNumber);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName ()
    {
        Console.Write("Please enter your name: ");
        string nameInput = Console.ReadLine();
        return nameInput;
    }
    static int PromptUserNumber ()
    {
        Console.Write("Please enter your favorite number: ");
        string number = Console.ReadLine();
        int numberInput = int.Parse(number);
        return numberInput;
    }
    static int SquareNumber (int numberInput)
    {
        int squareNum = numberInput * numberInput;
        return squareNum;
    }
    static void DisplayResult(string nameInput, int squareNum)
    {
        Console.WriteLine($"{nameInput}, the square of your number is {squareNum}");
    }
}