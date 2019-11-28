using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo
{
    class Subscriber
    {
        public void Subscribe(Consumer consumer, Publisher publisher) {
            publisher.publishEvent += consumer.MyEventHandler;
            // При первом вызове += значит:
            /* publisher.publishEvent =
                new EventHandler<MyEventArgs>(consumer.MyEventHandler); */
            // При следующих вызовах += значит:
            // publisher.publishEvent.Add(consumer.MyEventHandler);
        }
    }
}
