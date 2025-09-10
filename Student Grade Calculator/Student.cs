using System;
using System.IO;
using System.Collections.Generic;
namespace Student_Grade_Calculator;

public class Student
{
    //Step Two: I created a class for students and added properties to the class.
    public string name  { get; set; }
    public int id {get; set;}
    public List<double> grades {get; set;}

    public Student()
    {
        grades = new List<double>();
    }
    public void AddGrade(double grade)
    {
        grades.Add(grade);
    }

    public void AddRange(params double[] grade)
    {
        grades.AddRange(grades);
    }

    public double CalculateAverageGrade()
    {
        if (grades == null || !grades.Any())
            {
                return 0;
            }
        return grades.Average();
    }
    //Step Three: I created methods in the student class
    public void AddGrade(double grade, double d, double d1, double d2)
    {
        throw new NotImplementedException();
    }
}
