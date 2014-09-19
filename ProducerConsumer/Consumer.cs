using System;

namespace ProducerConsumer
{
    class Consumer
    {
        private BoundedBuffer buf;
        public Consumer(BoundedBuffer obj)
        {
            buf = obj;
        }
        public void Run()
        {
            int i = 0;
            while (buf.MyQueue.Count == 0)
            {
                
            }
            while (i < buf.InQueue)
            {
                int tempI = i;
                lock (buf)
                if (buf.MyQueue.Count != 0)
                {
                    {
                        buf.Take();
                        Console.WriteLine("Line removed");
                        i = tempI + 1;         
                    }
                }
            } 
            Console.WriteLine("Consumer Done");
        }

    }
}
