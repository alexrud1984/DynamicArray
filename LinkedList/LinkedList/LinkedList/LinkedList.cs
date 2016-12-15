using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList<T> : ILinkedList<T>
    {
        private LinkedNode<T> head;
        private LinkedNode<T> tail;
        private LinkedNode<T> result;                       // used for getting element by index

        public int Count { private set; get; }

        public LinkedList()
        {
            Count = 0;
        }

        public void AddInHead(T value)
        {
            if (head == null)
            {
                AddFirstElement(value);
                return;
            }

            LinkedNode<T> temp = new LinkedNode<T>(value);  //create new element
            temp.Next = head;                               //make it linked with head
            head = temp;                                    //put created element in head
            Count++;
        }

        public void AddInTail(T value)
        {
            if (tail == null)
            {
                AddFirstElement(value);
                return;
            }

            LinkedNode<T> temp = new LinkedNode<T>(value);  //create new element
            tail.Next = temp;                               //make it linked with tail
            tail = temp;                                    // put new element in tail
            Count++;
        }

        public T Get(int index)
        {
            if (index < 0 && index >= Count || Count==0)
            {
                return default(T);
            }
            return GetByIndex(head, index).Value;
        }

        public void Insert(int index, T value)
        {
            if (index < 1 || index >= Count)
            {
                return;
            }
            LinkedNode<T> previous = GetByIndex(head, index - 1);
            LinkedNode<T> next = previous.Next;
            previous.Next = new LinkedNode<T>(value);
            previous.Next.Next = next;                                     // :-)                 
            Count++;
        }

        public void Remove(int index)
        {
            if (Count == 0 || index <0 || index >= Count)
            {
                return;
            }

            if (index == 0)
            {
                head = GetByIndex(head, 1);
            }
            else if (index == Count - 1)
            {
                GetByIndex(head, index - 1).Next = null;
                tail = GetByIndex(head, index - 1);
            }
            else
            {
                GetByIndex(head, index - 1).Next = GetByIndex(head, index + 1);
            }
            Count--;
            if (Count == 0)
            {
                head = tail = null;
            }
        }

        public void Set(int index, T value)
        {
            if (index<0 || index >= Count)
            {
                return;
            }
            GetByIndex(head, index).Value=value;
        }

        public T GetHead()
        {
            if (head == null)
            {
                return default(T);
            }
            return head.Value;
        }

        public T GetTail()
        {
            if (tail == null)
            {
                return default(T);
            }
            return tail.Value;
        }

        //internal methods

        private void AddFirstElement(T value)
        {
            head = new LinkedNode<T>(value);                                //if first element than it should be in head and tail
            tail = head;
            Count++;
        }

        private LinkedNode<T> GetByIndex(LinkedNode<T> temp, int index)   
        {
            result = temp;
            if (index != 0)                                 // go to the next until index >0
            {
                GetByIndex(temp.Next, index-1);
            }
            return result;
        }

        public class LinkedNode<Type>                                   // nodes class
        {
            public LinkedNode<Type> Next { get; set;}
            public Type Value { get; set; }

            public LinkedNode(Type value)
            {
                Value = value;
                Next = null;
            }
        }

    }
}
