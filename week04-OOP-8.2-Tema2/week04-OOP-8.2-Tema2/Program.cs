using System;

namespace week04_OOP_8._2_Tema2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue<string> queue = new MyQueue<string>();
            queue.Enqueue("aaaa");
            queue.Enqueue("bbbb");
            queue.Enqueue("cccc");
            queue.Enqueue("dddd");
            queue.Enqueue("eeee");
            queue.Enqueue("ffff");
            queue.Enqueue("gggg");
            for (int i = 0; i < queue.Count(); i++)
            {
                Console.Write(" " + queue[i]);
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine();
            Console.WriteLine();
            //            Console.WriteLine(queue.Peek());
            //            Console.WriteLine(queue.Count());
            //            Console.WriteLine(queue.Contain("dddd"));
            //            Console.WriteLine(queue.Contain("rrr"));


            //            Console.WriteLine(queue.Peek());
            for (int i = 0; i < queue.Count(); i++)
            {
                Console.Write(" " + queue[i]);
            }
            Console.WriteLine();


            //            Queue<int> c = new Queue<int>();
            //            c.Enqueue(2);
            //            c.Enqueue(3);
            //            c.Enqueue(6);
            //            Console.WriteLine(c.Dequeue());
            //            c.TrimExcess();
            //
            //            c.GetEnumerator();
            //            Stack<string> myStack = new Stack<string>();
            //            myStack.Push("sss");


        }
    }
}
