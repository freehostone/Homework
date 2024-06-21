using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;
            using System.Collections.Generic;

class Worker
        {
            public string FullName { get; set; }
            public double Salary { get; set; }
            public string Profession { get; set; }

            public void DisplayInfo()
            {
                Console.WriteLine($"Worker: {FullName}");
                Console.WriteLine($"Profession: {Profession}");
                Console.WriteLine($"Salary: {Salary}");
                Console.WriteLine();
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                List<Worker> workers = new List<Worker>();

                Worker worker1 = new Worker();
                worker1.FullName = "John Doe";
                worker1.Salary = 2000;
                worker1.Profession = "Programmer";
                workers.Add(worker1);

                Worker worker2 = new Worker();
                worker2.FullName = "Jane Smith";
                worker2.Salary = 2500;
                worker2.Profession = "Designer";
                workers.Add(worker2);

                Worker worker3 = new Worker();
                worker3.FullName = "Mike Johnson";
                worker3.Salary = 1800;
                worker3.Profession = "Accountant";
                workers.Add(worker3);

                foreach (Worker worker in workers)
                {
                    worker.DisplayInfo();
                }
            }
        }

    }Console.ReadLine;

}

