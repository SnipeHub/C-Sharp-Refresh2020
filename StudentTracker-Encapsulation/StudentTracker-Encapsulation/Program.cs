using System;
using System.Collections.Generic;

namespace StudentTrackerImproved
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();

            var adding = true;

            while (adding)
            {
                var newStudent = new Student();

                newStudent.Name = Util.Console.Ask("Student Name: ");

                newStudent.Grade = int.Parse(Util.Console.Ask("Student Grade: "));

                newStudent.Birthday = Util.Console.Ask("Student Birthday: ");

                newStudent.Address = Util.Console.Ask("Student Address: ");

                newStudent.Phone = int.Parse(Util.Console.Ask("Student Phone: "));

                students.Add(newStudent);
                Student.Count++;
                Console.WriteLine("Student Count: {0}", Student.Count);

                Console.WriteLine("Add another? y/n");

                if (Console.ReadLine() != "y")
                {
                    adding = false;
                }
            }

            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}, Grade: {1}, Birthday: {2}, Address: {3}", student.Name, student.Grade, student.Birthday, student.Address);
            }
        }
    }

    class Student
    {
        static public int Count = 0;

        public string Name;
        public int Grade;
        public string Birthday;
        public string Address;
        private int phone;

        // now we use this instead of the below function
        // This is making the number private
        public int Phone
        {
            set { phone = value; }
        }

        public void SetPhone(int number)
        {
            phone = number;
        }
    }
}