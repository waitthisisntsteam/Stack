using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class Stack<T>
    {
        public T[] stack = new T[0];
        int addAt = 0;

        public void Resize()
        {
            T[] temp = new T[stack.Length + 1];
            for(int i = 0; i < stack.Length; i++)
            {
                temp[i] = stack[i];
            }
            stack = temp;
        }
        public void Push(T current)
        {
            //stack.AddNodeToLast(current);

            if(addAt == stack.Length)
            {
                Resize();
            }
            stack[addAt] = current;
            
            addAt++;
        }
        public T Pop()
        {
            addAt--;
            return stack[addAt];
            //stack.RemoveLast();
        }
        public void Peek()
        { 
                    //Console.WriteLine(stack.Tail.data);
            Console.WriteLine(stack[stack.Length]);
        }
    }
}
