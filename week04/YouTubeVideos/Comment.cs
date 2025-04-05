using System;

public class Comment
{
    public string _personName;
    public string _commentText;

    public Comment(string personName, string commentText)
    {
        _personName = personName;
        _commentText = commentText;
    }

    public void Display()
    {
        Console.WriteLine($"{_personName} {_commentText}");
    }
}