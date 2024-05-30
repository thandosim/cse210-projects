using System.ComponentModel.DataAnnotations;

public class Video
{
    private string _title;
    private string _author;
    private float _length;
    private List<Comment> _comments;

    public Video(string title, string author, float length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;

    }

    public void Display()
    {
        Console.WriteLine($"{_title} by {_author} ({_length} seconds)");
        Console.WriteLine($"Comments ({GetCommentAmmount()})");
        foreach (var comment in _comments)
        {
            Console.WriteLine(comment.GetCommentString());
        }
    }

    public int GetCommentAmmount()
    {
        return _comments.Count;
    }
}