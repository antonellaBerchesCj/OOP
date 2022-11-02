namespace Learn.Delegates
{
    public static class Delegates
    {
        delegate void CustomDel(string s);

        // Define two methods that have the same signature as CustomDel.
        static void Hello(string s)
        {
            Console.WriteLine($"  Hello, {s}!");
        }

        static void Goodbye(string s)
        {
            Console.WriteLine($"  Goodbye, {s}!");
        }

        public static void DoWork()
        {
            try
            {
                string filePath = "C:\\Users\\aberches\\test1.txt";
                int task = ReadFile(filePath);
            }
            catch (FileNotFoundException exception)
            {

            }
            catch (IOException exception)
            {

            }
            catch (Exception ex) when (ex is FormatException || ex is OverflowException)
            {

            }
            CustomDel hiDel, byeDel, multiDel, multiMinusHiDel;

            // In this example, you can omit the custom delegate if you
            // want to and use Action<string> instead.
            //Action<string> hiDel, byeDel, multiDel, multiMinusHiDel;

            // Create the delegate object hiDel that references the
            // method Hello.
            hiDel = Hello;

            // Create the delegate object byeDel that references the
            // method Goodbye.
            byeDel = Goodbye;

            // The two delegates, hiDel and byeDel, are combined to
            // form multiDel.
            multiDel = hiDel + byeDel;

            // Remove hiDel from the multicast delegate, leaving byeDel,
            // which calls only the method Goodbye.
            multiMinusHiDel = multiDel - hiDel;

            Console.WriteLine("Invoking delegate hiDel:");
            hiDel("A");
            Console.WriteLine("Invoking delegate byeDel:");
            byeDel("B");
            Console.WriteLine("Invoking delegate multiDel:");
            multiDel("C");
            Console.WriteLine("Invoking delegate multiMinusHiDel:");
            multiMinusHiDel("D");
        }

        public static int ReadFile(string file)
        {
            int length = 0;

            Console.WriteLine(" File reading is stating");
            using (StreamReader reader = new StreamReader(file))
            {
                // Reads all characters from the current position to the end of the stream asynchronously
                // and returns them as one string.
                string s = reader.ReadToEnd();

                length = s.Length;
            }
            Console.WriteLine(" File reading is completed");
            return length;
        }
    }


}
