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
            CheckStack();
            CheckQueue();
        }

        static void CheckStack()
        {
            DynamicStack<Something> stack = new DynamicStack<Something>(5);

            Console.WriteLine("Check Stack");

            PrintBuffer(stack);

            Console.WriteLine("Push 1");
            stack.Push(new Something ("1"));
            PrintBuffer(stack);

            Console.WriteLine("Peek " + stack.Peek());
            PrintBuffer(stack);

            Console.WriteLine("Pop " + stack.Pop());
            PrintBuffer(stack);

            Console.WriteLine("Push 1");
            stack.Push(new Something("1"));
            PrintBuffer(stack);
            Console.WriteLine("Push 2");
            stack.Push(new Something("2"));
            PrintBuffer(stack);
            Console.WriteLine("Push 3");
            stack.Push(new Something("3"));
            PrintBuffer(stack);
            Console.WriteLine("Push 4");
            stack.Push(new Something("4"));
            PrintBuffer(stack);
            Console.WriteLine("Push 5");
            stack.Push(new Something("5"));
            PrintBuffer(stack);
            Console.WriteLine("Push 6");
            stack.Push(new Something("6"));
            PrintBuffer(stack);

            Console.WriteLine("Peek " + stack.Peek());
            PrintBuffer(stack);

            Console.WriteLine("Pop " + stack.Pop());
            PrintBuffer(stack);
            Console.WriteLine("Pop " + stack.Pop());
            PrintBuffer(stack);
            Console.WriteLine("Pop " + stack.Pop());
            PrintBuffer(stack);
            Console.WriteLine("Pop " + stack.Pop());
            PrintBuffer(stack);
            Console.WriteLine("Pop " + stack.Pop());
            PrintBuffer(stack);
            Console.WriteLine("Pop " + stack.Pop());
            PrintBuffer(stack);

        }

        static void CheckQueue()
        {
            DynamicQueue<Something> queue = new DynamicQueue<Something>(5);
            Console.WriteLine("Check queue");

            PrintBuffer(queue);

            queue.Enqueue(new Something("1"));
            Console.WriteLine("add 1");
            PrintBuffer(queue);

            Console.WriteLine ("Peek: " + queue.Peek());
            PrintBuffer(queue);

            Console.WriteLine("Dequeue: " + queue.Dequeue());
            PrintBuffer(queue);

            queue.Enqueue(new Something("1"));
            Console.WriteLine("add 1");
            PrintBuffer(queue);
            queue.Enqueue(new Something("2"));
            Console.WriteLine("add 2");
            PrintBuffer(queue);
            queue.Enqueue(new Something("3"));
            Console.WriteLine("add 3");
            PrintBuffer(queue);
            queue.Enqueue(new Something("4"));
            Console.WriteLine("add 4");
            PrintBuffer(queue);
            queue.Enqueue(new Something("5"));
            Console.WriteLine("add 5");
            PrintBuffer(queue);
            queue.Enqueue(new Something(""));
            Console.WriteLine("add 6");
            PrintBuffer(queue);

            Console.WriteLine("Peek: " + queue.Peek());
            PrintBuffer(queue);

            Console.WriteLine("Peek: " + queue.Peek());
            PrintBuffer(queue);

            Console.WriteLine("Dequeue: " + queue.Dequeue());
            PrintBuffer(queue);

            Console.WriteLine("Dequeue: " + queue.Dequeue());
            PrintBuffer(queue);

            Console.WriteLine("Dequeue: " + queue.Dequeue());
            PrintBuffer(queue);

            Console.WriteLine("Dequeue: " + queue.Dequeue());
            PrintBuffer(queue);

            Console.WriteLine("Dequeue: " + queue.Dequeue());
            PrintBuffer(queue);

            Console.WriteLine("Dequeue: " + queue.Dequeue());
            PrintBuffer(queue);

            Console.WriteLine("Dequeue: " + queue.Dequeue());
            PrintBuffer(queue);


        }

        static void PrintBuffer(Buffer<Something> buffer)
        {
            Console.WriteLine("Is full - " + buffer.IsFull());
            Console.WriteLine("Is empty - " + buffer.IsEmpty());
            buffer.Print();
            Console.ReadKey();
        }

    }
}
