using System;

namespace UdemyCSharpUnit8Quiz6
{
    class Program
    {
        void ParentMethod()
        {
            Console.WriteLine("Hi from to the parent method");
            ChildMethod();
            void ChildMethod()
            {
                Console.WriteLine("Hi from the child method");
            }
        }
        static void Main(string[] args)
        {
            Program pgm = new Program();
            pgm.ParentMethod();
            Console.WriteLine("Hello World!");
        }
    }
}
