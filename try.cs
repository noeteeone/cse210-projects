using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold the videos
        List<Video> videoList = new List<Video>();

        // Video 1
        Video video1 = new Video("Learn C# in 10 Minutes", "CodeAcademy", 600);
        video1.AddComment("Alice", "This was incredibly helpful, thank you!");
        video1.AddComment("Bob", "Clear and concise. Perfect for beginners.");
        video1.AddComment("Charlie", "Can you make a follow-up video on object-oriented programming?");
        videoList.Add(video1);

        // Video 2
        Video video2 = new Video("Ultimate Sourdough Bread Guide", "Baking with Julia", 1200);
        video2.AddComment("Diana", "My crust finally turned out crispy!");
        video2.AddComment("Ethan", "What temperature should the water be?");
        video2.AddComment("Fiona", "Best baking tutorial on the internet hands down.");
        videoList.Add(video2);

        // Video 3
        Video video3 = new Video("Exploring the Deep Ocean", "Nature Channel", 2700);
        video3.AddComment("George", "The footage of the giant squid was breathtaking.");
        video3.AddComment("Hannah", "It is crazy how little we know about our own oceans.");
        video3.AddComment("Ian", "The narrator has such a soothing voice.");
        videoList.Add(video3);

        // Video 4
        Video video4 = new Video("Keyboard Typing ASMR (1 Hour)", "RelaxSounds", 3600);
        video4.AddComment("Julia", "Fell asleep within 5 minutes. Amazing.");
        video4.AddComment("Kevin", "The mechanical switches sound so crisp.");
        video4.AddComment("Lily", "This is exactly what I needed to finish my essay.");
        videoList.Add(video4);

        // Iterate through the list and display the information
        foreach (Video video in videoList)
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("\nComments:");

            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"  - {comment.Name}: \"{comment.Text}\"");
            }
        }
        Console.WriteLine(new string('-', 50));
    }
}

class Comment
{
    // Properties to track the person and text of the comment
    public string Name { get; set; }
    public string Text { get; set; }

    // Constructor
    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}

class Video
{
    // Properties to track video details
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthSeconds { get; set; }
    
    // Public getter for the comments list, but private setter to protect the list integrity
    public List<Comment> Comments { get; private set; }

    // Constructor
    public Video(string title, string author, int lengthSeconds)
    {
        Title = title;
        Author = author;
        LengthSeconds = lengthSeconds;
        Comments = new List<Comment>();
    }

    // Helper method to add a comment
    public void AddComment(string name, string text)
    {
        Comments.Add(new Comment(name, text));
    }

    // Method to return the number of comments
    public int GetCommentCount()
    {
        return Comments.Count;
    }
}
