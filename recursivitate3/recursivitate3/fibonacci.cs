using System;
using System.Collections.Generic;
using System.Text;

namespace recursivitate3
{
    class fibonacci
    {
        public static int fib(int a,int b,int n, int p )

        {
             if (n == p)
                return a;
            else
                return fib(b, a + b, n + 1, p);
        }
    }
}
