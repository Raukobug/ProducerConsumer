using System;
using System.Collections.Generic;

namespace ProducerConsumer
{
    class BoundedBuffer
    {

        public Queue<int> MyQueue = new Queue<int>();
        public int I = 0;
        public BoundedBuffer(int i)
        {
            I = i;
        }

        public Boolean IsFull()
        {
            if (I == MyQueue.Count)
            {
                return false;
            }
            return true;
        }

        public void Put(int i)
        {
            if (IsFull()) 
            {
                var rnd = new Random();
                int number = rnd.Next(1, 1000);
                MyQueue.Enqueue(number);
            }
        }

        public int Take()
        {
            return MyQueue.Dequeue();
        }


    }
}
