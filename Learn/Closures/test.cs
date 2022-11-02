namespace Learn.Closures
{
    public static class Prova
    {
        public delegate void Anto();
        public static void Execute()
        {
            var a = GetDetails();
            a();
        }

        public static Anto GetDetails()
        {
            int x = 0;
            Anto details = delegate { Console.WriteLine(x); };

            x = 1;

            return details;
        }
    }
}
