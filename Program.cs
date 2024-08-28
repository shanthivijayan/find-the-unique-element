using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'lonelyinteger' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static int lonelyinteger(List<int> a)
    {
        a.Sort();
        for (int i = 0; i < a.Count; i++)
        {
            int unique = 0;
            for (int j = 0; j < a.Count; j++)
            {
                if (a[i] == a[j])
                {
                    unique++;
                }
            }
            if (unique == 1)
            {
                return a[i];
            }

        }
        return -1;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Given an array of integers, where all elements but one occur twice, find the unique element.");

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.lonelyinteger(a);
        Console.WriteLine(result);

    }
}
