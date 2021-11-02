using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays.Algorithms
{
    //series of n daily price quotes for stock
    //need to calculate span of stock's price for all n days
    //span Si of stock's price on given day i = max num of consec days just before given day 
    //when price of current day is less than price of given day
    public class StockSpan
    {
        public void SpanOfStock(int[] price, int[] span)
        {
            //create stack and push index of first element into it
            var st = new Stack<int>();
            st.Push(0);

            //span of first element always one
            span[0] = 1;

            //traverse price array and calculate span values
            for(int i = 1; i < price.Length; i++)
            {
                //if stack is not empty and top element of stack is < price[i]
                while(st.Count > 0 && price[(int)st.Peek()] <= price[i])
                {
                    st.Pop();
                }

                //if stack is  empty, then price[i] is greater than all elements on the left of it
                //otherwise, price[i] is greater than elements after the top of stack
                span[i] = (st.Count == 0) ? (i + 1) : (i - (int)st.Peek());

                //push this element into the stack
                st.Push(i);
            }

            //print span array
            for(int i = 0; i < span.Length; i++)
            {
                Console.WriteLine(span[i] + " ");
            }
        }
    }
}
