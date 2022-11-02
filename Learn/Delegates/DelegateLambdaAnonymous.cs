namespace Learn.Delegates
{
    // https://www.competit.eu/article/delegates%2c-anonymous-methods-e-lambda-expressions--facciamo-chiarezza
    public static class DelegateLambdaAnonymous
    {
        private delegate int SomeMethodDelegate(int input);
        public static int SomeMethod(int input)
        {
            return input + 1;
        }

        public static int StandardDelegateTest()
        {
            SomeMethodDelegate f = new SomeMethodDelegate(SomeMethod);
            int y = f(5);

            return y; // 6
        }

        public static int StandardShortDelegateTest()
        {
            SomeMethodDelegate f = SomeMethod;
            int y = f(5);

            return y; // 6
        }

        public static int AnonymousTest()
        {
            SomeMethodDelegate f = delegate (int x) { return x + 1; };
            int y = f(5);

            return y; //6
        }

        public static int AnonymousFuncTest()
        {
            Func<int, int> f = delegate (int x) { return x + 1; };
            int y = f(5);

            return y; //6
        }

        public static int LambdaFuncTest()
        {
            Func<int, int> f = x => { return x + 1; };
            int y = f(5);
            
            return y; //6
        }
    }
}
