using System;

namespace YouTubeVideos
{
    class Comment
    {
        // properties for the commentor's name and the comment text
        public string Name { get; set; }
        public string Text { get; set; }

        //constructor to initialise the commentor's name and the comment made
        public Comment(string name, string text)
        {
            Name = name;
            Text = text;
        }
    }
}