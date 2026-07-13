class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video(
            "Easy Breakfast Ideas for Busy Students",
            "Campus Kitchen",
            520
        );

        video1.AddComment(new Comment("Emily", "These ideas are simple and useful."));
        video1.AddComment(new Comment("Daniel", "I want to try the egg sandwich."));
        video1.AddComment(new Comment("Grace", "This is perfect for college students."));
        videos.Add(video1);

        Video video2 = new Video(
            "A Day in the Life of a College Student",
            "Student Vlog",
            780
        );

        video2.AddComment(new Comment("Ryan", "This reminds me of my school schedule."));
        video2.AddComment(new Comment("Ashley", "I like how realistic this vlog feels."));
        video2.AddComment(new Comment("Kevin", "The library part was my favorite."));
        videos.Add(video2);

        Video video3 = new Video(
            "Beginner Tips for Learning C#",
            "Code Helper",
            690
        );

        video3.AddComment(new Comment("Hannah", "This helped me understand classes better."));
        video3.AddComment(new Comment("Mark", "The examples were easy to follow."));
        video3.AddComment(new Comment("Sophie", "Please make more programming videos."));
        videos.Add(video3);

        Video video4 = new Video(
            "Simple Room Cleaning Routine",
            "Clean Space",
            430
        );

        video4.AddComment(new Comment("Rachel", "This made cleaning feel less stressful."));
        video4.AddComment(new Comment("Tyler", "I need to organize my desk too."));
        video4.AddComment(new Comment("Madison", "The routine is simple but helpful."));
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.DisplayVideoInformation();
            Console.WriteLine();
        }
    }
}