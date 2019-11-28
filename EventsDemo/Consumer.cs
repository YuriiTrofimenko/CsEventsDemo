using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo
{
    class Consumer
    {
        public int Id { get; set; }
        public void MyEventHandler(object sender, MyEventArgs eventArgs) {
            Console.WriteLine($"Consumer #{Id}.I'm reading a magazine:");
            Console.WriteLine("Title: " + eventArgs.Title);
        }
    }
}
