using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Создаем массив случайных целых чисел);
            int array = new int 100;
            Random random = new Random();
            for (int i = 0; i < array; i++ ) 
            {
             array=random.Next(1,100);
                Console.WriteLine(Генерация случайного числа от 1 до 100);
            }
            Console.WriteLine(Вывод значений массива в строчку через пробел);
            foreach (int num in array) ;
            {
                Console.WriteLine(num + "");
            }
            Console.WriteLine(Нахождение максимального значения в массиве);
            int max = array0;
            for (int i = 1; i < array.Lenght;i++) 
            {
                if (array > max) ;
            }
        }
        Console.WriteLine(Вывод максимального значения синим цветом);
        Console.ForegroundColor=ConsoleColor.Blue;
        Console.WriteLine("\nМаксимальное значение массива:" + max);
        Console.ResetColor();
        Console.ReadLine(;
    }
}
