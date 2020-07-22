using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace YetAnotherSoftwareBlog.CSharpCollections.Part2
{
    internal class Examples
    {
        public void SynchronizedReadCollection()
        {
            var someCollection = new int[10];

            ICollection myCollection = someCollection;
            lock(myCollection.SyncRoot)
            {
                foreach (object item in myCollection)
                {
                    // Do something with item
                }
            }
        }

        public void ArrayLengthVsCount()
        {
            var array = new int[10];

            var length = array.Length;

            // The following line will not compile
            // var count = array.Count;

            // Magic!
            var count = ((ICollection) array).Count;
        }
    }
}
