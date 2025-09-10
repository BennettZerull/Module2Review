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
        }
    }
}
