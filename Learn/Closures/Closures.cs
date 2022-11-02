namespace Learn.Closures
{
    /*
     * https://www.simplethread.com/c-closures-explained/
     * https://web.archive.org/web/20150707082707/http://diditwith.net/PermaLink,guid,235646ae-3476-4893-899d-105e4d48c25b.aspx
     * 
     * Closure = is a function that is bound (legata)to the environment in which it is declared. 
     * Thus, the function can reference elements from the environment within it's body.
     * 
     * 
     * A first class function simply means that it is a function which your 
     * language treats as a first class data type.
     * It means that you can assign a function to a variable, pass it around,
     * and invoke it (delegates):
     * Func<string,string> myFunc = var1 => "some value";
     * sau
     * Func<string,string> myFunc = delegate(string var1)
                                {
                                    return "some value";
                                };
     * string myVar = myFunc("something");
     * 
     * A free variable just happens to be a variable which is referenced in a
     * function which is not a parameter of the function or a local variable 
     * of the function:
     * 
     * var myVar = "this is good";

       Func<string,string> myFunc = delegate(string var1)
                                {
                                    return var1 + myVar;
                                };
     * so the anonymous delegate is referencing a variable that is in its enclosing scope. 
     * That variable isn’t a parameter, and it isn’t a local variable.  
     * 

     */
    public static class Closures
    {
        public static void DoWork()
        {
            var inc = GetAFunc(); // when we return "inc" method, it is a bound inside the delegate
            Console.WriteLine(inc(5));
            Console.WriteLine(inc(6));

            // When we passed back the method, the variable now lives along with the method.
            // Outside of its original scope.
            // You see, it got incremented when we called the method twice
        }

        public static Func<int, int> GetAFunc()
        {
            var inizio = 1; // local variable
            Func<int, int> inc = delegate (int input)
            {
                inizio = inizio + 1;
                return input + inizio;
            };
            return inc;
        }
    }
}
