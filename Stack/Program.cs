using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace Stack
{
    public class Program
    {
        public int[] stack = new int[0];
        public void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Push, pop, peek, or exit?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "push")
                {
                    Console.WriteLine("What would you like to push?");
                    int pushAnswer = int.Parse(Console.ReadLine());
                    Stack.Stack.Push(pushAnswer);
                }
                else if (answer == "pop")
                {
                    if (Stack.Stack.addAt > 0)
                    {
                        Stack.Stack.Pop();
                    }
                    else
                    {
                        Console.WriteLine("The stack is empty.");
                    }
                }
                else if (answer == "peek")
                {
                    if (Stack.Stack.addAt > 0)
                    {
                        Stack.Stack.Peek();
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
