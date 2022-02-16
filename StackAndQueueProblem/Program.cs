using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueueProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(56);
            linkedListStack.Push(30);
            linkedListStack.Push(70);
            linkedListStack.Display();
            Console.ReadLine();
        }
    }
}
