using System;

namespace CSharp763
{
    class Program
    {
        static char[] Recursion(int k, int t, char[] arrreverse, char[] a, char[] b, int i, int j, int arrl)
        {
            if (i < k)
            {
                arrreverse[i] = a[i];

                return Recursion(k, t, arrreverse, a, b, i + 1, j, arrl);
            }

            else
            {
                if (t < arrl)
                {
                    arrreverse[t] = b[j];

                    return Recursion(k, t + 1, arrreverse, a, b, i, j + 1, arrl);
                }

                else
                {
                    return arrreverse;
                }
            }

        }
    }
}