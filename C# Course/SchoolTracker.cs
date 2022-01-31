//School tracker 

using System;
using System.Collections.Generic;

namespace C__Course
{
    class SchoolTracker
    {
        public void SchoolTracking()
        {
            /*
            Array Implementation
            
            Console.WriteLine("How many studnets are you entering?");
            int studentCount = int.Parse(Console.ReadLine());
            var studentNames = new String[studentCount];
            var studnetGrades = new int[studentCount]; 

            Console.WriteLine("Please enter the studnet name(enter), then the grade(enter).");
            for (int i = 1; i <= studentCount; i++)
            {
                Console.WriteLine("Student " + i + ":");
                studentNames[i] = Console.ReadLine();
                studnetGrades[i] = int.Parse(Console.ReadLine());
            }

            for( int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("Name: " + studentNames[i] + ", Grade: " + studnetGrades[i]);
            }*/

            var students = new List<Student>();

            
            bool adding = true;

            while(adding)
            {
                var newStudnet = new Student();
                Console.Write("Student Name: ");
                newStudnet.Name = Console.ReadLine();

                Console.Write("Student Garde: ");
                newStudnet.Grade = int.Parse(Console.ReadLine());

                Console.Write("Student Address: ");
                newStudnet.Address = Console.ReadLine();

                Console.Write("Student Birthday: ");
                newStudnet.Birthday = Console.ReadLine();

                Console.Write("Student Phone Number(numbers only): ");
                newStudnet.Phone = (int.Parse(Console.ReadLine()));

                students.Add(newStudnet);
                Student.Count++;
                Console.WriteLine("Student Count: {0}", Student.Count);

                Console.Write("Still adding? y/n \t");
                if (Console.ReadLine() == "y")
                    adding = true;
                else
                    adding = false;
            }
            
            foreach (var student in students)
                Console.WriteLine("Student Name: {0}, Grade: {1}", student.Name, student.Grade);       
        }
    }

    class Student
    {
        static public int Count = 0;
        public String Name;
        public int Grade;
        public String Address;
        public String Birthday;
        private int phoneNumber;

        public int Phone
        {
            set{ phoneNumber = value; }
        }

        public void setPhone(int number)
        {
            phoneNumber = number;
        }
    }
}