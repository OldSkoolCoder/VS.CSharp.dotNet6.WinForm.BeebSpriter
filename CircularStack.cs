using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeebSpriter
{
    public class CircularStack<T>
    {
        private int stackSize;
        private int top = 0;
        private int count = 0;
        private T[] stack;

        public int Count
        {
            get { return count; }
        }

        public CircularStack()
        {
            stackSize = 32;
            stack = new T[stackSize];
        }

        public CircularStack(int size)
        {
            stackSize = size;
            stack = new T[stackSize];
        }

        public void Push(T item)
        {
            stack[top] = item;
            top = (top + 1) % stackSize;
            if (count < stackSize)
            {
                count++;
            }
        }

        public T Pop()
        {
            if (count == 0)
            {
                throw new Exception("Stack empty");
            }
            else
            {
                count--;
                top = (top + stackSize - 1) % stackSize;
                T item = stack[top];
                stack[top] = default(T);
                return item;
            }
        }

        public void Clear()
        {
            stack.Initialize();
            count = 0;
            top = 0;
        }
    }
}
