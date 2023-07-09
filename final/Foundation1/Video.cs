class Video{
           private string Title {get;}
           private string Author{get;}
           private int Length {get;}
           private List<Comment>Comments{get;}

public Video(string title,string author,int lenght)
{
    Title=title;
    Author=author;
    Length=lenght;
    Comments=new List<Comment>();
}      

public void AddComment(string name,string text)
{
    Comment comment=new Comment(name,text);//Invokes Comment Constructor in Comment Class
    Comments.Add(comment); //Add create comment to List "Comments"
    
}
public int GetNumberOfComments()
{
    return Comments.Count;
}
 public void DisplayInfomation()
 {
    Console.WriteLine("Title: " + Title);
    Console.WriteLine("Author: " + Author);
    Console.WriteLine("Length: " + Length + " seconds");
    Console.WriteLine("Number of comments: " + GetNumberOfComments());
    Console.WriteLine("Comments:");
    foreach (Comment comment in Comments)//iterate through comment list above
    {
        Console.WriteLine($"Comment by  {comment.Name} : {comment.Text}");
    }
    Console.WriteLine();

 }


}