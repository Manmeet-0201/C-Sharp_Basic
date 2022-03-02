using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            //dequeuing the top element from queue
            queue.Dequeue();
            //getting the first element from queue
            Console.WriteLine(queue.Peek());
            Console.ReadKey();
        }
    }
}
