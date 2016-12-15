using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedStack <T> : Buffer <T>, ILinkedStack<T>
    {
        public LinkedStack(int size) : base(size) { }

        public T Pop()                                            //returns top value in the stack
        {
            T temp = bufferMtrx.GetTail();                        //save last value in array
            bufferMtrx.Remove(bufferMtrx.Count-1);                  // delete it form array
            return temp;                                          
        }

        public void Push(T value)                                 //push the value to the next free sell
        {
            if (this.IsFull())
            {
                return;
            }
            bufferMtrx.AddInTail(value);
        }


        public override T Peek()                                           //return top value without deletion
        {
            return bufferMtrx.GetTail();
        }

    }
}
