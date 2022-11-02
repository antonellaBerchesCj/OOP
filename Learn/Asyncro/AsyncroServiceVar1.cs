namespace Learn.Asyncro
{
    /* 
     * OUTPUT:
     
     *  Pouring coffee
        coffee is ready
        Warming the egg pan...
        cracking 2 eggs
        cooking the eggs ...
        Put eggs on plate

        putting 3 slices of bacon in the pan
        cooking first side of bacon...
        flipping a slice of bacon
        flipping a slice of bacon
        flipping a slice of bacon
        cooking the second side of bacon...
        Put bacon on plate

        Putting a slice of bread in the toaster
        Putting a slice of bread in the toaster
        Start toasting...
        Remove toast from toaster

        Putting butter on the toast
        Putting jam on the toast

        eggs are ready
        bacon is ready
        toast is ready
        Pouring orange juice
        
        oj is ready
        Breakfast is ready!

     */
    public class AsyncroServiceVar1
    {
        public AsyncroServiceVar1() { }

        public async Task DoWork()
        {
            Coffee cup = PourCoffee();
            Console.WriteLine("coffee is ready");

            var eggsTask = FryEggsAsync(2);
            var baconTask = FryBaconAsync(3);
            var toastTask = MakeToastWithButterAndJamAsync(2);

            var eggs = await eggsTask;
            Console.WriteLine("eggs are ready");

            var bacon = await baconTask;
            Console.WriteLine("bacon is ready");

            var toast = await toastTask;
            Console.WriteLine("toast is ready");

            Juice oj = PourOJ();
            Console.WriteLine("oj is ready");
            Console.WriteLine("Breakfast is ready!");
            Console.WriteLine();
        }

        private async Task<Toast> MakeToastWithButterAndJamAsync(int number)
        {
            var toast = await ToastBreadAsync(number);
            ApplyButter(toast);
            ApplyJam(toast);
            Console.WriteLine();

            return toast;
        }

        private async Task<Toast> ToastBreadAsync(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("Putting a slice of bread in the toaster");
            }
            Console.WriteLine("Start toasting...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Remove toast from toaster");
            Console.WriteLine();

            return new Toast();
        }

        private async Task<Bacon> FryBaconAsync(int slices)
        {
            Console.WriteLine($"putting {slices} slices of bacon in the pan");
            Console.WriteLine("cooking first side of bacon...");
            Task.Delay(3000).Wait();
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("flipping a slice of bacon");
            }
            Console.WriteLine("cooking the second side of bacon...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Put bacon on plate");
            Console.WriteLine();

            return new Bacon();
        }

        private async Task<Egg> FryEggsAsync(int howMany)
        {
            Console.WriteLine("Warming the egg pan...");
            Task.Delay(3000).Wait();
            Console.WriteLine($"cracking {howMany} eggs");
            Console.WriteLine("cooking the eggs ...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Put eggs on plate");
            Console.WriteLine();

            return new Egg();
        }

        private Coffee PourCoffee()
        {
            Console.WriteLine("Pouring coffee");
            Console.WriteLine();

            return new Coffee();
        }

        private Juice PourOJ()
        {
            Console.WriteLine("Pouring orange juice");
            Console.WriteLine();

            return new Juice();
        }

        private void ApplyJam(Toast toast) =>
            Console.WriteLine("Putting jam on the toast");

        private void ApplyButter(Toast toast) =>
            Console.WriteLine("Putting butter on the toast");

    }
}
