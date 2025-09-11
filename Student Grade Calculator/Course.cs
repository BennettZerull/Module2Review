namespace Student_Grade_Calculator;

public class Course : Student
{
    public string Name {get; set;}
    public string Code {get; set;}
    public List<Student> EnrolledStudents {get; set;}

    public Course()
    {
        EnrolledStudents = new List<Student>();
    }

    public void AddEnrolledStudent(Student student)
    {
        if (!EnrolledStudents.Contains(student))
        {
            EnrolledStudents.Add(student);
            Console.WriteLine($"{student.Name} has been enrolled in {Name} - {Code}.");
        }
        else
        {
            Console.WriteLine($"{student.Name} is already enrolled in {Name} - {Code}.");
        }
    }
    public void DisplayCourseInfo()
    {
        Console.WriteLine($"\nCourse Name: {Name}");
        Console.WriteLine($"Course Code: {Code}");
        Console.WriteLine("Enrolled Students:");
        if (EnrolledStudents.Count == 0)
        {
            Console.WriteLine("  No students enrolled yet.");
        }
        else
        {
            foreach (var student in EnrolledStudents)
            {
                Console.WriteLine($"  - {student.Name}");
            }
        }
    }
}