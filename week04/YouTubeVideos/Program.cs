using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        // Create 3-4 videos

        Video video1 = new Video("How to Go and Do, and why do it.", "Nephi", 300);
        Video video2 = new Video("The Importance of Faith", "Zenos", 600);
        Video video3 = new Video("Understanding the Atonement", "Helaman", 900);
        Video video4 = new Video("The Role of Prophets", "Joseph_Da_Smith", 1200);

        // set values: title, author, length, comments
        video1.AddComment(new Comment("IvP4", "Great video!"));
        video1.AddComment(new Comment("Gr8_walls_of_Fire", "Very informative."));
        video1.AddComment(new Comment("Nephi", "Loved it!"));
        
        video2.AddComment(new Comment("Lehi", "I learned a lot."));
        video2.AddComment(new Comment("ADAM1", "Thanks for sharing!"));
        video2.AddComment(new Comment("EVE1", "Very helpful."));
        
        video3.AddComment(new Comment("Yoda365", "Good content, it is."));
        video3.AddComment(new Comment("Laman", "It's a good video, but could be better."));
        video3.AddComment(new Comment("Lemuel", "Bruh, I totally agree with Laman."));
        
        video4.AddComment(new Comment("Nephite_300", "Interesting perspective."));
        video4.AddComment(new Comment("Whos_UR_Profit", "Well explained, doth sayeth the I."));
        video4.AddComment(new Comment("Ministering_Angel_who", "I appreciate the effort."));

        //add 3-4 comments to each video with username and text
        // put videos into a list
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };
        
        // iterate through the list and print out the video details
        //List out all comments for each video
        // Use a loop to print out the details of each video and its comments
        foreach (Video video in videos)
        {
            Console.WriteLine(video.getInfo());
            Console.WriteLine($"Number of comments: {video.getCommentCount()}");
            Console.WriteLine("Comments:");
            
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.GetCommentInfo()}");
            }
            Console.WriteLine(); // Empty line for separation
        }
    }
}