namespace UniversityClass;

public class Student
{
    private string _firstName;
    private string _lastName;
    private string _privateNum;
    private List<Subject> _studSubjects;
    private int _currentCredits;
    private const int MaxCredits = 35;

    // public void AddSubject(Subject, int currentCredits)
    // {
    //     _currentCredits = currentCredits;
    // }
    
    
    
    public Student(string firstName, string lastName, List<Subject> studSubjects)
    {
        _firstName = firstName;
        _lastName = lastName;
        _studSubjects = studSubjects;
    }

    public string PrivateNum
    {
        get => _privateNum;
        set
        {
            try
            {
                if (_privateNum.Length <= 11)
                {
                    _privateNum = value;
                }
            }
            catch
            {
                throw new ArgumentOutOfRangeException("private number");
            }
        }
    }
}

public class Teacher
{
    private string _firstName;
    private string _lastName;
    private List<string> _subjects;


    public Teacher(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
        _subjects = new List<string>();
    }
    
}

public class Subject
{
    private string _subjectName;
    private string _prerequisite;
    private int _credits;
    private int _maxStudentNum;

    public Subject(string subjectName, int credits, int maxStudentNum, string prerequisite)
    {
        _subjectName= subjectName;
        _credits = credits;
        _maxStudentNum = maxStudentNum;
        _prerequisite = prerequisite;
    }
}