
using System.Runtime.InteropServices.Marshalling;

class Comment
{
    public string CommentAuthor{get;}
    public string CommentText{get;}


    public Comment(string _commentAuthor, string _commentText)
    {
        CommentAuthor = _commentAuthor;
        CommentText = _commentText;
    }
}