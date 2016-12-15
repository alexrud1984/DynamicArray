using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedQueue <T> : Buffer <T>, ILinkedQueue<T>
    {
        public LinkedQueue(int size) : base(size) { }
      
        public void Enqueue(T value)                    //put new value in queue
        {
            if (this.IsFull())
            {
                return;
            }
            bufferMtrx.AddInTail (value);           
        }

        public T Dequeue()
        {
            T temp = bufferMtrx.GetHead();
            bufferMtrx.Remove(0);       //remove this element
            return temp;
        }

        public override T Peek()
        {
            return bufferMtrx.GetHead();
        }
    }
}
