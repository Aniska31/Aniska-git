using System;
using System.Threading;

namespace prak8_3
{
    class Program
    {
        static void ShowHyText(object state)
        {
            string myText = (string)state;
            Console.WriteLine("Thread: (0) - (1)", Thread.CurrentThread.ManagedThreadId, myText);
    }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
