public class MathAssignment : Assignment
{
    private string _textSection;
    private string _problem;

    public MathAssignment(string student, string topic, string textbookSection, string problems)
      : base(student, topic)
      {
        _textSection = textbookSection;
        _problem = problems;
      }

    public string GetHomeworkList()
    {
        return $"Section{_textSection} Problem{_problem}";
    }
      }
