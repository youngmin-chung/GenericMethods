## GenericMethods
### Testing Generic/Non-Generic Methods

* Motivation: 
Data with different structures coming from different data sources, needing a special manipulation in memory. Number of items in arrays could not be changed (fixed size)
Type safety (validate types while compiling) - more customized coding.
Non generic classes have performance issues (memory transfer operations between Stack and Heap) - Box / Unboxing

* Syntax
public class Stack<T> {...}
  - T is the type variable
  - Stack<int> myStacck = nennw Stack<int>();
 
* Terminology
  - Why the name Generic? We separate the behaviro from the type allowing more generic behavior descriptions
  - A.k.a "Parametric Polymorphism"
 
* System.collections.generic has "Dictionary<Tkey, Tvalue>", "LinkedList<T>", "List<T>", "Queue<T>", "SortedSet<T>", Stack<T>
