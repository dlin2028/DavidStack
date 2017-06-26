using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaivdStack
{
    class DavidStack <T>
    {
        public StackNode<T> Top;
        public int count;
        public DavidStack()
        {
            count = 0;
        }

        public void Push(T item)
        {
            StackNode<T> newNode = new StackNode<T>(item, Top);
            Top = newNode;
            count++;
        }

        public T Pop()
        {      
            if(count > 0)
            {
                T temp = Top.Item;
                Top = Top.Below;
                count--;
                return temp;
            }

            throw new Exception("Stack is empty");
        }
        public T Peek()
        {
            if (count > 0)
            {
                return Top.Item;
            }
            throw new Exception("Stack is empty");
        }
        public bool IsEmpty()
        {
            return count <= 0;
        }
        public override string ToString()
        {
            StackNode<T> currentNode = Top;
            string output = "";
            for (int i = 0; i < count; i++)
            {
                output += currentNode.Item + "\n";
                currentNode = currentNode.Below;
            }
            return output;
        }
    }
}
