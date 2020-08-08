using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class StackFunctions
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
    }
}
