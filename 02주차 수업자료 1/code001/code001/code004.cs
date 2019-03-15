using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code003
{
    class Event
    {
        public EventHandler EventHandler;

        public Event()
        {
            this.EventHandler += new EventHandler(MyEventHandler);
        }

        void MyEventHandler(object o, EventArgs e)
        {
            Console.WriteLine("HelloWolrd");
        }

        public void invokeEvent()
        {
            if(EventHandler != null)
            {
                EventHandler(this, null);
            }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            new Event().invokeEvent();
        }
    }


}
