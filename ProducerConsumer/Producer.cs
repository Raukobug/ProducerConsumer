using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

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
            for (int i = 0; i < HowMany; i++)
            {
                var rnd = new Random();
                int number = rnd.Next(1, 1000);
                buf.Put(number);
            }
        }
    }
}
