using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaivdStack
{
    class StackNode <T>
    {
        public StackNode<T> Below;
        public T Item;

        public StackNode(T item, StackNode<T> below)
            :this(item)
        {
            Below = below;
        }
        public StackNode(T item)
        {
            Item = item;
        }
    }
}
