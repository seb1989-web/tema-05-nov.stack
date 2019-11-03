using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    class Stack
    {
        Stack<string> stiva = new Stack<string>();

        public Stack(Stack<string> stiva )
        {
            this.stiva = stiva;
        }

        public void Push(string value)
        {
            stiva.Push(value);
        }

        public void Pop()
        {
            stiva.Pop();
        }

        public void Print()
        {
            foreach (var item in stiva)
            {
                Console.WriteLine(item);
            }
        }
    }
}
