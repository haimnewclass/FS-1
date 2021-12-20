using System;

namespace QueueProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Queue q = new Queue();
            Item i1 = new Item();
            i1.name = "cola";
            i1.val = 10;

            Item i2 = new Item();
            i2.name = "pepsi";
            i2.val = 11;

            Item i3 = new Item();
            i3.name = "bisli";
            i3.val = 12;

            q.Push(i1);
            q.Push(i2);
            q.Push(i3);

        }
    }
}
