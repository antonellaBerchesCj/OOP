namespace Learn.ExceptionsBlocks
{
    /*
     * https://www.geeksforgeeks.org/c-sharp-finally-keyword/
     */
    public static class FinallyKeywordEx2
    {
        public static void Execute()
        {
            // variables
            int number = 4;
            int divisor = 0;

            try
            {
                int output = number / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Not possible to divide by zero!");
            }
            finally
            {
                Console.WriteLine("Finally Block!");
            }
        }

        public static void DummyMethod()
        {
            int number = 4;
            int divisor = 0;
            int output;

            // In this block exception raise
            // Here this exception in unhandled due to the absence of catch block
            try
            {
                output = number / divisor;
            }
            finally
            {
                Console.WriteLine("Finally Block!");
            }
        }
    }
}
