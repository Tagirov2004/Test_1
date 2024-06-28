using System;
using System.Collections.Generic;

class Program
{
    public static List<int> MergeAndSort(List<int> a, List<int> b)
    {
        List<int> res = new List<int>();
        int i = 0, j = 0;

        while (i < a.Count && j < b.Count)
        {
            if (a[i] <= b[j])
            {
                res.Add(a[i]);
                i++;
            }
            else
            {
                res.Add(b[j]); 
                j++;
            }
        }

        while (i < a.Count)
        {
            res.Add(a[i]);
            i++;
        }

        while (j < b.Count)
        {
            res.Add(b[j]);
            j++;
        }

        return res;
    }

    static void Main(string[] args)
    {
        // Пример
        List<int> a = new List<int> { 1, 3, 5, 7 };
        List<int> b = new List<int> { 2, 4, 6, 8, 9};
        List<int> result = MergeAndSort(a, b);
        Console.WriteLine(string.Join(", ", result));

        Console.ReadLine();
    }
}

