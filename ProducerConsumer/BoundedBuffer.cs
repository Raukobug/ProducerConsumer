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

        public Boolean IsFull()
        {
            if (Max == MyQueue.Count)
            {
                return false;
            }
            return true;
        }

        public void Put(int number)
        {
            if (IsFull()) 
            {
                MyQueue.Enqueue(number);
            }
        }

        public int Take()
        {
            return MyQueue.Dequeue();
        }


    }
}
