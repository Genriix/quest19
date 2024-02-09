using System;

namespace quest19._4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> my = new MyList<string>();

            my.Add("the first");
            my.Add("the second");
            my.Add("the third");

            string[] arr = my.GetArray();
            foreach (string item in arr)
                Console.Write($"{item}\n");
        }
    }
}
