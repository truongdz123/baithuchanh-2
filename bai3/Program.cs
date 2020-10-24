using System;
namespace bai_3
{
    class Queue
    {
        private int[] q;
        private int front, rear;
        public Queue(int n)
        {
            front = rear = 0;
            q = new int[n];
        }
        public bool full()
        {
            return rear >= q.Length - 1;
        }
        public bool empty()
        {
            return front == 0;
        }
        public void push(int x)
        {
            if (full())
            {
                Console.WriteLine("queue day");
            }
            else
            {
                q[front++] = x;
            }
        }
        public int pop()
        {
            if (empty())
                throw new Exception("queue rong");
            else
            {
                int x = q[front--];
                return x;
            }
        }
    }
    class test
    {
        static void Main1(string[] args)
        {
            Queue q = new Queue(20);
            q.push(3);
            q.push(4);
            q.push(5);
            while (!q.empty())
                Console.WriteLine(q.pop());
            Console.ReadKey();

        }
    }
}