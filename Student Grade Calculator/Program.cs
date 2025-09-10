using System;
using System.IO;
using System.Collections.Generic;
//Step One: I created the console application to calculate students grades.
namespace Student_Grade_Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> Students = new List<string>();
            //Step Four: I created a list for students in the main method
            Student student1 = new Student();
            Student student2 = new Student();
            Student student3 = new Student();
            Student student4 = new Student();
            
            student1.name = "Bennett Zerull";
            student1.id = 001;
            student2.name = "Wedge Mydoggo";
            student2.id = 002;
            student3.name = "Mario Brother";
            student3.id = 003;
            student4.name = "Luigi Brother";
            student4.id = 004;
            //Step Five: I created 4 instances of students
            
            Students.Add(student1.name);
            Students.Add(student2.name);
            Students.Add(student3.name);
            Students.Add(student4.name);
            //Step Six: I populated the list with students
            
            student1.AddGrade(97.2);
            student1.AddGrade(95.0, 98.4, 90.7, 96.9);
            student2.AddGrade(100.0);
            student2.AddGrade(100.0, 100.0, 100.0, 100.0);
            student3.AddGrade(48.5);
            student3.AddGrade(52.6, 63.4, 44.3, 0.0);
            student4.AddGrade(86.4);
            student4.AddGrade(89.0, 82.8, 87.6, 90.2);
            //Step Seven: I called the method to add grades to the students
            
            
        }
    }
}
