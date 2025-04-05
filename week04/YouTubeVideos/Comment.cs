using System;

public class Comment
{
    public string _personName;
    public string _commentText;

    public void Display()
    {
        Console.WriteLine($"{_personName} {_commentText}");
    }
}