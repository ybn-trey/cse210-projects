using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Forex strategy", "Alice", 300);
        video1.AddComment(new Comment("John", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Lisa", "Love your tutorials."));
        video1.AddComment(new Comment("Mark", "Made enough profits from this"));
        videos.Add(video1);

        Video video2 = new Video("FC 25", "Bob", 450);
        video2.AddComment(new Comment("Anna", "Cool game!"));
        video2.AddComment(new Comment("Addams", "How did you do that spin move?"));
        video2.AddComment(new Comment("Billy", "Great graphics!"));
        videos.Add(video2);

        Video video3 = new Video("How to drift a car", "Charles", 600);
        video3.AddComment(new Comment("Steve", "This cleared up my confusion."));
        video3.AddComment(new Comment("Lizzie", "Loved the real-world example."));
        video3.AddComment(new Comment("Mina", "I'm enlightened now!"));
        videos.Add(video3);

        Video video4 = new Video("Making money online", "Diana", 350);
        video4.AddComment(new Comment("Ray", "This is powerful!"));
        video4.AddComment(new Comment("Elaine", "I wish I knew this sooner."));
        video4.AddComment(new Comment("Raji", "I'm off to making some money!"));
        videos.Add(video4);

        
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}