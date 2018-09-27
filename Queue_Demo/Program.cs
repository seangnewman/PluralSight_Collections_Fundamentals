using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> tasks = new Queue<string>();
            tasks.Enqueue("Complete Reading in Certification Book");
            tasks.Enqueue("Do examples in Toolkit");
            tasks.Enqueue("Continue examples in .Net Generics");
            tasks.Enqueue("Start Documenting Chap 11 in toolkit");

            Console.WriteLine("\r\nAll Tasks: ");
            foreach (string task in tasks)
            {
                Console.WriteLine(task);
            }
            Console.WriteLine();

            string nextTask = tasks.Dequeue();
            Console.WriteLine("The task just completed is {0}", nextTask);

            Console.WriteLine("The next task to complete is {0}", tasks.Peek());

            Console.WriteLine("\r\nAll Tasks after Dequeue: ");
            foreach (string task in tasks)
            {
                Console.WriteLine(task);
            }
            Console.WriteLine();
        }
    }
}
