using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace YetAnotherSoftwareBlog.CSharpCollections.Part3
{
    internal class Examples
    {
        public void ListSize()
        {
            var firstList = new List<int>();
            // Prints 4
            Console.WriteLine(firstList.Capacity);
            firstList.AddRange(new [] { 1, 2, 3, 4 });
            // Still prints 4
            Console.WriteLine(firstList.Capacity);
            firstList.AddRange(new [] { 1, 2, 3, 4, 5 });
            // Prints 9!
            Console.WriteLine(firstList.Capacity);

            var secondList = new List<int>();
            // Prints 4
            Console.WriteLine(secondList.Capacity);
            secondList.AddRange(new [] { 1, 2, 3, 4 });
            // Still prints 4
            Console.WriteLine(secondList.Capacity);
            secondList.Add(5);
            // Prints 8!
        }

        public void ListResizePerformance()
        {
            var list = new List<int>();
            var oldCapacity = list.Capacity;
            var capacityChangeCount = 0;
            var totalAllocation = 0;
            var totalCopy = 0;

            for (var i = 0; i < 1000000; i++)
            {
                list.Add(i);

                if (list.Capacity != oldCapacity)
                {
                    totalCopy += oldCapacity;
                    totalAllocation += list.Capacity;
                    oldCapacity = list.Capacity;
                    capacityChangeCount++;
                }
            }

            // Re-allocated 19 times.
            Console.WriteLine($"Total allocation: {totalAllocation * sizeof(int)} bytes.");
            Console.WriteLine($"Total items enumerated: {totalCopy}.");
            Console.WriteLine($"List re-allocated {capacityChangeCount} arrays.");
        }

        public void ArrayIsAList()
        {
            IList<int> array = new [] { 1, 2, 3, 4, 5 };

            // Uh oh..
            array.Insert(0, 3);
        }
    }
}
