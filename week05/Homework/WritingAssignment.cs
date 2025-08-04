



class WritingAssignment : Assignment
{
    private string _title;

    ///////////
    /// Constructor
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }
    public string GetWritingInformation()
    {
        return $"\nStudent: {GetStudentName()}\n Topic: {GetTopic()}\n Title: {_title}";

    }
}