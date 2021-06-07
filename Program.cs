using System;

namespace GenericMethods
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Compare with two values using Non-Generic Compare method\n");
            NonGenericCompare nonGenericCompare = new NonGenericCompare();
            Console.WriteLine(nonGenericCompare.Compare<int>(3,5));
            Console.WriteLine("Compare with two values using Generic Compare method\n");
            GenericCompareItems<int> genericCompareItems = new GenericCompareItems<int>();
            Console.WriteLine(genericCompareItems.Compare("Class","Salt"));

            // Working with the base class constraint
            Console.WriteLine("Working with the base class constraint\n");
            Department department = new Department("IT");
            GenericBaseClass<Department> dGenerics = new GenericBaseClass<Department>(department);
            dGenerics.Display();

            // Working with the child class
            Console.WriteLine("Working with the child class\n");
            Course course = new Course("C#");
            GenericBaseClass<Course> cGenerics = new GenericBaseClass<Course>(course);
            cGenerics.Display();
        }
    }
}
