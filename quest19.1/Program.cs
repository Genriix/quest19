using System;

namespace quest19._1
{
    partial class Program
    {
        static void Main(string[] args)
        {
            int t = MyClass<int>.FacrotyMethod();
            string s = MyClass<string>.FacrotyMethod();
            Console.WriteLine(s);
        }
    }
}
