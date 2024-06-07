using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public double GradePointAverage { get; set; }

            public Student(string name, int age, double gradePointAverage)
            {
                Name = name;
                Age = age;
                GradePointAverage = gradePointAverage;
            }

            public void PrintInfo()
            {
                Console.WriteLine($"Имя: {Name}");
                Console.WriteLine($"Возраст: {Age}");
                Console.WriteLine($"Средний балл: {GradePointAverage}");
                if (GradePointAverage >= 4.5)
                {
                    Console.WriteLine("Отличник");
                }
                else if (GradePointAverage >= 3.5)
                {
                    Console.WriteLine("Хорошист");
                }
                else if (GradePointAverage >= 2.5)
                {
                    Console.WriteLine("Троечник");
                }
                else
                {
                    Console.WriteLine("Неуд");
                }
                Console.ReadLine();
            }
        }


       
        }
    }
}
