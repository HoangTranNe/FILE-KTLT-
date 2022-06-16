// See https://aka.ms/new-console-template for more information
using System;
class program
{
    static int Min(int[] a, int left, int right)
    {
        if (left == right)
        {
            return a[left];
        }
        else
        {
            int mid = (left + right) / 2;
            int midL = Min(a, left, mid);
            int midR = Min(a, mid + 1, right);
            return Math.Min(midL, midR);
        }
    }

    static int Max(int[] a, int left, int right)
    {
        if (left == right)
        {
            return a[left];
        }
        else
        {
            int mid = (left + right) / 2;
            int midL = Max(a, left, mid);
            int midR = Max(a, mid + 1, right);
            return Math.Max(midL, midR);
        }
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        var numberlist = Console.ReadLine().Split();
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(numberlist[i]);
        }
        Console.WriteLine(Min(a, 0, n - 1));
        Console.WriteLine(Max(a, 0, n - 1));
    }
}
