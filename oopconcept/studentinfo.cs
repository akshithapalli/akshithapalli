using System;
using System.Collections.Generic;
using System.Text;

namespace oopconcept
{
    class studentinfo
    {
        int StudentID;
        string StudentName;
        string StudentGender;

        public void GetStudentInformation()
        {
            Console.WriteLine("Please enter student Id");
            StudentID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter student Name");
            StudentName = Console.ReadLine();
            Console.WriteLine("Please enter student Gender");
            StudentGender = Console.ReadLine();
        }

        public void ShowStudentData()
        {
            Console.WriteLine("Student Data :-");
            Console.WriteLine("Student Id : {0}", StudentID);
            Console.WriteLine("Student Name : {0}", StudentName);
            Console.WriteLine("student Gender : {0}", StudentGender);

        }
    }
    class programm
    {
        static void Main3(string[] args)
        {
            studentinfo student = new studentinfo();
            student.GetStudentInformation();
            student.ShowStudentData();
            studentinfo[] Student= new studentinfo[2];

            for (int i = 0; i < Student.Length; i++)

            {
                studentinfo student1 = new studentinfo();
                student1.GetStudentInformation();
                Student[i] = student1;
            }
            for (int i = 0; i < Student.Length; i++)
            {
                Student[i].ShowStudentData();
            }
        }
    }
}
 