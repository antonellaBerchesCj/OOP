using System.Diagnostics;

namespace Learn.Asyncro
{
    public static class AsyncTest
    {
        public static async Task AsyncAwait1()
        {
            var a = new AsyncExample();
            var s = new Stopwatch();
            s.Start();
            a.ExecuteSync();
            Console.WriteLine("Sync executed in: " + s.ElapsedMilliseconds);
            s.Reset();

            s.Start();
            //var t = Task.Run(() => a.ExecuteAsync());
            await a.ExecuteAsync();
            //Assert.AreEqual("OneTwo", t.Result);
            Console.WriteLine("Async executed in: " + s.ElapsedMilliseconds);
            s.Reset();
        }
    }

    public class AsyncExample
    {
        public AsyncExample()
        {
        }

        internal string ExecuteSync()
        {
            return Operation1() + Operation2();
        }

        private string Operation2()
        {
            Thread.Sleep(5);
            Console.WriteLine("Two");
            return "Two";
        }

        private string Operation1()
        {
            Thread.Sleep(5);
            Console.WriteLine("One");
            return "One";
        }

        internal async Task<string> ExecuteAsync()
        {
            var o1 = Operation1Async();
            var o2 = Operation2Async();

            var o1Result = await o1;
            var o2Result = await o2;
            Console.WriteLine(o1Result + o2Result);
            return o1Result + o2Result;
        }

        private async Task<string> Operation2Async()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(3);
                Console.WriteLine("Two");
                return "Two";
            });
        }

        private async Task<string> Operation1Async()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(3);
                Console.WriteLine("One");
                return "One";
            });
        }
    }
}
