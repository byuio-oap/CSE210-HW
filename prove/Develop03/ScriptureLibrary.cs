public class ScriptureLibrary
{
    private List<Scripture> scriptures;

    public ScriptureLibrary()
    {
        scriptures = new List<Scripture>();
    }

    public void LoadScripturesFromFile(string filePath)
    {
        string[] lines = File.ReadAllLines(filePath);
        foreach (string line in lines)
        {
            string[] parts = line.Split(';');
            if (parts.Length >= 6)
            {
                string book = parts[1];
                int chapter = int.Parse(parts[2]);
                int startVerse = int.Parse(parts[3]);
                int endVerse = int.Parse(parts[4]);
                string referenceText = parts[0];
                string scriptureText = parts[5];
                for (int i = 6; i < parts.Length; i++)
                {
                    scriptureText += ";" + parts[i];
                }
                Reference reference = new Reference(book, chapter, startVerse, endVerse);
                List<Verse> verses = CreateVerses(scriptureText);
                Scripture scripture = new Scripture(reference, verses);
                scriptures.Add(scripture);
            }
        }
    }

    private List<Verse> CreateVerses(string scriptureText)
    {
        List<Verse> verses = new List<Verse>();
        string[] verseTexts = scriptureText.Split(';');
        foreach (string verseText in verseTexts)
        {
            List<Word> words = CreateWords(verseText);
            Verse verse = new Verse(words);
            verses.Add(verse);
        }
        return verses;
    }

    private List<Word> CreateWords(string verseText)
    {
        List<Word> words = new List<Word>();
        string[] wordTexts = verseText.Split(' ');
        for (int i = 0; i < wordTexts.Length; i++)
        {
            string wordText = wordTexts[i];
            words.Add(new Word(wordText, i));
        }
        return words;
    }

    public List<Scripture> GetScriptures()
    {
        return scriptures;
    }
}

