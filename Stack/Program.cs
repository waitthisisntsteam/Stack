using System;
using System.Xml.Schema;

namespace Stack
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var stack = new DoublyLinkedList<int>();
            while (true)
            {
                Console.WriteLine("Push, pop, peek, or exit?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "push")
                {
                    Console.WriteLine("What would you like to push?");
                    int pushAnswer = int.Parse(Console.ReadLine());
                    StackFunctions.Push(stack, pushAnswer);
                }
                else if (answer == "pop")
                {
                    if (stack.Count > 0)
                    {
                        StackFunctions.Pop(stack);
                    }
                    else
                    {
                        Console.WriteLine("The stack is empty.");
                    }
                }
                else if (answer == "peek")
                {
                    if (stack.Count > 0)
                    {
                        StackFunctions.Peek(stack);
                    }
                    else
                    {
                        Console.WriteLine("The stack is empty.");
                    }
                }
                else if (answer == "exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Check spelling errors.");
                }


            }
        }
    }
}
