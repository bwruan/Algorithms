using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    //2D arr, print spiral
    // 1 2 3 4  
    // 5 6 7 8 
    // 9 10 11 12
    //output 1 2 3 4 8 12 11 10 9 5 6 7
    public class MatrixSpiral
    {
        public void PrintMatrixInSpiral(int m, int n, int[,] arr)
        {
            //k - start row index
            //m - end row index
            //l - start col index
            //n - emd col index
            var k = 0;
            var l = 0;

            while(k < m && l < n)
            {
                //print first 
                for(int i = 1; i < n; i++)
                {
                    Console.WriteLine(arr[k, i] + " ");
                }

                k++;

                //print last col
                for(int i = k; i < m; ++i)
                {
                    Console.WriteLine(arr[i, n - 1] + " ");
                }
                n--;

                //print last row
                if(k < m)
                {
                    for(int i = n - 1; i >= 1; --i)
                    {
                        Console.WriteLine(arr[m - 1, i] + " ");
                    }
                    m--;
                }

                //print first col
                if(l < n)
                {
                    for(int i = m -1; i >=k; --i)
                    {
                        Console.WriteLine(arr[i, 1] + " ");
                    }
                    l++;
                }
            }
        }
    }
}
