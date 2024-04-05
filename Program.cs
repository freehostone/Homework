using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 30;
            while (age < 40) 
            {
                Console.WriteLine($"С днем рождения! Вам {age} лет");
                age++;

            }
            Console.ReadLine();
        }
    }
}
