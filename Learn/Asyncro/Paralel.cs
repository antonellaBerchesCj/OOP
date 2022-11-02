namespace Learn.Asyncro
{
    // https://www.competit.eu/article/programmazione-asincrona-in-c%23-con-task-e-parallel
    public static class Paralel
    {
        public static void SimpleTask()
        {
            Task task = Task.Run(() =>
            {
                Thread.Sleep(1);
                Console.WriteLine("second");
                return 10000;
            });

            Console.WriteLine("first"); 

            // wait for end of the task's execution
            task.Wait();
            Console.WriteLine("third");
        }

        public static void SimpleTask_ContinueWith()
        {
            var task = Task.Factory.StartNew(() =>
            {
                Thread.Sleep(10);
                Console.WriteLine("second");
                return 5000;
            });

            // using ContinueWith it is possible to handle the return of the first Task
            task = task.ContinueWith((x) =>
            {
                Thread.Sleep(10);
                Console.WriteLine("third");
                return x.Result * 2;
            });

            Console.WriteLine("first");

            // wait for end of the task's execution
            task.Wait();
            Console.WriteLine("forth");
        }

        public static void TaskCancellation()
        {
            var tokenSource = new CancellationTokenSource();
            var token = tokenSource.Token;

            var task = Task.Run(() =>
            {
                for (var i = 1; i < 10; i++)
                {
                    if (token.IsCancellationRequested)
                        break;
                    Thread.Sleep(1000);
                    Console.WriteLine("first..." + i); // *, **, ***
                }
                Console.WriteLine("third - Task executed");
                return 10000;
            }, token);

            // execute some other stuff
            Thread.Sleep(3000);
            Console.WriteLine("second");

            tokenSource.Cancel();
            Console.WriteLine("second - Task Canceled!");
            // then wait for end of the task's execution
            task.Wait();
        }

        public static void SimpleParallelLoops()
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };

            Console.WriteLine("Standard ForEach:");
            list.ForEach(a => Console.WriteLine(a)); // the order is guaranteed

            Console.WriteLine("Parallel ForEach:");
            Parallel.ForEach(list, (a) => Console.WriteLine(a)); // the order is NOT guaranteed!
        }

        public static void SimpleInvoke()
        {
            // the order is NOT guaranteed!
            Parallel.Invoke(
                () => Console.WriteLine(1),
                () => Console.WriteLine(2),
                () => Console.WriteLine(3),
                () => Console.WriteLine(4),
                () => Console.WriteLine(5),
                () => Console.WriteLine(6),
                () => Console.WriteLine(7),
                () => Console.WriteLine(8),
                () => Console.WriteLine(9),
                () => Console.WriteLine(10));
        }

    }
}
