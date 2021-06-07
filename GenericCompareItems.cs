using System;
using System.Collections.Generic;
using System.Text;

namespace GenericMethods
{
    // T: interface
    // T: class(reference type)
    // T: struct (value type)
    // T: Base class
    // T: new()
    public class GenericCompareItems<T> where T : struct, IComparable
    {
        public T Compare<T>(T a, T b) where T : class, IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }


    }
}
