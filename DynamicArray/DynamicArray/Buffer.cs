using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    public abstract class Buffer<T> : IBuffer<T>
    {
        protected DynamicArray <T> bufferMtrx;
        protected int size;

        public Buffer(int size)
        {
            this.size = size;
            bufferMtrx = new DynamicArray <T> (size);
        }

        public abstract T Peek();

        public bool IsFull()
        {
            if (size == bufferMtrx.Size)
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
            if (bufferMtrx.Size == 0)        
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
                for (int i = 0; i < bufferMtrx.Size; i++)
                {
                    Console.WriteLine(bufferMtrx[i].ToString());
                }
                Console.WriteLine();
            }
        }

    }
}
