using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace Stack
{
    public class Stack<T>
    {
        public T[] stack = new T[0];
        int index = 0;
        public int Count => index;
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
            if(index == stack.Length)
            {
                Resize();
            }
            stack[index] = current;
            
            index++;
        }
        public T Pop()
        {
            if (index <= 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            index--;
            return stack[index];
        }
        public T Peek()
        {
            if (index <= 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            return stack[index-1];
        }
    }
}
