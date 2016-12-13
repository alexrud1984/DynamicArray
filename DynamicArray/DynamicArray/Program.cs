using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArray<int> array = new DynamicArray<int>(2);

            PrintArray(array);

            array.Add(1);
            PrintArray(array);

            array.Add(2);
            PrintArray(array);

            array.Insert(8, 9);
            PrintArray(array);

            array.Add(10);
            PrintArray(array);

            array.Insert(6, 7);
            PrintArray(array);

            array.Insert(7, 8);
            PrintArray(array);

            array.Remove(8);
            PrintArray(array);

            array.Remove(8);
            PrintArray(array);

            array[2] = 3;
            PrintArray(array);

        }

        static void PrintArray(DynamicArray<int> array)
        {
            Console.WriteLine();
            Console.WriteLine("capacity - " + array.Capacity);
            Console.WriteLine("size - " + array.Size);
            for (int i = 0; i < array.Size; i++)
            {
                Console.Write(array.Get(i) + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }

    }
}
