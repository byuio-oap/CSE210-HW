using System;
using System.Collections.Generic;
using System.IO;

public class Scripture
{
    private Reference reference;
    private List<Verse> verses;
    private List<int> hiddenWordIndices;

    public Scripture(Reference reference, List<Verse> verses)
    {
        this.reference = reference;
        this.verses = verses;
        this.hiddenWordIndices = new List<int>();
    }

    public Reference GetReference()
    {
        return reference;
    }

    public List<Verse> GetVerses()
    {
        return verses;
    }

    public void Display()
    {
        Console.WriteLine(reference.GetFormattedReference());
        foreach (Verse verse in verses)
        {
            verse.Display(hiddenWordIndices);
            Console.WriteLine();
        }
    }

    public bool HideRandomWord()
    {
        List<int> availableIndices = GetAvailableWordIndices();
        if (availableIndices.Count == 0)
        {
            return false;
        }

        Random random = new Random();
        int randomIndex = random.Next(0, availableIndices.Count);
        int wordIndex = availableIndices[randomIndex];
        hiddenWordIndices.Add(wordIndex);
        return true;
    }

    private List<int> GetAvailableWordIndices()
    {
        List<int> availableIndices = new List<int>();
        for (int i = 0; i < verses.Count; i++)
        {
            Verse verse = verses[i];
            for (int j = 0; j < verse.GetWords().Count; j++)
            {
                if (!hiddenWordIndices.Contains(j))
                {
                    availableIndices.Add(j);
                }
            }
        }
        return availableIndices;
    }

    public bool IsFullyHidden()
    {
        return hiddenWordIndices.Count == GetTotalWordCount();
    }

    private int GetTotalWordCount()
    {
        int count = 0;
        foreach (Verse verse in verses)
        {
            count += verse.GetWords().Count;
        }
        return count;
    }
}

