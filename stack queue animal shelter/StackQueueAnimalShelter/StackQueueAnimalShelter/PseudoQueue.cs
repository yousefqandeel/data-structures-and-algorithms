using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueAnimalShelter
{
    public class PseudoQueue<T>
    {
        public Stack<T> s1 = new Stack<T>();
        public Stack<T> s2 = new Stack<T>();

        public void Enqueue(T node)
        {
            s1.Push(node);
        }

        public Node<T> Dequeue()
        {
            while (!s1.IsEmpty())
            {
                s2.Push(s1.Pop().Value);
            }

            Node<T> temp = s2.Pop();

            while (!s1.IsEmpty())
            {
                s1.Push(s2.Pop().Value);
            }

            return temp;
        }
    }
}
