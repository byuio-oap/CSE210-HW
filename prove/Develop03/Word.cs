public class Word
{
    private string text;
    private int index;

    public string Text
    {
        get { return text; }
    }

    public int Index
    {
        get { return index; }
    }

    public Word(string text, int index)
    {
        this.text = text;
        this.index = index;
    }
}

