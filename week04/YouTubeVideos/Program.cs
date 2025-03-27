using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    // Comment class to track the comment text
    public class Comment
    {
        public string CommenterName { get; set; }
        public string CommentText { get; set; }

        public Comment(string commenterName, string commentText)
        {
            CommenterName = commenterName;
            CommentText = commentText;
        }
    }

    // Video class to track title, author, length and list of comments
    public class Video
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int LengthInSeconds { get; set; }
        private List<Comment> Comments { get; set; }

        public Video(string title, string author, int lengthInSeconds)
        {
            Title = title;
            Author = author;
            LengthInSeconds = lengthInSeconds;
            Comments = new List<Comment>();
        }

        // Method to add a comment to the video
        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        // Method to get the number of comments
        public int GetNumberOfComments()
        {
            return Comments.Count;
        }

        // Method to display all comments
        public void DisplayComments()
        {
            foreach (var comment in Comments)
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText}");
            }
        }

        // Method to display video details
        public void DisplayVideoDetails()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Length: {LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            DisplayComments();
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create some sample videos
            Video video1 = new Video("How to Code in C#", "John Doe", 120);
            Video video2 = new Video("Understanding Algorithms", "Jane Smith", 150);
            Video video3 = new Video("C# for Beginners", "Alice Brown", 180);

            // Add comments to video1
            video1.AddComment(new Comment("Mike", "Great tutorial!"));
            video1.AddComment(new Comment("Sarah", "Very helpful, thanks!"));
            video1.AddComment(new Comment("David", "I learned a lot, keep it up!"));

            // Add comments to video2
            video2.AddComment(new Comment("Chris", "Well explained!"));
            video2.AddComment(new Comment("Tom", "I need to watch this again."));
            video2.AddComment(new Comment("Rachel", "Great explanation on sorting algorithms!"));

            // Add comments to video3
            video3.AddComment(new Comment("James", "Perfect for beginners!"));
            video3.AddComment(new Comment("Mary", "I wish I had found this earlier."));
            video3.AddComment(new Comment("Alex", "Awesome introduction to C#!"));
            video3.AddComment(new Comment("Sophia", "Can you do a follow-up video?"));

            // List of videos
            List<Video> videos = new List<Video> { video1, video2, video3 };

            // Iterate through the list of videos and display the details
            foreach (var video in videos)
            {
                video.DisplayVideoDetails();
            }
        }
    }
}
