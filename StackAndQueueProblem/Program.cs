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
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n 1.LinkedList Stack."
                                + "\n 2.LinkedList Queue."
                                + "\n 3.Exit\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("LinkedList Stack");
                        LinkedListStack linkedListStack = new LinkedListStack();
                        linkedListStack.Push(70);
                        linkedListStack.Push(30);
                        linkedListStack.Push(56);
                        linkedListStack.Display();
                        linkedListStack.IsEmpty();
                        linkedListStack.Display();
                        break;
                    case 2:
                        Console.WriteLine("LinkedList Queue");
                        LinkedListQueue linkedListQueue = new LinkedListQueue();
                        linkedListQueue.Enqueue(56);
                        linkedListQueue.Enqueue(30);
                        linkedListQueue.Enqueue(70);
                        linkedListQueue.Display();
                        break;
                    case 3:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Enter Correct Option!!!");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
