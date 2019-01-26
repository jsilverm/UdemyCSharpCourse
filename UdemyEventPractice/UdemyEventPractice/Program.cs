using System;

namespace UdemyEventPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateTarget dt = new DelegateTarget();
            dt.publicMethodOfDelegateTarget();
            Console.WriteLine("Hello World!");
        }
    }
}
