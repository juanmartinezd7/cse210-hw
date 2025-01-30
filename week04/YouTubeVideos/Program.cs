using System;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videos = new List<Video>();

        //List of videos
        Video video1 = new Video("The story of Juan", "Juan Martinez", 300);
        video1.AddComment("Jose", "Great video");
        video1.AddComment("Mary", "I love it");

        Video video2 = new Video("Welcome to the church", "The Church Of Jesus Christ Of Latter Day Saints", 600);
        video2.AddComment("Luis", "I'm proud to belong to this church");
        video2.AddComment("Joselyn", "I felt the spirit when I watch this video");
        video2.AddComment("Miriam", "I like this video");
        video2.AddComment("Oscar", "I'm a new member of this church, I like this church.");
        video2.AddComment("Martha", "The gospel of Jesus Christ is a blessing in my life.");

        Video video3 = new Video("C# Tutorial for beginners", "IAMTimCorey", 554);
        video3.AddComment("Marvin", "Keep it up Tim, been waiting for this soooo long! Lots of Love from Edmonton Alberta");
        video3.AddComment("Xavier", "Got it! Ready for next one.");
        video3.AddComment("Kevin", "This is actually what they teach in schools in the name of Coding");
        video3.AddComment("Rachel", "Thanks, please keep making more videos like this one.");

        Video video4 = new Video("The Lord Appears to the Brother of Jared", "Book of Mormon: Another Testament of Jesus Christ", 1231);
        video4.AddComment("Eric", "I loved being a part of this playing Jared! I'm so grateful for the scriptures so we can learn from their story.");


        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);


        //Video details
        foreach (var video in videos)
        {
            Console.WriteLine("================================");
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (var Comment in video.Comments)
            {
                Console.WriteLine($"-{Comment.CommentAuthor}: {Comment.CommentText}");
            }
            Console.WriteLine("================================\n");

        }
    }
}