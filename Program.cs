using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Введите расстояние в м :");
            int i=int.Parse(Console.ReadLine());
            Console.WriteLine($"Полных м: {i/100}");
            Console.ReadLine();
        }
    }
}
