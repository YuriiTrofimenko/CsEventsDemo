using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            Consumer consumer = new Consumer() { Id = 1 };
            Consumer consumer2 = new Consumer() { Id = 2 };
            Subscriber subscriber = new Subscriber();

            subscriber.Subscribe(consumer, publisher);
            subscriber.Subscribe(consumer2, publisher);

            publisher.Publish(new MyEventArgs()
            {
                Title = "#1",
                Content = "Lorem ipsun dolor",
                Date = new DateTime()
            });

            Thread.Sleep(5000);

            // Это не работает - объект делегат защищен с помощью события
            // publisher.publishEvent = null;

            publisher.Publish(new MyEventArgs()
            {
                Title = "#2",
                Content = "Lorem ipsun dolor 2",
                Date = new DateTime()
            });
        }
    }
}
