using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    class Video
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int LengthInSeconds { get; set; }
        public List<Comment> Comments { get; private set; }
        public Video(string title, string author, int LengthInSeconds)
        {
            Title = title;
            Author = author;
            LengthInSeconds = LengthInSeconds;
            Comments = new List<Comment>();
        }
        public void AddComment(string Name, string Text)
        {
            Comment comment = new Comment(Name, Text);
            Comments.Add(comment);
        }
        public int GetNumberOfComments()
        {
            return Comments.Count;
        }
    } 
}