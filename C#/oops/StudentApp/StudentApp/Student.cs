using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class Student
    {
        private int id;
        private string name;
        private static int countstudentconstruct;
        private static int countstudent;

        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
            countstudentconstruct += 1;
            countstudent += 1;
        }

        static Student()
        {
            countstudentconstruct = 100;
            Console.WriteLine("Count of constuctor invoke:" + countstudentconstruct);
        }

        public static int HeadCount()
        {
            return countstudent;
        }

        public int Id
        {
            get
            {
                return id;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public int Countstudent
        {
            get
            {
                return countstudentconstruct;
            }
        }

    }
}
