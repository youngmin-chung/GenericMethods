using System;
using System.Collections.Generic;
using System.Text;

namespace GenericMethods
{
    public class GenericBaseClass<T> where T : Department
    {
        private T _obj;

        public GenericBaseClass(T obj)
        {
            this._obj = obj;
        }
        
        public void Display()
        {
            System.Console.WriteLine("This passing object is: {0} and it's name is: {1}", typeof(T).Name, _obj.Name);
        }
    }
}
