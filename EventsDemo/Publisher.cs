using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo
{
    class Publisher
    {
        public event EventHandler<MyEventArgs> publishEvent;
        public void Publish(MyEventArgs args)
        {
            /*if (publishEvent != null)
            {
                publishEvent(this, args);
            }*/

            publishEvent?.Invoke(this, args);
        }
    }
}
