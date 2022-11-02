namespace Learn.Closures
{
    public static class Closures3
    {
        /* 
         * A closure is when a function is defined inside another function 
         * (or method) and it uses the variables from the parent method. 
         * This use of variables which are located in a method and wrapped 
         * in a function defined within it, is called a closure.
         */
        public static Func<int, int> GetMultiplier()
        {
            var a = 2;
            return delegate (int b) { return a * b; };
        }

        public static void DoWork()
        {
            var fn2 = GetMultiplier();
            Console.WriteLine(fn2(2));  //outputs 4
            Console.WriteLine(fn2(3));  //outputs 6

        }
    }
}
