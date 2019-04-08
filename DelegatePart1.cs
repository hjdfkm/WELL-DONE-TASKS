using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public delegate void StudentDelegate(string name, ref int energy);

    class Program
    {
        static void Main()
        {
            Student student = new Student();
            StudentDelegate studentDelegate = new StudentDelegate(student.Wash) + new StudentDelegate(student.Feed) + new StudentDelegate(student.PutToSleep) + new StudentDelegate(student.GiveAScholarship);
            Student[] studentList = new Student[4]
            {
                new Student { Name = "Eric Ericson", Energy = 87, GPA = 4.6 },
                new Student { Name = "Kenny Nicson", Energy = 68, GPA = 4.3 },
                new Student { Name = "Louis Louison", Energy = 94, GPA = 4.0},
                new Student { Name = "Anders Andersin", Energy = 82, GPA = 4.7}
            };
            for (int i = 0; i < studentList.Length; i++)
            {
                if (studentList[i].GPA > 4.5)
                {
                    string name = studentList[i].Name;
                    int energy = studentList[i].Energy;
                    studentDelegate(name, ref energy);
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
