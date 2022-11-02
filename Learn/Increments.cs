namespace Learn
{
    // diff i++ and ++i

    // So basically ++i returns the value after it is incremented,
    // while i++ return the value before it is incremented.
    //
    // At the end, in both cases the i will have its value incremented.
    public static class Increments
    {
        public static void Execute()
        {
            int i = 0, a;
            Console.WriteLine($"i initial value: {i}");
            a = i++;
            Console.WriteLine($"value returned by i++: {a}, i after: {i}");

            i = 0;
            a = ++i;
            Console.WriteLine($"value returned by ++i: {a}, i after: {i}");
        }
    }
}
