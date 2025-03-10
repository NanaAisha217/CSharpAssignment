using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProject.Models
{
    class Program
    {
        static void Main()
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop()); // 3
            Console.WriteLine(stack.Pop()); // 2
            Console.WriteLine(stack.Pop()); // 1
        }
    }
}
