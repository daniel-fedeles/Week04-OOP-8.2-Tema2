using System.Collections.Generic;

namespace week04_OOP_8._2_Tema2
{
    public class MyStack<T>
    {
        private T _genericValue = default;
        private int head = 0;
        public MyStack()
        {
            MyStackList = new List<T>();
        }

        public MyStack(int capacity)
        {
            MyStackList = new List<T>(capacity);
        }

        private List<T> MyStackList { get; }

        public int Count
        {
            get { return this.MyStackList.Count; }
        }

        public void Clear()
        {
            MyStackList.Clear();
        }

        public bool Contains(T generic)
        {
            return MyStackList.Contains(generic);
        }

        public T Peak()
        {
            return this.MyStackList[0];
        }

        public void Pop()
        {
            MyStackList.RemoveAt(head);
        }

        public void Push(T generic)
        {
            MyStackList.Add(generic);
        }

        public T[] ToArray()
        {
            return MyStackList.ToArray();
        }


    }
}
