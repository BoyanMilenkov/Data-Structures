using MoreComplexDataStructures;
using System;

namespace HeapOfNames
{
    class Program
    {
        static void Main(string[] args)
        {
            MaxHeap<string> heap = new MaxHeap<string>();
            heap.Insert("Pesho");
            heap.Insert("Kiro");
            heap.Insert("Asen");
            heap.Insert("Miro");

            while (heap.Count > 0)
            {
                Console.WriteLine(heap.ExtractMax());
            }
        }
    }
}
