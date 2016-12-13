using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    class DynamicArray<T> : IDynamicArray<T>
    {
        private const int grFactor = 2;
        private int capacity;
        private int size;
        private T[] matrix;

        public T this[int index]
        {
            get
            {
                if (index >= size)
                {
                    return default (T);
                }
                return matrix[index];
            }

            set
            {
                if (index >= size)                      //if index out of size
                {
                    size = index;                       //change size to index to compare with capacity
                    matrix = expand();                  //than try expand matrix
                }
                matrix[index] = value;
            }
        } 


        public DynamicArray(int userCapacity)
        {
            capacity = userCapacity;
            matrix = new T[capacity];
            size = 0;
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }
        }

        public int Size
        {
            get
            {
                return size;
            }
        }

        public void Add(T value)
        {
            matrix=expand();
            matrix[size] = value;
            size++;
        }

        public T Get(int index)
        {

            return this[index];                     //return via the indexer property
        }

        public void Insert(int index, T value)
        {
            if (index >= size)                      //if index out of size
            {
                size = index;                       //change size to index to compare with capacity
                matrix = expand();                  //than try expand matrix
                matrix[index] = value;              //put the value in the end of matrix  
            }
            else
            {
                matrix = expand();                    //try to expand to check/create if need a place
                for (int i = size; i >= index; i--)  //move elemetnts to the right until get index place
                {
                    matrix[i] = matrix[i - 1];
                }
                matrix[index] = value;                //insert elemet to his place
            }
            size++;                                  //increase size
        }

        public void Remove(int index)
        {
            if (index >= size)
            {
                return;
            }
            for (int i = index; i < size; i++)  //move all elements to the left until deleted index reached
            {
                matrix[i] = matrix[i + 1];
            }
            size--;
            if (size * grFactor * 2 < capacity)             //check if size less than capacity more than in 4 times
            {
                T[] tempMatrix;
                capacity = capacity / 2 / grFactor;
                tempMatrix = new T[capacity];    //create new matrix less that original
                for (int i = 0; i < size; i++)
                {
                    tempMatrix[i] = matrix[i];  //copy old matrix to the new
                }
                matrix = tempMatrix;
            }
        }

        private T[] expand ()
        {
            if (size < capacity)
            {
                return matrix;          //no need to expand if size is 0
            }
            T[] tempMatrix;
            while (capacity <= size)    //increase capacity while it less than size
            {
                capacity *= grFactor;
            }
            tempMatrix = new T[capacity];   
            for (int i = 0; i < matrix.Length; i++)
            {
                tempMatrix[i] = matrix[i];  //copy old matrix to the new
            }
            return tempMatrix;
        }
    }
}
