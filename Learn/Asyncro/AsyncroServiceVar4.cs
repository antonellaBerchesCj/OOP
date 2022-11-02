namespace Learn.Asyncro
{
    public static class AsyncroServiceVar4
    {
        public static readonly string _text = "ss";
        private const int Total = 5;

        static AsyncroServiceVar4() { _text = ""; }

        public static async Task DoWork()
        {
            try
            {
                Method1();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "main");
                throw;
            }
        }

        private static void Method1(int i) // overloading
        {
            throw new Exception();
        }
        private static void Method1()
        {
            try
            {
                Method2();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "m1");
                throw;
            }
        }

        private static void Method2()
        {
            string s = null;
            try
            {
                Console.WriteLine(s[0]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "m2");
                throw;
            }
        }
    }
}
