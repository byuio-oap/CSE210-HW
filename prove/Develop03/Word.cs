using System;
public class Word
{
public string _words = "";
 public string _ref = "";
 public string[] _arrayofWords;
public List<int> _hiddenWords;

 public Word()
    {
    }

    public void GetRenderedText(Scriptures scripture)
    {
        var _words = scripture.GetScripture();
        _arrayofWords = _words.Split(" ");
        _hiddenWords = new List<int>();
    }
    

    public void ShowScripture(string referense)
    {
       _ref = referense;
        Console.Clear();
        Console.Write("\n**** Press spacebar or enter to hide words ****");
        Console.Write("\n**** Press Q to Quit ****\n");
        
        Console.WriteLine($"{_ref}");
        for (var i = 0; i < _arrayofWords.Length; i++)
        {
            var singleWordFromArray = _arrayofWords[i];
            int len = singleWordFromArray.Length;
            string dashedLine = new String('_', len);
            if (_hiddenWords.Contains(i))
            {
                Console.Write($"{dashedLine} ");
            }
            else
            {
                Console.Write($"{singleWordFromArray} ");
            }
        }
    }

    public void GetReadKey()
    {
        var input = Console.ReadKey();
        if (input.Key == ConsoleKey.Spacebar || input.Key == ConsoleKey.Enter)
        {
            GetNewHiddenWord();
        }
        else if (input.Key == ConsoleKey.Q)
        {
            Environment.Exit(0);
        }

    }
    public void GetNewHiddenWord()
    {
    
        var random = new Random();
        var index1 = random.Next(_arrayofWords.Length);
        var index2 = random.Next(_arrayofWords.Length);
        var index3 = random.Next(_arrayofWords.Length);

        if (_hiddenWords.Contains(index1) || _hiddenWords.Contains(index2)||_hiddenWords.Contains(index3))
        {
            GetNewHiddenWord();
        }
        else
        {
            _hiddenWords.Add(index1);
            _hiddenWords.Add(index2);
            _hiddenWords.Add(index3);

        }
    }


}