using System;
using System.Collections.Generic;

namespace week04_OOP_8._2_Tema2
{
    public class MyQueue<T>
    {
        /// <summary>
        /// The head
        /// </summary>
        private int head;

        /// <summary>
        /// The tail
        /// </summary>
        private int tail;

        /// <summary>
        /// Initializes a new instance of the <see cref="MyQueue{T}"/> class.
        /// </summary>
        public MyQueue()
        {
            MyListQueue = new List<T>();
            head = 0;
            tail = MyListQueue.Count;

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="MyQueue{T}"/> class.
        /// </summary>
        /// <param name="capacity">The capacity.</param>
        public MyQueue(int capacity)
        {
            if (capacity < 0)
            {
                Console.WriteLine("Enter capacity");
            }

            this.MyListQueue = new List<T>(capacity);
            head = 0;
            tail = MyListQueue.Count;

        }

        /// <summary>
        /// Gets my list queue.
        /// </summary>
        /// <value>
        /// My list queue.
        /// </value>
        private List<T> MyListQueue { get; }

        /// <summary>
        /// Counts this instance.
        /// </summary>
        /// <returns></returns>
        public int Count() => MyListQueue.Count;

        /// <summary>
        /// Clears this instance.
        /// </summary>
        public void Clear() => MyListQueue.Clear();


        /// <summary>
        /// Enqueues the specified generic.
        /// </summary>
        /// <param name="generic">The generic.</param>
        public void Enqueue(T generic)
        {
            MyListQueue.Reverse();
            if (generic != null)
            {
                MyListQueue.Add(generic);
            }
            else
            {
                Console.WriteLine($"Insert element {generic.GetType()}, null is not valid");
            }
            MyListQueue.Reverse();
        }


        /// <summary>
        /// Dequeues this instance.
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {
            T generic = MyListQueue[head];

            MyListQueue.Remove(generic);

            return generic;

        }

        /// <summary>
        /// Contains the specified generic.
        /// </summary>
        /// <param name="generic">The generic.</param>
        /// <returns></returns>
        public bool Contains(T generic)
        {
            if (generic == null) Console.WriteLine($"Insert element {generic.GetType()}, null is not valid");
            return MyListQueue.Contains(generic);
        }

        /// <summary>
        /// Peeks this instance.
        /// </summary>
        /// <returns></returns>
        public T Peek() => MyListQueue[head];

        /// <summary>
        /// Converts to array.
        /// </summary>
        /// <returns></returns>
        public T[] ToArray() => MyListQueue.ToArray();

        /// <summary>
        /// Trims the excess.
        /// </summary>
        public void TrimExcess() => MyListQueue.TrimExcess();


        /// <summary>
        /// Gets or sets the <see cref="T"/> with the specified i.
        /// </summary>
        /// <value>
        /// The <see cref="T"/>.
        /// </value>
        /// <param name="i">The i.</param>
        /// <returns></returns>
        public T this[int i]
        {
            get => MyListQueue[i];
            set => MyListQueue[i] = value;
        }
    }
}
