using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangePperson
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[]
            {
                new Person{Name = "Cody", Age = 20},
                new Person{Name = "Connor", Age = 15}

            };

            foreach (Person person in people)
            {
                person.Age = 20;
            }

            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
