namespace Learn.ExceptionsBlocks
{
    public static class Exception2
    {
        // Main method
        public static void Execute()
        {
            // This block raises an exception
            try
            {
                byte data = byte.Parse("a");
                Console.WriteLine(data);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("At least provide one Argument!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Entered value in not a number!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Data is out of Range!");
            }
            catch (Exception)
            {
                Console.WriteLine("General exception!");
            }
        }
    }
}
