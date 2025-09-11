using System;
using System.IO;
using System.Collections.Generic;
namespace Student_Grade_Calculator;

public class Student
{
    //Step Two: I created a class for students and added properties to the class.
    public string Name  { get; set; }
    public int Id {get; set;}
    public List<double> Grades {get; set;}

    public Student()
    {
        Grades = new List<double>();
    }
    public void AddGrade(double grade)
    {
        Grades.Add(grade);
    }

    public void AddRange(params double[] grade)
    {
        Grades.AddRange(Grades);
    }

    public double CalculateAverageGrade()
    {
        if (Grades == null || !Grades.Any())
        {
            return 0;
        }
        return Grades.Average();
    }
    //Step Three: I created methods in the student class
    public void AddGrade(double grade1, double grade2, double grade3, double grade4)
    {
        Grades.Add(grade1);
        Grades.Add(grade2);
        Grades.Add(grade3);
        Grades.Add(grade4);
    }
}
