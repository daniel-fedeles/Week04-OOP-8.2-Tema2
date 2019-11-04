using System;
using System.Collections.Generic;

namespace week04_OOP_8._2_Tema2
{
    public class MyQueue<T>
    {
        private List<T> MyListQueue { get; }
        private LinkedList<T> LinkedList { get; }


        public MyQueue()
        {
            LinkedList = new LinkedList<T>();
            MyListQueue = new List<T>();

        }
        public MyQueue(int capacity)
        {
            if (capacity < 0)
            {
                Console.WriteLine("Enter capacity");
            }

            this.MyListQueue = new List<T>(capacity);

        }

        public MyQueue(IEnumerable<T> collection)
        {
            if (collection == null)
            {
                Console.WriteLine("Collection is null");
            }
            this.MyListQueue = new List<T>(4);

            foreach (T obj in collection)
            {
                this.Enqueue(obj);
            }

        }

        public int Count()
        {
            return MyListQueue.Count;
        }

        public void Clear()
        {
            MyListQueue.Clear();
            LinkedList.Clear();
        }


        public void Enqueue(T generic)
        {
            MyListQueue.Reverse();
            if (generic != null)
            {
                MyListQueue.Add(generic);
            }
            else
            {
                Console.WriteLine("the value cannot be null");
            }
            MyListQueue.Reverse();
        }


        public T Dequeue()
        {
            //            MyListQueue.Reverse();
            T generic = MyListQueue[MyListQueue.Count - 1];

            MyListQueue.Remove(generic);
            //            MyListQueue.Reverse();
            return generic;

        }

        public bool Contain(T generic)
        {
            if (generic == null) Console.WriteLine("the element is null");
            return MyListQueue.Contains(generic);
        }

        public T Peek()
        {
            return MyListQueue[0];
        }

        public T[] ToArray()
        {
            return MyListQueue.ToArray();
        }

        public void TrimExcess()
        {
            MyListQueue.TrimExcess();
        }


        public T this[int i]
        {
            get
            {
                return MyListQueue[i];
            }
            set
            {
                MyListQueue[i] = value;
            }
        }
    }
}
