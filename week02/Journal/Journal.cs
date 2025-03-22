using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries;

    public void AddEntry(Entry newEntry)
    {
        if (_entries == null)
        _entries = new List<Entry>();

        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries == null || _entries.Count == 0)
        {
            Console.WriteLine("No entries yet.");
            return;
        }
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        string fileName = "responses.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine("File not found.");
            return;
        }
        string fileName = "responses.txt";
        _entries = new List<Entry>();


        foreach (string line in File.ReadAllLines(fileName))
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                Entry entry = new Entry
                {
                    _date = parts[0],
                    _promptText = parts[1],
                    _entryText = parts[2]
                };
                
                _entries.Add(entry);
            }
        }
        
    }
}