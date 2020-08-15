using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace Stack
{
    public class Program
    {
        public int[] stack = new int[0];
        public static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            while (true)
            {
                Console.WriteLine("Push, pop, peek, or exit?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "push")
                {
                    Console.WriteLine("What would you like to push?");
                    int pushAnswer = int.Parse(Console.ReadLine());
                    stack.Push(pushAnswer);
                }
                else if (answer == "pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (answer == "peek")
                {
                    try
                    {
                        Console.WriteLine(stack.Peek());
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
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
