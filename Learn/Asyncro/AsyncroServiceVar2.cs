using System.Diagnostics;

namespace Learn.Asyncro
{
    public class AsyncroServiceVar2
    {
        public AsyncroServiceVar2() { }
        public async Task DoWork()
        {
            await Method1();
        }

        public async Task Method1()
        {
            // DoMultipleAsync(); // OUTPUT: nimic!

            //await Task.Run(() =>
            //{
            //    DoMultipleAsync();  // hello, hello, hello -- dupa  await allTasks;
            //});
            await DoMultipleAsync(); // OUTPUT: hello, hello, hello
        }

        public async Task DoMultipleAsync()
        {
            Task theTask1 = ExcAsync(info: "First Task");
            Task theTask2 = ExcAsync(info: "Second Task");
            Task theTask3 = ExcAsync(info: "Third Task");

            Task allTasks = Task.WhenAll(theTask1, theTask2, theTask3);

            try
            {
                await allTasks;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
                Console.WriteLine("Task IsFaulted: " + allTasks.IsFaulted);
                foreach (var inEx in allTasks.Exception.InnerExceptions)
                {
                    Console.WriteLine("Task Inner Exception: " + inEx.Message);
                }
            }
        }

        private async Task ExcAsync(string info)
        {
            await Task.Delay(100);
            Console.WriteLine("hello");
            //throw new Exception("Error-" + info);
        }
    }
}
