using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> books = new Stack<string>();

            books.Push("MCSD Certification Toolkit");
            books.Push("Programming in C#");
            books.Push("Algorithms and Data Structures in Java");
            books.Push("Python the Hard Way");

            Console.WriteLine("All Books:");
            foreach (string book in books)
            {
                Console.WriteLine(book);
            }

            string topIteim = books.Peek();
            Console.WriteLine("\r\nAll Books after Peek:");
            foreach (string book in books)
            {
                Console.WriteLine(book);
            }


        }
    }
}
