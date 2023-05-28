
public class Scriptures

{
 private string _verse;
 private List <Scriptures>lstScriptures=new List<Scriptures>();
 Reference clsReferen = new Reference();

public void BuildScripture(){
     string scriptureReference=clsReferen.ScriptureReference();

     string [] scriptureReferencePart=scriptureReference.Split(";");
      
      Scriptures scriptureReferencEntry = new Scriptures();
      scriptureReferencEntry._verse=scriptureReferencePart[5];
      lstScriptures.Add(scriptureReferencEntry);
      
      }


 public string GetScripture()
    {
        string escritura = $"{_verse}";
        foreach(Scriptures verse in lstScriptures)
        {
          escritura = ($"{verse._verse}");

        }
        
        return escritura;
        
    }

}