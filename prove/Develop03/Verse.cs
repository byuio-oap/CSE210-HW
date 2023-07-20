public class Verse
{
    private List<Word> words;

    public Verse(List<Word> words)
    {
        this.words = words;
    }

    public List<Word> GetWords()
    {
        return words;
    }

    public void Display(List<int> hiddenWordIndices)
    {
        foreach (Word word in words)
        {
            if (hiddenWordIndices.Contains(word.Index))
            {
                Console.Write("________ ");
            }
            else
            {
                Console.Write(word.Text + " ");
            }
        }
    }
}
