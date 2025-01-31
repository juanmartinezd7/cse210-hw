
using System.Runtime.InteropServices.Marshalling;

class Comment
{
    public string _commentAuthor{get;}
    public string _commentText{get;}


    public Comment(string commentAuthor, string commentText)
    {
        _commentAuthor = commentAuthor;
        _commentText = commentText;
    }
}