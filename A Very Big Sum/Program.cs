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

class Solution
{
    public static long aVeryBigSum(List<long> ar)
    {
        long sum = 0;

        foreach (long number in ar)
        {
            sum += number;
        }

        return sum;
    }

    public static void Main(string[] args)
    {

        int arCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<long> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();

        long result = aVeryBigSum(ar);

        Console.WriteLine(result);
    }
}
