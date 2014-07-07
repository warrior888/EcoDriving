using System.Collections.Generic;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> test = new List<int>();

            test.Add(2);
            test.Add(2);
            test.Add(2);
            test.Add(2);
            test.Add(2);

            MyList<int> myTest = new MyList<int>();

            myTest.Add(3);
            myTest.Add(3);
            myTest.Add(3);

        }
    }
}
