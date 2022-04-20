using System;
using System.Collections.Generic;
using System.Text;

namespace Multi_bracket_Validation_
{
    public class Stack
    {
        public Node Top { get; set; }

        public Stack()
        {
            Top = null;
        }

        public void Push(char value)
        {
            Node node = new Node(value);
            node.Next = Top;
            Top = node;
        }

        public Node Pop()
        {
            Node temp = Top;
            Top = Top.Next;
            temp.Next = null;
            return temp;
        }

        public Node Peek()
        {
            return Top;
        }
    }
}
