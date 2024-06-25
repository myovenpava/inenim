using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<int> list = new List<int> { 1, 2, 3, 4, 5 };
        list.Reverse();
        foreach (int item in list)
        {
            Console.WriteLine(item);
        }
    }
}
