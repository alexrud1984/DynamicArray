using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    interface ILinkedList <T>
    {
        T Get (int index);
        T GetHead();
        T GetTail();
        void Set(int index, T value);
        void Insert (int index, T value);
        void AddInTail (T value);
        void AddInHead(T value);
        void Remove(int index);
    }
}
