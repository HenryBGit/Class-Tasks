using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    public class Stack
    {
        private string[] items;
        private int top;

        public Stack(int capacity)
        {
            items = new string[capacity];
            top = -1;
        }

        public void Push(string item)
        {
            if (top == items.Length - 1)
            {
                throw new Exception("Stack is full");
            }
            items[++top] = item;
        }

        public string Pop()
        {
            if (top == -1)
            {
                throw new Exception("Stack is empty");
            }
            return items[top--];
        }

        public string Peek()
        {
            if (top == -1)
            {
                throw new Exception("Stack is empty");
            }
            return items[0];
        }
    }
}
