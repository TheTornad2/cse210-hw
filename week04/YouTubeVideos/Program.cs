using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("How to Cook Pasta", "Chef John", 600);
        Video video2 = new Video("Top 10 Travel Destinations", "Travel Guru", 1200);
        Video video3 = new Video("Learn Guitar in 10 Minutes", "Music Pro", 900);

        // Add comments to video 1
        video1.AddComment(new Comment("Alice", "Great recipe!"));
        video1.AddComment(new Comment("Bob", "Tried it and loved it."));
        video1.AddComment(new Comment("Charlie", "Easy to follow."));

        // Add comments to video 2
        video2.AddComment(new Comment("Diana", "I want to visit all of these places."));
        video2.AddComment(new Comment("Evan", "Nice selection."));
        video2.AddComment(new Comment("Fiona", "Amazing video!"));

        // Add comments to video 3
        video3.AddComment(new Comment("George", "Finally learning guitar!"));
        video3.AddComment(new Comment("Hannah", "Thanks for the tips."));
        video3.AddComment(new Comment("Ivan", "Well explained."));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display information for each video
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.CommenterName}: {comment.CommentText}");
            }
            Console.WriteLine(); 
        }
    }
}
