using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            buf.Take();
            Console.WriteLine("Line removed");
        }

    }
}
