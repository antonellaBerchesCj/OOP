namespace Learn
{
    public sealed class Singleton1
    {
        // varianta 1
        public static Singleton1 Instance { get; } = new Singleton1(); // global/public access to instance
        private Singleton1() // constructori privati
        {

        }
    }

    public static class Singleton2
    {
        // varianta 2
        // STATIC METHOD care sa returneze ref. la instanta (tipic)
        public static MyOtherClass Instance { get; } = new MyOtherClass(); // unicul acces la clasa
    }

    public class MyOtherClass
    {
        public MyOtherClass()
        {
        }
    }
}
