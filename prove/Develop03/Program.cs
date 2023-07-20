public class Program
{
    private static ScriptureLibrary scriptureLibrary = new ScriptureLibrary();

    public static void Main(string[] args)
    {
        scriptureLibrary.LoadScripturesFromFile("scriptures.txt");

        List<Scripture> scriptures = scriptureLibrary.GetScriptures();
        foreach (Scripture scripture in scriptures)
        {
            Console.WriteLine();
            scripture.Display();
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to exit...");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            while (!scripture.IsFullyHidden())
            {
                scripture.HideRandomWord();
                Console.Clear();
                Console.WriteLine();
                scripture.Display();
                Console.WriteLine();
                Console.WriteLine("Press enter to continue or type 'quit' to exit...");
                input = Console.ReadLine();
                if (input.ToLower() == "quit")
                {
                    break;
                }
            }

            Console.Clear();
        }
    }
}