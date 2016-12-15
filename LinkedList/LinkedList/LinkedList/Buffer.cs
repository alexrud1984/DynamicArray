using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public abstract class Buffer<T> : IBuffer<T>
    {
        protected LinkedList <T> bufferMtrx;
        protected int size;

        public Buffer(int size)
        {
            this.size = size;
            bufferMtrx = new LinkedList<T> ();
        }

        public abstract T Peek();

        public bool IsFull()
        {
            if (size == bufferMtrx.Count)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }

        public bool IsEmpty()
        {
            if (bufferMtrx.Count == 0)        
            {
                return (true);
            }
            else
            {
                return (false);
            }

        }

        public void Print()
        {
            {
                for (int i = 0; i < bufferMtrx.Count; i++)
                {
                    Console.WriteLine(bufferMtrx.Get(i).ToString());
                }
                Console.WriteLine();
            }
        }

    }
}
