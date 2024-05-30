using System;

class Program
{
    static void Main(string[] args)
    {
        List<Comment> comments1 = new List<Comment>();
        Video video1 = new Video("My First video", "Thando Sim", 1110, comments1);
        Comment comment1 = new Comment("Billy","This  was his first video!");
        Comment comment2 = new Comment("Willy","This  a comment.");
        Comment comment3 = new Comment("Hilly","This  another comment.");
        comments1.Add(comment1);
        comments1.Add(comment2);
        comments1.Add(comment3);

        video1.Display();
        Console.WriteLine();

        
        List<Comment> comments2 = new List<Comment>();
        Video video2 = new Video("My Second video", "Waldo Sim", 210, comments2);
        Comment comment2_1 = new Comment("Billy","Loved it!");
        Comment comment2_2 = new Comment("Riley","I wasn't the first to comment.");
        Comment comment2_3 = new Comment("Hilly","Please like my comment.");
        Comment comment2_4 = new Comment("Wili Nilly","Please like my comment too.");
        Comment comment2_5 = new Comment("Lily","I like this.");
        comments2.Add(comment2_1);
        comments2.Add(comment2_2);
        comments2.Add(comment2_3);
        comments2.Add(comment2_4);
        comments2.Add(comment2_5);

        video2.Display();
        Console.WriteLine();

        
        List<Comment> comments3 = new List<Comment>();
        Video video3 = new Video("My Third video", "Bando Sim", 3610, comments3);
        Comment comment3_1 = new Comment("Billy","Sooo Cool!");
        Comment comment3_2 = new Comment("Miller","Impossible!");
        Comment comment3_3 = new Comment("Hilly","I dont believe it.");
        Comment comment3_4 = new Comment("Hilly","He's the best at this.");
        comments3.Add(comment3_1);
        comments3.Add(comment3_2);
        comments3.Add(comment3_3);
        comments3.Add(comment3_4);


        video3.Display();
    }
}