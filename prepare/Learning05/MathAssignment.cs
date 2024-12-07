using System.Globalization;
using System.Runtime.CompilerServices;

public class MathAssignment: Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string textbookSection, string problems, string studentName, string topic): base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        string studentDetails = base.GetSummary();
        return $"{studentDetails} Section: {_textbookSection} Problems: {_problems}";
    }
}