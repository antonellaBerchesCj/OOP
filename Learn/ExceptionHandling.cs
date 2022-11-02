namespace Learn
{
    /*
     * throw ex; -> rethrow an exception. It will not preserve the original exception and creates a new one. It resets StackTrace and the exact location of the issued error is not known
     * throw; -> da eroare, dar cu F5 merge mai departe. Reissues the error with the same StackTrace as before. Issues exactly the same error as before.
     * 
     * Therefore, it is better to use throw and not to use throw ex as much as possible 
     * because it resets StackTrace and the exact location of the issued error is not known.
     * 
     */
    public class ExceptionHandling
    {
        public ExceptionHandling() { }

        public void DoWork()
        {
            try
            {
                // TryCast produces an unhandled exception.
                TryCast();
            }
            catch (Exception ex)
            {
                // Catch the exception that is unhandled in TryCast.
                Console.WriteLine
                    ("Catching the {0} exception triggers the finally block.",
                    ex.GetType());

                // Restore the original unhandled exception. You might not
                // know what exception to expect, or how to handle it, so pass
                // it on.
                throw;
            }
        }

        public void TryCast()
        {
            int i = 123;
            string s = "Some string";
            object obj = s;

            try
            {
                // Invalid conversion; obj contains a string, not a numeric type.
                i = (int)obj;

                // The following statement is not run.
                Console.WriteLine("WriteLine at the end of the try block.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
            finally
            {
                // Report that the finally block is run, and show that the value of
                // i has not been changed.
                Console.WriteLine("\nIn the finally block in TryCast, i = {0}.\n", i);
            }
        }
    }
}
