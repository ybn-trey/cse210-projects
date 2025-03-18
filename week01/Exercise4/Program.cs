using System;

class Program
{
    static void Main(string[] args)
    {
        List<int>numbers;
        numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 if finished.");
        int number;

        do
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);

            if (number > 0)
            {
                numbers.Add(number);
            } 

        }while (number != 0);

        int sum = 0;
        foreach (int figure in numbers)
        {
            sum += figure;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

         int max = numbers[0];

        foreach (int figure in numbers)
        {
            if (figure > max)
            {
                
                max = figure;
            }
        }

        Console.WriteLine($"The largest number is: {max}");

    }
}