using System;
using System.Collections;
using System.Collections.Generic;

namespace quest19._3
{
    internal class Program
    {
        static void Main()
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "value 1");
            Console.WriteLine(myDictionary[1]);
        }
    }
}
