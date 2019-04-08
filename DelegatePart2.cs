using System;

namespace ConsoleApp11
{
    class Student
    {
        public string Name { get; set; }
        public int Energy { get; set; }
        public double GPA { get; set; }

        public void Wash(string name, ref int energy)
        {
            Console.WriteLine("Студент " + name + " принял душ");
        }

        public void Feed(string name, ref int energy)
        {
            energy = energy + 1;
            Console.WriteLine("Студент " + name + " накормлен. Энергия увеличена и составляет " + energy);
        }

        public void PutToSleep(string name, ref int energy)
        {
            energy = energy + 1;
            Console.WriteLine("Студент " + name + " лёг спять. Энергия увеличена и составляет " + energy);
        }

        public void GiveAScholarship(string name, ref int energy)
        {
            Console.WriteLine("Студент " + name + " получил степендию");
        }
    }
}
