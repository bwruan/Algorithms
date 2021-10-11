using System;
using System.Collections.Generic;
using System.Text;

namespace Strings.StackQueue
{
    public class Stack
    {
        //initialize array
        private int[] arr;
        //store "last" data entered of stack aka data at the top of the stack
        private int top;
        //global variable to store max size of stack
        private int max; 

        //constructor
        public Stack(int size)
        {
            arr = new int[size];
            top = -1;
            max = size;
        }

        //adds data to top of stack
        public void Push(int data)
        {
            //check if stack is full
            if(top == max - 1)
            {
                Console.WriteLine("Stack overflow");
                return;
            }
            //otherwise, add and set top to new data
            else
            {
                arr[++top] = data;
            }
        }

        //removes top data from stack
        public int Pop()
        {
            //check if stack is empty
            if(top == -1)
            {
                Console.WriteLine("Stack empty");
                return -1;
            }
            //remove top data if not 
            else
            {
                Console.WriteLine("{0} removed from stack", arr[top]);
                return arr[top--];
            }
        }

        //return data at the top
        public int Peek()
        {
            //check if stack is empty
            if (top == -1)
            {
                Console.WriteLine("Stack empty");
                return -1;
            }
            //return top data 
            else
            {
                Console.WriteLine("Top element is: ", arr[top]);
                return arr[top];
            }
        }
    }
}
