using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayTyping
{
    class Program
    {
        static void Main(string[] args)
        {

            object[] objArray = new object[3]
            {
                "Hello World",
                4,
                new Button{Text = "Click Me"}
            };

            Type objArrType = objArray.GetType();

            foreach (object obj in objArray)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
