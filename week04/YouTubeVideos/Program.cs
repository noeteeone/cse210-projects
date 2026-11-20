using System;
using System.Collections.Generic;
using System.Transactions;
using YouTubeVideos;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        List<Video> videoList = new List<Video>();
        
        //Video 1
        Video video1 = new Video("Learn C# in 10 Minutes", "CodeAcademy", 600);
        video1.AddComment("Alice", "This was incredibly helpful, thank you!");
        video1.AddComment("Bob", "Clear and concise. Perfect for beginners.");
        video1.AddComment("Charlie", "Can you make a follow-up video on object-oriented programming?");
        videoList.Add(video1);

        //video 2
        Video video2 = new Video("Ultimate Sourdough Bread Guide", "Baking with Julia", 1200);
        video2.AddComment("Diana", "My crust finally turned out crispy!");
        video2.AddComment("Ethan", "What temperature should the water be?");
        video2.AddComment("Fiona", "Best baking tutorrial on the internet hands down.");
        videoList.Add(video2);

        //video 3
        Video video3 = new Video("Exploring the Deep Ocean", "Nature Channel", 2700);
        video3.AddComment("George", "The footage of the giant squid was breathtaking.");
        video3.AddComment("Hannah", "It is crazy how little we know about our own oceans.");
        video3.AddComment("Ian", "The narrator has such a soothing voice.");
        videoList.Add(video3);

        //video 4
        Video video4 = new Video("Keyboard Typing ASMR (1 Hour)", "RelaxSounds", 3600);
        video4.AddComment("Julia", "Fell asleep within 5 minutes. Amazing.");
        video4.AddComment("Kevin", "The mechanical switches sound so crisp.");
        video4.AddComment("Lily", "This is exactly what I needed to finish my essay");
        videoList.Add(video4);

        //iterate through the list and display the information
        foreach (Video video in videoList)
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds}");
            Console.WriteLine($"Number of Comments: {video.Comments.Count}");
            Console.WriteLine("Comments: ");

            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($" - {comment.Name}: \"{comment.Text}\"");;
            }
            // Completed the broken output line below
            Console.WriteLine($"Channel: {video.Author} | Duration: {video.LengthInSeconds} seconds");
        }
        Console.WriteLine(new string('-', 50));
    }
}

