using System;




class Program
{
    static void Main(string[] args)
    {
     Reference clsReference = new Reference();
     clsReference.BuildScriptureRefrence();
     string scriptReference=clsReference.GetReference();
    // clsReference.DisplayScriptureReference();
    Word word = new Word();
     Scriptures clsScripture = new Scriptures();
     clsScripture.BuildScripture();
     string scriptre=clsScripture.GetScripture();
     word.GetRenderedText(clsScripture);
  //  word.GetRenderedRef(clsScripture);
     //Console.WriteLine($"{refer}  {script}");
     
     while (word._hiddenWords.Count < word._arrayofWords.Length)
                    {
                        word.ShowScripture(scriptReference);
                        word.GetReadKey();
                    }
                    word.ShowScripture(scriptReference);
    


     

    }

}

    

   


