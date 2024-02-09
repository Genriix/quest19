using System;

namespace quest19._1
{
    class MyClass<T>
    {
        public T field;
        static void FacrotyMethod() { }
    }
    class Program
    {
        static void Main()
        {
            _ = new MyClass<int>();
        }
    }
}
