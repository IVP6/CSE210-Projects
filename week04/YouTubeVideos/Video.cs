using System;
using System.Collections.Generic;

class Video
{
    //Track title, author, length
    private string _title;
    private string _author;
    private double _length;
    // Store list of comments
    private List<Comment> comments = new List<Comment>();

    // Constructor

    // Constructor with parameters
    public Video(string title, string author, double length)
    {
        this._title = title;
        this._author = author;
        this._length = length;
    }

    // method to return # of comments
    public int getCommentCount()
    {
        return comments.Count;
    }

    public string getInfo()
    {
        return $"Title: {_title}\n Author: {_author}\n Length: {_length} seconds";
    }

    public void setInfo(string title, string author, double length)
    {
        this._title = title;
        this._author = author;
        this._length = length;
    }

    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    // Method to get all comments
    public List<Comment> GetComments()
    {
        return comments;
    }
}