using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        var wordsToHide = _words.Where(w => !w.IsHidden()).OrderBy(w => random.Next()).Take(numberToHide);

        foreach (var word in wordsToHide)
        {
            word.Hide();
        }
    }

    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()} - {string.Join(" ", _words.Select(w => w.GetDisplayText()))}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}