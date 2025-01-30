
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Transactions;

class Video
{
    public string Title{get;}
    public string Author{get;}
    public int Length{get;}
    public List<Comment> Comments{get;}


    public Video(string _title, string _author, int _length)
    {
        Title = _title;
        Author = _author;
        Length = _length;
        Comments = new List<Comment>();
    }

    public void AddComment(string _commentAuthor, string _commentText)
    {
        Comments.Add(new Comment(_commentAuthor, _commentText));
    }

    public int GetCommentCount()
    {
        return Comments.Count;
    }

    
}