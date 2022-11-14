namespace Learn
{
    /*
     * not sorted and not duplicated elements.
     * provides many mathematical set operations, such as set addition (unions) and set subtraction.
     * 
     * A HashSet<T> is an unordered collection of the unique elements. 
     * It comes under System.Collections.Generic namespace. 
     * It is used in a situation where we want to prevent duplicates from being inserted in the collection. 
     * As far as performance is concerned, it is better in comparison to the list.
     */
    public static class HashSetExamples
    {
        public static void DummyMethod1()
        {
            HashSet<int> odd = new HashSet<int>();

            for (int i = 0; i < 5; i++)
            {
                odd.Add(2 * i + 1);
            }

            foreach (int i in odd)
            {
                Console.Write(i);
            }
            Console.WriteLine($"\ncount: {odd.Count}");
        }

        public static void DummyMethod2()
        {
            HashSet<int> mySet1 = new HashSet<int>();

            // Inserting elements in HashSet mySet1 only contains even numbers <= 10
            for (int i = 1; i <= 5; i++)
                mySet1.Add(2 * i);

            HashSet<int> mySet2 = new HashSet<int>();

            // Inserting elements in HashSet mySet2 contains all numbers from 1 to 10
            for (int i = 1; i <= 10; i++)
                mySet2.Add(i);

            // Check if a HashSet mySet1 is a subset of the HashSet mySet2
            Console.WriteLine(mySet1.IsSubsetOf(mySet2));
        }

        public static void DummyMethod3()
        {
            HashSet<string> mySet = new HashSet<string>();
            
            mySet.Add("DS");
            mySet.Add("C++");
            mySet.Add("Java");
            mySet.Add("JavaScript");

            if (mySet.Contains("Java"))
                Console.WriteLine("Required Element is present");
            else
                Console.WriteLine("Required Element is not present");
        }

    }
}
