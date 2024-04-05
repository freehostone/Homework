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
            float p;
            int age;
            float percent;
            Console.WriteLine("введите количество денег");
            p=float.Parse(Console.ReadLine());
            Console.WriteLine("введите количество лет");
            age=int.Parse(Console.ReadLine());
            Console.WriteLine("процент");
            percent=float.Parse(Console.ReadLine());    
            for(int i = 0; i < age; i++) 
            {
                p+=(p/100)*percent;
                Console.WriteLine("на вашем счете "+p );
            }
            Console.ReadLine();
        }
    }
}
