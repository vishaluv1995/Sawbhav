using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student firststudent = new Student(1, "Mayuresh");
            Print(firststudent);

            Student secondstudent = new Student(2, "Ashwini");
            Print(secondstudent);

            Student thirdstudent = new Student(3, "Dhana");
            Print(thirdstudent);

            Console.WriteLine("Total student:"+Student.HeadCount());
            Console.ReadLine();
        }

        public static void Print(Student student)
        {
            Console.WriteLine("Id:" + student.Id);
            Console.WriteLine("Name:" + student.Name);
            Console.WriteLine("Count of student constructor invoke:" + student.Countstudent);
           
        }
    }
}
