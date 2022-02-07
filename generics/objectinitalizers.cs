using System;
using System.Collections.Generic;
using System.Text;

namespace generics
{
    class objectinitalizers
    {
        public class sample<T>
        {
            //field
            private T data;
            //property
            public T value
            {
                //accessors
                get
                {
                    return this.data;
                }
                set
                {
                    this.data = value;
                }
            }

        }

        public class Student
        {
            public int StudentID { get; set; }
            public string StudentName { get; set; }
            public int Age { get; set; }
            public string Address { get; set; }
        }
        static void Main2(string[] args)
        { 
            sample<string> name = new sample<string>();
            name.value = "akshitha pinishetty";
            sample<float> version = new sample<float>();
            version.value = 12.0F;
            Console.WriteLine(name.value);
            Console.WriteLine(version.value);
            Student std = new Student()
            {
                StudentID = 1,
                StudentName = "akshitha pinishetty",
                Age = 20,
                Address = "bodrai bazar "
            };
            Console.WriteLine("Student Information");
            Console.WriteLine(std.StudentID);
            Console.WriteLine(std.StudentName);
            Console.WriteLine(std.Age);
            Console.WriteLine(std.Address);
        }

    }
}