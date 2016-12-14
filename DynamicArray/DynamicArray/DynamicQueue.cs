using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    class DynamicQueue <T> : Buffer <T>, IDynamicQueue<T>
    {
        public DynamicQueue(int size) : base(size) { }
      
        public void Enqueue(T value)                    //put new value in queue
        {
            if (this.IsFull())
            {
                return;
            }
            bufferMtrx.Add(value);           
        }

        public T Dequeue()
        {
            T temp;
            temp = bufferMtrx[0];       //get first element from array
            bufferMtrx.Remove(0);       //remove this element
            return temp;
        }

        public override T Peek()
        {
            return bufferMtrx[0];
        }
    }
}
