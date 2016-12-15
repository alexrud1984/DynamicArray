using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    interface ILinkedStack<T>:IBuffer<T>
    {
        void Push(T value);
        T Pop();
    }
}
