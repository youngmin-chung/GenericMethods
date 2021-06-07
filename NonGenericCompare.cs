using System;
using System.Collections.Generic;
using System.Text;


namespace GenericMethods
{
    public class NonGenericCompare
    {
        // Generic methods
        public T Compare<T>(T a, T b) where T: struct, IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
