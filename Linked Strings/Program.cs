using System;
using System.Collections.Generic;

namespace Linked_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();
            string firstW = Console.ReadLine();
            string secondW = Console.ReadLine();
            string thirdW = Console.ReadLine();
            string fourthW = Console.ReadLine();
            list.AddFirst(firstW);
            list.AddLast(secondW);
            list.AddAfter(list.First, thirdW);
            list.AddBefore(list.Last, fourthW);

            Console.WriteLine(string.Join(", ", list));
        }
    }
}
