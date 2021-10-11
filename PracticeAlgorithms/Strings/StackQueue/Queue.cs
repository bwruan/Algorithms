using System;
using System.Collections.Generic;
using System.Text;

namespace Strings.StackQueue
{
    public class Queue
    {
        private int[] arr;
        private int front;
        private int back;
        private int max;

        public Queue(int size)
        {
            arr = new int[size];
            front = 0;
            back = -1;
            max = size;
        }

        //add to back of queue
        public void Enqueue(int data)
        {
            if(back == max - 1)
            {
                Console.WriteLine("Overflow");
                return;
            }
            else
            {
                arr[++back] = data;
            }
        }

        //remove from front of queue
        public int Dequeue()
        {
            if(front == back + 1)
            {
                Console.WriteLine("Empty Queue");
                return -1;
            }
            else
            {
                Console.WriteLine(arr[front] + "removed from queue");
                return arr[front++];
            }
        }
    }
}
