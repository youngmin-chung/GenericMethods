using System;
using System.Collections.Generic;
using System.Text;

namespace GenericMethods
{
    public class Department
    {
        public string Name { get; set; }

        public Department(string name)
        {
            this.Name = name;
        }

        public string Print()
        {
            return this.Name;
        }
    }
}
