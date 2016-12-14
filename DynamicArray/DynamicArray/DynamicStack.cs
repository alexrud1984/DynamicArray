using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    class DynamicStack <T> : Buffer <T>, IMyStack<T>
    {
        public DynamicStack(int size) : base(size) { }

        public T Pop()                                            //returns top value in the stack
        {
            T temp = bufferMtrx[bufferMtrx.Size - 1];             //save last value in array
            bufferMtrx.Remove(bufferMtrx.Size-1);                  // delete it form array
            return temp;                                          
        }

        public void Push(T value)                                 //push the value to the next free sell
        {
            if (this.IsFull())
            {
                return;
            }
            bufferMtrx.Add(value);
        }


        public override T Peek()                                           //return top value without deletion
        {
            return bufferMtrx[bufferMtrx.Size-1];
        }

    }
}
