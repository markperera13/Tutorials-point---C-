using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            /* my first program in C# */
            string[] sarray = { "Hello", "World", "Earth"};
            Console.WriteLine("Messagae: {0}, {1}", sarray[0], sarray[1], sarray[2]);
            Console.WriteLine("Messagae: {0}, {2}", sarray[0], sarray[1], sarray[2]);
            Console.ReadLine();
        }
    }
}
