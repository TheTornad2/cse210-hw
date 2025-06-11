public class Comment
{

    private string _CommenterName;
    private string _CommentText;

    public Comment(string commenterName, string commentText)
    {
        _CommenterName = commenterName;
        _CommentText = commentText;
    }

    public string CommenterName
    {
        get { return _CommenterName; }

    }

    public string CommentText
    {
        get { return _CommentText; }
    }
}
