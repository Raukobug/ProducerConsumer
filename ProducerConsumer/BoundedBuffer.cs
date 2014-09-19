﻿
using System.Collections.Generic;

namespace ProducerConsumer
{
    class BoundedBuffer
    {

        public Queue<int> MyQueue = new Queue<int>();
        public int Max = 0;
        public int InQueue;
        public BoundedBuffer(int i)
        {
            Max = i;
        }

        public bool IsFull()
        {
            if (Max == MyQueue.Count)
            {
                return true;
            }
            return false;
        }

        public void Put(int number)
        {
            MyQueue.Enqueue(number);
        }

        public int Take()
        {
            return MyQueue.Dequeue();
        }


    }
}
