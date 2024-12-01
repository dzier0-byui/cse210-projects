using System;

class Program
{
    static void Main(string[] args)
    {
         List<Video> videos = new List<Video>
        {
            new Video("C# Programming Tutorial", "Code Academy", 600),
            new Video("Top 10 Coding Practices", "Dev Master", 900),
            new Video("Beginner's Guide to OOP", "LearnCode", 720),
            new Video("Advanced C# Techniques", "TechGuru", 1100)
        };

        videos[0].AddComment(new Comment("Alice", "Great tutorial!"));
        videos[0].AddComment(new Comment("Bob", "Very helpful, thanks!"));
        videos[0].AddComment(new Comment("Charlie", "Clear explanations."));

        videos[1].AddComment(new Comment("David", "Loved the tips!"));
        videos[1].AddComment(new Comment("Eve", "This was awesome."));
        videos[1].AddComment(new Comment("Frank", "Helpful for my project."));

        videos[2].AddComment(new Comment("Grace", "Nice introduction."));
        videos[2].AddComment(new Comment("Hank", "Simple and concise."));
        videos[2].AddComment(new Comment("Ivy", "Looking forward to more."));

        videos[3].AddComment(new Comment("John", "Really advanced stuff!"));
        videos[3].AddComment(new Comment("Kate", "Great insights!"));
        videos[3].AddComment(new Comment("Leo", "Well explained."));

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}