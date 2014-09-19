using System;

namespace ProducerConsumer
{
    class Producer
    {
        public int HowMany;
        private BoundedBuffer buf;

        public Producer(BoundedBuffer obj, int i)
        {
            HowMany = i;
            buf = obj;
        }

        public void Run()
        {
            int i = 0;
            buf.InQueue = HowMany;
            while (i < HowMany)
            {
                int tempI = i;
                lock (buf)
                if (!buf.IsFull())
                {
                    {
                        var rnd = new Random();
                        int number = rnd.Next(1, 1000);
                        buf.Put(number);
                        Console.WriteLine("Line added");
                        i = tempI+1;  
                    }

                }
            }
            Console.WriteLine("Producer Done");

        }
    }
}
