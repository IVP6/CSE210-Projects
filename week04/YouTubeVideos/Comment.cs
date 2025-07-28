
using System;

class Comment
{
    // Track username and text of the comment
    private string _username;
    private string _text;

    // Constructor
    public Comment(string username, string text)
    {
        this._username = username;
        this._text = text;
    }

    // Method to get comment info
    public string GetCommentInfo()
    {
        return $"{_username}: {_text}";
    }

    // Getters
    public string GetUsername()
    {
        return _username;
    }

    public string GetText()
    {
        return _text;
    }
}