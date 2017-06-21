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
        
        DavidStack()
        {
            
        }

        public void Push(T item)
        {
            StackNode<T> newNode = new StackNode<T>(item, Top);
            Top = newNode;
        }
        public T Pop()
        {
            T temp = Top.Item;
            Top = Top.Below;
            return temp;
        }
        public T Peek()
        {
            return Top.Item;
        }
        public bool IsEmpty()
        {

        }

    }
}
