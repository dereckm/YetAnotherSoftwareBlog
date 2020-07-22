using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace YetAnotherSoftwareBlog.CSharpCollections.Part1
{
    internal class Examples
    {
        public void ManualEnumeration()
        {
            var enumerable = new[] {1, 1, 2, 3, 5, 8, 13, 21};

            IEnumerator enumerator = enumerable.GetEnumerator();

            try
            {
                while (enumerator.MoveNext())
                {
                    object item = enumerator.Current;
                    // Do something with item
                }
            }
            finally
            {
                // clean up enumerator
            }
        }

        public void ForEachEnumeration()
        {
            var enumerable = new[] {1, 1, 2, 3, 5, 8, 13, 21};

            foreach (var item in enumerable)
            {
                // Do something with item
            }
        }

        public void ForEachCount()
        {
            var enumerable = new[] {1, 1, 2, 3, 5, 8, 13, 21};
            var array = enumerable;

            // Enumerable - O(n)
            int count = 0;
            foreach (var item in enumerable)
            {
                count++;
            }

            // Array - O(1)
            count = array.Length;
        }

        public void ForEachFind()
        {
            var enumerable = new[] {1, 1, 2, 3, 5, 8, 13, 21};
            var hashSet = new HashSet<int>(enumerable);

            const int numberToFind = 13;
            // Enumerable - O(n)
            bool isFound = false;
            int count = 0;
            foreach (var item in enumerable)
            {
                if (item == numberToFind)
                    isFound = true;
            }

            // HashSet - O(1)
            isFound = hashSet.Contains(numberToFind);
        }
    }
}
