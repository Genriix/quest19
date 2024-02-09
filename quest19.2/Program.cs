using System;

namespace quest19._2
{
    class Program
    {
        static void Main()
        {
            MyList<int> array = new MyList<int>();
            for (int i = 0; i < 5; i++) 
            { 
                array.Add(i + 1);
                Console.WriteLine($"Элемент под индексом [{i}] = " + array[i]);
            }
            Console.WriteLine("Размер коллекции: " + array.Count);
        }
    }
}
