using System;

namespace week04_OOP_8._2_Tema2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue<string> queue = new MyQueue<string>();
            Console.WriteLine("Queue");
            queue.Enqueue("aaaa");
            queue.Enqueue("bbbb");
            queue.Enqueue("cccc");
            queue.Enqueue("dddd");
            queue.Enqueue("eeee");
            queue.Enqueue("ffff");
            queue.Enqueue("gggg");
            Console.WriteLine("Queue with elements " + queue.GetType());
            for (int i = 0; i < queue.Count(); i++)
            {
                Console.Write(" " + queue[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Element aaaa is present: " + queue.Contains("aaaa"));

            Console.WriteLine();
            Console.WriteLine("Peak " + queue.Peek());
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Dequeue element  " + queue.Dequeue());
            Console.WriteLine();
            Console.WriteLine("Elements after Dequeue");
            Console.WriteLine();

            for (int i = 0; i < queue.Count(); i++)
            {
                Console.Write(" " + queue[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---------------");
            Console.WriteLine("Stack");
            Console.WriteLine();
            MyStack<string> stack = new MyStack<string>();

            stack.Push("aaaa");
            stack.Push("bbbb");
            stack.Push("cccc");
            stack.Push("dddd");
            stack.Push("eeee");
            stack.Push("ffff");
            stack.Push("gggg");

            Console.WriteLine("Stack with elements " + stack.GetType());
            for (int i = 0; i < stack.Count(); i++)
            {
                Console.Write(" " + stack[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Element aaaa is present: " + stack.Contains("aaaa"));

            Console.WriteLine();
            Console.WriteLine("Peak " + stack.Peak());
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("POP element  " + stack.Pop());
            Console.WriteLine();
            Console.WriteLine("Elements after POP");
            Console.WriteLine();

            for (int i = 0; i < stack.Count(); i++)
            {
                Console.Write(" " + stack[i]);
            }
            Console.WriteLine();





        }
    }
}
