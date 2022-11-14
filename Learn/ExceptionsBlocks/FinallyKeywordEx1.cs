namespace Learn.ExceptionsBlocks
{
    /*
     * https://www.geeksforgeeks.org/c-sharp-finally-keyword/
     * The finally block will execute when the try/catch block leaves the execution, no matter what condition cause it. 
     * It always executes whether the try block terminates normally or terminates due to an exception. 
     * 
     * The main purpose of finally block is to release the system resources.
     */
    public static class FinallyKeywordEx1
    {
        public static void A()
        {
            try
            {
                Console.WriteLine("Inside A");
                throw new Exception("Throwing Exception");
            }
            finally
            {
                Console.WriteLine("A's finally");
            }
        }

        public static void B()
        {
            try
            {
                Console.WriteLine("Inside B");
                return;
            }
            finally
            {
                Console.WriteLine("B's finally");
            }
        }

        public static void Execute()
        {
            try
            {
                A();
            }
            catch (Exception)
            {
                Console.WriteLine("Exception Caught");
            }

            B();
        }
    }
}
