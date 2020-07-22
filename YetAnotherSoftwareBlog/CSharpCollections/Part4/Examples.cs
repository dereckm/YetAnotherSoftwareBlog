using System;
using System.Collections.Generic;
using System.Text;

namespace YetAnotherSoftwareBlog.CSharpCollections.Part4
{
    internal class Examples
    {
        public void GetNthElementLinkedList()
        {
            var linkedList = new LinkedList<int>();
            linkedList.AddLast(1);
            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddLast(5);
            linkedList.AddLast(8);
            linkedList.AddLast(13);

            const int indexOfItemToGet = 4;
            var currentNode = linkedList.First;
            for (var i = 0; i < indexOfItemToGet; i++)
            {
                currentNode = currentNode.Next;
            }

            // Prints 5
            Console.WriteLine(currentNode.Value);
        }
    }
}
