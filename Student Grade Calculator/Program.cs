using System;
using System.IO;
using System.Collections.Generic;
//Step One: I created the console application to calculate students grades.
namespace Student_Grade_Calculator
{
    public static class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            //Step Four: I created a list for students in the main method
            Student student1 = new Student();
            Student student2 = new Student();
            Student student3 = new Student();
            Student student4 = new Student();
            
            student1.Name = "Bennett Zerull";
            student1.Id = 1001;
            student2.Name = "Wedge Zerull";
            student2.Id = 1002;
            student3.Name = "Mario Brothers";
            student3.Id = 1003;
            student4.Name = "Luigi Brothers";
            student4.Id = 1004;
            //Step Five: I created 4 instances of students
            
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);
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

            foreach (Student student in students)
            {
                Console.Write($"Name: {student.Name} \tID: {student.Id} \tAverage Grade: {Math.Round(student.Grades.Average(), 1)} \nGrades:\n");
                foreach (double grade in student.Grades)
                {
                    Console.Write($" {grade} \n");
                }
            }
            //Step Eight:I chose a foreach loop to list the students information 
            
            Course course1 = new Course();
            Course course2 = new Course();

            course1.Name = "English";
            course1.Code = "101";
            course2.Name = "Mathematics";
            course2.Code = "101";
            
            course1.EnrolledStudents.Add(student1);
            course1.EnrolledStudents.Add(student2);
            course2.EnrolledStudents.Add(student3);
            course2.EnrolledStudents.Add(student4);
            
            course1.DisplayCourseInfo();
            course2.DisplayCourseInfo();
        }
    }
}//BONUS: I created courses and enrolled students in them