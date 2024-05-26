using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int[] Massiv = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, }
          Console.WriteLine(Massiv(Massiv));
        }
       static int Massiv(int [] Massiv) 
        { int sum = 0;
           
            foreach (var number in Massiv)      
            
            {
                if (number % 3 == 0)
                {
                    sum += number;
                }
            }
            return sum;
        }
    }
    
    Console.Readline;
}


