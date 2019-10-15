using System;

namespace CSharp762
{
    class Program
    {
        static string Method_Recursion(char[] arr, char[] arrreverse, int i, int j)
        {
            arrreverse[j] = arr[i - 1];

            if (arrreverse[arr.Length - 1] == '\0')
            {
                return Method_Recursion(arr, arrreverse, i - 1, j + 1);
            }
            else
            {
                string rs = new string(arrreverse);

                return rs;
            }
        }
    }
}