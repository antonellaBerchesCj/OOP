namespace Learn.Closures
{
    /*
     * 
     * closures allow you to encapsulate some behaviour, pass it around like any
     * other object, and still have access to the context in which they were
     * first declared
     * 
     *  closures are a more convenient way to give functions access to local 
     *  state and to pass data into background operations. They are special 
     *  functions that carry an implicit binding to all the nonlocal variables 
     *  (also called free variables or up-values) referenced. 
     *  
     *  The biggest sell for closures is that they can dramatically improve 
     *  code and make it more robust.
     */
    public static class Closures2
    {
        /* 
         * The important distinction is that it is bound to variables, 
         * not to values. In other words, the value of "x" is not copied 
         * in when "a" is declared. Instead, a reference to "x" is used 
         * so that "a" will always use the most recent value of "x". 
         * In fact, this reference to "x" will be persisted even if "x" 
         * goes out of scope.
         */
        public delegate void DavidAction();

        public static void DoWork()
        {
            DavidAction a = GetDetails();

            a(); // output: 1 - because of line 42
        }
        public static DavidAction GetDetails()
        {
            int x = 0;

            DavidAction david = delegate { Console.WriteLine(x); };

            // The rub occurs when the code is changed like this:
            x = 1;

            //david(); // OUTPUT: 1

            // if I delete x=1 from above, I get OUTPUT: 0
            return david;
        }
    }
}
