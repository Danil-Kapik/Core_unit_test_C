using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] inputArray = { "apple", "cat", "dog", "banana", "car", "uu"};
        List<string> outputList = new List<string>();

        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                outputList.Add(str);
            }
        }
        string[] outputArray = outputList.ToArray();
        Console.WriteLine("[" + string.Join(", ", outputArray) + "]");
    }
}


