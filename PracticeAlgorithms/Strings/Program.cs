using Strings.Algos;
using Strings.StackQueue;
using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Stack(5);

            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Pop();

            var q = new Queue(5);

            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Dequeue();
        }
    }
}
