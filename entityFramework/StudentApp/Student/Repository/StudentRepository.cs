using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class StudentRepository
{
    StudentDBContext studentDBContext = new StudentDBContext();

    public void AddStudent()
    {
        StudentMe student = new StudentMe();
        Console.WriteLine("Enter student name : ");
        student.Name = Console.ReadLine();

        studentDBContext.Students.Add(student);
        studentDBContext.SaveChanges();
    }

    public void DisplayStudent()
    {

    }
}

