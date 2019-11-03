using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stiva = new Stack(new Stack<string>());
            stiva.Push("costel");
            stiva.Push("ion");
            stiva.Push("vasile");
            stiva.Print();
            Console.WriteLine();
            stiva.Pop();
            stiva.Print();




            Console.ReadLine();
        }




    }
}
