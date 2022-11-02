using System.Reflection;

namespace Learn
{
    /* 
     * https://www.tutorialspoint.com/difference-between-managed-and-unmanaged-code-in-net
     * 
     * managed code = Applications that are under the control of the CLR.
     * 
     * unmanaged code:
        Applications that are not under the control of the CLR 
        The unsafe code or the unmanaged code is a code block that uses a pointer variable.
        The unsafe modifier allows pointer usage in unmanaged code.

     * The unsafe code or the unmanaged code is a code block that uses a pointer 
     * variable and allows pointer usage in unmanaged code.
     * 
     * The sizeof operator returns a number of bytes that would be allocated by the CLR
     * (common language runtime) in managed memory. 
     * For struct types, that value includes any padding, as the preceding example demonstrates. 
     */
    public static class SizeOf
    {
        //public static int GetSizeOfObject(object obj)
        //{
        //    object value = null;
        //    int size = 0;
        //    Type type = obj.GetType();
        //    PropertyInfo[] info = type.GetProperties();
        //    foreach (PropertyInfo property in info)
        //    {
        //        value = property.GetValue(obj, null);
        //        unsafe
        //        {
        //            size += sizeof(value);
        //        }
        //    }
        //    return size;
        //}

        public static void DoWork()
        {
            Console.WriteLine("byte: " + sizeof(byte));  // output: 1
            Console.WriteLine("double: " + sizeof(double));  // output: 8

            DisplaySizeOf<Point>();  // output: Size of Point is 24
            DisplaySizeOf<decimal>();  // output: Size of System.Decimal is 16

            unsafe
            {
                Console.WriteLine(sizeof(Point*));  // output: 8
            }
        }

        static unsafe void DisplaySizeOf<T>() where T : unmanaged
        {
            Console.WriteLine($"Size of {typeof(T)} is {sizeof(T)}");
        }
    }
    public struct Point
    {
        public Point(byte tag, double x, double y) => (Tag, X, Y) = (tag, x, y);
        public byte Tag { get; }
        public double X { get; }
        public double Y { get; }
    }
}