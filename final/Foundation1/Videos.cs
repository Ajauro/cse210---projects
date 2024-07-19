using System;

public class Video
{
    public string _title { get; set; }
    public string _author { get; set; }
    public int _duration { get; set; } // em segundos
    private List<Comment> comments;

    public Video(string title, string author, int duration)
    {
        _title = title;
        _author = author;
        _duration = duration;
        comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int NumberOfComments()
    {
        return comments.Count;
    }

    public override string ToString()
    {
        string videoComments = string.Join("\n", comments);
        return $"Title: {_title}\nAuthor: {_author}\nDuration: {_duration} seconds\nNumber of comments: {NumberOfComments()}\nComments:\n{videoComments}\n";
    }
}