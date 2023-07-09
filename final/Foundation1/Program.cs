using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation1 World!");
        List<Video> videos=new List<Video>();
        
        Video video1=new Video("MESSI DESTROYED! THE BEST PLAYER OF ALL TIME GAVE A SHOW AND WAS A STANDING APPLAUSE","SIAN SPOPRTS",1120);//Invokes Constructor on Video Class
        video1.AddComment("@rrmunoz1245","Now that he won the WC theres no pressure at all hes finally free to remind the world why he the GOAT");
        video1.AddComment("@ibuporfiado52","Ese arquero tapó cada pelota, es tremendo VIVA EL FÚTBOL");
        video1.AddComment("@manishedai","The greatest of all times .");

        Video video2=new Video("EVEN RETIRED AND BEAUTIFUL DAVID BECKHAM DESTROYED IN THIS FRIENDLY MATCH AGAINST RONALDINHO","SS Sports",8520);//Invokes Constructor on Video Class
        video2.AddComment("@springofbliss3571","David Beckham’s vision and pass accuracy is unmatched and rare. Excellent!!");
        video2.AddComment("@noelgol1245","Ronaldinho in Braca, Beckham in MU, Figo in RM, Sedrof in ACM,.....  what a memories");
        video2.AddComment("@bestsoccer8574","Beckham's passing accuracy is amazing... what a legend.");

        Video video3=new Video("FIFA World Cup 2006 All Goals","RPTimao TV",7452);//Invokes Constructor on Video Class
        video3.AddComment("@roma152","The 2006 World Cup was the pinnacle of World Cups. So many stacked squads with legends!");
        video3.AddComment("@userGol","Personally my favourite WC. The squads, the legends, the kits, the ball, the stadiums... everything was awesome. Never forget.");
        video3.AddComment("@gb2006","It is remarkable how many long range shots were scored compared to now. Football changed a lot..");

        videos.Add(video1); //adds to the list above
        videos.Add(video2); //adds to the list above
        videos.Add(video3); //adds to the list above

        foreach (Video video in videos)//iterate through list above
        {
            video.DisplayInfomation();
       }

    }
}