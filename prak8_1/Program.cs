//Создание нескольких потоков
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace prak8_1
{
    class Program
    {
        static void Counting()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Count: {0} - Thread' {1} ", i, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(10);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
