public class Reference{

    private string _bookName;
    private string _chapter;
    private string _startVerse;
    private string _endVerse;
    private List<Reference> lstOfReferences = new List<Reference>();

    public string ScriptureReference()
    {
        string scriptureReference =("Matthew;11;28;30;Come unto me, all ye that labour and are heavy laden, and I will give you rest;Come unto me, all ye that labour and are heavy laden, and I will give you rest. Take my yoke upon you, and learn of me for I am meek and lowly in heart and ye shall find rest unto your souls. For my yoke is easy, and my burden is light.");
        return scriptureReference;   
    }
    public void BuildScriptureRefrence()
    {
      string scriptureInScriptureReference =  ScriptureReference();
      string [] scriptureReferencePart=scriptureInScriptureReference.Split(";");
      
      Reference scriptureReferencEntry = new Reference();
      scriptureReferencEntry._bookName=scriptureReferencePart[0];
      scriptureReferencEntry._chapter=scriptureReferencePart[1];
      scriptureReferencEntry._startVerse=scriptureReferencePart[2];
      scriptureReferencEntry._endVerse=scriptureReferencePart[3];

      lstOfReferences.Add(scriptureReferencEntry); 
      
       

    }

   public void  DisplayScriptureReference( )
   {
         
         foreach (Reference item in lstOfReferences)
         {
                         Console.WriteLine($"{item._bookName}:{item._chapter}-{item._startVerse}-{item._endVerse}");        

            
         }
              
            
            
   }
       public string GetReference()
    {
        string reference = $"{_bookName} {_chapter}:";
        foreach(Reference verse in lstOfReferences)
        {
            reference = ($"{verse._bookName} {verse._chapter}:{verse._startVerse}-{verse._endVerse}");
        }
    
        return reference;
     }
}