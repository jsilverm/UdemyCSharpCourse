using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyEventPractice
{
    // this class contains two public delegates and two public event types that call
    // delegated methods thru them when the events are raised.
    class EventRaisingClass
    {
        public delegate void Delegate1();
        public event Delegate1 EventType1;

        public delegate void Delegate2();
        public event Delegate2 EventType2;

        public void PubMethod1OfEventRaisingClass()
        {
            Console.WriteLine("In PubMethod1OfEventRaisingClass() ");
            EventType1();
            Console.WriteLine("Back in PubMethod1OfEventRaisingClass().");
            Console.WriteLine("Did the event hit the private method it was delegated to?");
        }
        public void PubMethod2OfEventRaisingClass()
        {
            Console.WriteLine("In PubMethod2OfEventRaisingClass() ");
            EventType2();
            Console.WriteLine("Back in PubMethod2OfEventRaisingClass().");
            Console.WriteLine("Did the event hit the private method it was delegated to?");
        }

    }
}
