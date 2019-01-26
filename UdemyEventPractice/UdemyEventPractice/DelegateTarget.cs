using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyEventPractice
{
    // This class contains private methods that will get called by another class when it 
    // raises events that this class has delegated to those private methods.  This class
    // contains an instance of that event-raising class.
    class DelegateTarget
    {
        private EventRaisingClass eventRaisingClassInstance;

        public DelegateTarget()
        {
            eventRaisingClassInstance = new EventRaisingClass();
            eventRaisingClassInstance.EventType1 += delegateTargetMethod1;
            eventRaisingClassInstance.EventType2 += delegateTargetMethod2;
            // now those events when raised in the other class will call each of my
            // private methods!
        }

        private void delegateTargetMethod1()
        {
            Console.WriteLine("private delegateTargetMethod1() has been called!");
        }
        private void delegateTargetMethod2()
        {
            Console.WriteLine("private delegateTargetMethod2() has been called!");
        }

        // this is the method that will call the other class's methods which raise our events
        public void publicMethodOfDelegateTarget()
        {
            Console.WriteLine("In public method of Delegate Target.");
            Console.WriteLine("Calling public method of the event-raising class.");
            Console.WriteLine("That method will raise an event which calls our 1st delegate target.");
            eventRaisingClassInstance.PubMethod1OfEventRaisingClass();
            Console.WriteLine("Now calling another public method of the event-raising class.");
            Console.WriteLine("That method will raise an event which calls our 2nd delegate target.");
            eventRaisingClassInstance.PubMethod2OfEventRaisingClass();
            Console.WriteLine("Now leaving publicMethodOfDelegateTarget");
            Console.WriteLine("Thank you very much and we hope we passed the audition!");
        }
    }


}
