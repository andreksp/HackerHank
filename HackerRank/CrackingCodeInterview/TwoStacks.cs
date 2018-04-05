using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.CrackingCodeInterview
{
    public class TwoStacks
    {
        public static void Run()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            MyQueue<int> queue = new MyQueue<int>();

            for (int i = 0; i < n; i++)
            {
                var data = Console.ReadLine().Split();

                int operation = Convert.ToInt32(data[0]);
                if (operation == 1)
                { // enqueue
                    queue.Enqueue(Convert.ToInt32(data[1]));
                }
                else if (operation == 2)
                { // dequeue
                    queue.Dequeue();
                }
                else if (operation == 3)
                { // print/peek
                    Console.WriteLine(queue.Peek());
                }
            }
        }


        public class MyQueue<T>
        {
            private Stack<T> stack1 = new Stack<T>();
            private Stack<T> stack2 = new Stack<T>();

            public MyQueue()
            {

            }

            public void Enqueue(T value)
            {
                stack1.Push(value);
            }

            public T Dequeue()
            {
                if (stack2.Count == 0)
                {
                    while (stack1.Count > 0)
                    {
                        stack2.Push(stack1.Pop());
                    }
                }

                var temp = stack2.Pop();

                return temp;
            }

            public T Peek()
            {
                if (stack2.Count == 0)
                {
                    while (stack1.Count > 0)
                    {
                        stack2.Push(stack1.Pop());
                    }
                }

                var temp = stack2.Peek();

                return temp;
            }
        }
    }

}
