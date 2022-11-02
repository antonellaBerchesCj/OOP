using System.Diagnostics;

namespace Learn.Asyncro
{
    /* 
     * Task.IsFaulted -> Gets whether the Task completed due to an unhandled exception.
     * Task.Canceled -> Gets whether this Task instance has completed execution due to being canceled.
     */
    public class AsyncroServiceWithErrorHandling
    {
        public AsyncroServiceWithErrorHandling() { }

        public async Task DoWork()
        {
            await Method1();
            Console.ReadKey();
        }

        public async Task Method1()
        {
            //await DoSomethingAsync();
            await Task.Run(() =>
            {
                DoSomethingAsync();
            });
        }

        public async Task DoSomethingAsync()
        {
            Task<string> theTask = DelayAsync();

            try
            {
                string result = await theTask;
                Console.WriteLine("Result: " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Message: " + ex.Message);
            }
            Console.WriteLine("Task IsCanceled: " + theTask.IsCanceled);
            Console.WriteLine("Task IsFaulted:  " + theTask.IsFaulted);
            if (theTask.Exception != null)
            {
                Console.WriteLine("Task Exception Message: " + theTask.Exception.Message);
                Console.WriteLine("Task Inner Exception Message: " + theTask.Exception.InnerException.Message);
            }
        }

        private async Task<string> DelayAsync()
        {
            await Task.Delay(5000);

            // Uncomment each of the following lines to
            // demonstrate exception handling.

            //throw new OperationCanceledException("canceled");
            //throw new Exception("Something happened.");
            return "Done";
        }

    }
}
