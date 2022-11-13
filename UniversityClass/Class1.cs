namespace UniversityClass;

public class Student
{
    private string _firstName;
    private string _lastName;
    private string _privateNum;
    private List<Subject> _studSubjects;
    private int _currentCredits;
    private const int MaxCredits = 35;
    private List<Semester> _completedSemesters;

    public List<Semester> CompetedSemesters
    {
        get => _completedSemesters;
        set => _completedSemesters = value;
    }

    public string FirstandLastName
    {
        get => _firstName + ' ' + _lastName;
    }

    public void AddSubject(List<Subject> newStudSubjects)
    {
        int newSubjectCredits = 0; 
        for (int i = 0; i < newStudSubjects.Count; i++)
        {
            Subject currentSubject = newStudSubjects[i];
            newSubjectCredits += currentSubject.Credits;
        }

        if (newSubjectCredits + _currentCredits <= MaxCredits)
        {
            for (int i = 0; i < newStudSubjects.Count; i++)
            {
                _studSubjects.Add(newStudSubjects[i]);
            }

            _currentCredits += newSubjectCredits;
        }
        else
        {
            Console.WriteLine("Not enough credits available");
        }
    }
    
    
    public Student(string firstName, string lastName, List<Subject> studSubjects, List<Semester> completedSemesters)
    {
        _firstName = firstName;
        _lastName = lastName;
        _studSubjects = studSubjects;
        _completedSemesters = completedSemesters;
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
                Console.WriteLine("The input is invalid");
            }
        }
    }

    public void GetStudentInfo()
    {
        for (int i = 0; i < _completedSemesters.Count; i++)
        {
            for (int j = 0; j < _completedSemesters[i].SemesterSubjects.Count; j++)
            {
                Console.WriteLine("semester: {0} subject: {1}, professor: {2}",
                    _completedSemesters[i].SemesterNumber, 
                    _completedSemesters[i].SemesterSubjects[j].SubjectName,
                    _completedSemesters[i].SemesterSubjects[j].Teacher.FirstAndLastName);
            }
        }
    }

    public void AddSemester (Semester semester)
    {
        _completedSemesters.Add(semester);
    }
}

public class Semester
{
    private List<Subject> _semesterSubjects;
    private double _semesterGPA;
    private int _semesterNumber;

    public List<Subject> SemesterSubjects
    {
        get => _semesterSubjects;
    }

    public int SemesterNumber
    {
        get => _semesterNumber;
    }

    public Semester(List<Subject> semesterSubjects, double semesterGpa, int semesterNumber)
    {
        _semesterSubjects = semesterSubjects;
        _semesterGPA = semesterGpa;
        _semesterNumber = semesterNumber;
    }
}


public class Teacher
{
    private string _firstName;
    private string _lastName;
    private List<Subject> _teacherSubjects;

    public string FirstAndLastName
    {
        get => _firstName + ' ' + _lastName;
    }
    

    public Teacher(string firstName, string lastName, List<Subject> teacherSubjects)
    {
        _firstName = firstName;
        _lastName = lastName;
        if (_teacherSubjects.Count > 3)
        {
            throw new Exception("Too many subjects");
        }
        else
        {
            _teacherSubjects = teacherSubjects;
        }
    }

    public void AddSubject(Subject newsubject)
    {
        if (_teacherSubjects.Count >= 3)
        {
            throw new Exception("Too many subjects");
        }
        else
        {
            _teacherSubjects.Add(newsubject);
        }
    }
    
}

public class Subject
{
    private string _subjectName;
    private List<Subject> _prerequisites;
    private int _credits;
    private int _maxStudentNum;
    private Teacher _teacher; 

    public int Credits
    {
        get => _credits;
        set => _credits = value;
    }

    public string SubjectName
    {
        get => _subjectName;
    }

    public Teacher Teacher
    {
        get => _teacher;
    }
    
    public Subject(string subjectName, int credits, int maxStudentNum, Teacher teacher, List<Subject> prerequisites)
    {
        _subjectName= subjectName;
        _credits = credits;
        _maxStudentNum = maxStudentNum;
        _teacher = teacher;
        _prerequisites = prerequisites;
    }
    
    public override string ToString()
    {
        return "The name of this subjects is " + _subjectName + ". It is taught by teacher " + _teacher + ". The subject has " + _credits + "credits" ;
    }

}