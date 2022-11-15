namespace Learn.Asyncro
{
    /*
     * The lock statement is used to take the mutual-exclusion lock for a specified object. 
     * It executes a specified block and then releases the lock.
     * The time during which the lock is active, the thread that holds the lock can again take and release the lock.
     * 
     * Note: any other thread cannot access the lock and it waits unless the lock is released. 
     * Note: await operator cannot be used in the lock statement.
     */
    public static class LockInThread
    {
        // Creating a reference type object
        public static readonly object obj = new object();

        public static void Sample()
        {
            lock (obj)
            {
                Thread.Sleep(20);
                Console.WriteLine(Environment.TickCount);
            }
        }

        /*
         * We are using a for-loop and at each step of the iteration, we are creating a new thread.
         * Here, using the lock keyword we specify a statement block as a critical section by getting 
         * the mutual-exclusion lock for a specified object then executing a statement. 
         * 
         * Now the sleep() method has been used to pause the thread for a specific period of time then 
         * it will release the lock.
         */
        public static void Execute()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);

                // Create a new thread
                ThreadStart begin = new ThreadStart(Sample);

                // Start executing the thread
                new Thread(begin).Start();
            }
        }
    }

    public class IGA
    {
        public int MyProperty { get; set; }
        public int MyProperty2 { get; set; }
        public int MyProperty3 { get; set; }
    }
}
