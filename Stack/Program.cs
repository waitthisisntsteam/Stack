using System;
using System.Xml.Schema;

namespace Stack
{
    class Program
    {
        public static void Push<T>(DoublyLinkedList<T> stack, T current)
        {
            stack.AddNodeToLast(current);
        }
        public static void Pop<T>(DoublyLinkedList<T> stack)
        {
            stack.RemoveLast();
        }
        public static void Peek<T>(DoublyLinkedList<T> stack)
        {
            Console.WriteLine(stack.Tail.data);
        }

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
                    Push(stack, pushAnswer);
                }
                else if (answer == "pop")
                {
                    if (stack.Count > 0)
                    {
                        Pop(stack);
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
                        Peek(stack);
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
