using System;
using System.Collections.Generic;

namespace ProducerConsumer
{
    class BoundedBuffer
    {

        public Queue<int> MyQueue = new Queue<int>();
        public int Max = 0;
        public BoundedBuffer(int i)
        {
            Max = i;
        }

        public bool IsFull()
        {
            return Max != MyQueue.Count;
        }

        public void Put(int number)
        {
            if (!IsFull()) 
            {
                MyQueue.Enqueue(number);
                Console.WriteLine("Line added");
            }
        }

        public int Take()
        {
            return MyQueue.Dequeue();
        }


    }
}
