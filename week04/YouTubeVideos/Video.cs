
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Transactions;

class Video
{
    public string _title{get;}
    public string _author{get;}
    public int _length{get;}
    public List<Comment> Comments{get;}


    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
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