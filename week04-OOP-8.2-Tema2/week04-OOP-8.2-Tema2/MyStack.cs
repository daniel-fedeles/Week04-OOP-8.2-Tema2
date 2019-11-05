using System;
using System.Collections.Generic;

namespace week04_OOP_8._2_Tema2
{
    public class MyStack<T>
    {
        /// <summary>
        /// The head of the stack
        /// </summary>
        private int head;

        /// <summary>
        /// Initializes a new instance of the <see cref="MyStack{T}"/> class.
        /// </summary>
        public MyStack()
        {
            MyStackList = new List<T>();
            head = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MyStack{T}"/> class.
        /// </summary>
        /// <param name="capacity">The capacity.</param>
        public MyStack(int capacity)
        {
            if (capacity <= 0) Console.WriteLine("The capacity is lower than 0");
            MyStackList = new List<T>(capacity);
            head = 0;
        }

        /// <summary>
        /// Gets my stack list.
        /// </summary>
        /// <value>
        /// My stack list.
        /// </value>
        private List<T> MyStackList { get; }

        /// <summary>
        /// Counts this instance.
        /// </summary>
        /// <returns></returns>
        public int Count() => this.MyStackList.Count;

        /// <summary>
        /// Clears this instance.
        /// </summary>
        public void Clear() => MyStackList.Clear();

        /// <summary>
        /// Determines whether this instance contains the object.
        /// </summary>
        /// <param name="generic">The generic.</param>
        /// <returns>
        ///   <c>true</c> if [contains] [the specified generic]; otherwise, <c>false</c>.
        /// </returns>
        public bool Contains(T generic)
        {
            if (generic == null) Console.WriteLine($"Insert element {generic.GetType()}, null is not valid");
            return MyStackList.Contains(generic);
        }

        /// <summary>
        /// Peaks this instance.
        /// </summary>
        /// <returns></returns>
        public T Peak() => this.MyStackList[head];

        /// <summary>
        /// Pops this instance.
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            T generic = MyStackList[head];
            MyStackList.RemoveAt(head);
            return generic;
        }

        /// <summary>
        /// Pushes the specified generic.
        /// </summary>
        /// <param name="generic">The generic.</param>
        public void Push(T generic)
        {
            if (generic == null) Console.WriteLine($"Insert element {generic.GetType()}, null is not valid");
            MyStackList.Add(generic);
        }

        /// <summary>
        /// Converts to array.
        /// </summary>
        /// <returns></returns>
        public T[] ToArray() => MyStackList.ToArray();

        /// <summary>
        /// Trims the excess.
        /// </summary>
        public void TrimExcess() => MyStackList.TrimExcess();

        /// <summary>
        /// Indexer method
        /// Gets or sets the <see cref="T"/> with the specified i.
        /// </summary>
        /// <value>
        /// The <see cref="T"/>.
        /// </value>
        /// <param name="i">The i.</param>
        /// <returns></returns>
        public T this[int i]
        {
            get => MyStackList[i];
            set => MyStackList[i] = value;
        }


    }
}
